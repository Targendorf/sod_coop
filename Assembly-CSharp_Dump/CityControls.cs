using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class CityControls : MonoBehaviour
{
	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct WindowColour
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_colourOne;

		private static readonly System.IntPtr NativeFieldInfoPtr_colourTwo;

		[FieldOffset(0)]
		public Color colourOne;

		[FieldOffset(16)]
		public Color colourTwo;

		static WindowColour()
		{
			Il2CppClassPointerStore<WindowColour>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "WindowColour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowColour>.NativeClassPtr);
			NativeFieldInfoPtr_colourOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowColour>.NativeClassPtr, "colourOne");
			NativeFieldInfoPtr_colourTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowColour>.NativeClassPtr, "colourTwo");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindowColour>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	public class NeonMaterial : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_neonColour;

		private static readonly System.IntPtr NativeFieldInfoPtr_altColour2;

		private static readonly System.IntPtr NativeFieldInfoPtr_altColour3;

		private static readonly System.IntPtr NativeFieldInfoPtr_regularMat;

		private static readonly System.IntPtr NativeFieldInfoPtr_flickingMat;

		private static readonly System.IntPtr NativeFieldInfoPtr_flickerAudio;

		private static readonly System.IntPtr NativeFieldInfoPtr_flicker;

		private static readonly System.IntPtr NativeFieldInfoPtr_flickerColourMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr_pulseSpeed;

		private static readonly System.IntPtr NativeFieldInfoPtr_flickerState;

		private static readonly System.IntPtr NativeFieldInfoPtr_flickerSwitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_flickerInterval;

		private static readonly System.IntPtr NativeFieldInfoPtr_interval;

		private static readonly System.IntPtr NativeFieldInfoPtr_intervalTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_brightness;

		private static readonly System.IntPtr NativeFieldInfoPtr_colourTag;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Color neonColour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonColour);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonColour)) = color;
			}
		}

		public unsafe Color altColour2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_altColour2);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_altColour2)) = color;
			}
		}

		public unsafe Color altColour3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_altColour3);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_altColour3)) = color;
			}
		}

		public unsafe Material regularMat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regularMat);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regularMat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
			}
		}

		public unsafe Material flickingMat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickingMat);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickingMat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
			}
		}

		public unsafe AudioEvent flickerAudio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerAudio);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerAudio)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
			}
		}

		public unsafe bool flicker
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flicker);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flicker)) = flag;
			}
		}

		public unsafe float flickerColourMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerColourMultiplier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerColourMultiplier)) = num;
			}
		}

		public unsafe float pulseSpeed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulseSpeed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulseSpeed)) = num;
			}
		}

		public unsafe float flickerState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerState);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerState)) = num;
			}
		}

		public unsafe bool flickerSwitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerSwitch);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerSwitch)) = flag;
			}
		}

		public unsafe bool flickerInterval
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerInterval);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flickerInterval)) = flag;
			}
		}

		public unsafe float interval
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interval);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interval)) = num;
			}
		}

		public unsafe float intervalTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalTime)) = num;
			}
		}

		public unsafe float brightness
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brightness);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brightness)) = num;
			}
		}

		public unsafe string colourTag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourTag);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourTag)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static NeonMaterial()
		{
			Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "NeonMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr);
			NativeFieldInfoPtr_neonColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "neonColour");
			NativeFieldInfoPtr_altColour2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "altColour2");
			NativeFieldInfoPtr_altColour3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "altColour3");
			NativeFieldInfoPtr_regularMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "regularMat");
			NativeFieldInfoPtr_flickingMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "flickingMat");
			NativeFieldInfoPtr_flickerAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "flickerAudio");
			NativeFieldInfoPtr_flicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "flicker");
			NativeFieldInfoPtr_flickerColourMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "flickerColourMultiplier");
			NativeFieldInfoPtr_pulseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "pulseSpeed");
			NativeFieldInfoPtr_flickerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "flickerState");
			NativeFieldInfoPtr_flickerSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "flickerSwitch");
			NativeFieldInfoPtr_flickerInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "flickerInterval");
			NativeFieldInfoPtr_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "interval");
			NativeFieldInfoPtr_intervalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "intervalTime");
			NativeFieldInfoPtr_brightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "brightness");
			NativeFieldInfoPtr_colourTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, "colourTag");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr, 100674082);
		}

		[CallerCount(0)]
		public unsafe NeonMaterial()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NeonMaterial>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public NeonMaterial(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class CitySize : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_size;

		private static readonly System.IntPtr NativeFieldInfoPtr_v2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Size size
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
				return *(Size*)num;
			}
			set
			{
				*(Size*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = size;
			}
		}

		public unsafe Vector2 v2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v2);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_v2)) = vector;
			}
		}

		static CitySize()
		{
			Il2CppClassPointerStore<CitySize>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "CitySize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CitySize>.NativeClassPtr);
			NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySize>.NativeClassPtr, "size");
			NativeFieldInfoPtr_v2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitySize>.NativeClassPtr, "v2");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitySize>.NativeClassPtr, 100674083);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CitySize()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CitySize>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CitySize(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum Size
	{
		small,
		medium,
		large,
		veryLarge
	}

	[System.Serializable]
	public class PPProfile : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_profile;

		private static readonly System.IntPtr NativeFieldInfoPtr_volume;

		private static readonly System.IntPtr NativeFieldInfoPtr_objectRef;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe SessionData.SceneProfile profile
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_profile);
				return *(SessionData.SceneProfile*)num;
			}
			set
			{
				*(SessionData.SceneProfile*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_profile)) = sceneProfile;
			}
		}

		public unsafe Volume volume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volume);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Volume>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_volume)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)volume));
			}
		}

		public unsafe GameObject objectRef
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectRef);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectRef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		static PPProfile()
		{
			Il2CppClassPointerStore<PPProfile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "PPProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PPProfile>.NativeClassPtr);
			NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PPProfile>.NativeClassPtr, "profile");
			NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PPProfile>.NativeClassPtr, "volume");
			NativeFieldInfoPtr_objectRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PPProfile>.NativeClassPtr, "objectRef");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PPProfile>.NativeClassPtr, 100674084);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PPProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PPProfile>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public PPProfile(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class StreetCable : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_prefab;

		private static readonly System.IntPtr NativeFieldInfoPtr_maximumWidth;

		private static readonly System.IntPtr NativeFieldInfoPtr_frequency;

		private static readonly System.IntPtr NativeFieldInfoPtr_maximumCableAngle;

		private static readonly System.IntPtr NativeFieldInfoPtr_minimumHeight;

		private static readonly System.IntPtr NativeFieldInfoPtr_maximumHeight;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyFromZoneType;

		private static readonly System.IntPtr NativeFieldInfoPtr_zone;

		private static readonly System.IntPtr NativeFieldInfoPtr_disitrctFrequencyModifier;

		private static readonly System.IntPtr NativeFieldInfoPtr_districts;

		private static readonly System.IntPtr NativeFieldInfoPtr_frequencyModifier;

		private static readonly System.IntPtr NativeFieldInfoPtr_alterAreaLighting;

		private static readonly System.IntPtr NativeFieldInfoPtr_possibleColours;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightOperation;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightAmount;

		private static readonly System.IntPtr NativeFieldInfoPtr_brightnessModifier;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe GameObject prefab
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe float maximumWidth
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumWidth);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumWidth)) = num;
			}
		}

		public unsafe int frequency
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency)) = num;
			}
		}

		public unsafe float maximumCableAngle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumCableAngle);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumCableAngle)) = num;
			}
		}

		public unsafe float minimumHeight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumHeight);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumHeight)) = num;
			}
		}

		public unsafe float maximumHeight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumHeight);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumHeight)) = num;
			}
		}

		public unsafe bool onlyFromZoneType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyFromZoneType);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyFromZoneType)) = flag;
			}
		}

		public unsafe BuildingPreset.ZoneType zone
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zone);
				return *(BuildingPreset.ZoneType*)num;
			}
			set
			{
				*(BuildingPreset.ZoneType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zone)) = zoneType;
			}
		}

		public unsafe bool disitrctFrequencyModifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disitrctFrequencyModifier);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disitrctFrequencyModifier)) = flag;
			}
		}

		public unsafe List<DistrictPreset> districts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districts);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DistrictPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int frequencyModifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyModifier);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequencyModifier)) = num;
			}
		}

		public unsafe bool alterAreaLighting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alterAreaLighting);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alterAreaLighting)) = flag;
			}
		}

		public unsafe List<Color> possibleColours
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleColours);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Color>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleColours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe DistrictPreset.AffectStreetAreaLights lightOperation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOperation);
				return *(DistrictPreset.AffectStreetAreaLights*)num;
			}
			set
			{
				*(DistrictPreset.AffectStreetAreaLights*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOperation)) = affectStreetAreaLights;
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

		static StreetCable()
		{
			Il2CppClassPointerStore<StreetCable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "StreetCable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreetCable>.NativeClassPtr);
			NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "prefab");
			NativeFieldInfoPtr_maximumWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "maximumWidth");
			NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "frequency");
			NativeFieldInfoPtr_maximumCableAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "maximumCableAngle");
			NativeFieldInfoPtr_minimumHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "minimumHeight");
			NativeFieldInfoPtr_maximumHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "maximumHeight");
			NativeFieldInfoPtr_onlyFromZoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "onlyFromZoneType");
			NativeFieldInfoPtr_zone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "zone");
			NativeFieldInfoPtr_disitrctFrequencyModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "disitrctFrequencyModifier");
			NativeFieldInfoPtr_districts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "districts");
			NativeFieldInfoPtr_frequencyModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "frequencyModifier");
			NativeFieldInfoPtr_alterAreaLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "alterAreaLighting");
			NativeFieldInfoPtr_possibleColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "possibleColours");
			NativeFieldInfoPtr_lightOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "lightOperation");
			NativeFieldInfoPtr_lightAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "lightAmount");
			NativeFieldInfoPtr_brightnessModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, "brightnessModifier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreetCable>.NativeClassPtr, 100674085);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330908, XrefRangeEnd = 330919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreetCable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreetCable>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public StreetCable(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_wardName;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityCustoms;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityCustomsAbr;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityTax;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityTaxAbr;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityCurrency;

	private static readonly System.IntPtr NativeFieldInfoPtr_citySizes;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityTileSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxBlockSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockExpandChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_blockExpandCentreMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_nonFavouredExpandMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_districtSizeMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_districtSizeMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_sideAlleyChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_sideAlleyExtentionChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_overheadStreet;

	private static readonly System.IntPtr NativeFieldInfoPtr_travelTimeCrowFliesMultiplierEstimate;

	private static readonly System.IntPtr NativeFieldInfoPtr_travelTimeMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_homelessMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_residentialRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_commercialRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_industrialRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_municipalRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_parksRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_lobbyPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_smallUnitRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_mediumUnitRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_lageUnitRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultWalls;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultFloorMaterialGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultCeilingMaterialGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultWallMaterialGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_nullDefaultRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_streetRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_alleyRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_backstreetRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_outsideLayoutConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_lobbyLayoutConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_street;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowestFloor;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowestFloorLightMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowestFloorIncreaseFlickerChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_basementWaterLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_fallbackStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_fallbackColourScheme;

	private static readonly System.IntPtr NativeFieldInfoPtr_fallbackFloorMat;

	private static readonly System.IntPtr NativeFieldInfoPtr_fallbackWallMat;

	private static readonly System.IntPtr NativeFieldInfoPtr_fallbackCeilingMat;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_hdrpLightSunData;

	private static readonly System.IntPtr NativeFieldInfoPtr_exteriorAmbientLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_exteriorAmbientHDRP;

	private static readonly System.IntPtr NativeFieldInfoPtr_interiorAmbientLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_interiorAmbientHDRP;

	private static readonly System.IntPtr NativeFieldInfoPtr_seaMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_seaRenderer;

	private static readonly System.IntPtr NativeFieldInfoPtr_skylineMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_skylineRenderers;

	private static readonly System.IntPtr NativeFieldInfoPtr_smokeMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_echelonDesignStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_echelonWood;

	private static readonly System.IntPtr NativeFieldInfoPtr_echelonFloorMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_echelonFloorVariation;

	private static readonly System.IntPtr NativeFieldInfoPtr_echelonCeilingMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_echelonCeilingVariation;

	private static readonly System.IntPtr NativeFieldInfoPtr_echelonDefaultWallMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_echelonWallVariation;

	private static readonly System.IntPtr NativeFieldInfoPtr_echelonColourScheme;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneProfileSetup;

	private static readonly System.IntPtr NativeFieldInfoPtr_captureSceneNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_captureSceneCCTV;

	private static readonly System.IntPtr NativeFieldInfoPtr_ships1;

	private static readonly System.IntPtr NativeFieldInfoPtr_angleOfSun;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightsOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightsOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_alleyBlockWallPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_weatherSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeForCityToGetWet;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeForCityToGetDry;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeForCityToGetSnow;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeForCityToGetNotSnow;

	private static readonly System.IntPtr NativeFieldInfoPtr_neonMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_neonIntensity;

	private static readonly System.IntPtr NativeFieldInfoPtr_neonColours;

	private static readonly System.IntPtr NativeFieldInfoPtr_cables;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumCableAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_park;

	private static readonly System.IntPtr NativeFieldInfoPtr_hotelCostLower;

	private static readonly System.IntPtr NativeFieldInfoPtr_hotelCostUpper;

	private static readonly System.IntPtr NativeFieldInfoPtr_kickoutTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_basementWaterTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_lostAndFoundNote;

	private static readonly System.IntPtr NativeFieldInfoPtr_lostAndFoundItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_dividerCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_dividerLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_dividerRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobNote;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_CityControls_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string wardName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wardName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wardName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string cityCustoms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityCustoms);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityCustoms)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string cityCustomsAbr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityCustomsAbr);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityCustomsAbr)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string cityTax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityTax);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityTax)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string cityTaxAbr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityTaxAbr);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityTaxAbr)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string cityCurrency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityCurrency);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityCurrency)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<CitySize> citySizes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySizes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CitySize>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySizes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Vector3 cityTileSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityTileSize);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityTileSize)) = vector;
		}
	}

	public unsafe int tileMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileMultiplier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileMultiplier)) = num;
		}
	}

	public unsafe int nodeMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeMultiplier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeMultiplier)) = num;
		}
	}

	public unsafe int maxBlockSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBlockSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBlockSize)) = num;
		}
	}

	public unsafe float blockExpandChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockExpandChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockExpandChance)) = num;
		}
	}

	public unsafe float blockExpandCentreMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockExpandCentreMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockExpandCentreMultiplier)) = num;
		}
	}

	public unsafe float nonFavouredExpandMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonFavouredExpandMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonFavouredExpandMultiplier)) = num;
		}
	}

	public unsafe int districtSizeMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districtSizeMin);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districtSizeMin)) = num;
		}
	}

	public unsafe int districtSizeMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districtSizeMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districtSizeMax)) = num;
		}
	}

	public unsafe float sideAlleyChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideAlleyChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideAlleyChance)) = num;
		}
	}

	public unsafe float sideAlleyExtentionChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideAlleyExtentionChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sideAlleyExtentionChance)) = num;
		}
	}

	public unsafe bool overheadStreet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overheadStreet);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overheadStreet)) = flag;
		}
	}

	public unsafe float travelTimeCrowFliesMultiplierEstimate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelTimeCrowFliesMultiplierEstimate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelTimeCrowFliesMultiplierEstimate)) = num;
		}
	}

	public unsafe float travelTimeMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelTimeMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_travelTimeMultiplier)) = num;
		}
	}

	public unsafe float homelessMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homelessMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homelessMultiplier)) = num;
		}
	}

	public unsafe float residentialRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_residentialRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_residentialRatio)) = num;
		}
	}

	public unsafe float commercialRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commercialRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commercialRatio)) = num;
		}
	}

	public unsafe float industrialRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_industrialRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_industrialRatio)) = num;
		}
	}

	public unsafe float municipalRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_municipalRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_municipalRatio)) = num;
		}
	}

	public unsafe float parksRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parksRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parksRatio)) = num;
		}
	}

	public unsafe AddressPreset lobbyPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lobbyPreset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AddressPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lobbyPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)addressPreset));
		}
	}

	public unsafe Vector2 smallUnitRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallUnitRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallUnitRange)) = vector;
		}
	}

	public unsafe Vector2 mediumUnitRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumUnitRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumUnitRange)) = vector;
		}
	}

	public unsafe Vector2 lageUnitRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lageUnitRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lageUnitRange)) = vector;
		}
	}

	public unsafe DesignStylePreset defaultStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultStyle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DesignStylePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultStyle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)designStylePreset));
		}
	}

	public unsafe DoorPairPreset defaultWalls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWalls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoorPairPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWalls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPairPreset));
		}
	}

	public unsafe MaterialGroupPreset defaultFloorMaterialGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultFloorMaterialGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultFloorMaterialGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
		}
	}

	public unsafe MaterialGroupPreset defaultCeilingMaterialGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultCeilingMaterialGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultCeilingMaterialGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
		}
	}

	public unsafe MaterialGroupPreset defaultWallMaterialGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWallMaterialGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWallMaterialGroup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
		}
	}

	public unsafe RoomConfiguration nullDefaultRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nullDefaultRoom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoomConfiguration>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nullDefaultRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomConfiguration));
		}
	}

	public unsafe RoomConfiguration streetRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetRoom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoomConfiguration>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streetRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomConfiguration));
		}
	}

	public unsafe RoomConfiguration alleyRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alleyRoom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoomConfiguration>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alleyRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomConfiguration));
		}
	}

	public unsafe RoomConfiguration backstreetRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backstreetRoom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoomConfiguration>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backstreetRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)roomConfiguration));
		}
	}

	public unsafe LayoutConfiguration outsideLayoutConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideLayoutConfig);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutConfiguration>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsideLayoutConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutConfiguration));
		}
	}

	public unsafe LayoutConfiguration lobbyLayoutConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lobbyLayoutConfig);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutConfiguration>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lobbyLayoutConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutConfiguration));
		}
	}

	public unsafe DesignStylePreset street
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_street);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DesignStylePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_street)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)designStylePreset));
		}
	}

	public unsafe int lowestFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowestFloor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowestFloor)) = num;
		}
	}

	public unsafe float lowestFloorLightMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowestFloorLightMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowestFloorLightMultiplier)) = num;
		}
	}

	public unsafe float lowestFloorIncreaseFlickerChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowestFloorIncreaseFlickerChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowestFloorIncreaseFlickerChance)) = num;
		}
	}

	public unsafe float basementWaterLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basementWaterLevel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basementWaterLevel)) = num;
		}
	}

	public unsafe DesignStylePreset fallbackStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackStyle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DesignStylePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackStyle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)designStylePreset));
		}
	}

	public unsafe ColourSchemePreset fallbackColourScheme
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackColourScheme);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ColourSchemePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackColourScheme)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colourSchemePreset));
		}
	}

	public unsafe MaterialGroupPreset fallbackFloorMat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackFloorMat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackFloorMat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
		}
	}

	public unsafe MaterialGroupPreset fallbackWallMat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackWallMat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackWallMat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
		}
	}

	public unsafe MaterialGroupPreset fallbackCeilingMat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackCeilingMat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackCeilingMat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
		}
	}

	public unsafe Light sunLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunLight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunLight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light));
		}
	}

	public unsafe Transform sunPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunPosition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe HDAdditionalLightData hdrpLightSunData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hdrpLightSunData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HDAdditionalLightData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hdrpLightSunData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hDAdditionalLightData));
		}
	}

	public unsafe Light exteriorAmbientLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorAmbientLight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorAmbientLight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light));
		}
	}

	public unsafe HDAdditionalLightData exteriorAmbientHDRP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorAmbientHDRP);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HDAdditionalLightData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exteriorAmbientHDRP)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hDAdditionalLightData));
		}
	}

	public unsafe Light interiorAmbientLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorAmbientLight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorAmbientLight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light));
		}
	}

	public unsafe HDAdditionalLightData interiorAmbientHDRP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorAmbientHDRP);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HDAdditionalLightData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interiorAmbientHDRP)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hDAdditionalLightData));
		}
	}

	public unsafe Material seaMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe MeshRenderer seaRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaRenderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seaRenderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer));
		}
	}

	public unsafe Material skylineMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skylineMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skylineMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe List<MeshRenderer> skylineRenderers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skylineRenderers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skylineRenderers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Material smokeMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smokeMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smokeMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe DesignStylePreset echelonDesignStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonDesignStyle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DesignStylePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonDesignStyle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)designStylePreset));
		}
	}

	public unsafe Color echelonWood
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonWood);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonWood)) = color;
		}
	}

	public unsafe MaterialGroupPreset echelonFloorMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonFloorMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonFloorMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
		}
	}

	public unsafe MaterialGroupPreset.MaterialVariation echelonFloorVariation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonFloorVariation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset.MaterialVariation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonFloorVariation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialVariation));
		}
	}

	public unsafe MaterialGroupPreset echelonCeilingMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonCeilingMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonCeilingMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
		}
	}

	public unsafe MaterialGroupPreset.MaterialVariation echelonCeilingVariation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonCeilingVariation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset.MaterialVariation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonCeilingVariation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialVariation));
		}
	}

	public unsafe MaterialGroupPreset echelonDefaultWallMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonDefaultWallMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonDefaultWallMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
		}
	}

	public unsafe MaterialGroupPreset.MaterialVariation echelonWallVariation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonWallVariation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset.MaterialVariation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonWallVariation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialVariation));
		}
	}

	public unsafe ColourSchemePreset echelonColourScheme
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonColourScheme);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ColourSchemePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echelonColourScheme)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colourSchemePreset));
		}
	}

	public unsafe List<PPProfile> sceneProfileSetup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneProfileSetup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PPProfile>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneProfileSetup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe PPProfile captureSceneNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureSceneNormal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PPProfile>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureSceneNormal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pPProfile));
		}
	}

	public unsafe PPProfile captureSceneCCTV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureSceneCCTV);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PPProfile>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureSceneCCTV)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pPProfile));
		}
	}

	public unsafe Transform ships1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ships1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ships1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe float angleOfSun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angleOfSun);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angleOfSun)) = num;
		}
	}

	public unsafe Vector2 lightsOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightsOff);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightsOff)) = vector;
		}
	}

	public unsafe Vector2 lightsOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightsOn);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightsOn)) = vector;
		}
	}

	public unsafe DoorPairPreset alleyBlockWallPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alleyBlockWallPreset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoorPairPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alleyBlockWallPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPairPreset));
		}
	}

	public unsafe FogPreset weatherSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FogPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fogPreset));
		}
	}

	public unsafe float timeForCityToGetWet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeForCityToGetWet);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeForCityToGetWet)) = num;
		}
	}

	public unsafe float timeForCityToGetDry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeForCityToGetDry);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeForCityToGetDry)) = num;
		}
	}

	public unsafe float timeForCityToGetSnow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeForCityToGetSnow);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeForCityToGetSnow)) = num;
		}
	}

	public unsafe float timeForCityToGetNotSnow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeForCityToGetNotSnow);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeForCityToGetNotSnow)) = num;
		}
	}

	public unsafe Material neonMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe float neonIntensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonIntensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonIntensity)) = num;
		}
	}

	public unsafe List<NeonMaterial> neonColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonColours);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NeonMaterial>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neonColours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<StreetCable> cables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cables);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StreetCable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float maximumCableAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumCableAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumCableAngle)) = num;
		}
	}

	public unsafe LayoutConfiguration park
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_park);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LayoutConfiguration>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_park)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layoutConfiguration));
		}
	}

	public unsafe int hotelCostLower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hotelCostLower);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hotelCostLower)) = num;
		}
	}

	public unsafe int hotelCostUpper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hotelCostUpper);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hotelCostUpper)) = num;
		}
	}

	public unsafe float kickoutTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kickoutTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kickoutTime)) = num;
		}
	}

	public unsafe Transform basementWaterTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basementWaterTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basementWaterTransform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe InteractablePreset lostAndFoundNote
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lostAndFoundNote);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lostAndFoundNote)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe List<InteractablePreset> lostAndFoundItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lostAndFoundItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lostAndFoundItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe DoorPairPreset dividerCenter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dividerCenter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoorPairPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dividerCenter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPairPreset));
		}
	}

	public unsafe DoorPairPreset dividerLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dividerLeft);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoorPairPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dividerLeft)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPairPreset));
		}
	}

	public unsafe DoorPairPreset dividerRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dividerRight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoorPairPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dividerRight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPairPreset));
		}
	}

	public unsafe InteractablePreset jobNote
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobNote);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobNote)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe static CityControls _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CityControls>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cityControls));
		}
	}

	public unsafe static CityControls Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330919, XrefRangeEnd = 330921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_CityControls_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CityControls>(intPtr) : null;
		}
	}

	static CityControls()
	{
		Il2CppClassPointerStore<CityControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CityControls");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CityControls>.NativeClassPtr);
		NativeFieldInfoPtr_wardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "wardName");
		NativeFieldInfoPtr_cityCustoms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "cityCustoms");
		NativeFieldInfoPtr_cityCustomsAbr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "cityCustomsAbr");
		NativeFieldInfoPtr_cityTax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "cityTax");
		NativeFieldInfoPtr_cityTaxAbr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "cityTaxAbr");
		NativeFieldInfoPtr_cityCurrency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "cityCurrency");
		NativeFieldInfoPtr_citySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "citySizes");
		NativeFieldInfoPtr_cityTileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "cityTileSize");
		NativeFieldInfoPtr_tileMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "tileMultiplier");
		NativeFieldInfoPtr_nodeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "nodeMultiplier");
		NativeFieldInfoPtr_maxBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "maxBlockSize");
		NativeFieldInfoPtr_blockExpandChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "blockExpandChance");
		NativeFieldInfoPtr_blockExpandCentreMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "blockExpandCentreMultiplier");
		NativeFieldInfoPtr_nonFavouredExpandMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "nonFavouredExpandMultiplier");
		NativeFieldInfoPtr_districtSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "districtSizeMin");
		NativeFieldInfoPtr_districtSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "districtSizeMax");
		NativeFieldInfoPtr_sideAlleyChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "sideAlleyChance");
		NativeFieldInfoPtr_sideAlleyExtentionChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "sideAlleyExtentionChance");
		NativeFieldInfoPtr_overheadStreet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "overheadStreet");
		NativeFieldInfoPtr_travelTimeCrowFliesMultiplierEstimate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "travelTimeCrowFliesMultiplierEstimate");
		NativeFieldInfoPtr_travelTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "travelTimeMultiplier");
		NativeFieldInfoPtr_homelessMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "homelessMultiplier");
		NativeFieldInfoPtr_residentialRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "residentialRatio");
		NativeFieldInfoPtr_commercialRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "commercialRatio");
		NativeFieldInfoPtr_industrialRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "industrialRatio");
		NativeFieldInfoPtr_municipalRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "municipalRatio");
		NativeFieldInfoPtr_parksRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "parksRatio");
		NativeFieldInfoPtr_lobbyPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "lobbyPreset");
		NativeFieldInfoPtr_smallUnitRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "smallUnitRange");
		NativeFieldInfoPtr_mediumUnitRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "mediumUnitRange");
		NativeFieldInfoPtr_lageUnitRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "lageUnitRange");
		NativeFieldInfoPtr_defaultStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "defaultStyle");
		NativeFieldInfoPtr_defaultWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "defaultWalls");
		NativeFieldInfoPtr_defaultFloorMaterialGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "defaultFloorMaterialGroup");
		NativeFieldInfoPtr_defaultCeilingMaterialGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "defaultCeilingMaterialGroup");
		NativeFieldInfoPtr_defaultWallMaterialGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "defaultWallMaterialGroup");
		NativeFieldInfoPtr_nullDefaultRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "nullDefaultRoom");
		NativeFieldInfoPtr_streetRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "streetRoom");
		NativeFieldInfoPtr_alleyRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "alleyRoom");
		NativeFieldInfoPtr_backstreetRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "backstreetRoom");
		NativeFieldInfoPtr_outsideLayoutConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "outsideLayoutConfig");
		NativeFieldInfoPtr_lobbyLayoutConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "lobbyLayoutConfig");
		NativeFieldInfoPtr_street = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "street");
		NativeFieldInfoPtr_lowestFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "lowestFloor");
		NativeFieldInfoPtr_lowestFloorLightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "lowestFloorLightMultiplier");
		NativeFieldInfoPtr_lowestFloorIncreaseFlickerChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "lowestFloorIncreaseFlickerChance");
		NativeFieldInfoPtr_basementWaterLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "basementWaterLevel");
		NativeFieldInfoPtr_fallbackStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "fallbackStyle");
		NativeFieldInfoPtr_fallbackColourScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "fallbackColourScheme");
		NativeFieldInfoPtr_fallbackFloorMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "fallbackFloorMat");
		NativeFieldInfoPtr_fallbackWallMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "fallbackWallMat");
		NativeFieldInfoPtr_fallbackCeilingMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "fallbackCeilingMat");
		NativeFieldInfoPtr_sunLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "sunLight");
		NativeFieldInfoPtr_sunPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "sunPosition");
		NativeFieldInfoPtr_hdrpLightSunData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "hdrpLightSunData");
		NativeFieldInfoPtr_exteriorAmbientLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "exteriorAmbientLight");
		NativeFieldInfoPtr_exteriorAmbientHDRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "exteriorAmbientHDRP");
		NativeFieldInfoPtr_interiorAmbientLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "interiorAmbientLight");
		NativeFieldInfoPtr_interiorAmbientHDRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "interiorAmbientHDRP");
		NativeFieldInfoPtr_seaMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "seaMaterial");
		NativeFieldInfoPtr_seaRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "seaRenderer");
		NativeFieldInfoPtr_skylineMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "skylineMaterial");
		NativeFieldInfoPtr_skylineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "skylineRenderers");
		NativeFieldInfoPtr_smokeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "smokeMaterial");
		NativeFieldInfoPtr_echelonDesignStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "echelonDesignStyle");
		NativeFieldInfoPtr_echelonWood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "echelonWood");
		NativeFieldInfoPtr_echelonFloorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "echelonFloorMaterial");
		NativeFieldInfoPtr_echelonFloorVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "echelonFloorVariation");
		NativeFieldInfoPtr_echelonCeilingMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "echelonCeilingMaterial");
		NativeFieldInfoPtr_echelonCeilingVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "echelonCeilingVariation");
		NativeFieldInfoPtr_echelonDefaultWallMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "echelonDefaultWallMaterial");
		NativeFieldInfoPtr_echelonWallVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "echelonWallVariation");
		NativeFieldInfoPtr_echelonColourScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "echelonColourScheme");
		NativeFieldInfoPtr_sceneProfileSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "sceneProfileSetup");
		NativeFieldInfoPtr_captureSceneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "captureSceneNormal");
		NativeFieldInfoPtr_captureSceneCCTV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "captureSceneCCTV");
		NativeFieldInfoPtr_ships1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "ships1");
		NativeFieldInfoPtr_angleOfSun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "angleOfSun");
		NativeFieldInfoPtr_lightsOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "lightsOff");
		NativeFieldInfoPtr_lightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "lightsOn");
		NativeFieldInfoPtr_alleyBlockWallPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "alleyBlockWallPreset");
		NativeFieldInfoPtr_weatherSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "weatherSettings");
		NativeFieldInfoPtr_timeForCityToGetWet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "timeForCityToGetWet");
		NativeFieldInfoPtr_timeForCityToGetDry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "timeForCityToGetDry");
		NativeFieldInfoPtr_timeForCityToGetSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "timeForCityToGetSnow");
		NativeFieldInfoPtr_timeForCityToGetNotSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "timeForCityToGetNotSnow");
		NativeFieldInfoPtr_neonMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "neonMaterial");
		NativeFieldInfoPtr_neonIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "neonIntensity");
		NativeFieldInfoPtr_neonColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "neonColours");
		NativeFieldInfoPtr_cables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "cables");
		NativeFieldInfoPtr_maximumCableAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "maximumCableAngle");
		NativeFieldInfoPtr_park = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "park");
		NativeFieldInfoPtr_hotelCostLower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "hotelCostLower");
		NativeFieldInfoPtr_hotelCostUpper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "hotelCostUpper");
		NativeFieldInfoPtr_kickoutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "kickoutTime");
		NativeFieldInfoPtr_basementWaterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "basementWaterTransform");
		NativeFieldInfoPtr_lostAndFoundNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "lostAndFoundNote");
		NativeFieldInfoPtr_lostAndFoundItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "lostAndFoundItems");
		NativeFieldInfoPtr_dividerCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "dividerCenter");
		NativeFieldInfoPtr_dividerLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "dividerLeft");
		NativeFieldInfoPtr_dividerRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "dividerRight");
		NativeFieldInfoPtr_jobNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "jobNote");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CityControls>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_CityControls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityControls>.NativeClassPtr, 100674078);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityControls>.NativeClassPtr, 100674079);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityControls>.NativeClassPtr, 100674080);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CityControls>.NativeClassPtr, 100674081);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330921, XrefRangeEnd = 330961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330961, XrefRangeEnd = 331018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331018, XrefRangeEnd = 331076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CityControls()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CityControls>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CityControls(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
