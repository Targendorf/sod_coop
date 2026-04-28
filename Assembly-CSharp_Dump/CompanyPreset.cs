using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class CompanyPreset : SoCustomComparison
{
	public enum CompanyCategory
	{
		meal,
		snack,
		caffeine,
		groceries,
		washing,
		medical,
		recreational,
		retail
	}

	public enum SalaryRange
	{
		illegal,
		minimumWage,
		low,
		average,
		aboveAverage,
		high,
		veryHigh,
		extreme,
		millionaire
	}

	public enum NameComponent
	{
		prefix,
		main,
		suffix
	}

	[System.Serializable]
	public class TheRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_component;

		private static readonly System.IntPtr NativeFieldInfoPtr_exists;

		private static readonly System.IntPtr NativeFieldInfoPtr_chanceModifier;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe NameComponent component
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_component);
				return *(NameComponent*)num;
			}
			set
			{
				*(NameComponent*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_component)) = nameComponent;
			}
		}

		public unsafe bool exists
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exists);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exists)) = flag;
			}
		}

		public unsafe float chanceModifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceModifier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceModifier)) = num;
			}
		}

		static TheRule()
		{
			Il2CppClassPointerStore<TheRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "TheRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TheRule>.NativeClassPtr);
			NativeFieldInfoPtr_component = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheRule>.NativeClassPtr, "component");
			NativeFieldInfoPtr_exists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheRule>.NativeClassPtr, "exists");
			NativeFieldInfoPtr_chanceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TheRule>.NativeClassPtr, "chanceModifier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TheRule>.NativeClassPtr, 100673857);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TheRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TheRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TheRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_companyCategories;

	private static readonly System.IntPtr NativeFieldInfoPtr_createMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_isIllegal;

	private static readonly System.IntPtr NativeFieldInfoPtr_useBuildingName;

	private static readonly System.IntPtr NativeFieldInfoPtr_useBuildingOverrideName;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideSuffixList;

	private static readonly System.IntPtr NativeFieldInfoPtr_useStreetNameChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_useDistrictNameChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_useOwnerFirstNameChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_useOwnerSurNameChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCompanyNameListChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_aliterationWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefixChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_prefixList;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainNamingList;

	private static readonly System.IntPtr NativeFieldInfoPtr_suffixList;

	private static readonly System.IntPtr NativeFieldInfoPtr_theRules;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumSalary;

	private static readonly System.IntPtr NativeFieldInfoPtr_topSalary;

	private static readonly System.IntPtr NativeFieldInfoPtr_payGradeCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_publicFacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSelfEmployed;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoCreate;

	private static readonly System.IntPtr NativeFieldInfoPtr_priority;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityPopRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableLoiteringBehaviour;

	private static readonly System.IntPtr NativeFieldInfoPtr_menus;

	private static readonly System.IntPtr NativeFieldInfoPtr_recordSalesData;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousFakeSalesRecords;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiredTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableSelling;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableSellingOfIllegalItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_sellValueMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_possibleUniformColours;

	private static readonly System.IntPtr NativeFieldInfoPtr_workHours;

	private static readonly System.IntPtr NativeFieldInfoPtr_structure;

	private static readonly System.IntPtr NativeFieldInfoPtr_controlsBuildingSurveillance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHotel;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<CompanyCategory> companyCategories
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companyCategories);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CompanyCategory>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companyCategories)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool createMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createMenu);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createMenu)) = flag;
		}
	}

	public unsafe bool isIllegal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isIllegal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isIllegal)) = flag;
		}
	}

	public unsafe bool useBuildingName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBuildingName);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBuildingName)) = flag;
		}
	}

	public unsafe bool useBuildingOverrideName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBuildingOverrideName);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBuildingOverrideName)) = flag;
		}
	}

	public unsafe List<string> overrideSuffixList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideSuffixList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideSuffixList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float useStreetNameChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useStreetNameChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useStreetNameChance)) = num;
		}
	}

	public unsafe float useDistrictNameChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDistrictNameChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDistrictNameChance)) = num;
		}
	}

	public unsafe float useOwnerFirstNameChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnerFirstNameChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnerFirstNameChance)) = num;
		}
	}

	public unsafe float useOwnerSurNameChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnerSurNameChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOwnerSurNameChance)) = num;
		}
	}

	public unsafe float useCompanyNameListChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCompanyNameListChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCompanyNameListChance)) = num;
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

	public unsafe float prefixChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefixChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefixChance)) = num;
		}
	}

	public unsafe List<string> prefixList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefixList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefixList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainNamingList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> suffixList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suffixList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suffixList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<TheRule> theRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_theRules);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TheRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_theRules)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe SalaryRange minimumSalary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumSalary);
			return *(SalaryRange*)num;
		}
		set
		{
			*(SalaryRange*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumSalary)) = salaryRange;
		}
	}

	public unsafe SalaryRange topSalary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topSalary);
			return *(SalaryRange*)num;
		}
		set
		{
			*(SalaryRange*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_topSalary)) = salaryRange;
		}
	}

	public unsafe AnimationCurve payGradeCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_payGradeCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_payGradeCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe bool publicFacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publicFacing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publicFacing)) = flag;
		}
	}

	public unsafe bool isSelfEmployed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSelfEmployed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSelfEmployed)) = flag;
		}
	}

	public unsafe bool autoCreate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoCreate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoCreate)) = flag;
		}
	}

	public unsafe int priority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority)) = num;
		}
	}

	public unsafe float cityPopRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityPopRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityPopRatio)) = num;
		}
	}

	public unsafe int minimumNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumNumber)) = num;
		}
	}

	public unsafe int maximumNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumNumber)) = num;
		}
	}

	public unsafe bool enableLoiteringBehaviour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableLoiteringBehaviour);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableLoiteringBehaviour)) = flag;
		}
	}

	public unsafe List<MenuPreset> menus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MenuPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool recordSalesData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recordSalesData);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recordSalesData)) = flag;
		}
	}

	public unsafe int previousFakeSalesRecords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousFakeSalesRecords);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousFakeSalesRecords)) = num;
		}
	}

	public unsafe List<CharacterTrait> requiredTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredTraits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiredTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool enableSelling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableSelling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableSelling)) = flag;
		}
	}

	public unsafe bool enableSellingOfIllegalItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableSellingOfIllegalItems);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableSellingOfIllegalItems)) = flag;
		}
	}

	public unsafe float sellValueMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sellValueMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sellValueMultiplier)) = num;
		}
	}

	public unsafe List<Color> possibleUniformColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleUniformColours);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Color>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleUniformColours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe CompanyOpenHoursPreset workHours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workHours);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompanyOpenHoursPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workHours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)companyOpenHoursPreset));
		}
	}

	public unsafe CompanyStructurePreset structure
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_structure);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompanyStructurePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_structure)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)companyStructurePreset));
		}
	}

	public unsafe bool controlsBuildingSurveillance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlsBuildingSurveillance);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlsBuildingSurveillance)) = flag;
		}
	}

	public unsafe bool isHotel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHotel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHotel)) = flag;
		}
	}

	static CompanyPreset()
	{
		Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CompanyPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr);
		NativeFieldInfoPtr_companyCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "companyCategories");
		NativeFieldInfoPtr_createMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "createMenu");
		NativeFieldInfoPtr_isIllegal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "isIllegal");
		NativeFieldInfoPtr_useBuildingName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "useBuildingName");
		NativeFieldInfoPtr_useBuildingOverrideName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "useBuildingOverrideName");
		NativeFieldInfoPtr_overrideSuffixList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "overrideSuffixList");
		NativeFieldInfoPtr_useStreetNameChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "useStreetNameChance");
		NativeFieldInfoPtr_useDistrictNameChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "useDistrictNameChance");
		NativeFieldInfoPtr_useOwnerFirstNameChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "useOwnerFirstNameChance");
		NativeFieldInfoPtr_useOwnerSurNameChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "useOwnerSurNameChance");
		NativeFieldInfoPtr_useCompanyNameListChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "useCompanyNameListChance");
		NativeFieldInfoPtr_aliterationWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "aliterationWeight");
		NativeFieldInfoPtr_prefixChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "prefixChance");
		NativeFieldInfoPtr_prefixList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "prefixList");
		NativeFieldInfoPtr_mainChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "mainChance");
		NativeFieldInfoPtr_mainNamingList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "mainNamingList");
		NativeFieldInfoPtr_suffixList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "suffixList");
		NativeFieldInfoPtr_theRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "theRules");
		NativeFieldInfoPtr_minimumSalary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "minimumSalary");
		NativeFieldInfoPtr_topSalary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "topSalary");
		NativeFieldInfoPtr_payGradeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "payGradeCurve");
		NativeFieldInfoPtr_publicFacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "publicFacing");
		NativeFieldInfoPtr_isSelfEmployed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "isSelfEmployed");
		NativeFieldInfoPtr_autoCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "autoCreate");
		NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "priority");
		NativeFieldInfoPtr_cityPopRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "cityPopRatio");
		NativeFieldInfoPtr_minimumNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "minimumNumber");
		NativeFieldInfoPtr_maximumNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "maximumNumber");
		NativeFieldInfoPtr_enableLoiteringBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "enableLoiteringBehaviour");
		NativeFieldInfoPtr_menus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "menus");
		NativeFieldInfoPtr_recordSalesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "recordSalesData");
		NativeFieldInfoPtr_previousFakeSalesRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "previousFakeSalesRecords");
		NativeFieldInfoPtr_requiredTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "requiredTraits");
		NativeFieldInfoPtr_enableSelling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "enableSelling");
		NativeFieldInfoPtr_enableSellingOfIllegalItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "enableSellingOfIllegalItems");
		NativeFieldInfoPtr_sellValueMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "sellValueMultiplier");
		NativeFieldInfoPtr_possibleUniformColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "possibleUniformColours");
		NativeFieldInfoPtr_workHours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "workHours");
		NativeFieldInfoPtr_structure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "structure");
		NativeFieldInfoPtr_controlsBuildingSurveillance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "controlsBuildingSurveillance");
		NativeFieldInfoPtr_isHotel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, "isHotel");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr, 100673856);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327974, XrefRangeEnd = 328018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CompanyPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompanyPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CompanyPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
