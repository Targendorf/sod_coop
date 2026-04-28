using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class DialogPreset : SoCustomComparison
{
	public enum InputSetting
	{
		none,
		addressPassword
	}

	public enum SpecialCase
	{
		none,
		backroomBribe,
		publicFacingWorkplace,
		working,
		workingGuestPass,
		callInSuspect,
		talkingToJobPoster,
		inputName,
		lastCaller,
		knowName,
		lookAroundHome,
		returnJobItemA,
		medicalCosts,
		starchPitch,
		mugging,
		neverDisplay,
		loanSharkAccept,
		loanSharkPayment,
		loanSharkPaymentRefuse,
		loanSharkAsk,
		revealHiddenitemPhoto,
		hotelBill,
		rentHotelRoomCheap,
		rentHotelRoomExpensive,
		hotelCheckOut,
		hotelRentRoom,
		mustHaveRoomAtHotel,
		mustBeMurdererForSuccess,
		killerCleanUp,
		killerCleanUpAccept,
		killerCleanUpReject,
		killerCleanUpSuccess,
		ransomInvestigate,
		kidnapperOnly,
		fameAndFortune
	}

	[ObfuscatedName("DialogPreset+<>c__DisplayClass32_0")]
	public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_hu;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetCost_b__0_Internal_Boolean_LoanDebt_0;

		public unsafe Human hu
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hu);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hu)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		static __c__DisplayClass32_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "<>c__DisplayClass32_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr);
			NativeFieldInfoPtr_hu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, "hu");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, 100673877);
			NativeMethodInfoPtr__GetCost_b__0_Internal_Boolean_LoanDebt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr, 100673878);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass32_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass32_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetCost_b__0(GameplayController.LoanDebt item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetCost_b__0_Internal_Boolean_LoanDebt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass32_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_msgID;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultOption;

	private static readonly System.IntPtr NativeFieldInfoPtr_telephoneCallOption;

	private static readonly System.IntPtr NativeFieldInfoPtr_hospitalDecisionOption;

	private static readonly System.IntPtr NativeFieldInfoPtr_tiedToKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_ranking;

	private static readonly System.IntPtr NativeFieldInfoPtr_removeAfterSaying;

	private static readonly System.IntPtr NativeFieldInfoPtr_dailyReplenish;

	private static readonly System.IntPtr NativeFieldInfoPtr_isJobDetails;

	private static readonly System.IntPtr NativeFieldInfoPtr_ignoreActiveJobRequirement;

	private static readonly System.IntPtr NativeFieldInfoPtr_specialCase;

	private static readonly System.IntPtr NativeFieldInfoPtr_cost;

	private static readonly System.IntPtr NativeFieldInfoPtr_usePercentageCost;

	private static readonly System.IntPtr NativeFieldInfoPtr_useAllWealthIfNotEnough;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayIfPasswordUnknown;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayAsIllegal;

	private static readonly System.IntPtr NativeFieldInfoPtr_preceedingSyntax;

	private static readonly System.IntPtr NativeFieldInfoPtr_followingSyntax;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSuccessTest;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresPassword;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseChance;

	private static readonly System.IntPtr NativeFieldInfoPtr_affectChanceIfRestrained;

	private static readonly System.IntPtr NativeFieldInfoPtr_modifySuccessChanceTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_responses;

	private static readonly System.IntPtr NativeFieldInfoPtr_followUpDialogSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_followUpDialogFail;

	private static readonly System.IntPtr NativeFieldInfoPtr_removeDialog;

	private static readonly System.IntPtr NativeFieldInfoPtr_removeDialogOnSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_removeDialogOnFail;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCost_Public_Int32_Actor_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string msgID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_msgID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_msgID)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool defaultOption
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultOption);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultOption)) = flag;
		}
	}

	public unsafe bool telephoneCallOption
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telephoneCallOption);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telephoneCallOption)) = flag;
		}
	}

	public unsafe bool hospitalDecisionOption
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hospitalDecisionOption);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hospitalDecisionOption)) = flag;
		}
	}

	public unsafe Evidence.DataKey tiedToKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiedToKey);
			return *(Evidence.DataKey*)num;
		}
		set
		{
			*(Evidence.DataKey*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tiedToKey)) = dataKey;
		}
	}

	public unsafe int ranking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ranking);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ranking)) = num;
		}
	}

	public unsafe bool removeAfterSaying
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeAfterSaying);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeAfterSaying)) = flag;
		}
	}

	public unsafe bool dailyReplenish
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dailyReplenish);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dailyReplenish)) = flag;
		}
	}

	public unsafe bool isJobDetails
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isJobDetails);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isJobDetails)) = flag;
		}
	}

	public unsafe bool ignoreActiveJobRequirement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreActiveJobRequirement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreActiveJobRequirement)) = flag;
		}
	}

	public unsafe SpecialCase specialCase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialCase);
			return *(SpecialCase*)num;
		}
		set
		{
			*(SpecialCase*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specialCase)) = specialCase;
		}
	}

	public unsafe int cost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cost);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cost)) = num;
		}
	}

	public unsafe bool usePercentageCost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePercentageCost);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePercentageCost)) = flag;
		}
	}

	public unsafe bool useAllWealthIfNotEnough
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAllWealthIfNotEnough);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useAllWealthIfNotEnough)) = flag;
		}
	}

	public unsafe bool displayIfPasswordUnknown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayIfPasswordUnknown);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayIfPasswordUnknown)) = flag;
		}
	}

	public unsafe InputSetting inputBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputBox);
			return *(InputSetting*)num;
		}
		set
		{
			*(InputSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputBox)) = inputSetting;
		}
	}

	public unsafe bool displayAsIllegal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayAsIllegal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayAsIllegal)) = flag;
		}
	}

	public unsafe string preceedingSyntax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preceedingSyntax);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preceedingSyntax)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string followingSyntax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followingSyntax);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followingSyntax)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool useSuccessTest
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSuccessTest);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSuccessTest)) = flag;
		}
	}

	public unsafe bool requiresPassword
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresPassword);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresPassword)) = flag;
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

	public unsafe float affectChanceIfRestrained
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectChanceIfRestrained);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectChanceIfRestrained)) = num;
		}
	}

	public unsafe List<CharacterTrait.TraitPickRule> modifySuccessChanceTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifySuccessChanceTraits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait.TraitPickRule>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifySuccessChanceTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AIActionPreset.AISpeechPreset> responses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_responses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIActionPreset.AISpeechPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_responses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DialogPreset> followUpDialogSuccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followUpDialogSuccess);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DialogPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followUpDialogSuccess)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DialogPreset> followUpDialogFail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followUpDialogFail);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DialogPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followUpDialogFail)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DialogPreset> removeDialog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeDialog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DialogPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeDialog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DialogPreset> removeDialogOnSuccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeDialogOnSuccess);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DialogPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeDialogOnSuccess)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DialogPreset> removeDialogOnFail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeDialogOnFail);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DialogPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeDialogOnFail)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static DialogPreset()
	{
		Il2CppClassPointerStore<DialogPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DialogPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr);
		NativeFieldInfoPtr_msgID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "msgID");
		NativeFieldInfoPtr_defaultOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "defaultOption");
		NativeFieldInfoPtr_telephoneCallOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "telephoneCallOption");
		NativeFieldInfoPtr_hospitalDecisionOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "hospitalDecisionOption");
		NativeFieldInfoPtr_tiedToKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "tiedToKey");
		NativeFieldInfoPtr_ranking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "ranking");
		NativeFieldInfoPtr_removeAfterSaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "removeAfterSaying");
		NativeFieldInfoPtr_dailyReplenish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "dailyReplenish");
		NativeFieldInfoPtr_isJobDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "isJobDetails");
		NativeFieldInfoPtr_ignoreActiveJobRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "ignoreActiveJobRequirement");
		NativeFieldInfoPtr_specialCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "specialCase");
		NativeFieldInfoPtr_cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "cost");
		NativeFieldInfoPtr_usePercentageCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "usePercentageCost");
		NativeFieldInfoPtr_useAllWealthIfNotEnough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "useAllWealthIfNotEnough");
		NativeFieldInfoPtr_displayIfPasswordUnknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "displayIfPasswordUnknown");
		NativeFieldInfoPtr_inputBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "inputBox");
		NativeFieldInfoPtr_displayAsIllegal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "displayAsIllegal");
		NativeFieldInfoPtr_preceedingSyntax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "preceedingSyntax");
		NativeFieldInfoPtr_followingSyntax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "followingSyntax");
		NativeFieldInfoPtr_useSuccessTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "useSuccessTest");
		NativeFieldInfoPtr_requiresPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "requiresPassword");
		NativeFieldInfoPtr_baseChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "baseChance");
		NativeFieldInfoPtr_affectChanceIfRestrained = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "affectChanceIfRestrained");
		NativeFieldInfoPtr_modifySuccessChanceTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "modifySuccessChanceTraits");
		NativeFieldInfoPtr_responses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "responses");
		NativeFieldInfoPtr_followUpDialogSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "followUpDialogSuccess");
		NativeFieldInfoPtr_followUpDialogFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "followUpDialogFail");
		NativeFieldInfoPtr_removeDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "removeDialog");
		NativeFieldInfoPtr_removeDialogOnSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "removeDialogOnSuccess");
		NativeFieldInfoPtr_removeDialogOnFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, "removeDialogOnFail");
		NativeMethodInfoPtr_GetCost_Public_Int32_Actor_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, 100673875);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr, 100673876);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 328137, RefRangeEnd = 328142, XrefRangeStart = 328099, XrefRangeEnd = 328137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCost(Actor talkingTo, Actor talking = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)talkingTo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)talking);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCost_Public_Int32_Actor_Actor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328142, XrefRangeEnd = 328178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DialogPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DialogPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
