using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class RetailItemPreset : SoCustomComparison
{
	public enum Tags
	{
		starchProduct
	}

	public enum MenuCategory
	{
		food,
		drinks,
		snacks,
		none
	}

	private static readonly IntPtr NativeFieldInfoPtr_itemPreset;

	private static readonly IntPtr NativeFieldInfoPtr_canBeFavourite;

	private static readonly IntPtr NativeFieldInfoPtr_isHot;

	private static readonly IntPtr NativeFieldInfoPtr_isConsumable;

	private static readonly IntPtr NativeFieldInfoPtr_brandName;

	private static readonly IntPtr NativeFieldInfoPtr_tags;

	private static readonly IntPtr NativeFieldInfoPtr_desireCategory;

	private static readonly IntPtr NativeFieldInfoPtr_menuCategory;

	private static readonly IntPtr NativeFieldInfoPtr_ethnicity;

	private static readonly IntPtr NativeFieldInfoPtr_minimumWealth;

	private static readonly IntPtr NativeFieldInfoPtr_mustFeatureTraits;

	private static readonly IntPtr NativeFieldInfoPtr_cantFeatureTrait;

	private static readonly IntPtr NativeFieldInfoPtr_preferredTraits;

	private static readonly IntPtr NativeFieldInfoPtr_nourishment;

	private static readonly IntPtr NativeFieldInfoPtr_hydration;

	private static readonly IntPtr NativeFieldInfoPtr_alertness;

	private static readonly IntPtr NativeFieldInfoPtr_energy;

	private static readonly IntPtr NativeFieldInfoPtr_excitement;

	private static readonly IntPtr NativeFieldInfoPtr_chores;

	private static readonly IntPtr NativeFieldInfoPtr_hygiene;

	private static readonly IntPtr NativeFieldInfoPtr_bladder;

	private static readonly IntPtr NativeFieldInfoPtr_heat;

	private static readonly IntPtr NativeFieldInfoPtr_drunk;

	private static readonly IntPtr NativeFieldInfoPtr_sick;

	private static readonly IntPtr NativeFieldInfoPtr_headache;

	private static readonly IntPtr NativeFieldInfoPtr_wet;

	private static readonly IntPtr NativeFieldInfoPtr_brokenLeg;

	private static readonly IntPtr NativeFieldInfoPtr_bruised;

	private static readonly IntPtr NativeFieldInfoPtr_blackEye;

	private static readonly IntPtr NativeFieldInfoPtr_blackedOut;

	private static readonly IntPtr NativeFieldInfoPtr_numb;

	private static readonly IntPtr NativeFieldInfoPtr_bleeding;

	private static readonly IntPtr NativeFieldInfoPtr_wellRested;

	private static readonly IntPtr NativeFieldInfoPtr_breath;

	private static readonly IntPtr NativeFieldInfoPtr_starchAddiction;

	private static readonly IntPtr NativeFieldInfoPtr_poisoned;

	private static readonly IntPtr NativeFieldInfoPtr_health;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe InteractablePreset itemPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemPreset);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe bool canBeFavourite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeFavourite);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeFavourite)) = flag;
		}
	}

	public unsafe bool isHot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHot);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHot)) = flag;
		}
	}

	public unsafe bool isConsumable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isConsumable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isConsumable)) = flag;
		}
	}

	public unsafe string brandName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brandName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brandName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<Tags> tags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Tags>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe CompanyPreset.CompanyCategory desireCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desireCategory);
			return *(CompanyPreset.CompanyCategory*)num;
		}
		set
		{
			*(CompanyPreset.CompanyCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desireCategory)) = companyCategory;
		}
	}

	public unsafe MenuCategory menuCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuCategory);
			return *(MenuCategory*)num;
		}
		set
		{
			*(MenuCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuCategory)) = menuCategory;
		}
	}

	public unsafe List<Descriptors.EthnicGroup> ethnicity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicity);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Descriptors.EthnicGroup>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ethnicity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float minimumWealth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumWealth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumWealth)) = num;
		}
	}

	public unsafe List<CharacterTrait> mustFeatureTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustFeatureTraits);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustFeatureTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CharacterTrait> cantFeatureTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cantFeatureTrait);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cantFeatureTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CharacterTrait> preferredTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredTraits);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float nourishment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nourishment);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nourishment)) = num;
		}
	}

	public unsafe float hydration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydration)) = num;
		}
	}

	public unsafe float alertness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertness)) = num;
		}
	}

	public unsafe float energy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energy)) = num;
		}
	}

	public unsafe float excitement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excitement);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excitement)) = num;
		}
	}

	public unsafe float chores
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chores);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chores)) = num;
		}
	}

	public unsafe float hygiene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hygiene);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hygiene)) = num;
		}
	}

	public unsafe float bladder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bladder);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bladder)) = num;
		}
	}

	public unsafe float heat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heat);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heat)) = num;
		}
	}

	public unsafe float drunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunk);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunk)) = num;
		}
	}

	public unsafe float sick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sick);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sick)) = num;
		}
	}

	public unsafe float headache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headache);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headache)) = num;
		}
	}

	public unsafe float wet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wet);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wet)) = num;
		}
	}

	public unsafe float brokenLeg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenLeg);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenLeg)) = num;
		}
	}

	public unsafe float bruised
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bruised);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bruised)) = num;
		}
	}

	public unsafe float blackEye
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackEye);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackEye)) = num;
		}
	}

	public unsafe float blackedOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackedOut);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackedOut)) = num;
		}
	}

	public unsafe float numb
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numb);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numb)) = num;
		}
	}

	public unsafe float bleeding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleeding);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleeding)) = num;
		}
	}

	public unsafe float wellRested
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wellRested);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wellRested)) = num;
		}
	}

	public unsafe float breath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breath);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breath)) = num;
		}
	}

	public unsafe float starchAddiction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starchAddiction);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starchAddiction)) = num;
		}
	}

	public unsafe float poisoned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisoned);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisoned)) = num;
		}
	}

	public unsafe float health
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_health);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_health)) = num;
		}
	}

	static RetailItemPreset()
	{
		Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RetailItemPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr);
		NativeFieldInfoPtr_itemPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "itemPreset");
		NativeFieldInfoPtr_canBeFavourite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "canBeFavourite");
		NativeFieldInfoPtr_isHot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "isHot");
		NativeFieldInfoPtr_isConsumable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "isConsumable");
		NativeFieldInfoPtr_brandName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "brandName");
		NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "tags");
		NativeFieldInfoPtr_desireCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "desireCategory");
		NativeFieldInfoPtr_menuCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "menuCategory");
		NativeFieldInfoPtr_ethnicity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "ethnicity");
		NativeFieldInfoPtr_minimumWealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "minimumWealth");
		NativeFieldInfoPtr_mustFeatureTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "mustFeatureTraits");
		NativeFieldInfoPtr_cantFeatureTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "cantFeatureTrait");
		NativeFieldInfoPtr_preferredTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "preferredTraits");
		NativeFieldInfoPtr_nourishment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "nourishment");
		NativeFieldInfoPtr_hydration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "hydration");
		NativeFieldInfoPtr_alertness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "alertness");
		NativeFieldInfoPtr_energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "energy");
		NativeFieldInfoPtr_excitement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "excitement");
		NativeFieldInfoPtr_chores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "chores");
		NativeFieldInfoPtr_hygiene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "hygiene");
		NativeFieldInfoPtr_bladder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "bladder");
		NativeFieldInfoPtr_heat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "heat");
		NativeFieldInfoPtr_drunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "drunk");
		NativeFieldInfoPtr_sick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "sick");
		NativeFieldInfoPtr_headache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "headache");
		NativeFieldInfoPtr_wet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "wet");
		NativeFieldInfoPtr_brokenLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "brokenLeg");
		NativeFieldInfoPtr_bruised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "bruised");
		NativeFieldInfoPtr_blackEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "blackEye");
		NativeFieldInfoPtr_blackedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "blackedOut");
		NativeFieldInfoPtr_numb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "numb");
		NativeFieldInfoPtr_bleeding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "bleeding");
		NativeFieldInfoPtr_wellRested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "wellRested");
		NativeFieldInfoPtr_breath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "breath");
		NativeFieldInfoPtr_starchAddiction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "starchAddiction");
		NativeFieldInfoPtr_poisoned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "poisoned");
		NativeFieldInfoPtr_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, "health");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr, 100674010);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329872, XrefRangeEnd = 329902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RetailItemPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RetailItemPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RetailItemPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
