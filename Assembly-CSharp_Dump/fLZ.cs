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

public class fLZ : Il2CppSystem.Object
{
	public class CustomWebRequest3 : DownloadHandlerScript
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		static CustomWebRequest3()
		{
			Il2CppClassPointerStore<CustomWebRequest3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<fLZ>.NativeClassPtr, "CustomWebRequest3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWebRequest3>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest3>.NativeClassPtr, 100663385);
			NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest3>.NativeClassPtr, 100663386);
			NativeMethodInfoPtr_GetData_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest3>.NativeClassPtr, 100663387);
			NativeMethodInfoPtr_ReceiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest3>.NativeClassPtr, 100663388);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomWebRequest3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWebRequest3>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomWebRequest3(Il2CppStructArray<byte> buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWebRequest3>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1784, XrefRangeEnd = 1798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		public CustomWebRequest3(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("fLZ+<downloadFlzFileNative>d__22")]
	public sealed class _downloadFlzFileNative_d__22 : Il2CppSystem.Object
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

		static _downloadFlzFileNative_d__22()
		{
			Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<fLZ>.NativeClassPtr, "<downloadFlzFileNative>d__22");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, "url");
			NativeFieldInfoPtr_downloadDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, "downloadDone");
			NativeFieldInfoPtr_pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, "pointer");
			NativeFieldInfoPtr_fileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, "fileSize");
			NativeFieldInfoPtr__wr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, "<wr>5__2");
			NativeFieldInfoPtr__zipSize_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, "<zipSize>5__3");
			NativeFieldInfoPtr__wwwSK_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, "<wwwSK>5__4");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, 100663389);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, 100663390);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, 100663391);
			NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, 100663392);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, 100663393);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, 100663394);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr, 100663395);
		}

		[CallerCount(0)]
		public unsafe _downloadFlzFileNative_d__22(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_downloadFlzFileNative_d__22>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1798, XrefRangeEnd = 1801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1801, XrefRangeEnd = 1880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1880, XrefRangeEnd = 1883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1883, XrefRangeEnd = 1889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _downloadFlzFileNative_d__22(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_isle;

	private static readonly System.IntPtr NativeFieldInfoPtr_libname;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeBufferIsBeingUsed;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeOffset;

	private static readonly System.IntPtr NativeMethodInfoPtr_fLZcompressFile_Internal_Static_Int32_Int32_String_String_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_fLZdecompressFile_Internal_Static_Int32_String_String_Boolean_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_fLZreleaseBuffer_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_create_Buffer_Public_Static_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addTo_Buffer_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_fLZcompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_fLZdecompressBuffer_Internal_Static_Int32_IntPtr_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFilePermissions_Public_Static_Int32_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gcA_Internal_Static_GCHandle_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkObject_Private_Static_Boolean_Object_String_byref_GCHandle_byref_IntPtr_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressFile_Public_Static_Int32_String_String_Int32_Boolean_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressFile_Public_Static_Int32_String_String_Boolean_Il2CppStructArray_1_UInt64_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_downloadFlzFileNative_Public_Static_IEnumerator_String_Action_1_Boolean_Action_1_IntPtr_Action_1_Int32_0;

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

	static fLZ()
	{
		Il2CppClassPointerStore<fLZ>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "fLZ");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<fLZ>.NativeClassPtr);
		NativeFieldInfoPtr_isle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fLZ>.NativeClassPtr, "isle");
		NativeFieldInfoPtr_libname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fLZ>.NativeClassPtr, "libname");
		NativeFieldInfoPtr_nativeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fLZ>.NativeClassPtr, "nativeBuffer");
		NativeFieldInfoPtr_nativeBufferIsBeingUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fLZ>.NativeClassPtr, "nativeBufferIsBeingUsed");
		NativeFieldInfoPtr_nativeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<fLZ>.NativeClassPtr, "nativeOffset");
		NativeMethodInfoPtr_fLZcompressFile_Internal_Static_Int32_Int32_String_String_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_fLZdecompressFile_Internal_Static_Int32_String_String_Boolean_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_fLZreleaseBuffer_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_create_Buffer_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_addTo_Buffer_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_fLZcompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_fLZdecompressBuffer_Internal_Static_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_setFilePermissions_Public_Static_Int32_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_gcA_Internal_Static_GCHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_checkObject_Private_Static_Boolean_Object_String_byref_GCHandle_byref_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_compressFile_Public_Static_Int32_String_String_Int32_Boolean_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_decompressFile_Public_Static_Int32_String_String_Boolean_Il2CppStructArray_1_UInt64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_decompressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_downloadFlzFileNative_Public_Static_IEnumerator_String_Action_1_Boolean_Action_1_IntPtr_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<fLZ>.NativeClassPtr, 100663383);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1889, XrefRangeEnd = 1893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int fLZcompressFile(int level, string inFile, string outFile, bool overwrite, System.IntPtr percent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&level);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &overwrite;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &percent;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fLZcompressFile_Internal_Static_Int32_Int32_String_String_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1893, XrefRangeEnd = 1897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int fLZdecompressFile(string inFile, string outFile, bool overwrite, System.IntPtr percent, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &overwrite;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &percent;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fLZdecompressFile_Internal_Static_Int32_String_String_Boolean_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1897, XrefRangeEnd = 1899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void fLZreleaseBuffer(System.IntPtr buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fLZreleaseBuffer_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1899, XrefRangeEnd = 1901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr create_Buffer(int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_create_Buffer_Public_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1901, XrefRangeEnd = 1903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addTo_Buffer(System.IntPtr destination, int offset, System.IntPtr buffer, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&destination);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addTo_Buffer_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1903, XrefRangeEnd = 1905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr fLZcompressBuffer(System.IntPtr buffer, int bufferLength, int level, ref int v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLength;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fLZcompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1907, RefRangeEnd = 1910, XrefRangeStart = 1905, XrefRangeEnd = 1907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int fLZdecompressBuffer(System.IntPtr buffer, int bufferLength, System.IntPtr outbuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLength;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &outbuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fLZdecompressBuffer_Internal_Static_Int32_IntPtr_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1910, XrefRangeEnd = 1920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1933, RefRangeEnd = 1935, XrefRangeStart = 1920, XrefRangeEnd = 1933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int compressFile(string inFile, string outFile, int level, bool overwrite, Il2CppStructArray<ulong> progress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &overwrite;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressFile_Public_Static_Int32_String_String_Int32_Boolean_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1950, RefRangeEnd = 1952, XrefRangeStart = 1935, XrefRangeEnd = 1950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompressFile(string inFile, string outFile, bool overwrite, Il2CppStructArray<ulong> progress, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &overwrite;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressFile_Public_Static_Int32_String_String_Boolean_Il2CppStructArray_1_UInt64_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1997, RefRangeEnd = 1998, XrefRangeStart = 1952, XrefRangeEnd = 1997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1998, XrefRangeEnd = 2042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2059, RefRangeEnd = 2060, XrefRangeStart = 2042, XrefRangeEnd = 2059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2074, RefRangeEnd = 2075, XrefRangeStart = 2060, XrefRangeEnd = 2074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2075, XrefRangeEnd = 2091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2091, XrefRangeEnd = 2094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator downloadFlzFileNative(string url, Il2CppSystem.Action<bool> downloadDone, Il2CppSystem.Action<System.IntPtr> pointer = null, Il2CppSystem.Action<int> fileSize = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)downloadDone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileSize);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_downloadFlzFileNative_Public_Static_IEnumerator_String_Action_1_Boolean_Action_1_IntPtr_Action_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe fLZ()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<fLZ>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public fLZ(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
