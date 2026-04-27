using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class EvidencePreset : SoCustomComparison
{
	public enum CaptureRules
	{
		building,
		location,
		item,
		citizen
	}

	public enum BelongsToSetting
	{
		self,
		partner,
		paramour,
		boss,
		doctor,
		landlord
	}

	public enum Subject
	{
		self,
		writer,
		receiver,
		parent,
		interactable,
		interactableLocation
	}

	[System.Serializable]
	public class EvidenceFactSetup : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_link;

		private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfInOwnedPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_createOnDiscovery;

		private static readonly System.IntPtr NativeFieldInfoPtr_forceDiscoveryOnCreation;

		private static readonly System.IntPtr NativeFieldInfoPtr_switchFindingFactToFrom;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe FactPreset preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FactPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)factPreset));
			}
		}

		public unsafe Subject link
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_link);
				return *(Subject*)num;
			}
			set
			{
				*(Subject*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_link)) = subject;
			}
		}

		public unsafe bool onlyIfInOwnedPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfInOwnedPosition);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfInOwnedPosition)) = flag;
			}
		}

		public unsafe bool createOnDiscovery
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createOnDiscovery);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createOnDiscovery)) = flag;
			}
		}

		public unsafe bool forceDiscoveryOnCreation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceDiscoveryOnCreation);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceDiscoveryOnCreation)) = flag;
			}
		}

		public unsafe bool switchFindingFactToFrom
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchFindingFactToFrom);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchFindingFactToFrom)) = flag;
			}
		}

		static EvidenceFactSetup()
		{
			Il2CppClassPointerStore<EvidenceFactSetup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "EvidenceFactSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvidenceFactSetup>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceFactSetup>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_link = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceFactSetup>.NativeClassPtr, "link");
			NativeFieldInfoPtr_onlyIfInOwnedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceFactSetup>.NativeClassPtr, "onlyIfInOwnedPosition");
			NativeFieldInfoPtr_createOnDiscovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceFactSetup>.NativeClassPtr, "createOnDiscovery");
			NativeFieldInfoPtr_forceDiscoveryOnCreation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceFactSetup>.NativeClassPtr, "forceDiscoveryOnCreation");
			NativeFieldInfoPtr_switchFindingFactToFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceFactSetup>.NativeClassPtr, "switchFindingFactToFrom");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvidenceFactSetup>.NativeClassPtr, 100673894);
		}

		[CallerCount(0)]
		public unsafe EvidenceFactSetup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvidenceFactSetup>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public EvidenceFactSetup(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class FactLinkSetup : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_subject;

		private static readonly System.IntPtr NativeFieldInfoPtr_factDictionary;

		private static readonly System.IntPtr NativeFieldInfoPtr_key;

		private static readonly System.IntPtr NativeFieldInfoPtr_discovery;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe FactLinkSubject subject
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subject);
				return *(FactLinkSubject*)num;
			}
			set
			{
				*(FactLinkSubject*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subject)) = factLinkSubject;
			}
		}

		public unsafe string factDictionary
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factDictionary);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factDictionary)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Evidence.DataKey key
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key);
				return *(Evidence.DataKey*)num;
			}
			set
			{
				*(Evidence.DataKey*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key)) = dataKey;
			}
		}

		public unsafe bool discovery
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discovery);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discovery)) = flag;
			}
		}

		static FactLinkSetup()
		{
			Il2CppClassPointerStore<FactLinkSetup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "FactLinkSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FactLinkSetup>.NativeClassPtr);
			NativeFieldInfoPtr_subject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactLinkSetup>.NativeClassPtr, "subject");
			NativeFieldInfoPtr_factDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactLinkSetup>.NativeClassPtr, "factDictionary");
			NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactLinkSetup>.NativeClassPtr, "key");
			NativeFieldInfoPtr_discovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FactLinkSetup>.NativeClassPtr, "discovery");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FactLinkSetup>.NativeClassPtr, 100673895);
		}

		[CallerCount(0)]
		public unsafe FactLinkSetup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FactLinkSetup>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FactLinkSetup(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DataKeyAutomaticTies : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_mainKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_mergeAtStart;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Evidence.DataKey mainKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainKey);
				return *(Evidence.DataKey*)num;
			}
			set
			{
				*(Evidence.DataKey*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainKey)) = dataKey;
			}
		}

		public unsafe List<Evidence.DataKey> mergeAtStart
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mergeAtStart);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mergeAtStart)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static DataKeyAutomaticTies()
		{
			Il2CppClassPointerStore<DataKeyAutomaticTies>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "DataKeyAutomaticTies");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataKeyAutomaticTies>.NativeClassPtr);
			NativeFieldInfoPtr_mainKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataKeyAutomaticTies>.NativeClassPtr, "mainKey");
			NativeFieldInfoPtr_mergeAtStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataKeyAutomaticTies>.NativeClassPtr, "mergeAtStart");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataKeyAutomaticTies>.NativeClassPtr, 100673896);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328306, XrefRangeEnd = 328312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataKeyAutomaticTies()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataKeyAutomaticTies>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DataKeyAutomaticTies(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum FactLinkSubject
	{
		writer,
		receiver
	}

	[System.Serializable]
	public class MergeKeysSetup : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_link;

		private static readonly System.IntPtr NativeFieldInfoPtr_mergeKeys;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Subject link
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_link);
				return *(Subject*)num;
			}
			set
			{
				*(Subject*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_link)) = subject;
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

		static MergeKeysSetup()
		{
			Il2CppClassPointerStore<MergeKeysSetup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "MergeKeysSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MergeKeysSetup>.NativeClassPtr);
			NativeFieldInfoPtr_link = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MergeKeysSetup>.NativeClassPtr, "link");
			NativeFieldInfoPtr_mergeKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MergeKeysSetup>.NativeClassPtr, "mergeKeys");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MergeKeysSetup>.NativeClassPtr, 100673897);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MergeKeysSetup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MergeKeysSetup>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MergeKeysSetup(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DiscoveryApplication : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_link;

		private static readonly System.IntPtr NativeFieldInfoPtr_applyDiscoveryTrigger;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Subject link
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_link);
				return *(Subject*)num;
			}
			set
			{
				*(Subject*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_link)) = subject;
			}
		}

		public unsafe Evidence.Discovery applyDiscoveryTrigger
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyDiscoveryTrigger);
				return *(Evidence.Discovery*)num;
			}
			set
			{
				*(Evidence.Discovery*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyDiscoveryTrigger)) = discovery;
			}
		}

		static DiscoveryApplication()
		{
			Il2CppClassPointerStore<DiscoveryApplication>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "DiscoveryApplication");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscoveryApplication>.NativeClassPtr);
			NativeFieldInfoPtr_link = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscoveryApplication>.NativeClassPtr, "link");
			NativeFieldInfoPtr_applyDiscoveryTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscoveryApplication>.NativeClassPtr, "applyDiscoveryTrigger");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscoveryApplication>.NativeClassPtr, 100673898);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiscoveryApplication()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiscoveryApplication>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DiscoveryApplication(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum PinnedStyle
	{
		polaroid,
		stickNote
	}

	[ObfuscatedName("EvidencePreset+<>c__DisplayClass52_0")]
	public sealed class __c__DisplayClass52_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_key;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__IsKeyValid_b__0_Internal_Boolean_DataKeySettings_0;

		public unsafe Evidence.DataKey key
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key);
				return *(Evidence.DataKey*)num;
			}
			set
			{
				*(Evidence.DataKey*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key)) = dataKey;
			}
		}

		static __c__DisplayClass52_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "<>c__DisplayClass52_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass52_0>.NativeClassPtr);
			NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass52_0>.NativeClassPtr, "key");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_0>.NativeClassPtr, 100673899);
			NativeMethodInfoPtr__IsKeyValid_b__0_Internal_Boolean_DataKeySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass52_0>.NativeClassPtr, 100673900);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass52_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass52_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _IsKeyValid_b__0(DataKeyControls.DataKeySettings item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__IsKeyValid_b__0_Internal_Boolean_DataKeySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass52_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("EvidencePreset+<>c__DisplayClass53_0")]
	public sealed class __c__DisplayClass53_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_key;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__IsKeyUnique_b__0_Internal_Boolean_DataKeySettings_0;

		public unsafe Evidence.DataKey key
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key);
				return *(Evidence.DataKey*)num;
			}
			set
			{
				*(Evidence.DataKey*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_key)) = dataKey;
			}
		}

		static __c__DisplayClass53_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "<>c__DisplayClass53_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass53_0>.NativeClassPtr);
			NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass53_0>.NativeClassPtr, "key");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass53_0>.NativeClassPtr, 100673901);
			NativeMethodInfoPtr__IsKeyUnique_b__0_Internal_Boolean_DataKeySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass53_0>.NativeClassPtr, 100673902);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass53_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass53_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _IsKeyUnique_b__0(DataKeyControls.DataKeySettings item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__IsKeyUnique_b__0_Internal_Boolean_DataKeySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass53_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_subClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_windowStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_useDataKeys;

	private static readonly System.IntPtr NativeFieldInfoPtr_validKeys;

	private static readonly System.IntPtr NativeFieldInfoPtr_passiveTies;

	private static readonly System.IntPtr NativeFieldInfoPtr_notifyOfTies;

	private static readonly System.IntPtr NativeFieldInfoPtr_useBelongsToInName;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSingleton;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowCustomNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_markAsDiscoveredOnAnyInteraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceWorldInteraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_useWindowFocusMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_iconSpriteLarge;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultNullImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_useInGamePhoto;

	private static readonly System.IntPtr NativeFieldInfoPtr_useWriter;

	private static readonly System.IntPtr NativeFieldInfoPtr_relativeCamPhotoPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_relativeCamPhotoEuler;

	private static readonly System.IntPtr NativeFieldInfoPtr_captureRules;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeTimeOfDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_captureTimeOfDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCaptureLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_useSurveillanceCapture;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemOwner;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemWriter;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemReceiver;

	private static readonly System.IntPtr NativeFieldInfoPtr_factSetup;

	private static readonly System.IntPtr NativeFieldInfoPtr_addFactLinks;

	private static readonly System.IntPtr NativeFieldInfoPtr_discoverOnCreate;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyMergeOnDiscovery;

	private static readonly System.IntPtr NativeFieldInfoPtr_discoveryTriggers;

	private static readonly System.IntPtr NativeFieldInfoPtr_applicationOnDiscover;

	private static readonly System.IntPtr NativeFieldInfoPtr_ddsDocumentID;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMatchParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_matchTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableSummary;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableFacts;

	private static readonly System.IntPtr NativeFieldInfoPtr_pinnedStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_pinnedBackgroundColour;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValidProfileKeys_Public_List_1_DataKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUniqueProfileKeys_Public_List_1_DataKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKeyValid_Public_Boolean_DataKey_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKeyUnique_Public_Boolean_DataKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProfileKeyCount_Public_Int32_List_1_DataKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe WindowStylePreset windowStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowStyle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WindowStylePreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowStyle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)windowStylePreset));
		}
	}

	public unsafe bool useDataKeys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDataKeys);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDataKeys)) = flag;
		}
	}

	public unsafe List<DataKeyControls.DataKeySettings> validKeys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validKeys);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DataKeyControls.DataKeySettings>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DataKeyAutomaticTies> passiveTies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passiveTies);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DataKeyAutomaticTies>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passiveTies)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool notifyOfTies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notifyOfTies);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notifyOfTies)) = flag;
		}
	}

	public unsafe bool useBelongsToInName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBelongsToInName);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useBelongsToInName)) = flag;
		}
	}

	public unsafe bool isSingleton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSingleton);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSingleton)) = flag;
		}
	}

	public unsafe bool disableHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableHistory);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableHistory)) = flag;
		}
	}

	public unsafe bool allowCustomNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowCustomNames);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowCustomNames)) = flag;
		}
	}

	public unsafe bool markAsDiscoveredOnAnyInteraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markAsDiscoveredOnAnyInteraction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markAsDiscoveredOnAnyInteraction)) = flag;
		}
	}

	public unsafe bool forceWorldInteraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceWorldInteraction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceWorldInteraction)) = flag;
		}
	}

	public unsafe bool useWindowFocusMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWindowFocusMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWindowFocusMode)) = flag;
		}
	}

	public unsafe Sprite iconSpriteLarge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconSpriteLarge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconSpriteLarge)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Texture2D defaultNullImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultNullImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultNullImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe bool useInGamePhoto
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useInGamePhoto);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useInGamePhoto)) = flag;
		}
	}

	public unsafe bool useWriter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWriter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWriter)) = flag;
		}
	}

	public unsafe Vector3 relativeCamPhotoPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoPos)) = vector;
		}
	}

	public unsafe Vector3 relativeCamPhotoEuler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoEuler);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_relativeCamPhotoEuler)) = vector;
		}
	}

	public unsafe CaptureRules captureRules
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureRules);
			return *(CaptureRules*)num;
		}
		set
		{
			*(CaptureRules*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureRules)) = captureRules;
		}
	}

	public unsafe bool changeTimeOfDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeTimeOfDay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeTimeOfDay)) = flag;
		}
	}

	public unsafe float captureTimeOfDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureTimeOfDay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureTimeOfDay)) = num;
		}
	}

	public unsafe bool useCaptureLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCaptureLight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCaptureLight)) = flag;
		}
	}

	public unsafe bool useSurveillanceCapture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSurveillanceCapture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useSurveillanceCapture)) = flag;
		}
	}

	public unsafe BelongsToSetting itemOwner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemOwner);
			return *(BelongsToSetting*)num;
		}
		set
		{
			*(BelongsToSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemOwner)) = belongsToSetting;
		}
	}

	public unsafe BelongsToSetting itemWriter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemWriter);
			return *(BelongsToSetting*)num;
		}
		set
		{
			*(BelongsToSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemWriter)) = belongsToSetting;
		}
	}

	public unsafe BelongsToSetting itemReceiver
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemReceiver);
			return *(BelongsToSetting*)num;
		}
		set
		{
			*(BelongsToSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemReceiver)) = belongsToSetting;
		}
	}

	public unsafe List<EvidenceFactSetup> factSetup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factSetup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EvidenceFactSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factSetup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FactLinkSetup> addFactLinks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addFactLinks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FactLinkSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addFactLinks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool discoverOnCreate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoverOnCreate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoverOnCreate)) = flag;
		}
	}

	public unsafe List<MergeKeysSetup> keyMergeOnDiscovery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyMergeOnDiscovery);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MergeKeysSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyMergeOnDiscovery)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Evidence.Discovery> discoveryTriggers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoveryTriggers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.Discovery>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoveryTriggers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DiscoveryApplication> applicationOnDiscover
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applicationOnDiscover);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DiscoveryApplication>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applicationOnDiscover)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string ddsDocumentID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsDocumentID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ddsDocumentID)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool isMatchParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMatchParent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMatchParent)) = flag;
		}
	}

	public unsafe List<MatchPreset> matchTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MatchPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool enableSummary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableSummary);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableSummary)) = flag;
		}
	}

	public unsafe bool enableFacts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFacts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFacts)) = flag;
		}
	}

	public unsafe PinnedStyle pinnedStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinnedStyle);
			return *(PinnedStyle*)num;
		}
		set
		{
			*(PinnedStyle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinnedStyle)) = pinnedStyle;
		}
	}

	public unsafe Color pinnedBackgroundColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinnedBackgroundColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinnedBackgroundColour)) = color;
		}
	}

	static EvidencePreset()
	{
		Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EvidencePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr);
		NativeFieldInfoPtr_subClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "subClass");
		NativeFieldInfoPtr_windowStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "windowStyle");
		NativeFieldInfoPtr_useDataKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "useDataKeys");
		NativeFieldInfoPtr_validKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "validKeys");
		NativeFieldInfoPtr_passiveTies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "passiveTies");
		NativeFieldInfoPtr_notifyOfTies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "notifyOfTies");
		NativeFieldInfoPtr_useBelongsToInName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "useBelongsToInName");
		NativeFieldInfoPtr_isSingleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "isSingleton");
		NativeFieldInfoPtr_disableHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "disableHistory");
		NativeFieldInfoPtr_allowCustomNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "allowCustomNames");
		NativeFieldInfoPtr_markAsDiscoveredOnAnyInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "markAsDiscoveredOnAnyInteraction");
		NativeFieldInfoPtr_forceWorldInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "forceWorldInteraction");
		NativeFieldInfoPtr_useWindowFocusMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "useWindowFocusMode");
		NativeFieldInfoPtr_iconSpriteLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "iconSpriteLarge");
		NativeFieldInfoPtr_defaultNullImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "defaultNullImage");
		NativeFieldInfoPtr_useInGamePhoto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "useInGamePhoto");
		NativeFieldInfoPtr_useWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "useWriter");
		NativeFieldInfoPtr_relativeCamPhotoPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "relativeCamPhotoPos");
		NativeFieldInfoPtr_relativeCamPhotoEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "relativeCamPhotoEuler");
		NativeFieldInfoPtr_captureRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "captureRules");
		NativeFieldInfoPtr_changeTimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "changeTimeOfDay");
		NativeFieldInfoPtr_captureTimeOfDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "captureTimeOfDay");
		NativeFieldInfoPtr_useCaptureLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "useCaptureLight");
		NativeFieldInfoPtr_useSurveillanceCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "useSurveillanceCapture");
		NativeFieldInfoPtr_itemOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "itemOwner");
		NativeFieldInfoPtr_itemWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "itemWriter");
		NativeFieldInfoPtr_itemReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "itemReceiver");
		NativeFieldInfoPtr_factSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "factSetup");
		NativeFieldInfoPtr_addFactLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "addFactLinks");
		NativeFieldInfoPtr_discoverOnCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "discoverOnCreate");
		NativeFieldInfoPtr_keyMergeOnDiscovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "keyMergeOnDiscovery");
		NativeFieldInfoPtr_discoveryTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "discoveryTriggers");
		NativeFieldInfoPtr_applicationOnDiscover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "applicationOnDiscover");
		NativeFieldInfoPtr_ddsDocumentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "ddsDocumentID");
		NativeFieldInfoPtr_isMatchParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "isMatchParent");
		NativeFieldInfoPtr_matchTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "matchTypes");
		NativeFieldInfoPtr_enableSummary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "enableSummary");
		NativeFieldInfoPtr_enableFacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "enableFacts");
		NativeFieldInfoPtr_pinnedStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "pinnedStyle");
		NativeFieldInfoPtr_pinnedBackgroundColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, "pinnedBackgroundColour");
		NativeMethodInfoPtr_GetValidProfileKeys_Public_List_1_DataKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, 100673888);
		NativeMethodInfoPtr_GetUniqueProfileKeys_Public_List_1_DataKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, 100673889);
		NativeMethodInfoPtr_IsKeyValid_Public_Boolean_DataKey_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, 100673890);
		NativeMethodInfoPtr_IsKeyUnique_Public_Boolean_DataKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, 100673891);
		NativeMethodInfoPtr_GetProfileKeyCount_Public_Int32_List_1_DataKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, 100673892);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr, 100673893);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 328329, RefRangeEnd = 328332, XrefRangeStart = 328312, XrefRangeEnd = 328329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Evidence.DataKey> GetValidProfileKeys()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValidProfileKeys_Public_List_1_DataKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328332, XrefRangeEnd = 328349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Evidence.DataKey> GetUniqueProfileKeys()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUniqueProfileKeys_Public_List_1_DataKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 328361, RefRangeEnd = 328363, XrefRangeStart = 328349, XrefRangeEnd = 328361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsKeyValid(Evidence.DataKey key, out bool countTowardsProfile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&key);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref countTowardsProfile);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKeyValid_Public_Boolean_DataKey_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 328375, RefRangeEnd = 328386, XrefRangeStart = 328363, XrefRangeEnd = 328375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsKeyUnique(Evidence.DataKey key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKeyUnique_Public_Boolean_DataKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 328395, RefRangeEnd = 328399, XrefRangeStart = 328386, XrefRangeEnd = 328395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetProfileKeyCount(List<Evidence.DataKey> keyList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProfileKeyCount_Public_Int32_List_1_DataKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328399, XrefRangeEnd = 328457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EvidencePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvidencePreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EvidencePreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
