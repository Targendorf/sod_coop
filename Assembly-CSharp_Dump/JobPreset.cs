using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class JobPreset : SoCustomComparison
{
	public enum JobTag
	{
		A,
		B,
		C,
		D,
		E,
		F,
		G,
		H,
		I,
		J,
		K,
		L,
		M,
		N,
		O,
		P,
		Q,
		R,
		S,
		T,
		U,
		V,
		W,
		X,
		Y,
		Z
	}

	[System.Serializable]
	public class StartingScenario : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_dds;

		private static readonly System.IntPtr NativeFieldInfoPtr_leads;

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

		public unsafe string dds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dds);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dds)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe List<StartingLead> leads
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leads);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StartingLead>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leads)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static StartingScenario()
		{
			Il2CppClassPointerStore<StartingScenario>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "StartingScenario");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartingScenario>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingScenario>.NativeClassPtr, "name");
			NativeFieldInfoPtr_dds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingScenario>.NativeClassPtr, "dds");
			NativeFieldInfoPtr_leads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingScenario>.NativeClassPtr, "leads");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartingScenario>.NativeClassPtr, 100673965);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329152, XrefRangeEnd = 329158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartingScenario()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartingScenario>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public StartingScenario(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class StartingLead : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_leadEvidence;

		private static readonly System.IntPtr NativeFieldInfoPtr_keys;

		private static readonly System.IntPtr NativeFieldInfoPtr_useKeyFromLeadPool;

		private static readonly System.IntPtr NativeFieldInfoPtr_autoPin;

		private static readonly System.IntPtr NativeFieldInfoPtr_addDialogOptions;

		private static readonly System.IntPtr NativeFieldInfoPtr_factsReveal;

		private static readonly System.IntPtr NativeFieldInfoPtr_mergeKeys;

		private static readonly System.IntPtr NativeFieldInfoPtr_discoveryApplication;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe LeadEvidence leadEvidence
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leadEvidence);
				return *(LeadEvidence*)num;
			}
			set
			{
				*(LeadEvidence*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leadEvidence)) = leadEvidence;
			}
		}

		public unsafe List<Evidence.DataKey> keys
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keys);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool useKeyFromLeadPool
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useKeyFromLeadPool);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useKeyFromLeadPool)) = flag;
			}
		}

		public unsafe bool autoPin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPin);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPin)) = flag;
			}
		}

		public unsafe List<DialogPreset> addDialogOptions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addDialogOptions);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DialogPreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addDialogOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<string> factsReveal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factsReveal);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factsReveal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<Evidence.DataKey> mergeKeys
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mergeKeys);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mergeKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<Evidence.Discovery> discoveryApplication
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoveryApplication);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.Discovery>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoveryApplication)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static StartingLead()
		{
			Il2CppClassPointerStore<StartingLead>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "StartingLead");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartingLead>.NativeClassPtr);
			NativeFieldInfoPtr_leadEvidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingLead>.NativeClassPtr, "leadEvidence");
			NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingLead>.NativeClassPtr, "keys");
			NativeFieldInfoPtr_useKeyFromLeadPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingLead>.NativeClassPtr, "useKeyFromLeadPool");
			NativeFieldInfoPtr_autoPin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingLead>.NativeClassPtr, "autoPin");
			NativeFieldInfoPtr_addDialogOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingLead>.NativeClassPtr, "addDialogOptions");
			NativeFieldInfoPtr_factsReveal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingLead>.NativeClassPtr, "factsReveal");
			NativeFieldInfoPtr_mergeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingLead>.NativeClassPtr, "mergeKeys");
			NativeFieldInfoPtr_discoveryApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingLead>.NativeClassPtr, "discoveryApplication");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartingLead>.NativeClassPtr, 100673966);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329158, XrefRangeEnd = 329186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartingLead()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartingLead>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public StartingLead(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class FactCreation : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_factPreset;

		private static readonly System.IntPtr NativeFieldInfoPtr_from;

		private static readonly System.IntPtr NativeFieldInfoPtr_to;

		private static readonly System.IntPtr NativeFieldInfoPtr_overrideFromKeys;

		private static readonly System.IntPtr NativeFieldInfoPtr_fromKeys;

		private static readonly System.IntPtr NativeFieldInfoPtr_featureKeysFromLeadPool;

		private static readonly System.IntPtr NativeFieldInfoPtr_overrideToKeys;

		private static readonly System.IntPtr NativeFieldInfoPtr_toKeys;

		private static readonly System.IntPtr NativeFieldInfoPtr_featureKeysFromLeadPoolTo;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe FactPreset factPreset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factPreset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factPreset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factPreset));
			}
		}

		public unsafe LeadEvidence from
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_from);
				return *(LeadEvidence*)num;
			}
			set
			{
				*(LeadEvidence*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_from)) = leadEvidence;
			}
		}

		public unsafe LeadEvidence to
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_to);
				return *(LeadEvidence*)num;
			}
			set
			{
				*(LeadEvidence*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_to)) = leadEvidence;
			}
		}

		public unsafe bool overrideFromKeys
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideFromKeys);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideFromKeys)) = flag;
			}
		}

		public unsafe List<Evidence.DataKey> fromKeys
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromKeys);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool featureKeysFromLeadPool
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureKeysFromLeadPool);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureKeysFromLeadPool)) = flag;
			}
		}

		public unsafe bool overrideToKeys
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideToKeys);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideToKeys)) = flag;
			}
		}

		public unsafe List<Evidence.DataKey> toKeys
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toKeys);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool featureKeysFromLeadPoolTo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureKeysFromLeadPoolTo);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featureKeysFromLeadPoolTo)) = flag;
			}
		}

		static FactCreation()
		{
			Il2CppClassPointerStore<FactCreation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "FactCreation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactCreation>.NativeClassPtr);
			NativeFieldInfoPtr_factPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactCreation>.NativeClassPtr, "factPreset");
			NativeFieldInfoPtr_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactCreation>.NativeClassPtr, "from");
			NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactCreation>.NativeClassPtr, "to");
			NativeFieldInfoPtr_overrideFromKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactCreation>.NativeClassPtr, "overrideFromKeys");
			NativeFieldInfoPtr_fromKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactCreation>.NativeClassPtr, "fromKeys");
			NativeFieldInfoPtr_featureKeysFromLeadPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactCreation>.NativeClassPtr, "featureKeysFromLeadPool");
			NativeFieldInfoPtr_overrideToKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactCreation>.NativeClassPtr, "overrideToKeys");
			NativeFieldInfoPtr_toKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactCreation>.NativeClassPtr, "toKeys");
			NativeFieldInfoPtr_featureKeysFromLeadPoolTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactCreation>.NativeClassPtr, "featureKeysFromLeadPoolTo");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactCreation>.NativeClassPtr, 100673967);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329186, XrefRangeEnd = 329196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FactCreation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactCreation>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FactCreation(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum LeadEvidence
	{
		none,
		poster,
		purp,
		purpsParamour,
		postersHome,
		purpsHome,
		purpsParamourHome,
		postersWorkplace,
		purpsWorkplace,
		purpsParamourWorkplace,
		postersBuilding,
		purpsBuilding,
		purpsParamourBuilding,
		post,
		posterTelephone,
		purpsTelephone,
		purpsParamourTelephone,
		postersWorkplaceBuilding,
		purpsWorkplaceBuilding,
		purpsParamourWorkplaceBuilding,
		extraPerson1,
		itemA,
		itemB,
		itemC,
		itemD,
		itemE
	}

	public enum BasicLeadPool
	{
		hair,
		eyeColour,
		shoeSize,
		build,
		height,
		fingerprint,
		age,
		jobTitle,
		randomInterest,
		partnerFirstName,
		partnerJobTitle,
		firstNameInitial,
		socialClub,
		partnerSocialClub,
		notableFeatures,
		salary,
		bloodType,
		randomAffliction,
		handwriting
	}

	public enum LeadCitizen
	{
		nobody,
		poster,
		purp,
		purpsParamour
	}

	public enum JobSpawnWhere
	{
		posterHome,
		posterWork,
		purpHome,
		purpWork,
		purpsParamourHome,
		purpsParamourWork,
		hiddenItemPlace,
		nearbyGooseChase
	}

	public enum DifficultyTag
	{
		D0,
		D1,
		D2A,
		D2B,
		D3,
		D4A,
		D4B,
		D4C,
		D5,
		D6
	}

	[System.Serializable]
	public class JobModifierRule : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_who;

		private static readonly System.IntPtr NativeFieldInfoPtr_rule;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitList;

		private static readonly System.IntPtr NativeFieldInfoPtr_mustPassForApplication;

		private static readonly System.IntPtr NativeFieldInfoPtr_chanceModifier;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe LeadCitizen who
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_who);
				return *(LeadCitizen*)num;
			}
			set
			{
				*(LeadCitizen*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_who)) = leadCitizen;
			}
		}

		public unsafe CharacterTrait.RuleType rule
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rule);
				return *(CharacterTrait.RuleType*)num;
			}
			set
			{
				*(CharacterTrait.RuleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rule)) = ruleType;
			}
		}

		public unsafe List<CharacterTrait> traitList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool mustPassForApplication
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustPassForApplication);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustPassForApplication)) = flag;
			}
		}

		public unsafe float chanceModifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceModifier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceModifier)) = num;
			}
		}

		static JobModifierRule()
		{
			Il2CppClassPointerStore<JobModifierRule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "JobModifierRule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobModifierRule>.NativeClassPtr);
			NativeFieldInfoPtr_who = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobModifierRule>.NativeClassPtr, "who");
			NativeFieldInfoPtr_rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobModifierRule>.NativeClassPtr, "rule");
			NativeFieldInfoPtr_traitList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobModifierRule>.NativeClassPtr, "traitList");
			NativeFieldInfoPtr_mustPassForApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobModifierRule>.NativeClassPtr, "mustPassForApplication");
			NativeFieldInfoPtr_chanceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobModifierRule>.NativeClassPtr, "chanceModifier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobModifierRule>.NativeClassPtr, 100673968);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329196, XrefRangeEnd = 329202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JobModifierRule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JobModifierRule>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public JobModifierRule(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class StartingSpawnItem : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_findExisting;

		private static readonly System.IntPtr NativeFieldInfoPtr_compatibleWithMotives;

		private static readonly System.IntPtr NativeFieldInfoPtr_compatibleWithAllMotives;

		private static readonly System.IntPtr NativeFieldInfoPtr_chance;

		private static readonly System.IntPtr NativeFieldInfoPtr_useTraits;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitModifiers;

		private static readonly System.IntPtr NativeFieldInfoPtr_useIf;

		private static readonly System.IntPtr NativeFieldInfoPtr_ifTag;

		private static readonly System.IntPtr NativeFieldInfoPtr_useOrGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr_orGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr_chanceRatio;

		private static readonly System.IntPtr NativeFieldInfoPtr_disableOnDifficulties;

		private static readonly System.IntPtr NativeFieldInfoPtr_itemTag;

		private static readonly System.IntPtr NativeFieldInfoPtr_spawnItem;

		private static readonly System.IntPtr NativeFieldInfoPtr_vmailThread;

		private static readonly System.IntPtr NativeFieldInfoPtr_vmailProgressThreshold;

		private static readonly System.IntPtr NativeFieldInfoPtr_where;

		private static readonly System.IntPtr NativeFieldInfoPtr_belongsTo;

		private static readonly System.IntPtr NativeFieldInfoPtr_writer;

		private static readonly System.IntPtr NativeFieldInfoPtr_receiver;

		private static readonly System.IntPtr NativeFieldInfoPtr_security;

		private static readonly System.IntPtr NativeFieldInfoPtr_priority;

		private static readonly System.IntPtr NativeFieldInfoPtr_ownershipRule;

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

		public unsafe bool findExisting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_findExisting);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_findExisting)) = flag;
			}
		}

		public unsafe List<MotivePreset> compatibleWithMotives
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWithMotives);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MotivePreset>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWithMotives)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool compatibleWithAllMotives
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWithAllMotives);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleWithAllMotives)) = flag;
			}
		}

		public unsafe float chance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance)) = num;
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

		public unsafe List<JobModifierRule> traitModifiers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<JobModifierRule>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool useIf
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useIf);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useIf)) = flag;
			}
		}

		public unsafe JobTag ifTag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifTag);
				return *(JobTag*)num;
			}
			set
			{
				*(JobTag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ifTag)) = jobTag;
			}
		}

		public unsafe bool useOrGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOrGroup);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useOrGroup)) = flag;
			}
		}

		public unsafe JobTag orGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orGroup);
				return *(JobTag*)num;
			}
			set
			{
				*(JobTag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orGroup)) = jobTag;
			}
		}

		public unsafe int chanceRatio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceRatio);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chanceRatio)) = num;
			}
		}

		public unsafe List<DifficultyTag> disableOnDifficulties
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableOnDifficulties);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DifficultyTag>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableOnDifficulties)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe JobTag itemTag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemTag);
				return *(JobTag*)num;
			}
			set
			{
				*(JobTag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemTag)) = jobTag;
			}
		}

		public unsafe InteractablePreset spawnItem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnItem);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
			}
		}

		public unsafe string vmailThread
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vmailThread);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vmailThread)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Vector2 vmailProgressThreshold
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vmailProgressThreshold);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vmailProgressThreshold)) = vector;
			}
		}

		public unsafe JobSpawnWhere where
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_where);
				return *(JobSpawnWhere*)num;
			}
			set
			{
				*(JobSpawnWhere*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_where)) = jobSpawnWhere;
			}
		}

		public unsafe LeadCitizen belongsTo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo);
				return *(LeadCitizen*)num;
			}
			set
			{
				*(LeadCitizen*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_belongsTo)) = leadCitizen;
			}
		}

		public unsafe LeadCitizen writer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer);
				return *(LeadCitizen*)num;
			}
			set
			{
				*(LeadCitizen*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writer)) = leadCitizen;
			}
		}

		public unsafe LeadCitizen receiver
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiver);
				return *(LeadCitizen*)num;
			}
			set
			{
				*(LeadCitizen*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiver)) = leadCitizen;
			}
		}

		public unsafe int security
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_security);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_security)) = num;
			}
		}

		public unsafe int priority
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority)) = num;
			}
		}

		public unsafe InteractablePreset.OwnedPlacementRule ownershipRule
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownershipRule);
				return *(InteractablePreset.OwnedPlacementRule*)num;
			}
			set
			{
				*(InteractablePreset.OwnedPlacementRule*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ownershipRule)) = ownedPlacementRule;
			}
		}

		static StartingSpawnItem()
		{
			Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "StartingSpawnItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "name");
			NativeFieldInfoPtr_findExisting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "findExisting");
			NativeFieldInfoPtr_compatibleWithMotives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "compatibleWithMotives");
			NativeFieldInfoPtr_compatibleWithAllMotives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "compatibleWithAllMotives");
			NativeFieldInfoPtr_chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "chance");
			NativeFieldInfoPtr_useTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "useTraits");
			NativeFieldInfoPtr_traitModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "traitModifiers");
			NativeFieldInfoPtr_useIf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "useIf");
			NativeFieldInfoPtr_ifTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "ifTag");
			NativeFieldInfoPtr_useOrGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "useOrGroup");
			NativeFieldInfoPtr_orGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "orGroup");
			NativeFieldInfoPtr_chanceRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "chanceRatio");
			NativeFieldInfoPtr_disableOnDifficulties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "disableOnDifficulties");
			NativeFieldInfoPtr_itemTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "itemTag");
			NativeFieldInfoPtr_spawnItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "spawnItem");
			NativeFieldInfoPtr_vmailThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "vmailThread");
			NativeFieldInfoPtr_vmailProgressThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "vmailProgressThreshold");
			NativeFieldInfoPtr_where = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "where");
			NativeFieldInfoPtr_belongsTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "belongsTo");
			NativeFieldInfoPtr_writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "writer");
			NativeFieldInfoPtr_receiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "receiver");
			NativeFieldInfoPtr_security = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "security");
			NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "priority");
			NativeFieldInfoPtr_ownershipRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, "ownershipRule");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr, 100673969);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329202, XrefRangeEnd = 329220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartingSpawnItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartingSpawnItem>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public StartingSpawnItem(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class HandInLocation : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_who;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe LeadCitizen who
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_who);
				return *(LeadCitizen*)num;
			}
			set
			{
				*(LeadCitizen*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_who)) = leadCitizen;
			}
		}

		static HandInLocation()
		{
			Il2CppClassPointerStore<HandInLocation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "HandInLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandInLocation>.NativeClassPtr);
			NativeFieldInfoPtr_who = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandInLocation>.NativeClassPtr, "who");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandInLocation>.NativeClassPtr, 100673970);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandInLocation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandInLocation>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public HandInLocation(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class IntroConfig : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_frequency;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe SideMissionIntroPreset preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SideMissionIntroPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sideMissionIntroPreset));
			}
		}

		public unsafe int frequency
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency)) = num;
			}
		}

		static IntroConfig()
		{
			Il2CppClassPointerStore<IntroConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "IntroConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroConfig>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroConfig>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroConfig>.NativeClassPtr, "frequency");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroConfig>.NativeClassPtr, 100673971);
		}

		[CallerCount(0)]
		public unsafe IntroConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroConfig>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public IntroConfig(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class HandInConfig : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_frequency;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe SideMissionHandInPreset preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SideMissionHandInPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sideMissionHandInPreset));
			}
		}

		public unsafe int frequency
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frequency)) = num;
			}
		}

		static HandInConfig()
		{
			Il2CppClassPointerStore<HandInConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "HandInConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandInConfig>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandInConfig>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandInConfig>.NativeClassPtr, "frequency");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandInConfig>.NativeClassPtr, 100673972);
		}

		[CallerCount(0)]
		public unsafe HandInConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandInConfig>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public HandInConfig(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum RewardLocation
	{
		none,
		postersMailbox,
		cityHallDesk,
		playersMailbox
	}

	public enum ParticipantCompliancy
	{
		noChange,
		alwaysSuccess,
		alwaysFail
	}

	[System.Serializable]
	public class DialogReference : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_dialog;

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

		public unsafe DialogPreset dialog
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialog);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogPreset));
			}
		}

		static DialogReference()
		{
			Il2CppClassPointerStore<DialogReference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "DialogReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogReference>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogReference>.NativeClassPtr, "name");
			NativeFieldInfoPtr_dialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogReference>.NativeClassPtr, "dialog");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogReference>.NativeClassPtr, 100673973);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogReference>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DialogReference(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_disabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_caseName;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobPosting;

	private static readonly System.IntPtr NativeFieldInfoPtr_subClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowSyncDiskRewards;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowBlackMarketSyncDiskRewards;

	private static readonly System.IntPtr NativeFieldInfoPtr_physicalRewardLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_generateHidingLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_socialCreditLevelMinSpawnFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_activePerCitizen;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_immediatePostCountThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_difficultyTag;

	private static readonly System.IntPtr NativeFieldInfoPtr_changePosterDialogCompliancy;

	private static readonly System.IntPtr NativeFieldInfoPtr_changePerpDialogCompliancy;

	private static readonly System.IntPtr NativeFieldInfoPtr_purpetratorMotives;

	private static readonly System.IntPtr NativeFieldInfoPtr_penaltyForPurpAndPosterSameBuilding;

	private static readonly System.IntPtr NativeFieldInfoPtr_startingScenarios;

	private static readonly System.IntPtr NativeFieldInfoPtr_compatibleIntros;

	private static readonly System.IntPtr NativeFieldInfoPtr_leadPoolData;

	private static readonly System.IntPtr NativeFieldInfoPtr_createFactsOnInformationAcquisition;

	private static readonly System.IntPtr NativeFieldInfoPtr_informationAcquisitionLeads;

	private static readonly System.IntPtr NativeFieldInfoPtr_revengeObjectives;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_resolveQuestions;

	private static readonly System.IntPtr NativeFieldInfoPtr_additional;

	private static readonly System.IntPtr NativeFieldInfoPtr_compatibleHandIns;

	private static readonly System.IntPtr NativeFieldInfoPtr_dialogReferences;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugCopyFrom;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyAcquisitionData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrequencyData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyStartingScenarios_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyItemSpawns_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyResolveQuestions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyIntros_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyHandIns_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyAdditionalMainElements_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyDialogReferences_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDifficultyValue_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFrequencyForSocialCreditLevel_Public_Int32_0;

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

	public unsafe string caseName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe InteractablePreset jobPosting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobPosting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobPosting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
		}
	}

	public unsafe string subClass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subClass);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subClass)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool allowSyncDiskRewards
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowSyncDiskRewards);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowSyncDiskRewards)) = flag;
		}
	}

	public unsafe bool allowBlackMarketSyncDiskRewards
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowBlackMarketSyncDiskRewards);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowBlackMarketSyncDiskRewards)) = flag;
		}
	}

	public unsafe RewardLocation physicalRewardLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicalRewardLocation);
			return *(RewardLocation*)num;
		}
		set
		{
			*(RewardLocation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicalRewardLocation)) = rewardLocation;
		}
	}

	public unsafe bool generateHidingLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateHidingLocation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateHidingLocation)) = flag;
		}
	}

	public unsafe AnimationCurve socialCreditLevelMinSpawnFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialCreditLevelMinSpawnFrequency);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialCreditLevelMinSpawnFrequency)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe float activePerCitizen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activePerCitizen);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activePerCitizen)) = num;
		}
	}

	public unsafe int maxJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxJobs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxJobs)) = num;
		}
	}

	public unsafe int immediatePostCountThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_immediatePostCountThreshold);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_immediatePostCountThreshold)) = num;
		}
	}

	public unsafe DifficultyTag difficultyTag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyTag);
			return *(DifficultyTag*)num;
		}
		set
		{
			*(DifficultyTag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_difficultyTag)) = difficultyTag;
		}
	}

	public unsafe ParticipantCompliancy changePosterDialogCompliancy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changePosterDialogCompliancy);
			return *(ParticipantCompliancy*)num;
		}
		set
		{
			*(ParticipantCompliancy*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changePosterDialogCompliancy)) = participantCompliancy;
		}
	}

	public unsafe ParticipantCompliancy changePerpDialogCompliancy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changePerpDialogCompliancy);
			return *(ParticipantCompliancy*)num;
		}
		set
		{
			*(ParticipantCompliancy*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changePerpDialogCompliancy)) = participantCompliancy;
		}
	}

	public unsafe List<MotivePreset> purpetratorMotives
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpetratorMotives);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MotivePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_purpetratorMotives)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int penaltyForPurpAndPosterSameBuilding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_penaltyForPurpAndPosterSameBuilding);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_penaltyForPurpAndPosterSameBuilding)) = num;
		}
	}

	public unsafe List<StartingScenario> startingScenarios
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingScenarios);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StartingScenario>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingScenarios)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<IntroConfig> compatibleIntros
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleIntros);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IntroConfig>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleIntros)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int leadPoolData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leadPoolData);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leadPoolData)) = num;
		}
	}

	public unsafe List<FactCreation> createFactsOnInformationAcquisition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createFactsOnInformationAcquisition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FactCreation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createFactsOnInformationAcquisition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<StartingLead> informationAcquisitionLeads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_informationAcquisitionLeads);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StartingLead>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_informationAcquisitionLeads)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<RevengeObjective> revengeObjectives
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_revengeObjectives);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RevengeObjective>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_revengeObjectives)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<StartingSpawnItem> spawnItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StartingSpawnItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Case.ResolveQuestion> resolveQuestions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolveQuestions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Case.ResolveQuestion>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolveQuestions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SideMissionIntroPreset.SideMissionObjectiveBlock> additional
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additional);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SideMissionIntroPreset.SideMissionObjectiveBlock>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additional)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<HandInConfig> compatibleHandIns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleHandIns);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HandInConfig>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleHandIns)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DialogReference> dialogReferences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogReferences);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DialogReference>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogReferences)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe JobPreset debugCopyFrom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugCopyFrom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<JobPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugCopyFrom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)jobPreset));
		}
	}

	static JobPreset()
	{
		Il2CppClassPointerStore<JobPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "JobPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobPreset>.NativeClassPtr);
		NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "disabled");
		NativeFieldInfoPtr_caseName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "caseName");
		NativeFieldInfoPtr_jobPosting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "jobPosting");
		NativeFieldInfoPtr_subClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "subClass");
		NativeFieldInfoPtr_allowSyncDiskRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "allowSyncDiskRewards");
		NativeFieldInfoPtr_allowBlackMarketSyncDiskRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "allowBlackMarketSyncDiskRewards");
		NativeFieldInfoPtr_physicalRewardLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "physicalRewardLocation");
		NativeFieldInfoPtr_generateHidingLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "generateHidingLocation");
		NativeFieldInfoPtr_socialCreditLevelMinSpawnFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "socialCreditLevelMinSpawnFrequency");
		NativeFieldInfoPtr_activePerCitizen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "activePerCitizen");
		NativeFieldInfoPtr_maxJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "maxJobs");
		NativeFieldInfoPtr_immediatePostCountThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "immediatePostCountThreshold");
		NativeFieldInfoPtr_difficultyTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "difficultyTag");
		NativeFieldInfoPtr_changePosterDialogCompliancy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "changePosterDialogCompliancy");
		NativeFieldInfoPtr_changePerpDialogCompliancy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "changePerpDialogCompliancy");
		NativeFieldInfoPtr_purpetratorMotives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "purpetratorMotives");
		NativeFieldInfoPtr_penaltyForPurpAndPosterSameBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "penaltyForPurpAndPosterSameBuilding");
		NativeFieldInfoPtr_startingScenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "startingScenarios");
		NativeFieldInfoPtr_compatibleIntros = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "compatibleIntros");
		NativeFieldInfoPtr_leadPoolData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "leadPoolData");
		NativeFieldInfoPtr_createFactsOnInformationAcquisition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "createFactsOnInformationAcquisition");
		NativeFieldInfoPtr_informationAcquisitionLeads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "informationAcquisitionLeads");
		NativeFieldInfoPtr_revengeObjectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "revengeObjectives");
		NativeFieldInfoPtr_spawnItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "spawnItems");
		NativeFieldInfoPtr_resolveQuestions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "resolveQuestions");
		NativeFieldInfoPtr_additional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "additional");
		NativeFieldInfoPtr_compatibleHandIns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "compatibleHandIns");
		NativeFieldInfoPtr_dialogReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "dialogReferences");
		NativeFieldInfoPtr_debugCopyFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, "debugCopyFrom");
		NativeMethodInfoPtr_CopyAcquisitionData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, 100673953);
		NativeMethodInfoPtr_CopyFrequencyData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, 100673954);
		NativeMethodInfoPtr_CopyStartingScenarios_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, 100673955);
		NativeMethodInfoPtr_CopyItemSpawns_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, 100673956);
		NativeMethodInfoPtr_CopyResolveQuestions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, 100673957);
		NativeMethodInfoPtr_CopyIntros_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, 100673958);
		NativeMethodInfoPtr_CopyHandIns_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, 100673959);
		NativeMethodInfoPtr_CopyAdditionalMainElements_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, 100673960);
		NativeMethodInfoPtr_CopyDialogReferences_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, 100673961);
		NativeMethodInfoPtr_GetDifficultyValue_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, 100673962);
		NativeMethodInfoPtr_GetFrequencyForSocialCreditLevel_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, 100673963);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobPreset>.NativeClassPtr, 100673964);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyAcquisitionData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyAcquisitionData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyFrequencyData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFrequencyData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyStartingScenarios()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyStartingScenarios_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyItemSpawns()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyItemSpawns_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyResolveQuestions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyResolveQuestions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyIntros()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyIntros_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyHandIns()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyHandIns_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyAdditionalMainElements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyAdditionalMainElements_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyDialogReferences()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyDialogReferences_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetDifficultyValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDifficultyValue_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 329230, RefRangeEnd = 329231, XrefRangeStart = 329220, XrefRangeEnd = 329230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetFrequencyForSocialCreditLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFrequencyForSocialCreditLevel_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329231, XrefRangeEnd = 329301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JobPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public JobPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
