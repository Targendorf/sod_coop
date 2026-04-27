using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class DebugPathfind : MonoBehaviour
{
	[System.Serializable]
	public class DebugLocationLink : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_access;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NodeAccess_String_0;

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

		public unsafe NewNode.NodeAccess access
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_access);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode.NodeAccess>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_access)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodeAccess));
			}
		}

		static DebugLocationLink()
		{
			Il2CppClassPointerStore<DebugLocationLink>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, "DebugLocationLink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugLocationLink>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLocationLink>.NativeClassPtr, "name");
			NativeFieldInfoPtr_access = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLocationLink>.NativeClassPtr, "access");
			NativeMethodInfoPtr__ctor_Public_Void_NodeAccess_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLocationLink>.NativeClassPtr, 100666519);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109926, XrefRangeEnd = 109953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugLocationLink(NewNode.NodeAccess acc, string reason)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugLocationLink>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)acc);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(reason);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NodeAccess_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DebugLocationLink(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_access;

	private static readonly System.IntPtr NativeFieldInfoPtr_room;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_fromNodePos;

	private static readonly System.IntPtr NativeFieldInfoPtr_toNodePos;

	private static readonly System.IntPtr NativeFieldInfoPtr_walkingAccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_employeeDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_noPassThroughOnFromNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_noPassThroughOnToNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_noAccessOnFromNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_noAccessOnToNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_locationLinkAttempts;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_NodeAccess_NewRoom_List_1_DebugLocationLink_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TeleportPlayer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe NewNode.NodeAccess access
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_access);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode.NodeAccess>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_access)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodeAccess));
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

	public unsafe NewGameLocation gameLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLocation);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewGameLocation>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameLocation)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newGameLocation));
		}
	}

	public unsafe Vector3 fromNodePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromNodePos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fromNodePos)) = vector;
		}
	}

	public unsafe Vector3 toNodePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toNodePos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toNodePos)) = vector;
		}
	}

	public unsafe bool walkingAccess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_walkingAccess);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_walkingAccess)) = flag;
		}
	}

	public unsafe bool employeeDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_employeeDoor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_employeeDoor)) = flag;
		}
	}

	public unsafe bool noPassThroughOnFromNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noPassThroughOnFromNode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noPassThroughOnFromNode)) = flag;
		}
	}

	public unsafe bool noPassThroughOnToNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noPassThroughOnToNode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noPassThroughOnToNode)) = flag;
		}
	}

	public unsafe bool noAccessOnFromNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAccessOnFromNode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAccessOnFromNode)) = flag;
		}
	}

	public unsafe bool noAccessOnToNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAccessOnToNode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noAccessOnToNode)) = flag;
		}
	}

	public unsafe List<DebugLocationLink> locationLinkAttempts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationLinkAttempts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DebugLocationLink>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationLinkAttempts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static DebugPathfind()
	{
		Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DebugPathfind");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr);
		NativeFieldInfoPtr_access = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, "access");
		NativeFieldInfoPtr_room = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, "room");
		NativeFieldInfoPtr_gameLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, "gameLocation");
		NativeFieldInfoPtr_fromNodePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, "fromNodePos");
		NativeFieldInfoPtr_toNodePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, "toNodePos");
		NativeFieldInfoPtr_walkingAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, "walkingAccess");
		NativeFieldInfoPtr_employeeDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, "employeeDoor");
		NativeFieldInfoPtr_noPassThroughOnFromNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, "noPassThroughOnFromNode");
		NativeFieldInfoPtr_noPassThroughOnToNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, "noPassThroughOnToNode");
		NativeFieldInfoPtr_noAccessOnFromNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, "noAccessOnFromNode");
		NativeFieldInfoPtr_noAccessOnToNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, "noAccessOnToNode");
		NativeFieldInfoPtr_locationLinkAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, "locationLinkAttempts");
		NativeMethodInfoPtr_Setup_Public_Void_NodeAccess_NewRoom_List_1_DebugLocationLink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, 100666516);
		NativeMethodInfoPtr_TeleportPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, 100666517);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr, 100666518);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 109987, RefRangeEnd = 109989, XrefRangeStart = 109953, XrefRangeEnd = 109987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(NewNode.NodeAccess newAccess, NewRoom newRoom, List<DebugLocationLink> linkList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAccess);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)linkList);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_NodeAccess_NewRoom_List_1_DebugLocationLink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109989, XrefRangeEnd = 109991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TeleportPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TeleportPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109991, XrefRangeEnd = 110000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugPathfind()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugPathfind>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DebugPathfind(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
