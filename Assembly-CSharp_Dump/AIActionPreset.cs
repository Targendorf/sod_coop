using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class AIActionPreset : SoCustomComparison
{
	public enum ActionLocation
	{
		interactable,
		findNearest,
		investigate,
		nearbyInvestigate,
		pause,
		randomNodeWithinLocation,
		flee,
		interactableLOS,
		meetOther,
		NearbyStreetRandomNode,
		putDownInteractable,
		pickUpInteractable,
		randomNodeWithinHome,
		interactableSpawn,
		proximityToMusic,
		player,
		tailAndConfrontPlayer,
		sniperVantagePoint,
		randomNodeWithinLocationPrioritiseWindows,
		randomNodeWithinDen,
		victimApartmentDoor,
		playerApartmentDoorOutside
	}

	public enum ActionFacingDirection
	{
		towardsDestination,
		awayFromDestination,
		interactable,
		InverseInteractable,
		accessableDirection,
		investigate,
		door,
		interactableSetting,
		none,
		inverseInteractableSetting,
		player,
		sniperVantagePoint,
		victim,
		awayFromSniperVantagePoint
	}

	public enum ActionFinding
	{
		doNothing,
		findNearest,
		removeAction,
		removeGoal
	}

	public enum ActionBusy
	{
		findAlternate,
		skipAction,
		skipGoal,
		standGuard,
		standGuardIfEnforcerSkipGoalNot
	}

	public enum FindSetting
	{
		nonTrespassing,
		onlyPublic,
		allAreas,
		homeOnly,
		workOnly
	}

	[System.Serializable]
	public class AISpeechPreset : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_dictionaryString;

		private static readonly System.IntPtr NativeFieldInfoPtr_ddsMessageID;

		private static readonly System.IntPtr NativeFieldInfoPtr_isSuccessful;

		private static readonly System.IntPtr NativeFieldInfoPtr_chance;

		private static readonly System.IntPtr NativeFieldInfoPtr_useParsing;

		private static readonly System.IntPtr NativeFieldInfoPtr_shout;

		private static readonly System.IntPtr NativeFieldInfoPtr_interupt;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfEnfocerOnDuty;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfNotEnforcerOnDuty;

		private static readonly System.IntPtr NativeFieldInfoPtr_mustFeatureTrait;

		private static readonly System.IntPtr NativeFieldInfoPtr_cantFeatureTrait;

		private static readonly System.IntPtr NativeFieldInfoPtr_mustBeKillerWithMotive;

		private static readonly System.IntPtr NativeFieldInfoPtr_useMurderMOConfession;

		private static readonly System.IntPtr NativeFieldInfoPtr_tieKeys;

		private static readonly System.IntPtr NativeFieldInfoPtr_applyDiscovery;

		private static readonly System.IntPtr NativeFieldInfoPtr_endsDialog;

		private static readonly System.IntPtr NativeFieldInfoPtr_jobHandIn;

		private static readonly System.IntPtr NativeFieldInfoPtr_startCombat;

		private static readonly System.IntPtr NativeFieldInfoPtr_flee;

		private static readonly System.IntPtr NativeFieldInfoPtr_giveUpSelf;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string dictionaryString
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dictionaryString);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dictionaryString)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string ddsMessageID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsMessageID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsMessageID)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe bool isSuccessful
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSuccessful);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSuccessful)) = flag;
			}
		}

		public unsafe int chance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance)) = num;
			}
		}

		public unsafe bool useParsing
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useParsing);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useParsing)) = flag;
			}
		}

		public unsafe bool shout
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shout);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shout)) = flag;
			}
		}

		public unsafe bool interupt
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interupt);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interupt)) = flag;
			}
		}

		public unsafe bool onlyIfEnfocerOnDuty
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfEnfocerOnDuty);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfEnfocerOnDuty)) = flag;
			}
		}

		public unsafe bool onlyIfNotEnforcerOnDuty
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfNotEnforcerOnDuty);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfNotEnforcerOnDuty)) = flag;
			}
		}

		public unsafe List<CharacterTrait> mustFeatureTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustFeatureTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustFeatureTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<CharacterTrait> cantFeatureTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cantFeatureTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cantFeatureTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<MurderMO> mustBeKillerWithMotive
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustBeKillerWithMotive);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderMO>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustBeKillerWithMotive)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool useMurderMOConfession
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMurderMOConfession);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useMurderMOConfession)) = flag;
			}
		}

		public unsafe List<Evidence.DataKey> tieKeys
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tieKeys);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tieKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<Evidence.Discovery> applyDiscovery
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyDiscovery);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.Discovery>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyDiscovery)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool endsDialog
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endsDialog);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endsDialog)) = flag;
			}
		}

		public unsafe bool jobHandIn
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobHandIn);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobHandIn)) = flag;
			}
		}

		public unsafe bool startCombat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startCombat);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startCombat)) = flag;
			}
		}

		public unsafe bool flee
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flee);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flee)) = flag;
			}
		}

		public unsafe bool giveUpSelf
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_giveUpSelf);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_giveUpSelf)) = flag;
			}
		}

		static AISpeechPreset()
		{
			Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "AISpeechPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr);
			NativeFieldInfoPtr_dictionaryString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "dictionaryString");
			NativeFieldInfoPtr_ddsMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "ddsMessageID");
			NativeFieldInfoPtr_isSuccessful = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "isSuccessful");
			NativeFieldInfoPtr_chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "chance");
			NativeFieldInfoPtr_useParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "useParsing");
			NativeFieldInfoPtr_shout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "shout");
			NativeFieldInfoPtr_interupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "interupt");
			NativeFieldInfoPtr_onlyIfEnfocerOnDuty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "onlyIfEnfocerOnDuty");
			NativeFieldInfoPtr_onlyIfNotEnforcerOnDuty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "onlyIfNotEnforcerOnDuty");
			NativeFieldInfoPtr_mustFeatureTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "mustFeatureTrait");
			NativeFieldInfoPtr_cantFeatureTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "cantFeatureTrait");
			NativeFieldInfoPtr_mustBeKillerWithMotive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "mustBeKillerWithMotive");
			NativeFieldInfoPtr_useMurderMOConfession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "useMurderMOConfession");
			NativeFieldInfoPtr_tieKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "tieKeys");
			NativeFieldInfoPtr_applyDiscovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "applyDiscovery");
			NativeFieldInfoPtr_endsDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "endsDialog");
			NativeFieldInfoPtr_jobHandIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "jobHandIn");
			NativeFieldInfoPtr_startCombat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "startCombat");
			NativeFieldInfoPtr_flee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "flee");
			NativeFieldInfoPtr_giveUpSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, "giveUpSelf");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr, 100673778);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326538, RefRangeEnd = 326539, XrefRangeStart = 326510, XrefRangeEnd = 326538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AISpeechPreset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AISpeechPreset>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AISpeechPreset(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class AutomaticAction : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_forcedAction;

		private static readonly System.IntPtr NativeFieldInfoPtr_proximityCheck;

		private static readonly System.IntPtr NativeFieldInfoPtr_additionalDelay;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe AIActionPreset forcedAction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedAction);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AIActionPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aIActionPreset));
			}
		}

		public unsafe bool proximityCheck
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_proximityCheck);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_proximityCheck)) = flag;
			}
		}

		public unsafe float additionalDelay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalDelay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalDelay)) = num;
			}
		}

		static AutomaticAction()
		{
			Il2CppClassPointerStore<AutomaticAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "AutomaticAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutomaticAction>.NativeClassPtr);
			NativeFieldInfoPtr_forcedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticAction>.NativeClassPtr, "forcedAction");
			NativeFieldInfoPtr_proximityCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticAction>.NativeClassPtr, "proximityCheck");
			NativeFieldInfoPtr_additionalDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticAction>.NativeClassPtr, "additionalDelay");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticAction>.NativeClassPtr, 100673779);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutomaticAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutomaticAction>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AutomaticAction(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum SourceOfBannedRooms
	{
		none,
		jobPreset
	}

	public enum CombatPose
	{
		noChange,
		always,
		never,
		onlyWhenPreviouslyPersuing,
		onlyWhenAtDestination
	}

	public enum ForcedActionsSearchLevel
	{
		thisObjectOnly,
		otherIntegratedInteractables,
		spawnInteractablesChildren,
		spawnedInteractablesAll,
		InteractablesOnNode
	}

	[System.Serializable]
	public class CheckActionAgainstState : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_switchState;

		private static readonly System.IntPtr NativeFieldInfoPtr_switchIs;

		private static readonly System.IntPtr NativeFieldInfoPtr_outcome;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe InteractablePreset.Switch switchState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchState);
				return *(InteractablePreset.Switch*)num;
			}
			set
			{
				*(InteractablePreset.Switch*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchState)) = obj;
			}
		}

		public unsafe bool switchIs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchIs);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchIs)) = flag;
			}
		}

		public unsafe CheckActionOutcome outcome
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outcome);
				return *(CheckActionOutcome*)num;
			}
			set
			{
				*(CheckActionOutcome*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outcome)) = checkActionOutcome;
			}
		}

		static CheckActionAgainstState()
		{
			Il2CppClassPointerStore<CheckActionAgainstState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "CheckActionAgainstState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckActionAgainstState>.NativeClassPtr);
			NativeFieldInfoPtr_switchState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckActionAgainstState>.NativeClassPtr, "switchState");
			NativeFieldInfoPtr_switchIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckActionAgainstState>.NativeClassPtr, "switchIs");
			NativeFieldInfoPtr_outcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckActionAgainstState>.NativeClassPtr, "outcome");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActionAgainstState>.NativeClassPtr, 100673780);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckActionAgainstState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckActionAgainstState>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CheckActionAgainstState(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum CheckActionOutcome
	{
		cancelAction,
		cancelGoal
	}

	public enum DoorRule
	{
		normal,
		dontLock,
		dontClose,
		onlyCloseToLocation,
		onlyLockToLocation
	}

	public enum LightRule
	{
		normal,
		dontSwitch,
		onlyWhenArrived
	}

	public enum ActionStateFlag
	{
		onActivation,
		onArrival,
		onDeactivation,
		onGoalDeactivation,
		none
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_debug;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_unavailableWhenItemSelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_unavailableWhenItemsSelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyAvailableWhenItemSelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_availableWhenItemsSelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_holsterCurrentItemOnAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableUIDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowInteractionAtRecognitionRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_confirmActionLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_useRandomNodeSublocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_onUnableToFindLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_searchSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_onUsePointBusy;

	private static readonly System.IntPtr NativeFieldInfoPtr_usageSlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCloseEnoughSetting;

	private static readonly System.IntPtr NativeFieldInfoPtr_robberyPriorityMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_avoidRepeatingInteractables;

	private static readonly System.IntPtr NativeFieldInfoPtr_filterSearchUsingRoomType;

	private static readonly System.IntPtr NativeFieldInfoPtr_searchRoomType;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitSearchToGoalLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_findOverrideWithHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresTelephone;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresTelephoneNoCall;

	private static readonly System.IntPtr NativeFieldInfoPtr_activationRequiresConsumable;

	private static readonly System.IntPtr NativeFieldInfoPtr_bannedRooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_completableAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_minutesTakenRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_completeOnSeeIllegal;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatOnComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatWhileHavingConsumables;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresForcedUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableImmediateCompletionWhenFarAway;

	private static readonly System.IntPtr NativeFieldInfoPtr_dontUpdateGoalPriorityWhileActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_dontUpdateGoalPriorityFor;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitTickRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumTickRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumTickRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_dontRemoveOnRefresh;

	private static readonly System.IntPtr NativeFieldInfoPtr_nonRefreshable;

	private static readonly System.IntPtr NativeFieldInfoPtr_useLOSCheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_cancelIfNonValidMugging;

	private static readonly System.IntPtr NativeFieldInfoPtr_cancelIfPlayerNotLoitering;

	private static readonly System.IntPtr NativeFieldInfoPtr_skipIfAIIsInState;

	private static readonly System.IntPtr NativeFieldInfoPtr_skipIfReaction;

	private static readonly System.IntPtr NativeFieldInfoPtr_skipIfGuestPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_facing;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookAround;

	private static readonly System.IntPtr NativeFieldInfoPtr_cancelIfPersuitTargetNotInRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_facePlayerWhileTalkingTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeIdleOnActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleAnimationOnActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeIdleOnArrival;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleAnimationOnArrival;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeIdleOnDeactivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleAnimationOnDeactivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeIdleOnComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_idleAnimationOnComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeArmsOnActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_armsAnimationOnActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeArmsOnArrival;

	private static readonly System.IntPtr NativeFieldInfoPtr_armsAnimationOnArrival;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeArmsOnDeactivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_armsAnimationOnDeactivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeArmsOnComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_armsAnimationOnComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_lying;

	private static readonly System.IntPtr NativeFieldInfoPtr_lyingOnFloor;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCurrentConsumable;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressNourishment;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressHydration;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressAlertness;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressEnergy;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressExcitement;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressChores;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressHygeiene;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressBladder;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressHeat;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressDrunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressBreath;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressPoisoned;

	private static readonly System.IntPtr NativeFieldInfoPtr_overtimeNourishment;

	private static readonly System.IntPtr NativeFieldInfoPtr_overtimeHydration;

	private static readonly System.IntPtr NativeFieldInfoPtr_overtimeAlertness;

	private static readonly System.IntPtr NativeFieldInfoPtr_overtimeEnergy;

	private static readonly System.IntPtr NativeFieldInfoPtr_overtimeExcitement;

	private static readonly System.IntPtr NativeFieldInfoPtr_overtimeChores;

	private static readonly System.IntPtr NativeFieldInfoPtr_overtimeHygiene;

	private static readonly System.IntPtr NativeFieldInfoPtr_overtimeBladder;

	private static readonly System.IntPtr NativeFieldInfoPtr_overtimeHeat;

	private static readonly System.IntPtr NativeFieldInfoPtr_overtimeDrunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_overtimeBreath;

	private static readonly System.IntPtr NativeFieldInfoPtr_overtimePoison;

	private static readonly System.IntPtr NativeFieldInfoPtr_useInvestigationUrgency;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceRun;

	private static readonly System.IntPtr NativeFieldInfoPtr_runIfSeesPlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_socialRules;

	private static readonly System.IntPtr NativeFieldInfoPtr_spookAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableSightingUpdates;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackPersuitTargetOnProximity;

	private static readonly System.IntPtr NativeFieldInfoPtr_throwObjectsAtTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCombatPose;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyUseCombatPoseWithEscalationOne;

	private static readonly System.IntPtr NativeFieldInfoPtr_sleepOnArrival;

	private static readonly System.IntPtr NativeFieldInfoPtr_uninteruptableWhileAtLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_progressVmailThreads;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableConversationTriggers;

	private static readonly System.IntPtr NativeFieldInfoPtr_exitConversationOnActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcedActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcedActionsOnArrival;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcedActionsOnComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcedActionsSearchLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_executeCompleteActionsOnEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_executeCompleteActionsOnEndIfArrived;

	private static readonly System.IntPtr NativeFieldInfoPtr_executeThisOnComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_switchStatesOnEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_tamperAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_tamperResetAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_fallAsleepAfterMinimum;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowSniperShot;

	private static readonly System.IntPtr NativeFieldInfoPtr_checkActionAgainstState;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceReactionState;

	private static readonly System.IntPtr NativeFieldInfoPtr_setReactionState;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignoreLockedDoors;

	private static readonly System.IntPtr NativeFieldInfoPtr_breakDownDoors;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorsAllowed;

	private static readonly System.IntPtr NativeFieldInfoPtr_deactivateAllowed;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatDelayOnActionFail;

	private static readonly System.IntPtr NativeFieldInfoPtr_repeatDelayOnActionSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_turnAllGamelocationLightsOff;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideGoalLightRule;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyOverrideIfAtGamelocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightingBehaviour;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideGoalDoorRule;

	private static readonly System.IntPtr NativeFieldInfoPtr_doorRule;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnTauntOnSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_onArrivalSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLoop;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_outdoorClothingCheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_specificOutfitOnActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedOutfitOnActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_makeClothedOnActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_specificOutfitOnArrive;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedOutfitOnArrive;

	private static readonly System.IntPtr NativeFieldInfoPtr_makeClothedOnArrive;

	private static readonly System.IntPtr NativeFieldInfoPtr_specificOutfitOnDeactivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedOutfitOnDeactivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_makeClothedOnDeactivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_specificOutfitOnComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowedOutfitOnComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_makeClothedOnComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_setExpressionOnActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_activateExpression;

	private static readonly System.IntPtr NativeFieldInfoPtr_setExpressionOnArrive;

	private static readonly System.IntPtr NativeFieldInfoPtr_arriveExpression;

	private static readonly System.IntPtr NativeFieldInfoPtr_setExpressionOnDeactivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_deactivateExpression;

	private static readonly System.IntPtr NativeFieldInfoPtr_setExpressionOnComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_completeExpression;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableCustomItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemRightLocalPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemRightLocalEuler;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemLeftLocalPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemLeftLocalEuler;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnCustomItemOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_destroyCustomItemOn;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresCarryAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideCarryAnimation;

	private static readonly System.IntPtr NativeFieldInfoPtr_dropItemOnEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfOnTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_onTriggerBark;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfWhileJourney;

	private static readonly System.IntPtr NativeFieldInfoPtr_whileJourneyBark;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfOnArrival;

	private static readonly System.IntPtr NativeFieldInfoPtr_onArrivalBark;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfWhileArrived;

	private static readonly System.IntPtr NativeFieldInfoPtr_mustSeeOtherCitizen;

	private static readonly System.IntPtr NativeFieldInfoPtr_whileArrivedBark;

	private static readonly System.IntPtr NativeFieldInfoPtr_chanceOfOnComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_onCompleteBark;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe InteractablePreset.InteractionKey defaultKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultKey);
			return *(InteractablePreset.InteractionKey*)num;
		}
		set
		{
			*(InteractablePreset.InteractionKey*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultKey)) = interactionKey;
		}
	}

	public unsafe bool debug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debug)) = flag;
		}
	}

	public unsafe int inputPriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputPriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputPriority)) = num;
		}
	}

	public unsafe bool unavailableWhenItemSelected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unavailableWhenItemSelected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unavailableWhenItemSelected)) = flag;
		}
	}

	public unsafe List<FirstPersonItem> unavailableWhenItemsSelected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unavailableWhenItemsSelected);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FirstPersonItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unavailableWhenItemsSelected)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool onlyAvailableWhenItemSelected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAvailableWhenItemSelected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyAvailableWhenItemSelected)) = flag;
		}
	}

	public unsafe List<FirstPersonItem> availableWhenItemsSelected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableWhenItemsSelected);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FirstPersonItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableWhenItemsSelected)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool holsterCurrentItemOnAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holsterCurrentItemOnAction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holsterCurrentItemOnAction)) = flag;
		}
	}

	public unsafe bool disableUIDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableUIDisplay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableUIDisplay)) = flag;
		}
	}

	public unsafe bool allowInteractionAtRecognitionRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInteractionAtRecognitionRange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInteractionAtRecognitionRange)) = flag;
		}
	}

	public unsafe ActionLocation actionLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionLocation);
			return *(ActionLocation*)num;
		}
		set
		{
			*(ActionLocation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionLocation)) = actionLocation;
		}
	}

	public unsafe bool confirmActionLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confirmActionLocation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confirmActionLocation)) = flag;
		}
	}

	public unsafe bool useRandomNodeSublocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRandomNodeSublocation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRandomNodeSublocation)) = flag;
		}
	}

	public unsafe ActionFinding onUnableToFindLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onUnableToFindLocation);
			return *(ActionFinding*)num;
		}
		set
		{
			*(ActionFinding*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onUnableToFindLocation)) = actionFinding;
		}
	}

	public unsafe FindSetting searchSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchSetting);
			return *(FindSetting*)num;
		}
		set
		{
			*(FindSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchSetting)) = findSetting;
		}
	}

	public unsafe ActionBusy onUsePointBusy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onUsePointBusy);
			return *(ActionBusy*)num;
		}
		set
		{
			*(ActionBusy*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onUsePointBusy)) = actionBusy;
		}
	}

	public unsafe Interactable.UsePointSlot usageSlot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageSlot);
			return *(Interactable.UsePointSlot*)num;
		}
		set
		{
			*(Interactable.UsePointSlot*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usageSlot)) = usePointSlot;
		}
	}

	public unsafe bool useCloseEnoughSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCloseEnoughSetting);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCloseEnoughSetting)) = flag;
		}
	}

	public unsafe float robberyPriorityMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_robberyPriorityMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_robberyPriorityMultiplier)) = num;
		}
	}

	public unsafe bool avoidRepeatingInteractables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoidRepeatingInteractables);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoidRepeatingInteractables)) = flag;
		}
	}

	public unsafe bool filterSearchUsingRoomType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filterSearchUsingRoomType);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filterSearchUsingRoomType)) = flag;
		}
	}

	public unsafe List<RoomTypePreset> searchRoomType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchRoomType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomTypePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchRoomType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool limitSearchToGoalLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitSearchToGoalLocation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitSearchToGoalLocation)) = flag;
		}
	}

	public unsafe bool findOverrideWithHome
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_findOverrideWithHome);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_findOverrideWithHome)) = flag;
		}
	}

	public unsafe bool requiresTelephone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresTelephone);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresTelephone)) = flag;
		}
	}

	public unsafe bool requiresTelephoneNoCall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresTelephoneNoCall);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresTelephoneNoCall)) = flag;
		}
	}

	public unsafe bool activationRequiresConsumable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activationRequiresConsumable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activationRequiresConsumable)) = flag;
		}
	}

	public unsafe SourceOfBannedRooms bannedRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bannedRooms);
			return *(SourceOfBannedRooms*)num;
		}
		set
		{
			*(SourceOfBannedRooms*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bannedRooms)) = sourceOfBannedRooms;
		}
	}

	public unsafe bool completableAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completableAction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completableAction)) = flag;
		}
	}

	public unsafe Vector2 minutesTakenRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minutesTakenRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minutesTakenRange)) = vector;
		}
	}

	public unsafe bool completeOnSeeIllegal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completeOnSeeIllegal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completeOnSeeIllegal)) = flag;
		}
	}

	public unsafe bool repeatOnComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatOnComplete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatOnComplete)) = flag;
		}
	}

	public unsafe bool repeatWhileHavingConsumables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatWhileHavingConsumables);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatWhileHavingConsumables)) = flag;
		}
	}

	public unsafe bool requiresForcedUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresForcedUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresForcedUpdate)) = flag;
		}
	}

	public unsafe bool enableImmediateCompletionWhenFarAway
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableImmediateCompletionWhenFarAway);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableImmediateCompletionWhenFarAway)) = flag;
		}
	}

	public unsafe bool dontUpdateGoalPriorityWhileActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontUpdateGoalPriorityWhileActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontUpdateGoalPriorityWhileActive)) = flag;
		}
	}

	public unsafe int dontUpdateGoalPriorityFor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontUpdateGoalPriorityFor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontUpdateGoalPriorityFor)) = num;
		}
	}

	public unsafe bool limitTickRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitTickRate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitTickRate)) = flag;
		}
	}

	public unsafe NewAIController.AITickRate minimumTickRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumTickRate);
			return *(NewAIController.AITickRate*)num;
		}
		set
		{
			*(NewAIController.AITickRate*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumTickRate)) = aITickRate;
		}
	}

	public unsafe NewAIController.AITickRate maximumTickRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumTickRate);
			return *(NewAIController.AITickRate*)num;
		}
		set
		{
			*(NewAIController.AITickRate*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumTickRate)) = aITickRate;
		}
	}

	public unsafe bool dontRemoveOnRefresh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontRemoveOnRefresh);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontRemoveOnRefresh)) = flag;
		}
	}

	public unsafe bool nonRefreshable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonRefreshable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonRefreshable)) = flag;
		}
	}

	public unsafe bool useLOSCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useLOSCheck);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useLOSCheck)) = flag;
		}
	}

	public unsafe bool cancelIfNonValidMugging
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelIfNonValidMugging);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelIfNonValidMugging)) = flag;
		}
	}

	public unsafe bool cancelIfPlayerNotLoitering
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelIfPlayerNotLoitering);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelIfPlayerNotLoitering)) = flag;
		}
	}

	public unsafe bool skipIfAIIsInState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipIfAIIsInState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipIfAIIsInState)) = flag;
		}
	}

	public unsafe NewAIController.ReactionState skipIfReaction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipIfReaction);
			return *(NewAIController.ReactionState*)num;
		}
		set
		{
			*(NewAIController.ReactionState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipIfReaction)) = reactionState;
		}
	}

	public unsafe bool skipIfGuestPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipIfGuestPass);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipIfGuestPass)) = flag;
		}
	}

	public unsafe ActionFacingDirection facing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facing);
			return *(ActionFacingDirection*)num;
		}
		set
		{
			*(ActionFacingDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facing)) = actionFacingDirection;
		}
	}

	public unsafe bool lookAround
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAround);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAround)) = flag;
		}
	}

	public unsafe bool cancelIfPersuitTargetNotInRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelIfPersuitTargetNotInRange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cancelIfPersuitTargetNotInRange)) = flag;
		}
	}

	public unsafe bool facePlayerWhileTalkingTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facePlayerWhileTalkingTo);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_facePlayerWhileTalkingTo)) = flag;
		}
	}

	public unsafe bool changeIdleOnActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeIdleOnActivate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeIdleOnActivate)) = flag;
		}
	}

	public unsafe CitizenAnimationController.IdleAnimationState idleAnimationOnActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleAnimationOnActivate);
			return *(CitizenAnimationController.IdleAnimationState*)num;
		}
		set
		{
			*(CitizenAnimationController.IdleAnimationState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleAnimationOnActivate)) = idleAnimationState;
		}
	}

	public unsafe bool changeIdleOnArrival
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeIdleOnArrival);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeIdleOnArrival)) = flag;
		}
	}

	public unsafe CitizenAnimationController.IdleAnimationState idleAnimationOnArrival
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleAnimationOnArrival);
			return *(CitizenAnimationController.IdleAnimationState*)num;
		}
		set
		{
			*(CitizenAnimationController.IdleAnimationState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleAnimationOnArrival)) = idleAnimationState;
		}
	}

	public unsafe bool changeIdleOnDeactivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeIdleOnDeactivate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeIdleOnDeactivate)) = flag;
		}
	}

	public unsafe CitizenAnimationController.IdleAnimationState idleAnimationOnDeactivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleAnimationOnDeactivate);
			return *(CitizenAnimationController.IdleAnimationState*)num;
		}
		set
		{
			*(CitizenAnimationController.IdleAnimationState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleAnimationOnDeactivate)) = idleAnimationState;
		}
	}

	public unsafe bool changeIdleOnComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeIdleOnComplete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeIdleOnComplete)) = flag;
		}
	}

	public unsafe CitizenAnimationController.IdleAnimationState idleAnimationOnComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleAnimationOnComplete);
			return *(CitizenAnimationController.IdleAnimationState*)num;
		}
		set
		{
			*(CitizenAnimationController.IdleAnimationState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idleAnimationOnComplete)) = idleAnimationState;
		}
	}

	public unsafe bool changeArmsOnActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeArmsOnActivate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeArmsOnActivate)) = flag;
		}
	}

	public unsafe CitizenAnimationController.ArmsBoolSate armsAnimationOnActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armsAnimationOnActivate);
			return *(CitizenAnimationController.ArmsBoolSate*)num;
		}
		set
		{
			*(CitizenAnimationController.ArmsBoolSate*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armsAnimationOnActivate)) = armsBoolSate;
		}
	}

	public unsafe bool changeArmsOnArrival
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeArmsOnArrival);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeArmsOnArrival)) = flag;
		}
	}

	public unsafe CitizenAnimationController.ArmsBoolSate armsAnimationOnArrival
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armsAnimationOnArrival);
			return *(CitizenAnimationController.ArmsBoolSate*)num;
		}
		set
		{
			*(CitizenAnimationController.ArmsBoolSate*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armsAnimationOnArrival)) = armsBoolSate;
		}
	}

	public unsafe bool changeArmsOnDeactivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeArmsOnDeactivate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeArmsOnDeactivate)) = flag;
		}
	}

	public unsafe CitizenAnimationController.ArmsBoolSate armsAnimationOnDeactivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armsAnimationOnDeactivate);
			return *(CitizenAnimationController.ArmsBoolSate*)num;
		}
		set
		{
			*(CitizenAnimationController.ArmsBoolSate*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armsAnimationOnDeactivate)) = armsBoolSate;
		}
	}

	public unsafe bool changeArmsOnComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeArmsOnComplete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeArmsOnComplete)) = flag;
		}
	}

	public unsafe CitizenAnimationController.ArmsBoolSate armsAnimationOnComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armsAnimationOnComplete);
			return *(CitizenAnimationController.ArmsBoolSate*)num;
		}
		set
		{
			*(CitizenAnimationController.ArmsBoolSate*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armsAnimationOnComplete)) = armsBoolSate;
		}
	}

	public unsafe bool lying
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lying);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lying)) = flag;
		}
	}

	public unsafe bool lyingOnFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lyingOnFloor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lyingOnFloor)) = flag;
		}
	}

	public unsafe bool useCurrentConsumable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCurrentConsumable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCurrentConsumable)) = flag;
		}
	}

	public unsafe float progressNourishment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressNourishment);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressNourishment)) = num;
		}
	}

	public unsafe float progressHydration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressHydration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressHydration)) = num;
		}
	}

	public unsafe float progressAlertness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressAlertness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressAlertness)) = num;
		}
	}

	public unsafe float progressEnergy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressEnergy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressEnergy)) = num;
		}
	}

	public unsafe float progressExcitement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressExcitement);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressExcitement)) = num;
		}
	}

	public unsafe float progressChores
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressChores);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressChores)) = num;
		}
	}

	public unsafe float progressHygeiene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressHygeiene);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressHygeiene)) = num;
		}
	}

	public unsafe float progressBladder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressBladder);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressBladder)) = num;
		}
	}

	public unsafe float progressHeat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressHeat);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressHeat)) = num;
		}
	}

	public unsafe float progressDrunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressDrunk);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressDrunk)) = num;
		}
	}

	public unsafe float progressBreath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressBreath);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressBreath)) = num;
		}
	}

	public unsafe float progressPoisoned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressPoisoned);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressPoisoned)) = num;
		}
	}

	public unsafe float overtimeNourishment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeNourishment);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeNourishment)) = num;
		}
	}

	public unsafe float overtimeHydration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeHydration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeHydration)) = num;
		}
	}

	public unsafe float overtimeAlertness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeAlertness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeAlertness)) = num;
		}
	}

	public unsafe float overtimeEnergy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeEnergy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeEnergy)) = num;
		}
	}

	public unsafe float overtimeExcitement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeExcitement);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeExcitement)) = num;
		}
	}

	public unsafe float overtimeChores
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeChores);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeChores)) = num;
		}
	}

	public unsafe float overtimeHygiene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeHygiene);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeHygiene)) = num;
		}
	}

	public unsafe float overtimeBladder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeBladder);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeBladder)) = num;
		}
	}

	public unsafe float overtimeHeat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeHeat);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeHeat)) = num;
		}
	}

	public unsafe float overtimeDrunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeDrunk);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeDrunk)) = num;
		}
	}

	public unsafe float overtimeBreath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeBreath);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimeBreath)) = num;
		}
	}

	public unsafe float overtimePoison
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimePoison);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overtimePoison)) = num;
		}
	}

	public unsafe bool useInvestigationUrgency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useInvestigationUrgency);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useInvestigationUrgency)) = flag;
		}
	}

	public unsafe bool forceRun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceRun);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceRun)) = flag;
		}
	}

	public unsafe bool runIfSeesPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runIfSeesPlayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runIfSeesPlayer)) = flag;
		}
	}

	public unsafe bool socialRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialRules);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialRules)) = flag;
		}
	}

	public unsafe bool spookAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookAction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookAction)) = flag;
		}
	}

	public unsafe bool disableSightingUpdates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSightingUpdates);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSightingUpdates)) = flag;
		}
	}

	public unsafe bool attackPersuitTargetOnProximity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackPersuitTargetOnProximity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackPersuitTargetOnProximity)) = flag;
		}
	}

	public unsafe bool throwObjectsAtTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwObjectsAtTarget);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwObjectsAtTarget)) = flag;
		}
	}

	public unsafe CombatPose useCombatPose
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCombatPose);
			return *(CombatPose*)num;
		}
		set
		{
			*(CombatPose*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCombatPose)) = combatPose;
		}
	}

	public unsafe bool onlyUseCombatPoseWithEscalationOne
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyUseCombatPoseWithEscalationOne);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyUseCombatPoseWithEscalationOne)) = flag;
		}
	}

	public unsafe bool sleepOnArrival
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepOnArrival);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepOnArrival)) = flag;
		}
	}

	public unsafe bool uninteruptableWhileAtLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uninteruptableWhileAtLocation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uninteruptableWhileAtLocation)) = flag;
		}
	}

	public unsafe bool progressVmailThreads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressVmailThreads);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_progressVmailThreads)) = flag;
		}
	}

	public unsafe bool disableConversationTriggers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableConversationTriggers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableConversationTriggers)) = flag;
		}
	}

	public unsafe bool exitConversationOnActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitConversationOnActivate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitConversationOnActivate)) = flag;
		}
	}

	public unsafe List<InteractablePreset> forcedActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedActive);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedActive)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AutomaticAction> forcedActionsOnArrival
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedActionsOnArrival);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AutomaticAction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedActionsOnArrival)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AutomaticAction> forcedActionsOnComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedActionsOnComplete);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AutomaticAction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedActionsOnComplete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ForcedActionsSearchLevel forcedActionsSearchLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedActionsSearchLevel);
			return *(ForcedActionsSearchLevel*)num;
		}
		set
		{
			*(ForcedActionsSearchLevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedActionsSearchLevel)) = forcedActionsSearchLevel;
		}
	}

	public unsafe bool executeCompleteActionsOnEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executeCompleteActionsOnEnd);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executeCompleteActionsOnEnd)) = flag;
		}
	}

	public unsafe bool executeCompleteActionsOnEndIfArrived
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executeCompleteActionsOnEndIfArrived);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executeCompleteActionsOnEndIfArrived)) = flag;
		}
	}

	public unsafe bool executeThisOnComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executeThisOnComplete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_executeThisOnComplete)) = flag;
		}
	}

	public unsafe List<InteractablePreset.SwitchState> switchStatesOnEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchStatesOnEnd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset.SwitchState>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchStatesOnEnd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool tamperAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperAction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperAction)) = flag;
		}
	}

	public unsafe bool tamperResetAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperResetAction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperResetAction)) = flag;
		}
	}

	public unsafe int fallAsleepAfterMinimum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallAsleepAfterMinimum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fallAsleepAfterMinimum)) = num;
		}
	}

	public unsafe bool allowSniperShot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowSniperShot);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowSniperShot)) = flag;
		}
	}

	public unsafe List<CheckActionAgainstState> checkActionAgainstState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkActionAgainstState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CheckActionAgainstState>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkActionAgainstState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool forceReactionState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceReactionState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceReactionState)) = flag;
		}
	}

	public unsafe NewAIController.ReactionState setReactionState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setReactionState);
			return *(NewAIController.ReactionState*)num;
		}
		set
		{
			*(NewAIController.ReactionState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setReactionState)) = reactionState;
		}
	}

	public unsafe bool ignoreLockedDoors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreLockedDoors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreLockedDoors)) = flag;
		}
	}

	public unsafe bool breakDownDoors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakDownDoors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakDownDoors)) = flag;
		}
	}

	public unsafe bool doorsAllowed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorsAllowed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorsAllowed)) = flag;
		}
	}

	public unsafe bool deactivateAllowed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deactivateAllowed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deactivateAllowed)) = flag;
		}
	}

	public unsafe float repeatDelayOnActionFail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDelayOnActionFail);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDelayOnActionFail)) = num;
		}
	}

	public unsafe float repeatDelayOnActionSuccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDelayOnActionSuccess);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeatDelayOnActionSuccess)) = num;
		}
	}

	public unsafe bool turnAllGamelocationLightsOff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turnAllGamelocationLightsOff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turnAllGamelocationLightsOff)) = flag;
		}
	}

	public unsafe bool overrideGoalLightRule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideGoalLightRule);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideGoalLightRule)) = flag;
		}
	}

	public unsafe bool onlyOverrideIfAtGamelocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyOverrideIfAtGamelocation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyOverrideIfAtGamelocation)) = flag;
		}
	}

	public unsafe List<RoomConfiguration.AILightingBehaviour> lightingBehaviour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightingBehaviour);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomConfiguration.AILightingBehaviour>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightingBehaviour)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool overrideGoalDoorRule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideGoalDoorRule);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideGoalDoorRule)) = flag;
		}
	}

	public unsafe DoorRule doorRule
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorRule);
			return *(DoorRule*)num;
		}
		set
		{
			*(DoorRule*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorRule)) = doorRule;
		}
	}

	public unsafe bool spawnTauntOnSuccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnTauntOnSuccess);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnTauntOnSuccess)) = flag;
		}
	}

	public unsafe AudioEvent onArrivalSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onArrivalSound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onArrivalSound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe bool isLoop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLoop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLoop)) = flag;
		}
	}

	public unsafe float soundDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_soundDelay)) = num;
		}
	}

	public unsafe bool outdoorClothingCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outdoorClothingCheck);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outdoorClothingCheck)) = flag;
		}
	}

	public unsafe bool specificOutfitOnActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specificOutfitOnActivate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specificOutfitOnActivate)) = flag;
		}
	}

	public unsafe ClothesPreset.OutfitCategory allowedOutfitOnActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOutfitOnActivate);
			return *(ClothesPreset.OutfitCategory*)num;
		}
		set
		{
			*(ClothesPreset.OutfitCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOutfitOnActivate)) = outfitCategory;
		}
	}

	public unsafe bool makeClothedOnActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeClothedOnActivate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeClothedOnActivate)) = flag;
		}
	}

	public unsafe bool specificOutfitOnArrive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specificOutfitOnArrive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specificOutfitOnArrive)) = flag;
		}
	}

	public unsafe ClothesPreset.OutfitCategory allowedOutfitOnArrive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOutfitOnArrive);
			return *(ClothesPreset.OutfitCategory*)num;
		}
		set
		{
			*(ClothesPreset.OutfitCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOutfitOnArrive)) = outfitCategory;
		}
	}

	public unsafe bool makeClothedOnArrive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeClothedOnArrive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeClothedOnArrive)) = flag;
		}
	}

	public unsafe bool specificOutfitOnDeactivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specificOutfitOnDeactivate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specificOutfitOnDeactivate)) = flag;
		}
	}

	public unsafe ClothesPreset.OutfitCategory allowedOutfitOnDeactivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOutfitOnDeactivate);
			return *(ClothesPreset.OutfitCategory*)num;
		}
		set
		{
			*(ClothesPreset.OutfitCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOutfitOnDeactivate)) = outfitCategory;
		}
	}

	public unsafe bool makeClothedOnDeactivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeClothedOnDeactivate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeClothedOnDeactivate)) = flag;
		}
	}

	public unsafe bool specificOutfitOnComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specificOutfitOnComplete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specificOutfitOnComplete)) = flag;
		}
	}

	public unsafe ClothesPreset.OutfitCategory allowedOutfitOnComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOutfitOnComplete);
			return *(ClothesPreset.OutfitCategory*)num;
		}
		set
		{
			*(ClothesPreset.OutfitCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowedOutfitOnComplete)) = outfitCategory;
		}
	}

	public unsafe bool makeClothedOnComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeClothedOnComplete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_makeClothedOnComplete)) = flag;
		}
	}

	public unsafe bool setExpressionOnActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setExpressionOnActivate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setExpressionOnActivate)) = flag;
		}
	}

	public unsafe CitizenOutfitController.Expression activateExpression
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activateExpression);
			return *(CitizenOutfitController.Expression*)num;
		}
		set
		{
			*(CitizenOutfitController.Expression*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activateExpression)) = expression;
		}
	}

	public unsafe bool setExpressionOnArrive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setExpressionOnArrive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setExpressionOnArrive)) = flag;
		}
	}

	public unsafe CitizenOutfitController.Expression arriveExpression
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arriveExpression);
			return *(CitizenOutfitController.Expression*)num;
		}
		set
		{
			*(CitizenOutfitController.Expression*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arriveExpression)) = expression;
		}
	}

	public unsafe bool setExpressionOnDeactivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setExpressionOnDeactivate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setExpressionOnDeactivate)) = flag;
		}
	}

	public unsafe CitizenOutfitController.Expression deactivateExpression
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deactivateExpression);
			return *(CitizenOutfitController.Expression*)num;
		}
		set
		{
			*(CitizenOutfitController.Expression*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deactivateExpression)) = expression;
		}
	}

	public unsafe bool setExpressionOnComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setExpressionOnComplete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setExpressionOnComplete)) = flag;
		}
	}

	public unsafe CitizenOutfitController.Expression completeExpression
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completeExpression);
			return *(CitizenOutfitController.Expression*)num;
		}
		set
		{
			*(CitizenOutfitController.Expression*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completeExpression)) = expression;
		}
	}

	public unsafe bool allowItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowItems);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowItems)) = flag;
		}
	}

	public unsafe bool enableCustomItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCustomItem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCustomItem)) = flag;
		}
	}

	public unsafe GameObject itemRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
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

	public unsafe GameObject itemLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeft);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemLeft)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
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

	public unsafe ActionStateFlag spawnCustomItemOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnCustomItemOn);
			return *(ActionStateFlag*)num;
		}
		set
		{
			*(ActionStateFlag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnCustomItemOn)) = actionStateFlag;
		}
	}

	public unsafe ActionStateFlag destroyCustomItemOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyCustomItemOn);
			return *(ActionStateFlag*)num;
		}
		set
		{
			*(ActionStateFlag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyCustomItemOn)) = actionStateFlag;
		}
	}

	public unsafe bool requiresCarryAnimation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresCarryAnimation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresCarryAnimation)) = flag;
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

	public unsafe InteractablePreset dropItemOnEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dropItemOnEnd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dropItemOnEnd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe float chanceOfOnTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOnTrigger);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOnTrigger)) = num;
		}
	}

	public unsafe List<SpeechController.Bark> onTriggerBark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTriggerBark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SpeechController.Bark>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onTriggerBark)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float chanceOfWhileJourney
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfWhileJourney);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfWhileJourney)) = num;
		}
	}

	public unsafe List<SpeechController.Bark> whileJourneyBark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_whileJourneyBark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SpeechController.Bark>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_whileJourneyBark)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float chanceOfOnArrival
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOnArrival);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOnArrival)) = num;
		}
	}

	public unsafe List<SpeechController.Bark> onArrivalBark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onArrivalBark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SpeechController.Bark>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onArrivalBark)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float chanceOfWhileArrived
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfWhileArrived);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfWhileArrived)) = num;
		}
	}

	public unsafe bool mustSeeOtherCitizen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustSeeOtherCitizen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustSeeOtherCitizen)) = flag;
		}
	}

	public unsafe List<SpeechController.Bark> whileArrivedBark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_whileArrivedBark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SpeechController.Bark>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_whileArrivedBark)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float chanceOfOnComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOnComplete);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceOfOnComplete)) = num;
		}
	}

	public unsafe List<SpeechController.Bark> onCompleteBark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCompleteBark);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SpeechController.Bark>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCompleteBark)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static AIActionPreset()
	{
		Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AIActionPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr);
		NativeFieldInfoPtr_defaultKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "defaultKey");
		NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "debug");
		NativeFieldInfoPtr_inputPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "inputPriority");
		NativeFieldInfoPtr_unavailableWhenItemSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "unavailableWhenItemSelected");
		NativeFieldInfoPtr_unavailableWhenItemsSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "unavailableWhenItemsSelected");
		NativeFieldInfoPtr_onlyAvailableWhenItemSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "onlyAvailableWhenItemSelected");
		NativeFieldInfoPtr_availableWhenItemsSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "availableWhenItemsSelected");
		NativeFieldInfoPtr_holsterCurrentItemOnAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "holsterCurrentItemOnAction");
		NativeFieldInfoPtr_disableUIDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "disableUIDisplay");
		NativeFieldInfoPtr_allowInteractionAtRecognitionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "allowInteractionAtRecognitionRange");
		NativeFieldInfoPtr_actionLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "actionLocation");
		NativeFieldInfoPtr_confirmActionLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "confirmActionLocation");
		NativeFieldInfoPtr_useRandomNodeSublocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "useRandomNodeSublocation");
		NativeFieldInfoPtr_onUnableToFindLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "onUnableToFindLocation");
		NativeFieldInfoPtr_searchSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "searchSetting");
		NativeFieldInfoPtr_onUsePointBusy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "onUsePointBusy");
		NativeFieldInfoPtr_usageSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "usageSlot");
		NativeFieldInfoPtr_useCloseEnoughSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "useCloseEnoughSetting");
		NativeFieldInfoPtr_robberyPriorityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "robberyPriorityMultiplier");
		NativeFieldInfoPtr_avoidRepeatingInteractables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "avoidRepeatingInteractables");
		NativeFieldInfoPtr_filterSearchUsingRoomType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "filterSearchUsingRoomType");
		NativeFieldInfoPtr_searchRoomType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "searchRoomType");
		NativeFieldInfoPtr_limitSearchToGoalLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "limitSearchToGoalLocation");
		NativeFieldInfoPtr_findOverrideWithHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "findOverrideWithHome");
		NativeFieldInfoPtr_requiresTelephone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "requiresTelephone");
		NativeFieldInfoPtr_requiresTelephoneNoCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "requiresTelephoneNoCall");
		NativeFieldInfoPtr_activationRequiresConsumable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "activationRequiresConsumable");
		NativeFieldInfoPtr_bannedRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "bannedRooms");
		NativeFieldInfoPtr_completableAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "completableAction");
		NativeFieldInfoPtr_minutesTakenRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "minutesTakenRange");
		NativeFieldInfoPtr_completeOnSeeIllegal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "completeOnSeeIllegal");
		NativeFieldInfoPtr_repeatOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "repeatOnComplete");
		NativeFieldInfoPtr_repeatWhileHavingConsumables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "repeatWhileHavingConsumables");
		NativeFieldInfoPtr_requiresForcedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "requiresForcedUpdate");
		NativeFieldInfoPtr_enableImmediateCompletionWhenFarAway = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "enableImmediateCompletionWhenFarAway");
		NativeFieldInfoPtr_dontUpdateGoalPriorityWhileActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "dontUpdateGoalPriorityWhileActive");
		NativeFieldInfoPtr_dontUpdateGoalPriorityFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "dontUpdateGoalPriorityFor");
		NativeFieldInfoPtr_limitTickRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "limitTickRate");
		NativeFieldInfoPtr_minimumTickRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "minimumTickRate");
		NativeFieldInfoPtr_maximumTickRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "maximumTickRate");
		NativeFieldInfoPtr_dontRemoveOnRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "dontRemoveOnRefresh");
		NativeFieldInfoPtr_nonRefreshable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "nonRefreshable");
		NativeFieldInfoPtr_useLOSCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "useLOSCheck");
		NativeFieldInfoPtr_cancelIfNonValidMugging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "cancelIfNonValidMugging");
		NativeFieldInfoPtr_cancelIfPlayerNotLoitering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "cancelIfPlayerNotLoitering");
		NativeFieldInfoPtr_skipIfAIIsInState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "skipIfAIIsInState");
		NativeFieldInfoPtr_skipIfReaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "skipIfReaction");
		NativeFieldInfoPtr_skipIfGuestPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "skipIfGuestPass");
		NativeFieldInfoPtr_facing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "facing");
		NativeFieldInfoPtr_lookAround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "lookAround");
		NativeFieldInfoPtr_cancelIfPersuitTargetNotInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "cancelIfPersuitTargetNotInRange");
		NativeFieldInfoPtr_facePlayerWhileTalkingTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "facePlayerWhileTalkingTo");
		NativeFieldInfoPtr_changeIdleOnActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "changeIdleOnActivate");
		NativeFieldInfoPtr_idleAnimationOnActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "idleAnimationOnActivate");
		NativeFieldInfoPtr_changeIdleOnArrival = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "changeIdleOnArrival");
		NativeFieldInfoPtr_idleAnimationOnArrival = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "idleAnimationOnArrival");
		NativeFieldInfoPtr_changeIdleOnDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "changeIdleOnDeactivate");
		NativeFieldInfoPtr_idleAnimationOnDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "idleAnimationOnDeactivate");
		NativeFieldInfoPtr_changeIdleOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "changeIdleOnComplete");
		NativeFieldInfoPtr_idleAnimationOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "idleAnimationOnComplete");
		NativeFieldInfoPtr_changeArmsOnActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "changeArmsOnActivate");
		NativeFieldInfoPtr_armsAnimationOnActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "armsAnimationOnActivate");
		NativeFieldInfoPtr_changeArmsOnArrival = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "changeArmsOnArrival");
		NativeFieldInfoPtr_armsAnimationOnArrival = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "armsAnimationOnArrival");
		NativeFieldInfoPtr_changeArmsOnDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "changeArmsOnDeactivate");
		NativeFieldInfoPtr_armsAnimationOnDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "armsAnimationOnDeactivate");
		NativeFieldInfoPtr_changeArmsOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "changeArmsOnComplete");
		NativeFieldInfoPtr_armsAnimationOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "armsAnimationOnComplete");
		NativeFieldInfoPtr_lying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "lying");
		NativeFieldInfoPtr_lyingOnFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "lyingOnFloor");
		NativeFieldInfoPtr_useCurrentConsumable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "useCurrentConsumable");
		NativeFieldInfoPtr_progressNourishment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "progressNourishment");
		NativeFieldInfoPtr_progressHydration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "progressHydration");
		NativeFieldInfoPtr_progressAlertness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "progressAlertness");
		NativeFieldInfoPtr_progressEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "progressEnergy");
		NativeFieldInfoPtr_progressExcitement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "progressExcitement");
		NativeFieldInfoPtr_progressChores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "progressChores");
		NativeFieldInfoPtr_progressHygeiene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "progressHygeiene");
		NativeFieldInfoPtr_progressBladder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "progressBladder");
		NativeFieldInfoPtr_progressHeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "progressHeat");
		NativeFieldInfoPtr_progressDrunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "progressDrunk");
		NativeFieldInfoPtr_progressBreath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "progressBreath");
		NativeFieldInfoPtr_progressPoisoned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "progressPoisoned");
		NativeFieldInfoPtr_overtimeNourishment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overtimeNourishment");
		NativeFieldInfoPtr_overtimeHydration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overtimeHydration");
		NativeFieldInfoPtr_overtimeAlertness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overtimeAlertness");
		NativeFieldInfoPtr_overtimeEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overtimeEnergy");
		NativeFieldInfoPtr_overtimeExcitement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overtimeExcitement");
		NativeFieldInfoPtr_overtimeChores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overtimeChores");
		NativeFieldInfoPtr_overtimeHygiene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overtimeHygiene");
		NativeFieldInfoPtr_overtimeBladder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overtimeBladder");
		NativeFieldInfoPtr_overtimeHeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overtimeHeat");
		NativeFieldInfoPtr_overtimeDrunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overtimeDrunk");
		NativeFieldInfoPtr_overtimeBreath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overtimeBreath");
		NativeFieldInfoPtr_overtimePoison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overtimePoison");
		NativeFieldInfoPtr_useInvestigationUrgency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "useInvestigationUrgency");
		NativeFieldInfoPtr_forceRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "forceRun");
		NativeFieldInfoPtr_runIfSeesPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "runIfSeesPlayer");
		NativeFieldInfoPtr_socialRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "socialRules");
		NativeFieldInfoPtr_spookAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "spookAction");
		NativeFieldInfoPtr_disableSightingUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "disableSightingUpdates");
		NativeFieldInfoPtr_attackPersuitTargetOnProximity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "attackPersuitTargetOnProximity");
		NativeFieldInfoPtr_throwObjectsAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "throwObjectsAtTarget");
		NativeFieldInfoPtr_useCombatPose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "useCombatPose");
		NativeFieldInfoPtr_onlyUseCombatPoseWithEscalationOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "onlyUseCombatPoseWithEscalationOne");
		NativeFieldInfoPtr_sleepOnArrival = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "sleepOnArrival");
		NativeFieldInfoPtr_uninteruptableWhileAtLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "uninteruptableWhileAtLocation");
		NativeFieldInfoPtr_progressVmailThreads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "progressVmailThreads");
		NativeFieldInfoPtr_disableConversationTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "disableConversationTriggers");
		NativeFieldInfoPtr_exitConversationOnActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "exitConversationOnActivate");
		NativeFieldInfoPtr_forcedActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "forcedActive");
		NativeFieldInfoPtr_forcedActionsOnArrival = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "forcedActionsOnArrival");
		NativeFieldInfoPtr_forcedActionsOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "forcedActionsOnComplete");
		NativeFieldInfoPtr_forcedActionsSearchLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "forcedActionsSearchLevel");
		NativeFieldInfoPtr_executeCompleteActionsOnEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "executeCompleteActionsOnEnd");
		NativeFieldInfoPtr_executeCompleteActionsOnEndIfArrived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "executeCompleteActionsOnEndIfArrived");
		NativeFieldInfoPtr_executeThisOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "executeThisOnComplete");
		NativeFieldInfoPtr_switchStatesOnEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "switchStatesOnEnd");
		NativeFieldInfoPtr_tamperAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "tamperAction");
		NativeFieldInfoPtr_tamperResetAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "tamperResetAction");
		NativeFieldInfoPtr_fallAsleepAfterMinimum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "fallAsleepAfterMinimum");
		NativeFieldInfoPtr_allowSniperShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "allowSniperShot");
		NativeFieldInfoPtr_checkActionAgainstState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "checkActionAgainstState");
		NativeFieldInfoPtr_forceReactionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "forceReactionState");
		NativeFieldInfoPtr_setReactionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "setReactionState");
		NativeFieldInfoPtr_ignoreLockedDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "ignoreLockedDoors");
		NativeFieldInfoPtr_breakDownDoors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "breakDownDoors");
		NativeFieldInfoPtr_doorsAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "doorsAllowed");
		NativeFieldInfoPtr_deactivateAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "deactivateAllowed");
		NativeFieldInfoPtr_repeatDelayOnActionFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "repeatDelayOnActionFail");
		NativeFieldInfoPtr_repeatDelayOnActionSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "repeatDelayOnActionSuccess");
		NativeFieldInfoPtr_turnAllGamelocationLightsOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "turnAllGamelocationLightsOff");
		NativeFieldInfoPtr_overrideGoalLightRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overrideGoalLightRule");
		NativeFieldInfoPtr_onlyOverrideIfAtGamelocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "onlyOverrideIfAtGamelocation");
		NativeFieldInfoPtr_lightingBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "lightingBehaviour");
		NativeFieldInfoPtr_overrideGoalDoorRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overrideGoalDoorRule");
		NativeFieldInfoPtr_doorRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "doorRule");
		NativeFieldInfoPtr_spawnTauntOnSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "spawnTauntOnSuccess");
		NativeFieldInfoPtr_onArrivalSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "onArrivalSound");
		NativeFieldInfoPtr_isLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "isLoop");
		NativeFieldInfoPtr_soundDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "soundDelay");
		NativeFieldInfoPtr_outdoorClothingCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "outdoorClothingCheck");
		NativeFieldInfoPtr_specificOutfitOnActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "specificOutfitOnActivate");
		NativeFieldInfoPtr_allowedOutfitOnActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "allowedOutfitOnActivate");
		NativeFieldInfoPtr_makeClothedOnActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "makeClothedOnActivate");
		NativeFieldInfoPtr_specificOutfitOnArrive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "specificOutfitOnArrive");
		NativeFieldInfoPtr_allowedOutfitOnArrive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "allowedOutfitOnArrive");
		NativeFieldInfoPtr_makeClothedOnArrive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "makeClothedOnArrive");
		NativeFieldInfoPtr_specificOutfitOnDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "specificOutfitOnDeactivate");
		NativeFieldInfoPtr_allowedOutfitOnDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "allowedOutfitOnDeactivate");
		NativeFieldInfoPtr_makeClothedOnDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "makeClothedOnDeactivate");
		NativeFieldInfoPtr_specificOutfitOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "specificOutfitOnComplete");
		NativeFieldInfoPtr_allowedOutfitOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "allowedOutfitOnComplete");
		NativeFieldInfoPtr_makeClothedOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "makeClothedOnComplete");
		NativeFieldInfoPtr_setExpressionOnActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "setExpressionOnActivate");
		NativeFieldInfoPtr_activateExpression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "activateExpression");
		NativeFieldInfoPtr_setExpressionOnArrive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "setExpressionOnArrive");
		NativeFieldInfoPtr_arriveExpression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "arriveExpression");
		NativeFieldInfoPtr_setExpressionOnDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "setExpressionOnDeactivate");
		NativeFieldInfoPtr_deactivateExpression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "deactivateExpression");
		NativeFieldInfoPtr_setExpressionOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "setExpressionOnComplete");
		NativeFieldInfoPtr_completeExpression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "completeExpression");
		NativeFieldInfoPtr_allowItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "allowItems");
		NativeFieldInfoPtr_enableCustomItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "enableCustomItem");
		NativeFieldInfoPtr_itemRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "itemRight");
		NativeFieldInfoPtr_itemRightLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "itemRightLocalPos");
		NativeFieldInfoPtr_itemRightLocalEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "itemRightLocalEuler");
		NativeFieldInfoPtr_itemLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "itemLeft");
		NativeFieldInfoPtr_itemLeftLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "itemLeftLocalPos");
		NativeFieldInfoPtr_itemLeftLocalEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "itemLeftLocalEuler");
		NativeFieldInfoPtr_spawnCustomItemOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "spawnCustomItemOn");
		NativeFieldInfoPtr_destroyCustomItemOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "destroyCustomItemOn");
		NativeFieldInfoPtr_requiresCarryAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "requiresCarryAnimation");
		NativeFieldInfoPtr_overrideCarryAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "overrideCarryAnimation");
		NativeFieldInfoPtr_dropItemOnEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "dropItemOnEnd");
		NativeFieldInfoPtr_chanceOfOnTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "chanceOfOnTrigger");
		NativeFieldInfoPtr_onTriggerBark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "onTriggerBark");
		NativeFieldInfoPtr_chanceOfWhileJourney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "chanceOfWhileJourney");
		NativeFieldInfoPtr_whileJourneyBark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "whileJourneyBark");
		NativeFieldInfoPtr_chanceOfOnArrival = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "chanceOfOnArrival");
		NativeFieldInfoPtr_onArrivalBark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "onArrivalBark");
		NativeFieldInfoPtr_chanceOfWhileArrived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "chanceOfWhileArrived");
		NativeFieldInfoPtr_mustSeeOtherCitizen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "mustSeeOtherCitizen");
		NativeFieldInfoPtr_whileArrivedBark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "whileArrivedBark");
		NativeFieldInfoPtr_chanceOfOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "chanceOfOnComplete");
		NativeFieldInfoPtr_onCompleteBark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, "onCompleteBark");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr, 100673777);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326539, XrefRangeEnd = 326613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIActionPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIActionPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AIActionPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
