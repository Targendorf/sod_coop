using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

public class BasebouleSimulator : MonoBehaviour
{
	private sealed class MethodInfoStoreGeneric_GetShuffledIndexesOfList_Private_Il2CppStructArray_1_Int32_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetShuffledIndexesOfList_Private_Il2CppStructArray_1_Int32_List_1_T_0, Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_availableTeams;

	private static readonly System.IntPtr NativeFieldInfoPtr_availableIntros;

	private static readonly System.IntPtr NativeFieldInfoPtr_availableFollowUps;

	private static readonly System.IntPtr NativeFieldInfoPtr_availableIntroClosingStatements;

	private static readonly System.IntPtr NativeFieldInfoPtr_availableAdverts;

	private static readonly System.IntPtr NativeFieldInfoPtr_homeTeam;

	private static readonly System.IntPtr NativeFieldInfoPtr_awayTeam;

	private static readonly System.IntPtr NativeFieldInfoPtr__basebouleGame;

	private static readonly System.IntPtr NativeFieldInfoPtr__introSelection;

	private static readonly System.IntPtr NativeFieldInfoPtr__followUpSelection;

	private static readonly System.IntPtr NativeFieldInfoPtr__closingSelection;

	private static readonly System.IntPtr NativeFieldInfoPtr__homeTeamIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__awayTeamIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__homeRosterPlayerOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr__awayRosterPlayerOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr__adsPlayed;

	private static readonly System.IntPtr NativeFieldInfoPtr__adOrder;

	private static readonly System.IntPtr NativeMethodInfoPtr_SimGame_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RollIntroduction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryNextAd_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RollTeams_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RollPlayerOrder_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RollAdOrder_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShuffledIndexesOfList_Private_Il2CppStructArray_1_Int32_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RollTeams_b__20_0_Private_Boolean_BasebouleTeam_0;

	public unsafe List<BasebouleTeam> availableTeams
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableTeams);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BasebouleTeam>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableTeams)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BasebouleGameIntro> availableIntros
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableIntros);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BasebouleGameIntro>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableIntros)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BasebouleGameLineUpFollowUp> availableFollowUps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableFollowUps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BasebouleGameLineUpFollowUp>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableFollowUps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BasebouleGameIntroClosingStatement> availableIntroClosingStatements
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableIntroClosingStatements);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BasebouleGameIntroClosingStatement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableIntroClosingStatements)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BasebouleGameAdvert> availableAdverts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableAdverts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BasebouleGameAdvert>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableAdverts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe BasebouleTeam homeTeam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homeTeam);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BasebouleTeam>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_homeTeam)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)basebouleTeam));
		}
	}

	public unsafe BasebouleTeam awayTeam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awayTeam);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BasebouleTeam>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awayTeam)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)basebouleTeam));
		}
	}

	public unsafe BasebouleGameData _basebouleGame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__basebouleGame);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BasebouleGameData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__basebouleGame)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)basebouleGameData));
		}
	}

	public unsafe int _introSelection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__introSelection);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__introSelection)) = num;
		}
	}

	public unsafe int _followUpSelection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__followUpSelection);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__followUpSelection)) = num;
		}
	}

	public unsafe int _closingSelection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__closingSelection);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__closingSelection)) = num;
		}
	}

	public unsafe int _homeTeamIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__homeTeamIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__homeTeamIndex)) = num;
		}
	}

	public unsafe int _awayTeamIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__awayTeamIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__awayTeamIndex)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> _homeRosterPlayerOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__homeRosterPlayerOrder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__homeRosterPlayerOrder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> _awayRosterPlayerOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__awayRosterPlayerOrder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__awayRosterPlayerOrder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int _adsPlayed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__adsPlayed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__adsPlayed)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> _adOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__adOrder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__adOrder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static BasebouleSimulator()
	{
		Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BasebouleSimulator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr);
		NativeFieldInfoPtr_availableTeams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "availableTeams");
		NativeFieldInfoPtr_availableIntros = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "availableIntros");
		NativeFieldInfoPtr_availableFollowUps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "availableFollowUps");
		NativeFieldInfoPtr_availableIntroClosingStatements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "availableIntroClosingStatements");
		NativeFieldInfoPtr_availableAdverts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "availableAdverts");
		NativeFieldInfoPtr_homeTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "homeTeam");
		NativeFieldInfoPtr_awayTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "awayTeam");
		NativeFieldInfoPtr__basebouleGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "_basebouleGame");
		NativeFieldInfoPtr__introSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "_introSelection");
		NativeFieldInfoPtr__followUpSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "_followUpSelection");
		NativeFieldInfoPtr__closingSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "_closingSelection");
		NativeFieldInfoPtr__homeTeamIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "_homeTeamIndex");
		NativeFieldInfoPtr__awayTeamIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "_awayTeamIndex");
		NativeFieldInfoPtr__homeRosterPlayerOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "_homeRosterPlayerOrder");
		NativeFieldInfoPtr__awayRosterPlayerOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "_awayRosterPlayerOrder");
		NativeFieldInfoPtr__adsPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "_adsPlayed");
		NativeFieldInfoPtr__adOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, "_adOrder");
		NativeMethodInfoPtr_SimGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, 100673798);
		NativeMethodInfoPtr_RollIntroduction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, 100673799);
		NativeMethodInfoPtr_TryNextAd_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, 100673800);
		NativeMethodInfoPtr_RollTeams_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, 100673801);
		NativeMethodInfoPtr_RollPlayerOrder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, 100673802);
		NativeMethodInfoPtr_RollAdOrder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, 100673803);
		NativeMethodInfoPtr_GetShuffledIndexesOfList_Private_Il2CppStructArray_1_Int32_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, 100673804);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, 100673805);
		NativeMethodInfoPtr__RollTeams_b__20_0_Private_Boolean_BasebouleTeam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr, 100673806);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326731, XrefRangeEnd = 326810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SimGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SimGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326810, XrefRangeEnd = 326819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RollIntroduction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RollIntroduction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326819, XrefRangeEnd = 326826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryNextAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryNextAd_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 326849, RefRangeEnd = 326850, XrefRangeStart = 326826, XrefRangeEnd = 326849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RollTeams()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RollTeams_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326850, XrefRangeEnd = 326855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RollPlayerOrder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RollPlayerOrder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326855, XrefRangeEnd = 326858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RollAdOrder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RollAdOrder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 326863, RefRangeEnd = 326869, XrefRangeStart = 326858, XrefRangeEnd = 326863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> GetShuffledIndexesOfList<T>(List<T> listToShuffle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listToShuffle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetShuffledIndexesOfList_Private_Il2CppStructArray_1_Int32_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BasebouleSimulator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasebouleSimulator>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326869, XrefRangeEnd = 326876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _RollTeams_b__20_0(BasebouleTeam x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RollTeams_b__20_0_Private_Boolean_BasebouleTeam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public BasebouleSimulator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
