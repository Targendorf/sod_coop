using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class MurderWeaponsPool : SoCustomComparison
{
	[System.Serializable]
	public class MurderWeaponPick : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_weapon;

		private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfDroppingAtScene;

		private static readonly System.IntPtr NativeFieldInfoPtr_randomScoreRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitModifiers;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe InteractablePreset weapon
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weapon);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weapon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
			}
		}

		public unsafe float chanceOfDroppingAtScene
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfDroppingAtScene);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfDroppingAtScene)) = num;
			}
		}

		public unsafe Vector2 randomScoreRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomScoreRange);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomScoreRange)) = vector;
			}
		}

		public unsafe List<MurderPreset.MurdererModifierRule> traitModifiers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderPreset.MurdererModifierRule>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static MurderWeaponPick()
		{
			Il2CppClassPointerStore<MurderWeaponPick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MurderWeaponsPool>.NativeClassPtr, "MurderWeaponPick");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MurderWeaponPick>.NativeClassPtr);
			NativeFieldInfoPtr_weapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPick>.NativeClassPtr, "weapon");
			NativeFieldInfoPtr_chanceOfDroppingAtScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPick>.NativeClassPtr, "chanceOfDroppingAtScene");
			NativeFieldInfoPtr_randomScoreRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPick>.NativeClassPtr, "randomScoreRange");
			NativeFieldInfoPtr_traitModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponPick>.NativeClassPtr, "traitModifiers");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurderWeaponPick>.NativeClassPtr, 100673997);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329700, XrefRangeEnd = 329706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MurderWeaponPick()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MurderWeaponPick>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MurderWeaponPick(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_murderWeaponPool;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<MurderWeaponPick> murderWeaponPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderWeaponPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderWeaponPick>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderWeaponPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static MurderWeaponsPool()
	{
		Il2CppClassPointerStore<MurderWeaponsPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MurderWeaponsPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MurderWeaponsPool>.NativeClassPtr);
		NativeFieldInfoPtr_murderWeaponPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MurderWeaponsPool>.NativeClassPtr, "murderWeaponPool");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MurderWeaponsPool>.NativeClassPtr, 100673996);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329706, XrefRangeEnd = 329714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MurderWeaponsPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MurderWeaponsPool>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MurderWeaponsPool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
