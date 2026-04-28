using System;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

[System.Serializable]
public class Telephone : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_number;

	private static readonly System.IntPtr NativeFieldInfoPtr_numberString;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeCall;

	private static readonly System.IntPtr NativeFieldInfoPtr_setup;

	private static readonly System.IntPtr NativeFieldInfoPtr_location;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactable;

	private static readonly System.IntPtr NativeFieldInfoPtr_speechController;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeReceiver;

	private static readonly System.IntPtr NativeFieldInfoPtr_dialTone;

	private static readonly System.IntPtr NativeFieldInfoPtr_engaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_locationEntry;

	private static readonly System.IntPtr NativeFieldInfoPtr_telephoneEntry;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Interactable_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadTelephoneNumber_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateTelephoneNumber_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputCode_Public_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateEvidence_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StopActiveCall_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveCall_Public_Void_PhoneCall_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTelephoneAnswered_Public_Void_Human_0;

	public unsafe int number
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_number);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_number)) = num;
		}
	}

	public unsafe string numberString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numberString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numberString)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<TelephoneController.PhoneCall> activeCall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeCall);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TelephoneController.PhoneCall>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeCall)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool setup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setup)) = flag;
		}
	}

	public unsafe NewGameLocation location
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewGameLocation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newGameLocation));
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

	public unsafe SpeechController speechController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speechController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpeechController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speechController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)speechController));
		}
	}

	public unsafe Human activeReceiver
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeReceiver);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeReceiver)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
		}
	}

	public unsafe AudioController.LoopingSoundInfo dialTone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialTone);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioController.LoopingSoundInfo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialTone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loopingSoundInfo));
		}
	}

	public unsafe EventInstance engaged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engaged);
			return *(EventInstance*)num;
		}
		set
		{
			*(EventInstance*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_engaged)) = eventInstance;
		}
	}

	public unsafe EvidenceLocation locationEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationEntry);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EvidenceLocation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationEntry)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evidenceLocation));
		}
	}

	public unsafe EvidenceTelephone telephoneEntry
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telephoneEntry);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EvidenceTelephone>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telephoneEntry)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evidenceTelephone));
		}
	}

	static Telephone()
	{
		Il2CppClassPointerStore<Telephone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Telephone");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Telephone>.NativeClassPtr);
		NativeFieldInfoPtr_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Telephone>.NativeClassPtr, "number");
		NativeFieldInfoPtr_numberString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Telephone>.NativeClassPtr, "numberString");
		NativeFieldInfoPtr_activeCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Telephone>.NativeClassPtr, "activeCall");
		NativeFieldInfoPtr_setup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Telephone>.NativeClassPtr, "setup");
		NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Telephone>.NativeClassPtr, "location");
		NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Telephone>.NativeClassPtr, "interactable");
		NativeFieldInfoPtr_speechController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Telephone>.NativeClassPtr, "speechController");
		NativeFieldInfoPtr_activeReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Telephone>.NativeClassPtr, "activeReceiver");
		NativeFieldInfoPtr_dialTone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Telephone>.NativeClassPtr, "dialTone");
		NativeFieldInfoPtr_engaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Telephone>.NativeClassPtr, "engaged");
		NativeFieldInfoPtr_locationEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Telephone>.NativeClassPtr, "locationEntry");
		NativeFieldInfoPtr_telephoneEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Telephone>.NativeClassPtr, "telephoneEntry");
		NativeMethodInfoPtr__ctor_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Telephone>.NativeClassPtr, 100669248);
		NativeMethodInfoPtr__ctor_Public_Void_Interactable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Telephone>.NativeClassPtr, 100669249);
		NativeMethodInfoPtr_LoadTelephoneNumber_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Telephone>.NativeClassPtr, 100669250);
		NativeMethodInfoPtr_GenerateTelephoneNumber_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Telephone>.NativeClassPtr, 100669251);
		NativeMethodInfoPtr_GetInputCode_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Telephone>.NativeClassPtr, 100669252);
		NativeMethodInfoPtr_CreateEvidence_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Telephone>.NativeClassPtr, 100669253);
		NativeMethodInfoPtr_StopActiveCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Telephone>.NativeClassPtr, 100669254);
		NativeMethodInfoPtr_SetActiveCall_Public_Void_PhoneCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Telephone>.NativeClassPtr, 100669255);
		NativeMethodInfoPtr_SetTelephoneAnswered_Public_Void_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Telephone>.NativeClassPtr, 100669256);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201283, RefRangeEnd = 201284, XrefRangeStart = 201270, XrefRangeEnd = 201283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Telephone(Interactable newTelephone)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Telephone>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTelephone);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201297, RefRangeEnd = 201298, XrefRangeStart = 201284, XrefRangeEnd = 201297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Telephone(Interactable newTelephone, int newNumber)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Telephone>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newTelephone);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newNumber;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Interactable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201311, RefRangeEnd = 201312, XrefRangeStart = 201298, XrefRangeEnd = 201311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadTelephoneNumber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadTelephoneNumber_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201334, RefRangeEnd = 201335, XrefRangeStart = 201312, XrefRangeEnd = 201334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateTelephoneNumber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateTelephoneNumber_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201359, RefRangeEnd = 201360, XrefRangeStart = 201335, XrefRangeEnd = 201359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> GetInputCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputCode_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 201385, RefRangeEnd = 201387, XrefRangeStart = 201360, XrefRangeEnd = 201385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateEvidence()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateEvidence_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 201393, RefRangeEnd = 201394, XrefRangeStart = 201387, XrefRangeEnd = 201393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopActiveCall()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StopActiveCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201394, XrefRangeEnd = 201422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActiveCall(TelephoneController.PhoneCall newCall)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newCall);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveCall_Public_Void_PhoneCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 201509, RefRangeEnd = 201512, XrefRangeStart = 201422, XrefRangeEnd = 201509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTelephoneAnswered(Human val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTelephoneAnswered_Public_Void_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Telephone(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
