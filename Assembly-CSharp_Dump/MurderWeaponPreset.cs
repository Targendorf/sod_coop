using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class MurderWeaponPreset : SoCustomComparison
{
	public enum WeaponType
	{
		handgun,
		rifle,
		shotgun,
		blade,
		bluntObject,
		poison,
		strangulation,
		fists
	}

	public enum StatMultiplier
	{
		zero,
		one,
		random,
		combatSkill,
		combatHeft
	}

	public enum EjectBrass
	{
		none,
		onFire,
		onPumpAction,
		revolver
	}

	public enum AttackValue
	{
		range,
		fireDelay,
		accuracy,
		damage
	}

	private static readonly IntPtr NativeFieldInfoPtr_type;

	private static readonly IntPtr NativeFieldInfoPtr_ammunition;

	private static readonly IntPtr NativeFieldInfoPtr_murderDifficultyModifier;

	private static readonly IntPtr NativeFieldInfoPtr_muzzleOffset;

	private static readonly IntPtr NativeFieldInfoPtr_brassEjectOffset;

	private static readonly IntPtr NativeFieldInfoPtr_itemRightOverride;

	private static readonly IntPtr NativeFieldInfoPtr_itemRightLocalPos;

	private static readonly IntPtr NativeFieldInfoPtr_itemRightLocalEuler;

	private static readonly IntPtr NativeFieldInfoPtr_itemLeftOverride;

	private static readonly IntPtr NativeFieldInfoPtr_itemLeftLocalPos;

	private static readonly IntPtr NativeFieldInfoPtr_itemLeftLocalEuler;

	private static readonly IntPtr NativeFieldInfoPtr_overideUsesCarryAnimation;

	private static readonly IntPtr NativeFieldInfoPtr_overrideCarryAnimation;

	private static readonly IntPtr NativeFieldInfoPtr_usedInPersonalDefence;

	private static readonly IntPtr NativeFieldInfoPtr_disabled;

	private static readonly IntPtr NativeFieldInfoPtr_basePriority;

	private static readonly IntPtr NativeFieldInfoPtr_socialClassRange;

	private static readonly IntPtr NativeFieldInfoPtr_citizenSpawningWithScore;

	private static readonly IntPtr NativeFieldInfoPtr_personalDefenceTraitModifiers;

	private static readonly IntPtr NativeFieldInfoPtr_jobModifierList;

	private static readonly IntPtr NativeFieldInfoPtr_jobScoreModifier;

	private static readonly IntPtr NativeFieldInfoPtr_drawnNerveModifier;

	private static readonly IntPtr NativeFieldInfoPtr_barkTriggerChance;

	private static readonly IntPtr NativeFieldInfoPtr_bark;

	private static readonly IntPtr NativeFieldInfoPtr_incomingNerveDamageMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_attackTriggerPoint;

	private static readonly IntPtr NativeFieldInfoPtr_attackRemovePoint;

	private static readonly IntPtr NativeFieldInfoPtr_shots;

	private static readonly IntPtr NativeFieldInfoPtr_weaponMaxRange;

	private static readonly IntPtr NativeFieldInfoPtr_minimumRange;

	private static readonly IntPtr NativeFieldInfoPtr_maximumBulletRange;

	private static readonly IntPtr NativeFieldInfoPtr_weaponRangeLerpSource;

	private static readonly IntPtr NativeFieldInfoPtr_fireDelay;

	private static readonly IntPtr NativeFieldInfoPtr_fireDelayLerpSource;

	private static readonly IntPtr NativeFieldInfoPtr_attackAccuracy;

	private static readonly IntPtr NativeFieldInfoPtr_attackAccuracyLerpSource;

	private static readonly IntPtr NativeFieldInfoPtr_attackDamage;

	private static readonly IntPtr NativeFieldInfoPtr_attackDamageLerpSource;

	private static readonly IntPtr NativeFieldInfoPtr_applyPoison;

	private static readonly IntPtr NativeFieldInfoPtr_shellCasing;

	private static readonly IntPtr NativeFieldInfoPtr_ejectBrassSetting;

	private static readonly IntPtr NativeFieldInfoPtr_bulletHole;

	private static readonly IntPtr NativeFieldInfoPtr_glassBulletHole;

	private static readonly IntPtr NativeFieldInfoPtr_entryWound;

	private static readonly IntPtr NativeFieldInfoPtr_bulletRicochet;

	private static readonly IntPtr NativeFieldInfoPtr_bulletImpactSpray;

	private static readonly IntPtr NativeFieldInfoPtr_muzzleFlash;

	private static readonly IntPtr NativeFieldInfoPtr_bloodPoolAmount;

	private static readonly IntPtr NativeFieldInfoPtr_forwardSpatter;

	private static readonly IntPtr NativeFieldInfoPtr_backSpatter;

	private static readonly IntPtr NativeFieldInfoPtr_fireEvent;

	private static readonly IntPtr NativeFieldInfoPtr_impactEvent;

	private static readonly IntPtr NativeFieldInfoPtr_impactEventBody;

	private static readonly IntPtr NativeFieldInfoPtr_impactEventPlayer;

	private static readonly IntPtr NativeMethodInfoPtr_GetAttackValue_Public_Single_AttackValue_Human_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe WeaponType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(WeaponType*)num;
		}
		set
		{
			*(WeaponType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = weaponType;
		}
	}

	public unsafe List<InteractablePreset> ammunition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ammunition);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ammunition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int murderDifficultyModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderDifficultyModifier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderDifficultyModifier)) = num;
		}
	}

	public unsafe Vector3 muzzleOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muzzleOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muzzleOffset)) = vector;
		}
	}

	public unsafe Vector3 brassEjectOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brassEjectOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brassEjectOffset)) = vector;
		}
	}

	public unsafe GameObject itemRightOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightOverride);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Vector3 itemRightLocalPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalPos)) = vector;
		}
	}

	public unsafe Vector3 itemRightLocalEuler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalEuler);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRightLocalEuler)) = vector;
		}
	}

	public unsafe GameObject itemLeftOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftOverride);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Vector3 itemLeftLocalPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalPos)) = vector;
		}
	}

	public unsafe Vector3 itemLeftLocalEuler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalEuler);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeftLocalEuler)) = vector;
		}
	}

	public unsafe bool overideUsesCarryAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overideUsesCarryAnimation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overideUsesCarryAnimation)) = flag;
		}
	}

	public unsafe int overrideCarryAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideCarryAnimation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideCarryAnimation)) = num;
		}
	}

	public unsafe bool usedInPersonalDefence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedInPersonalDefence);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usedInPersonalDefence)) = flag;
		}
	}

	public unsafe bool disabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled)) = flag;
		}
	}

	public unsafe int basePriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basePriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basePriority)) = num;
		}
	}

	public unsafe Vector2 socialClassRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialClassRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialClassRange)) = vector;
		}
	}

	public unsafe int citizenSpawningWithScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenSpawningWithScore);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenSpawningWithScore)) = num;
		}
	}

	public unsafe List<MurderPreset.MurdererModifierRule> personalDefenceTraitModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_personalDefenceTraitModifiers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MurderPreset.MurdererModifierRule>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_personalDefenceTraitModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<OccupationPreset> jobModifierList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobModifierList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<OccupationPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobModifierList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int jobScoreModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobScoreModifier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobScoreModifier)) = num;
		}
	}

	public unsafe float drawnNerveModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawnNerveModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawnNerveModifier)) = num;
		}
	}

	public unsafe float barkTriggerChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barkTriggerChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_barkTriggerChance)) = num;
		}
	}

	public unsafe SpeechController.Bark bark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bark);
			return *(SpeechController.Bark*)num;
		}
		set
		{
			*(SpeechController.Bark*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bark)) = bark;
		}
	}

	public unsafe float incomingNerveDamageMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incomingNerveDamageMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incomingNerveDamageMultiplier)) = num;
		}
	}

	public unsafe float attackTriggerPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackTriggerPoint);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackTriggerPoint)) = num;
		}
	}

	public unsafe float attackRemovePoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackRemovePoint);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackRemovePoint)) = num;
		}
	}

	public unsafe int shots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shots);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shots)) = num;
		}
	}

	public unsafe Vector2 weaponMaxRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponMaxRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponMaxRange)) = vector;
		}
	}

	public unsafe float minimumRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumRange)) = num;
		}
	}

	public unsafe float maximumBulletRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumBulletRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumBulletRange)) = num;
		}
	}

	public unsafe StatMultiplier weaponRangeLerpSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponRangeLerpSource);
			return *(StatMultiplier*)num;
		}
		set
		{
			*(StatMultiplier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponRangeLerpSource)) = statMultiplier;
		}
	}

	public unsafe Vector2 fireDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fireDelay);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fireDelay)) = vector;
		}
	}

	public unsafe StatMultiplier fireDelayLerpSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fireDelayLerpSource);
			return *(StatMultiplier*)num;
		}
		set
		{
			*(StatMultiplier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fireDelayLerpSource)) = statMultiplier;
		}
	}

	public unsafe Vector2 attackAccuracy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAccuracy);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAccuracy)) = vector;
		}
	}

	public unsafe StatMultiplier attackAccuracyLerpSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAccuracyLerpSource);
			return *(StatMultiplier*)num;
		}
		set
		{
			*(StatMultiplier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackAccuracyLerpSource)) = statMultiplier;
		}
	}

	public unsafe Vector2 attackDamage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDamage);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDamage)) = vector;
		}
	}

	public unsafe StatMultiplier attackDamageLerpSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDamageLerpSource);
			return *(StatMultiplier*)num;
		}
		set
		{
			*(StatMultiplier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackDamageLerpSource)) = statMultiplier;
		}
	}

	public unsafe float applyPoison
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyPoison);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyPoison)) = num;
		}
	}

	public unsafe InteractablePreset shellCasing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shellCasing);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shellCasing)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe EjectBrass ejectBrassSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ejectBrassSetting);
			return *(EjectBrass*)num;
		}
		set
		{
			*(EjectBrass*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ejectBrassSetting)) = ejectBrass;
		}
	}

	public unsafe InteractablePreset bulletHole
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletHole);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletHole)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe InteractablePreset glassBulletHole
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glassBulletHole);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_glassBulletHole)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe InteractablePreset entryWound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entryWound);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entryWound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe GameObject bulletRicochet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletRicochet);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletRicochet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject bulletImpactSpray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletImpactSpray);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bulletImpactSpray)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject muzzleFlash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muzzleFlash);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_muzzleFlash)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe float bloodPoolAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodPoolAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodPoolAmount)) = num;
		}
	}

	public unsafe SpatterPatternPreset forwardSpatter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardSpatter);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpatterPatternPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardSpatter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spatterPatternPreset));
		}
	}

	public unsafe SpatterPatternPreset backSpatter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backSpatter);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpatterPatternPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backSpatter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spatterPatternPreset));
		}
	}

	public unsafe AudioEvent fireEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fireEvent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fireEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent impactEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactEvent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent impactEventBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactEventBody);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactEventBody)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent impactEventPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactEventPlayer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactEventPlayer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	static MurderWeaponPreset()
	{
		Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MurderWeaponPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr);
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "type");
		NativeFieldInfoPtr_ammunition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "ammunition");
		NativeFieldInfoPtr_murderDifficultyModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "murderDifficultyModifier");
		NativeFieldInfoPtr_muzzleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "muzzleOffset");
		NativeFieldInfoPtr_brassEjectOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "brassEjectOffset");
		NativeFieldInfoPtr_itemRightOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "itemRightOverride");
		NativeFieldInfoPtr_itemRightLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "itemRightLocalPos");
		NativeFieldInfoPtr_itemRightLocalEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "itemRightLocalEuler");
		NativeFieldInfoPtr_itemLeftOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "itemLeftOverride");
		NativeFieldInfoPtr_itemLeftLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "itemLeftLocalPos");
		NativeFieldInfoPtr_itemLeftLocalEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "itemLeftLocalEuler");
		NativeFieldInfoPtr_overideUsesCarryAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "overideUsesCarryAnimation");
		NativeFieldInfoPtr_overrideCarryAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "overrideCarryAnimation");
		NativeFieldInfoPtr_usedInPersonalDefence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "usedInPersonalDefence");
		NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "disabled");
		NativeFieldInfoPtr_basePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "basePriority");
		NativeFieldInfoPtr_socialClassRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "socialClassRange");
		NativeFieldInfoPtr_citizenSpawningWithScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "citizenSpawningWithScore");
		NativeFieldInfoPtr_personalDefenceTraitModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "personalDefenceTraitModifiers");
		NativeFieldInfoPtr_jobModifierList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "jobModifierList");
		NativeFieldInfoPtr_jobScoreModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "jobScoreModifier");
		NativeFieldInfoPtr_drawnNerveModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "drawnNerveModifier");
		NativeFieldInfoPtr_barkTriggerChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "barkTriggerChance");
		NativeFieldInfoPtr_bark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "bark");
		NativeFieldInfoPtr_incomingNerveDamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "incomingNerveDamageMultiplier");
		NativeFieldInfoPtr_attackTriggerPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "attackTriggerPoint");
		NativeFieldInfoPtr_attackRemovePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "attackRemovePoint");
		NativeFieldInfoPtr_shots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "shots");
		NativeFieldInfoPtr_weaponMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "weaponMaxRange");
		NativeFieldInfoPtr_minimumRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "minimumRange");
		NativeFieldInfoPtr_maximumBulletRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "maximumBulletRange");
		NativeFieldInfoPtr_weaponRangeLerpSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "weaponRangeLerpSource");
		NativeFieldInfoPtr_fireDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "fireDelay");
		NativeFieldInfoPtr_fireDelayLerpSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "fireDelayLerpSource");
		NativeFieldInfoPtr_attackAccuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "attackAccuracy");
		NativeFieldInfoPtr_attackAccuracyLerpSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "attackAccuracyLerpSource");
		NativeFieldInfoPtr_attackDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "attackDamage");
		NativeFieldInfoPtr_attackDamageLerpSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "attackDamageLerpSource");
		NativeFieldInfoPtr_applyPoison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "applyPoison");
		NativeFieldInfoPtr_shellCasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "shellCasing");
		NativeFieldInfoPtr_ejectBrassSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "ejectBrassSetting");
		NativeFieldInfoPtr_bulletHole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "bulletHole");
		NativeFieldInfoPtr_glassBulletHole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "glassBulletHole");
		NativeFieldInfoPtr_entryWound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "entryWound");
		NativeFieldInfoPtr_bulletRicochet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "bulletRicochet");
		NativeFieldInfoPtr_bulletImpactSpray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "bulletImpactSpray");
		NativeFieldInfoPtr_muzzleFlash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "muzzleFlash");
		NativeFieldInfoPtr_bloodPoolAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "bloodPoolAmount");
		NativeFieldInfoPtr_forwardSpatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "forwardSpatter");
		NativeFieldInfoPtr_backSpatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "backSpatter");
		NativeFieldInfoPtr_fireEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "fireEvent");
		NativeFieldInfoPtr_impactEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "impactEvent");
		NativeFieldInfoPtr_impactEventBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "impactEventBody");
		NativeFieldInfoPtr_impactEventPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, "impactEventPlayer");
		NativeMethodInfoPtr_GetAttackValue_Public_Single_AttackValue_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, 100673994);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr, 100673995);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 329662, RefRangeEnd = 329668, XrefRangeStart = 329647, XrefRangeEnd = 329662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetAttackValue(AttackValue valueType, Human human)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&valueType);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAttackValue_Public_Single_AttackValue_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329668, XrefRangeEnd = 329700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MurderWeaponPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MurderWeaponPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MurderWeaponPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
