using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using UnityEngine;

public class RestartSafeController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_loadFromDirty;

	private static readonly IntPtr NativeFieldInfoPtr_generateNew;

	private static readonly IntPtr NativeFieldInfoPtr_newGameLoadCity;

	private static readonly IntPtr NativeFieldInfoPtr_loadCityFileInfo;

	private static readonly IntPtr NativeFieldInfoPtr_cityName;

	private static readonly IntPtr NativeFieldInfoPtr_cityX;

	private static readonly IntPtr NativeFieldInfoPtr_cityY;

	private static readonly IntPtr NativeFieldInfoPtr_seed;

	private static readonly IntPtr NativeFieldInfoPtr_sandbox;

	private static readonly IntPtr NativeFieldInfoPtr_newGamePlayerFirstName;

	private static readonly IntPtr NativeFieldInfoPtr_newGamePlayerSurname;

	private static readonly IntPtr NativeFieldInfoPtr_newGamePlayerGender;

	private static readonly IntPtr NativeFieldInfoPtr_newGamePartnerGender;

	private static readonly IntPtr NativeFieldInfoPtr_newGamePlayerSkinTone;

	private static readonly IntPtr NativeFieldInfoPtr_loadSaveGame;

	private static readonly IntPtr NativeFieldInfoPtr_saveStateFileInfo;

	private static readonly IntPtr NativeFieldInfoPtr_newFloor;

	private static readonly IntPtr NativeFieldInfoPtr_newFloorName;

	private static readonly IntPtr NativeFieldInfoPtr_newFloorSize;

	private static readonly IntPtr NativeFieldInfoPtr_newFloorFloorHeight;

	private static readonly IntPtr NativeFieldInfoPtr_newFloorCeilingHeight;

	private static readonly IntPtr NativeFieldInfoPtr_loadFloor;

	private static readonly IntPtr NativeFieldInfoPtr_loadFloorString;

	private static readonly IntPtr NativeFieldInfoPtr_recalculateAll;

	private static readonly IntPtr NativeFieldInfoPtr_floorList;

	private static readonly IntPtr NativeFieldInfoPtr__instance;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_RestartSafeController_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool loadFromDirty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadFromDirty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadFromDirty)) = flag;
		}
	}

	public unsafe bool generateNew
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateNew);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_generateNew)) = flag;
		}
	}

	public unsafe bool newGameLoadCity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newGameLoadCity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newGameLoadCity)) = flag;
		}
	}

	public unsafe FileInfo loadCityFileInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadCityFileInfo);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FileInfo>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadCityFileInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileInfo));
		}
	}

	public unsafe string cityName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int cityX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityX)) = num;
		}
	}

	public unsafe int cityY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityY)) = num;
		}
	}

	public unsafe string seed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool sandbox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sandbox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sandbox)) = flag;
		}
	}

	public unsafe string newGamePlayerFirstName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newGamePlayerFirstName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newGamePlayerFirstName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string newGamePlayerSurname
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newGamePlayerSurname);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newGamePlayerSurname)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Human.Gender newGamePlayerGender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newGamePlayerGender);
			return *(Human.Gender*)num;
		}
		set
		{
			*(Human.Gender*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newGamePlayerGender)) = gender;
		}
	}

	public unsafe Human.Gender newGamePartnerGender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newGamePartnerGender);
			return *(Human.Gender*)num;
		}
		set
		{
			*(Human.Gender*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newGamePartnerGender)) = gender;
		}
	}

	public unsafe Color newGamePlayerSkinTone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newGamePlayerSkinTone);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newGamePlayerSkinTone)) = color;
		}
	}

	public unsafe bool loadSaveGame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadSaveGame);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadSaveGame)) = flag;
		}
	}

	public unsafe FileInfo saveStateFileInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveStateFileInfo);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FileInfo>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveStateFileInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileInfo));
		}
	}

	public unsafe bool newFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newFloor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newFloor)) = flag;
		}
	}

	public unsafe string newFloorName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newFloorName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newFloorName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Vector2 newFloorSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newFloorSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newFloorSize)) = vector;
		}
	}

	public unsafe int newFloorFloorHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newFloorFloorHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newFloorFloorHeight)) = num;
		}
	}

	public unsafe int newFloorCeilingHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newFloorCeilingHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newFloorCeilingHeight)) = num;
		}
	}

	public unsafe bool loadFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadFloor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadFloor)) = flag;
		}
	}

	public unsafe string loadFloorString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadFloorString);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadFloorString)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool recalculateAll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recalculateAll);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recalculateAll)) = flag;
		}
	}

	public unsafe List<string> floorList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static RestartSafeController _instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<RestartSafeController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)restartSafeController));
		}
	}

	public unsafe static RestartSafeController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241092, XrefRangeEnd = 241094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_RestartSafeController_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RestartSafeController>(intPtr) : null;
		}
	}

	static RestartSafeController()
	{
		Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RestartSafeController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr);
		NativeFieldInfoPtr_loadFromDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "loadFromDirty");
		NativeFieldInfoPtr_generateNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "generateNew");
		NativeFieldInfoPtr_newGameLoadCity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "newGameLoadCity");
		NativeFieldInfoPtr_loadCityFileInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "loadCityFileInfo");
		NativeFieldInfoPtr_cityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "cityName");
		NativeFieldInfoPtr_cityX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "cityX");
		NativeFieldInfoPtr_cityY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "cityY");
		NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "seed");
		NativeFieldInfoPtr_sandbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "sandbox");
		NativeFieldInfoPtr_newGamePlayerFirstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "newGamePlayerFirstName");
		NativeFieldInfoPtr_newGamePlayerSurname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "newGamePlayerSurname");
		NativeFieldInfoPtr_newGamePlayerGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "newGamePlayerGender");
		NativeFieldInfoPtr_newGamePartnerGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "newGamePartnerGender");
		NativeFieldInfoPtr_newGamePlayerSkinTone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "newGamePlayerSkinTone");
		NativeFieldInfoPtr_loadSaveGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "loadSaveGame");
		NativeFieldInfoPtr_saveStateFileInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "saveStateFileInfo");
		NativeFieldInfoPtr_newFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "newFloor");
		NativeFieldInfoPtr_newFloorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "newFloorName");
		NativeFieldInfoPtr_newFloorSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "newFloorSize");
		NativeFieldInfoPtr_newFloorFloorHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "newFloorFloorHeight");
		NativeFieldInfoPtr_newFloorCeilingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "newFloorCeilingHeight");
		NativeFieldInfoPtr_loadFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "loadFloor");
		NativeFieldInfoPtr_loadFloorString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "loadFloorString");
		NativeFieldInfoPtr_recalculateAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "recalculateAll");
		NativeFieldInfoPtr_floorList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "floorList");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_RestartSafeController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, 100670312);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, 100670313);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr, 100670314);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241094, XrefRangeEnd = 241135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241135, XrefRangeEnd = 241146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RestartSafeController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RestartSafeController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RestartSafeController(IntPtr pointer)
		: base(pointer)
	{
	}
}
