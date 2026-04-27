using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class SocialStatistics : MonoBehaviour
{
	[System.Serializable]
	public class EthnicityFrequency : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ethnicity;

		private static readonly System.IntPtr NativeFieldInfoPtr_frequency;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_EthnicityFrequency_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Descriptors.EthnicGroup ethnicity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicity);
				return *(Descriptors.EthnicGroup*)num;
			}
			set
			{
				*(Descriptors.EthnicGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicity)) = ethnicGroup;
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

		static EthnicityFrequency()
		{
			Il2CppClassPointerStore<EthnicityFrequency>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "EthnicityFrequency");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EthnicityFrequency>.NativeClassPtr);
			NativeFieldInfoPtr_ethnicity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityFrequency>.NativeClassPtr, "ethnicity");
			NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityFrequency>.NativeClassPtr, "frequency");
			NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_EthnicityFrequency_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EthnicityFrequency>.NativeClassPtr, 100674138);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EthnicityFrequency>.NativeClassPtr, 100674139);
		}

		[CallerCount(0)]
		public unsafe virtual int CompareTo(EthnicityFrequency otherObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherObject);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_EthnicityFrequency_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EthnicityFrequency()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EthnicityFrequency>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public EthnicityFrequency(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class HairSetting : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_colour;

		private static readonly System.IntPtr NativeFieldInfoPtr_hairColourRange1;

		private static readonly System.IntPtr NativeFieldInfoPtr_hairColourRange2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Descriptors.HairColour colour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour);
				return *(Descriptors.HairColour*)num;
			}
			set
			{
				*(Descriptors.HairColour*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour)) = hairColour;
			}
		}

		public unsafe Color hairColourRange1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairColourRange1);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairColourRange1)) = color;
			}
		}

		public unsafe Color hairColourRange2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairColourRange2);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairColourRange2)) = color;
			}
		}

		static HairSetting()
		{
			Il2CppClassPointerStore<HairSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "HairSetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HairSetting>.NativeClassPtr);
			NativeFieldInfoPtr_colour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HairSetting>.NativeClassPtr, "colour");
			NativeFieldInfoPtr_hairColourRange1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HairSetting>.NativeClassPtr, "hairColourRange1");
			NativeFieldInfoPtr_hairColourRange2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HairSetting>.NativeClassPtr, "hairColourRange2");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HairSetting>.NativeClassPtr, 100674140);
		}

		[CallerCount(0)]
		public unsafe HairSetting()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HairSetting>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public HairSetting(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class EthnicityStats : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_group;

		private static readonly System.IntPtr NativeFieldInfoPtr_skinColourRange1;

		private static readonly System.IntPtr NativeFieldInfoPtr_skinColourRange2;

		private static readonly System.IntPtr NativeFieldInfoPtr_blackHairRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_brownHairRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_blondeHairRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_gingerHairRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_RedHairRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_blueHairRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_greenHairRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_purpleHairRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_pinkHairRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_greyHairRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_whiteHairRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_baldHairRatioMale;

		private static readonly System.IntPtr NativeFieldInfoPtr_shortHairRatioMale;

		private static readonly System.IntPtr NativeFieldInfoPtr_longHairRatioMale;

		private static readonly System.IntPtr NativeFieldInfoPtr_baldHairRatioFemale;

		private static readonly System.IntPtr NativeFieldInfoPtr_shortHairRatioFemale;

		private static readonly System.IntPtr NativeFieldInfoPtr_longHairRatioFemale;

		private static readonly System.IntPtr NativeFieldInfoPtr_straightHairRatioMale;

		private static readonly System.IntPtr NativeFieldInfoPtr_curlyHairRatioMale;

		private static readonly System.IntPtr NativeFieldInfoPtr_balingHairRatioMale;

		private static readonly System.IntPtr NativeFieldInfoPtr_messyHairRatioMale;

		private static readonly System.IntPtr NativeFieldInfoPtr_styledHairRatioMale;

		private static readonly System.IntPtr NativeFieldInfoPtr_mohawkHairRatioMale;

		private static readonly System.IntPtr NativeFieldInfoPtr_afroHairRatioMale;

		private static readonly System.IntPtr NativeFieldInfoPtr_straightHairRatioFemale;

		private static readonly System.IntPtr NativeFieldInfoPtr_curlyHairRatioFemale;

		private static readonly System.IntPtr NativeFieldInfoPtr_balingHairRatioFemale;

		private static readonly System.IntPtr NativeFieldInfoPtr_messyHairRatioFemale;

		private static readonly System.IntPtr NativeFieldInfoPtr_styledHairRatioFemale;

		private static readonly System.IntPtr NativeFieldInfoPtr_mohawkHairRatioFemale;

		private static readonly System.IntPtr NativeFieldInfoPtr_afroHairRatioFemale;

		private static readonly System.IntPtr NativeFieldInfoPtr_blueEyesRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_brownEyesRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_greenEyesRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_greyEyesRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_overrideFirst;

		private static readonly System.IntPtr NativeFieldInfoPtr_overrideNameFirst;

		private static readonly System.IntPtr NativeFieldInfoPtr_overrideSur;

		private static readonly System.IntPtr NativeFieldInfoPtr_overrideNameSur;

		private static readonly System.IntPtr NativeFieldInfoPtr_culturalSimilarities;

		private static readonly System.IntPtr NativeFieldInfoPtr_ethTraits;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Descriptors.EthnicGroup group
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_group);
				return *(Descriptors.EthnicGroup*)num;
			}
			set
			{
				*(Descriptors.EthnicGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_group)) = ethnicGroup;
			}
		}

		public unsafe Color skinColourRange1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinColourRange1);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinColourRange1)) = color;
			}
		}

		public unsafe Color skinColourRange2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinColourRange2);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinColourRange2)) = color;
			}
		}

		public unsafe int blackHairRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackHairRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackHairRatio)) = num;
			}
		}

		public unsafe int brownHairRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brownHairRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brownHairRatio)) = num;
			}
		}

		public unsafe int blondeHairRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blondeHairRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blondeHairRatio)) = num;
			}
		}

		public unsafe int gingerHairRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gingerHairRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gingerHairRatio)) = num;
			}
		}

		public unsafe int RedHairRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RedHairRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RedHairRatio)) = num;
			}
		}

		public unsafe int blueHairRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueHairRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueHairRatio)) = num;
			}
		}

		public unsafe int greenHairRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenHairRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenHairRatio)) = num;
			}
		}

		public unsafe int purpleHairRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpleHairRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpleHairRatio)) = num;
			}
		}

		public unsafe int pinkHairRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinkHairRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinkHairRatio)) = num;
			}
		}

		public unsafe int greyHairRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greyHairRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greyHairRatio)) = num;
			}
		}

		public unsafe int whiteHairRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_whiteHairRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_whiteHairRatio)) = num;
			}
		}

		public unsafe int baldHairRatioMale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baldHairRatioMale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baldHairRatioMale)) = num;
			}
		}

		public unsafe int shortHairRatioMale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortHairRatioMale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortHairRatioMale)) = num;
			}
		}

		public unsafe int longHairRatioMale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longHairRatioMale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longHairRatioMale)) = num;
			}
		}

		public unsafe int baldHairRatioFemale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baldHairRatioFemale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baldHairRatioFemale)) = num;
			}
		}

		public unsafe int shortHairRatioFemale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortHairRatioFemale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortHairRatioFemale)) = num;
			}
		}

		public unsafe int longHairRatioFemale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longHairRatioFemale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longHairRatioFemale)) = num;
			}
		}

		public unsafe int straightHairRatioMale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_straightHairRatioMale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_straightHairRatioMale)) = num;
			}
		}

		public unsafe int curlyHairRatioMale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curlyHairRatioMale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curlyHairRatioMale)) = num;
			}
		}

		public unsafe int balingHairRatioMale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_balingHairRatioMale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_balingHairRatioMale)) = num;
			}
		}

		public unsafe int messyHairRatioMale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messyHairRatioMale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messyHairRatioMale)) = num;
			}
		}

		public unsafe int styledHairRatioMale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styledHairRatioMale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styledHairRatioMale)) = num;
			}
		}

		public unsafe int mohawkHairRatioMale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mohawkHairRatioMale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mohawkHairRatioMale)) = num;
			}
		}

		public unsafe int afroHairRatioMale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_afroHairRatioMale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_afroHairRatioMale)) = num;
			}
		}

		public unsafe int straightHairRatioFemale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_straightHairRatioFemale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_straightHairRatioFemale)) = num;
			}
		}

		public unsafe int curlyHairRatioFemale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curlyHairRatioFemale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curlyHairRatioFemale)) = num;
			}
		}

		public unsafe int balingHairRatioFemale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_balingHairRatioFemale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_balingHairRatioFemale)) = num;
			}
		}

		public unsafe int messyHairRatioFemale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messyHairRatioFemale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messyHairRatioFemale)) = num;
			}
		}

		public unsafe int styledHairRatioFemale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styledHairRatioFemale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styledHairRatioFemale)) = num;
			}
		}

		public unsafe int mohawkHairRatioFemale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mohawkHairRatioFemale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mohawkHairRatioFemale)) = num;
			}
		}

		public unsafe int afroHairRatioFemale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_afroHairRatioFemale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_afroHairRatioFemale)) = num;
			}
		}

		public unsafe int blueEyesRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueEyesRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueEyesRatio)) = num;
			}
		}

		public unsafe int brownEyesRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brownEyesRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brownEyesRatio)) = num;
			}
		}

		public unsafe int greenEyesRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenEyesRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenEyesRatio)) = num;
			}
		}

		public unsafe int greyEyesRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greyEyesRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greyEyesRatio)) = num;
			}
		}

		public unsafe bool overrideFirst
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideFirst);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideFirst)) = flag;
			}
		}

		public unsafe Descriptors.EthnicGroup overrideNameFirst
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideNameFirst);
				return *(Descriptors.EthnicGroup*)num;
			}
			set
			{
				*(Descriptors.EthnicGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideNameFirst)) = ethnicGroup;
			}
		}

		public unsafe bool overrideSur
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideSur);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideSur)) = flag;
			}
		}

		public unsafe Descriptors.EthnicGroup overrideNameSur
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideNameSur);
				return *(Descriptors.EthnicGroup*)num;
			}
			set
			{
				*(Descriptors.EthnicGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideNameSur)) = ethnicGroup;
			}
		}

		public unsafe List<Descriptors.EthnicGroup> culturalSimilarities
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_culturalSimilarities);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Descriptors.EthnicGroup>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_culturalSimilarities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<CharacterTrait> ethTraits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethTraits);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static EthnicityStats()
		{
			Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "EthnicityStats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr);
			NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "group");
			NativeFieldInfoPtr_skinColourRange1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "skinColourRange1");
			NativeFieldInfoPtr_skinColourRange2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "skinColourRange2");
			NativeFieldInfoPtr_blackHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "blackHairRatio");
			NativeFieldInfoPtr_brownHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "brownHairRatio");
			NativeFieldInfoPtr_blondeHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "blondeHairRatio");
			NativeFieldInfoPtr_gingerHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "gingerHairRatio");
			NativeFieldInfoPtr_RedHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "RedHairRatio");
			NativeFieldInfoPtr_blueHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "blueHairRatio");
			NativeFieldInfoPtr_greenHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "greenHairRatio");
			NativeFieldInfoPtr_purpleHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "purpleHairRatio");
			NativeFieldInfoPtr_pinkHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "pinkHairRatio");
			NativeFieldInfoPtr_greyHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "greyHairRatio");
			NativeFieldInfoPtr_whiteHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "whiteHairRatio");
			NativeFieldInfoPtr_baldHairRatioMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "baldHairRatioMale");
			NativeFieldInfoPtr_shortHairRatioMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "shortHairRatioMale");
			NativeFieldInfoPtr_longHairRatioMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "longHairRatioMale");
			NativeFieldInfoPtr_baldHairRatioFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "baldHairRatioFemale");
			NativeFieldInfoPtr_shortHairRatioFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "shortHairRatioFemale");
			NativeFieldInfoPtr_longHairRatioFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "longHairRatioFemale");
			NativeFieldInfoPtr_straightHairRatioMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "straightHairRatioMale");
			NativeFieldInfoPtr_curlyHairRatioMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "curlyHairRatioMale");
			NativeFieldInfoPtr_balingHairRatioMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "balingHairRatioMale");
			NativeFieldInfoPtr_messyHairRatioMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "messyHairRatioMale");
			NativeFieldInfoPtr_styledHairRatioMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "styledHairRatioMale");
			NativeFieldInfoPtr_mohawkHairRatioMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "mohawkHairRatioMale");
			NativeFieldInfoPtr_afroHairRatioMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "afroHairRatioMale");
			NativeFieldInfoPtr_straightHairRatioFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "straightHairRatioFemale");
			NativeFieldInfoPtr_curlyHairRatioFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "curlyHairRatioFemale");
			NativeFieldInfoPtr_balingHairRatioFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "balingHairRatioFemale");
			NativeFieldInfoPtr_messyHairRatioFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "messyHairRatioFemale");
			NativeFieldInfoPtr_styledHairRatioFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "styledHairRatioFemale");
			NativeFieldInfoPtr_mohawkHairRatioFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "mohawkHairRatioFemale");
			NativeFieldInfoPtr_afroHairRatioFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "afroHairRatioFemale");
			NativeFieldInfoPtr_blueEyesRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "blueEyesRatio");
			NativeFieldInfoPtr_brownEyesRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "brownEyesRatio");
			NativeFieldInfoPtr_greenEyesRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "greenEyesRatio");
			NativeFieldInfoPtr_greyEyesRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "greyEyesRatio");
			NativeFieldInfoPtr_overrideFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "overrideFirst");
			NativeFieldInfoPtr_overrideNameFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "overrideNameFirst");
			NativeFieldInfoPtr_overrideSur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "overrideSur");
			NativeFieldInfoPtr_overrideNameSur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "overrideNameSur");
			NativeFieldInfoPtr_culturalSimilarities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "culturalSimilarities");
			NativeFieldInfoPtr_ethTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, "ethTraits");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr, 100674141);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331962, XrefRangeEnd = 331974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EthnicityStats()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EthnicityStats>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public EthnicityStats(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_genderNonBinaryThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_transThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_sexualityStraightThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_sexualityGayThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_asexualChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_maleTrait;

	private static readonly System.IntPtr NativeFieldInfoPtr_femaleTrait;

	private static readonly System.IntPtr NativeFieldInfoPtr_nbTrait;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttractedToMaleTrait;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttractedToFemaleTrait;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttractedToNBTrait;

	private static readonly System.IntPtr NativeFieldInfoPtr_relationshipTrait;

	private static readonly System.IntPtr NativeFieldInfoPtr_lipstickColours;

	private static readonly System.IntPtr NativeFieldInfoPtr_ageRanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_ethnicityFrequencies;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOf2ndEthnicity;

	private static readonly System.IntPtr NativeFieldInfoPtr_districtEthnictiyDominanceMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_ethnicityStats;

	private static readonly System.IntPtr NativeFieldInfoPtr_averageHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_averageWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightMinMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_skinnyRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_averageRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_overweightRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_muscleyRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloodOPosRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloodAPosRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloodBPosRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloodONegRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloodANegRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloodABPosRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloodBNegRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloodABNegRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_hairColourSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_RedHairRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_blueHairRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_greenHairRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_purpleHairRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_pinkHairRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaringRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_menWithBeards;

	private static readonly System.IntPtr NativeFieldInfoPtr_menWithMoustaches;

	private static readonly System.IntPtr NativeFieldInfoPtr_piercingRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_TattooRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_glassesRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_moleRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_frecklesRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_seriousRelationshipsRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangGreetingDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangGreetingMale;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangGreetingFemale;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangGreetingLover;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangCurse;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangCurseNoun;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangPraiseNoun;

	private static readonly System.IntPtr NativeFieldInfoPtr_favouriteColoursPool;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_SocialStatistics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float genderNonBinaryThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genderNonBinaryThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genderNonBinaryThreshold)) = num;
		}
	}

	public unsafe float transThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transThreshold)) = num;
		}
	}

	public unsafe float sexualityStraightThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sexualityStraightThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sexualityStraightThreshold)) = num;
		}
	}

	public unsafe float sexualityGayThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sexualityGayThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sexualityGayThreshold)) = num;
		}
	}

	public unsafe float asexualChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_asexualChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_asexualChance)) = num;
		}
	}

	public unsafe CharacterTrait maleTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleTrait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait femaleTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleTrait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait nbTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nbTrait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nbTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait AttractedToMaleTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttractedToMaleTrait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttractedToMaleTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait AttractedToFemaleTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttractedToFemaleTrait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttractedToFemaleTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait AttractedToNBTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttractedToNBTrait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttractedToNBTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait relationshipTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relationshipTrait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relationshipTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe List<Color> lipstickColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lipstickColours);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Color>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lipstickColours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Il2CppStructArray<int> ageRanges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ageRanges);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ageRanges)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe List<EthnicityFrequency> ethnicityFrequencies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicityFrequencies);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EthnicityFrequency>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicityFrequencies)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int chanceOf2ndEthnicity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOf2ndEthnicity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOf2ndEthnicity)) = num;
		}
	}

	public unsafe float districtEthnictiyDominanceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districtEthnictiyDominanceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_districtEthnictiyDominanceMultiplier)) = num;
		}
	}

	public unsafe List<EthnicityStats> ethnicityStats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicityStats);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EthnicityStats>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicityStats)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float averageHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageHeight)) = num;
		}
	}

	public unsafe float averageWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageWeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageWeight)) = num;
		}
	}

	public unsafe Vector2 heightMinMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightMinMax);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightMinMax)) = vector;
		}
	}

	public unsafe int skinnyRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinnyRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinnyRatio)) = num;
		}
	}

	public unsafe int averageRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_averageRatio)) = num;
		}
	}

	public unsafe int overweightRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overweightRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overweightRatio)) = num;
		}
	}

	public unsafe int muscleyRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muscleyRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muscleyRatio)) = num;
		}
	}

	public unsafe float bloodOPosRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodOPosRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodOPosRatio)) = num;
		}
	}

	public unsafe float bloodAPosRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodAPosRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodAPosRatio)) = num;
		}
	}

	public unsafe float bloodBPosRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodBPosRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodBPosRatio)) = num;
		}
	}

	public unsafe float bloodONegRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodONegRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodONegRatio)) = num;
		}
	}

	public unsafe float bloodANegRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodANegRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodANegRatio)) = num;
		}
	}

	public unsafe float bloodABPosRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodABPosRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodABPosRatio)) = num;
		}
	}

	public unsafe float bloodBNegRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodBNegRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodBNegRatio)) = num;
		}
	}

	public unsafe float bloodABNegRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodABNegRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodABNegRatio)) = num;
		}
	}

	public unsafe List<HairSetting> hairColourSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairColourSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HairSetting>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairColourSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int RedHairRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RedHairRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RedHairRatio)) = num;
		}
	}

	public unsafe int blueHairRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueHairRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blueHairRatio)) = num;
		}
	}

	public unsafe int greenHairRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenHairRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenHairRatio)) = num;
		}
	}

	public unsafe int purpleHairRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpleHairRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpleHairRatio)) = num;
		}
	}

	public unsafe int pinkHairRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinkHairRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinkHairRatio)) = num;
		}
	}

	public unsafe int scaringRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaringRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaringRatio)) = num;
		}
	}

	public unsafe int menWithBeards
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menWithBeards);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menWithBeards)) = num;
		}
	}

	public unsafe int menWithMoustaches
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menWithMoustaches);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menWithMoustaches)) = num;
		}
	}

	public unsafe int piercingRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_piercingRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_piercingRatio)) = num;
		}
	}

	public unsafe int TattooRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooRatio)) = num;
		}
	}

	public unsafe int glassesRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glassesRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glassesRatio)) = num;
		}
	}

	public unsafe int moleRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moleRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moleRatio)) = num;
		}
	}

	public unsafe int frecklesRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frecklesRatio);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frecklesRatio)) = num;
		}
	}

	public unsafe float seriousRelationshipsRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seriousRelationshipsRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seriousRelationshipsRatio)) = num;
		}
	}

	public unsafe List<string> slangGreetingDefault
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingDefault);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingDefault)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> slangGreetingMale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingMale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingMale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> slangGreetingFemale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingFemale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingFemale)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> slangGreetingLover
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingLover);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangGreetingLover)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> slangCurse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangCurse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangCurse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> slangCurseNoun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangCurseNoun);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangCurseNoun)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> slangPraiseNoun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangPraiseNoun);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangPraiseNoun)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Color> favouriteColoursPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favouriteColoursPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Color>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favouriteColoursPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static SocialStatistics _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SocialStatistics>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)socialStatistics));
		}
	}

	public unsafe static SocialStatistics Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331974, XrefRangeEnd = 331976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_SocialStatistics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SocialStatistics>(intPtr) : null;
		}
	}

	static SocialStatistics()
	{
		Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SocialStatistics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr);
		NativeFieldInfoPtr_genderNonBinaryThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "genderNonBinaryThreshold");
		NativeFieldInfoPtr_transThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "transThreshold");
		NativeFieldInfoPtr_sexualityStraightThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "sexualityStraightThreshold");
		NativeFieldInfoPtr_sexualityGayThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "sexualityGayThreshold");
		NativeFieldInfoPtr_asexualChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "asexualChance");
		NativeFieldInfoPtr_maleTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "maleTrait");
		NativeFieldInfoPtr_femaleTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "femaleTrait");
		NativeFieldInfoPtr_nbTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "nbTrait");
		NativeFieldInfoPtr_AttractedToMaleTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "AttractedToMaleTrait");
		NativeFieldInfoPtr_AttractedToFemaleTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "AttractedToFemaleTrait");
		NativeFieldInfoPtr_AttractedToNBTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "AttractedToNBTrait");
		NativeFieldInfoPtr_relationshipTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "relationshipTrait");
		NativeFieldInfoPtr_lipstickColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "lipstickColours");
		NativeFieldInfoPtr_ageRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "ageRanges");
		NativeFieldInfoPtr_ethnicityFrequencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "ethnicityFrequencies");
		NativeFieldInfoPtr_chanceOf2ndEthnicity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "chanceOf2ndEthnicity");
		NativeFieldInfoPtr_districtEthnictiyDominanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "districtEthnictiyDominanceMultiplier");
		NativeFieldInfoPtr_ethnicityStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "ethnicityStats");
		NativeFieldInfoPtr_averageHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "averageHeight");
		NativeFieldInfoPtr_averageWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "averageWeight");
		NativeFieldInfoPtr_heightMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "heightMinMax");
		NativeFieldInfoPtr_skinnyRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "skinnyRatio");
		NativeFieldInfoPtr_averageRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "averageRatio");
		NativeFieldInfoPtr_overweightRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "overweightRatio");
		NativeFieldInfoPtr_muscleyRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "muscleyRatio");
		NativeFieldInfoPtr_bloodOPosRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "bloodOPosRatio");
		NativeFieldInfoPtr_bloodAPosRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "bloodAPosRatio");
		NativeFieldInfoPtr_bloodBPosRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "bloodBPosRatio");
		NativeFieldInfoPtr_bloodONegRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "bloodONegRatio");
		NativeFieldInfoPtr_bloodANegRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "bloodANegRatio");
		NativeFieldInfoPtr_bloodABPosRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "bloodABPosRatio");
		NativeFieldInfoPtr_bloodBNegRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "bloodBNegRatio");
		NativeFieldInfoPtr_bloodABNegRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "bloodABNegRatio");
		NativeFieldInfoPtr_hairColourSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "hairColourSettings");
		NativeFieldInfoPtr_RedHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "RedHairRatio");
		NativeFieldInfoPtr_blueHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "blueHairRatio");
		NativeFieldInfoPtr_greenHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "greenHairRatio");
		NativeFieldInfoPtr_purpleHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "purpleHairRatio");
		NativeFieldInfoPtr_pinkHairRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "pinkHairRatio");
		NativeFieldInfoPtr_scaringRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "scaringRatio");
		NativeFieldInfoPtr_menWithBeards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "menWithBeards");
		NativeFieldInfoPtr_menWithMoustaches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "menWithMoustaches");
		NativeFieldInfoPtr_piercingRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "piercingRatio");
		NativeFieldInfoPtr_TattooRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "TattooRatio");
		NativeFieldInfoPtr_glassesRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "glassesRatio");
		NativeFieldInfoPtr_moleRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "moleRatio");
		NativeFieldInfoPtr_frecklesRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "frecklesRatio");
		NativeFieldInfoPtr_seriousRelationshipsRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "seriousRelationshipsRatio");
		NativeFieldInfoPtr_slangGreetingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "slangGreetingDefault");
		NativeFieldInfoPtr_slangGreetingMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "slangGreetingMale");
		NativeFieldInfoPtr_slangGreetingFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "slangGreetingFemale");
		NativeFieldInfoPtr_slangGreetingLover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "slangGreetingLover");
		NativeFieldInfoPtr_slangCurse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "slangCurse");
		NativeFieldInfoPtr_slangCurseNoun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "slangCurseNoun");
		NativeFieldInfoPtr_slangPraiseNoun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "slangPraiseNoun");
		NativeFieldInfoPtr_favouriteColoursPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "favouriteColoursPool");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_SocialStatistics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, 100674134);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, 100674135);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, 100674136);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr, 100674137);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331976, XrefRangeEnd = 332013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332013, XrefRangeEnd = 332034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332034, XrefRangeEnd = 332071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SocialStatistics()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocialStatistics>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SocialStatistics(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
