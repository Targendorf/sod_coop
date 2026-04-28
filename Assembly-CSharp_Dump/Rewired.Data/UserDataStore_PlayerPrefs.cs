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

namespace Rewired.Data;

public class UserDataStore_PlayerPrefs : UserDataStore
{
	public class ControllerAssignmentSaveInfo : Il2CppSystem.Object
	{
		public class PlayerInfo : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_id;

			private static readonly System.IntPtr NativeFieldInfoPtr_hasKeyboard;

			private static readonly System.IntPtr NativeFieldInfoPtr_hasMouse;

			private static readonly System.IntPtr NativeFieldInfoPtr_joysticks;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_joystickCount_Public_get_Int32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfJoystick_Public_Int32_Int32_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_ContainsJoystick_Public_Boolean_Int32_0;

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

			public unsafe bool hasKeyboard
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasKeyboard);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasKeyboard)) = flag;
				}
			}

			public unsafe bool hasMouse
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasMouse);
					return *(bool*)num;
				}
				set
				{
					*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasMouse)) = flag;
				}
			}

			public unsafe Il2CppReferenceArray<JoystickInfo> joysticks
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joysticks);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<JoystickInfo>>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joysticks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
				}
			}

			public unsafe int joystickCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr2);
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_joystickCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			static PlayerInfo()
			{
				Il2CppClassPointerStore<PlayerInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerAssignmentSaveInfo>.NativeClassPtr, "PlayerInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInfo>.NativeClassPtr);
				NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInfo>.NativeClassPtr, "id");
				NativeFieldInfoPtr_hasKeyboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInfo>.NativeClassPtr, "hasKeyboard");
				NativeFieldInfoPtr_hasMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInfo>.NativeClassPtr, "hasMouse");
				NativeFieldInfoPtr_joysticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInfo>.NativeClassPtr, "joysticks");
				NativeMethodInfoPtr_get_joystickCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInfo>.NativeClassPtr, 100675045);
				NativeMethodInfoPtr_IndexOfJoystick_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInfo>.NativeClassPtr, 100675046);
				NativeMethodInfoPtr_ContainsJoystick_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInfo>.NativeClassPtr, 100675047);
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInfo>.NativeClassPtr, 100675048);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348262, XrefRangeEnd = 348263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int IndexOfJoystick(int joystickId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&joystickId);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfJoystick_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348263, XrefRangeEnd = 348264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ContainsJoystick(int joystickId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&joystickId);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsJoystick_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInfo>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public PlayerInfo(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		public class JoystickInfo : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_instanceGuid;

			private static readonly System.IntPtr NativeFieldInfoPtr_hardwareIdentifier;

			private static readonly System.IntPtr NativeFieldInfoPtr_id;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			public unsafe Il2CppSystem.Guid instanceGuid
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceGuid);
					return *(Il2CppSystem.Guid*)num;
				}
				set
				{
					*(Il2CppSystem.Guid*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceGuid)) = guid;
				}
			}

			public unsafe string hardwareIdentifier
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hardwareIdentifier);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hardwareIdentifier)), IL2CPP.ManagedStringToIl2Cpp(text));
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

			static JoystickInfo()
			{
				Il2CppClassPointerStore<JoystickInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerAssignmentSaveInfo>.NativeClassPtr, "JoystickInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickInfo>.NativeClassPtr);
				NativeFieldInfoPtr_instanceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickInfo>.NativeClassPtr, "instanceGuid");
				NativeFieldInfoPtr_hardwareIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickInfo>.NativeClassPtr, "hardwareIdentifier");
				NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickInfo>.NativeClassPtr, "id");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickInfo>.NativeClassPtr, 100675049);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JoystickInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickInfo>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public JoystickInfo(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_players;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_playerCount_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfPlayer_Public_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ContainsPlayer_Public_Boolean_Int32_0;

		public unsafe Il2CppReferenceArray<PlayerInfo> players
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_players);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerInfo>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_players)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe int playerCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		static ControllerAssignmentSaveInfo()
		{
			Il2CppClassPointerStore<ControllerAssignmentSaveInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "ControllerAssignmentSaveInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerAssignmentSaveInfo>.NativeClassPtr);
			NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerAssignmentSaveInfo>.NativeClassPtr, "players");
			NativeMethodInfoPtr_get_playerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAssignmentSaveInfo>.NativeClassPtr, 100675040);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAssignmentSaveInfo>.NativeClassPtr, 100675041);
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAssignmentSaveInfo>.NativeClassPtr, 100675042);
			NativeMethodInfoPtr_IndexOfPlayer_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAssignmentSaveInfo>.NativeClassPtr, 100675043);
			NativeMethodInfoPtr_ContainsPlayer_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerAssignmentSaveInfo>.NativeClassPtr, 100675044);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerAssignmentSaveInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerAssignmentSaveInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348264, XrefRangeEnd = 348271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerAssignmentSaveInfo(int playerCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerAssignmentSaveInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&playerCount);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 348272, RefRangeEnd = 348277, XrefRangeStart = 348271, XrefRangeEnd = 348272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfPlayer(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&playerId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfPlayer_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348277, XrefRangeEnd = 348278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPlayer(int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&playerId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ContainsPlayer_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public ControllerAssignmentSaveInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class JoystickAssignmentHistoryInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_joystick;

		private static readonly System.IntPtr NativeFieldInfoPtr_oldJoystickId;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Joystick_Int32_0;

		public unsafe Joystick joystick
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joystick);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Joystick>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joystick)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystick));
			}
		}

		public unsafe int oldJoystickId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldJoystickId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldJoystickId)) = num;
			}
		}

		static JoystickAssignmentHistoryInfo()
		{
			Il2CppClassPointerStore<JoystickAssignmentHistoryInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "JoystickAssignmentHistoryInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoystickAssignmentHistoryInfo>.NativeClassPtr);
			NativeFieldInfoPtr_joystick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickAssignmentHistoryInfo>.NativeClassPtr, "joystick");
			NativeFieldInfoPtr_oldJoystickId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoystickAssignmentHistoryInfo>.NativeClassPtr, "oldJoystickId");
			NativeMethodInfoPtr__ctor_Public_Void_Joystick_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoystickAssignmentHistoryInfo>.NativeClassPtr, 100675050);
		}

		[CallerCount(0)]
		public unsafe JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoystickAssignmentHistoryInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystick);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldJoystickId;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Joystick_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public JoystickAssignmentHistoryInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Rewired.Data.UserDataStore_PlayerPrefs+<>c__DisplayClass78_0")]
	public sealed class __c__DisplayClass78_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_joystick;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__0_Internal_Boolean_JoystickAssignmentHistoryInfo_0;

		public unsafe Joystick joystick
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joystick);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Joystick>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joystick)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystick));
			}
		}

		static __c__DisplayClass78_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "<>c__DisplayClass78_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass78_0>.NativeClassPtr);
			NativeFieldInfoPtr_joystick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass78_0>.NativeClassPtr, "joystick");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass78_0>.NativeClassPtr, 100675051);
			NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__0_Internal_Boolean_JoystickAssignmentHistoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass78_0>.NativeClassPtr, 100675052);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass78_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass78_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _LoadJoystickAssignmentsNow_b__0(JoystickAssignmentHistoryInfo x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__0_Internal_Boolean_JoystickAssignmentHistoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass78_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Rewired.Data.UserDataStore_PlayerPrefs+<>c__DisplayClass78_1")]
	public sealed class __c__DisplayClass78_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_joystickInfo;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__1_Internal_Boolean_JoystickAssignmentHistoryInfo_0;

		public unsafe ControllerAssignmentSaveInfo.JoystickInfo joystickInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joystickInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControllerAssignmentSaveInfo.JoystickInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_joystickInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystickInfo));
			}
		}

		static __c__DisplayClass78_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass78_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "<>c__DisplayClass78_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass78_1>.NativeClassPtr);
			NativeFieldInfoPtr_joystickInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass78_1>.NativeClassPtr, "joystickInfo");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass78_1>.NativeClassPtr, 100675053);
			NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__1_Internal_Boolean_JoystickAssignmentHistoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass78_1>.NativeClassPtr, 100675054);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass78_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass78_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _LoadJoystickAssignmentsNow_b__1(JoystickAssignmentHistoryInfo x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__1_Internal_Boolean_JoystickAssignmentHistoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass78_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Rewired.Data.UserDataStore_PlayerPrefs+<>c__DisplayClass78_2")]
	public sealed class __c__DisplayClass78_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_match;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__2_Internal_Boolean_JoystickAssignmentHistoryInfo_0;

		public unsafe Joystick match
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_match);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Joystick>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_match)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystick));
			}
		}

		static __c__DisplayClass78_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass78_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "<>c__DisplayClass78_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass78_2>.NativeClassPtr);
			NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass78_2>.NativeClassPtr, "match");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass78_2>.NativeClassPtr, 100675055);
			NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__2_Internal_Boolean_JoystickAssignmentHistoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass78_2>.NativeClassPtr, 100675056);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass78_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass78_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _LoadJoystickAssignmentsNow_b__2(JoystickAssignmentHistoryInfo x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LoadJoystickAssignmentsNow_b__2_Internal_Boolean_JoystickAssignmentHistoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass78_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Rewired.Data.UserDataStore_PlayerPrefs+<LoadJoystickAssignmentsDeferred>d__80")]
	public sealed class _LoadJoystickAssignmentsDeferred_d__80 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

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

		public unsafe UserDataStore_PlayerPrefs __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UserDataStore_PlayerPrefs>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)userDataStore_PlayerPrefs));
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

		static _LoadJoystickAssignmentsDeferred_d__80()
		{
			Il2CppClassPointerStore<_LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "<LoadJoystickAssignmentsDeferred>d__80");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, "<>4__this");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100675057);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100675058);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100675059);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100675060);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100675061);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr, 100675062);
		}

		[CallerCount(0)]
		public unsafe _LoadJoystickAssignmentsDeferred_d__80(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_LoadJoystickAssignmentsDeferred_d__80>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348278, XrefRangeEnd = 348282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348282, XrefRangeEnd = 348288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _LoadJoystickAssignmentsDeferred_d__80(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_thisScriptName;

	private static readonly System.IntPtr NativeFieldInfoPtr_logPrefix;

	private static readonly System.IntPtr NativeFieldInfoPtr_editorLoadedMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerPrefsKeySuffix_controllerAssignments;

	private static readonly System.IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion_original;

	private static readonly System.IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion_includeDuplicateJoystickIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion_supportDisconnectedControllers;

	private static readonly System.IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion_includeFormatVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_controllerMapPPKeyVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadDataOnStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadJoystickAssignments;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadKeyboardAssignments;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadMouseAssignments;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerPrefsKeyPrefix;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowImpreciseJoystickAssignmentMatching;

	private static readonly System.IntPtr NativeFieldInfoPtr_deferredJoystickAssignmentLoadPending;

	private static readonly System.IntPtr NativeFieldInfoPtr_wasJoystickEverDetected;

	private static readonly System.IntPtr NativeFieldInfoPtr___allActionIds;

	private static readonly System.IntPtr NativeFieldInfoPtr___allActionIdsString;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsEnabled_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadDataOnStart_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LoadDataOnStart_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadJoystickAssignments_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LoadJoystickAssignments_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadKeyboardAssignments_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LoadKeyboardAssignments_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadMouseAssignments_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LoadMouseAssignments_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerPrefsKeyPrefix_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerPrefsKeyPrefix_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playerPrefsKey_controllerAssignments_Private_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_loadControllerAssignments_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allActionIds_Private_get_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allActionIdsString_Private_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SavePlayerData_Public_Virtual_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveInputBehavior_Public_Virtual_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadPlayerData_Public_Virtual_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInputBehavior_Public_Virtual_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerConnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerPreDisconnect_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnControllerDisconnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerMap_Public_Virtual_Void_Int32_ControllerMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerMap_Public_Virtual_ControllerMap_Int32_ControllerIdentifier_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAll_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAllJoystickCalibrationData_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Joystick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadJoystickData_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_Int32_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerMaps_Private_Int32_Int32_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerMap_Private_ControllerMap_Player_ControllerIdentifier_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInputBehaviors_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Player_InputBehavior_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerAssignmentsNow_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadKeyboardAndMouseAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadJoystickAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadControllerAssignmentData_Private_ControllerAssignmentSaveInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadJoystickAssignmentsDeferred_Private_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveAll_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveAllJoystickCalibrationData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Joystick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveJoystickData_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_Int32_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Player_PlayerSaveData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Int32_ControllerType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerMap_Private_Void_Player_ControllerMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveInputBehaviors_Private_Void_Player_PlayerSaveData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Player_InputBehavior_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveControllerAssignments_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ControllerAssignmentSaveDataExists_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBasePlayerPrefsKey_Private_String_Player_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMapPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMapKnownActionIdsPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMapPlayerPrefsKeyCommonSuffix_Private_Static_String_Player_ControllerIdentifier_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJoystickCalibrationMapPlayerPrefsKey_Private_String_Joystick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputBehaviorPlayerPrefsKey_Private_String_Player_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMapXml_Private_String_Player_ControllerIdentifier_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMapKnownActionIds_Private_List_1_Int32_Player_ControllerIdentifier_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetJoystickCalibrationMapXml_Private_String_Joystick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputBehaviorXml_Private_String_Player_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddDefaultMappingsForNewActions_Private_Void_ControllerIdentifier_ControllerMap_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindJoystickPrecise_Private_Joystick_JoystickInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindJoysticksImprecise_Private_Boolean_JoystickInfo_byref_List_1_Joystick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDuplicateIndex_Private_Static_Int32_Player_ControllerIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshLayoutManager_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControllerMapType_Private_Static_Type_ControllerType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string thisScriptName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_thisScriptName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_thisScriptName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string logPrefix
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_logPrefix, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_logPrefix, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string editorLoadedMessage
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_editorLoadedMessage, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_editorLoadedMessage, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string playerPrefsKeySuffix_controllerAssignments
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_playerPrefsKeySuffix_controllerAssignments, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_playerPrefsKeySuffix_controllerAssignments, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int controllerMapPPKeyVersion_original
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_controllerMapPPKeyVersion_original, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_controllerMapPPKeyVersion_original, (void*)(&num));
		}
	}

	public unsafe static int controllerMapPPKeyVersion_includeDuplicateJoystickIndex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_controllerMapPPKeyVersion_includeDuplicateJoystickIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_controllerMapPPKeyVersion_includeDuplicateJoystickIndex, (void*)(&num));
		}
	}

	public unsafe static int controllerMapPPKeyVersion_supportDisconnectedControllers
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_controllerMapPPKeyVersion_supportDisconnectedControllers, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_controllerMapPPKeyVersion_supportDisconnectedControllers, (void*)(&num));
		}
	}

	public unsafe static int controllerMapPPKeyVersion_includeFormatVersion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_controllerMapPPKeyVersion_includeFormatVersion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_controllerMapPPKeyVersion_includeFormatVersion, (void*)(&num));
		}
	}

	public unsafe static int controllerMapPPKeyVersion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_controllerMapPPKeyVersion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_controllerMapPPKeyVersion, (void*)(&num));
		}
	}

	public unsafe bool isEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnabled)) = flag;
		}
	}

	public unsafe bool loadDataOnStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadDataOnStart);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadDataOnStart)) = flag;
		}
	}

	public unsafe bool loadJoystickAssignments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadJoystickAssignments);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadJoystickAssignments)) = flag;
		}
	}

	public unsafe bool loadKeyboardAssignments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadKeyboardAssignments);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadKeyboardAssignments)) = flag;
		}
	}

	public unsafe bool loadMouseAssignments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadMouseAssignments);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadMouseAssignments)) = flag;
		}
	}

	public unsafe string playerPrefsKeyPrefix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPrefsKeyPrefix);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerPrefsKeyPrefix)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool allowImpreciseJoystickAssignmentMatching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowImpreciseJoystickAssignmentMatching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowImpreciseJoystickAssignmentMatching)) = flag;
		}
	}

	public unsafe bool deferredJoystickAssignmentLoadPending
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deferredJoystickAssignmentLoadPending);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deferredJoystickAssignmentLoadPending)) = flag;
		}
	}

	public unsafe bool wasJoystickEverDetected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wasJoystickEverDetected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wasJoystickEverDetected)) = flag;
		}
	}

	public unsafe List<int> __allActionIds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___allActionIds);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___allActionIds)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string __allActionIdsString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___allActionIdsString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___allActionIdsString)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool IsEnabled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool LoadDataOnStart
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LoadDataOnStart_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LoadDataOnStart_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool LoadJoystickAssignments
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LoadJoystickAssignments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LoadJoystickAssignments_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool LoadKeyboardAssignments
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LoadKeyboardAssignments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LoadKeyboardAssignments_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool LoadMouseAssignments
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LoadMouseAssignments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LoadMouseAssignments_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe string PlayerPrefsKeyPrefix
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerPrefsKeyPrefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 59139, RefRangeEnd = 59183, XrefRangeStart = 59139, XrefRangeEnd = 59183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PlayerPrefsKeyPrefix_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe string playerPrefsKey_controllerAssignments
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 348294, RefRangeEnd = 348299, XrefRangeStart = 348288, XrefRangeEnd = 348294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playerPrefsKey_controllerAssignments_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe bool loadControllerAssignments
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_loadControllerAssignments_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe List<int> allActionIds
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 348321, RefRangeEnd = 348324, XrefRangeStart = 348299, XrefRangeEnd = 348321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allActionIds_Private_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
	}

	public unsafe string allActionIdsString
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348324, XrefRangeEnd = 348337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allActionIdsString_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	static UserDataStore_PlayerPrefs()
	{
		Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Data", "UserDataStore_PlayerPrefs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr);
		NativeFieldInfoPtr_thisScriptName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "thisScriptName");
		NativeFieldInfoPtr_logPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "logPrefix");
		NativeFieldInfoPtr_editorLoadedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "editorLoadedMessage");
		NativeFieldInfoPtr_playerPrefsKeySuffix_controllerAssignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "playerPrefsKeySuffix_controllerAssignments");
		NativeFieldInfoPtr_controllerMapPPKeyVersion_original = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "controllerMapPPKeyVersion_original");
		NativeFieldInfoPtr_controllerMapPPKeyVersion_includeDuplicateJoystickIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "controllerMapPPKeyVersion_includeDuplicateJoystickIndex");
		NativeFieldInfoPtr_controllerMapPPKeyVersion_supportDisconnectedControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "controllerMapPPKeyVersion_supportDisconnectedControllers");
		NativeFieldInfoPtr_controllerMapPPKeyVersion_includeFormatVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "controllerMapPPKeyVersion_includeFormatVersion");
		NativeFieldInfoPtr_controllerMapPPKeyVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "controllerMapPPKeyVersion");
		NativeFieldInfoPtr_isEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "isEnabled");
		NativeFieldInfoPtr_loadDataOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "loadDataOnStart");
		NativeFieldInfoPtr_loadJoystickAssignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "loadJoystickAssignments");
		NativeFieldInfoPtr_loadKeyboardAssignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "loadKeyboardAssignments");
		NativeFieldInfoPtr_loadMouseAssignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "loadMouseAssignments");
		NativeFieldInfoPtr_playerPrefsKeyPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "playerPrefsKeyPrefix");
		NativeFieldInfoPtr_allowImpreciseJoystickAssignmentMatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "allowImpreciseJoystickAssignmentMatching");
		NativeFieldInfoPtr_deferredJoystickAssignmentLoadPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "deferredJoystickAssignmentLoadPending");
		NativeFieldInfoPtr_wasJoystickEverDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "wasJoystickEverDetected");
		NativeFieldInfoPtr___allActionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "__allActionIds");
		NativeFieldInfoPtr___allActionIdsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, "__allActionIdsString");
		NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674955);
		NativeMethodInfoPtr_set_IsEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674956);
		NativeMethodInfoPtr_get_LoadDataOnStart_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674957);
		NativeMethodInfoPtr_set_LoadDataOnStart_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674958);
		NativeMethodInfoPtr_get_LoadJoystickAssignments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674959);
		NativeMethodInfoPtr_set_LoadJoystickAssignments_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674960);
		NativeMethodInfoPtr_get_LoadKeyboardAssignments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674961);
		NativeMethodInfoPtr_set_LoadKeyboardAssignments_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674962);
		NativeMethodInfoPtr_get_LoadMouseAssignments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674963);
		NativeMethodInfoPtr_set_LoadMouseAssignments_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674964);
		NativeMethodInfoPtr_get_PlayerPrefsKeyPrefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674965);
		NativeMethodInfoPtr_set_PlayerPrefsKeyPrefix_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674966);
		NativeMethodInfoPtr_get_playerPrefsKey_controllerAssignments_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674967);
		NativeMethodInfoPtr_get_loadControllerAssignments_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674968);
		NativeMethodInfoPtr_get_allActionIds_Private_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674969);
		NativeMethodInfoPtr_get_allActionIdsString_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674970);
		NativeMethodInfoPtr_Save_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674971);
		NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674972);
		NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674973);
		NativeMethodInfoPtr_SavePlayerData_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674974);
		NativeMethodInfoPtr_SaveInputBehavior_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674975);
		NativeMethodInfoPtr_Load_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674976);
		NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674977);
		NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674978);
		NativeMethodInfoPtr_LoadPlayerData_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674979);
		NativeMethodInfoPtr_LoadInputBehavior_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674980);
		NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674981);
		NativeMethodInfoPtr_OnControllerConnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674982);
		NativeMethodInfoPtr_OnControllerPreDisconnect_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674983);
		NativeMethodInfoPtr_OnControllerDisconnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674984);
		NativeMethodInfoPtr_SaveControllerMap_Public_Virtual_Void_Int32_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674985);
		NativeMethodInfoPtr_LoadControllerMap_Public_Virtual_ControllerMap_Int32_ControllerIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674986);
		NativeMethodInfoPtr_LoadAll_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674987);
		NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674988);
		NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674989);
		NativeMethodInfoPtr_LoadAllJoystickCalibrationData_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674990);
		NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674991);
		NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674992);
		NativeMethodInfoPtr_LoadJoystickData_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674993);
		NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674994);
		NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674995);
		NativeMethodInfoPtr_LoadControllerMaps_Private_Int32_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674996);
		NativeMethodInfoPtr_LoadControllerMap_Private_ControllerMap_Player_ControllerIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674997);
		NativeMethodInfoPtr_LoadInputBehaviors_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674998);
		NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100674999);
		NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Player_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675000);
		NativeMethodInfoPtr_LoadControllerAssignmentsNow_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675001);
		NativeMethodInfoPtr_LoadKeyboardAndMouseAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675002);
		NativeMethodInfoPtr_LoadJoystickAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675003);
		NativeMethodInfoPtr_LoadControllerAssignmentData_Private_ControllerAssignmentSaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675004);
		NativeMethodInfoPtr_LoadJoystickAssignmentsDeferred_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675005);
		NativeMethodInfoPtr_SaveAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675006);
		NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675007);
		NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675008);
		NativeMethodInfoPtr_SaveAllJoystickCalibrationData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675009);
		NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675010);
		NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675011);
		NativeMethodInfoPtr_SaveJoystickData_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675012);
		NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675013);
		NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675014);
		NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Player_PlayerSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675015);
		NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Int32_ControllerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675016);
		NativeMethodInfoPtr_SaveControllerMap_Private_Void_Player_ControllerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675017);
		NativeMethodInfoPtr_SaveInputBehaviors_Private_Void_Player_PlayerSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675018);
		NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675019);
		NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Player_InputBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675020);
		NativeMethodInfoPtr_SaveControllerAssignments_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675021);
		NativeMethodInfoPtr_ControllerAssignmentSaveDataExists_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675022);
		NativeMethodInfoPtr_GetBasePlayerPrefsKey_Private_String_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675023);
		NativeMethodInfoPtr_GetControllerMapPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675024);
		NativeMethodInfoPtr_GetControllerMapKnownActionIdsPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675025);
		NativeMethodInfoPtr_GetControllerMapPlayerPrefsKeyCommonSuffix_Private_Static_String_Player_ControllerIdentifier_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675026);
		NativeMethodInfoPtr_GetJoystickCalibrationMapPlayerPrefsKey_Private_String_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675027);
		NativeMethodInfoPtr_GetInputBehaviorPlayerPrefsKey_Private_String_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675028);
		NativeMethodInfoPtr_GetControllerMapXml_Private_String_Player_ControllerIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675029);
		NativeMethodInfoPtr_GetControllerMapKnownActionIds_Private_List_1_Int32_Player_ControllerIdentifier_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675030);
		NativeMethodInfoPtr_GetJoystickCalibrationMapXml_Private_String_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675031);
		NativeMethodInfoPtr_GetInputBehaviorXml_Private_String_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675032);
		NativeMethodInfoPtr_AddDefaultMappingsForNewActions_Private_Void_ControllerIdentifier_ControllerMap_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675033);
		NativeMethodInfoPtr_FindJoystickPrecise_Private_Joystick_JoystickInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675034);
		NativeMethodInfoPtr_TryFindJoysticksImprecise_Private_Boolean_JoystickInfo_byref_List_1_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675035);
		NativeMethodInfoPtr_GetDuplicateIndex_Private_Static_Int32_Player_ControllerIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675036);
		NativeMethodInfoPtr_RefreshLayoutManager_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675037);
		NativeMethodInfoPtr_GetControllerMapType_Private_Static_Type_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675038);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr, 100675039);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348337, XrefRangeEnd = 348344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Save_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348344, XrefRangeEnd = 348357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playerId);
		*(ControllerType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348357, XrefRangeEnd = 348368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SaveControllerData(ControllerType controllerType, int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&controllerType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveControllerData_Public_Virtual_Void_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348368, XrefRangeEnd = 348385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SavePlayerData(int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SavePlayerData_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348385, XrefRangeEnd = 348401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SaveInputBehavior(int playerId, int behaviorId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &behaviorId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveInputBehavior_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348401, XrefRangeEnd = 348408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Load()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Load_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348408, XrefRangeEnd = 348418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playerId);
		*(ControllerType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_Int32_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348418, XrefRangeEnd = 348425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LoadControllerData(ControllerType controllerType, int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&controllerType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadControllerData_Public_Virtual_Void_ControllerType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348425, XrefRangeEnd = 348438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LoadPlayerData(int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadPlayerData_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348438, XrefRangeEnd = 348450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void LoadInputBehavior(int playerId, int behaviorId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &behaviorId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadInputBehavior_Public_Virtual_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348450, XrefRangeEnd = 348456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348456, XrefRangeEnd = 348465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnControllerConnected(ControllerStatusChangedEventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnControllerConnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348465, XrefRangeEnd = 348466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnControllerPreDisconnect_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348466, XrefRangeEnd = 348470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnControllerDisconnected_Protected_Virtual_Void_ControllerStatusChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348470, XrefRangeEnd = 348476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SaveControllerMap(int playerId, ControllerMap controllerMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerMap);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SaveControllerMap_Public_Virtual_Void_Int32_ControllerMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348476, XrefRangeEnd = 348482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&playerId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controllerIdentifier));
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &categoryId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layoutId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadControllerMap_Public_Virtual_ControllerMap_Int32_ControllerIdentifier_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 348499, RefRangeEnd = 348500, XrefRangeStart = 348482, XrefRangeEnd = 348499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LoadAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAll_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348500, XrefRangeEnd = 348507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LoadPlayerDataNow(int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 348536, RefRangeEnd = 348539, XrefRangeStart = 348507, XrefRangeEnd = 348536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LoadPlayerDataNow(Player player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadPlayerDataNow_Private_Int32_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 348554, RefRangeEnd = 348555, XrefRangeStart = 348539, XrefRangeEnd = 348554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LoadAllJoystickCalibrationData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAllJoystickCalibrationData_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 348563, RefRangeEnd = 348566, XrefRangeStart = 348555, XrefRangeEnd = 348563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LoadJoystickCalibrationData(Joystick joystick)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystick);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 348573, RefRangeEnd = 348577, XrefRangeStart = 348566, XrefRangeEnd = 348573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LoadJoystickCalibrationData(int joystickId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&joystickId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadJoystickCalibrationData_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 348612, RefRangeEnd = 348613, XrefRangeStart = 348577, XrefRangeEnd = 348612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LoadJoystickData(int joystickId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&joystickId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadJoystickData_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348613, XrefRangeEnd = 348617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playerId);
		*(ControllerType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348617, XrefRangeEnd = 348618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LoadControllerDataNow(ControllerType controllerType, int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&controllerType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadControllerDataNow_Private_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 348662, RefRangeEnd = 348668, XrefRangeStart = 348618, XrefRangeEnd = 348662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playerId);
		*(ControllerType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadControllerMaps_Private_Int32_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 348672, RefRangeEnd = 348674, XrefRangeStart = 348668, XrefRangeEnd = 348672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controllerIdentifier));
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &categoryId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layoutId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadControllerMap_Private_ControllerMap_Player_ControllerIdentifier_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControllerMap>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 348694, RefRangeEnd = 348695, XrefRangeStart = 348674, XrefRangeEnd = 348694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LoadInputBehaviors(int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadInputBehaviors_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348695, XrefRangeEnd = 348705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LoadInputBehaviorNow(int playerId, int behaviorId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &behaviorId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 348716, RefRangeEnd = 348719, XrefRangeStart = 348705, XrefRangeEnd = 348716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputBehavior);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadInputBehaviorNow_Private_Int32_Player_InputBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 348723, RefRangeEnd = 348724, XrefRangeStart = 348719, XrefRangeEnd = 348723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LoadControllerAssignmentsNow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadControllerAssignmentsNow_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 348730, RefRangeEnd = 348731, XrefRangeStart = 348724, XrefRangeEnd = 348730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadKeyboardAndMouseAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 348883, RefRangeEnd = 348884, XrefRangeStart = 348731, XrefRangeEnd = 348883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadJoystickAssignmentsNow_Private_Boolean_ControllerAssignmentSaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 348901, RefRangeEnd = 348904, XrefRangeStart = 348884, XrefRangeEnd = 348901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ControllerAssignmentSaveInfo LoadControllerAssignmentData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadControllerAssignmentData_Private_ControllerAssignmentSaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ControllerAssignmentSaveInfo>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348904, XrefRangeEnd = 348907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator LoadJoystickAssignmentsDeferred()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadJoystickAssignmentsDeferred_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 348929, RefRangeEnd = 348930, XrefRangeStart = 348907, XrefRangeEnd = 348929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348930, XrefRangeEnd = 348941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SavePlayerDataNow(int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 348947, RefRangeEnd = 348950, XrefRangeStart = 348941, XrefRangeEnd = 348947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SavePlayerDataNow(Player player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SavePlayerDataNow_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 348965, RefRangeEnd = 348966, XrefRangeStart = 348950, XrefRangeEnd = 348965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveAllJoystickCalibrationData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveAllJoystickCalibrationData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 348973, RefRangeEnd = 348977, XrefRangeStart = 348966, XrefRangeEnd = 348973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveJoystickCalibrationData(int joystickId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&joystickId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 348989, RefRangeEnd = 348992, XrefRangeStart = 348977, XrefRangeEnd = 348989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveJoystickCalibrationData(Joystick joystick)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystick);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveJoystickCalibrationData_Private_Void_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 349026, RefRangeEnd = 349027, XrefRangeStart = 348992, XrefRangeEnd = 349026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveJoystickData(int joystickId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&joystickId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveJoystickData_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349027, XrefRangeEnd = 349037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playerId);
		*(ControllerType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349037, XrefRangeEnd = 349042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveControllerDataNow(ControllerType controllerType, int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&controllerType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveControllerDataNow_Private_Void_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 349062, RefRangeEnd = 349063, XrefRangeStart = 349042, XrefRangeEnd = 349062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)playerSaveData));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Player_PlayerSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 349083, RefRangeEnd = 349086, XrefRangeStart = 349063, XrefRangeEnd = 349083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&playerId);
		*(ControllerType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerType;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controllerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveControllerMaps_Private_Void_Int32_ControllerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 349111, RefRangeEnd = 349114, XrefRangeStart = 349086, XrefRangeEnd = 349111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveControllerMap(Player player, ControllerMap controllerMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerMap);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveControllerMap_Private_Void_Player_ControllerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349114, XrefRangeEnd = 349118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)playerSaveData));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveInputBehaviors_Private_Void_Player_PlayerSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349118, XrefRangeEnd = 349132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveInputBehaviorNow(int playerId, int behaviorId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &behaviorId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349132, XrefRangeEnd = 349135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputBehavior);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveInputBehaviorNow_Private_Void_Player_InputBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 349192, RefRangeEnd = 349196, XrefRangeStart = 349135, XrefRangeEnd = 349192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SaveControllerAssignments()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveControllerAssignments_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349196, XrefRangeEnd = 349201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ControllerAssignmentSaveDataExists()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ControllerAssignmentSaveDataExists_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349201, XrefRangeEnd = 349206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetBasePlayerPrefsKey(Player player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBasePlayerPrefsKey_Private_String_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 349216, RefRangeEnd = 349219, XrefRangeStart = 349206, XrefRangeEnd = 349216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controllerIdentifier));
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &categoryId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layoutId;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &ppKeyVersion;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControllerMapPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 349229, RefRangeEnd = 349231, XrefRangeStart = 349219, XrefRangeEnd = 349229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controllerIdentifier));
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &categoryId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layoutId;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &ppKeyVersion;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControllerMapKnownActionIdsPlayerPrefsKey_Private_String_Player_ControllerIdentifier_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 349304, RefRangeEnd = 349306, XrefRangeStart = 349231, XrefRangeEnd = 349304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controllerIdentifier));
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &categoryId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layoutId;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &ppKeyVersion;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControllerMapPlayerPrefsKeyCommonSuffix_Private_Static_String_Player_ControllerIdentifier_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 349327, RefRangeEnd = 349330, XrefRangeStart = 349306, XrefRangeEnd = 349327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystick);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJoystickCalibrationMapPlayerPrefsKey_Private_String_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 349342, RefRangeEnd = 349349, XrefRangeStart = 349330, XrefRangeEnd = 349342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputBehaviorId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputBehaviorPlayerPrefsKey_Private_String_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349349, XrefRangeEnd = 349354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controllerIdentifier));
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &categoryId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layoutId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControllerMapXml_Private_String_Player_ControllerIdentifier_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349354, XrefRangeEnd = 349364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controllerIdentifier));
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &categoryId;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layoutId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControllerMapKnownActionIds_Private_List_1_Int32_Player_ControllerIdentifier_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349364, XrefRangeEnd = 349370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetJoystickCalibrationMapXml(Joystick joystick)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystick);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetJoystickCalibrationMapXml_Private_String_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349370, XrefRangeEnd = 349376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetInputBehaviorXml(Player player, int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputBehaviorXml_Private_String_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349376, XrefRangeEnd = 349424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controllerIdentifier));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controllerMap);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)knownActionIds);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddDefaultMappingsForNewActions_Private_Void_ControllerIdentifier_ControllerMap_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 349439, RefRangeEnd = 349440, XrefRangeStart = 349424, XrefRangeEnd = 349439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Joystick FindJoystickPrecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystickInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindJoystickPrecise_Private_Joystick_JoystickInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Joystick>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 349471, RefRangeEnd = 349472, XrefRangeStart = 349440, XrefRangeEnd = 349471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryFindJoysticksImprecise(ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)joystickInfo);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindJoysticksImprecise_Private_Boolean_JoystickInfo_byref_List_1_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		matches = ((num3 == 0) ? null : new List<Joystick>(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 349518, RefRangeEnd = 349519, XrefRangeStart = 349472, XrefRangeEnd = 349518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)controllerIdentifier));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDuplicateIndex_Private_Static_Int32_Player_ControllerIdentifier_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 349525, RefRangeEnd = 349529, XrefRangeStart = 349519, XrefRangeEnd = 349525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshLayoutManager(int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshLayoutManager_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349529, XrefRangeEnd = 349544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type GetControllerMapType(ControllerType controllerType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&controllerType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControllerMapType_Private_Static_Type_ControllerType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349544, XrefRangeEnd = 349549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UserDataStore_PlayerPrefs()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserDataStore_PlayerPrefs>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UserDataStore_PlayerPrefs(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
