using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.InteropServices;
using UnityEngine.Networking;

public class LZ4 : Il2CppSystem.Object
{
	public class CustomWebRequest4 : DownloadHandlerScript
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		static CustomWebRequest4()
		{
			Il2CppClassPointerStore<CustomWebRequest4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LZ4>.NativeClassPtr, "CustomWebRequest4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWebRequest4>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest4>.NativeClassPtr, 100663433);
			NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest4>.NativeClassPtr, 100663434);
			NativeMethodInfoPtr_GetData_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest4>.NativeClassPtr, 100663435);
			NativeMethodInfoPtr_ReceiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest4>.NativeClassPtr, 100663436);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomWebRequest4()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWebRequest4>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomWebRequest4(Il2CppStructArray<byte> buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWebRequest4>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe override Il2CppStructArray<byte> GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetData_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2289, XrefRangeEnd = 2303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReceiveData(Il2CppStructArray<byte> bytesFromServer, int dataLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytesFromServer);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataLength;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReceiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public CustomWebRequest4(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("LZ4+<downloadLZ4FileNative>d__24")]
	public sealed class _downloadLZ4FileNative_d__24 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_url;

		private static readonly System.IntPtr NativeFieldInfoPtr_downloadDone;

		private static readonly System.IntPtr NativeFieldInfoPtr_pointer;

		private static readonly System.IntPtr NativeFieldInfoPtr_fileSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__wr_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__zipSize_5__3;

		private static readonly System.IntPtr NativeFieldInfoPtr__wwwSK_5__4;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe string url
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_url)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Il2CppSystem.Action<bool> downloadDone
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downloadDone);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downloadDone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe Il2CppSystem.Action<System.IntPtr> pointer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<System.IntPtr>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe Il2CppSystem.Action<int> fileSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileSize);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileSize)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe UnityWebRequest _wr_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wr_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wr_5__2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityWebRequest));
			}
		}

		public unsafe int _zipSize_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__zipSize_5__3);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__zipSize_5__3)) = num;
			}
		}

		public unsafe UnityWebRequest _wwwSK_5__4
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wwwSK_5__4);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__wwwSK_5__4)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityWebRequest));
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1008, RefRangeEnd = 1012, XrefRangeStart = 1008, XrefRangeEnd = 1012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		static _downloadLZ4FileNative_d__24()
		{
			Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LZ4>.NativeClassPtr, "<downloadLZ4FileNative>d__24");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, "url");
			NativeFieldInfoPtr_downloadDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, "downloadDone");
			NativeFieldInfoPtr_pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, "pointer");
			NativeFieldInfoPtr_fileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, "fileSize");
			NativeFieldInfoPtr__wr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, "<wr>5__2");
			NativeFieldInfoPtr__zipSize_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, "<zipSize>5__3");
			NativeFieldInfoPtr__wwwSK_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, "<wwwSK>5__4");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, 100663437);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, 100663438);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, 100663439);
			NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, 100663440);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, 100663441);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, 100663442);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr, 100663443);
		}

		[CallerCount(0)]
		public unsafe _downloadLZ4FileNative_d__24(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_downloadLZ4FileNative_d__24>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2303, XrefRangeEnd = 2306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2306, XrefRangeEnd = 2385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2385, XrefRangeEnd = 2388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2388, XrefRangeEnd = 2394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _downloadLZ4FileNative_d__24(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_isle;

	private static readonly System.IntPtr NativeFieldInfoPtr_libname;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeBufferIsBeingUsed;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeOffset;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4DecompressFile_Internal_Static_Int32_String_String_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4CompressFile_Internal_Static_Int32_String_String_Int32_IntPtr_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4releaseBuffer_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4Create_Buffer_Public_Static_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4AddTo_Buffer_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4CompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_byref_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LZ4DecompressBuffer_Internal_Static_Int32_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gcA_Internal_Static_GCHandle_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFilePermissions_Public_Static_Int32_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkObject_Private_Static_Boolean_Object_String_byref_GCHandle_byref_IntPtr_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compress_Public_Static_Single_String_String_Int32_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompress_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBufferPartialFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBufferPartialFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_downloadLZ4FileNative_Public_Static_IEnumerator_String_Action_1_Boolean_Action_1_IntPtr_Action_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool isle
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isle, (void*)(&flag));
		}
	}

	public unsafe static string libname
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_libname, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_libname, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static System.IntPtr nativeBuffer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nativeBuffer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nativeBuffer, (void*)(&intPtr));
		}
	}

	public unsafe static bool nativeBufferIsBeingUsed
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nativeBufferIsBeingUsed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nativeBufferIsBeingUsed, (void*)(&flag));
		}
	}

	public unsafe static int nativeOffset
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nativeOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nativeOffset, (void*)(&num));
		}
	}

	static LZ4()
	{
		Il2CppClassPointerStore<LZ4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LZ4");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LZ4>.NativeClassPtr);
		NativeFieldInfoPtr_isle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4>.NativeClassPtr, "isle");
		NativeFieldInfoPtr_libname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4>.NativeClassPtr, "libname");
		NativeFieldInfoPtr_nativeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4>.NativeClassPtr, "nativeBuffer");
		NativeFieldInfoPtr_nativeBufferIsBeingUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4>.NativeClassPtr, "nativeBufferIsBeingUsed");
		NativeFieldInfoPtr_nativeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LZ4>.NativeClassPtr, "nativeOffset");
		NativeMethodInfoPtr_LZ4DecompressFile_Internal_Static_Int32_String_String_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_LZ4CompressFile_Internal_Static_Int32_String_String_Int32_IntPtr_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_LZ4releaseBuffer_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_LZ4Create_Buffer_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_LZ4AddTo_Buffer_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_LZ4CompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_LZ4DecompressBuffer_Internal_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_gcA_Internal_Static_GCHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_setFilePermissions_Public_Static_Int32_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_checkObject_Private_Static_Boolean_Object_String_byref_GCHandle_byref_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_compress_Public_Static_Single_String_String_Int32_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_decompress_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_compressBufferPartialFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_decompressBufferPartialFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_decompressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_downloadLZ4FileNative_Public_Static_IEnumerator_String_Action_1_Boolean_Action_1_IntPtr_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LZ4>.NativeClassPtr, 100663431);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2394, XrefRangeEnd = 2398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4DecompressFile(string inFile, string outFile, System.IntPtr bytes, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bytes;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4DecompressFile_Internal_Static_Int32_String_String_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2398, XrefRangeEnd = 2402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4CompressFile(string inFile, string outFile, int level, System.IntPtr percentage, ref float rate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &percentage;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4CompressFile_Internal_Static_Int32_String_String_Int32_IntPtr_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2402, XrefRangeEnd = 2404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LZ4releaseBuffer(System.IntPtr buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4releaseBuffer_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2404, XrefRangeEnd = 2406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr LZ4Create_Buffer(int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4Create_Buffer_Public_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2406, XrefRangeEnd = 2408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LZ4AddTo_Buffer(System.IntPtr destination, int offset, System.IntPtr buffer, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&destination);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4AddTo_Buffer_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2408, XrefRangeEnd = 2410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr LZ4CompressBuffer(System.IntPtr buffer, int bufferLength, ref int v, int level)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLength;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4CompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_byref_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 2412, RefRangeEnd = 2418, XrefRangeStart = 2410, XrefRangeEnd = 2412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LZ4DecompressBuffer(System.IntPtr buffer, System.IntPtr outbuffer, int bufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&buffer);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &outbuffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LZ4DecompressBuffer_Internal_Static_Int32_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GCHandle gcA(Il2CppSystem.Object o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gcA_Internal_Static_GCHandle_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(GCHandle*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int setFilePermissions(string filePath, string _user, string _group, string _other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_user);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_group);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_other);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFilePermissions_Public_Static_Int32_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2418, XrefRangeEnd = 2428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool checkObject(Il2CppSystem.Object fileBuffer, string filePath, ref GCHandle fbuf, ref System.IntPtr fileBufferPointer, ref int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref fbuf);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref fileBufferPointer);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref fileBufferLength);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkObject_Private_Static_Boolean_Object_String_byref_GCHandle_byref_IntPtr_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2441, RefRangeEnd = 2443, XrefRangeStart = 2428, XrefRangeEnd = 2441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float compress(string inFile, string outFile, int level, Il2CppStructArray<float> progress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compress_Public_Static_Single_String_String_Int32_Il2CppStructArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2458, RefRangeEnd = 2460, XrefRangeStart = 2443, XrefRangeEnd = 2458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompress(string inFile, string outFile, Il2CppStructArray<ulong> bytes, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompress_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2505, RefRangeEnd = 2506, XrefRangeStart = 2460, XrefRangeEnd = 2505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool compressBuffer(Il2CppStructArray<byte> inBuffer, ref Il2CppStructArray<byte> outBuffer, int level, bool includeSize = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeSize;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2506, XrefRangeEnd = 2550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> compressBuffer(Il2CppStructArray<byte> inBuffer, int level, bool includeSize = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeSize;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2550, XrefRangeEnd = 2582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int compressBufferPartialFixed(Il2CppStructArray<byte> inBuffer, ref Il2CppStructArray<byte> outBuffer, int outBufferPartialIndex, int level, bool includeSize = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &outBufferPartialIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeSize;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBufferPartialFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2582, XrefRangeEnd = 2596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompressBufferPartialFixed(Il2CppStructArray<byte> inBuffer, ref Il2CppStructArray<byte> outBuffer, int partialIndex, int compressedBufferSize, bool safe = true, bool useFooter = true, int customLength = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &partialIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &compressedBufferSize;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &safe;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &useFooter;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &customLength;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressBufferPartialFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2596, XrefRangeEnd = 2612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decompressBuffer(Il2CppStructArray<byte> inBuffer, ref Il2CppStructArray<byte> outBuffer, bool useFooter = true, int customLength = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useFooter;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &customLength;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2612, XrefRangeEnd = 2626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompressBufferFixed(Il2CppStructArray<byte> inBuffer, ref Il2CppStructArray<byte> outBuffer, bool safe = true, bool useFooter = true, int customLength = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &safe;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &useFooter;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &customLength;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2626, XrefRangeEnd = 2642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> decompressBuffer(Il2CppStructArray<byte> inBuffer, bool useFooter = true, int customLength = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useFooter;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &customLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2642, XrefRangeEnd = 2645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator downloadLZ4FileNative(string url, Il2CppSystem.Action<bool> downloadDone, Il2CppSystem.Action<System.IntPtr> pointer = null, Il2CppSystem.Action<int> fileSize = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)downloadDone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileSize);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_downloadLZ4FileNative_Public_Static_IEnumerator_String_Action_1_Boolean_Action_1_IntPtr_Action_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LZ4()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LZ4>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LZ4(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
