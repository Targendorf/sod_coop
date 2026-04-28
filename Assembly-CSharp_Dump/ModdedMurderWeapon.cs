using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class ModdedMurderWeapon : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_copyDataFrom;

	private static readonly System.IntPtr NativeFieldInfoPtr_presetName;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_ammunition;

	private static readonly System.IntPtr NativeFieldInfoPtr_murderDifficultyModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_muzzleOffsetX;

	private static readonly System.IntPtr NativeFieldInfoPtr_muzzleOffsetY;

	private static readonly System.IntPtr NativeFieldInfoPtr_muzzleOffsetZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_brassEjectOffsetX;

	private static readonly System.IntPtr NativeFieldInfoPtr_brassEjectOffsetY;

	private static readonly System.IntPtr NativeFieldInfoPtr_brassEjectOffsetZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemRightOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemRightLocalPosX;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemRightLocalPosY;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemRightLocalPosZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemRightLocalEulerX;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemRightLocalEulerY;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemRightLocalEulerZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemLeftOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemLeftLocalPosX;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemLeftLocalPosY;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemLeftLocalPosZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemLeftLocalEulerX;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemLeftLocalEulerY;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemLeftLocalEulerZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_overideUsesCarryAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideCarryAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_usedInPersonalDefence;

	private static readonly System.IntPtr NativeFieldInfoPtr_disabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_basePriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_socialClassRangeMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_socialClassRangeMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenSpawningWithScore;

	private static readonly System.IntPtr NativeFieldInfoPtr_personalDefenceTraitModifiers1;

	private static readonly System.IntPtr NativeFieldInfoPtr_personalDefenceTraitModifiers2;

	private static readonly System.IntPtr NativeFieldInfoPtr_personalDefenceTraitModifiers3;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobModifierList;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobScoreModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawnNerveModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_barkTriggerChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_bark;

	private static readonly System.IntPtr NativeFieldInfoPtr_incomingNerveDamageMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackTriggerPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackRemovePoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_shots;

	private static readonly System.IntPtr NativeFieldInfoPtr_weaponMaxRangeMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_weaponMaxRangeMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumBulletRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_weaponRangeLerpSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_fireDelayMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_fireDelayMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_fireDelayLerpSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackAccuracyMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackAccuracyMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackAccuracyLerpSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackDamageMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackDamageMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackDamageLerpSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_applyPoison;

	private static readonly System.IntPtr NativeFieldInfoPtr_shellCasing;

	private static readonly System.IntPtr NativeFieldInfoPtr_ejectBrassSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_bulletHole;

	private static readonly System.IntPtr NativeFieldInfoPtr_glassBulletHole;

	private static readonly System.IntPtr NativeFieldInfoPtr_entryWound;

	private static readonly System.IntPtr NativeFieldInfoPtr_bulletRicochet;

	private static readonly System.IntPtr NativeFieldInfoPtr_bulletImpactSpray;

	private static readonly System.IntPtr NativeFieldInfoPtr_muzzleFlash;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloodPoolAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_forwardSpatter;

	private static readonly System.IntPtr NativeFieldInfoPtr_backSpatter;

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

	public unsafe string type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> ammunition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ammunition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ammunition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string murderDifficultyModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderDifficultyModifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderDifficultyModifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string muzzleOffsetX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muzzleOffsetX);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muzzleOffsetX)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string muzzleOffsetY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muzzleOffsetY);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muzzleOffsetY)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string muzzleOffsetZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muzzleOffsetZ);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muzzleOffsetZ)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string brassEjectOffsetX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brassEjectOffsetX);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brassEjectOffsetX)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string brassEjectOffsetY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brassEjectOffsetY);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brassEjectOffsetY)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string brassEjectOffsetZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brassEjectOffsetZ);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brassEjectOffsetZ)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemRightOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightOverride);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightOverride)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemRightLocalPosX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalPosX);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalPosX)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemRightLocalPosY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalPosY);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalPosY)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemRightLocalPosZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalPosZ);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalPosZ)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemRightLocalEulerX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalEulerX);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalEulerX)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemRightLocalEulerY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalEulerY);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalEulerY)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemRightLocalEulerZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalEulerZ);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalEulerZ)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemLeftOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftOverride);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftOverride)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemLeftLocalPosX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalPosX);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalPosX)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemLeftLocalPosY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalPosY);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalPosY)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemLeftLocalPosZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalPosZ);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalPosZ)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemLeftLocalEulerX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalEulerX);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalEulerX)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemLeftLocalEulerY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalEulerY);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalEulerY)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string itemLeftLocalEulerZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalEulerZ);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalEulerZ)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string overideUsesCarryAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overideUsesCarryAnimation);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overideUsesCarryAnimation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string overrideCarryAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideCarryAnimation);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideCarryAnimation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string usedInPersonalDefence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedInPersonalDefence);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedInPersonalDefence)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string disabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string basePriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basePriority);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basePriority)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string socialClassRangeMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialClassRangeMin);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialClassRangeMin)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string socialClassRangeMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialClassRangeMax);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialClassRangeMax)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string citizenSpawningWithScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenSpawningWithScore);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenSpawningWithScore)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> personalDefenceTraitModifiers1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_personalDefenceTraitModifiers1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_personalDefenceTraitModifiers1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> personalDefenceTraitModifiers2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_personalDefenceTraitModifiers2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_personalDefenceTraitModifiers2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> personalDefenceTraitModifiers3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_personalDefenceTraitModifiers3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_personalDefenceTraitModifiers3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> jobModifierList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobModifierList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobModifierList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string jobScoreModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobScoreModifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobScoreModifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string drawnNerveModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawnNerveModifier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawnNerveModifier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string barkTriggerChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barkTriggerChance);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barkTriggerChance)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bark);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bark)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string incomingNerveDamageMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incomingNerveDamageMultiplier);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incomingNerveDamageMultiplier)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string attackTriggerPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackTriggerPoint);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackTriggerPoint)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string attackRemovePoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackRemovePoint);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackRemovePoint)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string shots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shots);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shots)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string weaponMaxRangeMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponMaxRangeMin);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponMaxRangeMin)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string weaponMaxRangeMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponMaxRangeMax);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponMaxRangeMax)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string minimumRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumRange);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumRange)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string maximumBulletRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumBulletRange);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumBulletRange)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string weaponRangeLerpSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponRangeLerpSource);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponRangeLerpSource)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string fireDelayMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fireDelayMin);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fireDelayMin)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string fireDelayMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fireDelayMax);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fireDelayMax)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string fireDelayLerpSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fireDelayLerpSource);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fireDelayLerpSource)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string attackAccuracyMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAccuracyMin);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAccuracyMin)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string attackAccuracyMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAccuracyMax);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAccuracyMax)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string attackAccuracyLerpSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAccuracyLerpSource);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAccuracyLerpSource)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string attackDamageMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDamageMin);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDamageMin)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string attackDamageMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDamageMax);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDamageMax)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string attackDamageLerpSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDamageLerpSource);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDamageLerpSource)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string applyPoison
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyPoison);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyPoison)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string shellCasing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shellCasing);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shellCasing)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string ejectBrassSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ejectBrassSetting);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ejectBrassSetting)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bulletHole
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletHole);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletHole)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string glassBulletHole
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glassBulletHole);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glassBulletHole)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string entryWound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entryWound);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entryWound)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bulletRicochet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletRicochet);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletRicochet)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bulletImpactSpray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletImpactSpray);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletImpactSpray)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string muzzleFlash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muzzleFlash);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muzzleFlash)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bloodPoolAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodPoolAmount);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodPoolAmount)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string forwardSpatter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardSpatter);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardSpatter)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string backSpatter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backSpatter);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backSpatter)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ModdedMurderWeapon()
	{
		Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ModdedMurderWeapon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr);
		NativeFieldInfoPtr_copyDataFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "copyDataFrom");
		NativeFieldInfoPtr_presetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "presetName");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "type");
		NativeFieldInfoPtr_ammunition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "ammunition");
		NativeFieldInfoPtr_murderDifficultyModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "murderDifficultyModifier");
		NativeFieldInfoPtr_muzzleOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "muzzleOffsetX");
		NativeFieldInfoPtr_muzzleOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "muzzleOffsetY");
		NativeFieldInfoPtr_muzzleOffsetZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "muzzleOffsetZ");
		NativeFieldInfoPtr_brassEjectOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "brassEjectOffsetX");
		NativeFieldInfoPtr_brassEjectOffsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "brassEjectOffsetY");
		NativeFieldInfoPtr_brassEjectOffsetZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "brassEjectOffsetZ");
		NativeFieldInfoPtr_itemRightOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemRightOverride");
		NativeFieldInfoPtr_itemRightLocalPosX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemRightLocalPosX");
		NativeFieldInfoPtr_itemRightLocalPosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemRightLocalPosY");
		NativeFieldInfoPtr_itemRightLocalPosZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemRightLocalPosZ");
		NativeFieldInfoPtr_itemRightLocalEulerX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemRightLocalEulerX");
		NativeFieldInfoPtr_itemRightLocalEulerY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemRightLocalEulerY");
		NativeFieldInfoPtr_itemRightLocalEulerZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemRightLocalEulerZ");
		NativeFieldInfoPtr_itemLeftOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemLeftOverride");
		NativeFieldInfoPtr_itemLeftLocalPosX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemLeftLocalPosX");
		NativeFieldInfoPtr_itemLeftLocalPosY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemLeftLocalPosY");
		NativeFieldInfoPtr_itemLeftLocalPosZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemLeftLocalPosZ");
		NativeFieldInfoPtr_itemLeftLocalEulerX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemLeftLocalEulerX");
		NativeFieldInfoPtr_itemLeftLocalEulerY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemLeftLocalEulerY");
		NativeFieldInfoPtr_itemLeftLocalEulerZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "itemLeftLocalEulerZ");
		NativeFieldInfoPtr_overideUsesCarryAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "overideUsesCarryAnimation");
		NativeFieldInfoPtr_overrideCarryAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "overrideCarryAnimation");
		NativeFieldInfoPtr_usedInPersonalDefence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "usedInPersonalDefence");
		NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "disabled");
		NativeFieldInfoPtr_basePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "basePriority");
		NativeFieldInfoPtr_socialClassRangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "socialClassRangeMin");
		NativeFieldInfoPtr_socialClassRangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "socialClassRangeMax");
		NativeFieldInfoPtr_citizenSpawningWithScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "citizenSpawningWithScore");
		NativeFieldInfoPtr_personalDefenceTraitModifiers1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "personalDefenceTraitModifiers1");
		NativeFieldInfoPtr_personalDefenceTraitModifiers2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "personalDefenceTraitModifiers2");
		NativeFieldInfoPtr_personalDefenceTraitModifiers3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "personalDefenceTraitModifiers3");
		NativeFieldInfoPtr_jobModifierList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "jobModifierList");
		NativeFieldInfoPtr_jobScoreModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "jobScoreModifier");
		NativeFieldInfoPtr_drawnNerveModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "drawnNerveModifier");
		NativeFieldInfoPtr_barkTriggerChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "barkTriggerChance");
		NativeFieldInfoPtr_bark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "bark");
		NativeFieldInfoPtr_incomingNerveDamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "incomingNerveDamageMultiplier");
		NativeFieldInfoPtr_attackTriggerPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "attackTriggerPoint");
		NativeFieldInfoPtr_attackRemovePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "attackRemovePoint");
		NativeFieldInfoPtr_shots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "shots");
		NativeFieldInfoPtr_weaponMaxRangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "weaponMaxRangeMin");
		NativeFieldInfoPtr_weaponMaxRangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "weaponMaxRangeMax");
		NativeFieldInfoPtr_minimumRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "minimumRange");
		NativeFieldInfoPtr_maximumBulletRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "maximumBulletRange");
		NativeFieldInfoPtr_weaponRangeLerpSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "weaponRangeLerpSource");
		NativeFieldInfoPtr_fireDelayMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "fireDelayMin");
		NativeFieldInfoPtr_fireDelayMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "fireDelayMax");
		NativeFieldInfoPtr_fireDelayLerpSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "fireDelayLerpSource");
		NativeFieldInfoPtr_attackAccuracyMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "attackAccuracyMin");
		NativeFieldInfoPtr_attackAccuracyMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "attackAccuracyMax");
		NativeFieldInfoPtr_attackAccuracyLerpSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "attackAccuracyLerpSource");
		NativeFieldInfoPtr_attackDamageMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "attackDamageMin");
		NativeFieldInfoPtr_attackDamageMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "attackDamageMax");
		NativeFieldInfoPtr_attackDamageLerpSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "attackDamageLerpSource");
		NativeFieldInfoPtr_applyPoison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "applyPoison");
		NativeFieldInfoPtr_shellCasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "shellCasing");
		NativeFieldInfoPtr_ejectBrassSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "ejectBrassSetting");
		NativeFieldInfoPtr_bulletHole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "bulletHole");
		NativeFieldInfoPtr_glassBulletHole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "glassBulletHole");
		NativeFieldInfoPtr_entryWound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "entryWound");
		NativeFieldInfoPtr_bulletRicochet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "bulletRicochet");
		NativeFieldInfoPtr_bulletImpactSpray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "bulletImpactSpray");
		NativeFieldInfoPtr_muzzleFlash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "muzzleFlash");
		NativeFieldInfoPtr_bloodPoolAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "bloodPoolAmount");
		NativeFieldInfoPtr_forwardSpatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "forwardSpatter");
		NativeFieldInfoPtr_backSpatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, "backSpatter");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr, 100673196);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313997, XrefRangeEnd = 314007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ModdedMurderWeapon()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModdedMurderWeapon>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ModdedMurderWeapon(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
