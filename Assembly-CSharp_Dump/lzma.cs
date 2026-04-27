using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using UnityEngine.Networking;

public class lzma : Il2CppSystem.Object
{
	public enum dic
	{
		K0004 = 0x1000,
		K0008 = 0x2000,
		K0016 = 0x4000,
		K0032 = 0x8000,
		K0064 = 0x10000,
		K0128 = 0x20000,
		K0256 = 0x40000,
		K0512 = 0x80000,
		K1024 = 0x100000,
		K2048 = 0x200000
	}

	public class CustomWebRequest2 : DownloadHandlerScript
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		static CustomWebRequest2()
		{
			Il2CppClassPointerStore<CustomWebRequest2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<lzma>.NativeClassPtr, "CustomWebRequest2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWebRequest2>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest2>.NativeClassPtr, 100663500);
			NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest2>.NativeClassPtr, 100663501);
			NativeMethodInfoPtr_GetData_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest2>.NativeClassPtr, 100663502);
			NativeMethodInfoPtr_ReceiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest2>.NativeClassPtr, 100663503);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomWebRequest2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWebRequest2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomWebRequest2(Il2CppStructArray<byte> buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWebRequest2>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2871, XrefRangeEnd = 2885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		public CustomWebRequest2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("lzma+<download7zFileNative>d__49")]
	public sealed class _download7zFileNative_d__49 : Il2CppSystem.Object
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

		static _download7zFileNative_d__49()
		{
			Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<lzma>.NativeClassPtr, "<download7zFileNative>d__49");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, "url");
			NativeFieldInfoPtr_downloadDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, "downloadDone");
			NativeFieldInfoPtr_pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, "pointer");
			NativeFieldInfoPtr_fileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, "fileSize");
			NativeFieldInfoPtr__wr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, "<wr>5__2");
			NativeFieldInfoPtr__zipSize_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, "<zipSize>5__3");
			NativeFieldInfoPtr__wwwSK_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, "<wwwSK>5__4");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, 100663504);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, 100663505);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, 100663506);
			NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, 100663507);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, 100663508);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, 100663509);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr, 100663510);
		}

		[CallerCount(0)]
		public unsafe _download7zFileNative_d__49(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_download7zFileNative_d__49>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2885, XrefRangeEnd = 2888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2888, XrefRangeEnd = 2967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2967, XrefRangeEnd = 2970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2970, XrefRangeEnd = 2976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _download7zFileNative_d__49(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_persitentDataPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_props;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultsSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_libname;

	private static readonly System.IntPtr NativeFieldInfoPtr_ninfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_sinfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_trueTotalFiles;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeBufferIsBeingUsed;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeOffset;

	private static readonly System.IntPtr NativeMethodInfoPtr_setProps_Public_Static_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompress7zip_Internal_Static_Int32_String_String_Boolean_String_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompress7zip2_Internal_Static_Int32_String_String_Boolean_String_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__getSize_Internal_Static_IntPtr_String_IntPtr_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entrySize_Internal_Static_UInt64_String_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lzmaUtil_Internal_Static_Int32_Boolean_String_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decode2Buf_Internal_Static_Int32_String_String_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__releaseBuffer_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__createBuffer_Public_Static_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__addToBuffer_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lzma_Compress_Internal_Static_IntPtr_IntPtr_Int32_Boolean_byref_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lzma_Uncompress_Internal_Static_Int32_IntPtr_Int32_Int32_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sevenZcancel_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resetBytesRead_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBytesRead_Public_Static_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBytesWritten_Public_Static_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gcA_Internal_Static_GCHandle_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFilePermissions_Public_Static_Int32_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkObject_Private_Static_Boolean_Object_String_byref_GCHandle_byref_IntPtr_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doDecompress7zip_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Boolean_Boolean_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doDecompress7zip_Public_Static_Int32_String_String_Boolean_Boolean_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LzmaUtilEncode_Public_Static_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LzmaUtilDecode_Public_Static_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get7zInfo_Public_Static_UInt64_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get7zSize_Public_Static_UInt64_String_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getHeadersSize_Public_Static_UInt32_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decode2Buffer_Public_Static_Il2CppStructArray_1_Byte_String_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getAllFiles_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFileSize_Public_Static_Int64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getDirSize_Public_Static_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBufferPartial_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBufferPartialFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBuffer_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_download7zFileNative_Public_Static_IEnumerator_String_Action_1_Boolean_Action_1_IntPtr_Action_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string persitentDataPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_persitentDataPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_persitentDataPath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Il2CppStructArray<int> props
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_props, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_props, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static bool defaultsSet
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultsSet, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultsSet, (void*)(&flag));
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

	public unsafe static List<string> ninfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ninfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ninfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<ulong> sinfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sinfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ulong>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sinfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static int trueTotalFiles
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_trueTotalFiles, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_trueTotalFiles, (void*)(&num));
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

	static lzma()
	{
		Il2CppClassPointerStore<lzma>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "lzma");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<lzma>.NativeClassPtr);
		NativeFieldInfoPtr_persitentDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzma>.NativeClassPtr, "persitentDataPath");
		NativeFieldInfoPtr_props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzma>.NativeClassPtr, "props");
		NativeFieldInfoPtr_defaultsSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzma>.NativeClassPtr, "defaultsSet");
		NativeFieldInfoPtr_libname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzma>.NativeClassPtr, "libname");
		NativeFieldInfoPtr_ninfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzma>.NativeClassPtr, "ninfo");
		NativeFieldInfoPtr_sinfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzma>.NativeClassPtr, "sinfo");
		NativeFieldInfoPtr_trueTotalFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzma>.NativeClassPtr, "trueTotalFiles");
		NativeFieldInfoPtr_nativeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzma>.NativeClassPtr, "nativeBuffer");
		NativeFieldInfoPtr_nativeBufferIsBeingUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzma>.NativeClassPtr, "nativeBufferIsBeingUsed");
		NativeFieldInfoPtr_nativeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzma>.NativeClassPtr, "nativeOffset");
		NativeMethodInfoPtr_setProps_Public_Static_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663459);
		NativeMethodInfoPtr_decompress7zip_Internal_Static_Int32_String_String_Boolean_String_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663460);
		NativeMethodInfoPtr_decompress7zip2_Internal_Static_Int32_String_String_Boolean_String_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663461);
		NativeMethodInfoPtr__getSize_Internal_Static_IntPtr_String_IntPtr_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663462);
		NativeMethodInfoPtr_entrySize_Internal_Static_UInt64_String_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663463);
		NativeMethodInfoPtr_lzmaUtil_Internal_Static_Int32_Boolean_String_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663464);
		NativeMethodInfoPtr_decode2Buf_Internal_Static_Int32_String_String_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663465);
		NativeMethodInfoPtr__releaseBuffer_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663466);
		NativeMethodInfoPtr__createBuffer_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663467);
		NativeMethodInfoPtr__addToBuffer_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663468);
		NativeMethodInfoPtr_Lzma_Compress_Internal_Static_IntPtr_IntPtr_Int32_Boolean_byref_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663469);
		NativeMethodInfoPtr_Lzma_Uncompress_Internal_Static_Int32_IntPtr_Int32_Int32_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663470);
		NativeMethodInfoPtr_sevenZcancel_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663471);
		NativeMethodInfoPtr_resetBytesRead_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663472);
		NativeMethodInfoPtr_getBytesRead_Public_Static_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663473);
		NativeMethodInfoPtr_getBytesWritten_Public_Static_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663474);
		NativeMethodInfoPtr_gcA_Internal_Static_GCHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663475);
		NativeMethodInfoPtr_setFilePermissions_Public_Static_Int32_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663476);
		NativeMethodInfoPtr_checkObject_Private_Static_Boolean_Object_String_byref_GCHandle_byref_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663477);
		NativeMethodInfoPtr_doDecompress7zip_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Boolean_Boolean_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663478);
		NativeMethodInfoPtr_doDecompress7zip_Public_Static_Int32_String_String_Boolean_Boolean_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663479);
		NativeMethodInfoPtr_LzmaUtilEncode_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663480);
		NativeMethodInfoPtr_LzmaUtilDecode_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_get7zInfo_Public_Static_UInt64_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_get7zSize_Public_Static_UInt64_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_getHeadersSize_Public_Static_UInt32_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_decode2Buffer_Public_Static_Il2CppStructArray_1_Byte_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_getAllFiles_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_getFileSize_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr_getDirSize_Public_Static_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_compressBufferPartial_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_compressBufferPartialFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_compressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663493);
		NativeMethodInfoPtr_decompressBuffer_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663495);
		NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663496);
		NativeMethodInfoPtr_download7zFileNative_Public_Static_IEnumerator_String_Action_1_Boolean_Action_1_IntPtr_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzma>.NativeClassPtr, 100663498);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 2987, RefRangeEnd = 2996, XrefRangeStart = 2976, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setProps(int level = 5, int dictSize = 65536, int lc = 3, int lp = 0, int pb = 2, int fb = 32, int numThreads = 2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&level);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dictSize;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lc;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lp;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &pb;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &fb;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &numThreads;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setProps_Public_Static_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3001, RefRangeEnd = 3003, XrefRangeStart = 2996, XrefRangeEnd = 3001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompress7zip(string filePath, string exctractionPath, bool fullPaths, string entry, System.IntPtr progress, System.IntPtr FileBuffer, int FileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(exctractionPath);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullPaths;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &progress;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompress7zip_Internal_Static_Int32_String_String_Boolean_String_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3008, RefRangeEnd = 3010, XrefRangeStart = 3003, XrefRangeEnd = 3008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompress7zip2(string filePath, string exctractionPath, bool fullPaths, string entry, System.IntPtr progress, System.IntPtr FileBuffer, int FileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(exctractionPath);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullPaths;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &progress;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompress7zip2_Internal_Static_Int32_String_String_Boolean_String_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3013, RefRangeEnd = 3016, XrefRangeStart = 3010, XrefRangeEnd = 3013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr _getSize(string filePath, System.IntPtr FileBuffer, int FileBufferLength, bool justParse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBufferLength;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &justParse;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__getSize_Internal_Static_IntPtr_String_IntPtr_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3016, XrefRangeEnd = 3020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong entrySize(string filePath, string entry, System.IntPtr FileBuffer, int FileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entrySize_Internal_Static_UInt64_String_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3024, RefRangeEnd = 3026, XrefRangeStart = 3020, XrefRangeEnd = 3024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int lzmaUtil(bool encode, string inPath, string outPath, System.IntPtr Props)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&encode);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &Props;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lzmaUtil_Internal_Static_Int32_Boolean_String_String_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3026, XrefRangeEnd = 3030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decode2Buf(string filePath, string entry, System.IntPtr buffer, System.IntPtr FileBuffer, int FileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decode2Buf_Internal_Static_Int32_String_String_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 3032, RefRangeEnd = 3039, XrefRangeStart = 3030, XrefRangeEnd = 3032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _releaseBuffer(System.IntPtr buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__releaseBuffer_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3039, XrefRangeEnd = 3041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr _createBuffer(int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__createBuffer_Public_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3041, XrefRangeEnd = 3043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _addToBuffer(System.IntPtr destination, int offset, System.IntPtr buffer, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&destination);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__addToBuffer_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3043, XrefRangeEnd = 3045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Lzma_Compress(System.IntPtr buffer, int bufferLength, bool makeHeader, ref int v, System.IntPtr Props)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLength;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &makeHeader;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &Props;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lzma_Compress_Internal_Static_IntPtr_IntPtr_Int32_Boolean_byref_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3047, RefRangeEnd = 3050, XrefRangeStart = 3045, XrefRangeEnd = 3047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Lzma_Uncompress(System.IntPtr buffer, int bufferLength, int uncompressedSize, System.IntPtr outbuffer, bool useHeader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLength;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &uncompressedSize;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outbuffer;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &useHeader;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lzma_Uncompress_Internal_Static_Int32_IntPtr_Int32_Int32_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3050, XrefRangeEnd = 3052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void sevenZcancel()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sevenZcancel_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3052, XrefRangeEnd = 3054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resetBytesRead()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resetBytesRead_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 3056, RefRangeEnd = 3061, XrefRangeStart = 3054, XrefRangeEnd = 3056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong getBytesRead()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBytesRead_Public_Static_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 3063, RefRangeEnd = 3068, XrefRangeStart = 3061, XrefRangeEnd = 3063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong getBytesWritten()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBytesWritten_Public_Static_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3068, XrefRangeEnd = 3078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 3112, RefRangeEnd = 3114, XrefRangeStart = 3078, XrefRangeEnd = 3112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int doDecompress7zip(string filePath, string exctractionPath = null, Il2CppStructArray<int> progress = null, bool largeFiles = false, bool fullPaths = true, string entry = null, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(exctractionPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &largeFiles;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullPaths;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doDecompress7zip_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Boolean_Boolean_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3148, RefRangeEnd = 3150, XrefRangeStart = 3114, XrefRangeEnd = 3148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int doDecompress7zip(string filePath, string exctractionPath = null, bool largeFiles = false, bool fullPaths = true, string entry = null, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(exctractionPath);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &largeFiles;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullPaths;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doDecompress7zip_Public_Static_Int32_String_String_Boolean_Boolean_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3163, RefRangeEnd = 3165, XrefRangeStart = 3150, XrefRangeEnd = 3163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LzmaUtilEncode(string inPath, string outPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LzmaUtilEncode_Public_Static_Int32_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3171, RefRangeEnd = 3173, XrefRangeStart = 3165, XrefRangeEnd = 3171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LzmaUtilDecode(string inPath, string outPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LzmaUtilDecode_Public_Static_Int32_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3230, RefRangeEnd = 3231, XrefRangeStart = 3173, XrefRangeEnd = 3230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong get7zInfo(string filePath, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get7zInfo_Public_Static_UInt64_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3245, RefRangeEnd = 3248, XrefRangeStart = 3231, XrefRangeEnd = 3245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong get7zSize(string filePath = null, string entry = null, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get7zSize_Public_Static_UInt64_String_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3248, XrefRangeEnd = 3261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint getHeadersSize(string filePath, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getHeadersSize_Public_Static_UInt32_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3284, RefRangeEnd = 3285, XrefRangeStart = 3261, XrefRangeEnd = 3284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> decode2Buffer(string filePath, string entry, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decode2Buffer_Public_Static_Il2CppStructArray_1_Byte_String_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3285, XrefRangeEnd = 3288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getAllFiles(string dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getAllFiles_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3288, XrefRangeEnd = 3292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long getFileSize(string file)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFileSize_Public_Static_Int64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3292, XrefRangeEnd = 3301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong getDirSize(string dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDirSize_Public_Static_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3330, RefRangeEnd = 3331, XrefRangeStart = 3301, XrefRangeEnd = 3330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool compressBuffer(Il2CppStructArray<byte> inBuffer, ref Il2CppStructArray<byte> outBuffer, bool makeHeader = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &makeHeader;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3331, XrefRangeEnd = 3360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> compressBuffer(Il2CppStructArray<byte> inBuffer, bool makeHeader = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &makeHeader;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3360, XrefRangeEnd = 3388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool compressBufferPartial(Il2CppStructArray<byte> inBuffer, int inBufferPartialIndex, int inBufferPartialLength, ref Il2CppStructArray<byte> outBuffer, bool makeHeader = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inBufferPartialIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inBufferPartialLength;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &makeHeader;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBufferPartial_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3388, XrefRangeEnd = 3413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int compressBufferPartialFixed(Il2CppStructArray<byte> inBuffer, int inBufferPartialIndex, int inBufferPartialLength, ref Il2CppStructArray<byte> outBuffer, bool safe = true, bool makeHeader = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inBufferPartialIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inBufferPartialLength;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &safe;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &makeHeader;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBufferPartialFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3439, RefRangeEnd = 3440, XrefRangeStart = 3413, XrefRangeEnd = 3439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int compressBufferFixed(Il2CppStructArray<byte> inBuffer, ref Il2CppStructArray<byte> outBuffer, bool safe = true, bool makeHeader = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &safe;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &makeHeader;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3461, RefRangeEnd = 3462, XrefRangeStart = 3440, XrefRangeEnd = 3461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompressBuffer(Il2CppStructArray<byte> inBuffer, ref Il2CppStructArray<byte> outbuffer, bool useHeader = true, int customLength = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outbuffer);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useHeader;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &customLength;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressBuffer_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outbuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3462, XrefRangeEnd = 3483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> decompressBuffer(Il2CppStructArray<byte> inBuffer, bool useHeader = true, int customLength = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &useHeader;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &customLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3500, RefRangeEnd = 3501, XrefRangeStart = 3483, XrefRangeEnd = 3500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompressBufferFixed(Il2CppStructArray<byte> inBuffer, ref Il2CppStructArray<byte> outbuffer, bool safe = true, bool useHeader = true, int customLength = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inBuffer);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outbuffer);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &safe;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &useHeader;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &customLength;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outbuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3501, XrefRangeEnd = 3504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator download7zFileNative(string url, Il2CppSystem.Action<bool> downloadDone, Il2CppSystem.Action<System.IntPtr> pointer = null, Il2CppSystem.Action<int> fileSize = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)downloadDone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileSize);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_download7zFileNative_Public_Static_IEnumerator_String_Action_1_Boolean_Action_1_IntPtr_Action_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe lzma()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<lzma>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public lzma(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
