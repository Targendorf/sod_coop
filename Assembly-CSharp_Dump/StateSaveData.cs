using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StateSaveData : Il2CppSystem.Object
{
	[System.Serializable]
	public class CrimeSceneCleanup : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_isStreet;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool isStreet
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStreet);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStreet)) = flag;
			}
		}

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		static CrimeSceneCleanup()
		{
			Il2CppClassPointerStore<CrimeSceneCleanup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "CrimeSceneCleanup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrimeSceneCleanup>.NativeClassPtr);
			NativeFieldInfoPtr_isStreet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeSceneCleanup>.NativeClassPtr, "isStreet");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrimeSceneCleanup>.NativeClassPtr, "id");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrimeSceneCleanup>.NativeClassPtr, 100670344);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrimeSceneCleanup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrimeSceneCleanup>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CrimeSceneCleanup(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class BrokenWindowSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pos;

		private static readonly System.IntPtr NativeFieldInfoPtr_brokenAt;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3 pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector;
			}
		}

		public unsafe float brokenAt
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenAt);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenAt)) = num;
			}
		}

		static BrokenWindowSave()
		{
			Il2CppClassPointerStore<BrokenWindowSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "BrokenWindowSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrokenWindowSave>.NativeClassPtr);
			NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrokenWindowSave>.NativeClassPtr, "pos");
			NativeFieldInfoPtr_brokenAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrokenWindowSave>.NativeClassPtr, "brokenAt");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrokenWindowSave>.NativeClassPtr, 100670345);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrokenWindowSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrokenWindowSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BrokenWindowSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ScannedObjPrint : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_objID;

		private static readonly System.IntPtr NativeFieldInfoPtr_prints;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int objID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objID)) = num;
			}
		}

		public unsafe List<int> prints
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prints);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static ScannedObjPrint()
		{
			Il2CppClassPointerStore<ScannedObjPrint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "ScannedObjPrint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScannedObjPrint>.NativeClassPtr);
			NativeFieldInfoPtr_objID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScannedObjPrint>.NativeClassPtr, "objID");
			NativeFieldInfoPtr_prints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScannedObjPrint>.NativeClassPtr, "prints");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScannedObjPrint>.NativeClassPtr, 100670346);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScannedObjPrint()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScannedObjPrint>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ScannedObjPrint(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ChaperStateSave : Il2CppSystem.Object
	{
		[ObfuscatedName("StateSaveData+ChaperStateSave+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_reference;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetDataInt_b__0_Internal_Boolean_ChapterSaveData_0;

			public unsafe string reference
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reference);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reference)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr);
				NativeFieldInfoPtr_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, "reference");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100670356);
				NativeMethodInfoPtr__GetDataInt_b__0_Internal_Boolean_ChapterSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass6_0>.NativeClassPtr, 100670357);
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
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDataInt_b__0(ChapterSaveData item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetDataInt_b__0_Internal_Boolean_ChapterSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass6_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("StateSaveData+ChaperStateSave+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_reference;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetDataFloat_b__0_Internal_Boolean_ChapterSaveData_0;

			public unsafe string reference
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reference);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reference)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr);
				NativeFieldInfoPtr_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, "reference");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100670358);
				NativeMethodInfoPtr__GetDataFloat_b__0_Internal_Boolean_ChapterSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr, 100670359);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass7_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDataFloat_b__0(ChapterSaveData item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetDataFloat_b__0_Internal_Boolean_ChapterSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass7_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("StateSaveData+ChaperStateSave+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_reference;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__GetDataString_b__0_Internal_Boolean_ChapterSaveData_0;

			public unsafe string reference
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reference);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reference)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr);
				NativeFieldInfoPtr_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, "reference");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, 100670360);
				NativeMethodInfoPtr__GetDataString_b__0_Internal_Boolean_ChapterSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr, 100670361);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass8_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDataString_b__0(ChapterSaveData item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetDataString_b__0_Internal_Boolean_ChapterSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass8_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddData_Public_Void_String_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddData_Public_Void_String_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddData_Public_Void_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddData_Public_Void_String_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDataBool_Public_Boolean_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDataInt_Public_Int32_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDataFloat_Public_Single_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDataString_Public_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe List<ChapterSaveData> data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ChapterSaveData>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static ChaperStateSave()
		{
			Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "ChaperStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr, "data");
			NativeMethodInfoPtr_AddData_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr, 100670347);
			NativeMethodInfoPtr_AddData_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr, 100670348);
			NativeMethodInfoPtr_AddData_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr, 100670349);
			NativeMethodInfoPtr_AddData_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr, 100670350);
			NativeMethodInfoPtr_GetDataBool_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr, 100670351);
			NativeMethodInfoPtr_GetDataInt_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr, 100670352);
			NativeMethodInfoPtr_GetDataFloat_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr, 100670353);
			NativeMethodInfoPtr_GetDataString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr, 100670354);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr, 100670355);
		}

		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 241503, RefRangeEnd = 241552, XrefRangeStart = 241495, XrefRangeEnd = 241503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(string reference, int integer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reference);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &integer;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddData_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 241564, RefRangeEnd = 241569, XrefRangeStart = 241552, XrefRangeEnd = 241564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(string reference, float floatP)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reference);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &floatP;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddData_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241569, XrefRangeEnd = 241576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(string reference, string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reference);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddData_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241576, XrefRangeEnd = 241577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(string reference, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reference);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddData_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241577, XrefRangeEnd = 241578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetDataBool(string reference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reference);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDataBool_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 241596, RefRangeEnd = 241624, XrefRangeStart = 241578, XrefRangeEnd = 241596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDataInt(string reference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reference);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDataInt_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 241640, RefRangeEnd = 241645, XrefRangeStart = 241624, XrefRangeEnd = 241640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDataFloat(string reference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reference);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDataFloat_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241645, XrefRangeEnd = 241659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDataString(string reference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reference);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDataString_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241659, XrefRangeEnd = 241665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChaperStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChaperStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ChaperStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ChapterSaveData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_reference;

		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string reference
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reference);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reference)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static ChapterSaveData()
		{
			Il2CppClassPointerStore<ChapterSaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "ChapterSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChapterSaveData>.NativeClassPtr);
			NativeFieldInfoPtr_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterSaveData>.NativeClassPtr, "reference");
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterSaveData>.NativeClassPtr, "data");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChapterSaveData>.NativeClassPtr, 100670362);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChapterSaveData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChapterSaveData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ChapterSaveData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class EvidenceStateSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_dds;

		private static readonly System.IntPtr NativeFieldInfoPtr_found;

		private static readonly System.IntPtr NativeFieldInfoPtr_keyTies;

		private static readonly System.IntPtr NativeFieldInfoPtr_discovery;

		private static readonly System.IntPtr NativeFieldInfoPtr_fs;

		private static readonly System.IntPtr NativeFieldInfoPtr_n;

		private static readonly System.IntPtr NativeFieldInfoPtr_customName;

		private static readonly System.IntPtr NativeFieldInfoPtr_mpContent;

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

		public unsafe bool found
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_found);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_found)) = flag;
			}
		}

		public unsafe List<EvidenceDataKeyTie> keyTies
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyTies);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EvidenceDataKeyTie>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyTies)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<Evidence.Discovery> discovery
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discovery);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.Discovery>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_discovery)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool fs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fs);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fs)) = flag;
			}
		}

		public unsafe string n
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_n);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_n)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe List<Evidence.CustomName> customName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customName);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.CustomName>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customName)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<EvidenceMultiPage.MultiPageContent> mpContent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mpContent);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EvidenceMultiPage.MultiPageContent>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mpContent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static EvidenceStateSave()
		{
			Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "EvidenceStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_dds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, "dds");
			NativeFieldInfoPtr_found = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, "found");
			NativeFieldInfoPtr_keyTies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, "keyTies");
			NativeFieldInfoPtr_discovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, "discovery");
			NativeFieldInfoPtr_fs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, "fs");
			NativeFieldInfoPtr_n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, "n");
			NativeFieldInfoPtr_customName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, "customName");
			NativeFieldInfoPtr_mpContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, "mpContent");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr, 100670363);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241689, RefRangeEnd = 241690, XrefRangeStart = 241665, XrefRangeEnd = 241689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EvidenceStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvidenceStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public EvidenceStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class EvidenceDataKeyTie : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_key;

		private static readonly System.IntPtr NativeFieldInfoPtr_tied;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

		public unsafe List<Evidence.DataKey> tied
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tied);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Evidence.DataKey>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tied)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static EvidenceDataKeyTie()
		{
			Il2CppClassPointerStore<EvidenceDataKeyTie>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "EvidenceDataKeyTie");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvidenceDataKeyTie>.NativeClassPtr);
			NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceDataKeyTie>.NativeClassPtr, "key");
			NativeFieldInfoPtr_tied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvidenceDataKeyTie>.NativeClassPtr, "tied");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvidenceDataKeyTie>.NativeClassPtr, 100670364);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241696, RefRangeEnd = 241697, XrefRangeStart = 241690, XrefRangeEnd = 241696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EvidenceDataKeyTie()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvidenceDataKeyTie>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public EvidenceDataKeyTie(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class FakeTelephone : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_number;

		private static readonly System.IntPtr NativeFieldInfoPtr_source;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

		public unsafe TelephoneController.CallSource source
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TelephoneController.CallSource>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_source)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callSource));
			}
		}

		static FakeTelephone()
		{
			Il2CppClassPointerStore<FakeTelephone>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "FakeTelephone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeTelephone>.NativeClassPtr);
			NativeFieldInfoPtr_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTelephone>.NativeClassPtr, "number");
			NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeTelephone>.NativeClassPtr, "source");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeTelephone>.NativeClassPtr, 100670365);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FakeTelephone()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeTelephone>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FakeTelephone(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class BuildingStateSav : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_alarmActive;

		private static readonly System.IntPtr NativeFieldInfoPtr_alarmTimer;

		private static readonly System.IntPtr NativeFieldInfoPtr_targetMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_targetModeSetAt;

		private static readonly System.IntPtr NativeFieldInfoPtr_targets;

		private static readonly System.IntPtr NativeFieldInfoPtr_wanted;

		private static readonly System.IntPtr NativeFieldInfoPtr_elevators;

		private static readonly System.IntPtr NativeFieldInfoPtr_callLog;

		private static readonly System.IntPtr NativeFieldInfoPtr_lostAndFound;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe bool alarmActive
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alarmActive);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alarmActive)) = flag;
			}
		}

		public unsafe float alarmTimer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alarmTimer);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alarmTimer)) = num;
			}
		}

		public unsafe NewBuilding.AlarmTargetMode targetMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetMode);
				return *(NewBuilding.AlarmTargetMode*)num;
			}
			set
			{
				*(NewBuilding.AlarmTargetMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetMode)) = alarmTargetMode;
			}
		}

		public unsafe float targetModeSetAt
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetModeSetAt);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetModeSetAt)) = num;
			}
		}

		public unsafe List<int> targets
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targets);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe float wanted
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wanted);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wanted)) = num;
			}
		}

		public unsafe List<ElevatorStateSave> elevators
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevators);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ElevatorStateSave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevators)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<TelephoneController.PhoneCall> callLog
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callLog);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TelephoneController.PhoneCall>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callLog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<GameplayController.LostAndFound> lostAndFound
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lostAndFound);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameplayController.LostAndFound>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lostAndFound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static BuildingStateSav()
		{
			Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "BuildingStateSav");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr, "id");
			NativeFieldInfoPtr_alarmActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr, "alarmActive");
			NativeFieldInfoPtr_alarmTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr, "alarmTimer");
			NativeFieldInfoPtr_targetMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr, "targetMode");
			NativeFieldInfoPtr_targetModeSetAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr, "targetModeSetAt");
			NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr, "targets");
			NativeFieldInfoPtr_wanted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr, "wanted");
			NativeFieldInfoPtr_elevators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr, "elevators");
			NativeFieldInfoPtr_callLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr, "callLog");
			NativeFieldInfoPtr_lostAndFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr, "lostAndFound");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr, 100670366);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241714, RefRangeEnd = 241715, XrefRangeStart = 241697, XrefRangeEnd = 241714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildingStateSav()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingStateSav>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BuildingStateSav(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ElevatorStateSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_tileID;

		private static readonly System.IntPtr NativeFieldInfoPtr_yPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_floor;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int tileID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tileID)) = num;
			}
		}

		public unsafe float yPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yPos);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yPos)) = num;
			}
		}

		public unsafe int floor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floor);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floor)) = num;
			}
		}

		static ElevatorStateSave()
		{
			Il2CppClassPointerStore<ElevatorStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "ElevatorStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElevatorStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_tileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorStateSave>.NativeClassPtr, "tileID");
			NativeFieldInfoPtr_yPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorStateSave>.NativeClassPtr, "yPos");
			NativeFieldInfoPtr_floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorStateSave>.NativeClassPtr, "floor");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElevatorStateSave>.NativeClassPtr, 100670367);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElevatorStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElevatorStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ElevatorStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class FloorStateSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_alarmLockdown;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe bool alarmLockdown
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alarmLockdown);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alarmLockdown)) = flag;
			}
		}

		static FloorStateSave()
		{
			Il2CppClassPointerStore<FloorStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "FloorStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloorStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorStateSave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_alarmLockdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorStateSave>.NativeClassPtr, "alarmLockdown");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorStateSave>.NativeClassPtr, 100670368);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloorStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloorStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FloorStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class AddressStateSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_sale;

		private static readonly System.IntPtr NativeFieldInfoPtr_vandalism;

		private static readonly System.IntPtr NativeFieldInfoPtr_alarmActive;

		private static readonly System.IntPtr NativeFieldInfoPtr_alarmTimer;

		private static readonly System.IntPtr NativeFieldInfoPtr_targetMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_targetModeSetAt;

		private static readonly System.IntPtr NativeFieldInfoPtr_targets;

		private static readonly System.IntPtr NativeFieldInfoPtr_escalation;

		private static readonly System.IntPtr NativeFieldInfoPtr_loiter;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe int sale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sale);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sale)) = num;
			}
		}

		public unsafe List<NewAddress.Vandalism> vandalism
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vandalism);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewAddress.Vandalism>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vandalism)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool alarmActive
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alarmActive);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alarmActive)) = flag;
			}
		}

		public unsafe float alarmTimer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alarmTimer);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alarmTimer)) = num;
			}
		}

		public unsafe NewBuilding.AlarmTargetMode targetMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetMode);
				return *(NewBuilding.AlarmTargetMode*)num;
			}
			set
			{
				*(NewBuilding.AlarmTargetMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetMode)) = alarmTargetMode;
			}
		}

		public unsafe float targetModeSetAt
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetModeSetAt);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetModeSetAt)) = num;
			}
		}

		public unsafe List<int> targets
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targets);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<NewGameLocation.TrespassEscalation> escalation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escalation);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewGameLocation.TrespassEscalation>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escalation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe float loiter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loiter);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loiter)) = num;
			}
		}

		static AddressStateSave()
		{
			Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "AddressStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_sale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr, "sale");
			NativeFieldInfoPtr_vandalism = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr, "vandalism");
			NativeFieldInfoPtr_alarmActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr, "alarmActive");
			NativeFieldInfoPtr_alarmTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr, "alarmTimer");
			NativeFieldInfoPtr_targetMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr, "targetMode");
			NativeFieldInfoPtr_targetModeSetAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr, "targetModeSetAt");
			NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr, "targets");
			NativeFieldInfoPtr_escalation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr, "escalation");
			NativeFieldInfoPtr_loiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr, "loiter");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr, 100670369);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241732, RefRangeEnd = 241733, XrefRangeStart = 241715, XrefRangeEnd = 241732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddressStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AddressStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class CompanyStateSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_sales;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe List<Company.SalesRecord> sales
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sales);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Company.SalesRecord>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sales)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static CompanyStateSave()
		{
			Il2CppClassPointerStore<CompanyStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "CompanyStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompanyStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyStateSave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_sales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyStateSave>.NativeClassPtr, "sales");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompanyStateSave>.NativeClassPtr, 100670370);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241739, RefRangeEnd = 241740, XrefRangeStart = 241733, XrefRangeEnd = 241739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompanyStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompanyStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CompanyStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class GuestPassStateSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_guestPassUntil;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe Vector2 guestPassUntil
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guestPassUntil);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guestPassUntil)) = vector;
			}
		}

		static GuestPassStateSave()
		{
			Il2CppClassPointerStore<GuestPassStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "GuestPassStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestPassStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestPassStateSave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_guestPassUntil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestPassStateSave>.NativeClassPtr, "guestPassUntil");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestPassStateSave>.NativeClassPtr, 100670371);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestPassStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestPassStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public GuestPassStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class RoomStateSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_ex;

		private static readonly System.IntPtr NativeFieldInfoPtr_ml;

		private static readonly System.IntPtr NativeFieldInfoPtr_gl;

		private static readonly System.IntPtr NativeFieldInfoPtr_fID;

		private static readonly System.IntPtr NativeFieldInfoPtr_iID;

		private static readonly System.IntPtr NativeFieldInfoPtr_decorOverride;

		private static readonly System.IntPtr NativeFieldInfoPtr_ls;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe int ex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ex)) = num;
			}
		}

		public unsafe bool ml
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ml);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ml)) = flag;
			}
		}

		public unsafe float gl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gl);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gl)) = num;
			}
		}

		public unsafe int fID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fID)) = num;
			}
		}

		public unsafe int iID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iID)) = num;
			}
		}

		public unsafe List<CitySaveData.RoomCitySave> decorOverride
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorOverride);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CitySaveData.RoomCitySave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decorOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<ChangedLightswitch> ls
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ls);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ChangedLightswitch>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static RoomStateSave()
		{
			Il2CppClassPointerStore<RoomStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "RoomStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomStateSave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_ex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomStateSave>.NativeClassPtr, "ex");
			NativeFieldInfoPtr_ml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomStateSave>.NativeClassPtr, "ml");
			NativeFieldInfoPtr_gl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomStateSave>.NativeClassPtr, "gl");
			NativeFieldInfoPtr_fID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomStateSave>.NativeClassPtr, "fID");
			NativeFieldInfoPtr_iID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomStateSave>.NativeClassPtr, "iID");
			NativeFieldInfoPtr_decorOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomStateSave>.NativeClassPtr, "decorOverride");
			NativeFieldInfoPtr_ls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomStateSave>.NativeClassPtr, "ls");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomStateSave>.NativeClassPtr, 100670372);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241740, RefRangeEnd = 241741, XrefRangeStart = 241740, XrefRangeEnd = 241740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoomStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoomStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public RoomStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class CitizenStateSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_pos;

		private static readonly System.IntPtr NativeFieldInfoPtr_rot;

		private static readonly System.IntPtr NativeFieldInfoPtr_trespassingEscalation;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentOutfit;

		private static readonly System.IntPtr NativeFieldInfoPtr_nourishment;

		private static readonly System.IntPtr NativeFieldInfoPtr_hydration;

		private static readonly System.IntPtr NativeFieldInfoPtr_alertness;

		private static readonly System.IntPtr NativeFieldInfoPtr_energy;

		private static readonly System.IntPtr NativeFieldInfoPtr_excitement;

		private static readonly System.IntPtr NativeFieldInfoPtr_chores;

		private static readonly System.IntPtr NativeFieldInfoPtr_hygiene;

		private static readonly System.IntPtr NativeFieldInfoPtr_bladder;

		private static readonly System.IntPtr NativeFieldInfoPtr_heat;

		private static readonly System.IntPtr NativeFieldInfoPtr_drunk;

		private static readonly System.IntPtr NativeFieldInfoPtr_breath;

		private static readonly System.IntPtr NativeFieldInfoPtr_poisoned;

		private static readonly System.IntPtr NativeFieldInfoPtr_blinded;

		private static readonly System.IntPtr NativeFieldInfoPtr_poisoner;

		private static readonly System.IntPtr NativeFieldInfoPtr_den;

		private static readonly System.IntPtr NativeFieldInfoPtr_kidnapper;

		private static readonly System.IntPtr NativeFieldInfoPtr_remFromWorld;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentHealth;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentNerve;

		private static readonly System.IntPtr NativeFieldInfoPtr_fsDirt;

		private static readonly System.IntPtr NativeFieldInfoPtr_fsBlood;

		private static readonly System.IntPtr NativeFieldInfoPtr_wounds;

		private static readonly System.IntPtr NativeFieldInfoPtr_investigateLocation;

		private static readonly System.IntPtr NativeFieldInfoPtr_investigatePosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_investigatePositionProjection;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastInvestigate;

		private static readonly System.IntPtr NativeFieldInfoPtr_persuit;

		private static readonly System.IntPtr NativeFieldInfoPtr_seesPlayerOnPersuit;

		private static readonly System.IntPtr NativeFieldInfoPtr_persuitChaseLogicUses;

		private static readonly System.IntPtr NativeFieldInfoPtr_persuitTarget;

		private static readonly System.IntPtr NativeFieldInfoPtr_persuitPlayer;

		private static readonly System.IntPtr NativeFieldInfoPtr_escalationLevel;

		private static readonly System.IntPtr NativeFieldInfoPtr_minimumInvestigationTimeMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr_reactionState;

		private static readonly System.IntPtr NativeFieldInfoPtr_atHome;

		private static readonly System.IntPtr NativeFieldInfoPtr_convicted;

		private static readonly System.IntPtr NativeFieldInfoPtr_unreportable;

		private static readonly System.IntPtr NativeFieldInfoPtr_ko;

		private static readonly System.IntPtr NativeFieldInfoPtr_koTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_res;

		private static readonly System.IntPtr NativeFieldInfoPtr_resTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_spooked;

		private static readonly System.IntPtr NativeFieldInfoPtr_spookCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_death;

		private static readonly System.IntPtr NativeFieldInfoPtr_ragdollSnapshot;

		private static readonly System.IntPtr NativeFieldInfoPtr_ragdollSnapshotWorld;

		private static readonly System.IntPtr NativeFieldInfoPtr_wallet;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentGoal;

		private static readonly System.IntPtr NativeFieldInfoPtr_fingerprintLoop;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentConsumable;

		private static readonly System.IntPtr NativeFieldInfoPtr_trash;

		private static readonly System.IntPtr NativeFieldInfoPtr_putDown;

		private static readonly System.IntPtr NativeFieldInfoPtr_sightingCit;

		private static readonly System.IntPtr NativeFieldInfoPtr_sightings;

		private static readonly System.IntPtr NativeFieldInfoPtr_confine;

		private static readonly System.IntPtr NativeFieldInfoPtr_avoid;

		private static readonly System.IntPtr NativeFieldInfoPtr_interactionDialog;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe Vector3 pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector;
			}
		}

		public unsafe Quaternion rot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rot);
				return *(Quaternion*)num;
			}
			set
			{
				*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rot)) = quaternion;
			}
		}

		public unsafe int trespassingEscalation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trespassingEscalation);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trespassingEscalation)) = num;
			}
		}

		public unsafe ClothesPreset.OutfitCategory currentOutfit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentOutfit);
				return *(ClothesPreset.OutfitCategory*)num;
			}
			set
			{
				*(ClothesPreset.OutfitCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentOutfit)) = outfitCategory;
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

		public unsafe int poisoner
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisoner);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poisoner)) = num;
			}
		}

		public unsafe int den
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_den);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_den)) = num;
			}
		}

		public unsafe int kidnapper
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kidnapper);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kidnapper)) = num;
			}
		}

		public unsafe bool remFromWorld
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remFromWorld);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remFromWorld)) = flag;
			}
		}

		public unsafe float currentHealth
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentHealth);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentHealth)) = num;
			}
		}

		public unsafe float currentNerve
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentNerve);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentNerve)) = num;
			}
		}

		public unsafe float fsDirt
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fsDirt);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fsDirt)) = num;
			}
		}

		public unsafe float fsBlood
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fsBlood);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fsBlood)) = num;
			}
		}

		public unsafe List<Human.Wound> wounds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wounds);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Human.Wound>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wounds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe Vector3Int investigateLocation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigateLocation);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigateLocation)) = vector3Int;
			}
		}

		public unsafe Vector3 investigatePosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigatePosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigatePosition)) = vector;
			}
		}

		public unsafe Vector3 investigatePositionProjection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigatePositionProjection);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_investigatePositionProjection)) = vector;
			}
		}

		public unsafe float lastInvestigate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastInvestigate);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastInvestigate)) = num;
			}
		}

		public unsafe bool persuit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuit);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuit)) = flag;
			}
		}

		public unsafe bool seesPlayerOnPersuit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seesPlayerOnPersuit);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seesPlayerOnPersuit)) = flag;
			}
		}

		public unsafe float persuitChaseLogicUses
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitChaseLogicUses);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitChaseLogicUses)) = num;
			}
		}

		public unsafe int persuitTarget
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitTarget);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitTarget)) = num;
			}
		}

		public unsafe bool persuitPlayer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitPlayer);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_persuitPlayer)) = flag;
			}
		}

		public unsafe int escalationLevel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escalationLevel);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_escalationLevel)) = num;
			}
		}

		public unsafe float minimumInvestigationTimeMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumInvestigationTimeMultiplier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumInvestigationTimeMultiplier)) = num;
			}
		}

		public unsafe NewAIController.ReactionState reactionState
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionState);
				return *(NewAIController.ReactionState*)num;
			}
			set
			{
				*(NewAIController.ReactionState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionState)) = reactionState;
			}
		}

		public unsafe List<int> atHome
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atHome);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atHome)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool convicted
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_convicted);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_convicted)) = flag;
			}
		}

		public unsafe bool unreportable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unreportable);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unreportable)) = flag;
			}
		}

		public unsafe bool ko
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ko);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ko)) = flag;
			}
		}

		public unsafe float koTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koTime)) = num;
			}
		}

		public unsafe bool res
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_res);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_res)) = flag;
			}
		}

		public unsafe float resTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resTime)) = num;
			}
		}

		public unsafe float spooked
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spooked);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spooked)) = num;
			}
		}

		public unsafe int spookCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spookCount)) = num;
			}
		}

		public unsafe Human.Death death
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_death);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human.Death>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_death)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)death));
			}
		}

		public unsafe List<CitizenAnimationController.RagdollSnapshot> ragdollSnapshot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollSnapshot);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CitizenAnimationController.RagdollSnapshot>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollSnapshot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<CitizenAnimationController.RagdollSnapshotWorld> ragdollSnapshotWorld
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollSnapshotWorld);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CitizenAnimationController.RagdollSnapshotWorld>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ragdollSnapshotWorld)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<Human.WalletItem> wallet
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallet);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Human.WalletItem>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe CurrentGoalStateSave currentGoal
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGoal);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CurrentGoalStateSave>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGoal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentGoalStateSave));
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

		public unsafe List<string> currentConsumable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentConsumable);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentConsumable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

		public unsafe List<int> putDown
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDown);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDown)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> sightingCit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sightingCit);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sightingCit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<Human.Sighting> sightings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sightings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Human.Sighting>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sightings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe AvoidConfineStateSave confine
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confine);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AvoidConfineStateSave>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confine)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)avoidConfineStateSave));
			}
		}

		public unsafe List<AvoidConfineStateSave> avoid
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoid);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AvoidConfineStateSave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avoid)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<Human.InteractionDialogInstance> interactionDialog
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionDialog);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Human.InteractionDialogInstance>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionDialog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static CitizenStateSave()
		{
			Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "CitizenStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "pos");
			NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "rot");
			NativeFieldInfoPtr_trespassingEscalation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "trespassingEscalation");
			NativeFieldInfoPtr_currentOutfit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "currentOutfit");
			NativeFieldInfoPtr_nourishment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "nourishment");
			NativeFieldInfoPtr_hydration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "hydration");
			NativeFieldInfoPtr_alertness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "alertness");
			NativeFieldInfoPtr_energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "energy");
			NativeFieldInfoPtr_excitement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "excitement");
			NativeFieldInfoPtr_chores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "chores");
			NativeFieldInfoPtr_hygiene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "hygiene");
			NativeFieldInfoPtr_bladder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "bladder");
			NativeFieldInfoPtr_heat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "heat");
			NativeFieldInfoPtr_drunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "drunk");
			NativeFieldInfoPtr_breath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "breath");
			NativeFieldInfoPtr_poisoned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "poisoned");
			NativeFieldInfoPtr_blinded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "blinded");
			NativeFieldInfoPtr_poisoner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "poisoner");
			NativeFieldInfoPtr_den = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "den");
			NativeFieldInfoPtr_kidnapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "kidnapper");
			NativeFieldInfoPtr_remFromWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "remFromWorld");
			NativeFieldInfoPtr_currentHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "currentHealth");
			NativeFieldInfoPtr_currentNerve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "currentNerve");
			NativeFieldInfoPtr_fsDirt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "fsDirt");
			NativeFieldInfoPtr_fsBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "fsBlood");
			NativeFieldInfoPtr_wounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "wounds");
			NativeFieldInfoPtr_investigateLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "investigateLocation");
			NativeFieldInfoPtr_investigatePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "investigatePosition");
			NativeFieldInfoPtr_investigatePositionProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "investigatePositionProjection");
			NativeFieldInfoPtr_lastInvestigate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "lastInvestigate");
			NativeFieldInfoPtr_persuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "persuit");
			NativeFieldInfoPtr_seesPlayerOnPersuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "seesPlayerOnPersuit");
			NativeFieldInfoPtr_persuitChaseLogicUses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "persuitChaseLogicUses");
			NativeFieldInfoPtr_persuitTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "persuitTarget");
			NativeFieldInfoPtr_persuitPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "persuitPlayer");
			NativeFieldInfoPtr_escalationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "escalationLevel");
			NativeFieldInfoPtr_minimumInvestigationTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "minimumInvestigationTimeMultiplier");
			NativeFieldInfoPtr_reactionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "reactionState");
			NativeFieldInfoPtr_atHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "atHome");
			NativeFieldInfoPtr_convicted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "convicted");
			NativeFieldInfoPtr_unreportable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "unreportable");
			NativeFieldInfoPtr_ko = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "ko");
			NativeFieldInfoPtr_koTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "koTime");
			NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "res");
			NativeFieldInfoPtr_resTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "resTime");
			NativeFieldInfoPtr_spooked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "spooked");
			NativeFieldInfoPtr_spookCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "spookCount");
			NativeFieldInfoPtr_death = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "death");
			NativeFieldInfoPtr_ragdollSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "ragdollSnapshot");
			NativeFieldInfoPtr_ragdollSnapshotWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "ragdollSnapshotWorld");
			NativeFieldInfoPtr_wallet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "wallet");
			NativeFieldInfoPtr_currentGoal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "currentGoal");
			NativeFieldInfoPtr_fingerprintLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "fingerprintLoop");
			NativeFieldInfoPtr_currentConsumable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "currentConsumable");
			NativeFieldInfoPtr_trash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "trash");
			NativeFieldInfoPtr_putDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "putDown");
			NativeFieldInfoPtr_sightingCit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "sightingCit");
			NativeFieldInfoPtr_sightings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "sightings");
			NativeFieldInfoPtr_confine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "confine");
			NativeFieldInfoPtr_avoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "avoid");
			NativeFieldInfoPtr_interactionDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, "interactionDialog");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr, 100670373);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241776, RefRangeEnd = 241777, XrefRangeStart = 241741, XrefRangeEnd = 241776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CitizenStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CitizenStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CitizenStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class AvoidConfineStateSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_st;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe bool st
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_st);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_st)) = flag;
			}
		}

		static AvoidConfineStateSave()
		{
			Il2CppClassPointerStore<AvoidConfineStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "AvoidConfineStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvoidConfineStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvoidConfineStateSave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_st = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvoidConfineStateSave>.NativeClassPtr, "st");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvoidConfineStateSave>.NativeClassPtr, 100670374);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 23040, RefRangeEnd = 23044, XrefRangeStart = 23040, XrefRangeEnd = 23044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvoidConfineStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvoidConfineStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AvoidConfineStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class CurrentGoalStateSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_priority;

		private static readonly System.IntPtr NativeFieldInfoPtr_trigerTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_timestamp;

		private static readonly System.IntPtr NativeFieldInfoPtr_duration;

		private static readonly System.IntPtr NativeFieldInfoPtr_passedNode;

		private static readonly System.IntPtr NativeFieldInfoPtr_passedInteractable;

		private static readonly System.IntPtr NativeFieldInfoPtr_gameLocation;

		private static readonly System.IntPtr NativeFieldInfoPtr_room;

		private static readonly System.IntPtr NativeFieldInfoPtr_isAddress;

		private static readonly System.IntPtr NativeFieldInfoPtr_passedGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr_jobID;

		private static readonly System.IntPtr NativeFieldInfoPtr_var;

		private static readonly System.IntPtr NativeFieldInfoPtr_actions;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe float priority
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority)) = num;
			}
		}

		public unsafe float trigerTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trigerTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trigerTime)) = num;
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

		public unsafe float duration
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duration)) = num;
			}
		}

		public unsafe Vector3Int passedNode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedNode);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedNode)) = vector3Int;
			}
		}

		public unsafe int passedInteractable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedInteractable);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedInteractable)) = num;
			}
		}

		public unsafe int gameLocation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLocation);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLocation)) = num;
			}
		}

		public unsafe int room
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_room);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_room)) = num;
			}
		}

		public unsafe bool isAddress
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAddress);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAddress)) = flag;
			}
		}

		public unsafe int passedGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedGroup);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedGroup)) = num;
			}
		}

		public unsafe int jobID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobID)) = num;
			}
		}

		public unsafe int var
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_var);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_var)) = num;
			}
		}

		public unsafe List<AIActionStateSave> actions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actions);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AIActionStateSave>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static CurrentGoalStateSave()
		{
			Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "CurrentGoalStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "priority");
			NativeFieldInfoPtr_trigerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "trigerTime");
			NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "timestamp");
			NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "duration");
			NativeFieldInfoPtr_passedNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "passedNode");
			NativeFieldInfoPtr_passedInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "passedInteractable");
			NativeFieldInfoPtr_gameLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "gameLocation");
			NativeFieldInfoPtr_room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "room");
			NativeFieldInfoPtr_isAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "isAddress");
			NativeFieldInfoPtr_passedGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "passedGroup");
			NativeFieldInfoPtr_jobID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "jobID");
			NativeFieldInfoPtr_var = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "var");
			NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, "actions");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr, 100670375);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241777, XrefRangeEnd = 241783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurrentGoalStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurrentGoalStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CurrentGoalStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class AIActionStateSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_node;

		private static readonly System.IntPtr NativeFieldInfoPtr_interactable;

		private static readonly System.IntPtr NativeFieldInfoPtr_passedInteractable;

		private static readonly System.IntPtr NativeFieldInfoPtr_passedRoom;

		private static readonly System.IntPtr NativeFieldInfoPtr_passedGroup;

		private static readonly System.IntPtr NativeFieldInfoPtr_forcedNode;

		private static readonly System.IntPtr NativeFieldInfoPtr_repeat;

		private static readonly System.IntPtr NativeFieldInfoPtr_inserted;

		private static readonly System.IntPtr NativeFieldInfoPtr_iap;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.ManagedStringToIl2Cpp(text));
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

		public unsafe int interactable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable)) = num;
			}
		}

		public unsafe int passedInteractable
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedInteractable);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedInteractable)) = num;
			}
		}

		public unsafe int passedRoom
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedRoom);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedRoom)) = num;
			}
		}

		public unsafe int passedGroup
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedGroup);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passedGroup)) = num;
			}
		}

		public unsafe Vector3Int forcedNode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedNode);
				return *(Vector3Int*)num;
			}
			set
			{
				*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedNode)) = vector3Int;
			}
		}

		public unsafe bool repeat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeat);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_repeat)) = flag;
			}
		}

		public unsafe bool inserted
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inserted);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inserted)) = flag;
			}
		}

		public unsafe int iap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iap);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iap)) = num;
			}
		}

		static AIActionStateSave()
		{
			Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "AIActionStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr, "node");
			NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr, "interactable");
			NativeFieldInfoPtr_passedInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr, "passedInteractable");
			NativeFieldInfoPtr_passedRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr, "passedRoom");
			NativeFieldInfoPtr_passedGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr, "passedGroup");
			NativeFieldInfoPtr_forcedNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr, "forcedNode");
			NativeFieldInfoPtr_repeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr, "repeat");
			NativeFieldInfoPtr_inserted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr, "inserted");
			NativeFieldInfoPtr_iap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr, "iap");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr, 100670376);
		}

		[CallerCount(0)]
		public unsafe AIActionStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIActionStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AIActionStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DoorStateSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_l;

		private static readonly System.IntPtr NativeFieldInfoPtr_ds;

		private static readonly System.IntPtr NativeFieldInfoPtr_ls;

		private static readonly System.IntPtr NativeFieldInfoPtr_ajar;

		private static readonly System.IntPtr NativeFieldInfoPtr_cs;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe bool l
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_l);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_l)) = flag;
			}
		}

		public unsafe float ds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ds);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ds)) = num;
			}
		}

		public unsafe float ls
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ls);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ls)) = num;
			}
		}

		public unsafe float ajar
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ajar);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ajar)) = num;
			}
		}

		public unsafe bool cs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs)) = flag;
			}
		}

		static DoorStateSave()
		{
			Il2CppClassPointerStore<DoorStateSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "DoorStateSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorStateSave>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorStateSave>.NativeClassPtr, "id");
			NativeFieldInfoPtr_l = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorStateSave>.NativeClassPtr, "l");
			NativeFieldInfoPtr_ds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorStateSave>.NativeClassPtr, "ds");
			NativeFieldInfoPtr_ls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorStateSave>.NativeClassPtr, "ls");
			NativeFieldInfoPtr_ajar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorStateSave>.NativeClassPtr, "ajar");
			NativeFieldInfoPtr_cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorStateSave>.NativeClassPtr, "cs");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorStateSave>.NativeClassPtr, 100670377);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorStateSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorStateSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DoorStateSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class MessageThreadSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_threadID;

		private static readonly System.IntPtr NativeFieldInfoPtr_msgType;

		private static readonly System.IntPtr NativeFieldInfoPtr_treeID;

		private static readonly System.IntPtr NativeFieldInfoPtr_participantA;

		private static readonly System.IntPtr NativeFieldInfoPtr_participantB;

		private static readonly System.IntPtr NativeFieldInfoPtr_participantC;

		private static readonly System.IntPtr NativeFieldInfoPtr_participantD;

		private static readonly System.IntPtr NativeFieldInfoPtr_cc;

		private static readonly System.IntPtr NativeFieldInfoPtr_messages;

		private static readonly System.IntPtr NativeFieldInfoPtr_senders;

		private static readonly System.IntPtr NativeFieldInfoPtr_recievers;

		private static readonly System.IntPtr NativeFieldInfoPtr_timestamps;

		private static readonly System.IntPtr NativeFieldInfoPtr_time;

		private static readonly System.IntPtr NativeFieldInfoPtr_ds;

		private static readonly System.IntPtr NativeFieldInfoPtr_dsID;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int threadID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threadID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threadID)) = num;
			}
		}

		public unsafe DDSSaveClasses.TreeType msgType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_msgType);
				return *(DDSSaveClasses.TreeType*)num;
			}
			set
			{
				*(DDSSaveClasses.TreeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_msgType)) = treeType;
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

		public unsafe int participantA
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantA);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantA)) = num;
			}
		}

		public unsafe int participantB
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantB);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantB)) = num;
			}
		}

		public unsafe int participantC
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantC);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantC)) = num;
			}
		}

		public unsafe int participantD
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantD);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_participantD)) = num;
			}
		}

		public unsafe List<int> cc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<string> messages
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messages);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> senders
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_senders);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_senders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<int> recievers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recievers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recievers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<float> timestamps
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timestamps);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<float>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timestamps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
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

		public unsafe CustomDataSource ds
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ds);
				return *(CustomDataSource*)num;
			}
			set
			{
				*(CustomDataSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ds)) = customDataSource;
			}
		}

		public unsafe int dsID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dsID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dsID)) = num;
			}
		}

		static MessageThreadSave()
		{
			Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "MessageThreadSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr);
			NativeFieldInfoPtr_threadID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "threadID");
			NativeFieldInfoPtr_msgType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "msgType");
			NativeFieldInfoPtr_treeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "treeID");
			NativeFieldInfoPtr_participantA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "participantA");
			NativeFieldInfoPtr_participantB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "participantB");
			NativeFieldInfoPtr_participantC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "participantC");
			NativeFieldInfoPtr_participantD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "participantD");
			NativeFieldInfoPtr_cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "cc");
			NativeFieldInfoPtr_messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "messages");
			NativeFieldInfoPtr_senders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "senders");
			NativeFieldInfoPtr_recievers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "recievers");
			NativeFieldInfoPtr_timestamps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "timestamps");
			NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "time");
			NativeFieldInfoPtr_ds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "ds");
			NativeFieldInfoPtr_dsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, "dsID");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr, 100670378);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241805, RefRangeEnd = 241806, XrefRangeStart = 241783, XrefRangeEnd = 241805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageThreadSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageThreadSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MessageThreadSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum CustomDataSource
	{
		sender,
		groupID
	}

	[System.Serializable]
	public class AirDuctExplorationSave : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_grpID;

		private static readonly System.IntPtr NativeFieldInfoPtr_vents;

		private static readonly System.IntPtr NativeFieldInfoPtr_ducts;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int grpID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grpID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_grpID)) = num;
			}
		}

		public unsafe List<int> vents
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vents);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<Vector3Int> ducts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ducts);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ducts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static AirDuctExplorationSave()
		{
			Il2CppClassPointerStore<AirDuctExplorationSave>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "AirDuctExplorationSave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AirDuctExplorationSave>.NativeClassPtr);
			NativeFieldInfoPtr_grpID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctExplorationSave>.NativeClassPtr, "grpID");
			NativeFieldInfoPtr_vents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctExplorationSave>.NativeClassPtr, "vents");
			NativeFieldInfoPtr_ducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirDuctExplorationSave>.NativeClassPtr, "ducts");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirDuctExplorationSave>.NativeClassPtr, 100670379);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 241816, RefRangeEnd = 241818, XrefRangeStart = 241806, XrefRangeEnd = 241816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AirDuctExplorationSave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AirDuctExplorationSave>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AirDuctExplorationSave(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ChangedLightswitch : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_locPos;

		private static readonly System.IntPtr NativeFieldInfoPtr_locEuler;

		private static readonly System.IntPtr NativeFieldInfoPtr_added;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3 locPos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locPos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locPos)) = vector;
			}
		}

		public unsafe Vector3 locEuler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locEuler);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locEuler)) = vector;
			}
		}

		public unsafe bool added
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_added);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_added)) = flag;
			}
		}

		static ChangedLightswitch()
		{
			Il2CppClassPointerStore<ChangedLightswitch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "ChangedLightswitch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangedLightswitch>.NativeClassPtr);
			NativeFieldInfoPtr_locPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangedLightswitch>.NativeClassPtr, "locPos");
			NativeFieldInfoPtr_locEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangedLightswitch>.NativeClassPtr, "locEuler");
			NativeFieldInfoPtr_added = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangedLightswitch>.NativeClassPtr, "added");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangedLightswitch>.NativeClassPtr, 100670380);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChangedLightswitch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangedLightswitch>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ChangedLightswitch(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_build;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityShare;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_compositionData;

	private static readonly System.IntPtr NativeFieldInfoPtr_dynamicPrintsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneCaptureCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneCapMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_saveTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_leapCycle;

	private static readonly System.IntPtr NativeFieldInfoPtr_fingerprintLoop;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignCaptureID;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignMessageThreadID;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignGroupID;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignStickNote;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignInteractableID;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignCaseID;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignMurderID;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentRain;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredRain;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentWind;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredWind;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSnow;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredSnow;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentLightning;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredLightning;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentFog;

	private static readonly System.IntPtr NativeFieldInfoPtr_desiredFog;

	private static readonly System.IntPtr NativeFieldInfoPtr_cityWetness;

	private static readonly System.IntPtr NativeFieldInfoPtr_citySnow;

	private static readonly System.IntPtr NativeFieldInfoPtr_weatherChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_basicJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_affairJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_sabotageJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_stolenItemJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_missingPersonJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_revengeJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_briefcaseJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_jobDiffLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_chapter;

	private static readonly System.IntPtr NativeFieldInfoPtr_chapterPart;

	private static readonly System.IntPtr NativeFieldInfoPtr_chapterSaveState;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapPathActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapPathNodeSpecific;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapPathNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeCases;

	private static readonly System.IntPtr NativeFieldInfoPtr_archivedCases;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeCase;

	private static readonly System.IntPtr NativeFieldInfoPtr_footprints;

	private static readonly System.IntPtr NativeFieldInfoPtr_history;

	private static readonly System.IntPtr NativeFieldInfoPtr_passcodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_numbers;

	private static readonly System.IntPtr NativeFieldInfoPtr_enforcerCalls;

	private static readonly System.IntPtr NativeFieldInfoPtr_crimeSceneCleanup;

	private static readonly System.IntPtr NativeFieldInfoPtr_hotelGuests;

	private static readonly System.IntPtr NativeFieldInfoPtr_brokenWindows;

	private static readonly System.IntPtr NativeFieldInfoPtr_newspaperState;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerFirstName;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerSurname;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerGender;

	private static readonly System.IntPtr NativeFieldInfoPtr_partnerGender;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerSkinColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerBirthDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerBirthMonth;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerBirthYear;

	private static readonly System.IntPtr NativeFieldInfoPtr_residence;

	private static readonly System.IntPtr NativeFieldInfoPtr_apartmentsOwned;

	private static readonly System.IntPtr NativeFieldInfoPtr_accidentCover;

	private static readonly System.IntPtr NativeFieldInfoPtr_foodH;

	private static readonly System.IntPtr NativeFieldInfoPtr_sanitary;

	private static readonly System.IntPtr NativeFieldInfoPtr_ops;

	private static readonly System.IntPtr NativeFieldInfoPtr_knowsPasswords;

	private static readonly System.IntPtr NativeFieldInfoPtr_debt;

	private static readonly System.IntPtr NativeFieldInfoPtr_carried;

	private static readonly System.IntPtr NativeFieldInfoPtr_tutorial;

	private static readonly System.IntPtr NativeFieldInfoPtr_tutTextTriggered;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstPersonItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_scannedPrints;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_money;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockpicks;

	private static readonly System.IntPtr NativeFieldInfoPtr_socCredit;

	private static readonly System.IntPtr NativeFieldInfoPtr_socCreditPerks;

	private static readonly System.IntPtr NativeFieldInfoPtr_health;

	private static readonly System.IntPtr NativeFieldInfoPtr_nourishment;

	private static readonly System.IntPtr NativeFieldInfoPtr_hydration;

	private static readonly System.IntPtr NativeFieldInfoPtr_alertness;

	private static readonly System.IntPtr NativeFieldInfoPtr_energy;

	private static readonly System.IntPtr NativeFieldInfoPtr_hygiene;

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

	private static readonly System.IntPtr NativeFieldInfoPtr_crouched;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgrades;

	private static readonly System.IntPtr NativeFieldInfoPtr_sabotaged;

	private static readonly System.IntPtr NativeFieldInfoPtr_booksRead;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerSavedCaptures;

	private static readonly System.IntPtr NativeFieldInfoPtr_speech;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyring;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyringInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_fakeTelephone;

	private static readonly System.IntPtr NativeFieldInfoPtr_hideInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_hideRef;

	private static readonly System.IntPtr NativeFieldInfoPtr_phoneInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_computerInteractable;

	private static readonly System.IntPtr NativeFieldInfoPtr_duct;

	private static readonly System.IntPtr NativeFieldInfoPtr_storedTransPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_buildings;

	private static readonly System.IntPtr NativeFieldInfoPtr_companies;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageThreads;

	private static readonly System.IntPtr NativeFieldInfoPtr_pgLoop;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentMurderer;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentVictim;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentActiveCase;

	private static readonly System.IntPtr NativeFieldInfoPtr_murderPreset;

	private static readonly System.IntPtr NativeFieldInfoPtr_chosenMO;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousMurderers;

	private static readonly System.IntPtr NativeFieldInfoPtr_pauseBetweenMurders;

	private static readonly System.IntPtr NativeFieldInfoPtr_pauseForKidnapperKill;

	private static readonly System.IntPtr NativeFieldInfoPtr_murderRoutineActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxMurderDiffLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentVictimSite;

	private static readonly System.IntPtr NativeFieldInfoPtr_victimSiteIsStreet;

	private static readonly System.IntPtr NativeFieldInfoPtr_triggerCoverUpCall;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerAcceptedCoverUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_triggerCoverUpSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_murders;

	private static readonly System.IntPtr NativeFieldInfoPtr_iaMurders;

	private static readonly System.IntPtr NativeFieldInfoPtr_evidence;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeEvidence;

	private static readonly System.IntPtr NativeFieldInfoPtr_dateEvidence;

	private static readonly System.IntPtr NativeFieldInfoPtr_customStrings;

	private static readonly System.IntPtr NativeFieldInfoPtr_spatter;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_airDuctExploration;

	private static readonly System.IntPtr NativeFieldInfoPtr_freeHealthCareFlag;

	private static readonly System.IntPtr NativeFieldInfoPtr_notTheAnswerFlag;

	private static readonly System.IntPtr NativeFieldInfoPtr_privateSlyFlag;

	private static readonly System.IntPtr NativeFieldInfoPtr_allConnectedReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_pacifistFlag;

	private static readonly System.IntPtr NativeFieldInfoPtr_notAScratchFlag;

	private static readonly System.IntPtr NativeFieldInfoPtr_spareNoOneReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_snail;

	private static readonly System.IntPtr NativeFieldInfoPtr_floors;

	private static readonly System.IntPtr NativeFieldInfoPtr_addresses;

	private static readonly System.IntPtr NativeFieldInfoPtr_guestPasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_rooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_metas;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactables;

	private static readonly System.IntPtr NativeFieldInfoPtr_removedCityData;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizens;

	private static readonly System.IntPtr NativeFieldInfoPtr_doors;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string build
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_build);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_build)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string cityShare
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityShare);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityShare)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> instanceIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceIDs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceIDs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> compositionData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compositionData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compositionData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int dynamicPrintsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicPrintsCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicPrintsCount)) = num;
		}
	}

	public unsafe int sceneCaptureCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneCaptureCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneCaptureCount)) = num;
		}
	}

	public unsafe int sceneCapMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneCapMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneCapMax)) = num;
		}
	}

	public unsafe string saveTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveTime);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveTime)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float gameTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameTime)) = num;
		}
	}

	public unsafe float timeLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLimit)) = num;
		}
	}

	public unsafe int leapCycle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leapCycle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leapCycle)) = num;
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

	public unsafe int assignCaptureID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignCaptureID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignCaptureID)) = num;
		}
	}

	public unsafe int assignMessageThreadID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignMessageThreadID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignMessageThreadID)) = num;
		}
	}

	public unsafe int assignGroupID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignGroupID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignGroupID)) = num;
		}
	}

	public unsafe int assignStickNote
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignStickNote);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignStickNote)) = num;
		}
	}

	public unsafe int assignInteractableID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignInteractableID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignInteractableID)) = num;
		}
	}

	public unsafe int assignCaseID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignCaseID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignCaseID)) = num;
		}
	}

	public unsafe int assignMurderID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignMurderID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assignMurderID)) = num;
		}
	}

	public unsafe int gameLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLength)) = num;
		}
	}

	public unsafe float currentRain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentRain);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentRain)) = num;
		}
	}

	public unsafe float desiredRain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredRain);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredRain)) = num;
		}
	}

	public unsafe float currentWind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWind);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentWind)) = num;
		}
	}

	public unsafe float desiredWind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredWind);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredWind)) = num;
		}
	}

	public unsafe float currentSnow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSnow);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSnow)) = num;
		}
	}

	public unsafe float desiredSnow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredSnow);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredSnow)) = num;
		}
	}

	public unsafe float currentLightning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLightning);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLightning)) = num;
		}
	}

	public unsafe float desiredLightning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredLightning);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredLightning)) = num;
		}
	}

	public unsafe float currentFog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFog);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFog)) = num;
		}
	}

	public unsafe float desiredFog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredFog);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desiredFog)) = num;
		}
	}

	public unsafe float cityWetness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityWetness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityWetness)) = num;
		}
	}

	public unsafe float citySnow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySnow);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citySnow)) = num;
		}
	}

	public unsafe float weatherChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherChange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weatherChange)) = num;
		}
	}

	public unsafe List<SideJob> basicJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basicJobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SideJob>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basicJobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SideJobAffair> affairJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affairJobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SideJobAffair>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_affairJobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SideJobSabotage> sabotageJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sabotageJobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SideJobSabotage>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sabotageJobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SideJobStolenItem> stolenItemJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stolenItemJobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SideJobStolenItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stolenItemJobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SideJobMissingPerson> missingPersonJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missingPersonJobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SideJobMissingPerson>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missingPersonJobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SideJobRevenge> revengeJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_revengeJobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SideJobRevenge>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_revengeJobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SideJobStealBriefcase> briefcaseJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_briefcaseJobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SideJobStealBriefcase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_briefcaseJobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int jobDiffLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobDiffLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jobDiffLevel)) = num;
		}
	}

	public unsafe int chapter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chapter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chapter)) = num;
		}
	}

	public unsafe int chapterPart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chapterPart);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chapterPart)) = num;
		}
	}

	public unsafe ChaperStateSave chapterSaveState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chapterSaveState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChaperStateSave>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chapterSaveState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chaperStateSave));
		}
	}

	public unsafe bool mapPathActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapPathActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapPathActive)) = flag;
		}
	}

	public unsafe bool mapPathNodeSpecific
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapPathNodeSpecific);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapPathNodeSpecific)) = flag;
		}
	}

	public unsafe Vector3Int mapPathNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapPathNode);
			return *(Vector3Int*)num;
		}
		set
		{
			*(Vector3Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapPathNode)) = vector3Int;
		}
	}

	public unsafe List<Case> activeCases
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeCases);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Case>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeCases)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Case> archivedCases
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_archivedCases);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Case>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_archivedCases)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int activeCase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeCase);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeCase)) = num;
		}
	}

	public unsafe List<GameplayController.Footprint> footprints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameplayController.Footprint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footprints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameplayController.History> history
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_history);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameplayController.History>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_history)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameplayController.Passcode> passcodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passcodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameplayController.Passcode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passcodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameplayController.PhoneNumber> numbers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numbers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameplayController.PhoneNumber>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numbers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameplayController.EnforcerCall> enforcerCalls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enforcerCalls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameplayController.EnforcerCall>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enforcerCalls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CrimeSceneCleanup> crimeSceneCleanup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crimeSceneCleanup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CrimeSceneCleanup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crimeSceneCleanup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameplayController.HotelGuest> hotelGuests
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hotelGuests);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameplayController.HotelGuest>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hotelGuests)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BrokenWindowSave> brokenWindows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenWindows);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BrokenWindowSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brokenWindows)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe NewspaperController.NewspaperState newspaperState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newspaperState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewspaperController.NewspaperState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newspaperState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newspaperState));
		}
	}

	public unsafe string playerFirstName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerFirstName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerFirstName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string playerSurname
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSurname);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSurname)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Human.Gender playerGender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGender);
			return *(Human.Gender*)num;
		}
		set
		{
			*(Human.Gender*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerGender)) = gender;
		}
	}

	public unsafe Human.Gender partnerGender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partnerGender);
			return *(Human.Gender*)num;
		}
		set
		{
			*(Human.Gender*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partnerGender)) = gender;
		}
	}

	public unsafe Color playerSkinColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSkinColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSkinColour)) = color;
		}
	}

	public unsafe int playerBirthDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBirthDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBirthDay)) = num;
		}
	}

	public unsafe int playerBirthMonth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBirthMonth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBirthMonth)) = num;
		}
	}

	public unsafe int playerBirthYear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBirthYear);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerBirthYear)) = num;
		}
	}

	public unsafe int residence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_residence);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_residence)) = num;
		}
	}

	public unsafe List<int> apartmentsOwned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apartmentsOwned);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apartmentsOwned)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool accidentCover
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accidentCover);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accidentCover)) = flag;
		}
	}

	public unsafe List<int> foodH
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foodH);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foodH)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> sanitary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sanitary);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sanitary)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> ops
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ops);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ops)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> knowsPasswords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowsPasswords);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_knowsPasswords)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameplayController.LoanDebt> debt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debt);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameplayController.LoanDebt>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debt)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int carried
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carried);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carried)) = num;
		}
	}

	public unsafe bool tutorial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorial);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutorial)) = flag;
		}
	}

	public unsafe List<string> tutTextTriggered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutTextTriggered);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tutTextTriggered)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FirstPersonItemController.InventorySlot> firstPersonItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstPersonItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FirstPersonItemController.InventorySlot>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstPersonItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ScannedObjPrint> scannedPrints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scannedPrints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ScannedObjPrint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scannedPrints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Vector3 playerPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPos)) = vector;
		}
	}

	public unsafe Quaternion playerRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerRot);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerRot)) = quaternion;
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

	public unsafe int lockpicks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockpicks);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockpicks)) = num;
		}
	}

	public unsafe int socCredit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socCredit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socCredit)) = num;
		}
	}

	public unsafe List<string> socCreditPerks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socCreditPerks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socCreditPerks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float health
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_health);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_health)) = num;
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

	public unsafe bool crouched
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crouched);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crouched)) = flag;
		}
	}

	public unsafe List<UpgradesController.Upgrades> upgrades
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgrades);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<UpgradesController.Upgrades>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgrades)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> sabotaged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sabotaged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sabotaged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> booksRead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_booksRead);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_booksRead)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SceneRecorder.SceneCapture> playerSavedCaptures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSavedCaptures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SceneRecorder.SceneCapture>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSavedCaptures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SpeechController.QueueElement> speech
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speech);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SpeechController.QueueElement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speech)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> keyring
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyring);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyring)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> keyringInt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyringInt);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyringInt)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FakeTelephone> fakeTelephone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fakeTelephone);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FakeTelephone>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fakeTelephone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int hideInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideInteractable);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideInteractable)) = num;
		}
	}

	public unsafe int hideRef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideRef);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideRef)) = num;
		}
	}

	public unsafe int phoneInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_phoneInteractable);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_phoneInteractable)) = num;
		}
	}

	public unsafe int computerInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_computerInteractable);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_computerInteractable)) = num;
		}
	}

	public unsafe int duct
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duct);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duct)) = num;
		}
	}

	public unsafe Vector3 storedTransPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storedTransPos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_storedTransPos)) = vector;
		}
	}

	public unsafe List<BuildingStateSav> buildings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuildingStateSav>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buildings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CompanyStateSave> companies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companies);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CompanyStateSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companies)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MessageThreadSave> messageThreads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageThreads);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MessageThreadSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageThreads)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool pgLoop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pgLoop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pgLoop)) = flag;
		}
	}

	public unsafe int currentMurderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMurderer);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMurderer)) = num;
		}
	}

	public unsafe int currentVictim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentVictim);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentVictim)) = num;
		}
	}

	public unsafe int currentActiveCase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentActiveCase);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentActiveCase)) = num;
		}
	}

	public unsafe string murderPreset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderPreset);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderPreset)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string chosenMO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chosenMO);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chosenMO)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<int> previousMurderers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousMurderers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousMurderers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float pauseBetweenMurders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseBetweenMurders);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseBetweenMurders)) = num;
		}
	}

	public unsafe float pauseForKidnapperKill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseForKidnapperKill);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pauseForKidnapperKill)) = num;
		}
	}

	public unsafe bool murderRoutineActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderRoutineActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murderRoutineActive)) = flag;
		}
	}

	public unsafe int maxMurderDiffLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMurderDiffLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMurderDiffLevel)) = num;
		}
	}

	public unsafe int currentVictimSite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentVictimSite);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentVictimSite)) = num;
		}
	}

	public unsafe bool victimSiteIsStreet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimSiteIsStreet);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_victimSiteIsStreet)) = flag;
		}
	}

	public unsafe bool triggerCoverUpCall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerCoverUpCall);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerCoverUpCall)) = flag;
		}
	}

	public unsafe bool playerAcceptedCoverUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAcceptedCoverUp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAcceptedCoverUp)) = flag;
		}
	}

	public unsafe bool triggerCoverUpSuccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerCoverUpSuccess);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerCoverUpSuccess)) = flag;
		}
	}

	public unsafe List<MurderController.Murder> murders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderController.Murder>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_murders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MurderController.Murder> iaMurders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iaMurders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MurderController.Murder>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iaMurders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<EvidenceStateSave> evidence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidence);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<EvidenceStateSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evidence)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> timeEvidence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeEvidence);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeEvidence)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> dateEvidence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateEvidence);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateEvidence)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> customStrings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customStrings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customStrings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<SpatterSimulation> spatter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SpatterSimulation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CitySaveData.FurnitureClusterObjectCitySave> furnitureStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureStorage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CitySaveData.FurnitureClusterObjectCitySave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureStorage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AirDuctExplorationSave> airDuctExploration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDuctExploration);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AirDuctExplorationSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_airDuctExploration)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool freeHealthCareFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freeHealthCareFlag);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freeHealthCareFlag)) = flag;
		}
	}

	public unsafe int notTheAnswerFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notTheAnswerFlag);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notTheAnswerFlag)) = num;
		}
	}

	public unsafe int privateSlyFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_privateSlyFlag);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_privateSlyFlag)) = num;
		}
	}

	public unsafe List<string> allConnectedReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allConnectedReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allConnectedReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool pacifistFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pacifistFlag);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pacifistFlag)) = flag;
		}
	}

	public unsafe bool notAScratchFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notAScratchFlag);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notAScratchFlag)) = flag;
		}
	}

	public unsafe List<int> spareNoOneReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spareNoOneReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spareNoOneReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe SnailController.SnailSaveData snail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snail);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SnailController.SnailSaveData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snail)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)snailSaveData));
		}
	}

	public unsafe List<FloorStateSave> floors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FloorStateSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AddressStateSave> addresses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addresses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AddressStateSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addresses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GuestPassStateSave> guestPasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guestPasses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GuestPassStateSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_guestPasses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<RoomStateSave> rooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rooms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomStateSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MetaObject> metas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MetaObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_metas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Interactable> interactables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactables);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactables)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<int> removedCityData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removedCityData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removedCityData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<CitizenStateSave> citizens
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizens);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CitizenStateSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizens)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DoorStateSave> doors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DoorStateSave>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static StateSaveData()
	{
		Il2CppClassPointerStore<StateSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StateSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr);
		NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "build");
		NativeFieldInfoPtr_cityShare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "cityShare");
		NativeFieldInfoPtr_instanceIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "instanceIDs");
		NativeFieldInfoPtr_compositionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "compositionData");
		NativeFieldInfoPtr_dynamicPrintsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "dynamicPrintsCount");
		NativeFieldInfoPtr_sceneCaptureCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "sceneCaptureCount");
		NativeFieldInfoPtr_sceneCapMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "sceneCapMax");
		NativeFieldInfoPtr_saveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "saveTime");
		NativeFieldInfoPtr_gameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "gameTime");
		NativeFieldInfoPtr_timeLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "timeLimit");
		NativeFieldInfoPtr_leapCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "leapCycle");
		NativeFieldInfoPtr_fingerprintLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "fingerprintLoop");
		NativeFieldInfoPtr_assignCaptureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "assignCaptureID");
		NativeFieldInfoPtr_assignMessageThreadID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "assignMessageThreadID");
		NativeFieldInfoPtr_assignGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "assignGroupID");
		NativeFieldInfoPtr_assignStickNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "assignStickNote");
		NativeFieldInfoPtr_assignInteractableID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "assignInteractableID");
		NativeFieldInfoPtr_assignCaseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "assignCaseID");
		NativeFieldInfoPtr_assignMurderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "assignMurderID");
		NativeFieldInfoPtr_gameLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "gameLength");
		NativeFieldInfoPtr_currentRain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "currentRain");
		NativeFieldInfoPtr_desiredRain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "desiredRain");
		NativeFieldInfoPtr_currentWind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "currentWind");
		NativeFieldInfoPtr_desiredWind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "desiredWind");
		NativeFieldInfoPtr_currentSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "currentSnow");
		NativeFieldInfoPtr_desiredSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "desiredSnow");
		NativeFieldInfoPtr_currentLightning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "currentLightning");
		NativeFieldInfoPtr_desiredLightning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "desiredLightning");
		NativeFieldInfoPtr_currentFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "currentFog");
		NativeFieldInfoPtr_desiredFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "desiredFog");
		NativeFieldInfoPtr_cityWetness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "cityWetness");
		NativeFieldInfoPtr_citySnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "citySnow");
		NativeFieldInfoPtr_weatherChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "weatherChange");
		NativeFieldInfoPtr_basicJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "basicJobs");
		NativeFieldInfoPtr_affairJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "affairJobs");
		NativeFieldInfoPtr_sabotageJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "sabotageJobs");
		NativeFieldInfoPtr_stolenItemJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "stolenItemJobs");
		NativeFieldInfoPtr_missingPersonJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "missingPersonJobs");
		NativeFieldInfoPtr_revengeJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "revengeJobs");
		NativeFieldInfoPtr_briefcaseJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "briefcaseJobs");
		NativeFieldInfoPtr_jobDiffLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "jobDiffLevel");
		NativeFieldInfoPtr_chapter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "chapter");
		NativeFieldInfoPtr_chapterPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "chapterPart");
		NativeFieldInfoPtr_chapterSaveState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "chapterSaveState");
		NativeFieldInfoPtr_mapPathActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "mapPathActive");
		NativeFieldInfoPtr_mapPathNodeSpecific = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "mapPathNodeSpecific");
		NativeFieldInfoPtr_mapPathNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "mapPathNode");
		NativeFieldInfoPtr_activeCases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "activeCases");
		NativeFieldInfoPtr_archivedCases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "archivedCases");
		NativeFieldInfoPtr_activeCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "activeCase");
		NativeFieldInfoPtr_footprints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "footprints");
		NativeFieldInfoPtr_history = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "history");
		NativeFieldInfoPtr_passcodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "passcodes");
		NativeFieldInfoPtr_numbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "numbers");
		NativeFieldInfoPtr_enforcerCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "enforcerCalls");
		NativeFieldInfoPtr_crimeSceneCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "crimeSceneCleanup");
		NativeFieldInfoPtr_hotelGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "hotelGuests");
		NativeFieldInfoPtr_brokenWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "brokenWindows");
		NativeFieldInfoPtr_newspaperState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "newspaperState");
		NativeFieldInfoPtr_playerFirstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "playerFirstName");
		NativeFieldInfoPtr_playerSurname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "playerSurname");
		NativeFieldInfoPtr_playerGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "playerGender");
		NativeFieldInfoPtr_partnerGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "partnerGender");
		NativeFieldInfoPtr_playerSkinColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "playerSkinColour");
		NativeFieldInfoPtr_playerBirthDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "playerBirthDay");
		NativeFieldInfoPtr_playerBirthMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "playerBirthMonth");
		NativeFieldInfoPtr_playerBirthYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "playerBirthYear");
		NativeFieldInfoPtr_residence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "residence");
		NativeFieldInfoPtr_apartmentsOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "apartmentsOwned");
		NativeFieldInfoPtr_accidentCover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "accidentCover");
		NativeFieldInfoPtr_foodH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "foodH");
		NativeFieldInfoPtr_sanitary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "sanitary");
		NativeFieldInfoPtr_ops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "ops");
		NativeFieldInfoPtr_knowsPasswords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "knowsPasswords");
		NativeFieldInfoPtr_debt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "debt");
		NativeFieldInfoPtr_carried = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "carried");
		NativeFieldInfoPtr_tutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "tutorial");
		NativeFieldInfoPtr_tutTextTriggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "tutTextTriggered");
		NativeFieldInfoPtr_firstPersonItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "firstPersonItems");
		NativeFieldInfoPtr_scannedPrints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "scannedPrints");
		NativeFieldInfoPtr_playerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "playerPos");
		NativeFieldInfoPtr_playerRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "playerRot");
		NativeFieldInfoPtr_money = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "money");
		NativeFieldInfoPtr_lockpicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "lockpicks");
		NativeFieldInfoPtr_socCredit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "socCredit");
		NativeFieldInfoPtr_socCreditPerks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "socCreditPerks");
		NativeFieldInfoPtr_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "health");
		NativeFieldInfoPtr_nourishment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "nourishment");
		NativeFieldInfoPtr_hydration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "hydration");
		NativeFieldInfoPtr_alertness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "alertness");
		NativeFieldInfoPtr_energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "energy");
		NativeFieldInfoPtr_hygiene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "hygiene");
		NativeFieldInfoPtr_heat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "heat");
		NativeFieldInfoPtr_drunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "drunk");
		NativeFieldInfoPtr_sick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "sick");
		NativeFieldInfoPtr_headache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "headache");
		NativeFieldInfoPtr_wet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "wet");
		NativeFieldInfoPtr_brokenLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "brokenLeg");
		NativeFieldInfoPtr_bruised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "bruised");
		NativeFieldInfoPtr_blackEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "blackEye");
		NativeFieldInfoPtr_blackedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "blackedOut");
		NativeFieldInfoPtr_numb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "numb");
		NativeFieldInfoPtr_poisoned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "poisoned");
		NativeFieldInfoPtr_bleeding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "bleeding");
		NativeFieldInfoPtr_wellRested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "wellRested");
		NativeFieldInfoPtr_starchAddiction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "starchAddiction");
		NativeFieldInfoPtr_syncDiskInstall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "syncDiskInstall");
		NativeFieldInfoPtr_blinded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "blinded");
		NativeFieldInfoPtr_crouched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "crouched");
		NativeFieldInfoPtr_upgrades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "upgrades");
		NativeFieldInfoPtr_sabotaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "sabotaged");
		NativeFieldInfoPtr_booksRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "booksRead");
		NativeFieldInfoPtr_playerSavedCaptures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "playerSavedCaptures");
		NativeFieldInfoPtr_speech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "speech");
		NativeFieldInfoPtr_keyring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "keyring");
		NativeFieldInfoPtr_keyringInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "keyringInt");
		NativeFieldInfoPtr_fakeTelephone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "fakeTelephone");
		NativeFieldInfoPtr_hideInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "hideInteractable");
		NativeFieldInfoPtr_hideRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "hideRef");
		NativeFieldInfoPtr_phoneInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "phoneInteractable");
		NativeFieldInfoPtr_computerInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "computerInteractable");
		NativeFieldInfoPtr_duct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "duct");
		NativeFieldInfoPtr_storedTransPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "storedTransPos");
		NativeFieldInfoPtr_buildings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "buildings");
		NativeFieldInfoPtr_companies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "companies");
		NativeFieldInfoPtr_messageThreads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "messageThreads");
		NativeFieldInfoPtr_pgLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "pgLoop");
		NativeFieldInfoPtr_currentMurderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "currentMurderer");
		NativeFieldInfoPtr_currentVictim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "currentVictim");
		NativeFieldInfoPtr_currentActiveCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "currentActiveCase");
		NativeFieldInfoPtr_murderPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "murderPreset");
		NativeFieldInfoPtr_chosenMO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "chosenMO");
		NativeFieldInfoPtr_previousMurderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "previousMurderers");
		NativeFieldInfoPtr_pauseBetweenMurders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "pauseBetweenMurders");
		NativeFieldInfoPtr_pauseForKidnapperKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "pauseForKidnapperKill");
		NativeFieldInfoPtr_murderRoutineActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "murderRoutineActive");
		NativeFieldInfoPtr_maxMurderDiffLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "maxMurderDiffLevel");
		NativeFieldInfoPtr_currentVictimSite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "currentVictimSite");
		NativeFieldInfoPtr_victimSiteIsStreet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "victimSiteIsStreet");
		NativeFieldInfoPtr_triggerCoverUpCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "triggerCoverUpCall");
		NativeFieldInfoPtr_playerAcceptedCoverUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "playerAcceptedCoverUp");
		NativeFieldInfoPtr_triggerCoverUpSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "triggerCoverUpSuccess");
		NativeFieldInfoPtr_murders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "murders");
		NativeFieldInfoPtr_iaMurders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "iaMurders");
		NativeFieldInfoPtr_evidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "evidence");
		NativeFieldInfoPtr_timeEvidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "timeEvidence");
		NativeFieldInfoPtr_dateEvidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "dateEvidence");
		NativeFieldInfoPtr_customStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "customStrings");
		NativeFieldInfoPtr_spatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "spatter");
		NativeFieldInfoPtr_furnitureStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "furnitureStorage");
		NativeFieldInfoPtr_airDuctExploration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "airDuctExploration");
		NativeFieldInfoPtr_freeHealthCareFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "freeHealthCareFlag");
		NativeFieldInfoPtr_notTheAnswerFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "notTheAnswerFlag");
		NativeFieldInfoPtr_privateSlyFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "privateSlyFlag");
		NativeFieldInfoPtr_allConnectedReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "allConnectedReference");
		NativeFieldInfoPtr_pacifistFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "pacifistFlag");
		NativeFieldInfoPtr_notAScratchFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "notAScratchFlag");
		NativeFieldInfoPtr_spareNoOneReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "spareNoOneReference");
		NativeFieldInfoPtr_snail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "snail");
		NativeFieldInfoPtr_floors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "floors");
		NativeFieldInfoPtr_addresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "addresses");
		NativeFieldInfoPtr_guestPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "guestPasses");
		NativeFieldInfoPtr_rooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "rooms");
		NativeFieldInfoPtr_metas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "metas");
		NativeFieldInfoPtr_interactables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "interactables");
		NativeFieldInfoPtr_removedCityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "removedCityData");
		NativeFieldInfoPtr_citizens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "citizens");
		NativeFieldInfoPtr_doors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, "doors");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr, 100670343);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242151, RefRangeEnd = 242152, XrefRangeStart = 241818, XrefRangeEnd = 242151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StateSaveData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateSaveData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StateSaveData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
