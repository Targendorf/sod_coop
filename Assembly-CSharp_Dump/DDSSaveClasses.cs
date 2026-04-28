using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DDSSaveClasses : Il2CppSystem.Object
{
	public enum TreeTriggers
	{
		awake,
		dead,
		asleep,
		unconscious,
		noReactionState,
		investigating,
		investigatingVisual,
		investigatingSound,
		persuing,
		searching,
		notInCombat,
		inCombat,
		legal,
		illegal,
		travelling,
		sat,
		employee,
		nonEmployee,
		carrying,
		notCarrying,
		privateLocation,
		publicLocation,
		onStreet,
		atHome,
		atWork,
		lightOnAny,
		lightOnMain,
		allLightsOff,
		rain,
		indoors,
		brokenSign,
		travellingToWork,
		notPresent,
		atEatery,
		hasJob,
		unemployed,
		homeIntenseWallpaper,
		homeBrightSign,
		enforcerOnDuty,
		notEnforcerOnDuty,
		trespassing,
		locationOfAuthority,
		drunk,
		restrained,
		sober,
		hasRoomAtHotel,
		hotelPaymentDue,
		hasNoRoomAtHotel,
		single,
		notSingle
	}

	public enum RepeatSetting
	{
		oneHour,
		sixHours,
		twelveHours,
		oneDay,
		twoDays,
		threeDays,
		oneWeek,
		never,
		noLimit
	}

	public enum TriggerPoint
	{
		onNewTrackTarget,
		onNewAction,
		whileTickOnTrackTarget,
		vmail,
		telephone,
		never,
		newspaperArticle,
		onGameStart
	}

	public enum TraitConditionType
	{
		IfAnyOfThese,
		IfAllOfThese,
		IfNoneOfThese,
		otherAnyOfThese,
		otherAllOfThese,
		otherNoneOfThese
	}

	[System.Serializable]
	public class DDSComponent : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

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

		public unsafe string id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static DDSComponent()
		{
			Il2CppClassPointerStore<DDSComponent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr, "DDSComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DDSComponent>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSComponent>.NativeClassPtr, "name");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSComponent>.NativeClassPtr, "id");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSComponent>.NativeClassPtr, 100666461);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DDSComponent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DDSComponent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DDSComponent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DDSBlockSave : DDSComponent
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_replacements;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddReplacement_Public_DDSReplacement_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<DDSReplacement> replacements
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replacements);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DDSReplacement>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replacements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static DDSBlockSave()
		{
			Il2CppClassPointerStore<DDSBlockSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr, "DDSBlockSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DDSBlockSave>.NativeClassPtr);
			NativeFieldInfoPtr_replacements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSBlockSave>.NativeClassPtr, "replacements");
			NativeMethodInfoPtr_AddReplacement_Public_DDSReplacement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSBlockSave>.NativeClassPtr, 100666462);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSBlockSave>.NativeClassPtr, 100666463);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109288, XrefRangeEnd = 109318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DDSReplacement AddReplacement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddReplacement_Public_DDSReplacement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSReplacement>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109318, XrefRangeEnd = 109324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DDSBlockSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DDSBlockSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DDSBlockSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DDSReplacement : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_replaceWithID;

		private static readonly System.IntPtr NativeFieldInfoPtr_useConnection;

		private static readonly System.IntPtr NativeFieldInfoPtr_connection;

		private static readonly System.IntPtr NativeFieldInfoPtr_useDislikeLike;

		private static readonly System.IntPtr NativeFieldInfoPtr_strangerKnown;

		private static readonly System.IntPtr NativeFieldInfoPtr_dislikeLike;

		private static readonly System.IntPtr NativeFieldInfoPtr_useTraits;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitCondition;

		private static readonly System.IntPtr NativeFieldInfoPtr_traits;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string replaceWithID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceWithID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replaceWithID)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe bool useConnection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useConnection);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useConnection)) = flag;
			}
		}

		public unsafe Acquaintance.ConnectionType connection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connection);
				return *(Acquaintance.ConnectionType*)num;
			}
			set
			{
				*(Acquaintance.ConnectionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connection)) = connectionType;
			}
		}

		public unsafe bool useDislikeLike
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDislikeLike);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDislikeLike)) = flag;
			}
		}

		public unsafe float strangerKnown
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strangerKnown);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strangerKnown)) = num;
			}
		}

		public unsafe float dislikeLike
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dislikeLike);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dislikeLike)) = num;
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

		public unsafe TraitConditionType traitCondition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitCondition);
				return *(TraitConditionType*)num;
			}
			set
			{
				*(TraitConditionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitCondition)) = traitConditionType;
			}
		}

		public unsafe List<string> traits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traits);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static DDSReplacement()
		{
			Il2CppClassPointerStore<DDSReplacement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr, "DDSReplacement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DDSReplacement>.NativeClassPtr);
			NativeFieldInfoPtr_replaceWithID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSReplacement>.NativeClassPtr, "replaceWithID");
			NativeFieldInfoPtr_useConnection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSReplacement>.NativeClassPtr, "useConnection");
			NativeFieldInfoPtr_connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSReplacement>.NativeClassPtr, "connection");
			NativeFieldInfoPtr_useDislikeLike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSReplacement>.NativeClassPtr, "useDislikeLike");
			NativeFieldInfoPtr_strangerKnown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSReplacement>.NativeClassPtr, "strangerKnown");
			NativeFieldInfoPtr_dislikeLike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSReplacement>.NativeClassPtr, "dislikeLike");
			NativeFieldInfoPtr_useTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSReplacement>.NativeClassPtr, "useTraits");
			NativeFieldInfoPtr_traitCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSReplacement>.NativeClassPtr, "traitCondition");
			NativeFieldInfoPtr_traits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSReplacement>.NativeClassPtr, "traits");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSReplacement>.NativeClassPtr, 100666464);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109324, XrefRangeEnd = 109330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DDSReplacement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DDSReplacement>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DDSReplacement(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DDSMessageSave : DDSComponent
	{
		[ObfuscatedName("DDSSaveClasses+DDSMessageSave+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_instID;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveBlock_b__0_Internal_Boolean_DDSBlockCondition_0;

			public unsafe string instID
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instID);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instID)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DDSMessageSave>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr);
				NativeFieldInfoPtr_instID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, "instID");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100666468);
				NativeMethodInfoPtr__RemoveBlock_b__0_Internal_Boolean_DDSBlockCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr, 100666469);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass4_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveBlock_b__0(DDSBlockCondition item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveBlock_b__0_Internal_Boolean_DDSBlockCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass4_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_blocks;

		private static readonly System.IntPtr NativeFieldInfoPtr_baseSuccessChance;

		private static readonly System.IntPtr NativeFieldInfoPtr_events;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddBlock_Public_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBlock_Public_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<DDSBlockCondition> blocks
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocks);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DDSBlockCondition>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe float baseSuccessChance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseSuccessChance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseSuccessChance)) = num;
			}
		}

		public unsafe List<DDSInteractionEvent> events
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_events);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DDSInteractionEvent>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_events)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static DDSMessageSave()
		{
			Il2CppClassPointerStore<DDSMessageSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr, "DDSMessageSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DDSMessageSave>.NativeClassPtr);
			NativeFieldInfoPtr_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSave>.NativeClassPtr, "blocks");
			NativeFieldInfoPtr_baseSuccessChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSave>.NativeClassPtr, "baseSuccessChance");
			NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSave>.NativeClassPtr, "events");
			NativeMethodInfoPtr_AddBlock_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSMessageSave>.NativeClassPtr, 100666465);
			NativeMethodInfoPtr_RemoveBlock_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSMessageSave>.NativeClassPtr, 100666466);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSMessageSave>.NativeClassPtr, 100666467);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109330, XrefRangeEnd = 109351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBlock(string newBlockID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newBlockID);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBlock_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109351, XrefRangeEnd = 109373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveBlock(string instID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(instID);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBlock_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109373, XrefRangeEnd = 109385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DDSMessageSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DDSMessageSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DDSMessageSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DDSBlockCondition : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_blockID;

		private static readonly System.IntPtr NativeFieldInfoPtr_instanceID;

		private static readonly System.IntPtr NativeFieldInfoPtr_alwaysDisplay;

		private static readonly System.IntPtr NativeFieldInfoPtr_group;

		private static readonly System.IntPtr NativeFieldInfoPtr_useTraits;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitConditions;

		private static readonly System.IntPtr NativeFieldInfoPtr_traits;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string blockID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockID)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string instanceID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceID)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe bool alwaysDisplay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysDisplay);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysDisplay)) = flag;
			}
		}

		public unsafe int group
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_group);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_group)) = num;
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

		public unsafe TraitConditionType traitConditions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitConditions);
				return *(TraitConditionType*)num;
			}
			set
			{
				*(TraitConditionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitConditions)) = traitConditionType;
			}
		}

		public unsafe List<string> traits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traits);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static DDSBlockCondition()
		{
			Il2CppClassPointerStore<DDSBlockCondition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr, "DDSBlockCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DDSBlockCondition>.NativeClassPtr);
			NativeFieldInfoPtr_blockID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSBlockCondition>.NativeClassPtr, "blockID");
			NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSBlockCondition>.NativeClassPtr, "instanceID");
			NativeFieldInfoPtr_alwaysDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSBlockCondition>.NativeClassPtr, "alwaysDisplay");
			NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSBlockCondition>.NativeClassPtr, "group");
			NativeFieldInfoPtr_useTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSBlockCondition>.NativeClassPtr, "useTraits");
			NativeFieldInfoPtr_traitConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSBlockCondition>.NativeClassPtr, "traitConditions");
			NativeFieldInfoPtr_traits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSBlockCondition>.NativeClassPtr, "traits");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSBlockCondition>.NativeClassPtr, 100666470);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109385, XrefRangeEnd = 109391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DDSBlockCondition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DDSBlockCondition>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DDSBlockCondition(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum TreeType
	{
		conversation,
		vmail,
		document,
		newspaper,
		misc,
		interactionDialog
	}

	[System.Serializable]
	public class DDSTreeSave : DDSComponent
	{
		[ObfuscatedName("DDSSaveClasses+DDSTreeSave+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_instID;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveMessage_b__0_Internal_Boolean_DDSMessageSettings_0;

			public unsafe string instID
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instID);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instID)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr);
				NativeFieldInfoPtr_instID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr, "instID");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr, 100666475);
				NativeMethodInfoPtr__RemoveMessage_b__0_Internal_Boolean_DDSMessageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr, 100666476);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass22_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveMessage_b__0(DDSMessageSettings item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveMessage_b__0_Internal_Boolean_DDSMessageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass22_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_participantA;

		private static readonly System.IntPtr NativeFieldInfoPtr_participantB;

		private static readonly System.IntPtr NativeFieldInfoPtr_participantC;

		private static readonly System.IntPtr NativeFieldInfoPtr_participantD;

		private static readonly System.IntPtr NativeFieldInfoPtr_repeat;

		private static readonly System.IntPtr NativeFieldInfoPtr_triggerPoint;

		private static readonly System.IntPtr NativeFieldInfoPtr_messages;

		private static readonly System.IntPtr NativeFieldInfoPtr_stopMovement;

		private static readonly System.IntPtr NativeFieldInfoPtr_ignoreGlobalRepeat;

		private static readonly System.IntPtr NativeFieldInfoPtr_treeType;

		private static readonly System.IntPtr NativeFieldInfoPtr_document;

		private static readonly System.IntPtr NativeFieldInfoPtr_startingMessage;

		private static readonly System.IntPtr NativeFieldInfoPtr_treeChance;

		private static readonly System.IntPtr NativeFieldInfoPtr_priority;

		private static readonly System.IntPtr NativeFieldInfoPtr_newspaperCategory;

		private static readonly System.IntPtr NativeFieldInfoPtr_newspaperContext;

		private static readonly System.IntPtr NativeFieldInfoPtr_interactionCitizenLimitation;

		private static readonly System.IntPtr NativeFieldInfoPtr_itemPool;

		private static readonly System.IntPtr NativeFieldInfoPtr_interactionOnePerCity;

		private static readonly System.IntPtr NativeFieldInfoPtr_messageRef;

		private static readonly System.IntPtr NativeFieldInfoPtr_citizenAddCount;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddMessage_Public_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveMessage_Public_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddElement_Public_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe DDSParticipant participantA
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantA);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSParticipant>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantA)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSParticipant));
			}
		}

		public unsafe DDSParticipant participantB
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantB);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSParticipant>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantB)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSParticipant));
			}
		}

		public unsafe DDSParticipant participantC
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantC);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSParticipant>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantC)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSParticipant));
			}
		}

		public unsafe DDSParticipant participantD
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantD);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSParticipant>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantD)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSParticipant));
			}
		}

		public unsafe RepeatSetting repeat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeat);
				return *(RepeatSetting*)num;
			}
			set
			{
				*(RepeatSetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeat)) = repeatSetting;
			}
		}

		public unsafe TriggerPoint triggerPoint
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerPoint);
				return *(TriggerPoint*)num;
			}
			set
			{
				*(TriggerPoint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerPoint)) = triggerPoint;
			}
		}

		public unsafe List<DDSMessageSettings> messages
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messages);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DDSMessageSettings>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool stopMovement
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopMovement);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stopMovement)) = flag;
			}
		}

		public unsafe bool ignoreGlobalRepeat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreGlobalRepeat);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreGlobalRepeat)) = flag;
			}
		}

		public unsafe TreeType treeType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeType);
				return *(TreeType*)num;
			}
			set
			{
				*(TreeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeType)) = treeType;
			}
		}

		public unsafe DDSDocument document
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_document);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSDocument>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_document)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSDocument));
			}
		}

		public unsafe string startingMessage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingMessage);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingMessage)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe float treeChance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeChance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeChance)) = num;
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

		public unsafe int newspaperCategory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newspaperCategory);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newspaperCategory)) = num;
			}
		}

		public unsafe int newspaperContext
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newspaperContext);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newspaperContext)) = num;
			}
		}

		public unsafe int interactionCitizenLimitation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionCitizenLimitation);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionCitizenLimitation)) = num;
			}
		}

		public unsafe List<string> itemPool
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemPool);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool interactionOnePerCity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionOnePerCity);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionOnePerCity)) = flag;
			}
		}

		public unsafe Dictionary<string, DDSMessageSettings> messageRef
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageRef);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, DDSMessageSettings>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageRef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe int citizenAddCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenAddCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenAddCount)) = num;
			}
		}

		static DDSTreeSave()
		{
			Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr, "DDSTreeSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr);
			NativeFieldInfoPtr_participantA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "participantA");
			NativeFieldInfoPtr_participantB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "participantB");
			NativeFieldInfoPtr_participantC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "participantC");
			NativeFieldInfoPtr_participantD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "participantD");
			NativeFieldInfoPtr_repeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "repeat");
			NativeFieldInfoPtr_triggerPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "triggerPoint");
			NativeFieldInfoPtr_messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "messages");
			NativeFieldInfoPtr_stopMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "stopMovement");
			NativeFieldInfoPtr_ignoreGlobalRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "ignoreGlobalRepeat");
			NativeFieldInfoPtr_treeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "treeType");
			NativeFieldInfoPtr_document = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "document");
			NativeFieldInfoPtr_startingMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "startingMessage");
			NativeFieldInfoPtr_treeChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "treeChance");
			NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "priority");
			NativeFieldInfoPtr_newspaperCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "newspaperCategory");
			NativeFieldInfoPtr_newspaperContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "newspaperContext");
			NativeFieldInfoPtr_interactionCitizenLimitation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "interactionCitizenLimitation");
			NativeFieldInfoPtr_itemPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "itemPool");
			NativeFieldInfoPtr_interactionOnePerCity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "interactionOnePerCity");
			NativeFieldInfoPtr_messageRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "messageRef");
			NativeFieldInfoPtr_citizenAddCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, "citizenAddCount");
			NativeMethodInfoPtr_AddMessage_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, 100666471);
			NativeMethodInfoPtr_RemoveMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, 100666472);
			NativeMethodInfoPtr_AddElement_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, 100666473);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr, 100666474);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109391, XrefRangeEnd = 109408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AddMessage(string newMsgID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newMsgID);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMessage_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109408, XrefRangeEnd = 109427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveMessage(string instID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(instID);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109427, XrefRangeEnd = 109444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AddElement(string elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddElement_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109444, XrefRangeEnd = 109469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DDSTreeSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DDSTreeSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DDSTreeSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DDSDocument : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_background;

		private static readonly System.IntPtr NativeFieldInfoPtr_fill;

		private static readonly System.IntPtr NativeFieldInfoPtr_size;

		private static readonly System.IntPtr NativeFieldInfoPtr_colour;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string background
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_background);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_background)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Image.Type fill
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fill);
				return *(Image.Type*)num;
			}
			set
			{
				*(Image.Type*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fill)) = type;
			}
		}

		public unsafe Vector2 size
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = vector;
			}
		}

		public unsafe Color colour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour)) = color;
			}
		}

		static DDSDocument()
		{
			Il2CppClassPointerStore<DDSDocument>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr, "DDSDocument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DDSDocument>.NativeClassPtr);
			NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSDocument>.NativeClassPtr, "background");
			NativeFieldInfoPtr_fill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSDocument>.NativeClassPtr, "fill");
			NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSDocument>.NativeClassPtr, "size");
			NativeFieldInfoPtr_colour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSDocument>.NativeClassPtr, "colour");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSDocument>.NativeClassPtr, 100666477);
		}

		[CallerCount(0)]
		public unsafe DDSDocument()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DDSDocument>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DDSDocument(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum ElementType
	{
		messageText,
		special
	}

	[System.Serializable]
	public class DDSMessageSettings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_msgID;

		private static readonly System.IntPtr NativeFieldInfoPtr_elementName;

		private static readonly System.IntPtr NativeFieldInfoPtr_instanceID;

		private static readonly System.IntPtr NativeFieldInfoPtr_saidBy;

		private static readonly System.IntPtr NativeFieldInfoPtr_saidTo;

		private static readonly System.IntPtr NativeFieldInfoPtr_pos;

		private static readonly System.IntPtr NativeFieldInfoPtr_size;

		private static readonly System.IntPtr NativeFieldInfoPtr_rot;

		private static readonly System.IntPtr NativeFieldInfoPtr_font;

		private static readonly System.IntPtr NativeFieldInfoPtr_col;

		private static readonly System.IntPtr NativeFieldInfoPtr_fontSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_charSpace;

		private static readonly System.IntPtr NativeFieldInfoPtr_wordSpace;

		private static readonly System.IntPtr NativeFieldInfoPtr_lineSpace;

		private static readonly System.IntPtr NativeFieldInfoPtr_paraSpace;

		private static readonly System.IntPtr NativeFieldInfoPtr_alignH;

		private static readonly System.IntPtr NativeFieldInfoPtr_alignV;

		private static readonly System.IntPtr NativeFieldInfoPtr_fontStyle;

		private static readonly System.IntPtr NativeFieldInfoPtr_order;

		private static readonly System.IntPtr NativeFieldInfoPtr_usePages;

		private static readonly System.IntPtr NativeFieldInfoPtr_isHandwriting;

		private static readonly System.IntPtr NativeFieldInfoPtr_links;

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

		public unsafe string elementName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string instanceID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceID)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int saidBy
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saidBy);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saidBy)) = num;
			}
		}

		public unsafe int saidTo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saidTo);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saidTo)) = num;
			}
		}

		public unsafe Vector2 pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector;
			}
		}

		public unsafe Vector2 size
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = vector;
			}
		}

		public unsafe float rot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rot);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rot)) = num;
			}
		}

		public unsafe string font
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_font)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Color col
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_col);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_col)) = color;
			}
		}

		public unsafe float fontSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontSize);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontSize)) = num;
			}
		}

		public unsafe float charSpace
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charSpace);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charSpace)) = num;
			}
		}

		public unsafe float wordSpace
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordSpace);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordSpace)) = num;
			}
		}

		public unsafe float lineSpace
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineSpace);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineSpace)) = num;
			}
		}

		public unsafe float paraSpace
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paraSpace);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paraSpace)) = num;
			}
		}

		public unsafe int alignH
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignH);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignH)) = num;
			}
		}

		public unsafe int alignV
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignV);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alignV)) = num;
			}
		}

		public unsafe int fontStyle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontStyle);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontStyle)) = num;
			}
		}

		public unsafe int order
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_order);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_order)) = num;
			}
		}

		public unsafe bool usePages
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePages);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePages)) = flag;
			}
		}

		public unsafe bool isHandwriting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHandwriting);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHandwriting)) = flag;
			}
		}

		public unsafe List<DDSMessageLink> links
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_links);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DDSMessageLink>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_links)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static DDSMessageSettings()
		{
			Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr, "DDSMessageSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr);
			NativeFieldInfoPtr_msgID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "msgID");
			NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "elementName");
			NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "instanceID");
			NativeFieldInfoPtr_saidBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "saidBy");
			NativeFieldInfoPtr_saidTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "saidTo");
			NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "pos");
			NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "size");
			NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "rot");
			NativeFieldInfoPtr_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "font");
			NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "col");
			NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "fontSize");
			NativeFieldInfoPtr_charSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "charSpace");
			NativeFieldInfoPtr_wordSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "wordSpace");
			NativeFieldInfoPtr_lineSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "lineSpace");
			NativeFieldInfoPtr_paraSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "paraSpace");
			NativeFieldInfoPtr_alignH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "alignH");
			NativeFieldInfoPtr_alignV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "alignV");
			NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "fontStyle");
			NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "order");
			NativeFieldInfoPtr_usePages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "usePages");
			NativeFieldInfoPtr_isHandwriting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "isHandwriting");
			NativeFieldInfoPtr_links = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, "links");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr, 100666478);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109477, RefRangeEnd = 109479, XrefRangeStart = 109469, XrefRangeEnd = 109477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DDSMessageSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DDSMessageSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DDSMessageSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DDSMessageLink : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_from;

		private static readonly System.IntPtr NativeFieldInfoPtr_to;

		private static readonly System.IntPtr NativeFieldInfoPtr_delayInterval;

		private static readonly System.IntPtr NativeFieldInfoPtr_useWeights;

		private static readonly System.IntPtr NativeFieldInfoPtr_choiceWeight;

		private static readonly System.IntPtr NativeFieldInfoPtr_useKnowLike;

		private static readonly System.IntPtr NativeFieldInfoPtr_know;

		private static readonly System.IntPtr NativeFieldInfoPtr_like;

		private static readonly System.IntPtr NativeFieldInfoPtr_isDialogSuccess;

		private static readonly System.IntPtr NativeFieldInfoPtr_secondaryBranchTrigger;

		private static readonly System.IntPtr NativeFieldInfoPtr_dialogSuccessModifier;

		private static readonly System.IntPtr NativeFieldInfoPtr_useTraits;

		private static readonly System.IntPtr NativeFieldInfoPtr_traits;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitConditions;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string from
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_from);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_from)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string to
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_to);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_to)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Vector2 delayInterval
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayInterval);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayInterval)) = vector;
			}
		}

		public unsafe bool useWeights
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWeights);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useWeights)) = flag;
			}
		}

		public unsafe float choiceWeight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choiceWeight);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_choiceWeight)) = num;
			}
		}

		public unsafe bool useKnowLike
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useKnowLike);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useKnowLike)) = flag;
			}
		}

		public unsafe float know
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_know);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_know)) = num;
			}
		}

		public unsafe float like
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_like);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_like)) = num;
			}
		}

		public unsafe bool isDialogSuccess
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDialogSuccess);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDialogSuccess)) = flag;
			}
		}

		public unsafe bool secondaryBranchTrigger
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryBranchTrigger);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryBranchTrigger)) = flag;
			}
		}

		public unsafe float dialogSuccessModifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogSuccessModifier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogSuccessModifier)) = num;
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

		public unsafe List<string> traits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traits);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe TraitConditionType traitConditions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitConditions);
				return *(TraitConditionType*)num;
			}
			set
			{
				*(TraitConditionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitConditions)) = traitConditionType;
			}
		}

		static DDSMessageLink()
		{
			Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr, "DDSMessageLink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr);
			NativeFieldInfoPtr_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "from");
			NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "to");
			NativeFieldInfoPtr_delayInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "delayInterval");
			NativeFieldInfoPtr_useWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "useWeights");
			NativeFieldInfoPtr_choiceWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "choiceWeight");
			NativeFieldInfoPtr_useKnowLike = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "useKnowLike");
			NativeFieldInfoPtr_know = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "know");
			NativeFieldInfoPtr_like = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "like");
			NativeFieldInfoPtr_isDialogSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "isDialogSuccess");
			NativeFieldInfoPtr_secondaryBranchTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "secondaryBranchTrigger");
			NativeFieldInfoPtr_dialogSuccessModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "dialogSuccessModifier");
			NativeFieldInfoPtr_useTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "useTraits");
			NativeFieldInfoPtr_traits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "traits");
			NativeFieldInfoPtr_traitConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, "traitConditions");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr, 100666479);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109479, XrefRangeEnd = 109485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DDSMessageLink()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DDSMessageLink>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DDSMessageLink(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DDSParticipant : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_required;

		private static readonly System.IntPtr NativeFieldInfoPtr_connection;

		private static readonly System.IntPtr NativeFieldInfoPtr_useJobs;

		private static readonly System.IntPtr NativeFieldInfoPtr_disableInbox;

		private static readonly System.IntPtr NativeFieldInfoPtr_jobs;

		private static readonly System.IntPtr NativeFieldInfoPtr_useTraits;

		private static readonly System.IntPtr NativeFieldInfoPtr_traits;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitConditions;

		private static readonly System.IntPtr NativeFieldInfoPtr_triggers;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool required
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_required);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_required)) = flag;
			}
		}

		public unsafe Acquaintance.ConnectionType connection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connection);
				return *(Acquaintance.ConnectionType*)num;
			}
			set
			{
				*(Acquaintance.ConnectionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connection)) = connectionType;
			}
		}

		public unsafe bool useJobs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useJobs);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useJobs)) = flag;
			}
		}

		public unsafe bool disableInbox
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableInbox);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableInbox)) = flag;
			}
		}

		public unsafe List<string> jobs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobs);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

		public unsafe List<string> traits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traits);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe TraitConditionType traitConditions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitConditions);
				return *(TraitConditionType*)num;
			}
			set
			{
				*(TraitConditionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitConditions)) = traitConditionType;
			}
		}

		public unsafe List<TreeTriggers> triggers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TreeTriggers>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static DDSParticipant()
		{
			Il2CppClassPointerStore<DDSParticipant>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr, "DDSParticipant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DDSParticipant>.NativeClassPtr);
			NativeFieldInfoPtr_required = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSParticipant>.NativeClassPtr, "required");
			NativeFieldInfoPtr_connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSParticipant>.NativeClassPtr, "connection");
			NativeFieldInfoPtr_useJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSParticipant>.NativeClassPtr, "useJobs");
			NativeFieldInfoPtr_disableInbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSParticipant>.NativeClassPtr, "disableInbox");
			NativeFieldInfoPtr_jobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSParticipant>.NativeClassPtr, "jobs");
			NativeFieldInfoPtr_useTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSParticipant>.NativeClassPtr, "useTraits");
			NativeFieldInfoPtr_traits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSParticipant>.NativeClassPtr, "traits");
			NativeFieldInfoPtr_traitConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSParticipant>.NativeClassPtr, "traitConditions");
			NativeFieldInfoPtr_triggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSParticipant>.NativeClassPtr, "triggers");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSParticipant>.NativeClassPtr, 100666480);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 109501, RefRangeEnd = 109505, XrefRangeStart = 109485, XrefRangeEnd = 109501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DDSParticipant()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DDSParticipant>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DDSParticipant(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DDSInteractionEvent : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_on;

		private static readonly System.IntPtr NativeFieldInfoPtr_param;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe InteractionEvent on
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_on);
				return *(InteractionEvent*)num;
			}
			set
			{
				*(InteractionEvent*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_on)) = interactionEvent;
			}
		}

		public unsafe string param
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_param);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_param)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static DDSInteractionEvent()
		{
			Il2CppClassPointerStore<DDSInteractionEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr, "DDSInteractionEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DDSInteractionEvent>.NativeClassPtr);
			NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSInteractionEvent>.NativeClassPtr, "on");
			NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSInteractionEvent>.NativeClassPtr, "param");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSInteractionEvent>.NativeClassPtr, 100666481);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DDSInteractionEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DDSInteractionEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DDSInteractionEvent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum InteractionEvent
	{
		none,
		isInteractionDialog,
		generateNewItemFromPool,
		findWorldItemFromPool,
		giveMoney,
		testHasItem,
		testHasItemSameType,
		testHasItemSameTypeAndOwner,
		testHasItemSameTypeAndOwnerStat,
		clearItem,
		deleteItem,
		clearAllAddedDialogOptions,
		postNewspaperAd,
		generateNewItem,
		moveItemToInventory,
		moveItem,
		setItem,
		postJobNote,
		goTo,
		setNourishment,
		setHydration,
		setAlertness,
		setEnergy,
		setExcitement,
		setChores,
		setHygeine,
		setBladder,
		setHeat,
		setDrunk,
		setPoisoned,
		setHealth
	}

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static DDSSaveClasses()
	{
		Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DDSSaveClasses");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr, 100666460);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DDSSaveClasses()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DDSSaveClasses>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DDSSaveClasses(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
