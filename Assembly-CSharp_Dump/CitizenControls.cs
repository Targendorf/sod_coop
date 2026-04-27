using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class CitizenControls : MonoBehaviour
{
	[System.Serializable]
	public class LimbPos : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_anchor;

		private static readonly System.IntPtr NativeFieldInfoPtr_localPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_localRotation;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe CitizenOutfitController.CharacterAnchor anchor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchor);
				return *(CitizenOutfitController.CharacterAnchor*)num;
			}
			set
			{
				*(CitizenOutfitController.CharacterAnchor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchor)) = characterAnchor;
			}
		}

		public unsafe Vector3 localPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localPosition)) = vector;
			}
		}

		public unsafe Quaternion localRotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRotation);
				return *(Quaternion*)num;
			}
			set
			{
				*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRotation)) = quaternion;
			}
		}

		static LimbPos()
		{
			Il2CppClassPointerStore<LimbPos>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "LimbPos");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LimbPos>.NativeClassPtr);
			NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimbPos>.NativeClassPtr, "anchor");
			NativeFieldInfoPtr_localPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimbPos>.NativeClassPtr, "localPosition");
			NativeFieldInfoPtr_localRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimbPos>.NativeClassPtr, "localRotation");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimbPos>.NativeClassPtr, 100674072);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LimbPos()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LimbPos>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public LimbPos(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ManualAnimation : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_timeline;

		private static readonly System.IntPtr NativeFieldInfoPtr_limbData;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe float timeline
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeline);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeline)) = num;
			}
		}

		public unsafe List<LimbPos> limbData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limbData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LimbPos>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limbData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static ManualAnimation()
		{
			Il2CppClassPointerStore<ManualAnimation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "ManualAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManualAnimation>.NativeClassPtr);
			NativeFieldInfoPtr_timeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualAnimation>.NativeClassPtr, "timeline");
			NativeFieldInfoPtr_limbData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualAnimation>.NativeClassPtr, "limbData");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualAnimation>.NativeClassPtr, 100674073);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330584, XrefRangeEnd = 330590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualAnimation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualAnimation>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ManualAnimation(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class StartingInventory : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_presets;

		private static readonly System.IntPtr NativeFieldInfoPtr_baseChance;

		private static readonly System.IntPtr NativeFieldInfoPtr_modifiers;

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

		public unsafe List<InteractablePreset> presets
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presets);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe float baseChance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseChance)) = num;
			}
		}

		public unsafe List<MurderPreset.MurdererModifierRule> modifiers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifiers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderPreset.MurdererModifierRule>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static StartingInventory()
		{
			Il2CppClassPointerStore<StartingInventory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "StartingInventory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartingInventory>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingInventory>.NativeClassPtr, "name");
			NativeFieldInfoPtr_presets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingInventory>.NativeClassPtr, "presets");
			NativeFieldInfoPtr_baseChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingInventory>.NativeClassPtr, "baseChance");
			NativeFieldInfoPtr_modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingInventory>.NativeClassPtr, "modifiers");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartingInventory>.NativeClassPtr, 100674074);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330590, XrefRangeEnd = 330602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartingInventory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartingInventory>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public StartingInventory(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("CitizenControls+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__104_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__DebugCitizensStuck_b__104_0_Internal_Int32_Citizen_Citizen_0;

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

		public unsafe static Il2CppSystem.Comparison<Citizen> __9__104_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__104_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Citizen>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__104_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__104_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__104_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100674076);
			NativeMethodInfoPtr__DebugCitizensStuck_b__104_0_Internal_Int32_Citizen_Citizen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100674077);
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
		public unsafe int _DebugCitizensStuck_b__104_0(Citizen p1, Citizen p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__DebugCitizensStuck_b__104_0_Internal_Int32_Citizen_Citizen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_baseCitizenWalkSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseCitizenRunSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_acceleration;

	private static readonly System.IntPtr NativeFieldInfoPtr_decceleration;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementSpeedMultiplierRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenFaceSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenLookAtSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenFootstepDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkMovementPenalty;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkFallChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_capsuleMovementThickness;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_speechBubbleHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_askAboutJob;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSpeechBubbles;

	private static readonly System.IntPtr NativeFieldInfoPtr_societalClassSavingsCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_savingsBoostTrait;

	private static readonly System.IntPtr NativeFieldInfoPtr_savingsDebuffTrait;

	private static readonly System.IntPtr NativeFieldInfoPtr_telephoneGreeting;

	private static readonly System.IntPtr NativeFieldInfoPtr_identifyNumberDialog;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCallerDialog;

	private static readonly System.IntPtr NativeFieldInfoPtr_policeDialog;

	private static readonly System.IntPtr NativeFieldInfoPtr_coverUpOffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_coverUpBodyLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_coverUpSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_telephoneWrongPerson;

	private static readonly System.IntPtr NativeFieldInfoPtr_coverUpConvoOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_fallbackTelephoneConversation;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumInvestigateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_persuitChaseLogicAdditionPerSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxChaseLogic;

	private static readonly System.IntPtr NativeFieldInfoPtr_persuitTimerThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_persuitForgetThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_hearingForgetThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_persuitMinInvestigationTimeMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_sightingMinInvestigationTimeMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundMinInvestigationTimeMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookAtGracePeriod;

	private static readonly System.IntPtr NativeFieldInfoPtr_punchedResponseRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultMemoryLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenBaseRecoveryRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenBaseCombatSkillRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenCombatHeftMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_throwMinRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_throwMaxRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_nerveDamageShockMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_nerveWeaponDrawMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_nerveRecoveryRateMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorBargeKOForceMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_damageRecieveForceMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_ragdollTransitionTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_getUpTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_getUpManualAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_stealthSkillApplicationRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_stealthSkillCancelRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftExtent;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightExtent;

	private static readonly System.IntPtr NativeFieldInfoPtr_upExtent;

	private static readonly System.IntPtr NativeFieldInfoPtr_downExtent;

	private static readonly System.IntPtr NativeFieldInfoPtr_sittingYOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_armsStandingYOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_unknownPrint;

	private static readonly System.IntPtr NativeFieldInfoPtr_prints;

	private static readonly System.IntPtr NativeFieldInfoPtr_destitute;

	private static readonly System.IntPtr NativeFieldInfoPtr_litterBug;

	private static readonly System.IntPtr NativeFieldInfoPtr_likesTheRain;

	private static readonly System.IntPtr NativeFieldInfoPtr_shoesNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_shoesBoots;

	private static readonly System.IntPtr NativeFieldInfoPtr_shoesHeels;

	private static readonly System.IntPtr NativeFieldInfoPtr_coffeeLiker;

	private static readonly System.IntPtr NativeFieldInfoPtr_teaLiker;

	private static readonly System.IntPtr NativeFieldInfoPtr_bbCardTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_bald;

	private static readonly System.IntPtr NativeFieldInfoPtr_shortHair;

	private static readonly System.IntPtr NativeFieldInfoPtr_longHair;

	private static readonly System.IntPtr NativeFieldInfoPtr_shoeSizeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeLocalSubdivisions;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenStartingInventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_handInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_sleep;

	private static readonly System.IntPtr NativeFieldInfoPtr_matchWithPhoto;

	private static readonly System.IntPtr NativeFieldInfoPtr_weakVisualSighting;

	private static readonly System.IntPtr NativeFieldInfoPtr_mediumVisualSighting;

	private static readonly System.IntPtr NativeFieldInfoPtr_strongVisualSighting;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomPassword;

	private static readonly System.IntPtr NativeFieldInfoPtr_deadBodySearchInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_entryWound;

	private static readonly System.IntPtr NativeFieldInfoPtr_exitWound;

	private static readonly System.IntPtr NativeFieldInfoPtr_toothbrush;

	private static readonly System.IntPtr NativeFieldInfoPtr_addressBook;

	private static readonly System.IntPtr NativeFieldInfoPtr_umbrella;

	private static readonly System.IntPtr NativeFieldInfoPtr_vomitSpatter;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugSelectCitizen;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_CitizenControls_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearManualAnimation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddManualKeyframe_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugCitizensStuck_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float baseCitizenWalkSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseCitizenWalkSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseCitizenWalkSpeed)) = num;
		}
	}

	public unsafe float baseCitizenRunSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseCitizenRunSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseCitizenRunSpeed)) = num;
		}
	}

	public unsafe AnimationCurve acceleration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acceleration);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acceleration)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve decceleration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decceleration);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decceleration)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe Vector2 movementSpeedMultiplierRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeedMultiplierRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeedMultiplierRange)) = vector;
		}
	}

	public unsafe float citizenFaceSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenFaceSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenFaceSpeed)) = num;
		}
	}

	public unsafe Vector2 citizenLookAtSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenLookAtSpeed);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenLookAtSpeed)) = vector;
		}
	}

	public unsafe float citizenFootstepDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenFootstepDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenFootstepDistance)) = num;
		}
	}

	public unsafe float drunkMovementPenalty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkMovementPenalty);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkMovementPenalty)) = num;
		}
	}

	public unsafe float drunkFallChance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkFallChance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkFallChance)) = num;
		}
	}

	public unsafe Vector2 capsuleMovementThickness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capsuleMovementThickness);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_capsuleMovementThickness)) = vector;
		}
	}

	public unsafe float baseScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseScale)) = num;
		}
	}

	public unsafe float speechBubbleHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speechBubbleHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speechBubbleHeight)) = num;
		}
	}

	public unsafe DialogPreset askAboutJob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_askAboutJob);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_askAboutJob)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogPreset));
		}
	}

	public unsafe int maxSpeechBubbles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeechBubbles);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSpeechBubbles)) = num;
		}
	}

	public unsafe AnimationCurve societalClassSavingsCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_societalClassSavingsCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_societalClassSavingsCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe List<CharacterTrait> savingsBoostTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_savingsBoostTrait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_savingsBoostTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CharacterTrait> savingsDebuffTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_savingsDebuffTrait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_savingsDebuffTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe DialogPreset telephoneGreeting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telephoneGreeting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telephoneGreeting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogPreset));
		}
	}

	public unsafe DialogPreset identifyNumberDialog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifyNumberDialog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_identifyNumberDialog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogPreset));
		}
	}

	public unsafe DialogPreset lastCallerDialog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCallerDialog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCallerDialog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogPreset));
		}
	}

	public unsafe DialogPreset policeDialog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_policeDialog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_policeDialog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogPreset));
		}
	}

	public unsafe DialogPreset coverUpOffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpOffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpOffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogPreset));
		}
	}

	public unsafe DialogPreset coverUpBodyLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpBodyLocation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpBodyLocation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogPreset));
		}
	}

	public unsafe DialogPreset coverUpSuccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpSuccess);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpSuccess)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogPreset));
		}
	}

	public unsafe DialogPreset telephoneWrongPerson
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telephoneWrongPerson);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telephoneWrongPerson)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogPreset));
		}
	}

	public unsafe List<EvidenceWitness.DialogOption> coverUpConvoOptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpConvoOptions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EvidenceWitness.DialogOption>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coverUpConvoOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string fallbackTelephoneConversation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackTelephoneConversation);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallbackTelephoneConversation)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float minimumInvestigateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumInvestigateTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumInvestigateTime)) = num;
		}
	}

	public unsafe float persuitChaseLogicAdditionPerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitChaseLogicAdditionPerSecond);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitChaseLogicAdditionPerSecond)) = num;
		}
	}

	public unsafe int maxChaseLogic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxChaseLogic);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxChaseLogic)) = num;
		}
	}

	public unsafe Vector2 persuitTimerThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitTimerThreshold);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitTimerThreshold)) = vector;
		}
	}

	public unsafe float persuitForgetThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitForgetThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitForgetThreshold)) = num;
		}
	}

	public unsafe float hearingForgetThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hearingForgetThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hearingForgetThreshold)) = num;
		}
	}

	public unsafe float persuitMinInvestigationTimeMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitMinInvestigationTimeMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitMinInvestigationTimeMP)) = num;
		}
	}

	public unsafe float sightingMinInvestigationTimeMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sightingMinInvestigationTimeMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sightingMinInvestigationTimeMP)) = num;
		}
	}

	public unsafe float soundMinInvestigationTimeMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundMinInvestigationTimeMP);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundMinInvestigationTimeMP)) = num;
		}
	}

	public unsafe float lookAtGracePeriod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtGracePeriod);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtGracePeriod)) = num;
		}
	}

	public unsafe float punchedResponseRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_punchedResponseRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_punchedResponseRange)) = num;
		}
	}

	public unsafe int defaultMemoryLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultMemoryLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultMemoryLimit)) = num;
		}
	}

	public unsafe float citizenBaseRecoveryRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenBaseRecoveryRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenBaseRecoveryRate)) = num;
		}
	}

	public unsafe Vector2 citizenBaseCombatSkillRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenBaseCombatSkillRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenBaseCombatSkillRange)) = vector;
		}
	}

	public unsafe float citizenCombatHeftMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenCombatHeftMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenCombatHeftMultiplier)) = num;
		}
	}

	public unsafe float throwMinRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwMinRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwMinRange)) = num;
		}
	}

	public unsafe float throwMaxRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwMaxRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwMaxRange)) = num;
		}
	}

	public unsafe float nerveDamageShockMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nerveDamageShockMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nerveDamageShockMultiplier)) = num;
		}
	}

	public unsafe float nerveWeaponDrawMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nerveWeaponDrawMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nerveWeaponDrawMultiplier)) = num;
		}
	}

	public unsafe float nerveRecoveryRateMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nerveRecoveryRateMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nerveRecoveryRateMultiplier)) = num;
		}
	}

	public unsafe float doorBargeKOForceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorBargeKOForceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorBargeKOForceMultiplier)) = num;
		}
	}

	public unsafe float damageRecieveForceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageRecieveForceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageRecieveForceMultiplier)) = num;
		}
	}

	public unsafe float ragdollTransitionTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollTransitionTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollTransitionTime)) = num;
		}
	}

	public unsafe float getUpTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpTimer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpTimer)) = num;
		}
	}

	public unsafe List<ManualAnimation> getUpManualAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpManualAnimation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ManualAnimation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_getUpManualAnimation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float stealthSkillApplicationRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthSkillApplicationRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthSkillApplicationRate)) = num;
		}
	}

	public unsafe float stealthSkillCancelRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthSkillCancelRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthSkillCancelRate)) = num;
		}
	}

	public unsafe float leftExtent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftExtent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftExtent)) = num;
		}
	}

	public unsafe float rightExtent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightExtent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightExtent)) = num;
		}
	}

	public unsafe float upExtent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upExtent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upExtent)) = num;
		}
	}

	public unsafe float downExtent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downExtent);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downExtent)) = num;
		}
	}

	public unsafe float sittingYOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sittingYOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sittingYOffset)) = num;
		}
	}

	public unsafe float armsStandingYOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armsStandingYOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armsStandingYOffset)) = num;
		}
	}

	public unsafe Texture2D unknownPrint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unknownPrint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unknownPrint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe List<Texture2D> prints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Texture2D>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe CharacterTrait destitute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destitute);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destitute)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait litterBug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_litterBug);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_litterBug)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait likesTheRain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_likesTheRain);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_likesTheRain)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait shoesNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoesNormal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoesNormal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait shoesBoots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoesBoots);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoesBoots)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait shoesHeels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoesHeels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoesHeels)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait coffeeLiker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coffeeLiker);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coffeeLiker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait teaLiker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teaLiker);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_teaLiker)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe List<CharacterTrait> bbCardTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bbCardTraits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bbCardTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe CharacterTrait bald
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bald);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bald)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait shortHair
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortHair);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shortHair)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe CharacterTrait longHair
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longHair);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longHair)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe Vector2 shoeSizeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoeSizeRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoeSizeRange)) = vector;
		}
	}

	public unsafe List<Vector3> nodeLocalSubdivisions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeLocalSubdivisions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodeLocalSubdivisions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<StartingInventory> citizenStartingInventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenStartingInventory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StartingInventory>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenStartingInventory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe InteractablePreset citizenInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenInteractable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenInteractable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe InteractablePreset handInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handInteractable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handInteractable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe AIActionPreset sleep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleep);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleep)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
		}
	}

	public unsafe MatchPreset matchWithPhoto
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchWithPhoto);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MatchPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchWithPhoto)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matchPreset));
		}
	}

	public unsafe MatchPreset weakVisualSighting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weakVisualSighting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MatchPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weakVisualSighting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matchPreset));
		}
	}

	public unsafe MatchPreset mediumVisualSighting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumVisualSighting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MatchPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumVisualSighting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matchPreset));
		}
	}

	public unsafe MatchPreset strongVisualSighting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strongVisualSighting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MatchPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strongVisualSighting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)matchPreset));
		}
	}

	public unsafe CharacterTrait randomPassword
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomPassword);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomPassword)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe InteractablePreset deadBodySearchInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deadBodySearchInteractable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deadBodySearchInteractable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe InteractablePreset entryWound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entryWound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entryWound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe InteractablePreset exitWound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitWound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitWound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe InteractablePreset toothbrush
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toothbrush);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toothbrush)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe InteractablePreset addressBook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressBook);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressBook)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe GameObject umbrella
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_umbrella);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_umbrella)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe SpatterPatternPreset vomitSpatter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vomitSpatter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpatterPatternPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vomitSpatter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spatterPatternPreset));
		}
	}

	public unsafe CitizenOutfitController debugSelectCitizen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugSelectCitizen);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CitizenOutfitController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugSelectCitizen)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)citizenOutfitController));
		}
	}

	public unsafe static CitizenControls _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CitizenControls>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)citizenControls));
		}
	}

	public unsafe static CitizenControls Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330602, XrefRangeEnd = 330604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_CitizenControls_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CitizenControls>(intPtr) : null;
		}
	}

	static CitizenControls()
	{
		Il2CppClassPointerStore<CitizenControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CitizenControls");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr);
		NativeFieldInfoPtr_baseCitizenWalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "baseCitizenWalkSpeed");
		NativeFieldInfoPtr_baseCitizenRunSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "baseCitizenRunSpeed");
		NativeFieldInfoPtr_acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "acceleration");
		NativeFieldInfoPtr_decceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "decceleration");
		NativeFieldInfoPtr_movementSpeedMultiplierRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "movementSpeedMultiplierRange");
		NativeFieldInfoPtr_citizenFaceSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "citizenFaceSpeed");
		NativeFieldInfoPtr_citizenLookAtSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "citizenLookAtSpeed");
		NativeFieldInfoPtr_citizenFootstepDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "citizenFootstepDistance");
		NativeFieldInfoPtr_drunkMovementPenalty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "drunkMovementPenalty");
		NativeFieldInfoPtr_drunkFallChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "drunkFallChance");
		NativeFieldInfoPtr_capsuleMovementThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "capsuleMovementThickness");
		NativeFieldInfoPtr_baseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "baseScale");
		NativeFieldInfoPtr_speechBubbleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "speechBubbleHeight");
		NativeFieldInfoPtr_askAboutJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "askAboutJob");
		NativeFieldInfoPtr_maxSpeechBubbles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "maxSpeechBubbles");
		NativeFieldInfoPtr_societalClassSavingsCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "societalClassSavingsCurve");
		NativeFieldInfoPtr_savingsBoostTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "savingsBoostTrait");
		NativeFieldInfoPtr_savingsDebuffTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "savingsDebuffTrait");
		NativeFieldInfoPtr_telephoneGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "telephoneGreeting");
		NativeFieldInfoPtr_identifyNumberDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "identifyNumberDialog");
		NativeFieldInfoPtr_lastCallerDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "lastCallerDialog");
		NativeFieldInfoPtr_policeDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "policeDialog");
		NativeFieldInfoPtr_coverUpOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "coverUpOffer");
		NativeFieldInfoPtr_coverUpBodyLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "coverUpBodyLocation");
		NativeFieldInfoPtr_coverUpSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "coverUpSuccess");
		NativeFieldInfoPtr_telephoneWrongPerson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "telephoneWrongPerson");
		NativeFieldInfoPtr_coverUpConvoOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "coverUpConvoOptions");
		NativeFieldInfoPtr_fallbackTelephoneConversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "fallbackTelephoneConversation");
		NativeFieldInfoPtr_minimumInvestigateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "minimumInvestigateTime");
		NativeFieldInfoPtr_persuitChaseLogicAdditionPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "persuitChaseLogicAdditionPerSecond");
		NativeFieldInfoPtr_maxChaseLogic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "maxChaseLogic");
		NativeFieldInfoPtr_persuitTimerThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "persuitTimerThreshold");
		NativeFieldInfoPtr_persuitForgetThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "persuitForgetThreshold");
		NativeFieldInfoPtr_hearingForgetThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "hearingForgetThreshold");
		NativeFieldInfoPtr_persuitMinInvestigationTimeMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "persuitMinInvestigationTimeMP");
		NativeFieldInfoPtr_sightingMinInvestigationTimeMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "sightingMinInvestigationTimeMP");
		NativeFieldInfoPtr_soundMinInvestigationTimeMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "soundMinInvestigationTimeMP");
		NativeFieldInfoPtr_lookAtGracePeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "lookAtGracePeriod");
		NativeFieldInfoPtr_punchedResponseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "punchedResponseRange");
		NativeFieldInfoPtr_defaultMemoryLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "defaultMemoryLimit");
		NativeFieldInfoPtr_citizenBaseRecoveryRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "citizenBaseRecoveryRate");
		NativeFieldInfoPtr_citizenBaseCombatSkillRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "citizenBaseCombatSkillRange");
		NativeFieldInfoPtr_citizenCombatHeftMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "citizenCombatHeftMultiplier");
		NativeFieldInfoPtr_throwMinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "throwMinRange");
		NativeFieldInfoPtr_throwMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "throwMaxRange");
		NativeFieldInfoPtr_nerveDamageShockMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "nerveDamageShockMultiplier");
		NativeFieldInfoPtr_nerveWeaponDrawMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "nerveWeaponDrawMultiplier");
		NativeFieldInfoPtr_nerveRecoveryRateMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "nerveRecoveryRateMultiplier");
		NativeFieldInfoPtr_doorBargeKOForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "doorBargeKOForceMultiplier");
		NativeFieldInfoPtr_damageRecieveForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "damageRecieveForceMultiplier");
		NativeFieldInfoPtr_ragdollTransitionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "ragdollTransitionTime");
		NativeFieldInfoPtr_getUpTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "getUpTimer");
		NativeFieldInfoPtr_getUpManualAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "getUpManualAnimation");
		NativeFieldInfoPtr_stealthSkillApplicationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "stealthSkillApplicationRate");
		NativeFieldInfoPtr_stealthSkillCancelRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "stealthSkillCancelRate");
		NativeFieldInfoPtr_leftExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "leftExtent");
		NativeFieldInfoPtr_rightExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "rightExtent");
		NativeFieldInfoPtr_upExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "upExtent");
		NativeFieldInfoPtr_downExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "downExtent");
		NativeFieldInfoPtr_sittingYOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "sittingYOffset");
		NativeFieldInfoPtr_armsStandingYOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "armsStandingYOffset");
		NativeFieldInfoPtr_unknownPrint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "unknownPrint");
		NativeFieldInfoPtr_prints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "prints");
		NativeFieldInfoPtr_destitute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "destitute");
		NativeFieldInfoPtr_litterBug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "litterBug");
		NativeFieldInfoPtr_likesTheRain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "likesTheRain");
		NativeFieldInfoPtr_shoesNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "shoesNormal");
		NativeFieldInfoPtr_shoesBoots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "shoesBoots");
		NativeFieldInfoPtr_shoesHeels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "shoesHeels");
		NativeFieldInfoPtr_coffeeLiker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "coffeeLiker");
		NativeFieldInfoPtr_teaLiker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "teaLiker");
		NativeFieldInfoPtr_bbCardTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "bbCardTraits");
		NativeFieldInfoPtr_bald = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "bald");
		NativeFieldInfoPtr_shortHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "shortHair");
		NativeFieldInfoPtr_longHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "longHair");
		NativeFieldInfoPtr_shoeSizeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "shoeSizeRange");
		NativeFieldInfoPtr_nodeLocalSubdivisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "nodeLocalSubdivisions");
		NativeFieldInfoPtr_citizenStartingInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "citizenStartingInventory");
		NativeFieldInfoPtr_citizenInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "citizenInteractable");
		NativeFieldInfoPtr_handInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "handInteractable");
		NativeFieldInfoPtr_sleep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "sleep");
		NativeFieldInfoPtr_matchWithPhoto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "matchWithPhoto");
		NativeFieldInfoPtr_weakVisualSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "weakVisualSighting");
		NativeFieldInfoPtr_mediumVisualSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "mediumVisualSighting");
		NativeFieldInfoPtr_strongVisualSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "strongVisualSighting");
		NativeFieldInfoPtr_randomPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "randomPassword");
		NativeFieldInfoPtr_deadBodySearchInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "deadBodySearchInteractable");
		NativeFieldInfoPtr_entryWound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "entryWound");
		NativeFieldInfoPtr_exitWound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "exitWound");
		NativeFieldInfoPtr_toothbrush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "toothbrush");
		NativeFieldInfoPtr_addressBook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "addressBook");
		NativeFieldInfoPtr_umbrella = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "umbrella");
		NativeFieldInfoPtr_vomitSpatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "vomitSpatter");
		NativeFieldInfoPtr_debugSelectCitizen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "debugSelectCitizen");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_CitizenControls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, 100674065);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, 100674066);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, 100674067);
		NativeMethodInfoPtr_ClearManualAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, 100674068);
		NativeMethodInfoPtr_AddManualKeyframe_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, 100674069);
		NativeMethodInfoPtr_DebugCitizensStuck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, 100674070);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr, 100674071);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330604, XrefRangeEnd = 330641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330641, XrefRangeEnd = 330662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330662, XrefRangeEnd = 330664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearManualAnimation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearManualAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330664, XrefRangeEnd = 330709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddManualKeyframe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddManualKeyframe_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330709, XrefRangeEnd = 330874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugCitizensStuck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugCitizensStuck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330874, XrefRangeEnd = 330908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CitizenControls()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CitizenControls>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CitizenControls(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
