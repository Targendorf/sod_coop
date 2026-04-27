using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Rewired.Demos;

public class PressAnyButtonToJoinExample_Assigner : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_AssignJoysticksToPlayers_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_FindPlayerWithoutJoystick_Private_Player_0;

	private static readonly IntPtr NativeMethodInfoPtr_DoAllPlayersHaveJoysticks_Private_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static PressAnyButtonToJoinExample_Assigner()
	{
		Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "PressAnyButtonToJoinExample_Assigner");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr, 100676658);
		NativeMethodInfoPtr_AssignJoysticksToPlayers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr, 100676659);
		NativeMethodInfoPtr_FindPlayerWithoutJoystick_Private_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr, 100676660);
		NativeMethodInfoPtr_DoAllPlayersHaveJoysticks_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr, 100676661);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr, 100676662);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365779, XrefRangeEnd = 365787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 365819, RefRangeEnd = 365820, XrefRangeStart = 365787, XrefRangeEnd = 365819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AssignJoysticksToPlayers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssignJoysticksToPlayers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 365833, RefRangeEnd = 365836, XrefRangeStart = 365820, XrefRangeEnd = 365833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Player FindPlayerWithoutJoystick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindPlayerWithoutJoystick_Private_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Player>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365836, XrefRangeEnd = 365837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DoAllPlayersHaveJoysticks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoAllPlayersHaveJoysticks_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PressAnyButtonToJoinExample_Assigner()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PressAnyButtonToJoinExample_Assigner(IntPtr pointer)
		: base(pointer)
	{
	}
}
