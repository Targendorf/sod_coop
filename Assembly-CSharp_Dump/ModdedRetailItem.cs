using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class ModdedRetailItem : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_copyDataFrom;

	private static readonly System.IntPtr NativeFieldInfoPtr_presetName;

	private static readonly System.IntPtr NativeFieldInfoPtr_isConsumable;

	private static readonly System.IntPtr NativeFieldInfoPtr_canBeFavourite;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHot;

	private static readonly System.IntPtr NativeFieldInfoPtr_tags;

	private static readonly System.IntPtr NativeFieldInfoPtr_desireCategory;

	private static readonly System.IntPtr NativeFieldInfoPtr_menuCategory;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumWealth;

	private static readonly System.IntPtr NativeFieldInfoPtr_nourishment;

	private static readonly System.IntPtr NativeFieldInfoPtr_hydration;

	private static readonly System.IntPtr NativeFieldInfoPtr_alertness;

	private static readonly System.IntPtr NativeFieldInfoPtr_energy;

	private static readonly System.IntPtr NativeFieldInfoPtr_excitement;

	private static readonly System.IntPtr NativeFieldInfoPtr_chores;

	private static readonly System.IntPtr NativeFieldInfoPtr_hygiene;

	private static readonly System.IntPtr NativeFieldInfoPtr_bladder;

	private static readonly System.IntPtr NativeFieldInfoPtr_heat;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_sick;

	private static readonly System.IntPtr NativeFieldInfoPtr_headache;

	private static readonly System.IntPtr NativeFieldInfoPtr_wet;

	private static readonly System.IntPtr NativeFieldInfoPtr_brokenLeg;

	private static readonly System.IntPtr NativeFieldInfoPtr_bruised;

	private static readonly System.IntPtr NativeFieldInfoPtr_blackEye;

	private static readonly System.IntPtr NativeFieldInfoPtr_blackedOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_numb;

	private static readonly System.IntPtr NativeFieldInfoPtr_bleeding;

	private static readonly System.IntPtr NativeFieldInfoPtr_wellRested;

	private static readonly System.IntPtr NativeFieldInfoPtr_breath;

	private static readonly System.IntPtr NativeFieldInfoPtr_starchAddiction;

	private static readonly System.IntPtr NativeFieldInfoPtr_poisoned;

	private static readonly System.IntPtr NativeFieldInfoPtr_health;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string copyDataFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyDataFrom);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyDataFrom)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string presetName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presetName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presetName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string isConsumable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isConsumable);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isConsumable)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string canBeFavourite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeFavourite);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canBeFavourite)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string isHot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHot);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHot)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> tags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string desireCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desireCategory);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desireCategory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string menuCategory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuCategory);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuCategory)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string minimumWealth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumWealth);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumWealth)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string nourishment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nourishment);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nourishment)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string hydration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydration);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydration)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string alertness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertness);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertness)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string energy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energy);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energy)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string excitement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excitement);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excitement)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string chores
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chores);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chores)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string hygiene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hygiene);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hygiene)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bladder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bladder);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bladder)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string heat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heat);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heat)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string drunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunk);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunk)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string sick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sick);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sick)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string headache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headache);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headache)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string wet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wet);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wet)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string brokenLeg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenLeg);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenLeg)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bruised
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bruised);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bruised)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string blackEye
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackEye);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackEye)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string blackedOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackedOut);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackedOut)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string numb
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numb);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numb)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bleeding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleeding);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleeding)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string wellRested
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wellRested);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wellRested)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string breath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string starchAddiction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starchAddiction);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starchAddiction)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string poisoned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisoned);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisoned)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string health
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_health);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_health)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ModdedRetailItem()
	{
		Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ModdedRetailItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr);
		NativeFieldInfoPtr_copyDataFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "copyDataFrom");
		NativeFieldInfoPtr_presetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "presetName");
		NativeFieldInfoPtr_isConsumable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "isConsumable");
		NativeFieldInfoPtr_canBeFavourite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "canBeFavourite");
		NativeFieldInfoPtr_isHot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "isHot");
		NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "tags");
		NativeFieldInfoPtr_desireCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "desireCategory");
		NativeFieldInfoPtr_menuCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "menuCategory");
		NativeFieldInfoPtr_minimumWealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "minimumWealth");
		NativeFieldInfoPtr_nourishment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "nourishment");
		NativeFieldInfoPtr_hydration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "hydration");
		NativeFieldInfoPtr_alertness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "alertness");
		NativeFieldInfoPtr_energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "energy");
		NativeFieldInfoPtr_excitement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "excitement");
		NativeFieldInfoPtr_chores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "chores");
		NativeFieldInfoPtr_hygiene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "hygiene");
		NativeFieldInfoPtr_bladder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "bladder");
		NativeFieldInfoPtr_heat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "heat");
		NativeFieldInfoPtr_drunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "drunk");
		NativeFieldInfoPtr_sick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "sick");
		NativeFieldInfoPtr_headache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "headache");
		NativeFieldInfoPtr_wet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "wet");
		NativeFieldInfoPtr_brokenLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "brokenLeg");
		NativeFieldInfoPtr_bruised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "bruised");
		NativeFieldInfoPtr_blackEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "blackEye");
		NativeFieldInfoPtr_blackedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "blackedOut");
		NativeFieldInfoPtr_numb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "numb");
		NativeFieldInfoPtr_bleeding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "bleeding");
		NativeFieldInfoPtr_wellRested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "wellRested");
		NativeFieldInfoPtr_breath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "breath");
		NativeFieldInfoPtr_starchAddiction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "starchAddiction");
		NativeFieldInfoPtr_poisoned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "poisoned");
		NativeFieldInfoPtr_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, "health");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr, 100673197);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModdedRetailItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModdedRetailItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ModdedRetailItem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
