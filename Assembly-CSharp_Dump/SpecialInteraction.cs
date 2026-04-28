using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

[System.Serializable]
public sealed class SpecialInteraction : Il2CppSystem.ValueType
{
	[System.Flags]
	public enum Frequency
	{
		None = 0,
		WhenSpawned = 1,
		EveryTurn = 2,
		WhenDies = 4
	}

	[System.Flags]
	public enum OthersLabels
	{
		None = 0,
		Monster = 1,
		Animal = 2,
		Building = 4,
		Metallic = 8,
		Wooden = 0x10,
		Human = 0x20,
		Mage = 0x40,
		Fabric = 0x80
	}

	[System.Flags]
	public enum SpecialEffects
	{
		None = 0,
		DoubleHP = 1,
		DoubleAttack = 2,
		DoubleMana = 4
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_frequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_othersLabels;

	private static readonly System.IntPtr NativeFieldInfoPtr_specialEffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_wizcardToSpawn;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraHealth;

	private static readonly System.IntPtr NativeFieldInfoPtr_bonusDamage;

	public unsafe Frequency frequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency);
			return *(Frequency*)num;
		}
		set
		{
			*(Frequency*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency)) = frequency;
		}
	}

	public unsafe OthersLabels othersLabels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_othersLabels);
			return *(OthersLabels*)num;
		}
		set
		{
			*(OthersLabels*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_othersLabels)) = othersLabels;
		}
	}

	public unsafe SpecialEffects specialEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialEffects);
			return *(SpecialEffects*)num;
		}
		set
		{
			*(SpecialEffects*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialEffects)) = specialEffects;
		}
	}

	public unsafe Wizcard wizcardToSpawn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wizcardToSpawn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Wizcard>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wizcardToSpawn)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)wizcard));
		}
	}

	public unsafe int extraAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraAttack);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraAttack)) = num;
		}
	}

	public unsafe int extraHealth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraHealth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraHealth)) = num;
		}
	}

	public unsafe int bonusDamage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonusDamage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bonusDamage)) = num;
		}
	}

	static SpecialInteraction()
	{
		Il2CppClassPointerStore<SpecialInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SpecialInteraction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialInteraction>.NativeClassPtr);
		NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialInteraction>.NativeClassPtr, "frequency");
		NativeFieldInfoPtr_othersLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialInteraction>.NativeClassPtr, "othersLabels");
		NativeFieldInfoPtr_specialEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialInteraction>.NativeClassPtr, "specialEffects");
		NativeFieldInfoPtr_wizcardToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialInteraction>.NativeClassPtr, "wizcardToSpawn");
		NativeFieldInfoPtr_extraAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialInteraction>.NativeClassPtr, "extraAttack");
		NativeFieldInfoPtr_extraHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialInteraction>.NativeClassPtr, "extraHealth");
		NativeFieldInfoPtr_bonusDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialInteraction>.NativeClassPtr, "bonusDamage");
	}

	public SpecialInteraction(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public SpecialInteraction()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialInteraction>.NativeClassPtr))
	{
	}
}
