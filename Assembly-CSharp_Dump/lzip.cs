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
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.InteropServices;
using UnityEngine.Networking;

public class lzip : Il2CppSystem.Object
{
	public class inMemory : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pointer;

		private static readonly System.IntPtr NativeFieldInfoPtr_zf;

		private static readonly System.IntPtr NativeFieldInfoPtr_memStruct;

		private static readonly System.IntPtr NativeFieldInfoPtr_fileStruct;

		private static readonly System.IntPtr NativeFieldInfoPtr_info;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastResult;

		private static readonly System.IntPtr NativeFieldInfoPtr_isClosed;

		private static readonly System.IntPtr NativeMethodInfoPtr_size_Public_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_memoryPointer_Public_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_getZipBuffer_Public_Il2CppStructArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe System.IntPtr pointer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointer);
				return *(System.IntPtr*)num;
			}
			set
			{
				*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointer)) = intPtr;
			}
		}

		public unsafe System.IntPtr zf
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zf);
				return *(System.IntPtr*)num;
			}
			set
			{
				*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zf)) = intPtr;
			}
		}

		public unsafe System.IntPtr memStruct
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memStruct);
				return *(System.IntPtr*)num;
			}
			set
			{
				*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memStruct)) = intPtr;
			}
		}

		public unsafe System.IntPtr fileStruct
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileStruct);
				return *(System.IntPtr*)num;
			}
			set
			{
				*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileStruct)) = intPtr;
			}
		}

		public unsafe Il2CppStructArray<int> info
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe int lastResult
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastResult);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastResult)) = num;
			}
		}

		public unsafe bool isClosed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClosed);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClosed)) = flag;
			}
		}

		static inMemory()
		{
			Il2CppClassPointerStore<inMemory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<lzip>.NativeClassPtr, "inMemory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<inMemory>.NativeClassPtr);
			NativeFieldInfoPtr_pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "pointer");
			NativeFieldInfoPtr_zf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "zf");
			NativeFieldInfoPtr_memStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "memStruct");
			NativeFieldInfoPtr_fileStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "fileStruct");
			NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "info");
			NativeFieldInfoPtr_lastResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "lastResult");
			NativeFieldInfoPtr_isClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<inMemory>.NativeClassPtr, "isClosed");
			NativeMethodInfoPtr_size_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<inMemory>.NativeClassPtr, 100663665);
			NativeMethodInfoPtr_memoryPointer_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<inMemory>.NativeClassPtr, 100663666);
			NativeMethodInfoPtr_getZipBuffer_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<inMemory>.NativeClassPtr, 100663667);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<inMemory>.NativeClassPtr, 100663668);
		}

		[CallerCount(0)]
		public unsafe int size()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_size_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 4139, RefRangeEnd = 4140, XrefRangeStart = 4139, XrefRangeEnd = 4139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe System.IntPtr memoryPointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_memoryPointer_Public_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 4149, RefRangeEnd = 4151, XrefRangeStart = 4140, XrefRangeEnd = 4149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> getZipBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getZipBuffer_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}

		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 4159, RefRangeEnd = 4168, XrefRangeStart = 4151, XrefRangeEnd = 4159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe inMemory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<inMemory>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public inMemory(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class zipInfo : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_VersionMadeBy;

		private static readonly System.IntPtr NativeFieldInfoPtr_MinimumVersionToExtract;

		private static readonly System.IntPtr NativeFieldInfoPtr_BitFlag;

		private static readonly System.IntPtr NativeFieldInfoPtr_CompressionMethod;

		private static readonly System.IntPtr NativeFieldInfoPtr_FileLastModificationTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_FileLastModificationDate;

		private static readonly System.IntPtr NativeFieldInfoPtr_CRC;

		private static readonly System.IntPtr NativeFieldInfoPtr_CompressedSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_UncompressedSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_DiskNumberWhereFileStarts;

		private static readonly System.IntPtr NativeFieldInfoPtr_InternalFileAttributes;

		private static readonly System.IntPtr NativeFieldInfoPtr_ExternalFileAttributes;

		private static readonly System.IntPtr NativeFieldInfoPtr_RelativeOffsetOfLocalFileHeader;

		private static readonly System.IntPtr NativeFieldInfoPtr_AbsoluteOffsetOfLocalFileHeaderStore;

		private static readonly System.IntPtr NativeFieldInfoPtr_filename;

		private static readonly System.IntPtr NativeFieldInfoPtr_extraField;

		private static readonly System.IntPtr NativeFieldInfoPtr_fileComment;

		public unsafe short VersionMadeBy
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VersionMadeBy);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VersionMadeBy)) = num;
			}
		}

		public unsafe short MinimumVersionToExtract
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumVersionToExtract);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumVersionToExtract)) = num;
			}
		}

		public unsafe short BitFlag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BitFlag);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BitFlag)) = num;
			}
		}

		public unsafe short CompressionMethod
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompressionMethod);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompressionMethod)) = num;
			}
		}

		public unsafe short FileLastModificationTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileLastModificationTime);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileLastModificationTime)) = num;
			}
		}

		public unsafe short FileLastModificationDate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileLastModificationDate);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FileLastModificationDate)) = num;
			}
		}

		public unsafe int CRC
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CRC);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CRC)) = num;
			}
		}

		public unsafe int CompressedSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompressedSize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompressedSize)) = num;
			}
		}

		public unsafe int UncompressedSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UncompressedSize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UncompressedSize)) = num;
			}
		}

		public unsafe short DiskNumberWhereFileStarts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DiskNumberWhereFileStarts);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DiskNumberWhereFileStarts)) = num;
			}
		}

		public unsafe short InternalFileAttributes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InternalFileAttributes);
				return *(short*)num;
			}
			set
			{
				*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InternalFileAttributes)) = num;
			}
		}

		public unsafe int ExternalFileAttributes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExternalFileAttributes);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExternalFileAttributes)) = num;
			}
		}

		public unsafe int RelativeOffsetOfLocalFileHeader
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelativeOffsetOfLocalFileHeader);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RelativeOffsetOfLocalFileHeader)) = num;
			}
		}

		public unsafe int AbsoluteOffsetOfLocalFileHeaderStore
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AbsoluteOffsetOfLocalFileHeaderStore);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AbsoluteOffsetOfLocalFileHeaderStore)) = num;
			}
		}

		public unsafe string filename
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filename);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filename)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string extraField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraField)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string fileComment
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileComment);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileComment)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static zipInfo()
		{
			Il2CppClassPointerStore<zipInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<lzip>.NativeClassPtr, "zipInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<zipInfo>.NativeClassPtr);
			NativeFieldInfoPtr_VersionMadeBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "VersionMadeBy");
			NativeFieldInfoPtr_MinimumVersionToExtract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "MinimumVersionToExtract");
			NativeFieldInfoPtr_BitFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "BitFlag");
			NativeFieldInfoPtr_CompressionMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "CompressionMethod");
			NativeFieldInfoPtr_FileLastModificationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "FileLastModificationTime");
			NativeFieldInfoPtr_FileLastModificationDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "FileLastModificationDate");
			NativeFieldInfoPtr_CRC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "CRC");
			NativeFieldInfoPtr_CompressedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "CompressedSize");
			NativeFieldInfoPtr_UncompressedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "UncompressedSize");
			NativeFieldInfoPtr_DiskNumberWhereFileStarts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "DiskNumberWhereFileStarts");
			NativeFieldInfoPtr_InternalFileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "InternalFileAttributes");
			NativeFieldInfoPtr_ExternalFileAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "ExternalFileAttributes");
			NativeFieldInfoPtr_RelativeOffsetOfLocalFileHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "RelativeOffsetOfLocalFileHeader");
			NativeFieldInfoPtr_AbsoluteOffsetOfLocalFileHeaderStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "AbsoluteOffsetOfLocalFileHeaderStore");
			NativeFieldInfoPtr_filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "filename");
			NativeFieldInfoPtr_extraField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "extraField");
			NativeFieldInfoPtr_fileComment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zipInfo>.NativeClassPtr, "fileComment");
		}

		public zipInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public zipInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<zipInfo>.NativeClassPtr))
		{
		}
	}

	public class CustomWebRequest : DownloadHandlerScript
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		static CustomWebRequest()
		{
			Il2CppClassPointerStore<CustomWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<lzip>.NativeClassPtr, "CustomWebRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWebRequest>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest>.NativeClassPtr, 100663669);
			NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest>.NativeClassPtr, 100663670);
			NativeMethodInfoPtr_GetData_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest>.NativeClassPtr, 100663671);
			NativeMethodInfoPtr_ReceiveData_Protected_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWebRequest>.NativeClassPtr, 100663672);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomWebRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWebRequest>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomWebRequest(Il2CppStructArray<byte> buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWebRequest>.NativeClassPtr))
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4168, XrefRangeEnd = 4182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		public CustomWebRequest(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("lzip+<downloadZipFileNative>d__141")]
	public sealed class _downloadZipFileNative_d__141 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_url;

		private static readonly System.IntPtr NativeFieldInfoPtr_downloadDone;

		private static readonly System.IntPtr NativeFieldInfoPtr_inmem;

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

		public unsafe Il2CppSystem.Action<inMemory> inmem
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inmem);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<inMemory>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inmem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
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

		static _downloadZipFileNative_d__141()
		{
			Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<lzip>.NativeClassPtr, "<downloadZipFileNative>d__141");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, "url");
			NativeFieldInfoPtr_downloadDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, "downloadDone");
			NativeFieldInfoPtr_inmem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, "inmem");
			NativeFieldInfoPtr_pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, "pointer");
			NativeFieldInfoPtr_fileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, "fileSize");
			NativeFieldInfoPtr__wr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, "<wr>5__2");
			NativeFieldInfoPtr__zipSize_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, "<zipSize>5__3");
			NativeFieldInfoPtr__wwwSK_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, "<wwwSK>5__4");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, 100663673);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, 100663674);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, 100663675);
			NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, 100663676);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, 100663677);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, 100663678);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr, 100663679);
		}

		[CallerCount(0)]
		public unsafe _downloadZipFileNative_d__141(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_downloadZipFileNative_d__141>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4182, XrefRangeEnd = 4185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4185, XrefRangeEnd = 4271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4271, XrefRangeEnd = 4274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4274, XrefRangeEnd = 4280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _downloadZipFileNative_d__141(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_libname;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeBufferIsBeingUsed;

	private static readonly System.IntPtr NativeFieldInfoPtr_nativeOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_ninfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_uinfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_cinfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_localOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_zipFiles;

	private static readonly System.IntPtr NativeFieldInfoPtr_zipFolders;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalCompressedSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalUncompressedSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_zinfo;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTarEncoding_Public_Static_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setEncoding_Public_Static_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipValidateFile_Internal_Static_Boolean_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipGetTotalFiles_Internal_Static_Int32_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipGetTotalEntries_Internal_Static_Int32_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipGetInfoA_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipGetInfo_Internal_Static_IntPtr_String_Int32_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_releaseBuffer_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createBuffer_Public_Static_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addToBuffer_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipGetEntrySize_Internal_Static_UInt64_String_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipEntryExists_Internal_Static_Boolean_String_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCD_Internal_Static_Int32_Int32_String_String_String_String_String_Boolean_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCDList_Internal_Static_Int32_Int32_String_IntPtr_Int32_IntPtr_IntPtr_String_Boolean_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipBuf2File_Internal_Static_Boolean_Int32_String_String_IntPtr_Int32_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipDeleteFile_Internal_Static_Int32_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipEntry2Buffer_Internal_Static_Int32_String_String_IntPtr_Int32_IntPtr_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipDecompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipEX_Internal_Static_Int32_String_String_IntPtr_IntPtr_Int32_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipEntry_Internal_Static_Int32_String_String_String_IntPtr_Int32_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipEntryList_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_IntPtr_Int32_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEntryDateTime_Internal_Static_UInt32_String_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_freeMemStruct_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCDMem_Internal_Static_IntPtr_IntPtr_IntPtr_Int32_IntPtr_Int32_String_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initMemStruct_Internal_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initFileStruct_Internal_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_freeMemZ_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_freeFileZ_Internal_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCDMemStart_Internal_Static_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCDMemAdd_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_String_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipCDMemClose_Internal_Static_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipGzip_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipUnGzip_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_zipUnGzip2_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gzip_File_Internal_Static_Int32_String_String_Int32_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ungzip_File_Internal_Static_Int32_String_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCancel_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readTarA_Internal_Static_Int32_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readTar_Internal_Static_IntPtr_String_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createTar_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_extractTar_Internal_Static_Int32_String_String_String_IntPtr_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bz2_Internal_Static_Int32_Boolean_Int32_String_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gcA_Internal_Static_GCHandle_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkObject_Private_Static_Boolean_Object_String_byref_Int32_byref_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFileInfo_Public_Static_UInt64_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEntryIndex_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTotalFiles_Public_Static_Int32_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTotalEntries_Public_Static_Int32_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEntrySize_Public_Static_UInt64_String_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entryExists_Public_Static_Boolean_String_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFilePermissions_Public_Static_Int32_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buffer2File_Public_Static_Boolean_Int32_String_String_Il2CppStructArray_1_Byte_Boolean_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_delete_entry_Public_Static_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_replace_entry_Public_Static_Int32_String_String_String_Int32_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_replace_entry_Public_Static_Int32_String_String_Il2CppStructArray_1_Byte_Int32_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_extract_entry_Public_Static_Int32_String_String_String_Object_Il2CppStructArray_1_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_extract_entries_Public_Static_Int32_String_Il2CppStringArray_String_Object_Il2CppStructArray_1_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompress_File_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Object_Il2CppStructArray_1_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compress_File_Public_Static_Int32_Int32_String_String_Boolean_String_String_String_Boolean_Int32_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compress_File_List_Public_Static_Int32_Int32_String_Il2CppStringArray_Il2CppStructArray_1_Int32_Boolean_Il2CppStringArray_String_Boolean_Int32_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressDir_Public_Static_Int32_String_Int32_String_Boolean_Il2CppStructArray_1_Int32_String_Boolean_Int32_Boolean_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_fillPointers_Private_Static_Void_String_Il2CppStringArray_Il2CppStringArray_byref_Il2CppStructArray_1_IntPtr_byref_Il2CppStructArray_1_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_fillLists_Private_Static_Void_String_Boolean_byref_List_1_String_byref_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getAllFiles_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFileSize_Public_Static_Int64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getDirSize_Public_Static_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tarExtract_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tarExtractEntry_Public_Static_Int32_String_String_String_Boolean_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tarDir_Public_Static_Int32_String_String_Boolean_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tarList_Public_Static_Int32_String_Il2CppStringArray_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTarInfo_Public_Static_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entryDateTime_Public_Static_DateTime_String_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_free_inmemory_Public_Static_Void_inMemory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_inMemoryZipStart_Public_Static_Boolean_inMemory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_inMemoryZipAdd_Public_Static_Int32_inMemory_Int32_Il2CppStructArray_1_Byte_String_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_inMemoryZipClose_Public_Static_IntPtr_inMemory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compress_Buf2Mem_Public_Static_IntPtr_inMemory_Int32_Il2CppStructArray_1_Byte_String_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompress_Mem2File_Public_Static_Int32_inMemory_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2BufferMem_Public_Static_Int32_inMemory_String_byref_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2BufferMem_Public_Static_Il2CppStructArray_1_Byte_inMemory_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2FixedBufferMem_Public_Static_Int32_inMemory_String_byref_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFileInfoMem_Public_Static_UInt64_inMemory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2Buffer_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2FixedBuffer_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2Buffer_Public_Static_Il2CppStructArray_1_Byte_String_String_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_validateFile_Public_Static_Boolean_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getZipInfo_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_String_byref_Int32_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_byref_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findPK_Private_Static_Boolean_BinaryReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findEnd_Private_Static_Int32_BinaryReader_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCentralDir_Private_Static_Void_BinaryReader_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_String_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressZipMerged_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressZipMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_writeFile_Private_Static_Void_Il2CppStructArray_1_Byte_String_String_String_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2FileMerged_Public_Static_Int32_String_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2FileMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Il2CppStructArray_1_Byte_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2FixedBufferMerged_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_byref_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_entry2FixedBufferMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_byref_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gzip_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gzipUncompressedSize_Public_Static_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gzipCompressedSize_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findGzStart_Public_Static_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_unGzip_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_unGzip2_Public_Static_Int32_Object_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_unGzip2Merged_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gzipFile_Public_Static_Int32_String_String_Int32_Il2CppStructArray_1_UInt64_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ungzipFile_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bz2Create_Public_Static_Int32_String_String_Int32_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bz2Decompress_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_downloadZipFileNative_Public_Static_IEnumerator_String_Action_1_Boolean_Action_1_inMemory_Action_1_IntPtr_Action_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe static List<ulong> uinfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_uinfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ulong>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_uinfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<ulong> cinfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cinfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ulong>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cinfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static List<ulong> localOffset
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_localOffset, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ulong>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_localOffset, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static int zipFiles
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_zipFiles, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_zipFiles, (void*)(&num));
		}
	}

	public unsafe static int zipFolders
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_zipFolders, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_zipFolders, (void*)(&num));
		}
	}

	public unsafe static ulong totalCompressedSize
	{
		get
		{
			Unsafe.SkipInit(out ulong result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_totalCompressedSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_totalCompressedSize, (void*)(&num));
		}
	}

	public unsafe static ulong totalUncompressedSize
	{
		get
		{
			Unsafe.SkipInit(out ulong result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_totalUncompressedSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_totalUncompressedSize, (void*)(&num));
		}
	}

	public unsafe static List<zipInfo> zinfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_zinfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<zipInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_zinfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static lzip()
	{
		Il2CppClassPointerStore<lzip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "lzip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<lzip>.NativeClassPtr);
		NativeFieldInfoPtr_libname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "libname");
		NativeFieldInfoPtr_nativeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "nativeBuffer");
		NativeFieldInfoPtr_nativeBufferIsBeingUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "nativeBufferIsBeingUsed");
		NativeFieldInfoPtr_nativeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "nativeOffset");
		NativeFieldInfoPtr_ninfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "ninfo");
		NativeFieldInfoPtr_uinfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "uinfo");
		NativeFieldInfoPtr_cinfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "cinfo");
		NativeFieldInfoPtr_localOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "localOffset");
		NativeFieldInfoPtr_zipFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "zipFiles");
		NativeFieldInfoPtr_zipFolders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "zipFolders");
		NativeFieldInfoPtr_totalCompressedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "totalCompressedSize");
		NativeFieldInfoPtr_totalUncompressedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "totalUncompressedSize");
		NativeFieldInfoPtr_zinfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<lzip>.NativeClassPtr, "zinfo");
		NativeMethodInfoPtr_setTarEncoding_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663536);
		NativeMethodInfoPtr_setEncoding_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663537);
		NativeMethodInfoPtr_zipValidateFile_Internal_Static_Boolean_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663538);
		NativeMethodInfoPtr_zipGetTotalFiles_Internal_Static_Int32_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663539);
		NativeMethodInfoPtr_zipGetTotalEntries_Internal_Static_Int32_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663540);
		NativeMethodInfoPtr_zipGetInfoA_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663541);
		NativeMethodInfoPtr_zipGetInfo_Internal_Static_IntPtr_String_Int32_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663542);
		NativeMethodInfoPtr_releaseBuffer_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663543);
		NativeMethodInfoPtr_createBuffer_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663544);
		NativeMethodInfoPtr_addToBuffer_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663545);
		NativeMethodInfoPtr_zipGetEntrySize_Internal_Static_UInt64_String_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663546);
		NativeMethodInfoPtr_zipEntryExists_Internal_Static_Boolean_String_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663547);
		NativeMethodInfoPtr_zipCD_Internal_Static_Int32_Int32_String_String_String_String_String_Boolean_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663548);
		NativeMethodInfoPtr_zipCDList_Internal_Static_Int32_Int32_String_IntPtr_Int32_IntPtr_IntPtr_String_Boolean_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663549);
		NativeMethodInfoPtr_zipBuf2File_Internal_Static_Boolean_Int32_String_String_IntPtr_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663550);
		NativeMethodInfoPtr_zipDeleteFile_Internal_Static_Int32_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663551);
		NativeMethodInfoPtr_zipEntry2Buffer_Internal_Static_Int32_String_String_IntPtr_Int32_IntPtr_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663552);
		NativeMethodInfoPtr_zipCompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663553);
		NativeMethodInfoPtr_zipDecompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663554);
		NativeMethodInfoPtr_zipEX_Internal_Static_Int32_String_String_IntPtr_IntPtr_Int32_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663555);
		NativeMethodInfoPtr_zipEntry_Internal_Static_Int32_String_String_String_IntPtr_Int32_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663556);
		NativeMethodInfoPtr_zipEntryList_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_IntPtr_Int32_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663557);
		NativeMethodInfoPtr_getEntryDateTime_Internal_Static_UInt32_String_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663558);
		NativeMethodInfoPtr_freeMemStruct_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663559);
		NativeMethodInfoPtr_zipCDMem_Internal_Static_IntPtr_IntPtr_IntPtr_Int32_IntPtr_Int32_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663560);
		NativeMethodInfoPtr_initMemStruct_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663561);
		NativeMethodInfoPtr_initFileStruct_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663562);
		NativeMethodInfoPtr_freeMemZ_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663563);
		NativeMethodInfoPtr_freeFileZ_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663564);
		NativeMethodInfoPtr_zipCDMemStart_Internal_Static_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663565);
		NativeMethodInfoPtr_zipCDMemAdd_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663566);
		NativeMethodInfoPtr_zipCDMemClose_Internal_Static_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663567);
		NativeMethodInfoPtr_zipGzip_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663568);
		NativeMethodInfoPtr_zipUnGzip_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663569);
		NativeMethodInfoPtr_zipUnGzip2_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663570);
		NativeMethodInfoPtr_gzip_File_Internal_Static_Int32_String_String_Int32_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663571);
		NativeMethodInfoPtr_ungzip_File_Internal_Static_Int32_String_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663572);
		NativeMethodInfoPtr_setCancel_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663573);
		NativeMethodInfoPtr_readTarA_Internal_Static_Int32_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663574);
		NativeMethodInfoPtr_readTar_Internal_Static_IntPtr_String_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663575);
		NativeMethodInfoPtr_createTar_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663576);
		NativeMethodInfoPtr_extractTar_Internal_Static_Int32_String_String_String_IntPtr_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663577);
		NativeMethodInfoPtr_bz2_Internal_Static_Int32_Boolean_Int32_String_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663578);
		NativeMethodInfoPtr_gcA_Internal_Static_GCHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663579);
		NativeMethodInfoPtr_checkObject_Private_Static_Boolean_Object_String_byref_Int32_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663580);
		NativeMethodInfoPtr_getFileInfo_Public_Static_UInt64_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663581);
		NativeMethodInfoPtr_getEntryIndex_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663582);
		NativeMethodInfoPtr_getTotalFiles_Public_Static_Int32_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663583);
		NativeMethodInfoPtr_getTotalEntries_Public_Static_Int32_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663584);
		NativeMethodInfoPtr_getEntrySize_Public_Static_UInt64_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663585);
		NativeMethodInfoPtr_entryExists_Public_Static_Boolean_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663586);
		NativeMethodInfoPtr_setFilePermissions_Public_Static_Int32_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663587);
		NativeMethodInfoPtr_buffer2File_Public_Static_Boolean_Int32_String_String_Il2CppStructArray_1_Byte_Boolean_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663588);
		NativeMethodInfoPtr_delete_entry_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663589);
		NativeMethodInfoPtr_replace_entry_Public_Static_Int32_String_String_String_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663590);
		NativeMethodInfoPtr_replace_entry_Public_Static_Int32_String_String_Il2CppStructArray_1_Byte_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663591);
		NativeMethodInfoPtr_extract_entry_Public_Static_Int32_String_String_String_Object_Il2CppStructArray_1_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663592);
		NativeMethodInfoPtr_extract_entries_Public_Static_Int32_String_Il2CppStringArray_String_Object_Il2CppStructArray_1_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663593);
		NativeMethodInfoPtr_decompress_File_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Object_Il2CppStructArray_1_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663594);
		NativeMethodInfoPtr_compress_File_Public_Static_Int32_Int32_String_String_Boolean_String_String_String_Boolean_Int32_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663595);
		NativeMethodInfoPtr_compress_File_List_Public_Static_Int32_Int32_String_Il2CppStringArray_Il2CppStructArray_1_Int32_Boolean_Il2CppStringArray_String_Boolean_Int32_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663596);
		NativeMethodInfoPtr_compressDir_Public_Static_Int32_String_Int32_String_Boolean_Il2CppStructArray_1_Int32_String_Boolean_Int32_Boolean_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663597);
		NativeMethodInfoPtr_fillPointers_Private_Static_Void_String_Il2CppStringArray_Il2CppStringArray_byref_Il2CppStructArray_1_IntPtr_byref_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663598);
		NativeMethodInfoPtr_fillLists_Private_Static_Void_String_Boolean_byref_List_1_String_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663599);
		NativeMethodInfoPtr_getAllFiles_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663600);
		NativeMethodInfoPtr_getFileSize_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663601);
		NativeMethodInfoPtr_getDirSize_Public_Static_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663602);
		NativeMethodInfoPtr_tarExtract_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663603);
		NativeMethodInfoPtr_tarExtractEntry_Public_Static_Int32_String_String_String_Boolean_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663604);
		NativeMethodInfoPtr_tarDir_Public_Static_Int32_String_String_Boolean_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663605);
		NativeMethodInfoPtr_tarList_Public_Static_Int32_String_Il2CppStringArray_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663606);
		NativeMethodInfoPtr_getTarInfo_Public_Static_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663607);
		NativeMethodInfoPtr_entryDateTime_Public_Static_DateTime_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663608);
		NativeMethodInfoPtr_free_inmemory_Public_Static_Void_inMemory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663609);
		NativeMethodInfoPtr_inMemoryZipStart_Public_Static_Boolean_inMemory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663610);
		NativeMethodInfoPtr_inMemoryZipAdd_Public_Static_Int32_inMemory_Int32_Il2CppStructArray_1_Byte_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663611);
		NativeMethodInfoPtr_inMemoryZipClose_Public_Static_IntPtr_inMemory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663612);
		NativeMethodInfoPtr_compress_Buf2Mem_Public_Static_IntPtr_inMemory_Int32_Il2CppStructArray_1_Byte_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663613);
		NativeMethodInfoPtr_decompress_Mem2File_Public_Static_Int32_inMemory_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663614);
		NativeMethodInfoPtr_entry2BufferMem_Public_Static_Int32_inMemory_String_byref_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663615);
		NativeMethodInfoPtr_entry2BufferMem_Public_Static_Il2CppStructArray_1_Byte_inMemory_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663616);
		NativeMethodInfoPtr_entry2FixedBufferMem_Public_Static_Int32_inMemory_String_byref_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663617);
		NativeMethodInfoPtr_getFileInfoMem_Public_Static_UInt64_inMemory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663618);
		NativeMethodInfoPtr_entry2Buffer_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663619);
		NativeMethodInfoPtr_entry2FixedBuffer_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663620);
		NativeMethodInfoPtr_entry2Buffer_Public_Static_Il2CppStructArray_1_Byte_String_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663621);
		NativeMethodInfoPtr_validateFile_Public_Static_Boolean_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663622);
		NativeMethodInfoPtr_getZipInfo_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663623);
		NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_String_byref_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663624);
		NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663625);
		NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663626);
		NativeMethodInfoPtr_findPK_Private_Static_Boolean_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663627);
		NativeMethodInfoPtr_findEnd_Private_Static_Int32_BinaryReader_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663628);
		NativeMethodInfoPtr_getCentralDir_Private_Static_Void_BinaryReader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663629);
		NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663630);
		NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663631);
		NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663632);
		NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663633);
		NativeMethodInfoPtr_decompressZipMerged_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663634);
		NativeMethodInfoPtr_decompressZipMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663635);
		NativeMethodInfoPtr_writeFile_Private_Static_Void_Il2CppStructArray_1_Byte_String_String_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663636);
		NativeMethodInfoPtr_entry2FileMerged_Public_Static_Int32_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663637);
		NativeMethodInfoPtr_entry2FileMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663638);
		NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Il2CppStructArray_1_Byte_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663639);
		NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663640);
		NativeMethodInfoPtr_entry2FixedBufferMerged_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663641);
		NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663642);
		NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_byref_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663643);
		NativeMethodInfoPtr_entry2FixedBufferMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_byref_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663644);
		NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663645);
		NativeMethodInfoPtr_compressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663646);
		NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663647);
		NativeMethodInfoPtr_decompressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663648);
		NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663649);
		NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663650);
		NativeMethodInfoPtr_gzip_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663651);
		NativeMethodInfoPtr_gzipUncompressedSize_Public_Static_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663652);
		NativeMethodInfoPtr_gzipCompressedSize_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663653);
		NativeMethodInfoPtr_findGzStart_Public_Static_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663654);
		NativeMethodInfoPtr_unGzip_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663655);
		NativeMethodInfoPtr_unGzip2_Public_Static_Int32_Object_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663656);
		NativeMethodInfoPtr_unGzip2Merged_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663657);
		NativeMethodInfoPtr_gzipFile_Public_Static_Int32_String_String_Int32_Il2CppStructArray_1_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663658);
		NativeMethodInfoPtr_ungzipFile_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663659);
		NativeMethodInfoPtr_bz2Create_Public_Static_Int32_String_String_Int32_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663660);
		NativeMethodInfoPtr_bz2Decompress_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663661);
		NativeMethodInfoPtr_downloadZipFileNative_Public_Static_IEnumerator_String_Action_1_Boolean_Action_1_inMemory_Action_1_IntPtr_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663662);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<lzip>.NativeClassPtr, 100663663);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4280, XrefRangeEnd = 4282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setTarEncoding(uint encoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTarEncoding_Public_Static_Void_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4282, XrefRangeEnd = 4284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setEncoding(uint encoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setEncoding_Public_Static_Void_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4284, XrefRangeEnd = 4286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool zipValidateFile(string zipArchive, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipValidateFile_Internal_Static_Boolean_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4286, XrefRangeEnd = 4288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipGetTotalFiles(string zipArchive, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipGetTotalFiles_Internal_Static_Int32_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4288, XrefRangeEnd = 4290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipGetTotalEntries(string zipArchive, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipGetTotalEntries_Internal_Static_Int32_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 4292, RefRangeEnd = 4295, XrefRangeStart = 4290, XrefRangeEnd = 4292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipGetInfoA(string zipArchive, System.IntPtr total, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &total;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipGetInfoA_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 4297, RefRangeEnd = 4300, XrefRangeStart = 4295, XrefRangeEnd = 4297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr zipGetInfo(string zipArchive, int size, System.IntPtr unc, System.IntPtr comp, System.IntPtr offs, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unc;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &comp;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &offs;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipGetInfo_Internal_Static_IntPtr_String_Int32_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 4302, RefRangeEnd = 4309, XrefRangeStart = 4300, XrefRangeEnd = 4302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void releaseBuffer(System.IntPtr buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_releaseBuffer_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4309, XrefRangeEnd = 4311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr createBuffer(int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createBuffer_Public_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4311, XrefRangeEnd = 4313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addToBuffer(System.IntPtr destination, int offset, System.IntPtr buffer, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&destination);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addToBuffer_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4313, XrefRangeEnd = 4315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong zipGetEntrySize(string zipArchive, string entry, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipGetEntrySize_Internal_Static_UInt64_String_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4315, XrefRangeEnd = 4317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool zipEntryExists(string zipArchive, string entry, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipEntryExists_Internal_Static_Boolean_String_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4317, XrefRangeEnd = 4320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipCD(int levelOfCompression, string zipArchive, string inFilePath, string fileName, string comment, string password, bool useBz2, int diskSize, System.IntPtr bprog)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&levelOfCompression);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inFilePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &diskSize;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &bprog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCD_Internal_Static_Int32_Int32_String_String_String_String_String_Boolean_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4320, XrefRangeEnd = 4323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipCDList(int levelOfCompression, string zipArchive, System.IntPtr filename, int arrayLength, System.IntPtr prog, System.IntPtr filenameForced, string password, bool useBz2, int diskSize, System.IntPtr bprog)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&levelOfCompression);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &filename;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayLength;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &prog;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &filenameForced;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &diskSize;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &bprog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCDList_Internal_Static_Int32_Int32_String_IntPtr_Int32_IntPtr_IntPtr_String_Boolean_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4323, XrefRangeEnd = 4326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool zipBuf2File(int levelOfCompression, string zipArchive, string arcFilename, System.IntPtr buffer, int bufferSize, string comment, string password, bool useBz2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&levelOfCompression);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arcFilename);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipBuf2File_Internal_Static_Boolean_Int32_String_String_IntPtr_Int32_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4326, XrefRangeEnd = 4328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipDeleteFile(string zipArchive, string arcFilename, string tempArchive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arcFilename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(tempArchive);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipDeleteFile_Internal_Static_Int32_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 4331, RefRangeEnd = 4340, XrefRangeStart = 4328, XrefRangeEnd = 4331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipEntry2Buffer(string zipArchive, string entry, System.IntPtr buffer, int bufferSize, System.IntPtr FileBuffer, int fileBufferLength, string password)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipEntry2Buffer_Internal_Static_Int32_String_String_IntPtr_Int32_IntPtr_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4340, XrefRangeEnd = 4342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr zipCompressBuffer(System.IntPtr source, int sourceLen, int levelOfCompression, ref int v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4342, XrefRangeEnd = 4344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr zipDecompressBuffer(System.IntPtr source, int sourceLen, ref int v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipDecompressBuffer_Internal_Static_IntPtr_IntPtr_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 4347, RefRangeEnd = 4350, XrefRangeStart = 4344, XrefRangeEnd = 4347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipEX(string zipArchive, string outPath, System.IntPtr progress, System.IntPtr FileBuffer, int fileBufferLength, System.IntPtr proc, string password)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &progress;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &proc;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipEX_Internal_Static_Int32_String_String_IntPtr_IntPtr_Int32_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4350, XrefRangeEnd = 4353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipEntry(string zipArchive, string arcFilename, string outpath, System.IntPtr FileBuffer, int fileBufferLength, System.IntPtr proc, string password)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arcFilename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outpath);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &proc;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipEntry_Internal_Static_Int32_String_String_String_IntPtr_Int32_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 4356, RefRangeEnd = 4359, XrefRangeStart = 4353, XrefRangeEnd = 4356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipEntryList(string zipArchive, System.IntPtr outpath, System.IntPtr filename, int arrayLength, System.IntPtr FileBuffer, int fileBufferLength, System.IntPtr proc, string password)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &outpath;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &filename;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayLength;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &proc;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipEntryList_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_IntPtr_Int32_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4359, XrefRangeEnd = 4361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint getEntryDateTime(string zipArchive, string arcFilename, System.IntPtr FileBuffer, int fileBufferLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arcFilename);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &FileBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileBufferLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEntryDateTime_Internal_Static_UInt32_String_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4361, XrefRangeEnd = 4363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int freeMemStruct(System.IntPtr buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_freeMemStruct_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4363, XrefRangeEnd = 4366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr zipCDMem(System.IntPtr info, System.IntPtr pnt, int levelOfCompression, System.IntPtr source, int sourceLen, string fileName, string comment, string password, bool useBz2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&info);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pnt;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCDMem_Internal_Static_IntPtr_IntPtr_IntPtr_Int32_IntPtr_Int32_String_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4366, XrefRangeEnd = 4368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr initMemStruct()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initMemStruct_Internal_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4368, XrefRangeEnd = 4370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr initFileStruct()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initFileStruct_Internal_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4370, XrefRangeEnd = 4372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int freeMemZ(System.IntPtr pointer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pointer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_freeMemZ_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4372, XrefRangeEnd = 4374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int freeFileZ(System.IntPtr pointer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pointer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_freeFileZ_Internal_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4374, XrefRangeEnd = 4376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr zipCDMemStart(System.IntPtr info, System.IntPtr pnt, System.IntPtr fileStruct, System.IntPtr memStruct)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&info);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pnt;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileStruct;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &memStruct;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCDMemStart_Internal_Static_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4376, XrefRangeEnd = 4379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipCDMemAdd(System.IntPtr zf, int levelOfCompression, System.IntPtr source, int sourceLen, string fileName, string comment, string password, bool useBz2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&zf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCDMemAdd_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_String_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4379, XrefRangeEnd = 4381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr zipCDMemClose(System.IntPtr zf, System.IntPtr memStruct, System.IntPtr info, int err)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&zf);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &memStruct;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &info;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &err;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipCDMemClose_Internal_Static_IntPtr_IntPtr_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4381, XrefRangeEnd = 4383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipGzip(System.IntPtr source, int sourceLen, System.IntPtr outBuffer, int levelOfCompression, bool addHeader, bool addFooter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &outBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &addHeader;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &addFooter;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipGzip_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4383, XrefRangeEnd = 4385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipUnGzip(System.IntPtr source, int sourceLen, System.IntPtr outBuffer, int outLen, bool hasHeader, bool hasFooter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &outBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outLen;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasHeader;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasFooter;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipUnGzip_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 4387, RefRangeEnd = 4390, XrefRangeStart = 4385, XrefRangeEnd = 4387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int zipUnGzip2(System.IntPtr source, int sourceLen, System.IntPtr outBuffer, int outLen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceLen;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &outBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &outLen;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_zipUnGzip2_Internal_Static_Int32_IntPtr_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4390, XrefRangeEnd = 4392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int gzip_File(string inFile, string outFile, int level, System.IntPtr progress, bool addHeader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &progress;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &addHeader;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gzip_File_Internal_Static_Int32_String_String_Int32_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4392, XrefRangeEnd = 4394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ungzip_File(string inFile, string outFile, System.IntPtr progress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &progress;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ungzip_File_Internal_Static_Int32_String_String_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4394, XrefRangeEnd = 4396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setCancel()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCancel_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4396, XrefRangeEnd = 4398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int readTarA(string zipArchive, System.IntPtr total)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &total;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readTarA_Internal_Static_Int32_String_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4398, XrefRangeEnd = 4400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr readTar(string zipArchive, int size, System.IntPtr unc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &unc;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readTar_Internal_Static_IntPtr_String_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4400, XrefRangeEnd = 4402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int createTar(string outFile, System.IntPtr filePath, System.IntPtr filename, int arrayLength, System.IntPtr prog, System.IntPtr bprog)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &filePath;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &filename;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayLength;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &prog;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &bprog;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createTar_Internal_Static_Int32_String_IntPtr_IntPtr_Int32_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4402, XrefRangeEnd = 4404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int extractTar(string inFile, string outDir, string entry, System.IntPtr prog, System.IntPtr bprog, bool fullPaths)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outDir);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &prog;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bprog;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullPaths;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_extractTar_Internal_Static_Int32_String_String_String_IntPtr_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4404, XrefRangeEnd = 4406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int bz2(bool decompress, int level, string inFile, string outFile, System.IntPtr byteProgress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&decompress);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &byteProgress;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bz2_Internal_Static_Int32_Boolean_Int32_String_String_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
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

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 4416, RefRangeEnd = 4428, XrefRangeStart = 4406, XrefRangeEnd = 4416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool checkObject(Il2CppSystem.Object o, string zipArchive, ref int len, ref System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[4];
		*ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(void**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref len);
		*(void**)((byte*)ptr2 + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkObject_Private_Static_Boolean_Object_String_byref_Int32_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 4581, RefRangeEnd = 4584, XrefRangeStart = 4428, XrefRangeEnd = 4581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong getFileInfo(string zipArchive, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFileInfo_Public_Static_UInt64_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4600, RefRangeEnd = 4601, XrefRangeStart = 4584, XrefRangeEnd = 4600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getEntryIndex(string entry)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(entry);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEntryIndex_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 4610, RefRangeEnd = 4612, XrefRangeStart = 4601, XrefRangeEnd = 4610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getTotalFiles(string zipArchive, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTotalFiles_Public_Static_Int32_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 4621, RefRangeEnd = 4623, XrefRangeStart = 4612, XrefRangeEnd = 4621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getTotalEntries(string zipArchive, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTotalEntries_Public_Static_Int32_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 4654, RefRangeEnd = 4656, XrefRangeStart = 4623, XrefRangeEnd = 4654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong getEntrySize(string zipArchive, string entry, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEntrySize_Public_Static_UInt64_String_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 4687, RefRangeEnd = 4689, XrefRangeStart = 4656, XrefRangeEnd = 4687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool entryExists(string zipArchive, string entry, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entryExists_Public_Static_Boolean_String_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 4711, RefRangeEnd = 4714, XrefRangeStart = 4689, XrefRangeEnd = 4711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool buffer2File(int levelOfCompression, string zipArchive, string arcFilename, Il2CppStructArray<byte> buffer, bool append = false, string comment = null, string password = null, bool useBz2 = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&levelOfCompression);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arcFilename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &append;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buffer2File_Public_Static_Boolean_Int32_String_String_Il2CppStructArray_1_Byte_Boolean_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 4724, RefRangeEnd = 4728, XrefRangeStart = 4714, XrefRangeEnd = 4724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int delete_entry(string zipArchive, string arcFilename)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arcFilename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_delete_entry_Public_Static_Int32_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4748, RefRangeEnd = 4749, XrefRangeStart = 4728, XrefRangeEnd = 4748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int replace_entry(string zipArchive, string arcFilename, string newFilePath, int level = 9, string comment = null, string password = null, bool useBz2 = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arcFilename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newFilePath);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_replace_entry_Public_Static_Int32_String_String_String_Int32_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4749, XrefRangeEnd = 4757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int replace_entry(string zipArchive, string arcFilename, Il2CppStructArray<byte> newFileBuffer, int level = 9, string password = null, bool useBz2 = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arcFilename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newFileBuffer);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_replace_entry_Public_Static_Int32_String_String_Il2CppStructArray_1_Byte_Int32_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 4780, RefRangeEnd = 4782, XrefRangeStart = 4757, XrefRangeEnd = 4780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int extract_entry(string zipArchive, string arcFilename, string outpath, Il2CppSystem.Object fileBuffer = null, Il2CppStructArray<ulong> proc = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(arcFilename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outpath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_extract_entry_Public_Static_Int32_String_String_String_Object_Il2CppStructArray_1_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 4909, RefRangeEnd = 4912, XrefRangeStart = 4782, XrefRangeEnd = 4909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int extract_entries(string zipArchive, Il2CppStringArray fileList, string outpath, Il2CppSystem.Object fileBuffer = null, Il2CppStructArray<ulong> proc = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileList);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outpath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_extract_entries_Public_Static_Int32_String_Il2CppStringArray_String_Object_Il2CppStructArray_1_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 4963, RefRangeEnd = 4976, XrefRangeStart = 4912, XrefRangeEnd = 4963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompress_File(string zipArchive, string outPath = null, Il2CppStructArray<int> progress = null, Il2CppSystem.Object fileBuffer = null, Il2CppStructArray<ulong> proc = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompress_File_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Object_Il2CppStructArray_1_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 5011, RefRangeEnd = 5017, XrefRangeStart = 4976, XrefRangeEnd = 5011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int compress_File(int levelOfCompression, string zipArchive, string inFilePath, bool append = false, string fileName = "", string comment = null, string password = null, bool useBz2 = false, int diskSize = 0, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&levelOfCompression);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(inFilePath);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &append;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &diskSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compress_File_Public_Static_Int32_Int32_String_String_Boolean_String_String_String_Boolean_Int32_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 5032, RefRangeEnd = 5034, XrefRangeStart = 5017, XrefRangeEnd = 5032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int compress_File_List(int levelOfCompression, string zipArchive, Il2CppStringArray inFilePath, Il2CppStructArray<int> progress = null, bool append = false, Il2CppStringArray fileName = null, string password = null, bool useBz2 = false, int diskSize = 0, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = (nint)(&levelOfCompression);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inFilePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &append;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &diskSize;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compress_File_List_Public_Static_Int32_Int32_String_Il2CppStringArray_Il2CppStructArray_1_Int32_Boolean_Il2CppStringArray_String_Boolean_Int32_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5079, RefRangeEnd = 5080, XrefRangeStart = 5034, XrefRangeEnd = 5079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int compressDir(string sourceDir, int levelOfCompression, string zipArchive = null, bool includeRoot = false, Il2CppStructArray<int> progress = null, string password = null, bool useBz2 = false, int diskSize = 0, bool append = false, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceDir);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeRoot;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &diskSize;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &append;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressDir_Public_Static_Int32_String_Int32_String_Boolean_Il2CppStructArray_1_Int32_String_Boolean_Int32_Boolean_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5080, XrefRangeEnd = 5130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void fillPointers(string outFile, Il2CppStringArray fileName, Il2CppStringArray inFilePath, ref Il2CppStructArray<System.IntPtr> fp, ref Il2CppStructArray<System.IntPtr> np)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inFilePath);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fp);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)np);
		*(System.IntPtr**)num2 = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fillPointers_Private_Static_Void_String_Il2CppStringArray_Il2CppStringArray_byref_Il2CppStructArray_1_IntPtr_byref_Il2CppStructArray_1_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		fp = ((intPtr5 == (System.IntPtr)0) ? null : new Il2CppStructArray<System.IntPtr>(intPtr5));
		System.IntPtr intPtr6 = intPtr2;
		np = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppStructArray<System.IntPtr>(intPtr6));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 5158, RefRangeEnd = 5160, XrefRangeStart = 5130, XrefRangeEnd = 5158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void fillLists(string fdir, bool includeRoot, ref List<string> inFilePath, ref List<string> fileName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fdir);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeRoot;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inFilePath);
		*(System.IntPtr**)num = &intPtr;
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileName);
		*(System.IntPtr**)num2 = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fillLists_Private_Static_Void_String_Boolean_byref_List_1_String_byref_List_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		inFilePath = ((intPtr5 == (System.IntPtr)0) ? null : new List<string>(intPtr5));
		System.IntPtr intPtr6 = intPtr2;
		fileName = ((intPtr6 == (System.IntPtr)0) ? null : new List<string>(intPtr6));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5160, XrefRangeEnd = 5163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5163, XrefRangeEnd = 5167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5167, XrefRangeEnd = 5176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 5197, RefRangeEnd = 5198, XrefRangeStart = 5176, XrefRangeEnd = 5197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tarExtract(string inFile, string outPath = null, Il2CppStructArray<int> progress = null, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tarExtract_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 5218, RefRangeEnd = 5220, XrefRangeStart = 5198, XrefRangeEnd = 5218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tarExtractEntry(string inFile, string entry, string outPath = null, bool fullPaths = true, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullPaths;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tarExtractEntry_Public_Static_Int32_String_String_String_Boolean_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5265, RefRangeEnd = 5266, XrefRangeStart = 5220, XrefRangeEnd = 5265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tarDir(string sourceDir, string outFile = null, bool includeRoot = false, Il2CppStructArray<int> progress = null, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceDir);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeRoot;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tarDir_Public_Static_Int32_String_String_Boolean_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5272, RefRangeEnd = 5273, XrefRangeStart = 5266, XrefRangeEnd = 5272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tarList(string outFile, Il2CppStringArray inFilePath, Il2CppStringArray fileName = null, Il2CppStructArray<int> progress = null, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inFilePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tarList_Public_Static_Int32_String_Il2CppStringArray_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5344, RefRangeEnd = 5345, XrefRangeStart = 5273, XrefRangeEnd = 5344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong getTarInfo(string tarArchive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tarArchive);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTarInfo_Public_Static_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5403, RefRangeEnd = 5404, XrefRangeStart = 5345, XrefRangeEnd = 5403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.DateTime entryDateTime(string zipArchive, string entry, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entryDateTime_Public_Static_DateTime_String_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 5437, RefRangeEnd = 5440, XrefRangeStart = 5404, XrefRangeEnd = 5437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void free_inmemory(inMemory t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_free_inmemory_Public_Static_Void_inMemory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 5465, RefRangeEnd = 5467, XrefRangeStart = 5440, XrefRangeEnd = 5465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool inMemoryZipStart(inMemory t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_inMemoryZipStart_Public_Static_Boolean_inMemory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 5489, RefRangeEnd = 5493, XrefRangeStart = 5467, XrefRangeEnd = 5489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int inMemoryZipAdd(inMemory t, int levelOfCompression, Il2CppStructArray<byte> buffer, string fileName, string comment = null, string password = null, bool useBz2 = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_inMemoryZipAdd_Public_Static_Int32_inMemory_Int32_Il2CppStructArray_1_Byte_String_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 5505, RefRangeEnd = 5508, XrefRangeStart = 5493, XrefRangeEnd = 5505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr inMemoryZipClose(inMemory t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_inMemoryZipClose_Public_Static_IntPtr_inMemory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 5534, RefRangeEnd = 5536, XrefRangeStart = 5508, XrefRangeEnd = 5534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr compress_Buf2Mem(inMemory t, int levelOfCompression, Il2CppStructArray<byte> buffer, string fileName, string comment = null, string password = null, bool useBz2 = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(comment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &useBz2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compress_Buf2Mem_Public_Static_IntPtr_inMemory_Int32_Il2CppStructArray_1_Byte_String_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 5564, RefRangeEnd = 5567, XrefRangeStart = 5536, XrefRangeEnd = 5564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompress_Mem2File(inMemory t, string outPath, Il2CppStructArray<int> progress = null, Il2CppStructArray<ulong> proc = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompress_Mem2File_Public_Static_Int32_inMemory_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 5592, RefRangeEnd = 5594, XrefRangeStart = 5567, XrefRangeEnd = 5592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2BufferMem(inMemory t, string entry, ref Il2CppStructArray<byte> buffer, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2BufferMem_Public_Static_Int32_inMemory_String_byref_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		buffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 5615, RefRangeEnd = 5618, XrefRangeStart = 5594, XrefRangeEnd = 5615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> entry2BufferMem(inMemory t, string entry, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2BufferMem_Public_Static_Il2CppStructArray_1_Byte_inMemory_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 5636, RefRangeEnd = 5638, XrefRangeStart = 5618, XrefRangeEnd = 5636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2FixedBufferMem(inMemory t, string entry, ref Il2CppStructArray<byte> fixedBuffer, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fixedBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2FixedBufferMem_Public_Static_Int32_inMemory_String_byref_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		fixedBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5734, RefRangeEnd = 5735, XrefRangeStart = 5638, XrefRangeEnd = 5734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong getFileInfoMem(inMemory t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFileInfoMem_Public_Static_UInt64_inMemory_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 5808, RefRangeEnd = 5812, XrefRangeStart = 5735, XrefRangeEnd = 5808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2Buffer(string zipArchive, string entry, ref Il2CppStructArray<byte> buffer, Il2CppSystem.Object fileBuffer = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2Buffer_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		buffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5879, RefRangeEnd = 5880, XrefRangeStart = 5812, XrefRangeEnd = 5879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2FixedBuffer(string zipArchive, string entry, ref Il2CppStructArray<byte> fixedBuffer, Il2CppSystem.Object fileBuffer = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fixedBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2FixedBuffer_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		fixedBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 5948, RefRangeEnd = 5951, XrefRangeStart = 5880, XrefRangeEnd = 5948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> entry2Buffer(string zipArchive, string entry, Il2CppSystem.Object fileBuffer = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2Buffer_Public_Static_Il2CppStructArray_1_Byte_String_String_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 5960, RefRangeEnd = 5965, XrefRangeStart = 5951, XrefRangeEnd = 5960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool validateFile(string zipArchive, Il2CppSystem.Object fileBuffer = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(zipArchive);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_validateFile_Public_Static_Boolean_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6003, RefRangeEnd = 6004, XrefRangeStart = 5965, XrefRangeEnd = 6003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool getZipInfo(string fileName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getZipInfo_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 6053, RefRangeEnd = 6055, XrefRangeStart = 6004, XrefRangeEnd = 6053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool getZipInfoMerged(string fileName, ref int pos, ref int size, bool getCentralDirectory = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref size);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &getCentralDirectory;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_String_byref_Int32_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 6105, RefRangeEnd = 6112, XrefRangeStart = 6055, XrefRangeEnd = 6105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool getZipInfoMerged(Il2CppStructArray<byte> buffer, ref int pos, ref int size, bool getCentralDirectory = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref size);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &getCentralDirectory;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_byref_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6152, RefRangeEnd = 6153, XrefRangeStart = 6112, XrefRangeEnd = 6152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool getZipInfoMerged(Il2CppStructArray<byte> buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getZipInfoMerged_Public_Static_Boolean_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 6154, RefRangeEnd = 6158, XrefRangeStart = 6153, XrefRangeEnd = 6154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool findPK(BinaryReader reader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findPK_Private_Static_Boolean_BinaryReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 6158, RefRangeEnd = 6162, XrefRangeStart = 6158, XrefRangeEnd = 6158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int findEnd(BinaryReader reader, ref int pos, ref int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pos);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref size);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findEnd_Private_Static_Int32_BinaryReader_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 6193, RefRangeEnd = 6197, XrefRangeStart = 6162, XrefRangeEnd = 6193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getCentralDir(BinaryReader reader, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCentralDir_Private_Static_Void_BinaryReader_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 6221, RefRangeEnd = 6226, XrefRangeStart = 6197, XrefRangeEnd = 6221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> getMergedZip(string filePath, ref int position, ref int siz)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref siz);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_String_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6226, XrefRangeEnd = 6249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> getMergedZip(string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6249, XrefRangeEnd = 6275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> getMergedZip(Il2CppStructArray<byte> buffer, ref int position, ref int siz)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref siz);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6275, XrefRangeEnd = 6300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> getMergedZip(Il2CppStructArray<byte> buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMergedZip_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6324, RefRangeEnd = 6325, XrefRangeStart = 6300, XrefRangeEnd = 6324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompressZipMerged(string file, string outPath, Il2CppStructArray<int> progress = null, Il2CppStructArray<ulong> proc = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressZipMerged_Public_Static_Int32_String_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6348, RefRangeEnd = 6349, XrefRangeStart = 6325, XrefRangeEnd = 6348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompressZipMerged(Il2CppStructArray<byte> buffer, string outPath, Il2CppStructArray<int> progress = null, Il2CppStructArray<ulong> proc = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressZipMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 6356, RefRangeEnd = 6358, XrefRangeStart = 6349, XrefRangeEnd = 6356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void writeFile(Il2CppStructArray<byte> tb, string entry, string outPath, string overrideEntryName, ref int res)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tb);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(overrideEntryName);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref res);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_writeFile_Private_Static_Void_Il2CppStructArray_1_Byte_String_String_String_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6381, RefRangeEnd = 6382, XrefRangeStart = 6358, XrefRangeEnd = 6381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2FileMerged(string file, string entry, string outPath, string overrideEntryName = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(overrideEntryName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2FileMerged_Public_Static_Int32_String_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6404, RefRangeEnd = 6405, XrefRangeStart = 6382, XrefRangeEnd = 6404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2FileMerged(Il2CppStructArray<byte> buffer, string entry, string outPath, string overrideEntryName = null, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(overrideEntryName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2FileMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6412, RefRangeEnd = 6413, XrefRangeStart = 6405, XrefRangeEnd = 6412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> entry2BufferMerged(string file, string entry, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Il2CppStructArray_1_Byte_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6413, XrefRangeEnd = 6420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2BufferMerged(string file, string entry, ref Il2CppStructArray<byte> refBuffer, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)refBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		refBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6427, RefRangeEnd = 6428, XrefRangeStart = 6420, XrefRangeEnd = 6427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2FixedBufferMerged(string file, string entry, ref Il2CppStructArray<byte> fixedBuffer, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fixedBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2FixedBufferMerged_Public_Static_Int32_String_String_byref_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		fixedBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6434, RefRangeEnd = 6435, XrefRangeStart = 6428, XrefRangeEnd = 6434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> entry2BufferMerged(Il2CppStructArray<byte> buffer, string entry, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6435, XrefRangeEnd = 6452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2BufferMerged(Il2CppStructArray<byte> buffer, string entry, ref Il2CppStructArray<byte> refBuffer, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)refBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2BufferMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_byref_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		refBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6469, RefRangeEnd = 6470, XrefRangeStart = 6452, XrefRangeEnd = 6469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int entry2FixedBufferMerged(Il2CppStructArray<byte> buffer, string entry, ref Il2CppStructArray<byte> fixedBuffer, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entry);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fixedBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_entry2FixedBufferMerged_Public_Static_Int32_Il2CppStructArray_1_Byte_String_byref_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		fixedBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6490, RefRangeEnd = 6491, XrefRangeStart = 6470, XrefRangeEnd = 6490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool compressBuffer(Il2CppStructArray<byte> source, ref Il2CppStructArray<byte> outBuffer, int levelOfCompression)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6508, RefRangeEnd = 6509, XrefRangeStart = 6491, XrefRangeEnd = 6508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int compressBufferFixed(Il2CppStructArray<byte> source, ref Il2CppStructArray<byte> outBuffer, int levelOfCompression, bool safe = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &safe;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6529, RefRangeEnd = 6530, XrefRangeStart = 6509, XrefRangeEnd = 6529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> compressBuffer(Il2CppStructArray<byte> source, int levelOfCompression)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelOfCompression;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6550, RefRangeEnd = 6551, XrefRangeStart = 6530, XrefRangeEnd = 6550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool decompressBuffer(Il2CppStructArray<byte> source, ref Il2CppStructArray<byte> outBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressBuffer_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6568, RefRangeEnd = 6569, XrefRangeStart = 6551, XrefRangeEnd = 6568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int decompressBufferFixed(Il2CppStructArray<byte> source, ref Il2CppStructArray<byte> outBuffer, bool safe = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &safe;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressBufferFixed_Public_Static_Int32_Il2CppStructArray_1_Byte_byref_Il2CppStructArray_1_Byte_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		outBuffer = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<byte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6589, RefRangeEnd = 6590, XrefRangeStart = 6569, XrefRangeEnd = 6589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> decompressBuffer(Il2CppStructArray<byte> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decompressBuffer_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6603, RefRangeEnd = 6604, XrefRangeStart = 6590, XrefRangeEnd = 6603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int gzip(Il2CppStructArray<byte> source, Il2CppStructArray<byte> outBuffer, int level, bool addHeader = true, bool addFooter = true, bool overrideDateTimeWithLength = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &addHeader;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &addFooter;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &overrideDateTimeWithLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gzip_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Boolean_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int gzipUncompressedSize(Il2CppStructArray<byte> source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gzipUncompressedSize_Public_Static_Int32_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6604, XrefRangeEnd = 6606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int gzipCompressedSize(Il2CppStructArray<byte> source, int offset = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gzipCompressedSize_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6606, XrefRangeEnd = 6607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int findGzStart(Il2CppStructArray<byte> buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findGzStart_Public_Static_Int32_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6607, XrefRangeEnd = 6618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int unGzip(Il2CppStructArray<byte> source, Il2CppStructArray<byte> outBuffer, bool hasHeader = true, bool hasFooter = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasHeader;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasFooter;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_unGzip_Public_Static_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6618, XrefRangeEnd = 6642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int unGzip2(Il2CppSystem.Object source, Il2CppStructArray<byte> outBuffer, int intPtrLength = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &intPtrLength;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_unGzip2_Public_Static_Int32_Object_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6642, XrefRangeEnd = 6653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int unGzip2Merged(Il2CppStructArray<byte> source, int offset, int bufferLength, Il2CppStructArray<byte> outBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferLength;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_unGzip2Merged_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 6685, RefRangeEnd = 6688, XrefRangeStart = 6653, XrefRangeEnd = 6685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int gzipFile(string inFile, string outFile = null, int level = 9, Il2CppStructArray<ulong> progress = null, bool addHeader = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &addHeader;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gzipFile_Public_Static_Int32_String_String_Int32_Il2CppStructArray_1_UInt64_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 6703, RefRangeEnd = 6705, XrefRangeStart = 6688, XrefRangeEnd = 6703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ungzipFile(string inFile, string outFile = null, Il2CppStructArray<ulong> progress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)progress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ungzipFile_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 6737, RefRangeEnd = 6739, XrefRangeStart = 6705, XrefRangeEnd = 6737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int bz2Create(string inFile, string outFile = null, int level = 9, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bz2Create_Public_Static_Int32_String_String_Int32_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6754, RefRangeEnd = 6755, XrefRangeStart = 6739, XrefRangeEnd = 6754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int bz2Decompress(string inFile, string outFile = null, Il2CppStructArray<ulong> byteProgress = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(inFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(outFile);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteProgress);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bz2Decompress_Public_Static_Int32_String_String_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 6758, RefRangeEnd = 6760, XrefRangeStart = 6755, XrefRangeEnd = 6758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator downloadZipFileNative(string url, Il2CppSystem.Action<bool> downloadDone, Il2CppSystem.Action<inMemory> inmem, Il2CppSystem.Action<System.IntPtr> pointer = null, Il2CppSystem.Action<int> fileSize = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)downloadDone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inmem);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pointer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileSize);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_downloadZipFileNative_Public_Static_IEnumerator_String_Action_1_Boolean_Action_1_inMemory_Action_1_IntPtr_Action_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe lzip()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<lzip>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public lzip(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
