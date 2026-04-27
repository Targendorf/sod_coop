using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

public class StatusController : MonoBehaviour
{
	[System.Serializable]
	public class FineRecord : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_addressID;

		private static readonly System.IntPtr NativeFieldInfoPtr_objectID;

		private static readonly System.IntPtr NativeFieldInfoPtr_crime;

		private static readonly System.IntPtr NativeFieldInfoPtr_confirmed;

		private static readonly System.IntPtr NativeFieldInfoPtr_forcedPenalty;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NewAddress_Interactable_CrimeType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetConfirmed_Public_Void_Boolean_0;

		public unsafe int addressID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addressID)) = num;
			}
		}

		public unsafe int objectID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectID)) = num;
			}
		}

		public unsafe CrimeType crime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crime);
				return *(CrimeType*)num;
			}
			set
			{
				*(CrimeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crime)) = crimeType;
			}
		}

		public unsafe bool confirmed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confirmed);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confirmed)) = flag;
			}
		}

		public unsafe int forcedPenalty
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedPenalty);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedPenalty)) = num;
			}
		}

		static FineRecord()
		{
			Il2CppClassPointerStore<FineRecord>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "FineRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FineRecord>.NativeClassPtr);
			NativeFieldInfoPtr_addressID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FineRecord>.NativeClassPtr, "addressID");
			NativeFieldInfoPtr_objectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FineRecord>.NativeClassPtr, "objectID");
			NativeFieldInfoPtr_crime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FineRecord>.NativeClassPtr, "crime");
			NativeFieldInfoPtr_confirmed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FineRecord>.NativeClassPtr, "confirmed");
			NativeFieldInfoPtr_forcedPenalty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FineRecord>.NativeClassPtr, "forcedPenalty");
			NativeMethodInfoPtr__ctor_Public_Void_NewAddress_Interactable_CrimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FineRecord>.NativeClassPtr, 100672588);
			NativeMethodInfoPtr_SetConfirmed_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FineRecord>.NativeClassPtr, 100672589);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298240, XrefRangeEnd = 298251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FineRecord(NewAddress ad, Interactable obj, CrimeType newCrime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FineRecord>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ad);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			*(CrimeType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newCrime;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NewAddress_Interactable_CrimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void SetConfirmed(bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&val);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConfirmed_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FineRecord(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum CrimeType
	{
		assault,
		theft,
		breakingAndEntering,
		trespassing,
		tampering,
		vandalism
	}

	public sealed class StatusInstance : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_building;

		private static readonly System.IntPtr NativeFieldInfoPtr_address;

		public unsafe StatusPreset preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatusPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusPreset));
			}
		}

		public unsafe NewBuilding building
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_building);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewBuilding>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_building)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newBuilding));
			}
		}

		public unsafe NewAddress address
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_address);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAddress>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_address)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAddress));
			}
		}

		static StatusInstance()
		{
			Il2CppClassPointerStore<StatusInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "StatusInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusInstance>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusInstance>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_building = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusInstance>.NativeClassPtr, "building");
			NativeFieldInfoPtr_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusInstance>.NativeClassPtr, "address");
		}

		public StatusInstance(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public StatusInstance()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusInstance>.NativeClassPtr))
		{
		}
	}

	public class StatusCount : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_statusInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_statusCountConfig;

		private static readonly System.IntPtr NativeFieldInfoPtr_fineRecord;

		private static readonly System.IntPtr NativeFieldInfoPtr_amount;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_StatusInstance_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_StatusInstance_StatusCountConfig_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPenaltyAmount_Public_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__5_0_Private_Boolean_StateElementController_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__6_0_Private_Boolean_StateElementController_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Remove_b__7_0_Private_Boolean_StateElementController_0;

		public unsafe StatusInstance statusInstance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusInstance);
				return new StatusInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatusInstance>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusInstance)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StatusInstance>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe StatusPreset preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatusPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusPreset));
			}
		}

		public unsafe StatusPreset.StatusCountConfig statusCountConfig
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusCountConfig);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatusPreset.StatusCountConfig>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusCountConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusCountConfig));
			}
		}

		public unsafe FineRecord fineRecord
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fineRecord);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FineRecord>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fineRecord)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fineRecord));
			}
		}

		public unsafe float amount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amount);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amount)) = num;
			}
		}

		static StatusCount()
		{
			Il2CppClassPointerStore<StatusCount>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "StatusCount");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusCount>.NativeClassPtr);
			NativeFieldInfoPtr_statusInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusCount>.NativeClassPtr, "statusInstance");
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusCount>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_statusCountConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusCount>.NativeClassPtr, "statusCountConfig");
			NativeFieldInfoPtr_fineRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusCount>.NativeClassPtr, "fineRecord");
			NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusCount>.NativeClassPtr, "amount");
			NativeMethodInfoPtr__ctor_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusCount>.NativeClassPtr, 100672590);
			NativeMethodInfoPtr__ctor_Public_Void_StatusInstance_StatusCountConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusCount>.NativeClassPtr, 100672591);
			NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusCount>.NativeClassPtr, 100672592);
			NativeMethodInfoPtr_GetPenaltyAmount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusCount>.NativeClassPtr, 100672593);
			NativeMethodInfoPtr___ctor_b__5_0_Private_Boolean_StateElementController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusCount>.NativeClassPtr, 100672594);
			NativeMethodInfoPtr___ctor_b__6_0_Private_Boolean_StateElementController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusCount>.NativeClassPtr, 100672595);
			NativeMethodInfoPtr__Remove_b__7_0_Private_Boolean_StateElementController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusCount>.NativeClassPtr, 100672596);
		}

		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 298345, RefRangeEnd = 298371, XrefRangeStart = 298251, XrefRangeEnd = 298345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusCount(StatusInstance newInstance)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusCount>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)newInstance));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298470, RefRangeEnd = 298472, XrefRangeStart = 298371, XrefRangeEnd = 298470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusCount(StatusInstance newInstance, StatusPreset.StatusCountConfig newConfig)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusCount>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)newInstance));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newConfig);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_StatusInstance_StatusCountConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298543, RefRangeEnd = 298545, XrefRangeStart = 298472, XrefRangeEnd = 298543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298546, RefRangeEnd = 298548, XrefRangeStart = 298545, XrefRangeEnd = 298546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPenaltyAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPenaltyAmount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298548, XrefRangeEnd = 298574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool __ctor_b__5_0(StateElementController item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__5_0_Private_Boolean_StateElementController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298574, XrefRangeEnd = 298600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool __ctor_b__6_0(StateElementController item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__6_0_Private_Boolean_StateElementController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298600, XrefRangeEnd = 298626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Remove_b__7_0(StateElementController item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Remove_b__7_0_Private_Boolean_StateElementController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public StatusCount(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("StatusController+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__51_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__56_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__57_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__67_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__67_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__51_0_Internal_Int32_StatusPreset_StatusPreset_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ForceStatusCheck_b__56_0_Internal_Int32_StateElementController_StateElementController_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__57_0_Internal_Int32_StateElementController_StateElementController_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Trespassing_b__67_1_Internal_Boolean_FineRecord_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Trespassing_b__67_0_Internal_Boolean_FineRecord_0;

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

		public unsafe static Il2CppSystem.Comparison<StatusPreset> __9__51_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<StatusPreset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__51_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<StateElementController> __9__56_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__56_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<StateElementController>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__56_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<StateElementController> __9__57_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__57_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<StateElementController>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__57_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<FineRecord> __9__67_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__67_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<FineRecord>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__67_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<FineRecord> __9__67_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__67_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<FineRecord>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__67_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__51_0");
			NativeFieldInfoPtr___9__56_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__56_0");
			NativeFieldInfoPtr___9__57_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__57_0");
			NativeFieldInfoPtr___9__67_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__67_1");
			NativeFieldInfoPtr___9__67_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__67_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100672598);
			NativeMethodInfoPtr__Start_b__51_0_Internal_Int32_StatusPreset_StatusPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100672599);
			NativeMethodInfoPtr__ForceStatusCheck_b__56_0_Internal_Int32_StateElementController_StateElementController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100672600);
			NativeMethodInfoPtr__Update_b__57_0_Internal_Int32_StateElementController_StateElementController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100672601);
			NativeMethodInfoPtr__Trespassing_b__67_1_Internal_Boolean_FineRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100672602);
			NativeMethodInfoPtr__Trespassing_b__67_0_Internal_Boolean_FineRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100672603);
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
		public unsafe int _Start_b__51_0(StatusPreset p2, StatusPreset p1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Start_b__51_0_Internal_Int32_StatusPreset_StatusPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _ForceStatusCheck_b__56_0(StateElementController p2, StateElementController p1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ForceStatusCheck_b__56_0_Internal_Int32_StateElementController_StateElementController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _Update_b__57_0(StateElementController p2, StateElementController p1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Update_b__57_0_Internal_Int32_StateElementController_StateElementController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _Trespassing_b__67_1(FineRecord item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Trespassing_b__67_1_Internal_Boolean_FineRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _Trespassing_b__67_0(FineRecord item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Trespassing_b__67_0_Internal_Boolean_FineRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("StatusController+<>c__DisplayClass58_0")]
	public sealed class __c__DisplayClass58_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ignoreDuplicates;

		private static readonly System.IntPtr NativeFieldInfoPtr_address;

		private static readonly System.IntPtr NativeFieldInfoPtr_crime;

		private static readonly System.IntPtr NativeFieldInfoPtr_obj;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddFineRecord_b__0_Internal_Boolean_FineRecord_0;

		public unsafe bool ignoreDuplicates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreDuplicates);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreDuplicates)) = flag;
			}
		}

		public unsafe NewAddress address
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_address);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAddress>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_address)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAddress));
			}
		}

		public unsafe CrimeType crime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crime);
				return *(CrimeType*)num;
			}
			set
			{
				*(CrimeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crime)) = crimeType;
			}
		}

		public unsafe Interactable obj
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obj);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
			}
		}

		static __c__DisplayClass58_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "<>c__DisplayClass58_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr);
			NativeFieldInfoPtr_ignoreDuplicates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr, "ignoreDuplicates");
			NativeFieldInfoPtr_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr, "address");
			NativeFieldInfoPtr_crime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr, "crime");
			NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr, "obj");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr, 100672604);
			NativeMethodInfoPtr__AddFineRecord_b__0_Internal_Boolean_FineRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr, 100672605);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass58_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass58_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298626, XrefRangeEnd = 298647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _AddFineRecord_b__0(FineRecord item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddFineRecord_b__0_Internal_Boolean_FineRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass58_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("StatusController+<>c__DisplayClass59_0")]
	public sealed class __c__DisplayClass59_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_matchAddress;

		private static readonly System.IntPtr NativeFieldInfoPtr_address;

		private static readonly System.IntPtr NativeFieldInfoPtr_crime;

		private static readonly System.IntPtr NativeFieldInfoPtr_obj;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveFineRecord_b__0_Internal_Boolean_FineRecord_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveFineRecord_b__1_Internal_Boolean_FineRecord_0;

		public unsafe bool matchAddress
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchAddress);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matchAddress)) = flag;
			}
		}

		public unsafe NewAddress address
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_address);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAddress>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_address)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAddress));
			}
		}

		public unsafe CrimeType crime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crime);
				return *(CrimeType*)num;
			}
			set
			{
				*(CrimeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crime)) = crimeType;
			}
		}

		public unsafe Interactable obj
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obj);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
			}
		}

		static __c__DisplayClass59_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "<>c__DisplayClass59_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr);
			NativeFieldInfoPtr_matchAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr, "matchAddress");
			NativeFieldInfoPtr_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr, "address");
			NativeFieldInfoPtr_crime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr, "crime");
			NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr, "obj");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr, 100672606);
			NativeMethodInfoPtr__RemoveFineRecord_b__0_Internal_Boolean_FineRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr, 100672607);
			NativeMethodInfoPtr__RemoveFineRecord_b__1_Internal_Boolean_FineRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr, 100672608);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass59_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass59_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298647, XrefRangeEnd = 298668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RemoveFineRecord_b__0(FineRecord item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveFineRecord_b__0_Internal_Boolean_FineRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298668, XrefRangeEnd = 298689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RemoveFineRecord_b__1(FineRecord item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveFineRecord_b__1_Internal_Boolean_FineRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass59_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("StatusController+<>c__DisplayClass64_0")]
	public sealed class __c__DisplayClass64_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_address;

		private static readonly System.IntPtr NativeFieldInfoPtr_crime;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ConfirmFinesAtLocation_b__0_Internal_Boolean_FineRecord_0;

		public unsafe NewAddress address
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_address);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAddress>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_address)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAddress));
			}
		}

		public unsafe CrimeType crime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crime);
				return *(CrimeType*)num;
			}
			set
			{
				*(CrimeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crime)) = crimeType;
			}
		}

		static __c__DisplayClass64_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "<>c__DisplayClass64_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr);
			NativeFieldInfoPtr_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr, "address");
			NativeFieldInfoPtr_crime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr, "crime");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr, 100672609);
			NativeMethodInfoPtr__ConfirmFinesAtLocation_b__0_Internal_Boolean_FineRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr, 100672610);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass64_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass64_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298689, XrefRangeEnd = 298710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ConfirmFinesAtLocation_b__0(FineRecord item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ConfirmFinesAtLocation_b__0_Internal_Boolean_FineRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass64_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("StatusController+<>c__DisplayClass65_0")]
	public sealed class __c__DisplayClass65_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_address;

		private static readonly System.IntPtr NativeFieldInfoPtr_crime;

		private static readonly System.IntPtr NativeFieldInfoPtr_obj;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ConfirmFine_b__0_Internal_Boolean_FineRecord_0;

		public unsafe NewAddress address
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_address);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewAddress>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_address)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAddress));
			}
		}

		public unsafe CrimeType crime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crime);
				return *(CrimeType*)num;
			}
			set
			{
				*(CrimeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crime)) = crimeType;
			}
		}

		public unsafe Interactable obj
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obj);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_obj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
			}
		}

		static __c__DisplayClass65_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "<>c__DisplayClass65_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr);
			NativeFieldInfoPtr_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr, "address");
			NativeFieldInfoPtr_crime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr, "crime");
			NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr, "obj");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr, 100672611);
			NativeMethodInfoPtr__ConfirmFine_b__0_Internal_Boolean_FineRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr, 100672612);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass65_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass65_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298710, XrefRangeEnd = 298731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ConfirmFine_b__0(FineRecord item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ConfirmFine_b__0_Internal_Boolean_FineRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass65_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("StatusController+<>c__DisplayClass66_0")]
	public sealed class __c__DisplayClass66_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_count;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PayActiveFines_b__0_Internal_Boolean_InventorySlot_0;

		public unsafe StatusCount count
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatusCount>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusCount));
			}
		}

		static __c__DisplayClass66_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "<>c__DisplayClass66_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr);
			NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr, "count");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr, 100672613);
			NativeMethodInfoPtr__PayActiveFines_b__0_Internal_Boolean_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr, 100672614);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass66_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass66_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _PayActiveFines_b__0(FirstPersonItemController.InventorySlot item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PayActiveFines_b__0_Internal_Boolean_InventorySlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass66_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("StatusController+<>c__DisplayClass70_0")]
	public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_f;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CaptureRisk_b__0_Internal_Boolean_StatusCountConfig_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__CaptureRisk_b__1_Internal_Boolean_StatusCount_0;

		public unsafe FineRecord f
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FineRecord>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fineRecord));
			}
		}

		static __c__DisplayClass70_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "<>c__DisplayClass70_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr);
			NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr, "f");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr, 100672615);
			NativeMethodInfoPtr__CaptureRisk_b__0_Internal_Boolean_StatusCountConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr, 100672616);
			NativeMethodInfoPtr__CaptureRisk_b__1_Internal_Boolean_StatusCount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr, 100672617);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass70_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass70_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298731, XrefRangeEnd = 298735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CaptureRisk_b__0(StatusPreset.StatusCountConfig item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CaptureRisk_b__0_Internal_Boolean_StatusCountConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _CaptureRisk_b__1(StatusCount item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__CaptureRisk_b__1_Internal_Boolean_StatusCount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass70_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_statusParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementDefaultWdith;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementMinimizedWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementDefaultHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementYInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_detailTextFadeInCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_disabledRecovery;

	private static readonly System.IntPtr NativeFieldInfoPtr_disabledSprint;

	private static readonly System.IntPtr NativeFieldInfoPtr_disabledJump;

	private static readonly System.IntPtr NativeFieldInfoPtr_recoveryRateMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHealthMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_movementSpeedMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_temperatureGainMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_damageIncomingMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_damageOutgoingMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkControls;

	private static readonly System.IntPtr NativeFieldInfoPtr_affectHeadBobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkVision;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiverVision;

	private static readonly System.IntPtr NativeFieldInfoPtr_headacheVision;

	private static readonly System.IntPtr NativeFieldInfoPtr_drunkLensDistort;

	private static readonly System.IntPtr NativeFieldInfoPtr_tripChanceWet;

	private static readonly System.IntPtr NativeFieldInfoPtr_tripChanceDrunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_bloomIntensityMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_motionBlurMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_chromaticAbberationAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_vignetteAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_exposureAmount;

	private static readonly System.IntPtr NativeFieldInfoPtr_channelRedR;

	private static readonly System.IntPtr NativeFieldInfoPtr_channelRedG;

	private static readonly System.IntPtr NativeFieldInfoPtr_channelRedB;

	private static readonly System.IntPtr NativeFieldInfoPtr_channelGreenR;

	private static readonly System.IntPtr NativeFieldInfoPtr_channelGreenG;

	private static readonly System.IntPtr NativeFieldInfoPtr_channelGreenB;

	private static readonly System.IntPtr NativeFieldInfoPtr_channelBlueR;

	private static readonly System.IntPtr NativeFieldInfoPtr_channelBlueG;

	private static readonly System.IntPtr NativeFieldInfoPtr_channelBlueB;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnedControllers;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeStatusCounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeStatuses;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeFineRecords;

	private static readonly System.IntPtr NativeFieldInfoPtr_checkingRef;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_StatusController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisplayCheck_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllCounts_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllCounts_Public_Void_StatusPreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceStatusCheck_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceStatusCheck_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFineRecord_Public_Void_NewAddress_Interactable_CrimeType_Boolean_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFineRecord_Public_Void_NewAddress_Interactable_CrimeType_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FineEscapeCheck_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWantedInBuilding_Public_Void_NewBuilding_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDetainedInBuilding_Public_Void_NewBuilding_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentDetainedStatus_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfirmFinesAtLocation_Public_Void_NewAddress_CrimeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfirmFine_Public_Void_NewAddress_Interactable_CrimeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PayActiveFines_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Trespassing_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AlarmActive_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IllegalAction_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CaptureRisk_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImageCaptured_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Wanted_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GuestPass_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Detained_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Echelons_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hiding_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stinky_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cold_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hungry_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Energized_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Thirsty_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hydrated_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Drunk_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sick_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StarchAddiction_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Headache_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Wet_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BrokenLeg_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bruised_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlackEye_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlackedOut_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Numb_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Poisoned_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Blinded_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bleeding_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Tired_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Focused_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pursued_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WellRested_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SyncDiskInstall_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToxicGas_Public_Void_StatusInstance_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RectTransform statusParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe float elementDefaultWdith
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementDefaultWdith);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementDefaultWdith)) = num;
		}
	}

	public unsafe float elementMinimizedWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementMinimizedWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementMinimizedWidth)) = num;
		}
	}

	public unsafe float elementDefaultHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementDefaultHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementDefaultHeight)) = num;
		}
	}

	public unsafe float elementYInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementYInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elementYInterval)) = num;
		}
	}

	public unsafe AnimationCurve detailTextFadeInCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailTextFadeInCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detailTextFadeInCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe bool disabledRecovery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabledRecovery);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabledRecovery)) = flag;
		}
	}

	public unsafe bool disabledSprint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabledSprint);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabledSprint)) = flag;
		}
	}

	public unsafe bool disabledJump
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabledJump);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabledJump)) = flag;
		}
	}

	public unsafe float recoveryRateMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recoveryRateMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recoveryRateMultiplier)) = num;
		}
	}

	public unsafe float maxHealthMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHealthMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHealthMultiplier)) = num;
		}
	}

	public unsafe float movementSpeedMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeedMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementSpeedMultiplier)) = num;
		}
	}

	public unsafe float temperatureGainMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temperatureGainMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_temperatureGainMultiplier)) = num;
		}
	}

	public unsafe float damageIncomingMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageIncomingMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageIncomingMultiplier)) = num;
		}
	}

	public unsafe float damageOutgoingMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageOutgoingMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageOutgoingMultiplier)) = num;
		}
	}

	public unsafe float drunkControls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkControls);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkControls)) = num;
		}
	}

	public unsafe Dictionary<AnimationCurve, float> affectHeadBobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectHeadBobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<AnimationCurve, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affectHeadBobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe float drunkVision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkVision);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkVision)) = num;
		}
	}

	public unsafe float shiverVision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverVision);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiverVision)) = num;
		}
	}

	public unsafe float headacheVision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headacheVision);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headacheVision)) = num;
		}
	}

	public unsafe float drunkLensDistort
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkLensDistort);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drunkLensDistort)) = num;
		}
	}

	public unsafe float tripChanceWet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tripChanceWet);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tripChanceWet)) = num;
		}
	}

	public unsafe float tripChanceDrunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tripChanceDrunk);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tripChanceDrunk)) = num;
		}
	}

	public unsafe float bloomIntensityMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomIntensityMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bloomIntensityMultiplier)) = num;
		}
	}

	public unsafe float motionBlurMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionBlurMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionBlurMultiplier)) = num;
		}
	}

	public unsafe float chromaticAbberationAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chromaticAbberationAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chromaticAbberationAmount)) = num;
		}
	}

	public unsafe float vignetteAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vignetteAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vignetteAmount)) = num;
		}
	}

	public unsafe float exposureAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exposureAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exposureAmount)) = num;
		}
	}

	public unsafe float channelRedR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelRedR);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelRedR)) = num;
		}
	}

	public unsafe float channelRedG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelRedG);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelRedG)) = num;
		}
	}

	public unsafe float channelRedB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelRedB);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelRedB)) = num;
		}
	}

	public unsafe float channelGreenR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelGreenR);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelGreenR)) = num;
		}
	}

	public unsafe float channelGreenG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelGreenG);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelGreenG)) = num;
		}
	}

	public unsafe float channelGreenB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelGreenB);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelGreenB)) = num;
		}
	}

	public unsafe float channelBlueR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelBlueR);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelBlueR)) = num;
		}
	}

	public unsafe float channelBlueG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelBlueG);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelBlueG)) = num;
		}
	}

	public unsafe float channelBlueB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelBlueB);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_channelBlueB)) = num;
		}
	}

	public unsafe List<StateElementController> spawnedControllers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedControllers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StateElementController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedControllers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<StatusInstance, List<StatusCount>> activeStatusCounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeStatusCounts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<StatusInstance, List<StatusCount>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeStatusCounts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe HashSet<StatusPreset> activeStatuses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeStatuses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<StatusPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeStatuses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe List<FineRecord> activeFineRecords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeFineRecords);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FineRecord>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeFineRecords)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<StatusPreset, MethodInfo> checkingRef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkingRef);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<StatusPreset, MethodInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkingRef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static StatusController _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatusController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)statusController));
		}
	}

	public unsafe static StatusController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298735, XrefRangeEnd = 298737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_StatusController_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatusController>(intPtr) : null;
		}
	}

	static StatusController()
	{
		Il2CppClassPointerStore<StatusController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatusController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatusController>.NativeClassPtr);
		NativeFieldInfoPtr_statusParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "statusParent");
		NativeFieldInfoPtr_elementDefaultWdith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "elementDefaultWdith");
		NativeFieldInfoPtr_elementMinimizedWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "elementMinimizedWidth");
		NativeFieldInfoPtr_elementDefaultHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "elementDefaultHeight");
		NativeFieldInfoPtr_elementYInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "elementYInterval");
		NativeFieldInfoPtr_detailTextFadeInCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "detailTextFadeInCurve");
		NativeFieldInfoPtr_disabledRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "disabledRecovery");
		NativeFieldInfoPtr_disabledSprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "disabledSprint");
		NativeFieldInfoPtr_disabledJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "disabledJump");
		NativeFieldInfoPtr_recoveryRateMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "recoveryRateMultiplier");
		NativeFieldInfoPtr_maxHealthMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "maxHealthMultiplier");
		NativeFieldInfoPtr_movementSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "movementSpeedMultiplier");
		NativeFieldInfoPtr_temperatureGainMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "temperatureGainMultiplier");
		NativeFieldInfoPtr_damageIncomingMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "damageIncomingMultiplier");
		NativeFieldInfoPtr_damageOutgoingMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "damageOutgoingMultiplier");
		NativeFieldInfoPtr_drunkControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "drunkControls");
		NativeFieldInfoPtr_affectHeadBobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "affectHeadBobs");
		NativeFieldInfoPtr_drunkVision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "drunkVision");
		NativeFieldInfoPtr_shiverVision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "shiverVision");
		NativeFieldInfoPtr_headacheVision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "headacheVision");
		NativeFieldInfoPtr_drunkLensDistort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "drunkLensDistort");
		NativeFieldInfoPtr_tripChanceWet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "tripChanceWet");
		NativeFieldInfoPtr_tripChanceDrunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "tripChanceDrunk");
		NativeFieldInfoPtr_bloomIntensityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "bloomIntensityMultiplier");
		NativeFieldInfoPtr_motionBlurMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "motionBlurMultiplier");
		NativeFieldInfoPtr_chromaticAbberationAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "chromaticAbberationAmount");
		NativeFieldInfoPtr_vignetteAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "vignetteAmount");
		NativeFieldInfoPtr_exposureAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "exposureAmount");
		NativeFieldInfoPtr_channelRedR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "channelRedR");
		NativeFieldInfoPtr_channelRedG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "channelRedG");
		NativeFieldInfoPtr_channelRedB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "channelRedB");
		NativeFieldInfoPtr_channelGreenR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "channelGreenR");
		NativeFieldInfoPtr_channelGreenG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "channelGreenG");
		NativeFieldInfoPtr_channelGreenB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "channelGreenB");
		NativeFieldInfoPtr_channelBlueR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "channelBlueR");
		NativeFieldInfoPtr_channelBlueG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "channelBlueG");
		NativeFieldInfoPtr_channelBlueB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "channelBlueB");
		NativeFieldInfoPtr_spawnedControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "spawnedControllers");
		NativeFieldInfoPtr_activeStatusCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "activeStatusCounts");
		NativeFieldInfoPtr_activeStatuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "activeStatuses");
		NativeFieldInfoPtr_activeFineRecords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "activeFineRecords");
		NativeFieldInfoPtr_checkingRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "checkingRef");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatusController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_StatusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672533);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672534);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672535);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672536);
		NativeMethodInfoPtr_DisplayCheck_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672537);
		NativeMethodInfoPtr_RemoveAllCounts_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672538);
		NativeMethodInfoPtr_RemoveAllCounts_Public_Void_StatusPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672539);
		NativeMethodInfoPtr_ForceStatusCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672540);
		NativeMethodInfoPtr_ForceStatusCheck_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672541);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672542);
		NativeMethodInfoPtr_AddFineRecord_Public_Void_NewAddress_Interactable_CrimeType_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672543);
		NativeMethodInfoPtr_RemoveFineRecord_Public_Void_NewAddress_Interactable_CrimeType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672544);
		NativeMethodInfoPtr_FineEscapeCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672545);
		NativeMethodInfoPtr_SetWantedInBuilding_Public_Void_NewBuilding_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672546);
		NativeMethodInfoPtr_SetDetainedInBuilding_Public_Void_NewBuilding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672547);
		NativeMethodInfoPtr_GetCurrentDetainedStatus_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672548);
		NativeMethodInfoPtr_ConfirmFinesAtLocation_Public_Void_NewAddress_CrimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672549);
		NativeMethodInfoPtr_ConfirmFine_Public_Void_NewAddress_Interactable_CrimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672550);
		NativeMethodInfoPtr_PayActiveFines_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672551);
		NativeMethodInfoPtr_Trespassing_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672552);
		NativeMethodInfoPtr_AlarmActive_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672553);
		NativeMethodInfoPtr_IllegalAction_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672554);
		NativeMethodInfoPtr_CaptureRisk_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672555);
		NativeMethodInfoPtr_ImageCaptured_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672556);
		NativeMethodInfoPtr_Wanted_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672557);
		NativeMethodInfoPtr_GuestPass_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672558);
		NativeMethodInfoPtr_Detained_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672559);
		NativeMethodInfoPtr_Echelons_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672560);
		NativeMethodInfoPtr_Hiding_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672561);
		NativeMethodInfoPtr_Stinky_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672562);
		NativeMethodInfoPtr_Cold_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672563);
		NativeMethodInfoPtr_Hungry_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672564);
		NativeMethodInfoPtr_Energized_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672565);
		NativeMethodInfoPtr_Thirsty_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672566);
		NativeMethodInfoPtr_Hydrated_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672567);
		NativeMethodInfoPtr_Drunk_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672568);
		NativeMethodInfoPtr_Sick_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672569);
		NativeMethodInfoPtr_StarchAddiction_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672570);
		NativeMethodInfoPtr_Headache_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672571);
		NativeMethodInfoPtr_Wet_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672572);
		NativeMethodInfoPtr_BrokenLeg_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672573);
		NativeMethodInfoPtr_Bruised_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672574);
		NativeMethodInfoPtr_BlackEye_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672575);
		NativeMethodInfoPtr_BlackedOut_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672576);
		NativeMethodInfoPtr_Numb_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672577);
		NativeMethodInfoPtr_Poisoned_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672578);
		NativeMethodInfoPtr_Blinded_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672579);
		NativeMethodInfoPtr_Bleeding_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672580);
		NativeMethodInfoPtr_Tired_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672581);
		NativeMethodInfoPtr_Focused_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672582);
		NativeMethodInfoPtr_Pursued_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672583);
		NativeMethodInfoPtr_WellRested_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672584);
		NativeMethodInfoPtr_SyncDiskInstall_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672585);
		NativeMethodInfoPtr_ToxicGas_Public_Void_StatusInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672586);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusController>.NativeClassPtr, 100672587);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298737, XrefRangeEnd = 298774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298774, XrefRangeEnd = 298795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298795, XrefRangeEnd = 298843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 298857, RefRangeEnd = 298858, XrefRangeStart = 298843, XrefRangeEnd = 298857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisplayCheck_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 298886, RefRangeEnd = 298898, XrefRangeStart = 298858, XrefRangeEnd = 298886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAllCounts(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAllCounts_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 298947, RefRangeEnd = 298948, XrefRangeStart = 298898, XrefRangeEnd = 298947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAllCounts(StatusPreset preset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preset);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveAllCounts_Public_Void_StatusPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 298949, RefRangeEnd = 298950, XrefRangeStart = 298948, XrefRangeEnd = 298949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceStatusCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceStatusCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 299212, RefRangeEnd = 299240, XrefRangeStart = 298950, XrefRangeEnd = 299212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceStatusCheck(bool bypassKOCheck = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bypassKOCheck);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceStatusCheck_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299240, XrefRangeEnd = 299413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 299554, RefRangeEnd = 299570, XrefRangeStart = 299413, XrefRangeEnd = 299554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFineRecord(NewAddress address, Interactable obj, CrimeType crime, bool confirm = false, int forcedPenalty = -1, bool ignoreDuplicates = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)address);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(CrimeType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &crime;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &confirm;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedPenalty;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreDuplicates;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFineRecord_Public_Void_NewAddress_Interactable_CrimeType_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 299587, RefRangeEnd = 299596, XrefRangeStart = 299570, XrefRangeEnd = 299587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFineRecord(NewAddress address, Interactable obj, CrimeType crime, bool onlyUnconfirmed = false, bool matchAddress = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)address);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(CrimeType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &crime;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &onlyUnconfirmed;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &matchAddress;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFineRecord_Public_Void_NewAddress_Interactable_CrimeType_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 299658, RefRangeEnd = 299660, XrefRangeStart = 299596, XrefRangeEnd = 299658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FineEscapeCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FineEscapeCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 299672, RefRangeEnd = 299674, XrefRangeStart = 299660, XrefRangeEnd = 299672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWantedInBuilding(NewBuilding b, float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWantedInBuilding_Public_Void_NewBuilding_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 299712, RefRangeEnd = 299714, XrefRangeStart = 299674, XrefRangeEnd = 299712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDetainedInBuilding(NewBuilding b, bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDetainedInBuilding_Public_Void_NewBuilding_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 299753, RefRangeEnd = 299755, XrefRangeStart = 299714, XrefRangeEnd = 299753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetCurrentDetainedStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentDetainedStatus_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299755, XrefRangeEnd = 299782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfirmFinesAtLocation(NewAddress address, CrimeType crime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)address);
		*(CrimeType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &crime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfirmFinesAtLocation_Public_Void_NewAddress_CrimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 299797, RefRangeEnd = 299800, XrefRangeStart = 299782, XrefRangeEnd = 299797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfirmFine(NewAddress address, Interactable obj, CrimeType crime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)address);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(CrimeType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &crime;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfirmFine_Public_Void_NewAddress_Interactable_CrimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 299884, RefRangeEnd = 299885, XrefRangeStart = 299800, XrefRangeEnd = 299884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PayActiveFines()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PayActiveFines_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299885, XrefRangeEnd = 299913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Trespassing(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trespassing_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299913, XrefRangeEnd = 299962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AlarmActive(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlarmActive_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299962, XrefRangeEnd = 299966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IllegalAction(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IllegalAction_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299966, XrefRangeEnd = 300067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CaptureRisk(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaptureRisk_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300067, XrefRangeEnd = 300078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ImageCaptured(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImageCaptured_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300078, XrefRangeEnd = 300104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Wanted(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Wanted_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300104, XrefRangeEnd = 300135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GuestPass(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GuestPass_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300135, XrefRangeEnd = 300167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Detained(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Detained_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300167, XrefRangeEnd = 300213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Echelons(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Echelons_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300213, XrefRangeEnd = 300219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hiding(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hiding_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300219, XrefRangeEnd = 300234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stinky(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stinky_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300234, XrefRangeEnd = 300256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cold(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cold_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300256, XrefRangeEnd = 300268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hungry(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hungry_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300268, XrefRangeEnd = 300280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Energized(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Energized_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300280, XrefRangeEnd = 300292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Thirsty(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Thirsty_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300292, XrefRangeEnd = 300304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hydrated(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hydrated_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300304, XrefRangeEnd = 300316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Drunk(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Drunk_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300316, XrefRangeEnd = 300335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Sick(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sick_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300335, XrefRangeEnd = 300347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StarchAddiction(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StarchAddiction_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300347, XrefRangeEnd = 300359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Headache(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Headache_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300359, XrefRangeEnd = 300371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Wet(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Wet_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300371, XrefRangeEnd = 300383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BrokenLeg(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BrokenLeg_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300383, XrefRangeEnd = 300395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Bruised(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bruised_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300395, XrefRangeEnd = 300407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlackEye(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlackEye_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300407, XrefRangeEnd = 300414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlackedOut(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlackedOut_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300414, XrefRangeEnd = 300426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Numb(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Numb_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300426, XrefRangeEnd = 300438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Poisoned(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Poisoned_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300438, XrefRangeEnd = 300450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Blinded(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Blinded_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300450, XrefRangeEnd = 300462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Bleeding(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bleeding_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300462, XrefRangeEnd = 300490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Tired(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Tired_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300490, XrefRangeEnd = 300502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Focused(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Focused_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300502, XrefRangeEnd = 300509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pursued(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pursued_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300509, XrefRangeEnd = 300521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WellRested(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WellRested_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300521, XrefRangeEnd = 300528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SyncDiskInstall(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncDiskInstall_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300528, XrefRangeEnd = 300535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToxicGas(StatusInstance inst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)inst));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToxicGas_Public_Void_StatusInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300535, XrefRangeEnd = 300570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StatusController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StatusController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
