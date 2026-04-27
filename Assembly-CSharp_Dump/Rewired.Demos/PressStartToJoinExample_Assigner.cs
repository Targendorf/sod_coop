using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Rewired.Demos;

public class PressStartToJoinExample_Assigner : MonoBehaviour
{
	public class PlayerMap : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rewiredPlayerId;

		private static readonly System.IntPtr NativeFieldInfoPtr_gamePlayerId;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		public unsafe int rewiredPlayerId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewiredPlayerId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewiredPlayerId)) = num;
			}
		}

		public unsafe int gamePlayerId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamePlayerId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamePlayerId)) = num;
			}
		}

		static PlayerMap()
		{
			Il2CppClassPointerStore<PlayerMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, "PlayerMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMap>.NativeClassPtr);
			NativeFieldInfoPtr_rewiredPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMap>.NativeClassPtr, "rewiredPlayerId");
			NativeFieldInfoPtr_gamePlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMap>.NativeClassPtr, "gamePlayerId");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMap>.NativeClassPtr, 100676675);
		}

		[CallerCount(0)]
		public unsafe PlayerMap(int rewiredPlayerId, int gamePlayerId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMap>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&rewiredPlayerId);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gamePlayerId;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public PlayerMap(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPlayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_gamePlayerIdCounter;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRewiredPlayer_Public_Static_Player_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssignNextPlayer_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextGamePlayerId_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static PressStartToJoinExample_Assigner instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PressStartToJoinExample_Assigner>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pressStartToJoinExample_Assigner));
		}
	}

	public unsafe int maxPlayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPlayers);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPlayers)) = num;
		}
	}

	public unsafe List<PlayerMap> playerMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PlayerMap>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int gamePlayerIdCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamePlayerIdCounter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gamePlayerIdCounter)) = num;
		}
	}

	static PressStartToJoinExample_Assigner()
	{
		Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "PressStartToJoinExample_Assigner");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr);
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_maxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, "maxPlayers");
		NativeFieldInfoPtr_playerMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, "playerMap");
		NativeFieldInfoPtr_gamePlayerIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, "gamePlayerIdCounter");
		NativeMethodInfoPtr_GetRewiredPlayer_Public_Static_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100676669);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100676670);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100676671);
		NativeMethodInfoPtr_AssignNextPlayer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100676672);
		NativeMethodInfoPtr_GetNextGamePlayerId_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100676673);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100676674);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 365957, RefRangeEnd = 365965, XrefRangeStart = 365920, XrefRangeEnd = 365957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Player GetRewiredPlayer(int gamePlayerId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gamePlayerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRewiredPlayer_Public_Static_Player_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365965, XrefRangeEnd = 365974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365974, XrefRangeEnd = 365994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 366035, RefRangeEnd = 366036, XrefRangeStart = 365994, XrefRangeEnd = 366035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AssignNextPlayer(int rewiredPlayerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rewiredPlayerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssignNextPlayer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetNextGamePlayerId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextGamePlayerId_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PressStartToJoinExample_Assigner()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PressStartToJoinExample_Assigner(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
