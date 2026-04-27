using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class RevengeObjective : SoCustomComparison
{
	public enum SpecialConditions
	{
		mustHaveWindows,
		trackProgressFromAddressQuestion,
		trackProgressFromNameQuestion
	}

	[System.Serializable]
	[ObfuscatedName("RevengeObjective+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__30_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__KickDownDoor_b__30_0_Internal_Boolean_NodeAccess_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewNode.NodeAccess> __9__30_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewNode.NodeAccess>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__30_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__30_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100674020);
			NativeMethodInfoPtr__KickDownDoor_b__30_0_Internal_Boolean_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100674021);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329902, XrefRangeEnd = 329913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _KickDownDoor_b__30_0(NewNode.NodeAccess item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__KickDownDoor_b__30_0_Internal_Boolean_NodeAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_disabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_useHEXACO;

	private static readonly System.IntPtr NativeFieldInfoPtr_feminineMasculine;

	private static readonly System.IntPtr NativeFieldInfoPtr_humility;

	private static readonly System.IntPtr NativeFieldInfoPtr_emotionality;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraversion;

	private static readonly System.IntPtr NativeFieldInfoPtr_agreeableness;

	private static readonly System.IntPtr NativeFieldInfoPtr_conscientiousness;

	private static readonly System.IntPtr NativeFieldInfoPtr_creativity;

	private static readonly System.IntPtr NativeFieldInfoPtr_useTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterTraitsPoster;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterTraitsPurp;

	private static readonly System.IntPtr NativeFieldInfoPtr_specialConditions;

	private static readonly System.IntPtr NativeFieldInfoPtr_d0Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_d1Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_idTargetName;

	private static readonly System.IntPtr NativeFieldInfoPtr_tag;

	private static readonly System.IntPtr NativeFieldInfoPtr_icon;

	private static readonly System.IntPtr NativeFieldInfoPtr_passedNumberRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_rewardMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_resolveQuestionName;

	private static readonly System.IntPtr NativeFieldInfoPtr_resolveQuestionNameAlternate;

	private static readonly System.IntPtr NativeFieldInfoPtr_answerMethod;

	private static readonly System.IntPtr NativeMethodInfoPtr_Vandalism_Public_Single_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VandalismTrash_Public_Single_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_VandalismWindow_Public_Single_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Handcuff_Public_Boolean_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeatUp_Public_Boolean_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KickDownDoor_Public_Boolean_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManualTrigger_Public_Boolean_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe int baseChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChance)) = num;
		}
	}

	public unsafe bool useHEXACO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useHEXACO);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useHEXACO)) = flag;
		}
	}

	public unsafe int feminineMasculine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feminineMasculine);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feminineMasculine)) = num;
		}
	}

	public unsafe int humility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humility);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humility)) = num;
		}
	}

	public unsafe int emotionality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotionality);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotionality)) = num;
		}
	}

	public unsafe int extraversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraversion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraversion)) = num;
		}
	}

	public unsafe int agreeableness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agreeableness);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agreeableness)) = num;
		}
	}

	public unsafe int conscientiousness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conscientiousness);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conscientiousness)) = num;
		}
	}

	public unsafe int creativity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creativity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creativity)) = num;
		}
	}

	public unsafe bool useTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTraits);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTraits)) = flag;
		}
	}

	public unsafe List<ClothesPreset.TraitPickRule> characterTraitsPoster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterTraitsPoster);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ClothesPreset.TraitPickRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterTraitsPoster)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ClothesPreset.TraitPickRule> characterTraitsPurp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterTraitsPurp);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ClothesPreset.TraitPickRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterTraitsPurp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SpecialConditions> specialConditions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialConditions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SpecialConditions>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialConditions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string d0Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d0Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d0Name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string d1Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d1Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d1Name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string idTargetName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idTargetName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idTargetName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe JobPreset.JobTag tag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tag);
			return *(JobPreset.JobTag*)num;
		}
		set
		{
			*(JobPreset.JobTag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tag)) = jobTag;
		}
	}

	public unsafe InterfaceControls.Icon icon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon);
			return *(InterfaceControls.Icon*)num;
		}
		set
		{
			*(InterfaceControls.Icon*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_icon)) = icon;
		}
	}

	public unsafe Vector2 passedNumberRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedNumberRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedNumberRange)) = vector;
		}
	}

	public unsafe Vector2 rewardMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewardMultiplier);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewardMultiplier)) = vector;
		}
	}

	public unsafe string resolveQuestionName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolveQuestionName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolveQuestionName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string resolveQuestionNameAlternate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolveQuestionNameAlternate);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolveQuestionNameAlternate)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string answerMethod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_answerMethod);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_answerMethod)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static RevengeObjective()
	{
		Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RevengeObjective");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr);
		NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "disabled");
		NativeFieldInfoPtr_baseChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "baseChance");
		NativeFieldInfoPtr_useHEXACO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "useHEXACO");
		NativeFieldInfoPtr_feminineMasculine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "feminineMasculine");
		NativeFieldInfoPtr_humility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "humility");
		NativeFieldInfoPtr_emotionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "emotionality");
		NativeFieldInfoPtr_extraversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "extraversion");
		NativeFieldInfoPtr_agreeableness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "agreeableness");
		NativeFieldInfoPtr_conscientiousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "conscientiousness");
		NativeFieldInfoPtr_creativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "creativity");
		NativeFieldInfoPtr_useTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "useTraits");
		NativeFieldInfoPtr_characterTraitsPoster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "characterTraitsPoster");
		NativeFieldInfoPtr_characterTraitsPurp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "characterTraitsPurp");
		NativeFieldInfoPtr_specialConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "specialConditions");
		NativeFieldInfoPtr_d0Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "d0Name");
		NativeFieldInfoPtr_d1Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "d1Name");
		NativeFieldInfoPtr_idTargetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "idTargetName");
		NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "tag");
		NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "icon");
		NativeFieldInfoPtr_passedNumberRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "passedNumberRange");
		NativeFieldInfoPtr_rewardMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "rewardMultiplier");
		NativeFieldInfoPtr_resolveQuestionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "resolveQuestionName");
		NativeFieldInfoPtr_resolveQuestionNameAlternate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "resolveQuestionNameAlternate");
		NativeFieldInfoPtr_answerMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, "answerMethod");
		NativeMethodInfoPtr_Vandalism_Public_Single_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, 100674011);
		NativeMethodInfoPtr_VandalismTrash_Public_Single_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, 100674012);
		NativeMethodInfoPtr_VandalismWindow_Public_Single_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, 100674013);
		NativeMethodInfoPtr_Handcuff_Public_Boolean_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, 100674014);
		NativeMethodInfoPtr_BeatUp_Public_Boolean_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, 100674015);
		NativeMethodInfoPtr_KickDownDoor_Public_Boolean_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, 100674016);
		NativeMethodInfoPtr_ManualTrigger_Public_Boolean_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, 100674017);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr, 100674018);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329913, XrefRangeEnd = 329936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Vandalism(int target, int location, float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&target);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Vandalism_Public_Single_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329936, XrefRangeEnd = 329959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float VandalismTrash(int target, int location, float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&target);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VandalismTrash_Public_Single_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329959, XrefRangeEnd = 329982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float VandalismWindow(int target, int location, float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&target);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_VandalismWindow_Public_Single_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329982, XrefRangeEnd = 329997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Handcuff(int target, int location, float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&target);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Handcuff_Public_Boolean_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329997, XrefRangeEnd = 330011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool BeatUp(int target, int location, float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&target);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeatUp_Public_Boolean_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330011, XrefRangeEnd = 330032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool KickDownDoor(int target, int location, float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&target);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KickDownDoor_Public_Boolean_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool ManualTrigger(int target, int location, float amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&target);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &location;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &amount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManualTrigger_Public_Boolean_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330032, XrefRangeEnd = 330059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RevengeObjective()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevengeObjective>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RevengeObjective(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
