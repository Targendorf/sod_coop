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

[System.Serializable]
public class Descriptors : Il2CppSystem.Object
{
	public enum Age
	{
		youngAdult,
		adult,
		old
	}

	public enum BuildType
	{
		skinny,
		average,
		overweight,
		muscular
	}

	public enum Height
	{
		veryShort,
		hShort,
		hAverage,
		tall,
		veryTall
	}

	public enum EthnicGroup
	{
		westEuropean,
		eastEuropean,
		scandinavian,
		mediterranean,
		hispanic,
		african,
		indian,
		chinese,
		japanese,
		korean,
		nativeAmerican,
		middleEastern,
		australian,
		africanAmerican,
		islander,
		northAmerican,
		southAmerican
	}

	[System.Serializable]
	public class EthnicitySetting : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_group;

		private static readonly System.IntPtr NativeFieldInfoPtr_ratio;

		private static readonly System.IntPtr NativeFieldInfoPtr_stats;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_EthnicitySetting_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe EthnicGroup group
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_group);
				return *(EthnicGroup*)num;
			}
			set
			{
				*(EthnicGroup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_group)) = ethnicGroup;
			}
		}

		public unsafe float ratio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ratio);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ratio)) = num;
			}
		}

		public unsafe SocialStatistics.EthnicityStats stats
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stats);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SocialStatistics.EthnicityStats>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stats)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ethnicityStats));
			}
		}

		static EthnicitySetting()
		{
			Il2CppClassPointerStore<EthnicitySetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "EthnicitySetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EthnicitySetting>.NativeClassPtr);
			NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicitySetting>.NativeClassPtr, "group");
			NativeFieldInfoPtr_ratio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicitySetting>.NativeClassPtr, "ratio");
			NativeFieldInfoPtr_stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EthnicitySetting>.NativeClassPtr, "stats");
			NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_EthnicitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EthnicitySetting>.NativeClassPtr, 100664963);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EthnicitySetting>.NativeClassPtr, 100664964);
		}

		[CallerCount(0)]
		public unsafe virtual int CompareTo(EthnicitySetting otherObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherObject);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_EthnicitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EthnicitySetting()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EthnicitySetting>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public EthnicitySetting(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum HairColour
	{
		black,
		brown,
		blonde,
		ginger,
		red,
		blue,
		green,
		purple,
		pink,
		grey,
		white
	}

	public enum HairStyle
	{
		bald,
		shortHair,
		longHair
	}

	public enum EyeColour
	{
		blueEyes,
		brownEyes,
		greenEyes,
		greyEyes
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct FacialFeaturesSetting
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_feature;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		[FieldOffset(0)]
		public FacialFeature feature;

		[FieldOffset(4)]
		public int id;

		static FacialFeaturesSetting()
		{
			Il2CppClassPointerStore<FacialFeaturesSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "FacialFeaturesSetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacialFeaturesSetting>.NativeClassPtr);
			NativeFieldInfoPtr_feature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacialFeaturesSetting>.NativeClassPtr, "feature");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacialFeaturesSetting>.NativeClassPtr, "id");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FacialFeaturesSetting>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public enum FacialFeature
	{
		scaring,
		beard,
		moustache,
		piercing,
		tattoo,
		glasses,
		mole
	}

	[ObfuscatedName("Descriptors+<>c__DisplayClass26_0")]
	public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_newEth;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateEthnicity_b__0_Internal_Boolean_EthnicityStats_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateEthnicity_b__1_Internal_Boolean_EthnicitySetting_0;

		public unsafe EthnicitySetting newEth
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newEth);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EthnicitySetting>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newEth)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ethnicitySetting));
			}
		}

		static __c__DisplayClass26_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "<>c__DisplayClass26_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr);
			NativeFieldInfoPtr_newEth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr, "newEth");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr, 100664965);
			NativeMethodInfoPtr__GenerateEthnicity_b__0_Internal_Boolean_EthnicityStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr, 100664966);
			NativeMethodInfoPtr__GenerateEthnicity_b__1_Internal_Boolean_EthnicitySetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr, 100664967);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass26_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass26_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GenerateEthnicity_b__0(SocialStatistics.EthnicityStats item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateEthnicity_b__0_Internal_Boolean_EthnicityStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _GenerateEthnicity_b__1(EthnicitySetting item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateEthnicity_b__1_Internal_Boolean_EthnicitySetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass26_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_citizen;

	private static readonly System.IntPtr NativeFieldInfoPtr_visualDistinctiveness;

	private static readonly System.IntPtr NativeFieldInfoPtr_build;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightCM;

	private static readonly System.IntPtr NativeFieldInfoPtr_weightKG;

	private static readonly System.IntPtr NativeFieldInfoPtr_shoeSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_footwear;

	private static readonly System.IntPtr NativeFieldInfoPtr_ethnicities;

	private static readonly System.IntPtr NativeFieldInfoPtr_skinColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_hairColourCategory;

	private static readonly System.IntPtr NativeFieldInfoPtr_hairColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_hairType;

	private static readonly System.IntPtr NativeFieldInfoPtr_eyeColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_facialFeatures;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Human_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateEthnicity_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateNameAndSkinColour_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateEyes_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateHair_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateBuild_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateFacialFeatures_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateFootwearPreference_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DescriptorComparison_Public_Static_Single_Descriptors_Descriptors_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GenerateNameAndSkinColour_b__27_0_Private_Boolean_Citizen_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GenerateHair_b__29_0_Private_Boolean_HairSetting_0;

	public unsafe Human citizen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizen);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizen)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
		}
	}

	public unsafe float visualDistinctiveness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visualDistinctiveness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visualDistinctiveness)) = num;
		}
	}

	public unsafe BuildType build
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_build);
			return *(BuildType*)num;
		}
		set
		{
			*(BuildType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_build)) = buildType;
		}
	}

	public unsafe Height height
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height);
			return *(Height*)num;
		}
		set
		{
			*(Height*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height)) = height;
		}
	}

	public unsafe float heightCM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightCM);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heightCM)) = num;
		}
	}

	public unsafe float weightKG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weightKG);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weightKG)) = num;
		}
	}

	public unsafe int shoeSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoeSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoeSize)) = num;
		}
	}

	public unsafe Human.ShoeType footwear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footwear);
			return *(Human.ShoeType*)num;
		}
		set
		{
			*(Human.ShoeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footwear)) = shoeType;
		}
	}

	public unsafe List<EthnicitySetting> ethnicities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicities);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EthnicitySetting>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Color skinColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinColour)) = color;
		}
	}

	public unsafe HairColour hairColourCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairColourCategory);
			return *(HairColour*)num;
		}
		set
		{
			*(HairColour*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairColourCategory)) = hairColour;
		}
	}

	public unsafe Color hairColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairColour)) = color;
		}
	}

	public unsafe HairStyle hairType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairType);
			return *(HairStyle*)num;
		}
		set
		{
			*(HairStyle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairType)) = hairStyle;
		}
	}

	public unsafe EyeColour eyeColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyeColour);
			return *(EyeColour*)num;
		}
		set
		{
			*(EyeColour*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyeColour)) = eyeColour;
		}
	}

	public unsafe List<FacialFeaturesSetting> facialFeatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facialFeatures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FacialFeaturesSetting>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facialFeatures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static Descriptors()
	{
		Il2CppClassPointerStore<Descriptors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Descriptors");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Descriptors>.NativeClassPtr);
		NativeFieldInfoPtr_citizen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "citizen");
		NativeFieldInfoPtr_visualDistinctiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "visualDistinctiveness");
		NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "build");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "height");
		NativeFieldInfoPtr_heightCM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "heightCM");
		NativeFieldInfoPtr_weightKG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "weightKG");
		NativeFieldInfoPtr_shoeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "shoeSize");
		NativeFieldInfoPtr_footwear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "footwear");
		NativeFieldInfoPtr_ethnicities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "ethnicities");
		NativeFieldInfoPtr_skinColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "skinColour");
		NativeFieldInfoPtr_hairColourCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "hairColourCategory");
		NativeFieldInfoPtr_hairColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "hairColour");
		NativeFieldInfoPtr_hairType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "hairType");
		NativeFieldInfoPtr_eyeColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "eyeColour");
		NativeFieldInfoPtr_facialFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, "facialFeatures");
		NativeMethodInfoPtr__ctor_Public_Void_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, 100664952);
		NativeMethodInfoPtr_GenerateEthnicity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, 100664953);
		NativeMethodInfoPtr_GenerateNameAndSkinColour_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, 100664954);
		NativeMethodInfoPtr_GenerateEyes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, 100664955);
		NativeMethodInfoPtr_GenerateHair_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, 100664956);
		NativeMethodInfoPtr_GenerateBuild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, 100664957);
		NativeMethodInfoPtr_GenerateFacialFeatures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, 100664958);
		NativeMethodInfoPtr_GenerateFootwearPreference_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, 100664959);
		NativeMethodInfoPtr_DescriptorComparison_Public_Static_Single_Descriptors_Descriptors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, 100664960);
		NativeMethodInfoPtr__GenerateNameAndSkinColour_b__27_0_Private_Boolean_Citizen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, 100664961);
		NativeMethodInfoPtr__GenerateHair_b__29_0_Private_Boolean_HairSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Descriptors>.NativeClassPtr, 100664962);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 61453, RefRangeEnd = 61455, XrefRangeStart = 61369, XrefRangeEnd = 61453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Descriptors(Human newCitizen)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Descriptors>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newCitizen);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61506, RefRangeEnd = 61507, XrefRangeStart = 61455, XrefRangeEnd = 61506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateEthnicity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateEthnicity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61595, RefRangeEnd = 61596, XrefRangeStart = 61507, XrefRangeEnd = 61595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateNameAndSkinColour()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateNameAndSkinColour_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61631, RefRangeEnd = 61632, XrefRangeStart = 61596, XrefRangeEnd = 61631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateEyes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateEyes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61813, RefRangeEnd = 61814, XrefRangeStart = 61632, XrefRangeEnd = 61813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateHair()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateHair_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61845, RefRangeEnd = 61846, XrefRangeStart = 61814, XrefRangeEnd = 61845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateBuild()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateBuild_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61901, RefRangeEnd = 61902, XrefRangeStart = 61846, XrefRangeEnd = 61901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateFacialFeatures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateFacialFeatures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61937, RefRangeEnd = 61938, XrefRangeStart = 61902, XrefRangeEnd = 61937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateFootwearPreference()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateFootwearPreference_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float DescriptorComparison(Descriptors comp1, Descriptors comp2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DescriptorComparison_Public_Static_Single_Descriptors_Descriptors_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61938, XrefRangeEnd = 61957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _GenerateNameAndSkinColour_b__27_0(Citizen item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateNameAndSkinColour_b__27_0_Private_Boolean_Citizen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _GenerateHair_b__29_0(SocialStatistics.HairSetting item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateHair_b__29_0_Private_Boolean_HairSetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public Descriptors(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
