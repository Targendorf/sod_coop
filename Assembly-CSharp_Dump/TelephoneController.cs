using System;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class TelephoneController : MonoBehaviour
{
	public enum CallState
	{
		dialing,
		denied,
		ringing,
		started,
		ended
	}

	public enum CallType
	{
		dds,
		audioEvent,
		player,
		fakeOutbound
	}

	[System.Serializable]
	public class CallSource : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_callType;

		private static readonly System.IntPtr NativeFieldInfoPtr_dds;

		private static readonly System.IntPtr NativeFieldInfoPtr_audio;

		private static readonly System.IntPtr NativeFieldInfoPtr_dialog;

		private static readonly System.IntPtr NativeFieldInfoPtr_job;

		private static readonly System.IntPtr NativeFieldInfoPtr_convoType;

		private static readonly System.IntPtr NativeFieldInfoPtr_audioEvent;

		private static readonly System.IntPtr NativeFieldInfoPtr_dialogGreeting;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CallType_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CallType_AudioEvent_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CallType_DialogPreset_ConversationType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CallType_DialogPreset_SideJob_ConversationType_0;

		public unsafe CallType callType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callType);
				return *(CallType*)num;
			}
			set
			{
				*(CallType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callType)) = callType;
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

		public unsafe string audio
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audio);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audio)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string dialog
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialog);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialog)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int job
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_job);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_job)) = num;
			}
		}

		public unsafe InteractionController.ConversationType convoType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_convoType);
				return *(InteractionController.ConversationType*)num;
			}
			set
			{
				*(InteractionController.ConversationType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_convoType)) = conversationType;
			}
		}

		public unsafe AudioEvent audioEvent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioEvent);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
			}
		}

		public unsafe DialogPreset dialogGreeting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogGreeting);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DialogPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogGreeting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialogPreset));
			}
		}

		static CallSource()
		{
			Il2CppClassPointerStore<CallSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, "CallSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSource>.NativeClassPtr);
			NativeFieldInfoPtr_callType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSource>.NativeClassPtr, "callType");
			NativeFieldInfoPtr_dds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSource>.NativeClassPtr, "dds");
			NativeFieldInfoPtr_audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSource>.NativeClassPtr, "audio");
			NativeFieldInfoPtr_dialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSource>.NativeClassPtr, "dialog");
			NativeFieldInfoPtr_job = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSource>.NativeClassPtr, "job");
			NativeFieldInfoPtr_convoType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSource>.NativeClassPtr, "convoType");
			NativeFieldInfoPtr_audioEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSource>.NativeClassPtr, "audioEvent");
			NativeFieldInfoPtr_dialogGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSource>.NativeClassPtr, "dialogGreeting");
			NativeMethodInfoPtr__ctor_Public_Void_CallType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSource>.NativeClassPtr, 100665829);
			NativeMethodInfoPtr__ctor_Public_Void_CallType_AudioEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSource>.NativeClassPtr, 100665830);
			NativeMethodInfoPtr__ctor_Public_Void_CallType_DialogPreset_ConversationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSource>.NativeClassPtr, 100665831);
			NativeMethodInfoPtr__ctor_Public_Void_CallType_DialogPreset_SideJob_ConversationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSource>.NativeClassPtr, 100665832);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95782, RefRangeEnd = 95783, XrefRangeStart = 95782, XrefRangeEnd = 95782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSource(CallType newType, string newDDS)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSource>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&newType);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newDDS);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CallType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95783, XrefRangeEnd = 95784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSource(CallType newType, AudioEvent newAudioEvent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSource>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&newType);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAudioEvent);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CallType_AudioEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 95787, RefRangeEnd = 95794, XrefRangeStart = 95784, XrefRangeEnd = 95787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSource(CallType newType, DialogPreset newGreeting, InteractionController.ConversationType newConvoType = InteractionController.ConversationType.normal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSource>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&newType);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newGreeting);
			*(InteractionController.ConversationType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newConvoType;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CallType_DialogPreset_ConversationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 95797, RefRangeEnd = 95800, XrefRangeStart = 95794, XrefRangeEnd = 95797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSource(CallType newType, DialogPreset newGreeting, SideJob newJob, InteractionController.ConversationType newConvoType = InteractionController.ConversationType.normal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSource>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&newType);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newGreeting);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newJob);
			*(InteractionController.ConversationType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newConvoType;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CallType_DialogPreset_SideJob_ConversationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CallSource(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class PhoneCall : Il2CppSystem.Object
	{
		[System.Serializable]
		[ObfuscatedName("TelephoneController+PhoneCall+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__27_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__EndCall_b__27_0_Internal_Boolean_NewAIAction_0;

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

			public unsafe static Il2CppSystem.Predicate<NewAIAction> __9__27_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NewAIAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__27_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__27_0");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665838);
				NativeMethodInfoPtr__EndCall_b__27_0_Internal_Boolean_NewAIAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665839);
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
			public unsafe bool _EndCall_b__27_0(NewAIAction item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__EndCall_b__27_0_Internal_Boolean_NewAIAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_from;

		private static readonly System.IntPtr NativeFieldInfoPtr_to;

		private static readonly System.IntPtr NativeFieldInfoPtr_time;

		private static readonly System.IntPtr NativeFieldInfoPtr_caller;

		private static readonly System.IntPtr NativeFieldInfoPtr_receiver;

		private static readonly System.IntPtr NativeFieldInfoPtr_intendedReceiver;

		private static readonly System.IntPtr NativeFieldInfoPtr_source;

		private static readonly System.IntPtr NativeFieldInfoPtr_previousSate;

		private static readonly System.IntPtr NativeFieldInfoPtr_state;

		private static readonly System.IntPtr NativeFieldInfoPtr_ringTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_specRecevier;

		private static readonly System.IntPtr NativeFieldInfoPtr_dialingTimer;

		private static readonly System.IntPtr NativeFieldInfoPtr_ringDelay;

		private static readonly System.IntPtr NativeFieldInfoPtr_fromNS;

		private static readonly System.IntPtr NativeFieldInfoPtr_toNS;

		private static readonly System.IntPtr NativeFieldInfoPtr_callerNS;

		private static readonly System.IntPtr NativeFieldInfoPtr_recevierNS;

		private static readonly System.IntPtr NativeFieldInfoPtr_intendedReceiverNS;

		private static readonly System.IntPtr NativeFieldInfoPtr_lineRingingLoop;

		private static readonly System.IntPtr NativeFieldInfoPtr_lineActiveLoopCaller;

		private static readonly System.IntPtr NativeFieldInfoPtr_lineActiveLoopReceiver;

		private static readonly System.IntPtr NativeFieldInfoPtr_callAudioInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_connecting;

		private static readonly System.IntPtr NativeFieldInfoPtr_hangUpCaller;

		private static readonly System.IntPtr NativeFieldInfoPtr_hangUpReciever;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Telephone_Telephone_Single_Human_Human_CallSource_Single_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetCallState_Public_Void_CallState_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndCall_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetupNonSerializedData_Public_Void_0;

		public unsafe int from
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_from);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_from)) = num;
			}
		}

		public unsafe int to
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_to);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_to)) = num;
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

		public unsafe int caller
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caller);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caller)) = num;
			}
		}

		public unsafe int receiver
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiver);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiver)) = num;
			}
		}

		public unsafe int intendedReceiver
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intendedReceiver);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intendedReceiver)) = num;
			}
		}

		public unsafe CallSource source
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CallSource>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callSource));
			}
		}

		public unsafe CallState previousSate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousSate);
				return *(CallState*)num;
			}
			set
			{
				*(CallState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousSate)) = callState;
			}
		}

		public unsafe CallState state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state);
				return *(CallState*)num;
			}
			set
			{
				*(CallState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_state)) = callState;
			}
		}

		public unsafe float ringTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringTime)) = num;
			}
		}

		public unsafe bool specRecevier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specRecevier);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_specRecevier)) = flag;
			}
		}

		public unsafe float dialingTimer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialingTimer);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialingTimer)) = num;
			}
		}

		public unsafe float ringDelay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringDelay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringDelay)) = num;
			}
		}

		public unsafe Telephone fromNS
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromNS);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Telephone>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromNS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)telephone));
			}
		}

		public unsafe Telephone toNS
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toNS);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Telephone>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toNS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)telephone));
			}
		}

		public unsafe Human callerNS
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callerNS);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callerNS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe Human recevierNS
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recevierNS);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recevierNS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe Human intendedReceiverNS
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intendedReceiverNS);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intendedReceiverNS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
			}
		}

		public unsafe AudioController.LoopingSoundInfo lineRingingLoop
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineRingingLoop);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioController.LoopingSoundInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineRingingLoop)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopingSoundInfo));
			}
		}

		public unsafe AudioController.LoopingSoundInfo lineActiveLoopCaller
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineActiveLoopCaller);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioController.LoopingSoundInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineActiveLoopCaller)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopingSoundInfo));
			}
		}

		public unsafe AudioController.LoopingSoundInfo lineActiveLoopReceiver
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineActiveLoopReceiver);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioController.LoopingSoundInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineActiveLoopReceiver)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopingSoundInfo));
			}
		}

		public unsafe EventInstance callAudioInstance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callAudioInstance);
				return *(EventInstance*)num;
			}
			set
			{
				*(EventInstance*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callAudioInstance)) = eventInstance;
			}
		}

		public unsafe EventInstance connecting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connecting);
				return *(EventInstance*)num;
			}
			set
			{
				*(EventInstance*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_connecting)) = eventInstance;
			}
		}

		public unsafe EventInstance hangUpCaller
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hangUpCaller);
				return *(EventInstance*)num;
			}
			set
			{
				*(EventInstance*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hangUpCaller)) = eventInstance;
			}
		}

		public unsafe EventInstance hangUpReciever
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hangUpReciever);
				return *(EventInstance*)num;
			}
			set
			{
				*(EventInstance*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hangUpReciever)) = eventInstance;
			}
		}

		static PhoneCall()
		{
			Il2CppClassPointerStore<PhoneCall>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, "PhoneCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr);
			NativeFieldInfoPtr_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "from");
			NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "to");
			NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "time");
			NativeFieldInfoPtr_caller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "caller");
			NativeFieldInfoPtr_receiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "receiver");
			NativeFieldInfoPtr_intendedReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "intendedReceiver");
			NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "source");
			NativeFieldInfoPtr_previousSate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "previousSate");
			NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "state");
			NativeFieldInfoPtr_ringTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "ringTime");
			NativeFieldInfoPtr_specRecevier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "specRecevier");
			NativeFieldInfoPtr_dialingTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "dialingTimer");
			NativeFieldInfoPtr_ringDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "ringDelay");
			NativeFieldInfoPtr_fromNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "fromNS");
			NativeFieldInfoPtr_toNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "toNS");
			NativeFieldInfoPtr_callerNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "callerNS");
			NativeFieldInfoPtr_recevierNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "recevierNS");
			NativeFieldInfoPtr_intendedReceiverNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "intendedReceiverNS");
			NativeFieldInfoPtr_lineRingingLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "lineRingingLoop");
			NativeFieldInfoPtr_lineActiveLoopCaller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "lineActiveLoopCaller");
			NativeFieldInfoPtr_lineActiveLoopReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "lineActiveLoopReceiver");
			NativeFieldInfoPtr_callAudioInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "callAudioInstance");
			NativeFieldInfoPtr_connecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "connecting");
			NativeFieldInfoPtr_hangUpCaller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "hangUpCaller");
			NativeFieldInfoPtr_hangUpReciever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, "hangUpReciever");
			NativeMethodInfoPtr__ctor_Public_Void_Telephone_Telephone_Single_Human_Human_CallSource_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, 100665833);
			NativeMethodInfoPtr_SetCallState_Public_Void_CallState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, 100665834);
			NativeMethodInfoPtr_EndCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, 100665835);
			NativeMethodInfoPtr_SetupNonSerializedData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr, 100665836);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95800, XrefRangeEnd = 95821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhoneCall(Telephone newFrom, Telephone newTo, float newTime, Human newCaller, Human newIntendedReceiver, CallSource newCallSource, float newMaxRingTime = 0.1f, bool newSpecificRecevier = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneCall>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[8];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newFrom);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTo);
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newTime;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newCaller);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newIntendedReceiver);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newCallSource);
			*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &newMaxRingTime;
			*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &newSpecificRecevier;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Telephone_Telephone_Single_Human_Human_CallSource_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96020, RefRangeEnd = 96023, XrefRangeStart = 95821, XrefRangeEnd = 96020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCallState(CallState newState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&newState);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCallState_Public_Void_CallState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 96201, RefRangeEnd = 96205, XrefRangeStart = 96023, XrefRangeEnd = 96201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96233, RefRangeEnd = 96234, XrefRangeStart = 96205, XrefRangeEnd = 96233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupNonSerializedData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupNonSerializedData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public PhoneCall(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class PlayerCall : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static PlayerCall()
		{
			Il2CppClassPointerStore<PlayerCall>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, "PlayerCall");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCall>.NativeClassPtr, 100665840);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCall>.NativeClassPtr, 100665841);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCall>.NativeClassPtr, 100665842);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCall>.NativeClassPtr, 100665843);
		}

		[CallerCount(994)]
		[CachedScanResults(RefRangeStart = 10717, RefRangeEnd = 11711, XrefRangeStart = 10717, XrefRangeEnd = 11711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerCall(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCall>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11711, RefRangeEnd = 11712, XrefRangeStart = 11711, XrefRangeEnd = 11712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public PlayerCall(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator PlayerCall(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<PlayerCall>((System.Delegate)P_0);
		}

		public static PlayerCall operator +(PlayerCall P_0, PlayerCall P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<PlayerCall>();
		}

		public static PlayerCall operator -(PlayerCall P_0, PlayerCall P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<PlayerCall>();
			}
			return (PlayerCall)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_activeCalls;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameTimeLastLoop;

	private static readonly System.IntPtr NativeFieldInfoPtr_engagedEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_fakeTelephoneDictionary;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnPlayerCall;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnPlayerCall_Public_add_Void_PlayerCall_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnPlayerCall_Public_rem_Void_PlayerCall_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_TelephoneController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewCall_Public_PhoneCall_Int32_Int32_Human_Human_CallSource_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewCall_Public_PhoneCall_Telephone_Telephone_Human_Human_CallSource_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPlayerCalls_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFakeNumber_Public_Void_Int32_CallSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFakeNumber_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddActiveCall_Public_Void_PhoneCall_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActiveCall_Public_Void_PhoneCall_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindTelephoneByNumber_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindTelephonesAtPlayerLocation_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<PhoneCall> activeCalls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeCalls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PhoneCall>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeCalls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float gameTimeLastLoop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameTimeLastLoop);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameTimeLastLoop)) = num;
		}
	}

	public unsafe Dictionary<Interactable, EventInstance> engagedEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engagedEvents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Interactable, EventInstance>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engagedEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Dictionary<int, CallSource> fakeTelephoneDictionary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fakeTelephoneDictionary);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, CallSource>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fakeTelephoneDictionary)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe int debugNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugNumber)) = num;
		}
	}

	public unsafe PlayerCall OnPlayerCall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPlayerCall);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerCall>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPlayerCall)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerCall));
		}
	}

	public unsafe static TelephoneController _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TelephoneController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)telephoneController));
		}
	}

	public unsafe static TelephoneController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96244, XrefRangeEnd = 96246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_TelephoneController_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TelephoneController>(intPtr) : null;
		}
	}

	static TelephoneController()
	{
		Il2CppClassPointerStore<TelephoneController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TelephoneController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr);
		NativeFieldInfoPtr_activeCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, "activeCalls");
		NativeFieldInfoPtr_gameTimeLastLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, "gameTimeLastLoop");
		NativeFieldInfoPtr_engagedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, "engagedEvents");
		NativeFieldInfoPtr_fakeTelephoneDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, "fakeTelephoneDictionary");
		NativeFieldInfoPtr_debugNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, "debugNumber");
		NativeFieldInfoPtr_OnPlayerCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, "OnPlayerCall");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_add_OnPlayerCall_Public_add_Void_PlayerCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665813);
		NativeMethodInfoPtr_remove_OnPlayerCall_Public_rem_Void_PlayerCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665814);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_TelephoneController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665815);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665816);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665817);
		NativeMethodInfoPtr_CreateNewCall_Public_PhoneCall_Int32_Int32_Human_Human_CallSource_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665818);
		NativeMethodInfoPtr_CreateNewCall_Public_PhoneCall_Telephone_Telephone_Human_Human_CallSource_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665819);
		NativeMethodInfoPtr_OnPlayerCalls_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665820);
		NativeMethodInfoPtr_AddFakeNumber_Public_Void_Int32_CallSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665821);
		NativeMethodInfoPtr_RemoveFakeNumber_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665822);
		NativeMethodInfoPtr_AddActiveCall_Public_Void_PhoneCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665823);
		NativeMethodInfoPtr_RemoveActiveCall_Public_Void_PhoneCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665824);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665825);
		NativeMethodInfoPtr_FindTelephoneByNumber_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665826);
		NativeMethodInfoPtr_FindTelephonesAtPlayerLocation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665827);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr, 100665828);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96237, RefRangeEnd = 96238, XrefRangeStart = 96234, XrefRangeEnd = 96237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnPlayerCall(PlayerCall value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnPlayerCall_Public_add_Void_PlayerCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 96241, RefRangeEnd = 96244, XrefRangeStart = 96238, XrefRangeEnd = 96241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnPlayerCall(PlayerCall value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnPlayerCall_Public_rem_Void_PlayerCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96246, XrefRangeEnd = 96283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96283, XrefRangeEnd = 96304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96304, XrefRangeEnd = 96314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PhoneCall CreateNewCall(int from, int to, Human caller, Human intendedReceiver, CallSource callSource, float maxRingTime = 0.1f, bool specificRecevier = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&from);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caller);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)intendedReceiver);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callSource);
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxRingTime;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &specificRecevier;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNewCall_Public_PhoneCall_Int32_Int32_Human_Human_CallSource_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PhoneCall>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 96351, RefRangeEnd = 96358, XrefRangeStart = 96314, XrefRangeEnd = 96351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PhoneCall CreateNewCall(Telephone from, Telephone to, Human caller, Human intendedReceiver, CallSource callSource, float maxRingTime = 0.1f, bool specificRecevier = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)to);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)caller);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)intendedReceiver);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callSource);
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxRingTime;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &specificRecevier;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNewCall_Public_PhoneCall_Telephone_Telephone_Human_Human_CallSource_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PhoneCall>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void OnPlayerCalls()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPlayerCalls_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 96362, RefRangeEnd = 96368, XrefRangeStart = 96358, XrefRangeEnd = 96362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFakeNumber(int number, CallSource source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&number);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFakeNumber_Public_Void_Int32_CallSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 96373, RefRangeEnd = 96377, XrefRangeStart = 96368, XrefRangeEnd = 96373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFakeNumber(int number)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&number);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFakeNumber_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96377, XrefRangeEnd = 96402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddActiveCall(PhoneCall newCall)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newCall);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddActiveCall_Public_Void_PhoneCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96421, RefRangeEnd = 96422, XrefRangeStart = 96402, XrefRangeEnd = 96421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveActiveCall(PhoneCall newCall)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newCall);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveActiveCall_Public_Void_PhoneCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96422, XrefRangeEnd = 96453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96453, XrefRangeEnd = 96498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindTelephoneByNumber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindTelephoneByNumber_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96498, XrefRangeEnd = 96550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindTelephonesAtPlayerLocation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindTelephonesAtPlayerLocation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96550, XrefRangeEnd = 96569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TelephoneController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TelephoneController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TelephoneController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
