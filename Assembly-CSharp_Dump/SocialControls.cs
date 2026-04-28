using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class SocialControls : MonoBehaviour
{
	[System.Serializable]
	public class SocialCreditBuff : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_description;

		private static readonly System.IntPtr NativeFieldInfoPtr_effect;

		private static readonly System.IntPtr NativeFieldInfoPtr_value;

		private static readonly System.IntPtr NativeFieldInfoPtr_randomGrouping;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetEffect_Public_AppliedEffect_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string description
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_description)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe SyncDiskPreset.Effect effect
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effect);
				return *(SyncDiskPreset.Effect*)num;
			}
			set
			{
				*(SyncDiskPreset.Effect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effect)) = effect;
			}
		}

		public unsafe float value
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)) = num;
			}
		}

		public unsafe int randomGrouping
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomGrouping);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomGrouping)) = num;
			}
		}

		static SocialCreditBuff()
		{
			Il2CppClassPointerStore<SocialCreditBuff>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "SocialCreditBuff");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocialCreditBuff>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialCreditBuff>.NativeClassPtr, "name");
			NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialCreditBuff>.NativeClassPtr, "description");
			NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialCreditBuff>.NativeClassPtr, "effect");
			NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialCreditBuff>.NativeClassPtr, "value");
			NativeFieldInfoPtr_randomGrouping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialCreditBuff>.NativeClassPtr, "randomGrouping");
			NativeMethodInfoPtr_GetEffect_Public_AppliedEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialCreditBuff>.NativeClassPtr, 100674132);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialCreditBuff>.NativeClassPtr, 100674133);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331882, RefRangeEnd = 331883, XrefRangeStart = 331879, XrefRangeEnd = 331882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpgradeEffectController.AppliedEffect GetEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEffect_Public_AppliedEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UpgradeEffectController.AppliedEffect>(intPtr) : null;
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocialCreditBuff()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocialCreditBuff>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SocialCreditBuff(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_knowLoverRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowHousemateRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowFriendRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowNeighborRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowBossRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowWorkTeamRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowWorkRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowWorkOtherRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowRegularCustomerRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowParamourRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowGroupRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_paramour;

	private static readonly System.IntPtr NativeFieldInfoPtr_basePreferredBookCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_wageRanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_overtimeRanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_accuracy1;

	private static readonly System.IntPtr NativeFieldInfoPtr_accuracy2;

	private static readonly System.IntPtr NativeFieldInfoPtr_accuracy3;

	private static readonly System.IntPtr NativeFieldInfoPtr_accuracy4;

	private static readonly System.IntPtr NativeFieldInfoPtr_accuracy5;

	private static readonly System.IntPtr NativeFieldInfoPtr_telephoneBookInclusionThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowPlaceOfWorkThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowAddressThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowMournThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowBirthdayThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowImmediateLocationThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomSocialCreditBuffs;

	private static readonly System.IntPtr NativeFieldInfoPtr_perkNotificationAudioEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_socialCreditBuffs;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_SocialControls_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector2 knowLoverRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowLoverRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowLoverRange)) = vector;
		}
	}

	public unsafe Vector2 knowHousemateRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowHousemateRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowHousemateRange)) = vector;
		}
	}

	public unsafe Vector2 knowFriendRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowFriendRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowFriendRange)) = vector;
		}
	}

	public unsafe Vector2 knowNeighborRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowNeighborRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowNeighborRange)) = vector;
		}
	}

	public unsafe Vector2 knowBossRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowBossRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowBossRange)) = vector;
		}
	}

	public unsafe Vector2 knowWorkTeamRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowWorkTeamRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowWorkTeamRange)) = vector;
		}
	}

	public unsafe Vector2 knowWorkRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowWorkRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowWorkRange)) = vector;
		}
	}

	public unsafe Vector2 knowWorkOtherRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowWorkOtherRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowWorkOtherRange)) = vector;
		}
	}

	public unsafe Vector2 knowRegularCustomerRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowRegularCustomerRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowRegularCustomerRange)) = vector;
		}
	}

	public unsafe Vector2 knowParamourRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowParamourRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowParamourRange)) = vector;
		}
	}

	public unsafe Vector2 knowGroupRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowGroupRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowGroupRange)) = vector;
		}
	}

	public unsafe CharacterTrait paramour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramour);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramour)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe int basePreferredBookCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basePreferredBookCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basePreferredBookCount)) = num;
		}
	}

	public unsafe List<float> wageRanges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wageRanges);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wageRanges)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Vector2> overtimeRanges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeRanges);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeRanges)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float accuracy1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accuracy1);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accuracy1)) = num;
		}
	}

	public unsafe float accuracy2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accuracy2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accuracy2)) = num;
		}
	}

	public unsafe float accuracy3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accuracy3);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accuracy3)) = num;
		}
	}

	public unsafe float accuracy4
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accuracy4);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accuracy4)) = num;
		}
	}

	public unsafe float accuracy5
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accuracy5);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accuracy5)) = num;
		}
	}

	public unsafe float telephoneBookInclusionThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telephoneBookInclusionThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telephoneBookInclusionThreshold)) = num;
		}
	}

	public unsafe float knowPlaceOfWorkThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowPlaceOfWorkThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowPlaceOfWorkThreshold)) = num;
		}
	}

	public unsafe float knowAddressThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowAddressThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowAddressThreshold)) = num;
		}
	}

	public unsafe float knowMournThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowMournThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowMournThreshold)) = num;
		}
	}

	public unsafe float knowBirthdayThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowBirthdayThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowBirthdayThreshold)) = num;
		}
	}

	public unsafe float knowImmediateLocationThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowImmediateLocationThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowImmediateLocationThreshold)) = num;
		}
	}

	public unsafe bool randomSocialCreditBuffs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSocialCreditBuffs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomSocialCreditBuffs)) = flag;
		}
	}

	public unsafe AudioEvent perkNotificationAudioEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perkNotificationAudioEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perkNotificationAudioEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe List<SocialCreditBuff> socialCreditBuffs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialCreditBuffs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SocialCreditBuff>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialCreditBuffs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static SocialControls _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SocialControls>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)socialControls));
		}
	}

	public unsafe static SocialControls Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331883, XrefRangeEnd = 331885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_SocialControls_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SocialControls>(intPtr) : null;
		}
	}

	static SocialControls()
	{
		Il2CppClassPointerStore<SocialControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SocialControls");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocialControls>.NativeClassPtr);
		NativeFieldInfoPtr_knowLoverRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowLoverRange");
		NativeFieldInfoPtr_knowHousemateRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowHousemateRange");
		NativeFieldInfoPtr_knowFriendRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowFriendRange");
		NativeFieldInfoPtr_knowNeighborRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowNeighborRange");
		NativeFieldInfoPtr_knowBossRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowBossRange");
		NativeFieldInfoPtr_knowWorkTeamRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowWorkTeamRange");
		NativeFieldInfoPtr_knowWorkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowWorkRange");
		NativeFieldInfoPtr_knowWorkOtherRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowWorkOtherRange");
		NativeFieldInfoPtr_knowRegularCustomerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowRegularCustomerRange");
		NativeFieldInfoPtr_knowParamourRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowParamourRange");
		NativeFieldInfoPtr_knowGroupRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowGroupRange");
		NativeFieldInfoPtr_paramour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "paramour");
		NativeFieldInfoPtr_basePreferredBookCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "basePreferredBookCount");
		NativeFieldInfoPtr_wageRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "wageRanges");
		NativeFieldInfoPtr_overtimeRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "overtimeRanges");
		NativeFieldInfoPtr_accuracy1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "accuracy1");
		NativeFieldInfoPtr_accuracy2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "accuracy2");
		NativeFieldInfoPtr_accuracy3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "accuracy3");
		NativeFieldInfoPtr_accuracy4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "accuracy4");
		NativeFieldInfoPtr_accuracy5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "accuracy5");
		NativeFieldInfoPtr_telephoneBookInclusionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "telephoneBookInclusionThreshold");
		NativeFieldInfoPtr_knowPlaceOfWorkThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowPlaceOfWorkThreshold");
		NativeFieldInfoPtr_knowAddressThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowAddressThreshold");
		NativeFieldInfoPtr_knowMournThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowMournThreshold");
		NativeFieldInfoPtr_knowBirthdayThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowBirthdayThreshold");
		NativeFieldInfoPtr_knowImmediateLocationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "knowImmediateLocationThreshold");
		NativeFieldInfoPtr_randomSocialCreditBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "randomSocialCreditBuffs");
		NativeFieldInfoPtr_perkNotificationAudioEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "perkNotificationAudioEvent");
		NativeFieldInfoPtr_socialCreditBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "socialCreditBuffs");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_SocialControls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, 100674128);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, 100674129);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, 100674130);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialControls>.NativeClassPtr, 100674131);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331885, XrefRangeEnd = 331922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331922, XrefRangeEnd = 331943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331943, XrefRangeEnd = 331962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SocialControls()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocialControls>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SocialControls(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
