using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class Human : Actor
{
	public enum ShoeType
	{
		normal,
		boots,
		heel,
		barefoot
	}

	public enum MovementSpeed
	{
		stopped,
		walking,
		running
	}

	public enum Gender
	{
		male,
		female,
		nonBinary
	}

	public enum BloodType
	{
		unassigned,
		Apos,
		Aneg,
		Bpos,
		Bneg,
		Opos,
		Oneg,
		ABpos,
		ABneg
	}

	[System.Serializable]
	public class Trait : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitID;

		private static readonly System.IntPtr NativeFieldInfoPtr_trait;

		private static readonly System.IntPtr NativeFieldInfoPtr_reason;

		private static readonly System.IntPtr NativeFieldInfoPtr_date;

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

		public unsafe int traitID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitID)) = num;
			}
		}

		public unsafe CharacterTrait trait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		public unsafe Trait reason
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reason);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Trait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reason)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trait));
			}
		}

		public unsafe string date
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_date);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_date)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static Trait()
		{
			Il2CppClassPointerStore<Trait>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "Trait");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Trait>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trait>.NativeClassPtr, "name");
			NativeFieldInfoPtr_traitID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trait>.NativeClassPtr, "traitID");
			NativeFieldInfoPtr_trait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trait>.NativeClassPtr, "trait");
			NativeFieldInfoPtr_reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trait>.NativeClassPtr, "reason");
			NativeFieldInfoPtr_date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trait>.NativeClassPtr, "date");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trait>.NativeClassPtr, 100664260);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Trait()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Trait>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Trait(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class WeightedTrait : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_trait;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitValue;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe CharacterTrait trait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		public unsafe float traitValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitValue);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitValue)) = num;
			}
		}

		static WeightedTrait()
		{
			Il2CppClassPointerStore<WeightedTrait>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "WeightedTrait");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeightedTrait>.NativeClassPtr);
			NativeFieldInfoPtr_trait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedTrait>.NativeClassPtr, "trait");
			NativeFieldInfoPtr_traitValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeightedTrait>.NativeClassPtr, "traitValue");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeightedTrait>.NativeClassPtr, 100664261);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeightedTrait()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeightedTrait>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public WeightedTrait(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class Sighting : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_time;

		private static readonly System.IntPtr NativeFieldInfoPtr_node;

		private static readonly System.IntPtr NativeFieldInfoPtr_mov;

		private static readonly System.IntPtr NativeFieldInfoPtr_dest;

		private static readonly System.IntPtr NativeFieldInfoPtr_run;

		private static readonly System.IntPtr NativeFieldInfoPtr_exp;

		private static readonly System.IntPtr NativeFieldInfoPtr_drunk;

		private static readonly System.IntPtr NativeFieldInfoPtr_phone;

		private static readonly System.IntPtr NativeFieldInfoPtr_poi;

		private static readonly System.IntPtr NativeFieldInfoPtr_sound;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe float time
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time)) = num;
			}
		}

		public unsafe Vector3 node
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node)) = vector;
			}
		}

		public unsafe bool mov
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mov);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mov)) = flag;
			}
		}

		public unsafe Vector3 dest
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dest);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dest)) = vector;
			}
		}

		public unsafe bool run
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_run);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_run)) = flag;
			}
		}

		public unsafe int exp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exp);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exp)) = num;
			}
		}

		public unsafe bool drunk
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunk);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunk)) = flag;
			}
		}

		public unsafe bool phone
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_phone);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_phone)) = flag;
			}
		}

		public unsafe bool poi
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poi);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poi)) = flag;
			}
		}

		public unsafe int sound
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sound);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sound)) = num;
			}
		}

		static Sighting()
		{
			Il2CppClassPointerStore<Sighting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "Sighting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sighting>.NativeClassPtr);
			NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sighting>.NativeClassPtr, "time");
			NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sighting>.NativeClassPtr, "node");
			NativeFieldInfoPtr_mov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sighting>.NativeClassPtr, "mov");
			NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sighting>.NativeClassPtr, "dest");
			NativeFieldInfoPtr_run = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sighting>.NativeClassPtr, "run");
			NativeFieldInfoPtr_exp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sighting>.NativeClassPtr, "exp");
			NativeFieldInfoPtr_drunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sighting>.NativeClassPtr, "drunk");
			NativeFieldInfoPtr_phone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sighting>.NativeClassPtr, "phone");
			NativeFieldInfoPtr_poi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sighting>.NativeClassPtr, "poi");
			NativeFieldInfoPtr_sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sighting>.NativeClassPtr, "sound");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sighting>.NativeClassPtr, 100664262);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sighting()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sighting>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Sighting(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ConversationInstance : Il2CppSystem.Object
	{
		[ObfuscatedName("Human+ConversationInstance+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_instanceID;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__SetCurrentMessage_b__0_Internal_Boolean_DDSMessageSettings_0;

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

			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass18_0>.NativeClassPtr);
				NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass18_0>.NativeClassPtr, "instanceID");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass18_0>.NativeClassPtr, 100664266);
				NativeMethodInfoPtr__SetCurrentMessage_b__0_Internal_Boolean_DDSMessageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass18_0>.NativeClassPtr, 100664267);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass18_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22690, XrefRangeEnd = 22691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetCurrentMessage_b__0(DDSSaveClasses.DDSMessageSettings item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetCurrentMessage_b__0_Internal_Boolean_DDSMessageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass18_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_active;

		private static readonly System.IntPtr NativeFieldInfoPtr_room;

		private static readonly System.IntPtr NativeFieldInfoPtr_tree;

		private static readonly System.IntPtr NativeFieldInfoPtr_participantA;

		private static readonly System.IntPtr NativeFieldInfoPtr_participantB;

		private static readonly System.IntPtr NativeFieldInfoPtr_participantC;

		private static readonly System.IntPtr NativeFieldInfoPtr_participantD;

		private static readonly System.IntPtr NativeFieldInfoPtr_previouslyTalking;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentlyTalking;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentlyTalkingTo;

		private static readonly System.IntPtr NativeFieldInfoPtr_speechTriggered;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentMessage;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentLink;

		private static readonly System.IntPtr NativeFieldInfoPtr_linkDelay;

		private static readonly System.IntPtr NativeFieldInfoPtr_timeUntilNextSpeech;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentlyTalkingSpeechQueue;

		private static readonly System.IntPtr NativeFieldInfoPtr_treeName;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndConversation_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentMessage_Public_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool active
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_active);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_active)) = flag;
			}
		}

		public unsafe NewRoom room
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_room);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_room)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
			}
		}

		public unsafe DDSSaveClasses.DDSTreeSave tree
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tree);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSSaveClasses.DDSTreeSave>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSTreeSave));
			}
		}

		public unsafe Human participantA
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantA);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantA)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe Human participantB
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantB);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantB)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe Human participantC
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantC);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantC)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe Human participantD
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantD);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantD)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe Human previouslyTalking
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previouslyTalking);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previouslyTalking)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe Human currentlyTalking
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentlyTalking);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentlyTalking)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe Human currentlyTalkingTo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentlyTalkingTo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentlyTalkingTo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe bool speechTriggered
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speechTriggered);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speechTriggered)) = flag;
			}
		}

		public unsafe DDSSaveClasses.DDSMessageSettings currentMessage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMessage);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSSaveClasses.DDSMessageSettings>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMessage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSMessageSettings));
			}
		}

		public unsafe DDSSaveClasses.DDSMessageLink currentLink
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLink);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSSaveClasses.DDSMessageLink>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLink)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSMessageLink));
			}
		}

		public unsafe float linkDelay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkDelay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkDelay)) = num;
			}
		}

		public unsafe float timeUntilNextSpeech
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeUntilNextSpeech);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeUntilNextSpeech)) = num;
			}
		}

		public unsafe int currentlyTalkingSpeechQueue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentlyTalkingSpeechQueue);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentlyTalkingSpeechQueue)) = num;
			}
		}

		public unsafe string treeName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static ConversationInstance()
		{
			Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "ConversationInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr);
			NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "active");
			NativeFieldInfoPtr_room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "room");
			NativeFieldInfoPtr_tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "tree");
			NativeFieldInfoPtr_participantA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "participantA");
			NativeFieldInfoPtr_participantB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "participantB");
			NativeFieldInfoPtr_participantC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "participantC");
			NativeFieldInfoPtr_participantD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "participantD");
			NativeFieldInfoPtr_previouslyTalking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "previouslyTalking");
			NativeFieldInfoPtr_currentlyTalking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "currentlyTalking");
			NativeFieldInfoPtr_currentlyTalkingTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "currentlyTalkingTo");
			NativeFieldInfoPtr_speechTriggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "speechTriggered");
			NativeFieldInfoPtr_currentMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "currentMessage");
			NativeFieldInfoPtr_currentLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "currentLink");
			NativeFieldInfoPtr_linkDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "linkDelay");
			NativeFieldInfoPtr_timeUntilNextSpeech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "timeUntilNextSpeech");
			NativeFieldInfoPtr_currentlyTalkingSpeechQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "currentlyTalkingSpeechQueue");
			NativeFieldInfoPtr_treeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, "treeName");
			NativeMethodInfoPtr_EndConversation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, 100664263);
			NativeMethodInfoPtr_SetCurrentMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, 100664264);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr, 100664265);
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 22776, RefRangeEnd = 22786, XrefRangeStart = 22691, XrefRangeEnd = 22776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndConversation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndConversation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22838, RefRangeEnd = 22839, XrefRangeStart = 22786, XrefRangeEnd = 22838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentMessage(string instanceID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(instanceID);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCurrentMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConversationInstance()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationInstance>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ConversationInstance(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class InteractionDialogInstance : Il2CppSystem.Object
	{
		public enum EventsTestResult
		{
			fail,
			success,
			wait
		}

		[System.Serializable]
		public class Branch : Il2CppSystem.Object
		{
			[ObfuscatedName("Human+InteractionDialogInstance+Branch+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				private static readonly System.IntPtr NativeFieldInfoPtr_msg;

				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				private static readonly System.IntPtr NativeMethodInfoPtr__NewInteractionInstanceMessage_b__1_Internal_Boolean_QueueElement_0;

				public unsafe DDSSaveClasses.DDSMessageSave msg
				{
					get
					{
						nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_msg);
						System.IntPtr intPtr = *(System.IntPtr*)num;
						return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSSaveClasses.DDSMessageSave>(intPtr) : null;
					}
					set
					{
						System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_msg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSMessageSave));
					}
				}

				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Branch>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr);
					NativeFieldInfoPtr_msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, "msg");
					NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100664276);
					NativeMethodInfoPtr__NewInteractionInstanceMessage_b__1_Internal_Boolean_QueueElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100664277);
				}

				[CallerCount(82)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr))
				{
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22839, XrefRangeEnd = 22840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _NewInteractionInstanceMessage_b__1(SpeechController.QueueElement item)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = stackalloc System.IntPtr[1];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__NewInteractionInstanceMessage_b__1_Internal_Boolean_QueueElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
				}

				public __c__DisplayClass6_0(System.IntPtr pointer)
					: base(pointer)
				{
				}
			}

			[System.Serializable]
			[ObfuscatedName("Human+InteractionDialogInstance+Branch+<>c")]
			public sealed class __c : Il2CppSystem.Object
			{
				private static readonly System.IntPtr NativeFieldInfoPtr___9;

				private static readonly System.IntPtr NativeFieldInfoPtr___9__6_0;

				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				private static readonly System.IntPtr NativeMethodInfoPtr__NewInteractionInstanceMessage_b__6_0_Internal_Boolean_DDSInteractionEvent_0;

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

				public unsafe static Il2CppSystem.Predicate<DDSSaveClasses.DDSInteractionEvent> __9__6_0
				{
					get
					{
						Unsafe.SkipInit(out System.IntPtr intPtr);
						IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<DDSSaveClasses.DDSInteractionEvent>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__6_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
					}
				}

				static __c()
				{
					Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Branch>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
					NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
					NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__6_0");
					NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664279);
					NativeMethodInfoPtr__NewInteractionInstanceMessage_b__6_0_Internal_Boolean_DDSInteractionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664280);
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
				public unsafe bool _NewInteractionInstanceMessage_b__6_0(DDSSaveClasses.DDSInteractionEvent item)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = stackalloc System.IntPtr[1];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__NewInteractionInstanceMessage_b__6_0_Internal_Boolean_DDSInteractionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
				}

				public __c(System.IntPtr pointer)
					: base(pointer)
				{
				}
			}

			private static readonly System.IntPtr NativeFieldInfoPtr_msgInstanceID;

			private static readonly System.IntPtr NativeFieldInfoPtr_completedEventIndexes;

			private static readonly System.IntPtr NativeFieldInfoPtr_inst;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InteractionDialogInstance_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_GetMessageInstance_Public_DDSMessageSettings_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_GetMessage_Public_DDSMessageSave_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_NewInteractionInstanceMessage_Public_Void_String_Human_0;

			public unsafe string msgInstanceID
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_msgInstanceID);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_msgInstanceID)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe List<int> completedEventIndexes
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedEventIndexes);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_completedEventIndexes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
				}
			}

			public unsafe InteractionDialogInstance inst
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inst);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractionDialogInstance>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inst)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactionDialogInstance));
				}
			}

			static Branch()
			{
				Il2CppClassPointerStore<Branch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, "Branch");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Branch>.NativeClassPtr);
				NativeFieldInfoPtr_msgInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Branch>.NativeClassPtr, "msgInstanceID");
				NativeFieldInfoPtr_completedEventIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Branch>.NativeClassPtr, "completedEventIndexes");
				NativeFieldInfoPtr_inst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Branch>.NativeClassPtr, "inst");
				NativeMethodInfoPtr__ctor_Public_Void_InteractionDialogInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664272);
				NativeMethodInfoPtr_GetMessageInstance_Public_DDSMessageSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664273);
				NativeMethodInfoPtr_GetMessage_Public_DDSMessageSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664274);
				NativeMethodInfoPtr_NewInteractionInstanceMessage_Public_Void_String_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664275);
			}

			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 22845, RefRangeEnd = 22847, XrefRangeStart = 22840, XrefRangeEnd = 22845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Branch(InteractionDialogInstance dialogInstance)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Branch>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogInstance);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InteractionDialogInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 22851, RefRangeEnd = 22854, XrefRangeStart = 22847, XrefRangeEnd = 22851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DDSSaveClasses.DDSMessageSettings GetMessageInstance()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMessageInstance_Public_DDSMessageSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSSaveClasses.DDSMessageSettings>(intPtr) : null;
			}

			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 22860, RefRangeEnd = 22864, XrefRangeStart = 22854, XrefRangeEnd = 22860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DDSSaveClasses.DDSMessageSave GetMessage()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMessage_Public_DDSMessageSave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSSaveClasses.DDSMessageSave>(intPtr) : null;
			}

			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 22952, RefRangeEnd = 22955, XrefRangeStart = 22864, XrefRangeEnd = 22952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void NewInteractionInstanceMessage(string newMsgInstanceID, Human human)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[2];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newMsgInstanceID);
				*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewInteractionInstanceMessage_Public_Void_String_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public Branch(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_treeID;

		private static readonly System.IntPtr NativeFieldInfoPtr_pickedItem;

		private static readonly System.IntPtr NativeFieldInfoPtr_pickedWorldItemID;

		private static readonly System.IntPtr NativeFieldInfoPtr_mainBranch;

		private static readonly System.IntPtr NativeFieldInfoPtr_secondaryBranches;

		private static readonly System.IntPtr NativeFieldInfoPtr_newspaperFeatures;

		private static readonly System.IntPtr NativeFieldInfoPtr_tree;

		private static readonly System.IntPtr NativeFieldInfoPtr_generatedDialogOptions;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DDSTreeSave_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnLoad_Public_Void_Human_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTree_Public_DDSTreeSave_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_Interactable_0;

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

		public unsafe string treeID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treeID)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string pickedItem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickedItem);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickedItem)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int pickedWorldItemID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickedWorldItemID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pickedWorldItemID)) = num;
			}
		}

		public unsafe Branch mainBranch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainBranch);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Branch>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainBranch)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)branch));
			}
		}

		public unsafe List<Branch> secondaryBranches
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryBranches);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Branch>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondaryBranches)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<NewspaperController.InteractionDialogFeature> newspaperFeatures
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newspaperFeatures);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewspaperController.InteractionDialogFeature>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newspaperFeatures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe DDSSaveClasses.DDSTreeSave tree
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tree);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSSaveClasses.DDSTreeSave>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSTreeSave));
			}
		}

		public unsafe List<EvidenceWitness.DialogOption> generatedDialogOptions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generatedDialogOptions);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EvidenceWitness.DialogOption>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generatedDialogOptions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static InteractionDialogInstance()
		{
			Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "InteractionDialogInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, "id");
			NativeFieldInfoPtr_treeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, "treeID");
			NativeFieldInfoPtr_pickedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, "pickedItem");
			NativeFieldInfoPtr_pickedWorldItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, "pickedWorldItemID");
			NativeFieldInfoPtr_mainBranch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, "mainBranch");
			NativeFieldInfoPtr_secondaryBranches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, "secondaryBranches");
			NativeFieldInfoPtr_newspaperFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, "newspaperFeatures");
			NativeFieldInfoPtr_tree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, "tree");
			NativeFieldInfoPtr_generatedDialogOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, "generatedDialogOptions");
			NativeMethodInfoPtr__ctor_Public_Void_DDSTreeSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, 100664268);
			NativeMethodInfoPtr_OnLoad_Public_Void_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, 100664269);
			NativeMethodInfoPtr_GetTree_Public_DDSTreeSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, 100664270);
			NativeMethodInfoPtr_GetItem_Public_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr, 100664271);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22980, RefRangeEnd = 22981, XrefRangeStart = 22955, XrefRangeEnd = 22980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractionDialogInstance(DDSSaveClasses.DDSTreeSave newTree)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionDialogInstance>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTree);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DDSTreeSave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22999, RefRangeEnd = 23000, XrefRangeStart = 22981, XrefRangeEnd = 22999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoad(Human human)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLoad_Public_Void_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 23005, RefRangeEnd = 23008, XrefRangeStart = 23000, XrefRangeEnd = 23005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DDSSaveClasses.DDSTreeSave GetTree()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTree_Public_DDSTreeSave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSSaveClasses.DDSTreeSave>(intPtr) : null;
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 23013, RefRangeEnd = 23015, XrefRangeStart = 23008, XrefRangeEnd = 23013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Interactable GetItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
		}

		public InteractionDialogInstance(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DDSRank : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_linkRef;

		private static readonly System.IntPtr NativeFieldInfoPtr_rankRef;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

		public unsafe DDSSaveClasses.DDSMessageLink linkRef
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkRef);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSSaveClasses.DDSMessageLink>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkRef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSMessageLink));
			}
		}

		public unsafe float rankRef
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rankRef);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rankRef)) = num;
			}
		}

		static DDSRank()
		{
			Il2CppClassPointerStore<DDSRank>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "DDSRank");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DDSRank>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSRank>.NativeClassPtr, "id");
			NativeFieldInfoPtr_linkRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSRank>.NativeClassPtr, "linkRef");
			NativeFieldInfoPtr_rankRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DDSRank>.NativeClassPtr, "rankRef");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DDSRank>.NativeClassPtr, 100664281);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DDSRank()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DDSRank>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DDSRank(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class SpeechHistory : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_timeStamp;

		private static readonly System.IntPtr NativeFieldInfoPtr_participants;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe float timeStamp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStamp);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStamp)) = num;
			}
		}

		public unsafe List<Human> participants
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participants);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Human>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participants)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static SpeechHistory()
		{
			Il2CppClassPointerStore<SpeechHistory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "SpeechHistory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeechHistory>.NativeClassPtr);
			NativeFieldInfoPtr_timeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechHistory>.NativeClassPtr, "timeStamp");
			NativeFieldInfoPtr_participants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechHistory>.NativeClassPtr, "participants");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechHistory>.NativeClassPtr, 100664282);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23015, XrefRangeEnd = 23021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpeechHistory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeechHistory>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SpeechHistory(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum DisposalType
	{
		anywhere,
		homeOnly,
		workOnly,
		homeOrWork
	}

	[System.Serializable]
	public class Wound : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_humanID;

		private static readonly System.IntPtr NativeFieldInfoPtr_interactable;

		private static readonly System.IntPtr NativeFieldInfoPtr_anchor;

		private static readonly System.IntPtr NativeFieldInfoPtr_timestamp;

		private static readonly System.IntPtr NativeFieldInfoPtr_bloodPoolID;

		private static readonly System.IntPtr NativeFieldInfoPtr_bloodPoolAmount;

		private static readonly System.IntPtr NativeFieldInfoPtr_human;

		private static readonly System.IntPtr NativeFieldInfoPtr_bloodPool;

		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessBloodPoolForWound_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int humanID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humanID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humanID)) = num;
			}
		}

		public unsafe Interactable interactable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
			}
		}

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

		public unsafe float timestamp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timestamp);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timestamp)) = num;
			}
		}

		public unsafe int bloodPoolID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodPoolID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodPoolID)) = num;
			}
		}

		public unsafe float bloodPoolAmount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodPoolAmount);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodPoolAmount)) = num;
			}
		}

		public unsafe Human human
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe Interactable bloodPool
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodPool);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
			}
		}

		static Wound()
		{
			Il2CppClassPointerStore<Wound>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "Wound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wound>.NativeClassPtr);
			NativeFieldInfoPtr_humanID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wound>.NativeClassPtr, "humanID");
			NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wound>.NativeClassPtr, "interactable");
			NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wound>.NativeClassPtr, "anchor");
			NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wound>.NativeClassPtr, "timestamp");
			NativeFieldInfoPtr_bloodPoolID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wound>.NativeClassPtr, "bloodPoolID");
			NativeFieldInfoPtr_bloodPoolAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wound>.NativeClassPtr, "bloodPoolAmount");
			NativeFieldInfoPtr_human = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wound>.NativeClassPtr, "human");
			NativeFieldInfoPtr_bloodPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wound>.NativeClassPtr, "bloodPool");
			NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wound>.NativeClassPtr, 100664283);
			NativeMethodInfoPtr_ProcessBloodPoolForWound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wound>.NativeClassPtr, 100664284);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wound>.NativeClassPtr, 100664285);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23033, RefRangeEnd = 23034, XrefRangeStart = 23021, XrefRangeEnd = 23033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23039, RefRangeEnd = 23040, XrefRangeStart = 23034, XrefRangeEnd = 23039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessBloodPoolForWound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessBloodPoolForWound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 23040, RefRangeEnd = 23044, XrefRangeStart = 23040, XrefRangeEnd = 23040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Wound()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Wound>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Wound(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class Death : Il2CppSystem.Object
	{
		public enum ReportType
		{
			visual,
			smell,
			audio
		}

		[System.Serializable]
		[ObfuscatedName("Human+Death+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__16_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__SetReported_b__16_0_Internal_Boolean_NewAIGoal_0;

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

			public unsafe static Il2CppSystem.Predicate<NewAIGoal> __9__16_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAIGoal>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__16_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Death>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__16_0");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664298);
				NativeMethodInfoPtr__SetReported_b__16_0_Internal_Boolean_NewAIGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664299);
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
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetReported_b__16_0(NewAIGoal item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetReported_b__16_0_Internal_Boolean_NewAIGoal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_isDead;

		private static readonly System.IntPtr NativeFieldInfoPtr_location;

		private static readonly System.IntPtr NativeFieldInfoPtr_time;

		private static readonly System.IntPtr NativeFieldInfoPtr_timeOfDeathRange;

		private static readonly System.IntPtr NativeFieldInfoPtr_weapon;

		private static readonly System.IntPtr NativeFieldInfoPtr_murder;

		private static readonly System.IntPtr NativeFieldInfoPtr_victim;

		private static readonly System.IntPtr NativeFieldInfoPtr_killer;

		private static readonly System.IntPtr NativeFieldInfoPtr_discoveredBy;

		private static readonly System.IntPtr NativeFieldInfoPtr_discoveredAt;

		private static readonly System.IntPtr NativeFieldInfoPtr_reported;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportType;

		private static readonly System.IntPtr NativeFieldInfoPtr_smell;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Human_Murder_Human_Interactable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDeathLocation_Public_Void_NewNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetReported_Public_Void_Human_ReportType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetVictim_Public_Human_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetKiller_Public_Human_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDiscoverer_Public_Human_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeOfDeathEvidence_Public_EvidenceTime_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDeathLocation_Public_NewGameLocation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMurder_Public_Murder_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetMurder_b__22_0_Private_Boolean_Murder_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetMurder_b__22_1_Private_Boolean_Murder_0;

		public unsafe bool isDead
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDead);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDead)) = flag;
			}
		}

		public unsafe Vector3 location
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location)) = vector;
			}
		}

		public unsafe float time
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time)) = num;
			}
		}

		public unsafe Vector2 timeOfDeathRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeOfDeathRange);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeOfDeathRange)) = vector;
			}
		}

		public unsafe int weapon
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weapon);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weapon)) = num;
			}
		}

		public unsafe int murder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murder);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murder)) = num;
			}
		}

		public unsafe int victim
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victim);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victim)) = num;
			}
		}

		public unsafe int killer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_killer);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_killer)) = num;
			}
		}

		public unsafe int discoveredBy
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoveredBy);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoveredBy)) = num;
			}
		}

		public unsafe float discoveredAt
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoveredAt);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discoveredAt)) = num;
			}
		}

		public unsafe bool reported
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reported);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reported)) = flag;
			}
		}

		public unsafe ReportType reportType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportType);
				return *(ReportType*)num;
			}
			set
			{
				*(ReportType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reportType)) = reportType;
			}
		}

		public unsafe float smell
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smell);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smell)) = num;
			}
		}

		static Death()
		{
			Il2CppClassPointerStore<Death>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "Death");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Death>.NativeClassPtr);
			NativeFieldInfoPtr_isDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Death>.NativeClassPtr, "isDead");
			NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Death>.NativeClassPtr, "location");
			NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Death>.NativeClassPtr, "time");
			NativeFieldInfoPtr_timeOfDeathRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Death>.NativeClassPtr, "timeOfDeathRange");
			NativeFieldInfoPtr_weapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Death>.NativeClassPtr, "weapon");
			NativeFieldInfoPtr_murder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Death>.NativeClassPtr, "murder");
			NativeFieldInfoPtr_victim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Death>.NativeClassPtr, "victim");
			NativeFieldInfoPtr_killer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Death>.NativeClassPtr, "killer");
			NativeFieldInfoPtr_discoveredBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Death>.NativeClassPtr, "discoveredBy");
			NativeFieldInfoPtr_discoveredAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Death>.NativeClassPtr, "discoveredAt");
			NativeFieldInfoPtr_reported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Death>.NativeClassPtr, "reported");
			NativeFieldInfoPtr_reportType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Death>.NativeClassPtr, "reportType");
			NativeFieldInfoPtr_smell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Death>.NativeClassPtr, "smell");
			NativeMethodInfoPtr__ctor_Public_Void_Human_Murder_Human_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Death>.NativeClassPtr, 100664286);
			NativeMethodInfoPtr_UpdateDeathLocation_Public_Void_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Death>.NativeClassPtr, 100664287);
			NativeMethodInfoPtr_SetReported_Public_Void_Human_ReportType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Death>.NativeClassPtr, 100664288);
			NativeMethodInfoPtr_GetVictim_Public_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Death>.NativeClassPtr, 100664289);
			NativeMethodInfoPtr_GetKiller_Public_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Death>.NativeClassPtr, 100664290);
			NativeMethodInfoPtr_GetDiscoverer_Public_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Death>.NativeClassPtr, 100664291);
			NativeMethodInfoPtr_GetTimeOfDeathEvidence_Public_EvidenceTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Death>.NativeClassPtr, 100664292);
			NativeMethodInfoPtr_GetDeathLocation_Public_NewGameLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Death>.NativeClassPtr, 100664293);
			NativeMethodInfoPtr_GetMurder_Public_Murder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Death>.NativeClassPtr, 100664294);
			NativeMethodInfoPtr__GetMurder_b__22_0_Private_Boolean_Murder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Death>.NativeClassPtr, 100664295);
			NativeMethodInfoPtr__GetMurder_b__22_1_Private_Boolean_Murder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Death>.NativeClassPtr, 100664296);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23073, RefRangeEnd = 23074, XrefRangeStart = 23044, XrefRangeEnd = 23073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Death(Human newVictim, MurderController.Murder newMurder, Human newKiller, Interactable newWeapon)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Death>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newVictim);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newMurder);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newKiller);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newWeapon);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Human_Murder_Human_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void UpdateDeathLocation(NewNode newNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDeathLocation_Public_Void_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 23155, RefRangeEnd = 23157, XrefRangeStart = 23074, XrefRangeEnd = 23155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReported(Human newFoundBy, ReportType newReportType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newFoundBy);
			*(ReportType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newReportType;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReported_Public_Void_Human_ReportType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 23160, RefRangeEnd = 23162, XrefRangeStart = 23157, XrefRangeEnd = 23160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Human GetVictim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVictim_Public_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 23165, RefRangeEnd = 23168, XrefRangeStart = 23162, XrefRangeEnd = 23165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Human GetKiller()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKiller_Public_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23171, RefRangeEnd = 23172, XrefRangeStart = 23168, XrefRangeEnd = 23171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Human GetDiscoverer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDiscoverer_Public_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 23181, RefRangeEnd = 23183, XrefRangeStart = 23172, XrefRangeEnd = 23181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EvidenceTime GetTimeOfDeathEvidence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimeOfDeathEvidence_Public_EvidenceTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EvidenceTime>(intPtr) : null;
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 23192, RefRangeEnd = 23195, XrefRangeStart = 23183, XrefRangeEnd = 23192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewGameLocation GetDeathLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeathLocation_Public_NewGameLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewGameLocation>(intPtr) : null;
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 23215, RefRangeEnd = 23218, XrefRangeStart = 23195, XrefRangeEnd = 23215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MurderController.Murder GetMurder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMurder_Public_Murder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MurderController.Murder>(intPtr) : null;
		}

		[CallerCount(0)]
		public unsafe bool _GetMurder_b__22_0(MurderController.Murder item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetMurder_b__22_0_Private_Boolean_Murder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _GetMurder_b__22_1(MurderController.Murder item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetMurder_b__22_1_Private_Boolean_Murder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public Death(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class WalletItem : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_itemType;

		private static readonly System.IntPtr NativeFieldInfoPtr_meta;

		private static readonly System.IntPtr NativeFieldInfoPtr_money;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe WalletItemType itemType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemType);
				return *(WalletItemType*)num;
			}
			set
			{
				*(WalletItemType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemType)) = walletItemType;
			}
		}

		public unsafe int meta
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meta);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meta)) = num;
			}
		}

		public unsafe int money
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_money);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_money)) = num;
			}
		}

		static WalletItem()
		{
			Il2CppClassPointerStore<WalletItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "WalletItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WalletItem>.NativeClassPtr);
			NativeFieldInfoPtr_itemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WalletItem>.NativeClassPtr, "itemType");
			NativeFieldInfoPtr_meta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WalletItem>.NativeClassPtr, "meta");
			NativeFieldInfoPtr_money = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WalletItem>.NativeClassPtr, "money");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WalletItem>.NativeClassPtr, 100664300);
		}

		[CallerCount(0)]
		public unsafe WalletItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WalletItem>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public WalletItem(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum WalletItemType
	{
		nothing,
		money,
		evidence,
		key
	}

	public sealed class BookChoice : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_p;

		private static readonly System.IntPtr NativeFieldInfoPtr_rank;

		public unsafe BookPreset p
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BookPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bookPreset));
			}
		}

		public unsafe float rank
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rank);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rank)) = num;
			}
		}

		static BookChoice()
		{
			Il2CppClassPointerStore<BookChoice>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "BookChoice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BookChoice>.NativeClassPtr);
			NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookChoice>.NativeClassPtr, "p");
			NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BookChoice>.NativeClassPtr, "rank");
		}

		public BookChoice(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public BookChoice()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BookChoice>.NativeClassPtr))
		{
		}
	}

	public enum NoteObject
	{
		note,
		letter,
		travelReceipt,
		vmailLetter
	}

	[System.Serializable]
	[ObfuscatedName("Human+<>c")]
	public new sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__159_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__159_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__164_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__164_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__184_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__184_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__184_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__184_3;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__190_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__190_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__190_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__190_3;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__192_4;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__193_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__193_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__193_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__204_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__204_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__211_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__211_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__211_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__242_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__244_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__246_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__254_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__259_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__259_3;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__259_4;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__259_5;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__259_7;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__259_9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__266_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__271_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__272_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__272_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__281_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__281_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__281_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__281_3;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__281_4;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__281_5;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetJob_b__159_1_Internal_Boolean_NewAIGoal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetJob_b__159_0_Internal_Boolean_NewAIGoal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetPersonality_b__164_0_Internal_Int32_BookChoice_BookChoice_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetPersonality_b__164_2_Internal_Boolean_DDSBlockCondition_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PickPassword_b__184_0_Internal_Boolean_Trait_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PickPassword_b__184_1_Internal_Boolean_Trait_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PickPassword_b__184_2_Internal_Boolean_Trait_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PickPassword_b__184_3_Internal_Boolean_Trait_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TestInteractionInstances_b__190_0_Internal_Boolean_DDSMessageLink_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TestInteractionInstances_b__190_1_Internal_Boolean_DDSMessageLink_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TestInteractionInstances_b__190_2_Internal_Boolean_DDSMessageLink_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TestInteractionInstances_b__190_3_Internal_Boolean_DDSMessageLink_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__192_4_Internal_Boolean_Interactable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetupInteractables_b__193_0_Internal_Boolean_InteractableController_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetupInteractables_b__193_1_Internal_Boolean_InteractableController_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetupInteractables_b__193_2_Internal_Boolean_InteractableController_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CreateAcquaintances_b__204_1_Internal_Boolean_Occupation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CreateAcquaintances_b__204_0_Internal_Boolean_Acquaintance_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WakeUp_b__211_0_Internal_Boolean_NewAIGoal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WakeUp_b__211_1_Internal_Boolean_NewAIGoal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WakeUp_b__211_2_Internal_Boolean_NewAIAction_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__FindSafeTeleport_b__242_0_Internal_Boolean_NodeAccess_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__FindSafeTeleport_b__244_0_Internal_Boolean_NewWall_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SpawnInventoryItems_b__246_1_Internal_Boolean_DebugCitizenWeapons_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SpeechTriggerPoint_b__254_1_Internal_Int32_DDSTreeSave_DDSTreeSave_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ParseDDSMessage_b__259_2_Internal_Boolean_Trait_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ParseDDSMessage_b__259_3_Internal_Boolean_Trait_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ParseDDSMessage_b__259_4_Internal_Boolean_Trait_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ParseDDSMessage_b__259_5_Internal_Boolean_Passed_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ParseDDSMessage_b__259_7_Internal_Boolean_Passed_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ParseDDSMessage_b__259_9_Internal_Int32_DDSRank_DDSRank_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetConversationTreeLinkRankings_b__266_0_Internal_Int32_DDSRank_DDSRank_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetDoctor_b__271_1_Internal_Int32_Occupation_Occupation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetLandlord_b__272_0_Internal_Boolean_Occupation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetLandlord_b__272_1_Internal_Int32_Occupation_Occupation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WalletItemCheck_b__281_0_Internal_Boolean_Trait_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WalletItemCheck_b__281_1_Internal_Boolean_WalletItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WalletItemCheck_b__281_2_Internal_Boolean_Trait_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WalletItemCheck_b__281_3_Internal_Boolean_WalletItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WalletItemCheck_b__281_4_Internal_Boolean_WalletItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WalletItemCheck_b__281_5_Internal_Boolean_WalletItem_0;

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

		public unsafe static Il2CppSystem.Predicate<NewAIGoal> __9__159_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__159_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAIGoal>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__159_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewAIGoal> __9__159_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__159_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAIGoal>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__159_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Comparison<BookChoice> __9__164_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__164_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<BookChoice>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__164_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<DDSSaveClasses.DDSBlockCondition> __9__164_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__164_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<DDSSaveClasses.DDSBlockCondition>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__164_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Trait> __9__184_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__184_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Trait>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__184_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Trait> __9__184_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__184_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Trait>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__184_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Trait> __9__184_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__184_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Trait>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__184_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Trait> __9__184_3
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__184_3, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Trait>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__184_3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<DDSSaveClasses.DDSMessageLink> __9__190_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__190_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<DDSSaveClasses.DDSMessageLink>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__190_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<DDSSaveClasses.DDSMessageLink> __9__190_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__190_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<DDSSaveClasses.DDSMessageLink>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__190_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<DDSSaveClasses.DDSMessageLink> __9__190_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__190_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<DDSSaveClasses.DDSMessageLink>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__190_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<DDSSaveClasses.DDSMessageLink> __9__190_3
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__190_3, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<DDSSaveClasses.DDSMessageLink>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__190_3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Interactable> __9__192_4
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__192_4, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__192_4, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<InteractableController> __9__193_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__193_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<InteractableController>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__193_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<InteractableController> __9__193_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__193_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<InteractableController>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__193_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<InteractableController> __9__193_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__193_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<InteractableController>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__193_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Occupation> __9__204_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__204_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Occupation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__204_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Acquaintance> __9__204_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__204_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Acquaintance>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__204_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewAIGoal> __9__211_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__211_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAIGoal>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__211_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewAIGoal> __9__211_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__211_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAIGoal>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__211_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewAIAction> __9__211_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__211_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAIAction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__211_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewNode.NodeAccess> __9__242_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__242_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewNode.NodeAccess>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__242_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<NewWall> __9__244_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__244_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewWall>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__244_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Game.DebugCitizenWeapons> __9__246_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__246_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Game.DebugCitizenWeapons>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__246_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Comparison<DDSSaveClasses.DDSTreeSave> __9__254_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__254_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<DDSSaveClasses.DDSTreeSave>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__254_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Trait> __9__259_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__259_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Trait>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__259_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Trait> __9__259_3
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__259_3, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Trait>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__259_3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Trait> __9__259_4
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__259_4, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Trait>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__259_4, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Interactable.Passed> __9__259_5
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__259_5, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable.Passed>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__259_5, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Interactable.Passed> __9__259_7
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__259_7, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable.Passed>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__259_7, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Comparison<DDSRank> __9__259_9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__259_9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<DDSRank>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__259_9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<DDSRank> __9__266_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__266_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<DDSRank>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__266_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<Occupation> __9__271_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__271_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Occupation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__271_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Occupation> __9__272_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__272_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Occupation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__272_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Comparison<Occupation> __9__272_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__272_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<Occupation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__272_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Trait> __9__281_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__281_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Trait>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__281_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<WalletItem> __9__281_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__281_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<WalletItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__281_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Trait> __9__281_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__281_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Trait>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__281_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<WalletItem> __9__281_3
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__281_3, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<WalletItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__281_3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<WalletItem> __9__281_4
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__281_4, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<WalletItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__281_4, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<WalletItem> __9__281_5
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__281_5, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<WalletItem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__281_5, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__159_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__159_1");
			NativeFieldInfoPtr___9__159_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__159_0");
			NativeFieldInfoPtr___9__164_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__164_0");
			NativeFieldInfoPtr___9__164_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__164_2");
			NativeFieldInfoPtr___9__184_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__184_0");
			NativeFieldInfoPtr___9__184_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__184_1");
			NativeFieldInfoPtr___9__184_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__184_2");
			NativeFieldInfoPtr___9__184_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__184_3");
			NativeFieldInfoPtr___9__190_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__190_0");
			NativeFieldInfoPtr___9__190_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__190_1");
			NativeFieldInfoPtr___9__190_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__190_2");
			NativeFieldInfoPtr___9__190_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__190_3");
			NativeFieldInfoPtr___9__192_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__192_4");
			NativeFieldInfoPtr___9__193_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__193_0");
			NativeFieldInfoPtr___9__193_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__193_1");
			NativeFieldInfoPtr___9__193_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__193_2");
			NativeFieldInfoPtr___9__204_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__204_1");
			NativeFieldInfoPtr___9__204_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__204_0");
			NativeFieldInfoPtr___9__211_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__211_0");
			NativeFieldInfoPtr___9__211_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__211_1");
			NativeFieldInfoPtr___9__211_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__211_2");
			NativeFieldInfoPtr___9__242_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__242_0");
			NativeFieldInfoPtr___9__244_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__244_0");
			NativeFieldInfoPtr___9__246_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__246_1");
			NativeFieldInfoPtr___9__254_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__254_1");
			NativeFieldInfoPtr___9__259_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__259_2");
			NativeFieldInfoPtr___9__259_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__259_3");
			NativeFieldInfoPtr___9__259_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__259_4");
			NativeFieldInfoPtr___9__259_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__259_5");
			NativeFieldInfoPtr___9__259_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__259_7");
			NativeFieldInfoPtr___9__259_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__259_9");
			NativeFieldInfoPtr___9__266_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__266_0");
			NativeFieldInfoPtr___9__271_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__271_1");
			NativeFieldInfoPtr___9__272_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__272_0");
			NativeFieldInfoPtr___9__272_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__272_1");
			NativeFieldInfoPtr___9__281_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__281_0");
			NativeFieldInfoPtr___9__281_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__281_1");
			NativeFieldInfoPtr___9__281_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__281_2");
			NativeFieldInfoPtr___9__281_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__281_3");
			NativeFieldInfoPtr___9__281_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__281_4");
			NativeFieldInfoPtr___9__281_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__281_5");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664302);
			NativeMethodInfoPtr__SetJob_b__159_1_Internal_Boolean_NewAIGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664303);
			NativeMethodInfoPtr__SetJob_b__159_0_Internal_Boolean_NewAIGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664304);
			NativeMethodInfoPtr__SetPersonality_b__164_0_Internal_Int32_BookChoice_BookChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664305);
			NativeMethodInfoPtr__SetPersonality_b__164_2_Internal_Boolean_DDSBlockCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664306);
			NativeMethodInfoPtr__PickPassword_b__184_0_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664307);
			NativeMethodInfoPtr__PickPassword_b__184_1_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664308);
			NativeMethodInfoPtr__PickPassword_b__184_2_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664309);
			NativeMethodInfoPtr__PickPassword_b__184_3_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664310);
			NativeMethodInfoPtr__TestInteractionInstances_b__190_0_Internal_Boolean_DDSMessageLink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664311);
			NativeMethodInfoPtr__TestInteractionInstances_b__190_1_Internal_Boolean_DDSMessageLink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664312);
			NativeMethodInfoPtr__TestInteractionInstances_b__190_2_Internal_Boolean_DDSMessageLink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664313);
			NativeMethodInfoPtr__TestInteractionInstances_b__190_3_Internal_Boolean_DDSMessageLink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664314);
			NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__192_4_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664315);
			NativeMethodInfoPtr__SetupInteractables_b__193_0_Internal_Boolean_InteractableController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664316);
			NativeMethodInfoPtr__SetupInteractables_b__193_1_Internal_Boolean_InteractableController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664317);
			NativeMethodInfoPtr__SetupInteractables_b__193_2_Internal_Boolean_InteractableController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664318);
			NativeMethodInfoPtr__CreateAcquaintances_b__204_1_Internal_Boolean_Occupation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664319);
			NativeMethodInfoPtr__CreateAcquaintances_b__204_0_Internal_Boolean_Acquaintance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664320);
			NativeMethodInfoPtr__WakeUp_b__211_0_Internal_Boolean_NewAIGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664321);
			NativeMethodInfoPtr__WakeUp_b__211_1_Internal_Boolean_NewAIGoal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664322);
			NativeMethodInfoPtr__WakeUp_b__211_2_Internal_Boolean_NewAIAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664323);
			NativeMethodInfoPtr__FindSafeTeleport_b__242_0_Internal_Boolean_NodeAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664324);
			NativeMethodInfoPtr__FindSafeTeleport_b__244_0_Internal_Boolean_NewWall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664325);
			NativeMethodInfoPtr__SpawnInventoryItems_b__246_1_Internal_Boolean_DebugCitizenWeapons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664326);
			NativeMethodInfoPtr__SpeechTriggerPoint_b__254_1_Internal_Int32_DDSTreeSave_DDSTreeSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664327);
			NativeMethodInfoPtr__ParseDDSMessage_b__259_2_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664328);
			NativeMethodInfoPtr__ParseDDSMessage_b__259_3_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664329);
			NativeMethodInfoPtr__ParseDDSMessage_b__259_4_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664330);
			NativeMethodInfoPtr__ParseDDSMessage_b__259_5_Internal_Boolean_Passed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664331);
			NativeMethodInfoPtr__ParseDDSMessage_b__259_7_Internal_Boolean_Passed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664332);
			NativeMethodInfoPtr__ParseDDSMessage_b__259_9_Internal_Int32_DDSRank_DDSRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664333);
			NativeMethodInfoPtr__GetConversationTreeLinkRankings_b__266_0_Internal_Int32_DDSRank_DDSRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664334);
			NativeMethodInfoPtr__GetDoctor_b__271_1_Internal_Int32_Occupation_Occupation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664335);
			NativeMethodInfoPtr__GetLandlord_b__272_0_Internal_Boolean_Occupation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664336);
			NativeMethodInfoPtr__GetLandlord_b__272_1_Internal_Int32_Occupation_Occupation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664337);
			NativeMethodInfoPtr__WalletItemCheck_b__281_0_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664338);
			NativeMethodInfoPtr__WalletItemCheck_b__281_1_Internal_Boolean_WalletItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664339);
			NativeMethodInfoPtr__WalletItemCheck_b__281_2_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664340);
			NativeMethodInfoPtr__WalletItemCheck_b__281_3_Internal_Boolean_WalletItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664341);
			NativeMethodInfoPtr__WalletItemCheck_b__281_4_Internal_Boolean_WalletItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664342);
			NativeMethodInfoPtr__WalletItemCheck_b__281_5_Internal_Boolean_WalletItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664343);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23218, XrefRangeEnd = 23220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SetJob_b__159_1(NewAIGoal item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetJob_b__159_1_Internal_Boolean_NewAIGoal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SetJob_b__159_0(NewAIGoal item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetJob_b__159_0_Internal_Boolean_NewAIGoal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _SetPersonality_b__164_0(BookChoice p1, BookChoice p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)p1));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)p2));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetPersonality_b__164_0_Internal_Int32_BookChoice_BookChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _SetPersonality_b__164_2(DDSSaveClasses.DDSBlockCondition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetPersonality_b__164_2_Internal_Boolean_DDSBlockCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23220, XrefRangeEnd = 23224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PickPassword_b__184_0(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PickPassword_b__184_0_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23224, XrefRangeEnd = 23228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PickPassword_b__184_1(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PickPassword_b__184_1_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23228, XrefRangeEnd = 23232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PickPassword_b__184_2(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PickPassword_b__184_2_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23232, XrefRangeEnd = 23236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PickPassword_b__184_3(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PickPassword_b__184_3_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _TestInteractionInstances_b__190_0(DDSSaveClasses.DDSMessageLink item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TestInteractionInstances_b__190_0_Internal_Boolean_DDSMessageLink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _TestInteractionInstances_b__190_1(DDSSaveClasses.DDSMessageLink item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TestInteractionInstances_b__190_1_Internal_Boolean_DDSMessageLink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _TestInteractionInstances_b__190_2(DDSSaveClasses.DDSMessageLink item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TestInteractionInstances_b__190_2_Internal_Boolean_DDSMessageLink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _TestInteractionInstances_b__190_3(DDSSaveClasses.DDSMessageLink item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TestInteractionInstances_b__190_3_Internal_Boolean_DDSMessageLink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _ExecuteAndTestCurrentInteractionEvent_b__192_4(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__192_4_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _SetupInteractables_b__193_0(InteractableController item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetupInteractables_b__193_0_Internal_Boolean_InteractableController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _SetupInteractables_b__193_1(InteractableController item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetupInteractables_b__193_1_Internal_Boolean_InteractableController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _SetupInteractables_b__193_2(InteractableController item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetupInteractables_b__193_2_Internal_Boolean_InteractableController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23236, XrefRangeEnd = 23237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CreateAcquaintances_b__204_1(Occupation item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CreateAcquaintances_b__204_1_Internal_Boolean_Occupation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23237, XrefRangeEnd = 23239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CreateAcquaintances_b__204_0(Acquaintance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CreateAcquaintances_b__204_0_Internal_Boolean_Acquaintance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23239, XrefRangeEnd = 23241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WakeUp_b__211_0(NewAIGoal item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WakeUp_b__211_0_Internal_Boolean_NewAIGoal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23241, XrefRangeEnd = 23243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WakeUp_b__211_1(NewAIGoal item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WakeUp_b__211_1_Internal_Boolean_NewAIGoal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23243, XrefRangeEnd = 23245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WakeUp_b__211_2(NewAIAction item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WakeUp_b__211_2_Internal_Boolean_NewAIAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _FindSafeTeleport_b__242_0(NewNode.NodeAccess item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FindSafeTeleport_b__242_0_Internal_Boolean_NodeAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23245, XrefRangeEnd = 23256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _FindSafeTeleport_b__244_0(NewWall item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__FindSafeTeleport_b__244_0_Internal_Boolean_NewWall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _SpawnInventoryItems_b__246_1(Game.DebugCitizenWeapons item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SpawnInventoryItems_b__246_1_Internal_Boolean_DebugCitizenWeapons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _SpeechTriggerPoint_b__254_1(DDSSaveClasses.DDSTreeSave p1, DDSSaveClasses.DDSTreeSave p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SpeechTriggerPoint_b__254_1_Internal_Int32_DDSTreeSave_DDSTreeSave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23256, XrefRangeEnd = 23262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ParseDDSMessage_b__259_2(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseDDSMessage_b__259_2_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23262, XrefRangeEnd = 23265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ParseDDSMessage_b__259_3(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseDDSMessage_b__259_3_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23265, XrefRangeEnd = 23268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ParseDDSMessage_b__259_4(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseDDSMessage_b__259_4_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _ParseDDSMessage_b__259_5(Interactable.Passed item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseDDSMessage_b__259_5_Internal_Boolean_Passed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _ParseDDSMessage_b__259_7(Interactable.Passed item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseDDSMessage_b__259_7_Internal_Boolean_Passed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _ParseDDSMessage_b__259_9(DDSRank p1, DDSRank p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseDDSMessage_b__259_9_Internal_Int32_DDSRank_DDSRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _GetConversationTreeLinkRankings_b__266_0(DDSRank p1, DDSRank p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetConversationTreeLinkRankings_b__266_0_Internal_Int32_DDSRank_DDSRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _GetDoctor_b__271_1(Occupation p1, Occupation p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetDoctor_b__271_1_Internal_Int32_Occupation_Occupation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23268, XrefRangeEnd = 23283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetLandlord_b__272_0(Occupation item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetLandlord_b__272_0_Internal_Boolean_Occupation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _GetLandlord_b__272_1(Occupation p1, Occupation p2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetLandlord_b__272_1_Internal_Int32_Occupation_Occupation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23283, XrefRangeEnd = 23285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WalletItemCheck_b__281_0(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WalletItemCheck_b__281_0_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23285, XrefRangeEnd = 23295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WalletItemCheck_b__281_1(WalletItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WalletItemCheck_b__281_1_Internal_Boolean_WalletItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23295, XrefRangeEnd = 23297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WalletItemCheck_b__281_2(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WalletItemCheck_b__281_2_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23297, XrefRangeEnd = 23307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WalletItemCheck_b__281_3(WalletItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WalletItemCheck_b__281_3_Internal_Boolean_WalletItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _WalletItemCheck_b__281_4(WalletItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WalletItemCheck_b__281_4_Internal_Boolean_WalletItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _WalletItemCheck_b__281_5(WalletItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WalletItemCheck_b__281_5_Internal_Boolean_WalletItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass164_0")]
	public sealed class __c__DisplayClass164_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_trait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetPersonality_b__1_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait trait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass164_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass164_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass164_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass164_0>.NativeClassPtr);
			NativeFieldInfoPtr_trait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass164_0>.NativeClassPtr, "trait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass164_0>.NativeClassPtr, 100664344);
			NativeMethodInfoPtr__SetPersonality_b__1_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass164_0>.NativeClassPtr, 100664345);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass164_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass164_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _SetPersonality_b__1(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetPersonality_b__1_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass164_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass167_0")]
	public sealed class __c__DisplayClass167_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TraitExists_b__0_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass167_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass167_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass167_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass167_0>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass167_0>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass167_0>.NativeClassPtr, 100664346);
			NativeMethodInfoPtr__TraitExists_b__0_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass167_0>.NativeClassPtr, 100664347);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass167_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass167_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _TraitExists_b__0(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TraitExists_b__0_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass167_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass168_0")]
	public sealed class __c__DisplayClass168_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetChance_b__0_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass168_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass168_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass168_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass168_0>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass168_0>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass168_0>.NativeClassPtr, 100664348);
			NativeMethodInfoPtr__GetChance_b__0_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass168_0>.NativeClassPtr, 100664349);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass168_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass168_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetChance_b__0(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetChance_b__0_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass168_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass168_1")]
	public sealed class __c__DisplayClass168_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetChance_b__1_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass168_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass168_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass168_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass168_1>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass168_1>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass168_1>.NativeClassPtr, 100664350);
			NativeMethodInfoPtr__GetChance_b__1_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass168_1>.NativeClassPtr, 100664351);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass168_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass168_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetChance_b__1(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetChance_b__1_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass168_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass168_2")]
	public sealed class __c__DisplayClass168_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetChance_b__2_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass168_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass168_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass168_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass168_2>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass168_2>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass168_2>.NativeClassPtr, 100664352);
			NativeMethodInfoPtr__GetChance_b__2_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass168_2>.NativeClassPtr, 100664353);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass168_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass168_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetChance_b__2(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetChance_b__2_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass168_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass168_3")]
	public sealed class __c__DisplayClass168_3 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetChance_b__3_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass168_3()
		{
			Il2CppClassPointerStore<__c__DisplayClass168_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass168_3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass168_3>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass168_3>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass168_3>.NativeClassPtr, 100664354);
			NativeMethodInfoPtr__GetChance_b__3_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass168_3>.NativeClassPtr, 100664355);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass168_3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass168_3>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetChance_b__3(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetChance_b__3_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass168_3(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass169_0")]
	public new sealed class __c__DisplayClass169_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddCharacterTrait_b__0_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass169_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass169_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass169_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass169_0>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass169_0>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass169_0>.NativeClassPtr, 100664356);
			NativeMethodInfoPtr__AddCharacterTrait_b__0_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass169_0>.NativeClassPtr, 100664357);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass169_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass169_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _AddCharacterTrait_b__0(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddCharacterTrait_b__0_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass169_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass169_1")]
	public sealed class __c__DisplayClass169_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddCharacterTrait_b__1_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass169_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass169_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass169_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass169_1>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass169_1>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass169_1>.NativeClassPtr, 100664358);
			NativeMethodInfoPtr__AddCharacterTrait_b__1_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass169_1>.NativeClassPtr, 100664359);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass169_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass169_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _AddCharacterTrait_b__1(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddCharacterTrait_b__1_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass169_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass169_2")]
	public sealed class __c__DisplayClass169_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddCharacterTrait_b__2_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass169_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass169_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass169_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass169_2>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass169_2>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass169_2>.NativeClassPtr, 100664360);
			NativeMethodInfoPtr__AddCharacterTrait_b__2_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass169_2>.NativeClassPtr, 100664361);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass169_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass169_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _AddCharacterTrait_b__2(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddCharacterTrait_b__2_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass169_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass169_3")]
	public sealed class __c__DisplayClass169_3 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddCharacterTrait_b__3_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass169_3()
		{
			Il2CppClassPointerStore<__c__DisplayClass169_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass169_3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass169_3>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass169_3>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass169_3>.NativeClassPtr, 100664362);
			NativeMethodInfoPtr__AddCharacterTrait_b__3_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass169_3>.NativeClassPtr, 100664363);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass169_3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass169_3>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _AddCharacterTrait_b__3(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddCharacterTrait_b__3_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass169_3(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass188_0")]
	public sealed class __c__DisplayClass188_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_sp;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GeneratePastVmails_b__0_Internal_Boolean_MessageThreadSave_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GeneratePastVmails_b__1_Internal_Boolean_MessageThreadSave_0;

		public unsafe DDSSaveClasses.DDSTreeSave sp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sp);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSSaveClasses.DDSTreeSave>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSTreeSave));
			}
		}

		static __c__DisplayClass188_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass188_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass188_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass188_0>.NativeClassPtr);
			NativeFieldInfoPtr_sp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass188_0>.NativeClassPtr, "sp");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass188_0>.NativeClassPtr, 100664364);
			NativeMethodInfoPtr__GeneratePastVmails_b__0_Internal_Boolean_MessageThreadSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass188_0>.NativeClassPtr, 100664365);
			NativeMethodInfoPtr__GeneratePastVmails_b__1_Internal_Boolean_MessageThreadSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass188_0>.NativeClassPtr, 100664366);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass188_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass188_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23307, XrefRangeEnd = 23308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GeneratePastVmails_b__0(StateSaveData.MessageThreadSave item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GeneratePastVmails_b__0_Internal_Boolean_MessageThreadSave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GeneratePastVmails_b__1(StateSaveData.MessageThreadSave item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GeneratePastVmails_b__1_Internal_Boolean_MessageThreadSave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass188_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass192_0")]
	public sealed class __c__DisplayClass192_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_msg;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__0_Internal_Boolean_InteractionDialogFeature_0;

		public unsafe DDSSaveClasses.DDSMessageSave msg
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_msg);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSSaveClasses.DDSMessageSave>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_msg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSMessageSave));
			}
		}

		public unsafe Il2CppSystem.Predicate<NewspaperController.InteractionDialogFeature> __9__0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewspaperController.InteractionDialogFeature>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c__DisplayClass192_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass192_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass192_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass192_0>.NativeClassPtr);
			NativeFieldInfoPtr_msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass192_0>.NativeClassPtr, "msg");
			NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass192_0>.NativeClassPtr, "<>9__0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_0>.NativeClassPtr, 100664367);
			NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__0_Internal_Boolean_InteractionDialogFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_0>.NativeClassPtr, 100664368);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass192_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass192_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23308, XrefRangeEnd = 23309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ExecuteAndTestCurrentInteractionEvent_b__0(NewspaperController.InteractionDialogFeature item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__0_Internal_Boolean_InteractionDialogFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass192_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass192_1")]
	public sealed class __c__DisplayClass192_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_newItem;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__1_Internal_Boolean_Interactable_0;

		public unsafe InteractablePreset newItem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newItem);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
			}
		}

		static __c__DisplayClass192_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass192_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr);
			NativeFieldInfoPtr_newItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr, "newItem");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr, 100664369);
			NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__1_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr, 100664370);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass192_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass192_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23309, XrefRangeEnd = 23323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ExecuteAndTestCurrentInteractionEvent_b__1(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__1_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass192_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass192_2")]
	public sealed class __c__DisplayClass192_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_testingForItem;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__2_Internal_Boolean_Interactable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__3_Internal_Boolean_Interactable_0;

		public unsafe Interactable testingForItem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_testingForItem);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_testingForItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
			}
		}

		static __c__DisplayClass192_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass192_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass192_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass192_2>.NativeClassPtr);
			NativeFieldInfoPtr_testingForItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass192_2>.NativeClassPtr, "testingForItem");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_2>.NativeClassPtr, 100664371);
			NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__2_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_2>.NativeClassPtr, 100664372);
			NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__3_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_2>.NativeClassPtr, 100664373);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass192_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass192_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _ExecuteAndTestCurrentInteractionEvent_b__2(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__2_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23323, XrefRangeEnd = 23327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ExecuteAndTestCurrentInteractionEvent_b__3(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__3_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass192_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass192_3")]
	public sealed class __c__DisplayClass192_3 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_so;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__5_Internal_Boolean_Interactable_0;

		public unsafe FurniturePreset.SubObject so
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_so);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurniturePreset.SubObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_so)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)subObject));
			}
		}

		static __c__DisplayClass192_3()
		{
			Il2CppClassPointerStore<__c__DisplayClass192_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass192_3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass192_3>.NativeClassPtr);
			NativeFieldInfoPtr_so = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass192_3>.NativeClassPtr, "so");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_3>.NativeClassPtr, 100664374);
			NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__5_Internal_Boolean_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass192_3>.NativeClassPtr, 100664375);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass192_3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass192_3>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _ExecuteAndTestCurrentInteractionEvent_b__5(Interactable item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ExecuteAndTestCurrentInteractionEvent_b__5_Internal_Boolean_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass192_3(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass194_0")]
	public sealed class __c__DisplayClass194_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_Occupation_0;

		public unsafe CitySaveData.HumanCitySave data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CitySaveData.HumanCitySave>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)humanCitySave));
			}
		}

		static __c__DisplayClass194_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass194_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass194_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass194_0>.NativeClassPtr);
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass194_0>.NativeClassPtr, "data");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass194_0>.NativeClassPtr, 100664376);
			NativeMethodInfoPtr__Load_b__0_Internal_Boolean_Occupation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass194_0>.NativeClassPtr, 100664377);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass194_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass194_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _Load_b__0(Occupation item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Load_b__0_Internal_Boolean_Occupation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass194_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass194_1")]
	public sealed class __c__DisplayClass194_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_traitSave;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__1_Internal_Boolean_CharacterTrait_0;

		public unsafe CitySaveData.CharTraitSave traitSave
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitSave);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CitySaveData.CharTraitSave>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitSave)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charTraitSave));
			}
		}

		static __c__DisplayClass194_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass194_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass194_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass194_1>.NativeClassPtr);
			NativeFieldInfoPtr_traitSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass194_1>.NativeClassPtr, "traitSave");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass194_1>.NativeClassPtr, 100664378);
			NativeMethodInfoPtr__Load_b__1_Internal_Boolean_CharacterTrait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass194_1>.NativeClassPtr, 100664379);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass194_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass194_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23327, XrefRangeEnd = 23329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Load_b__1(CharacterTrait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Load_b__1_Internal_Boolean_CharacterTrait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass194_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass194_2")]
	public sealed class __c__DisplayClass194_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_traitSave;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__2_Internal_Boolean_Trait_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__3_Internal_Boolean_Trait_0;

		public unsafe CitySaveData.CharTraitSave traitSave
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitSave);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CitySaveData.CharTraitSave>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitSave)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charTraitSave));
			}
		}

		static __c__DisplayClass194_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass194_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass194_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass194_2>.NativeClassPtr);
			NativeFieldInfoPtr_traitSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass194_2>.NativeClassPtr, "traitSave");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass194_2>.NativeClassPtr, 100664380);
			NativeMethodInfoPtr__Load_b__2_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass194_2>.NativeClassPtr, 100664381);
			NativeMethodInfoPtr__Load_b__3_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass194_2>.NativeClassPtr, 100664382);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass194_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass194_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _Load_b__2(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Load_b__2_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _Load_b__3(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Load_b__3_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass194_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass196_0")]
	public sealed class __c__DisplayClass196_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		private static readonly System.IntPtr NativeFieldInfoPtr_i;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__LoadFavourites_b__0_Internal_Boolean_NewAddress_0;

		public unsafe CitySaveData.HumanCitySave data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CitySaveData.HumanCitySave>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)humanCitySave));
			}
		}

		public unsafe int i
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i)) = num;
			}
		}

		public unsafe Il2CppSystem.Predicate<NewAddress> __9__0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAddress>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c__DisplayClass196_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass196_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass196_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass196_0>.NativeClassPtr);
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass196_0>.NativeClassPtr, "data");
			NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass196_0>.NativeClassPtr, "i");
			NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass196_0>.NativeClassPtr, "<>9__0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass196_0>.NativeClassPtr, 100664383);
			NativeMethodInfoPtr__LoadFavourites_b__0_Internal_Boolean_NewAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass196_0>.NativeClassPtr, 100664384);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass196_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass196_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23329, XrefRangeEnd = 23330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _LoadFavourites_b__0(NewAddress item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LoadFavourites_b__0_Internal_Boolean_NewAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass196_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass198_0")]
	public sealed class __c__DisplayClass198_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TraitGoalTest_b__0_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass198_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass198_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass198_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass198_0>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass198_0>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass198_0>.NativeClassPtr, 100664385);
			NativeMethodInfoPtr__TraitGoalTest_b__0_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass198_0>.NativeClassPtr, 100664386);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass198_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass198_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _TraitGoalTest_b__0(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TraitGoalTest_b__0_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass198_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass198_1")]
	public sealed class __c__DisplayClass198_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TraitGoalTest_b__1_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass198_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass198_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass198_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass198_1>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass198_1>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass198_1>.NativeClassPtr, 100664387);
			NativeMethodInfoPtr__TraitGoalTest_b__1_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass198_1>.NativeClassPtr, 100664388);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass198_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass198_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _TraitGoalTest_b__1(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TraitGoalTest_b__1_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass198_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass198_2")]
	public sealed class __c__DisplayClass198_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TraitGoalTest_b__2_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass198_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass198_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass198_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass198_2>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass198_2>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass198_2>.NativeClassPtr, 100664389);
			NativeMethodInfoPtr__TraitGoalTest_b__2_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass198_2>.NativeClassPtr, 100664390);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass198_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass198_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _TraitGoalTest_b__2(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TraitGoalTest_b__2_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass198_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass198_3")]
	public sealed class __c__DisplayClass198_3 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TraitGoalTest_b__3_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass198_3()
		{
			Il2CppClassPointerStore<__c__DisplayClass198_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass198_3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass198_3>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass198_3>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass198_3>.NativeClassPtr, 100664391);
			NativeMethodInfoPtr__TraitGoalTest_b__3_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass198_3>.NativeClassPtr, 100664392);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass198_3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass198_3>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _TraitGoalTest_b__3(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TraitGoalTest_b__3_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass198_3(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass245_0")]
	public sealed class __c__DisplayClass245_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_blockedTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateItemFavs_b__0_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait blockedTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass245_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass245_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass245_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass245_0>.NativeClassPtr);
			NativeFieldInfoPtr_blockedTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass245_0>.NativeClassPtr, "blockedTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_0>.NativeClassPtr, 100664393);
			NativeMethodInfoPtr__GenerateItemFavs_b__0_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_0>.NativeClassPtr, 100664394);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass245_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass245_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GenerateItemFavs_b__0(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateItemFavs_b__0_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass245_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass245_1")]
	public sealed class __c__DisplayClass245_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_blockedTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateItemFavs_b__1_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait blockedTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass245_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass245_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass245_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass245_1>.NativeClassPtr);
			NativeFieldInfoPtr_blockedTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass245_1>.NativeClassPtr, "blockedTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_1>.NativeClassPtr, 100664395);
			NativeMethodInfoPtr__GenerateItemFavs_b__1_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_1>.NativeClassPtr, 100664396);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass245_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass245_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GenerateItemFavs_b__1(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateItemFavs_b__1_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass245_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass245_2")]
	public sealed class __c__DisplayClass245_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_blockedTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateItemFavs_b__2_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait blockedTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blockedTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass245_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass245_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr);
			NativeFieldInfoPtr_blockedTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr, "blockedTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr, 100664397);
			NativeMethodInfoPtr__GenerateItemFavs_b__2_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr, 100664398);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass245_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass245_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GenerateItemFavs_b__2(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateItemFavs_b__2_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass245_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass245_3")]
	public sealed class __c__DisplayClass245_3 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cat;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateItemFavs_b__3_Internal_Boolean_Company_0;

		public unsafe CompanyPreset.CompanyCategory cat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cat);
				return *(CompanyPreset.CompanyCategory*)num;
			}
			set
			{
				*(CompanyPreset.CompanyCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cat)) = companyCategory;
			}
		}

		static __c__DisplayClass245_3()
		{
			Il2CppClassPointerStore<__c__DisplayClass245_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass245_3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass245_3>.NativeClassPtr);
			NativeFieldInfoPtr_cat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass245_3>.NativeClassPtr, "cat");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_3>.NativeClassPtr, 100664399);
			NativeMethodInfoPtr__GenerateItemFavs_b__3_Internal_Boolean_Company_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass245_3>.NativeClassPtr, 100664400);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass245_3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass245_3>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23330, XrefRangeEnd = 23332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GenerateItemFavs_b__3(Company item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateItemFavs_b__3_Internal_Boolean_Company_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass245_3(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass246_0")]
	public sealed class __c__DisplayClass246_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_chosen;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SpawnInventoryItems_b__0_Internal_Boolean_DebugCitizenWeapons_0;

		public unsafe InteractablePreset chosen
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chosen);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chosen)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
			}
		}

		static __c__DisplayClass246_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass246_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass246_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass246_0>.NativeClassPtr);
			NativeFieldInfoPtr_chosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass246_0>.NativeClassPtr, "chosen");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass246_0>.NativeClassPtr, 100664401);
			NativeMethodInfoPtr__SpawnInventoryItems_b__0_Internal_Boolean_DebugCitizenWeapons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass246_0>.NativeClassPtr, 100664402);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass246_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass246_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _SpawnInventoryItems_b__0(Game.DebugCitizenWeapons item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SpawnInventoryItems_b__0_Internal_Boolean_DebugCitizenWeapons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass246_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass247_0")]
	public sealed class __c__DisplayClass247_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WeaponTraitTest_b__0_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass247_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass247_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass247_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass247_0>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass247_0>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass247_0>.NativeClassPtr, 100664403);
			NativeMethodInfoPtr__WeaponTraitTest_b__0_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass247_0>.NativeClassPtr, 100664404);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass247_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass247_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _WeaponTraitTest_b__0(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WeaponTraitTest_b__0_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass247_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass247_1")]
	public sealed class __c__DisplayClass247_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WeaponTraitTest_b__1_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass247_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass247_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass247_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass247_1>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass247_1>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass247_1>.NativeClassPtr, 100664405);
			NativeMethodInfoPtr__WeaponTraitTest_b__1_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass247_1>.NativeClassPtr, 100664406);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass247_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass247_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _WeaponTraitTest_b__1(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WeaponTraitTest_b__1_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass247_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass247_2")]
	public sealed class __c__DisplayClass247_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WeaponTraitTest_b__2_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass247_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass247_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass247_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass247_2>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass247_2>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass247_2>.NativeClassPtr, 100664407);
			NativeMethodInfoPtr__WeaponTraitTest_b__2_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass247_2>.NativeClassPtr, 100664408);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass247_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass247_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _WeaponTraitTest_b__2(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WeaponTraitTest_b__2_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass247_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass247_3")]
	public sealed class __c__DisplayClass247_3 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__WeaponTraitTest_b__3_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass247_3()
		{
			Il2CppClassPointerStore<__c__DisplayClass247_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass247_3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass247_3>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass247_3>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass247_3>.NativeClassPtr, 100664409);
			NativeMethodInfoPtr__WeaponTraitTest_b__3_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass247_3>.NativeClassPtr, 100664410);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass247_3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass247_3>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _WeaponTraitTest_b__3(Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__WeaponTraitTest_b__3_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass247_3(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass259_0")]
	public sealed class __c__DisplayClass259_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_conditions;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ParseDDSMessage_b__0_Internal_Boolean_ResolveQuestion_0;

		public unsafe DDSSaveClasses.DDSBlockCondition conditions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditions);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DDSSaveClasses.DDSBlockCondition>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dDSBlockCondition));
			}
		}

		static __c__DisplayClass259_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass259_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass259_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass259_0>.NativeClassPtr);
			NativeFieldInfoPtr_conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass259_0>.NativeClassPtr, "conditions");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass259_0>.NativeClassPtr, 100664411);
			NativeMethodInfoPtr__ParseDDSMessage_b__0_Internal_Boolean_ResolveQuestion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass259_0>.NativeClassPtr, 100664412);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass259_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass259_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23332, XrefRangeEnd = 23333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ParseDDSMessage_b__0(Case.ResolveQuestion item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseDDSMessage_b__0_Internal_Boolean_ResolveQuestion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass259_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass259_1")]
	public sealed class __c__DisplayClass259_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_displayGroupFromLeadPool;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ParseDDSMessage_b__1_Internal_Boolean_DDSBlockCondition_0;

		public unsafe int displayGroupFromLeadPool
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayGroupFromLeadPool);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayGroupFromLeadPool)) = num;
			}
		}

		static __c__DisplayClass259_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass259_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass259_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass259_1>.NativeClassPtr);
			NativeFieldInfoPtr_displayGroupFromLeadPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass259_1>.NativeClassPtr, "displayGroupFromLeadPool");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass259_1>.NativeClassPtr, 100664413);
			NativeMethodInfoPtr__ParseDDSMessage_b__1_Internal_Boolean_DDSBlockCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass259_1>.NativeClassPtr, 100664414);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass259_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass259_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _ParseDDSMessage_b__1(DDSSaveClasses.DDSBlockCondition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseDDSMessage_b__1_Internal_Boolean_DDSBlockCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass259_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass259_2")]
	public sealed class __c__DisplayClass259_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_passedLost;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ParseDDSMessage_b__6_Internal_Boolean_NewBuilding_0;

		public unsafe Interactable.Passed passedLost
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedLost);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable.Passed>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedLost)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passed));
			}
		}

		static __c__DisplayClass259_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass259_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass259_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass259_2>.NativeClassPtr);
			NativeFieldInfoPtr_passedLost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass259_2>.NativeClassPtr, "passedLost");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass259_2>.NativeClassPtr, 100664415);
			NativeMethodInfoPtr__ParseDDSMessage_b__6_Internal_Boolean_NewBuilding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass259_2>.NativeClassPtr, 100664416);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass259_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass259_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _ParseDDSMessage_b__6(NewBuilding item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseDDSMessage_b__6_Internal_Boolean_NewBuilding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass259_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass259_3")]
	public sealed class __c__DisplayClass259_3 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_passedLost;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ParseDDSMessage_b__8_Internal_Boolean_NewBuilding_0;

		public unsafe Interactable.Passed passedLost
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedLost);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable.Passed>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedLost)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passed));
			}
		}

		static __c__DisplayClass259_3()
		{
			Il2CppClassPointerStore<__c__DisplayClass259_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass259_3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass259_3>.NativeClassPtr);
			NativeFieldInfoPtr_passedLost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass259_3>.NativeClassPtr, "passedLost");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass259_3>.NativeClassPtr, 100664417);
			NativeMethodInfoPtr__ParseDDSMessage_b__8_Internal_Boolean_NewBuilding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass259_3>.NativeClassPtr, 100664418);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass259_3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass259_3>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _ParseDDSMessage_b__8(NewBuilding item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseDDSMessage_b__8_Internal_Boolean_NewBuilding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass259_3(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass282_0")]
	public sealed class __c__DisplayClass282_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_citizen;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__UpdateLastSighting_b__0_Internal_Boolean_Murder_0;

		public unsafe Human citizen
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizen);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizen)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		static __c__DisplayClass282_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass282_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass282_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass282_0>.NativeClassPtr);
			NativeFieldInfoPtr_citizen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass282_0>.NativeClassPtr, "citizen");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass282_0>.NativeClassPtr, 100664419);
			NativeMethodInfoPtr__UpdateLastSighting_b__0_Internal_Boolean_Murder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass282_0>.NativeClassPtr, 100664420);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass282_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass282_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23333, XrefRangeEnd = 23350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdateLastSighting_b__0(MurderController.Murder item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdateLastSighting_b__0_Internal_Boolean_Murder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass282_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass295_0")]
	public sealed class __c__DisplayClass295_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_givenItem;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TryGiveItem_b__1_Internal_Boolean_InventorySlot_0;

		public unsafe Interactable givenItem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_givenItem);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_givenItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
			}
		}

		static __c__DisplayClass295_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass295_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass295_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass295_0>.NativeClassPtr);
			NativeFieldInfoPtr_givenItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass295_0>.NativeClassPtr, "givenItem");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass295_0>.NativeClassPtr, 100664421);
			NativeMethodInfoPtr__TryGiveItem_b__1_Internal_Boolean_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass295_0>.NativeClassPtr, 100664422);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass295_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass295_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23350, XrefRangeEnd = 23351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _TryGiveItem_b__1(FirstPersonItemController.InventorySlot item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TryGiveItem_b__1_Internal_Boolean_InventorySlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass295_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Human+<>c__DisplayClass295_1")]
	public sealed class __c__DisplayClass295_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_lf;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__TryGiveItem_b__0_Internal_Boolean_Human_0;

		public unsafe GameplayController.LostAndFound lf
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lf);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameplayController.LostAndFound>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lf)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lostAndFound));
			}
		}

		static __c__DisplayClass295_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass295_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Human>.NativeClassPtr, "<>c__DisplayClass295_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass295_1>.NativeClassPtr);
			NativeFieldInfoPtr_lf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass295_1>.NativeClassPtr, "lf");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass295_1>.NativeClassPtr, 100664423);
			NativeMethodInfoPtr__TryGiveItem_b__0_Internal_Boolean_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass295_1>.NativeClassPtr, 100664424);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass295_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass295_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _TryGiveItem_b__0(Human item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__TryGiveItem_b__0_Internal_Boolean_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass295_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_humanID;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignID;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignTraitID;

	private static readonly System.IntPtr NativeFieldInfoPtr_seed;

	private static readonly System.IntPtr NativeFieldInfoPtr_footwear;

	private static readonly System.IntPtr NativeFieldInfoPtr_footstepEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_footstepDirt;

	private static readonly System.IntPtr NativeFieldInfoPtr_footstepBlood;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftFoot;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightFoot;

	private static readonly System.IntPtr NativeFieldInfoPtr_removedFromWorld;

	private static readonly System.IntPtr NativeFieldInfoPtr_home;

	private static readonly System.IntPtr NativeFieldInfoPtr_residence;

	private static readonly System.IntPtr NativeFieldInfoPtr_den;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaredOfRats;

	private static readonly System.IntPtr NativeFieldInfoPtr_likesRats;

	private static readonly System.IntPtr NativeFieldInfoPtr_dislikesRats;

	private static readonly System.IntPtr NativeFieldInfoPtr_hatesRats;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementWalkSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementRunSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_walkingSpeedRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentNormalizedSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredNormalizedSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentMovementSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_breathRecoveryRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentVehicle;

	private static readonly System.IntPtr NativeFieldInfoPtr_job;

	private static readonly System.IntPtr NativeFieldInfoPtr_director;

	private static readonly System.IntPtr NativeFieldInfoPtr_societalClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_descriptors;

	private static readonly System.IntPtr NativeFieldInfoPtr_outfitController;

	private static readonly System.IntPtr NativeFieldInfoPtr_handwriting;

	private static readonly System.IntPtr NativeFieldInfoPtr_birthday;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenName;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstName;

	private static readonly System.IntPtr NativeFieldInfoPtr_casualName;

	private static readonly System.IntPtr NativeFieldInfoPtr_surName;

	private static readonly System.IntPtr NativeFieldInfoPtr_genderScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_gender;

	private static readonly System.IntPtr NativeFieldInfoPtr_birthGender;

	private static readonly System.IntPtr NativeFieldInfoPtr_slangUsage;

	private static readonly System.IntPtr NativeFieldInfoPtr_sexuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_homosexuality;

	private static readonly System.IntPtr NativeFieldInfoPtr_attractedTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_partner;

	private static readonly System.IntPtr NativeFieldInfoPtr_anniversary;

	private static readonly System.IntPtr NativeFieldInfoPtr_paramour;

	private static readonly System.IntPtr NativeFieldInfoPtr_fingerprintLoop;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloodType;

	private static readonly System.IntPtr NativeFieldInfoPtr_favColourIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_humility;

	private static readonly System.IntPtr NativeFieldInfoPtr_emotionality;

	private static readonly System.IntPtr NativeFieldInfoPtr_extraversion;

	private static readonly System.IntPtr NativeFieldInfoPtr_agreeableness;

	private static readonly System.IntPtr NativeFieldInfoPtr_conscientiousness;

	private static readonly System.IntPtr NativeFieldInfoPtr_creativity;

	private static readonly System.IntPtr NativeFieldInfoPtr_sleepNeedMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_snoring;

	private static readonly System.IntPtr NativeFieldInfoPtr_snoreDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitHumility;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitEmotionality;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitExtraversion;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitAgreeableness;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitConscientiousness;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitCreativity;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_aggressiveTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_peacefulTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_fearfulTraits;

	private static readonly System.IntPtr NativeFieldInfoPtr_groups;

	private static readonly System.IntPtr NativeFieldInfoPtr_nourishment;

	private static readonly System.IntPtr NativeFieldInfoPtr_hydration;

	private static readonly System.IntPtr NativeFieldInfoPtr_alertness;

	private static readonly System.IntPtr NativeFieldInfoPtr_energy;

	private static readonly System.IntPtr NativeFieldInfoPtr_excitement;

	private static readonly System.IntPtr NativeFieldInfoPtr_chores;

	private static readonly System.IntPtr NativeFieldInfoPtr_hygiene;

	private static readonly System.IntPtr NativeFieldInfoPtr_bladder;

	private static readonly System.IntPtr NativeFieldInfoPtr_breath;

	private static readonly System.IntPtr NativeFieldInfoPtr_heat;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_sick;

	private static readonly System.IntPtr NativeFieldInfoPtr_headache;

	private static readonly System.IntPtr NativeFieldInfoPtr_wet;

	private static readonly System.IntPtr NativeFieldInfoPtr_brokenLeg;

	private static readonly System.IntPtr NativeFieldInfoPtr_bruised;

	private static readonly System.IntPtr NativeFieldInfoPtr_blackEye;

	private static readonly System.IntPtr NativeFieldInfoPtr_blackedOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_numb;

	private static readonly System.IntPtr NativeFieldInfoPtr_poisoned;

	private static readonly System.IntPtr NativeFieldInfoPtr_bleeding;

	private static readonly System.IntPtr NativeFieldInfoPtr_wellRested;

	private static readonly System.IntPtr NativeFieldInfoPtr_starchAddiction;

	private static readonly System.IntPtr NativeFieldInfoPtr_syncDiskInstall;

	private static readonly System.IntPtr NativeFieldInfoPtr_blinded;

	private static readonly System.IntPtr NativeFieldInfoPtr_poisoner;

	private static readonly System.IntPtr NativeFieldInfoPtr_CorpseCollisionCorrection;

	private static readonly System.IntPtr NativeFieldInfoPtr_acquaintances;

	private static readonly System.IntPtr NativeFieldInfoPtr_dds;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionEventsTestingRecursionProtect;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentConversation;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextCasualSpeechValidAt;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastSightings;

	private static readonly System.IntPtr NativeFieldInfoPtr_sightingMemoryLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastMovementSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_speechHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageThreadsStarted;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageThreadFeatures;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageThreadCCd;

	private static readonly System.IntPtr NativeFieldInfoPtr_addressBook;

	private static readonly System.IntPtr NativeFieldInfoPtr_setupAddressBook;

	private static readonly System.IntPtr NativeFieldInfoPtr_workID;

	private static readonly System.IntPtr NativeFieldInfoPtr_birthdayCards;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentConsumables;

	private static readonly System.IntPtr NativeFieldInfoPtr_trash;

	private static readonly System.IntPtr NativeFieldInfoPtr_anywhereTrash;

	private static readonly System.IntPtr NativeFieldInfoPtr_death;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentWounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_walletItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_factDictionary;

	private static readonly System.IntPtr NativeFieldInfoPtr_personalAffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_workAffects;

	private static readonly System.IntPtr NativeFieldInfoPtr_workPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_sleepPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_preferredBookCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_library;

	private static readonly System.IntPtr NativeFieldInfoPtr_nonShelfBooks;

	private static readonly System.IntPtr NativeFieldInfoPtr_booksAwayFromShelf;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemRanking;

	private static readonly System.IntPtr NativeFieldInfoPtr_favouritePlaces;

	private static readonly System.IntPtr NativeFieldInfoPtr_recentPurchases;

	private static readonly System.IntPtr NativeFieldInfoPtr_passcode;

	private static readonly System.IntPtr NativeFieldInfoPtr_passwordTrait;

	private static readonly System.IntPtr NativeFieldInfoPtr_simulatedPreviousBehaviour;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastUsedCCTVScreenPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateMeshList;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugConversation;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugLastChangedNodeAt;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugLastAITick;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetJob_Public_Void_Occupation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerGender_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSexualityAndGender_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBirthGender_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSuitableGenderAndSexualityForParnter_Public_Void_Citizen_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPersonality_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupPotentialModifierFlagsByTraits_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTraitChance_Private_Single_CharacterTrait_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TraitExists_Public_Boolean_CharacterTrait_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChance_Public_Single_byref_List_1_TraitPickRule_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCharacterTrait_Public_Trait_CharacterTrait_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPartner_Public_Void_Citizen_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetResidence_Public_Virtual_New_Void_ResidenceController_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDen_Public_Virtual_New_Void_NewAddress_MurderMO_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTickRateOnProx_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupGeneral_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateBloodType_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBloodTypeString_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSlang_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPhysicalModelParams_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateEvidence_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDetails_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateAge_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAge_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAgeGroup_Public_Age_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PickPassword_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepForStart_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateVocab_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDDSVocab_Public_Virtual_New_Void_DDSTreeSave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GeneratePastVmails_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDDSInteractionDialog_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TestInteractionInstances_Public_Void_DialogOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartSecondaryBranch_Private_Branch_InteractionDialogInstance_DDSMessageLink_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteAndTestCurrentInteractionEvent_Private_EventsTestResult_Branch_byref_Boolean_DialogOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupInteractables_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_HumanCitySave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAcquaintances_Public_Void_HumanCitySave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFavourites_Public_Void_HumanCitySave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRoutineGoals_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TraitGoalTest_Public_Boolean_AIGoalPreset_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVisible_Public_Virtual_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnGameLocationChange_Public_Virtual_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRoomChange_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnNodeChange_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTrespassing_Public_Virtual_Boolean_NewRoom_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAcquaintances_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindAcquaintanceExists_Public_Boolean_Human_byref_Acquaintance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAcquaintance_Public_Void_Human_Single_ConnectionType_Boolean_Boolean_ConnectionType_SocialGroup_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDetailToDict_Public_Void_String_Fact_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Murder_Public_Void_Human_Boolean_Murder_Interactable_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromWorld_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GoToSleep_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WakeUp_Public_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNourishment_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddHydration_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAlertness_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddEnergy_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddExcitement_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChores_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddHygiene_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBladder_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBreath_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddHeat_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDrunk_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSick_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddHeadache_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWet_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBrokenLeg_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBruised_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBlackEye_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBlackedOut_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNumb_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPoisoned_Public_Virtual_New_Void_Single_Human_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBleeding_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBlinded_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddStarchAddiction_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWellRested_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSyncDiskInstall_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAsDirector_Public_Void_Company_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFootwear_Public_Virtual_New_Void_ShoeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFootstep_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPersonalAffect_Public_Void_InteractablePreset_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemovePersonalAffect_Public_Void_InteractablePreset_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSafeTeleport_Public_NewNode_NewGameLocation_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSafeTeleport_Public_NewNode_NewRoom_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindSafeTeleport_Public_NewNode_NewRoom_byref_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateItemFavs_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnInventoryItems_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WeaponTraitTest_Public_Boolean_Citizen_byref_List_1_MurdererModifierRule_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaceFavouriteItems_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSimulatedTimeRange_Public_Single_NewGameLocation_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteNote_Public_Interactable_NoteObject_String_Human_NewGameLocation_Int32_OwnedPlacementRule_Int32_HashSet_1_NewRoom_Boolean_Int32_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteNote_Public_Interactable_List_1_NoteObject_String_Human_NewGameLocation_Int32_OwnedPlacementRule_Int32_HashSet_1_NewRoom_Boolean_Int32_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSaveData_Public_HumanCitySave_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Human_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpeechTriggerPoint_Public_Void_TriggerPoint_Actor_AIActionPreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DDSParticipantConditionCheck_Public_Boolean_Human_DDSParticipant_TreeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteConversationTree_Public_Void_DDSTreeSave_List_1_Human_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInConversation_Public_Virtual_New_Void_ConversationInstance_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseDDSMessage_Public_List_1_String_DDSMessageSettings_Acquaintance_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseDDSMessage_Public_List_1_String_String_Acquaintance_byref_List_1_Int32_Boolean_Object_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDesiredSpeed_Public_Virtual_New_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDesiredSpeed_Public_Virtual_New_Void_MovementSpeed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMovementSpeed_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBed_Public_Virtual_New_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWorkFurniture_Public_Virtual_New_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConversation_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConversationTreeLinkRankings_Public_List_1_DDSRank_DDSMessageSettings_byref_List_1_DDSMessageLink_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCurrentConsumable_Public_Void_InteractablePreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCurrentConsumable_Public_Void_InteractablePreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddTrash_Public_Void_InteractablePreset_Human_List_1_Passed_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PickConsumable_Public_InteractablePreset_byref_Dictionary_2_InteractablePreset_Int32_byref_Int32_List_1_InteractablePreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDoctor_Public_Human_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLandlord_Public_Human_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMeshes_Public_Virtual_New_Void_List_1_MeshRenderer_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMesh_Public_Virtual_New_Void_GameObject_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMesh_Public_Virtual_New_Void_MeshRenderer_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveMesh_Public_Virtual_New_Void_MeshRenderer_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMeshList_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNerve_Public_Virtual_Void_Single_Actor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLODs_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHexacoScore_Public_Int32_byref_HEXACO_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WalletItemCheck_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLastSighting_Public_Void_Human_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSightingDirection_Public_Vector2_Sighting_byref_NewGameLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RevealSighting_Public_Void_Human_Boolean_Boolean_SpeechController_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RevealSighting_Public_Void_Human_Sighting_SpeechController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNearestVert_Public_Vector3_Vector3_byref_CharacterAnchor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCitizenName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCasualName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSurName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInitialledName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInitials_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstInitial_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugGetAge_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGiveItem_Public_Boolean_Interactable_Human_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReceiptDifficulty_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReceiptDifficultyBaseNameInfo_Public_String_Boolean_byref_LinkData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVehicle_Public_Virtual_New_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromGameWorld_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TeleportChosenInteractionWorldItemsToPlayer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GenerateRoutineGoals_b__197_0_Private_Boolean_AIGoalPreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__SpeechTriggerPoint_b__254_0_Private_Boolean_Telephone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__DDSParticipantConditionCheck_b__255_0_Private_Boolean_Telephone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__SetInConversation_b__257_0_Private_Boolean_Telephone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetDoctor_b__271_0_Private_Boolean_Occupation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RevealSighting_b__284_0_Private_Boolean_Murder_0;

	public unsafe int humanID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humanID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humanID)) = num;
		}
	}

	public unsafe static int assignID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_assignID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_assignID, (void*)(&num));
		}
	}

	public unsafe static int assignTraitID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_assignTraitID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_assignTraitID, (void*)(&num));
		}
	}

	public unsafe string seed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe ShoeType footwear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footwear);
			return *(ShoeType*)num;
		}
		set
		{
			*(ShoeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footwear)) = shoeType;
		}
	}

	public unsafe AudioEvent footstepEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footstepEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footstepEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe float footstepDirt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footstepDirt);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footstepDirt)) = num;
		}
	}

	public unsafe float footstepBlood
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footstepBlood);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footstepBlood)) = num;
		}
	}

	public unsafe Transform leftFoot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftFoot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftFoot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform rightFoot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightFoot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightFoot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe bool removedFromWorld
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removedFromWorld);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removedFromWorld)) = flag;
		}
	}

	public unsafe NewAddress home
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_home);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAddress>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_home)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAddress));
		}
	}

	public unsafe ResidenceController residence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_residence);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ResidenceController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_residence)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)residenceController));
		}
	}

	public unsafe NewAddress den
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_den);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAddress>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_den)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAddress));
		}
	}

	public unsafe bool scaredOfRats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaredOfRats);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scaredOfRats)) = flag;
		}
	}

	public unsafe bool likesRats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_likesRats);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_likesRats)) = flag;
		}
	}

	public unsafe bool dislikesRats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dislikesRats);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dislikesRats)) = flag;
		}
	}

	public unsafe bool hatesRats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hatesRats);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hatesRats)) = flag;
		}
	}

	public unsafe float speedMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMultiplier)) = num;
		}
	}

	public unsafe float movementWalkSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementWalkSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementWalkSpeed)) = num;
		}
	}

	public unsafe float movementRunSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementRunSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementRunSpeed)) = num;
		}
	}

	public unsafe float walkingSpeedRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_walkingSpeedRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_walkingSpeedRatio)) = num;
		}
	}

	public unsafe float currentNormalizedSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentNormalizedSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentNormalizedSpeed)) = num;
		}
	}

	public unsafe float desiredNormalizedSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredNormalizedSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredNormalizedSpeed)) = num;
		}
	}

	public unsafe float currentMovementSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMovementSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMovementSpeed)) = num;
		}
	}

	public unsafe float breathRecoveryRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breathRecoveryRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breathRecoveryRate)) = num;
		}
	}

	public unsafe Transform currentVehicle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentVehicle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentVehicle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Occupation job
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_job);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Occupation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_job)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)occupation));
		}
	}

	public unsafe Company director
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_director);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Company>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_director)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)company));
		}
	}

	public unsafe float societalClass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_societalClass);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_societalClass)) = num;
		}
	}

	public unsafe Descriptors descriptors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Descriptors>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)descriptors));
		}
	}

	public unsafe CitizenOutfitController outfitController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfitController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CitizenOutfitController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfitController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)citizenOutfitController));
		}
	}

	public unsafe HandwritingPreset handwriting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handwriting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HandwritingPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handwriting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handwritingPreset));
		}
	}

	public unsafe string birthday
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_birthday);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_birthday)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string citizenName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string firstName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string casualName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_casualName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_casualName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string surName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_surName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float genderScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genderScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genderScale)) = num;
		}
	}

	public unsafe Gender gender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gender);
			return *(Gender*)num;
		}
		set
		{
			*(Gender*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gender)) = gender;
		}
	}

	public unsafe Gender birthGender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_birthGender);
			return *(Gender*)num;
		}
		set
		{
			*(Gender*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_birthGender)) = gender;
		}
	}

	public unsafe float slangUsage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangUsage);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slangUsage)) = num;
		}
	}

	public unsafe float sexuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sexuality);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sexuality)) = num;
		}
	}

	public unsafe float homosexuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homosexuality);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homosexuality)) = num;
		}
	}

	public unsafe List<Gender> attractedTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attractedTo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Gender>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attractedTo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Citizen partner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partner);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Citizen>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partner)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)citizen));
		}
	}

	public unsafe string anniversary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anniversary);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anniversary)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Citizen paramour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramour);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Citizen>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramour)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)citizen));
		}
	}

	public unsafe int fingerprintLoop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintLoop);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fingerprintLoop)) = num;
		}
	}

	public unsafe BloodType bloodType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodType);
			return *(BloodType*)num;
		}
		set
		{
			*(BloodType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloodType)) = bloodType;
		}
	}

	public unsafe int favColourIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favColourIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favColourIndex)) = num;
		}
	}

	public unsafe float humility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humility);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humility)) = num;
		}
	}

	public unsafe float emotionality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotionality);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotionality)) = num;
		}
	}

	public unsafe float extraversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraversion);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraversion)) = num;
		}
	}

	public unsafe float agreeableness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agreeableness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agreeableness)) = num;
		}
	}

	public unsafe float conscientiousness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conscientiousness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conscientiousness)) = num;
		}
	}

	public unsafe float creativity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creativity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creativity)) = num;
		}
	}

	public unsafe float sleepNeedMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepNeedMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepNeedMultiplier)) = num;
		}
	}

	public unsafe float snoring
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snoring);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snoring)) = num;
		}
	}

	public unsafe float snoreDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snoreDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snoreDelay)) = num;
		}
	}

	public unsafe Vector2 limitHumility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitHumility);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitHumility)) = vector;
		}
	}

	public unsafe Vector2 limitEmotionality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitEmotionality);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitEmotionality)) = vector;
		}
	}

	public unsafe Vector2 limitExtraversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitExtraversion);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitExtraversion)) = vector;
		}
	}

	public unsafe Vector2 limitAgreeableness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitAgreeableness);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitAgreeableness)) = vector;
		}
	}

	public unsafe Vector2 limitConscientiousness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitConscientiousness);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitConscientiousness)) = vector;
		}
	}

	public unsafe Vector2 limitCreativity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitCreativity);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitCreativity)) = vector;
		}
	}

	public unsafe List<Trait> characterTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterTraits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Trait>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<WeightedTrait> aggressiveTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aggressiveTraits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WeightedTrait>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aggressiveTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<WeightedTrait> peacefulTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peacefulTraits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WeightedTrait>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peacefulTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<WeightedTrait> fearfulTraits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fearfulTraits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WeightedTrait>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fearfulTraits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GroupsController.SocialGroup> groups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groups);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GroupsController.SocialGroup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_groups)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float nourishment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nourishment);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nourishment)) = num;
		}
	}

	public unsafe float hydration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hydration)) = num;
		}
	}

	public unsafe float alertness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertness)) = num;
		}
	}

	public unsafe float energy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energy)) = num;
		}
	}

	public unsafe float excitement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excitement);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excitement)) = num;
		}
	}

	public unsafe float chores
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chores);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chores)) = num;
		}
	}

	public unsafe float hygiene
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hygiene);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hygiene)) = num;
		}
	}

	public unsafe float bladder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bladder);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bladder)) = num;
		}
	}

	public unsafe float breath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breath);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breath)) = num;
		}
	}

	public unsafe float heat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heat);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heat)) = num;
		}
	}

	public unsafe float drunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunk);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunk)) = num;
		}
	}

	public unsafe float sick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sick);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sick)) = num;
		}
	}

	public unsafe float headache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headache);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headache)) = num;
		}
	}

	public unsafe float wet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wet);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wet)) = num;
		}
	}

	public unsafe float brokenLeg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenLeg);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenLeg)) = num;
		}
	}

	public unsafe float bruised
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bruised);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bruised)) = num;
		}
	}

	public unsafe float blackEye
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackEye);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackEye)) = num;
		}
	}

	public unsafe float blackedOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackedOut);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackedOut)) = num;
		}
	}

	public unsafe float numb
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numb);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numb)) = num;
		}
	}

	public unsafe float poisoned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisoned);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisoned)) = num;
		}
	}

	public unsafe float bleeding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleeding);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bleeding)) = num;
		}
	}

	public unsafe float wellRested
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wellRested);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wellRested)) = num;
		}
	}

	public unsafe float starchAddiction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starchAddiction);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starchAddiction)) = num;
		}
	}

	public unsafe float syncDiskInstall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncDiskInstall);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncDiskInstall)) = num;
		}
	}

	public unsafe float blinded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blinded);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blinded)) = num;
		}
	}

	public unsafe Human poisoner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisoner);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisoner)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
		}
	}

	public unsafe GameObject CorpseCollisionCorrection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CorpseCollisionCorrection);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CorpseCollisionCorrection)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe List<Acquaintance> acquaintances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acquaintances);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Acquaintance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_acquaintances)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<DDSSaveClasses.TriggerPoint, List<DDSSaveClasses.DDSTreeSave>> dds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<DDSSaveClasses.TriggerPoint, List<DDSSaveClasses.DDSTreeSave>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<InteractionDialogInstance> interactionEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionEvents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractionDialogInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool interactionEventsTestingRecursionProtect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionEventsTestingRecursionProtect);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionEventsTestingRecursionProtect)) = flag;
		}
	}

	public unsafe ConversationInstance currentConversation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentConversation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConversationInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentConversation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)conversationInstance));
		}
	}

	public unsafe float nextCasualSpeechValidAt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextCasualSpeechValidAt);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextCasualSpeechValidAt)) = num;
		}
	}

	public unsafe Dictionary<Human, Sighting> lastSightings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSightings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Human, Sighting>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSightings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int sightingMemoryLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sightingMemoryLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sightingMemoryLimit)) = num;
		}
	}

	public unsafe MovementSpeed lastMovementSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMovementSpeed);
			return *(MovementSpeed*)num;
		}
		set
		{
			*(MovementSpeed*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMovementSpeed)) = movementSpeed;
		}
	}

	public unsafe Dictionary<DDSSaveClasses.DDSTreeSave, List<SpeechHistory>> speechHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speechHistory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<DDSSaveClasses.DDSTreeSave, List<SpeechHistory>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speechHistory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<StateSaveData.MessageThreadSave> messageThreadsStarted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageThreadsStarted);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StateSaveData.MessageThreadSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageThreadsStarted)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<StateSaveData.MessageThreadSave> messageThreadFeatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageThreadFeatures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StateSaveData.MessageThreadSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageThreadFeatures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<StateSaveData.MessageThreadSave> messageThreadCCd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageThreadCCd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StateSaveData.MessageThreadSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageThreadCCd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Evidence addressBook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressBook);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Evidence>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressBook)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evidence));
		}
	}

	public unsafe bool setupAddressBook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setupAddressBook);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setupAddressBook)) = flag;
		}
	}

	public unsafe Evidence workID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workID);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Evidence>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workID)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evidence));
		}
	}

	public unsafe List<Interactable> birthdayCards
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_birthdayCards);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_birthdayCards)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InteractablePreset> currentConsumables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentConsumables);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentConsumables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> trash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trash);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trash)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int anywhereTrash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anywhereTrash);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anywhereTrash)) = num;
		}
	}

	public unsafe Death death
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_death);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Death>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_death)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)death));
		}
	}

	public unsafe List<Wound> currentWounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWounds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Wound>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWounds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<WalletItem> walletItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_walletItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<WalletItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_walletItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<string, Fact> factDictionary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factDictionary);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Fact>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_factDictionary)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<InteractablePreset> personalAffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_personalAffects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_personalAffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InteractablePreset> workAffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workAffects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workAffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Interactable workPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workPosition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
		}
	}

	public unsafe Interactable sleepPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepPosition);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepPosition)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
		}
	}

	public unsafe int preferredBookCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredBookCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preferredBookCount)) = num;
		}
	}

	public unsafe List<BookPreset> library
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_library);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BookPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_library)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BookPreset> nonShelfBooks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonShelfBooks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BookPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonShelfBooks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int booksAwayFromShelf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_booksAwayFromShelf);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_booksAwayFromShelf)) = num;
		}
	}

	public unsafe Dictionary<RetailItemPreset, int> itemRanking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRanking);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<RetailItemPreset, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemRanking)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<CompanyPreset.CompanyCategory, NewAddress> favouritePlaces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favouritePlaces);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CompanyPreset.CompanyCategory, NewAddress>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_favouritePlaces)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<RetailItemPreset, float> recentPurchases
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recentPurchases);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<RetailItemPreset, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recentPurchases)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe GameplayController.Passcode passcode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passcode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameplayController.Passcode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passcode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passcode));
		}
	}

	public unsafe CharacterTrait passwordTrait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passwordTrait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passwordTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
		}
	}

	public unsafe List<float> simulatedPreviousBehaviour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulatedPreviousBehaviour);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_simulatedPreviousBehaviour)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Vector2 lastUsedCCTVScreenPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUsedCCTVScreenPoint);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUsedCCTVScreenPoint)) = vector;
		}
	}

	public unsafe bool updateMeshList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateMeshList);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateMeshList)) = flag;
		}
	}

	public unsafe ConversationInstance debugConversation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugConversation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConversationInstance>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugConversation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)conversationInstance));
		}
	}

	public unsafe float debugLastChangedNodeAt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLastChangedNodeAt);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLastChangedNodeAt)) = num;
		}
	}

	public unsafe float debugLastAITick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLastAITick);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugLastAITick)) = num;
		}
	}

	static Human()
	{
		Il2CppClassPointerStore<Human>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Human");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Human>.NativeClassPtr);
		NativeFieldInfoPtr_humanID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "humanID");
		NativeFieldInfoPtr_assignID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "assignID");
		NativeFieldInfoPtr_assignTraitID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "assignTraitID");
		NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "seed");
		NativeFieldInfoPtr_footwear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "footwear");
		NativeFieldInfoPtr_footstepEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "footstepEvent");
		NativeFieldInfoPtr_footstepDirt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "footstepDirt");
		NativeFieldInfoPtr_footstepBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "footstepBlood");
		NativeFieldInfoPtr_leftFoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "leftFoot");
		NativeFieldInfoPtr_rightFoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "rightFoot");
		NativeFieldInfoPtr_removedFromWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "removedFromWorld");
		NativeFieldInfoPtr_home = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "home");
		NativeFieldInfoPtr_residence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "residence");
		NativeFieldInfoPtr_den = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "den");
		NativeFieldInfoPtr_scaredOfRats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "scaredOfRats");
		NativeFieldInfoPtr_likesRats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "likesRats");
		NativeFieldInfoPtr_dislikesRats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "dislikesRats");
		NativeFieldInfoPtr_hatesRats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "hatesRats");
		NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "speedMultiplier");
		NativeFieldInfoPtr_movementWalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "movementWalkSpeed");
		NativeFieldInfoPtr_movementRunSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "movementRunSpeed");
		NativeFieldInfoPtr_walkingSpeedRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "walkingSpeedRatio");
		NativeFieldInfoPtr_currentNormalizedSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "currentNormalizedSpeed");
		NativeFieldInfoPtr_desiredNormalizedSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "desiredNormalizedSpeed");
		NativeFieldInfoPtr_currentMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "currentMovementSpeed");
		NativeFieldInfoPtr_breathRecoveryRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "breathRecoveryRate");
		NativeFieldInfoPtr_currentVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "currentVehicle");
		NativeFieldInfoPtr_job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "job");
		NativeFieldInfoPtr_director = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "director");
		NativeFieldInfoPtr_societalClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "societalClass");
		NativeFieldInfoPtr_descriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "descriptors");
		NativeFieldInfoPtr_outfitController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "outfitController");
		NativeFieldInfoPtr_handwriting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "handwriting");
		NativeFieldInfoPtr_birthday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "birthday");
		NativeFieldInfoPtr_citizenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "citizenName");
		NativeFieldInfoPtr_firstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "firstName");
		NativeFieldInfoPtr_casualName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "casualName");
		NativeFieldInfoPtr_surName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "surName");
		NativeFieldInfoPtr_genderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "genderScale");
		NativeFieldInfoPtr_gender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "gender");
		NativeFieldInfoPtr_birthGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "birthGender");
		NativeFieldInfoPtr_slangUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "slangUsage");
		NativeFieldInfoPtr_sexuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "sexuality");
		NativeFieldInfoPtr_homosexuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "homosexuality");
		NativeFieldInfoPtr_attractedTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "attractedTo");
		NativeFieldInfoPtr_partner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "partner");
		NativeFieldInfoPtr_anniversary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "anniversary");
		NativeFieldInfoPtr_paramour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "paramour");
		NativeFieldInfoPtr_fingerprintLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "fingerprintLoop");
		NativeFieldInfoPtr_bloodType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "bloodType");
		NativeFieldInfoPtr_favColourIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "favColourIndex");
		NativeFieldInfoPtr_humility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "humility");
		NativeFieldInfoPtr_emotionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "emotionality");
		NativeFieldInfoPtr_extraversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "extraversion");
		NativeFieldInfoPtr_agreeableness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "agreeableness");
		NativeFieldInfoPtr_conscientiousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "conscientiousness");
		NativeFieldInfoPtr_creativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "creativity");
		NativeFieldInfoPtr_sleepNeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "sleepNeedMultiplier");
		NativeFieldInfoPtr_snoring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "snoring");
		NativeFieldInfoPtr_snoreDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "snoreDelay");
		NativeFieldInfoPtr_limitHumility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "limitHumility");
		NativeFieldInfoPtr_limitEmotionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "limitEmotionality");
		NativeFieldInfoPtr_limitExtraversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "limitExtraversion");
		NativeFieldInfoPtr_limitAgreeableness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "limitAgreeableness");
		NativeFieldInfoPtr_limitConscientiousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "limitConscientiousness");
		NativeFieldInfoPtr_limitCreativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "limitCreativity");
		NativeFieldInfoPtr_characterTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "characterTraits");
		NativeFieldInfoPtr_aggressiveTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "aggressiveTraits");
		NativeFieldInfoPtr_peacefulTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "peacefulTraits");
		NativeFieldInfoPtr_fearfulTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "fearfulTraits");
		NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "groups");
		NativeFieldInfoPtr_nourishment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "nourishment");
		NativeFieldInfoPtr_hydration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "hydration");
		NativeFieldInfoPtr_alertness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "alertness");
		NativeFieldInfoPtr_energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "energy");
		NativeFieldInfoPtr_excitement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "excitement");
		NativeFieldInfoPtr_chores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "chores");
		NativeFieldInfoPtr_hygiene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "hygiene");
		NativeFieldInfoPtr_bladder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "bladder");
		NativeFieldInfoPtr_breath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "breath");
		NativeFieldInfoPtr_heat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "heat");
		NativeFieldInfoPtr_drunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "drunk");
		NativeFieldInfoPtr_sick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "sick");
		NativeFieldInfoPtr_headache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "headache");
		NativeFieldInfoPtr_wet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "wet");
		NativeFieldInfoPtr_brokenLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "brokenLeg");
		NativeFieldInfoPtr_bruised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "bruised");
		NativeFieldInfoPtr_blackEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "blackEye");
		NativeFieldInfoPtr_blackedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "blackedOut");
		NativeFieldInfoPtr_numb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "numb");
		NativeFieldInfoPtr_poisoned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "poisoned");
		NativeFieldInfoPtr_bleeding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "bleeding");
		NativeFieldInfoPtr_wellRested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "wellRested");
		NativeFieldInfoPtr_starchAddiction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "starchAddiction");
		NativeFieldInfoPtr_syncDiskInstall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "syncDiskInstall");
		NativeFieldInfoPtr_blinded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "blinded");
		NativeFieldInfoPtr_poisoner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "poisoner");
		NativeFieldInfoPtr_CorpseCollisionCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "CorpseCollisionCorrection");
		NativeFieldInfoPtr_acquaintances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "acquaintances");
		NativeFieldInfoPtr_dds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "dds");
		NativeFieldInfoPtr_interactionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "interactionEvents");
		NativeFieldInfoPtr_interactionEventsTestingRecursionProtect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "interactionEventsTestingRecursionProtect");
		NativeFieldInfoPtr_currentConversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "currentConversation");
		NativeFieldInfoPtr_nextCasualSpeechValidAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "nextCasualSpeechValidAt");
		NativeFieldInfoPtr_lastSightings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "lastSightings");
		NativeFieldInfoPtr_sightingMemoryLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "sightingMemoryLimit");
		NativeFieldInfoPtr_lastMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "lastMovementSpeed");
		NativeFieldInfoPtr_speechHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "speechHistory");
		NativeFieldInfoPtr_messageThreadsStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "messageThreadsStarted");
		NativeFieldInfoPtr_messageThreadFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "messageThreadFeatures");
		NativeFieldInfoPtr_messageThreadCCd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "messageThreadCCd");
		NativeFieldInfoPtr_addressBook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "addressBook");
		NativeFieldInfoPtr_setupAddressBook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "setupAddressBook");
		NativeFieldInfoPtr_workID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "workID");
		NativeFieldInfoPtr_birthdayCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "birthdayCards");
		NativeFieldInfoPtr_currentConsumables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "currentConsumables");
		NativeFieldInfoPtr_trash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "trash");
		NativeFieldInfoPtr_anywhereTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "anywhereTrash");
		NativeFieldInfoPtr_death = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "death");
		NativeFieldInfoPtr_currentWounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "currentWounds");
		NativeFieldInfoPtr_walletItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "walletItems");
		NativeFieldInfoPtr_factDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "factDictionary");
		NativeFieldInfoPtr_personalAffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "personalAffects");
		NativeFieldInfoPtr_workAffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "workAffects");
		NativeFieldInfoPtr_workPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "workPosition");
		NativeFieldInfoPtr_sleepPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "sleepPosition");
		NativeFieldInfoPtr_preferredBookCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "preferredBookCount");
		NativeFieldInfoPtr_library = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "library");
		NativeFieldInfoPtr_nonShelfBooks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "nonShelfBooks");
		NativeFieldInfoPtr_booksAwayFromShelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "booksAwayFromShelf");
		NativeFieldInfoPtr_itemRanking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "itemRanking");
		NativeFieldInfoPtr_favouritePlaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "favouritePlaces");
		NativeFieldInfoPtr_recentPurchases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "recentPurchases");
		NativeFieldInfoPtr_passcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "passcode");
		NativeFieldInfoPtr_passwordTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "passwordTrait");
		NativeFieldInfoPtr_simulatedPreviousBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "simulatedPreviousBehaviour");
		NativeFieldInfoPtr_lastUsedCCTVScreenPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "lastUsedCCTVScreenPoint");
		NativeFieldInfoPtr_updateMeshList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "updateMeshList");
		NativeFieldInfoPtr_debugConversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "debugConversation");
		NativeFieldInfoPtr_debugLastChangedNodeAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "debugLastChangedNodeAt");
		NativeFieldInfoPtr_debugLastAITick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Human>.NativeClassPtr, "debugLastAITick");
		NativeMethodInfoPtr_SetJob_Public_Void_Occupation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664110);
		NativeMethodInfoPtr_SetPlayerGender_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664111);
		NativeMethodInfoPtr_SetSexualityAndGender_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664112);
		NativeMethodInfoPtr_SetBirthGender_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664113);
		NativeMethodInfoPtr_GenerateSuitableGenderAndSexualityForParnter_Public_Void_Citizen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664114);
		NativeMethodInfoPtr_SetPersonality_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664115);
		NativeMethodInfoPtr_SetupPotentialModifierFlagsByTraits_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664116);
		NativeMethodInfoPtr_GetTraitChance_Private_Single_CharacterTrait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664117);
		NativeMethodInfoPtr_TraitExists_Public_Boolean_CharacterTrait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664118);
		NativeMethodInfoPtr_GetChance_Public_Single_byref_List_1_TraitPickRule_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664119);
		NativeMethodInfoPtr_AddCharacterTrait_Public_Trait_CharacterTrait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664120);
		NativeMethodInfoPtr_SetPartner_Public_Void_Citizen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664121);
		NativeMethodInfoPtr_SetResidence_Public_Virtual_New_Void_ResidenceController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664122);
		NativeMethodInfoPtr_SetDen_Public_Virtual_New_Void_NewAddress_MurderMO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664123);
		NativeMethodInfoPtr_UpdateTickRateOnProx_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664124);
		NativeMethodInfoPtr_SetupGeneral_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664125);
		NativeMethodInfoPtr_GenerateBloodType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664126);
		NativeMethodInfoPtr_GetBloodTypeString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664127);
		NativeMethodInfoPtr_GenerateSlang_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664128);
		NativeMethodInfoPtr_SetPhysicalModelParams_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664129);
		NativeMethodInfoPtr_CreateEvidence_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664130);
		NativeMethodInfoPtr_CreateDetails_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664131);
		NativeMethodInfoPtr_CalculateAge_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664132);
		NativeMethodInfoPtr_GetAge_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664133);
		NativeMethodInfoPtr_GetAgeGroup_Public_Age_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664134);
		NativeMethodInfoPtr_PickPassword_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664135);
		NativeMethodInfoPtr_PrepForStart_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664136);
		NativeMethodInfoPtr_GenerateVocab_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664137);
		NativeMethodInfoPtr_AddDDSVocab_Public_Virtual_New_Void_DDSTreeSave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664138);
		NativeMethodInfoPtr_GeneratePastVmails_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664139);
		NativeMethodInfoPtr_GenerateDDSInteractionDialog_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664140);
		NativeMethodInfoPtr_TestInteractionInstances_Public_Void_DialogOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664141);
		NativeMethodInfoPtr_StartSecondaryBranch_Private_Branch_InteractionDialogInstance_DDSMessageLink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664142);
		NativeMethodInfoPtr_ExecuteAndTestCurrentInteractionEvent_Private_EventsTestResult_Branch_byref_Boolean_DialogOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664143);
		NativeMethodInfoPtr_SetupInteractables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664144);
		NativeMethodInfoPtr_Load_Public_Void_HumanCitySave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664145);
		NativeMethodInfoPtr_LoadAcquaintances_Public_Void_HumanCitySave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664146);
		NativeMethodInfoPtr_LoadFavourites_Public_Void_HumanCitySave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664147);
		NativeMethodInfoPtr_GenerateRoutineGoals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664148);
		NativeMethodInfoPtr_TraitGoalTest_Public_Boolean_AIGoalPreset_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664149);
		NativeMethodInfoPtr_SetVisible_Public_Virtual_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664150);
		NativeMethodInfoPtr_OnGameLocationChange_Public_Virtual_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664151);
		NativeMethodInfoPtr_OnRoomChange_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664152);
		NativeMethodInfoPtr_OnNodeChange_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664153);
		NativeMethodInfoPtr_IsTrespassing_Public_Virtual_Boolean_NewRoom_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664154);
		NativeMethodInfoPtr_CreateAcquaintances_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664155);
		NativeMethodInfoPtr_FindAcquaintanceExists_Public_Boolean_Human_byref_Acquaintance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664156);
		NativeMethodInfoPtr_AddAcquaintance_Public_Void_Human_Single_ConnectionType_Boolean_Boolean_ConnectionType_SocialGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664157);
		NativeMethodInfoPtr_AddDetailToDict_Public_Void_String_Fact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664158);
		NativeMethodInfoPtr_Murder_Public_Void_Human_Boolean_Murder_Interactable_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664159);
		NativeMethodInfoPtr_RemoveFromWorld_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664160);
		NativeMethodInfoPtr_GoToSleep_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664161);
		NativeMethodInfoPtr_WakeUp_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664162);
		NativeMethodInfoPtr_AddNourishment_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664163);
		NativeMethodInfoPtr_AddHydration_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664164);
		NativeMethodInfoPtr_AddAlertness_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664165);
		NativeMethodInfoPtr_AddEnergy_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664166);
		NativeMethodInfoPtr_AddExcitement_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664167);
		NativeMethodInfoPtr_AddChores_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664168);
		NativeMethodInfoPtr_AddHygiene_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664169);
		NativeMethodInfoPtr_AddBladder_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664170);
		NativeMethodInfoPtr_AddBreath_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664171);
		NativeMethodInfoPtr_AddHeat_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664172);
		NativeMethodInfoPtr_AddDrunk_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664173);
		NativeMethodInfoPtr_AddSick_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664174);
		NativeMethodInfoPtr_AddHeadache_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664175);
		NativeMethodInfoPtr_AddWet_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664176);
		NativeMethodInfoPtr_AddBrokenLeg_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664177);
		NativeMethodInfoPtr_AddBruised_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664178);
		NativeMethodInfoPtr_AddBlackEye_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664179);
		NativeMethodInfoPtr_AddBlackedOut_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664180);
		NativeMethodInfoPtr_AddNumb_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664181);
		NativeMethodInfoPtr_AddPoisoned_Public_Virtual_New_Void_Single_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664182);
		NativeMethodInfoPtr_AddBleeding_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664183);
		NativeMethodInfoPtr_AddBlinded_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664184);
		NativeMethodInfoPtr_AddStarchAddiction_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664185);
		NativeMethodInfoPtr_AddWellRested_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664186);
		NativeMethodInfoPtr_AddSyncDiskInstall_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664187);
		NativeMethodInfoPtr_SetAsDirector_Public_Void_Company_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664188);
		NativeMethodInfoPtr_SetFootwear_Public_Virtual_New_Void_ShoeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664189);
		NativeMethodInfoPtr_OnFootstep_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664190);
		NativeMethodInfoPtr_AddPersonalAffect_Public_Void_InteractablePreset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664191);
		NativeMethodInfoPtr_RemovePersonalAffect_Public_Void_InteractablePreset_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664192);
		NativeMethodInfoPtr_FindSafeTeleport_Public_NewNode_NewGameLocation_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664193);
		NativeMethodInfoPtr_FindSafeTeleport_Public_NewNode_NewRoom_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664194);
		NativeMethodInfoPtr_FindSafeTeleport_Public_NewNode_NewRoom_byref_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664195);
		NativeMethodInfoPtr_GenerateItemFavs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664196);
		NativeMethodInfoPtr_SpawnInventoryItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664197);
		NativeMethodInfoPtr_WeaponTraitTest_Public_Boolean_Citizen_byref_List_1_MurdererModifierRule_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664198);
		NativeMethodInfoPtr_PlaceFavouriteItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664199);
		NativeMethodInfoPtr_GetSimulatedTimeRange_Public_Single_NewGameLocation_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664200);
		NativeMethodInfoPtr_WriteNote_Public_Interactable_NoteObject_String_Human_NewGameLocation_Int32_OwnedPlacementRule_Int32_HashSet_1_NewRoom_Boolean_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664201);
		NativeMethodInfoPtr_WriteNote_Public_Interactable_List_1_NoteObject_String_Human_NewGameLocation_Int32_OwnedPlacementRule_Int32_HashSet_1_NewRoom_Boolean_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664202);
		NativeMethodInfoPtr_GenerateSaveData_Public_HumanCitySave_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664203);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664204);
		NativeMethodInfoPtr_SpeechTriggerPoint_Public_Void_TriggerPoint_Actor_AIActionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664205);
		NativeMethodInfoPtr_DDSParticipantConditionCheck_Public_Boolean_Human_DDSParticipant_TreeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664206);
		NativeMethodInfoPtr_ExecuteConversationTree_Public_Void_DDSTreeSave_List_1_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664207);
		NativeMethodInfoPtr_SetInConversation_Public_Virtual_New_Void_ConversationInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664208);
		NativeMethodInfoPtr_ParseDDSMessage_Public_List_1_String_DDSMessageSettings_Acquaintance_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664209);
		NativeMethodInfoPtr_ParseDDSMessage_Public_List_1_String_String_Acquaintance_byref_List_1_Int32_Boolean_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664210);
		NativeMethodInfoPtr_SetDesiredSpeed_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664211);
		NativeMethodInfoPtr_SetDesiredSpeed_Public_Virtual_New_Void_MovementSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664212);
		NativeMethodInfoPtr_UpdateMovementSpeed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664213);
		NativeMethodInfoPtr_SetBed_Public_Virtual_New_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664214);
		NativeMethodInfoPtr_SetWorkFurniture_Public_Virtual_New_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664215);
		NativeMethodInfoPtr_UpdateConversation_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664216);
		NativeMethodInfoPtr_GetConversationTreeLinkRankings_Public_List_1_DDSRank_DDSMessageSettings_byref_List_1_DDSMessageLink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664217);
		NativeMethodInfoPtr_AddCurrentConsumable_Public_Void_InteractablePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664218);
		NativeMethodInfoPtr_RemoveCurrentConsumable_Public_Void_InteractablePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664219);
		NativeMethodInfoPtr_AddTrash_Public_Void_InteractablePreset_Human_List_1_Passed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664220);
		NativeMethodInfoPtr_PickConsumable_Public_InteractablePreset_byref_Dictionary_2_InteractablePreset_Int32_byref_Int32_List_1_InteractablePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664221);
		NativeMethodInfoPtr_GetDoctor_Public_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664222);
		NativeMethodInfoPtr_GetLandlord_Public_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664223);
		NativeMethodInfoPtr_AddMeshes_Public_Virtual_New_Void_List_1_MeshRenderer_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664224);
		NativeMethodInfoPtr_AddMesh_Public_Virtual_New_Void_GameObject_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664225);
		NativeMethodInfoPtr_AddMesh_Public_Virtual_New_Void_MeshRenderer_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664226);
		NativeMethodInfoPtr_RemoveMesh_Public_Virtual_New_Void_MeshRenderer_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664227);
		NativeMethodInfoPtr_UpdateMeshList_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664228);
		NativeMethodInfoPtr_AddNerve_Public_Virtual_Void_Single_Actor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664229);
		NativeMethodInfoPtr_UpdateLODs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664230);
		NativeMethodInfoPtr_GetHexacoScore_Public_Int32_byref_HEXACO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664231);
		NativeMethodInfoPtr_WalletItemCheck_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664232);
		NativeMethodInfoPtr_UpdateLastSighting_Public_Void_Human_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664233);
		NativeMethodInfoPtr_GetSightingDirection_Public_Vector2_Sighting_byref_NewGameLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664234);
		NativeMethodInfoPtr_RevealSighting_Public_Void_Human_Boolean_Boolean_SpeechController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664235);
		NativeMethodInfoPtr_RevealSighting_Public_Void_Human_Sighting_SpeechController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664236);
		NativeMethodInfoPtr_GetNearestVert_Public_Vector3_Vector3_byref_CharacterAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664237);
		NativeMethodInfoPtr_GetCitizenName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664238);
		NativeMethodInfoPtr_GetFirstName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664239);
		NativeMethodInfoPtr_GetCasualName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664240);
		NativeMethodInfoPtr_GetSurName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664241);
		NativeMethodInfoPtr_GetInitialledName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664242);
		NativeMethodInfoPtr_GetInitials_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664243);
		NativeMethodInfoPtr_GetFirstInitial_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664244);
		NativeMethodInfoPtr_DebugGetAge_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664245);
		NativeMethodInfoPtr_TryGiveItem_Public_Boolean_Interactable_Human_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664246);
		NativeMethodInfoPtr_GetReceiptDifficulty_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664247);
		NativeMethodInfoPtr_GetReceiptDifficultyBaseNameInfo_Public_String_Boolean_byref_LinkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664248);
		NativeMethodInfoPtr_SetVehicle_Public_Virtual_New_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664249);
		NativeMethodInfoPtr_RemoveFromGameWorld_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664250);
		NativeMethodInfoPtr_TeleportChosenInteractionWorldItemsToPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664251);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664252);
		NativeMethodInfoPtr__GenerateRoutineGoals_b__197_0_Private_Boolean_AIGoalPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664254);
		NativeMethodInfoPtr__SpeechTriggerPoint_b__254_0_Private_Boolean_Telephone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664255);
		NativeMethodInfoPtr__DDSParticipantConditionCheck_b__255_0_Private_Boolean_Telephone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664256);
		NativeMethodInfoPtr__SetInConversation_b__257_0_Private_Boolean_Telephone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664257);
		NativeMethodInfoPtr__GetDoctor_b__271_0_Private_Boolean_Occupation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664258);
		NativeMethodInfoPtr__RevealSighting_b__284_0_Private_Boolean_Murder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Human>.NativeClassPtr, 100664259);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 23552, RefRangeEnd = 23554, XrefRangeStart = 23351, XrefRangeEnd = 23552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetJob(Occupation newJob)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newJob);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetJob_Public_Void_Occupation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23554, XrefRangeEnd = 23567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayerGender()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayerGender_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 23653, RefRangeEnd = 23654, XrefRangeStart = 23567, XrefRangeEnd = 23653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSexualityAndGender()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSexualityAndGender_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23654, XrefRangeEnd = 23661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBirthGender()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBirthGender_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23661, XrefRangeEnd = 23781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateSuitableGenderAndSexualityForParnter(Citizen newPartner)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPartner);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSuitableGenderAndSexualityForParnter_Public_Void_Citizen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 24010, RefRangeEnd = 24011, XrefRangeStart = 23781, XrefRangeEnd = 24010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPersonality()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPersonality_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 24041, RefRangeEnd = 24043, XrefRangeStart = 24011, XrefRangeEnd = 24041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupPotentialModifierFlagsByTraits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupPotentialModifierFlagsByTraits_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 24092, RefRangeEnd = 24093, XrefRangeStart = 24043, XrefRangeEnd = 24092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetTraitChance(CharacterTrait trait)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trait);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTraitChance_Private_Single_CharacterTrait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 24104, RefRangeEnd = 24109, XrefRangeStart = 24093, XrefRangeEnd = 24104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TraitExists(CharacterTrait searchTrait)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)searchTrait);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TraitExists_Public_Boolean_CharacterTrait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 24195, RefRangeEnd = 24200, XrefRangeStart = 24109, XrefRangeEnd = 24195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetChance(ref List<CharacterTrait.TraitPickRule> pickRules, float baseChance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pickRules);
		*ptr = (nint)(&intPtr);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseChance;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChance_Public_Single_byref_List_1_TraitPickRule_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		pickRules = ((intPtr4 == (System.IntPtr)0) ? null : new List<CharacterTrait.TraitPickRule>(intPtr4));
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 24390, RefRangeEnd = 24408, XrefRangeStart = 24200, XrefRangeEnd = 24390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Trait AddCharacterTrait(CharacterTrait newTrait)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTrait);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCharacterTrait_Public_Trait_CharacterTrait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Trait>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24408, XrefRangeEnd = 24410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPartner(Citizen newLover)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newLover);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPartner_Public_Void_Citizen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 24542, RefRangeEnd = 24543, XrefRangeStart = 24410, XrefRangeEnd = 24542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetResidence(ResidenceController newHome, bool removePreviousResidence = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newHome);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &removePreviousResidence;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetResidence_Public_Virtual_New_Void_ResidenceController_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24543, XrefRangeEnd = 24627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetDen(NewAddress newAddress, MurderMO decorateUsingRules = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAddress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decorateUsingRules);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetDen_Public_Virtual_New_Void_NewAddress_MurderMO_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 24719, RefRangeEnd = 24722, XrefRangeStart = 24627, XrefRangeEnd = 24719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTickRateOnProx()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTickRateOnProx_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 24821, RefRangeEnd = 24822, XrefRangeStart = 24722, XrefRangeEnd = 24821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupGeneral()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupGeneral_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 24859, RefRangeEnd = 24860, XrefRangeStart = 24822, XrefRangeEnd = 24859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateBloodType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateBloodType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 24872, RefRangeEnd = 24874, XrefRangeStart = 24860, XrefRangeEnd = 24872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetBloodTypeString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBloodTypeString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 24936, RefRangeEnd = 24937, XrefRangeStart = 24874, XrefRangeEnd = 24936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateSlang()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSlang_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 24945, RefRangeEnd = 24947, XrefRangeStart = 24937, XrefRangeEnd = 24945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPhysicalModelParams()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPhysicalModelParams_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24947, XrefRangeEnd = 24958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void CreateEvidence()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateEvidence_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25196, RefRangeEnd = 25197, XrefRangeStart = 24958, XrefRangeEnd = 25196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateDetails()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDetails_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25349, RefRangeEnd = 25350, XrefRangeStart = 25197, XrefRangeEnd = 25349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateAge()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateAge_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 25354, RefRangeEnd = 25370, XrefRangeStart = 25350, XrefRangeEnd = 25354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAge()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAge_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 25371, RefRangeEnd = 25374, XrefRangeStart = 25370, XrefRangeEnd = 25371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Descriptors.Age GetAgeGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAgeGroup_Public_Age_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Descriptors.Age*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25759, RefRangeEnd = 25760, XrefRangeStart = 25374, XrefRangeEnd = 25759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PickPassword()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PickPassword_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25760, XrefRangeEnd = 26034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void PrepForStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PrepForStart_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26053, RefRangeEnd = 26054, XrefRangeStart = 26034, XrefRangeEnd = 26053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateVocab()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateVocab_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26054, XrefRangeEnd = 26071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddDDSVocab(DDSSaveClasses.DDSTreeSave newTree)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTree);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddDDSVocab_Public_Virtual_New_Void_DDSTreeSave_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26135, RefRangeEnd = 26136, XrefRangeStart = 26071, XrefRangeEnd = 26135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GeneratePastVmails()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GeneratePastVmails_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26163, RefRangeEnd = 26164, XrefRangeStart = 26136, XrefRangeEnd = 26163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateDDSInteractionDialog()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateDDSInteractionDialog_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 26441, RefRangeEnd = 26445, XrefRangeStart = 26164, XrefRangeEnd = 26441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TestInteractionInstances(EvidenceWitness.DialogOption justSpokeDialogOption = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)justSpokeDialogOption);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TestInteractionInstances_Public_Void_DialogOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 26462, RefRangeEnd = 26464, XrefRangeStart = 26445, XrefRangeEnd = 26462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InteractionDialogInstance.Branch StartSecondaryBranch(InteractionDialogInstance inst, DDSSaveClasses.DDSMessageLink link)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inst);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)link);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartSecondaryBranch_Private_Branch_InteractionDialogInstance_DDSMessageLink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractionDialogInstance.Branch>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 27721, RefRangeEnd = 27722, XrefRangeStart = 26464, XrefRangeEnd = 27721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InteractionDialogInstance.EventsTestResult ExecuteAndTestCurrentInteractionEvent(InteractionDialogInstance.Branch branch, out bool usedJustSpoken, EvidenceWitness.DialogOption justSpokeDialogOption = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)branch);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref usedJustSpoken);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)justSpokeDialogOption);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteAndTestCurrentInteractionEvent_Private_EventsTestResult_Branch_byref_Boolean_DialogOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(InteractionDialogInstance.EventsTestResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 27842, RefRangeEnd = 27844, XrefRangeStart = 27722, XrefRangeEnd = 27842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupInteractables()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupInteractables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28034, RefRangeEnd = 28035, XrefRangeStart = 27844, XrefRangeEnd = 28034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load(CitySaveData.HumanCitySave data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_HumanCitySave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28035, XrefRangeEnd = 28047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAcquaintances(CitySaveData.HumanCitySave data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAcquaintances_Public_Void_HumanCitySave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28047, XrefRangeEnd = 28088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadFavourites(CitySaveData.HumanCitySave data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFavourites_Public_Void_HumanCitySave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28164, RefRangeEnd = 28165, XrefRangeStart = 28088, XrefRangeEnd = 28164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateRoutineGoals()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRoutineGoals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28251, RefRangeEnd = 28252, XrefRangeStart = 28165, XrefRangeEnd = 28251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TraitGoalTest(AIGoalPreset goalPreset, out float priorityMultiplier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)goalPreset);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref priorityMultiplier);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TraitGoalTest_Public_Boolean_AIGoalPreset_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28252, XrefRangeEnd = 28313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetVisible(bool vis, bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&vis);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &force;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetVisible_Public_Virtual_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28422, RefRangeEnd = 28423, XrefRangeStart = 28313, XrefRangeEnd = 28422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnGameLocationChange(bool enableSocialSightings = true, bool forceDisableLocationMemory = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&enableSocialSightings);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceDisableLocationMemory;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnGameLocationChange_Public_Virtual_Void_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28464, RefRangeEnd = 28465, XrefRangeStart = 28423, XrefRangeEnd = 28464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnRoomChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnRoomChange_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28577, RefRangeEnd = 28578, XrefRangeStart = 28465, XrefRangeEnd = 28577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnNodeChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnNodeChange_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 28729, RefRangeEnd = 28730, XrefRangeStart = 28578, XrefRangeEnd = 28729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsTrespassing(NewRoom room, out int trespassEscalation, bool enforcersAllowedEverywhere = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref trespassEscalation);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &enforcersAllowedEverywhere;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_IsTrespassing_Public_Virtual_Boolean_NewRoom_byref_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29056, RefRangeEnd = 29057, XrefRangeStart = 28730, XrefRangeEnd = 29056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateAcquaintances()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAcquaintances_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 29097, RefRangeEnd = 29117, XrefRangeStart = 29057, XrefRangeEnd = 29097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FindAcquaintanceExists(Human findC, out Acquaintance returnAcq)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)findC);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindAcquaintanceExists_Public_Boolean_Human_byref_Acquaintance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		returnAcq = ((num3 == 0) ? null : new Acquaintance(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 29155, RefRangeEnd = 29168, XrefRangeStart = 29117, XrefRangeEnd = 29155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAcquaintance(Human addC, float known, Acquaintance.ConnectionType newConnection, bool addInverse = true, bool secretConnection = false, Acquaintance.ConnectionType newSecretConnection = Acquaintance.ConnectionType.friend, GroupsController.SocialGroup group = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)addC);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &known;
		*(Acquaintance.ConnectionType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newConnection;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &addInverse;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &secretConnection;
		*(Acquaintance.ConnectionType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &newSecretConnection;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)group);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAcquaintance_Public_Void_Human_Single_ConnectionType_Boolean_Boolean_ConnectionType_SocialGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 29197, RefRangeEnd = 29202, XrefRangeStart = 29168, XrefRangeEnd = 29197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDetailToDict(string key, Fact det)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)det);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDetailToDict_Public_Void_String_Fact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29343, RefRangeEnd = 29345, XrefRangeStart = 29202, XrefRangeEnd = 29343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Murder(Human killer, bool setTimeOfDeath, MurderController.Murder murder, Interactable weapon, float chanceToScream = 1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)killer);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &setTimeOfDeath;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)murder);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)weapon);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &chanceToScream;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Murder_Public_Void_Human_Boolean_Murder_Interactable_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 29405, RefRangeEnd = 29421, XrefRangeStart = 29345, XrefRangeEnd = 29405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFromWorld(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFromWorld_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29421, XrefRangeEnd = 29448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void GoToSleep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GoToSleep_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29448, XrefRangeEnd = 29534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void WakeUp(bool forceImmediate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceImmediate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_WakeUp_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddNourishment(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddNourishment_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddHydration(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddHydration_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddAlertness(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddAlertness_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddEnergy(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddEnergy_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddExcitement(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddExcitement_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddChores(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddChores_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddHygiene(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddHygiene_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 29534, RefRangeEnd = 29541, XrefRangeStart = 29534, XrefRangeEnd = 29534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBladder(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBladder_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 29554, RefRangeEnd = 29557, XrefRangeStart = 29541, XrefRangeEnd = 29554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBreath(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBreath_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddHeat(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddHeat_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddDrunk(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddDrunk_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddSick(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddSick_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddHeadache(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddHeadache_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddWet(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddWet_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddBrokenLeg(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddBrokenLeg_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddBruised(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddBruised_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddBlackEye(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddBlackEye_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddBlackedOut(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddBlackedOut_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddNumb(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddNumb_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29557, XrefRangeEnd = 29570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddPoisoned(float addVal, Human byWho)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&addVal);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byWho);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddPoisoned_Public_Virtual_New_Void_Single_Human_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddBleeding(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddBleeding_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddBlinded(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddBlinded_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddStarchAddiction(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddStarchAddiction_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddWellRested(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddWellRested_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void AddSyncDiskInstall(float addVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&addVal);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddSyncDiskInstall_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29582, RefRangeEnd = 29583, XrefRangeStart = 29570, XrefRangeEnd = 29582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAsDirector(Company newComp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newComp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAsDirector_Public_Void_Company_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29583, XrefRangeEnd = 29599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetFootwear(ShoeType newType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetFootwear_Public_Virtual_New_Void_ShoeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 29639, RefRangeEnd = 29642, XrefRangeStart = 29599, XrefRangeEnd = 29639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFootstep(bool isRight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isRight);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFootstep_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 29704, RefRangeEnd = 29711, XrefRangeStart = 29642, XrefRangeEnd = 29704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPersonalAffect(InteractablePreset interactable, bool isWork = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isWork;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPersonalAffect_Public_Void_InteractablePreset_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 29720, RefRangeEnd = 29724, XrefRangeStart = 29711, XrefRangeEnd = 29720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemovePersonalAffect(InteractablePreset interactable, bool isWork = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isWork;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemovePersonalAffect_Public_Void_InteractablePreset_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 29779, RefRangeEnd = 29814, XrefRangeStart = 29724, XrefRangeEnd = 29779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewNode FindSafeTeleport(NewGameLocation gameLoc, bool prioritiseWindows = false, bool allowTrespass = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameLoc);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prioritiseWindows;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowTrespass;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSafeTeleport_Public_NewNode_NewGameLocation_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29815, RefRangeEnd = 29816, XrefRangeStart = 29814, XrefRangeEnd = 29815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewNode FindSafeTeleport(NewRoom room, bool prioritiseWindows = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &prioritiseWindows;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSafeTeleport_Public_NewNode_NewRoom_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 29929, RefRangeEnd = 29934, XrefRangeStart = 29816, XrefRangeEnd = 29929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewNode FindSafeTeleport(NewRoom room, out float bestScore, bool prioritiseWindows = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)room);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bestScore);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &prioritiseWindows;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSafeTeleport_Public_NewNode_NewRoom_byref_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30153, RefRangeEnd = 30154, XrefRangeStart = 29934, XrefRangeEnd = 30153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateItemFavs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateItemFavs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30308, RefRangeEnd = 30309, XrefRangeStart = 30154, XrefRangeEnd = 30308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnInventoryItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnInventoryItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30395, RefRangeEnd = 30396, XrefRangeStart = 30309, XrefRangeEnd = 30395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool WeaponTraitTest(Citizen cit, ref List<MurderPreset.MurdererModifierRule> rules, out float output)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cit);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rules);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref output);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WeaponTraitTest_Public_Boolean_Citizen_byref_List_1_MurdererModifierRule_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		rules = ((intPtr4 == (System.IntPtr)0) ? null : new List<MurderPreset.MurdererModifierRule>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30396, XrefRangeEnd = 30406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaceFavouriteItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaceFavouriteItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30406, XrefRangeEnd = 30434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetSimulatedTimeRange(NewGameLocation where, float maxTimeAgo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)where);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxTimeAgo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSimulatedTimeRange_Public_Single_NewGameLocation_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 30444, RefRangeEnd = 30454, XrefRangeStart = 30434, XrefRangeEnd = 30444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable WriteNote(NoteObject newPresetType, string treeID, Human reciever, NewGameLocation placement, int security = 0, InteractablePreset.OwnedPlacementRule ownershipPlacement = InteractablePreset.OwnedPlacementRule.both, int priority = 1, HashSet<NewRoom> dontPlaceInRooms = null, bool printDebug = false, int toneFriendly = 0, int toneFormal = 0, string loadGUID = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = (nint)(&newPresetType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(treeID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reciever);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)placement);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &security;
		*(InteractablePreset.OwnedPlacementRule**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ownershipPlacement;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &priority;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dontPlaceInRooms);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &printDebug;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &toneFriendly;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &toneFormal;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(loadGUID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteNote_Public_Interactable_NoteObject_String_Human_NewGameLocation_Int32_OwnedPlacementRule_Int32_HashSet_1_NewRoom_Boolean_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30470, RefRangeEnd = 30471, XrefRangeStart = 30454, XrefRangeEnd = 30470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Interactable WriteNote(List<NoteObject> newPresetType, string treeID, Human reciever, NewGameLocation placement, int security = 0, InteractablePreset.OwnedPlacementRule ownershipPlacement = InteractablePreset.OwnedPlacementRule.both, int priority = 1, HashSet<NewRoom> dontPlaceInRooms = null, bool printDebug = false, int toneFriendly = 0, int toneFormal = 0, string loadGUID = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPresetType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(treeID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reciever);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)placement);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &security;
		*(InteractablePreset.OwnedPlacementRule**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ownershipPlacement;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &priority;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dontPlaceInRooms);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &printDebug;
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &toneFriendly;
		*(int**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &toneFormal;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(loadGUID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteNote_Public_Interactable_List_1_NoteObject_String_Human_NewGameLocation_Int32_OwnedPlacementRule_Int32_HashSet_1_NewRoom_Boolean_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30583, RefRangeEnd = 30584, XrefRangeStart = 30471, XrefRangeEnd = 30583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CitySaveData.HumanCitySave GenerateSaveData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSaveData_Public_HumanCitySave_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CitySaveData.HumanCitySave>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual int CompareTo(Human comp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 30804, RefRangeEnd = 30806, XrefRangeStart = 30584, XrefRangeEnd = 30804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpeechTriggerPoint(DDSSaveClasses.TriggerPoint triggerPoint, Actor trackedTarget, AIActionPreset onAction = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&triggerPoint);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trackedTarget);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onAction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpeechTriggerPoint_Public_Void_TriggerPoint_Actor_AIActionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 30899, RefRangeEnd = 30903, XrefRangeStart = 30806, XrefRangeEnd = 30899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DDSParticipantConditionCheck(Human initiator, DDSSaveClasses.DDSParticipant conditions, DDSSaveClasses.TreeType treeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)initiator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)conditions);
		*(DDSSaveClasses.TreeType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &treeType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DDSParticipantConditionCheck_Public_Boolean_Human_DDSParticipant_TreeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 31003, RefRangeEnd = 31006, XrefRangeStart = 30903, XrefRangeEnd = 31003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteConversationTree(DDSSaveClasses.DDSTreeSave newTree, List<Human> otherParticipants)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTree);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)otherParticipants);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteConversationTree_Public_Void_DDSTreeSave_List_1_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31006, XrefRangeEnd = 31059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetInConversation(ConversationInstance newInstance, bool endCall = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newInstance);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &endCall;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetInConversation_Public_Virtual_New_Void_ConversationInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31059, XrefRangeEnd = 31060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<string> ParseDDSMessage(DDSSaveClasses.DDSMessageSettings settings, Acquaintance aq, Il2CppSystem.Object passedObject = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aq);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseDDSMessage_Public_List_1_String_DDSMessageSettings_Acquaintance_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 31531, RefRangeEnd = 31540, XrefRangeStart = 31060, XrefRangeEnd = 31531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<string> ParseDDSMessage(string msgID, Acquaintance aq, out List<int> outputDisplayGroups, bool forceRealRandom = false, Il2CppSystem.Object passedObject = null, bool debug = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msgID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)aq);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceRealRandom;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedObject);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &debug;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseDDSMessage_Public_List_1_String_String_Acquaintance_byref_List_1_Int32_Boolean_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		outputDisplayGroups = ((num3 == 0) ? null : new List<int>(num3));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31540, XrefRangeEnd = 31569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetDesiredSpeed(float newSpeedRatio)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newSpeedRatio);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetDesiredSpeed_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31569, XrefRangeEnd = 31592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetDesiredSpeed(MovementSpeed newMovement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newMovement);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetDesiredSpeed_Public_Virtual_New_Void_MovementSpeed_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31592, XrefRangeEnd = 31593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UpdateMovementSpeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateMovementSpeed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetBed(Interactable passSpecificInteractable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passSpecificInteractable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetBed_Public_Virtual_New_Void_Interactable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void SetWorkFurniture(Interactable passSpecificInteractable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passSpecificInteractable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetWorkFurniture_Public_Virtual_New_Void_Interactable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31593, XrefRangeEnd = 31635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UpdateConversation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateConversation_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 31687, RefRangeEnd = 31690, XrefRangeStart = 31635, XrefRangeEnd = 31687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<DDSRank> GetConversationTreeLinkRankings(DDSSaveClasses.DDSMessageSettings thisMsg, ref List<DDSSaveClasses.DDSMessageLink> links)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisMsg);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)links);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConversationTreeLinkRankings_Public_List_1_DDSRank_DDSMessageSettings_byref_List_1_DDSMessageLink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		links = ((intPtr4 == (System.IntPtr)0) ? null : new List<DDSSaveClasses.DDSMessageLink>(intPtr4));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DDSRank>>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 31705, RefRangeEnd = 31711, XrefRangeStart = 31690, XrefRangeEnd = 31705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCurrentConsumable(InteractablePreset newPreset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCurrentConsumable_Public_Void_InteractablePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 31742, RefRangeEnd = 31744, XrefRangeStart = 31711, XrefRangeEnd = 31742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveCurrentConsumable(InteractablePreset newPreset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveCurrentConsumable_Public_Void_InteractablePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 31761, RefRangeEnd = 31764, XrefRangeStart = 31744, XrefRangeEnd = 31761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTrash(InteractablePreset trashItem, Human writer, List<Interactable.Passed> passedVars = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)trashItem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)writer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passedVars);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTrash_Public_Void_InteractablePreset_Human_List_1_Passed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31801, RefRangeEnd = 31802, XrefRangeStart = 31764, XrefRangeEnd = 31801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InteractablePreset PickConsumable(ref Dictionary<InteractablePreset, int> prices, out int price, List<InteractablePreset> ignore = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prices);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref price);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ignore);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PickConsumable_Public_InteractablePreset_byref_Dictionary_2_InteractablePreset_Int32_byref_Int32_List_1_InteractablePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		prices = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<InteractablePreset, int>(intPtr4));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr2) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 31834, RefRangeEnd = 31846, XrefRangeStart = 31802, XrefRangeEnd = 31834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Human GetDoctor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDoctor_Public_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 31895, RefRangeEnd = 31908, XrefRangeStart = 31846, XrefRangeEnd = 31895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Human GetLandlord()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLandlord_Public_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31908, XrefRangeEnd = 31916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddMeshes(List<MeshRenderer> renderers, bool addToOutline = true, bool forceMeshListUpdate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderers);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &addToOutline;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMeshListUpdate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddMeshes_Public_Virtual_New_Void_List_1_MeshRenderer_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31916, XrefRangeEnd = 31953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddMesh(GameObject newObject, bool addToOutline = true, bool forceMeshListUpdate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newObject);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &addToOutline;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMeshListUpdate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddMesh_Public_Virtual_New_Void_GameObject_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31953, XrefRangeEnd = 31994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddMesh(MeshRenderer newMesh, bool addToOutline = true, bool forceMeshListUpdate = false, bool addToLOD1 = false, bool addToBoth = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newMesh);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &addToOutline;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMeshListUpdate;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &addToLOD1;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &addToBoth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddMesh_Public_Virtual_New_Void_MeshRenderer_Boolean_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31994, XrefRangeEnd = 32024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveMesh(MeshRenderer newMesh, bool removeFromOutline = true, bool forceMeshListUpdate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newMesh);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &removeFromOutline;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceMeshListUpdate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RemoveMesh_Public_Virtual_New_Void_MeshRenderer_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32024, XrefRangeEnd = 32101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UpdateMeshList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateMeshList_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32101, XrefRangeEnd = 32114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void AddNerve(float amount, Actor scaredBy = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&amount);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scaredBy);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddNerve_Public_Virtual_Void_Single_Actor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 32173, RefRangeEnd = 32176, XrefRangeStart = 32114, XrefRangeEnd = 32173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLODs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLODs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 32187, RefRangeEnd = 32191, XrefRangeStart = 32176, XrefRangeEnd = 32187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetHexacoScore(ref HEXACO hex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hex);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHexacoScore_Public_Int32_byref_HEXACO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		hex = ((intPtr4 == (System.IntPtr)0) ? null : new HEXACO(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 32332, RefRangeEnd = 32334, XrefRangeStart = 32191, XrefRangeEnd = 32332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WalletItemCheck(int maxNewItems, bool dailyReplenish)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&maxNewItems);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dailyReplenish;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WalletItemCheck_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 32433, RefRangeEnd = 32437, XrefRangeStart = 32334, XrefRangeEnd = 32433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLastSighting(Human citizen, bool phoneCall = false, int isSound = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)citizen);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &phoneCall;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSound;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLastSighting_Public_Void_Human_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 32464, RefRangeEnd = 32466, XrefRangeStart = 32437, XrefRangeEnd = 32464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetSightingDirection(Sighting sighting, out NewGameLocation newDestination)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sighting);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSightingDirection_Public_Vector2_Sighting_byref_NewGameLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		newDestination = ((num3 == 0) ? null : new NewGameLocation(num3));
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 32490, RefRangeEnd = 32495, XrefRangeStart = 32466, XrefRangeEnd = 32490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RevealSighting(Human prospectCitizen, bool allowCalls, bool allowSounds, SpeechController sc, bool allowGeneralClue = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prospectCitizen);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowCalls;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowSounds;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sc);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowGeneralClue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RevealSighting_Public_Void_Human_Boolean_Boolean_SpeechController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32495, XrefRangeEnd = 32575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RevealSighting(Human prospectCitizen, Sighting sighting, SpeechController sc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prospectCitizen);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sighting);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RevealSighting_Public_Void_Human_Sighting_SpeechController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32599, RefRangeEnd = 32600, XrefRangeStart = 32575, XrefRangeEnd = 32599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetNearestVert(Vector3 worldPosition, out CitizenOutfitController.CharacterAnchor nearestBodyPart)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&worldPosition);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref nearestBodyPart);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearestVert_Public_Vector3_Vector3_byref_CharacterAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(160)]
	[CachedScanResults(RefRangeStart = 32630, RefRangeEnd = 32790, XrefRangeStart = 32600, XrefRangeEnd = 32630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetCitizenName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCitizenName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 32823, RefRangeEnd = 32843, XrefRangeStart = 32790, XrefRangeEnd = 32823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetFirstName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 32859, RefRangeEnd = 32862, XrefRangeStart = 32843, XrefRangeEnd = 32859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetCasualName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCasualName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 32893, RefRangeEnd = 32916, XrefRangeStart = 32862, XrefRangeEnd = 32893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSurName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSurName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 32923, RefRangeEnd = 32937, XrefRangeStart = 32916, XrefRangeEnd = 32923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetInitialledName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInitialledName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 32944, RefRangeEnd = 32951, XrefRangeStart = 32937, XrefRangeEnd = 32944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetInitials()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInitials_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 32955, RefRangeEnd = 32957, XrefRangeStart = 32951, XrefRangeEnd = 32955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetFirstInitial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstInitial_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32957, XrefRangeEnd = 32974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugGetAge()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugGetAge_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 33144, RefRangeEnd = 33148, XrefRangeStart = 32974, XrefRangeEnd = 33144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGiveItem(Interactable givenItem, Human givenBy, bool defaultSuccess, bool enableSpeech = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)givenItem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)givenBy);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultSuccess;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableSpeech;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGiveItem_Public_Boolean_Interactable_Human_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 33154, RefRangeEnd = 33156, XrefRangeStart = 33148, XrefRangeEnd = 33154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetReceiptDifficulty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReceiptDifficulty_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 33269, RefRangeEnd = 33272, XrefRangeStart = 33156, XrefRangeEnd = 33269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetReceiptDifficultyBaseNameInfo(bool includeLink, out Strings.LinkData nameLink)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&includeLink);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReceiptDifficultyBaseNameInfo_Public_String_Boolean_byref_LinkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		nameLink = ((num3 == 0) ? null : new Strings.LinkData(num3));
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33272, XrefRangeEnd = 33343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetVehicle(Transform newVehicle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newVehicle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetVehicle_Public_Virtual_New_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33343, XrefRangeEnd = 33344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFromGameWorld()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFromGameWorld_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33344, XrefRangeEnd = 33355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TeleportChosenInteractionWorldItemsToPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TeleportChosenInteractionWorldItemsToPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 33510, RefRangeEnd = 33513, XrefRangeStart = 33355, XrefRangeEnd = 33510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Human()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Human>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33513, XrefRangeEnd = 33515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _GenerateRoutineGoals_b__197_0(AIGoalPreset item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateRoutineGoals_b__197_0_Private_Boolean_AIGoalPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33515, XrefRangeEnd = 33522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _SpeechTriggerPoint_b__254_0(Telephone item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SpeechTriggerPoint_b__254_0_Private_Boolean_Telephone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33522, XrefRangeEnd = 33529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _DDSParticipantConditionCheck_b__255_0(Telephone item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__DDSParticipantConditionCheck_b__255_0_Private_Boolean_Telephone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33529, XrefRangeEnd = 33536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _SetInConversation_b__257_0(Telephone item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetInConversation_b__257_0_Private_Boolean_Telephone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33536, XrefRangeEnd = 33575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _GetDoctor_b__271_0(Occupation item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetDoctor_b__271_0_Private_Boolean_Occupation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33575, XrefRangeEnd = 33582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _RevealSighting_b__284_0(MurderController.Murder item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RevealSighting_b__284_0_Private_Boolean_Murder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public Human(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
