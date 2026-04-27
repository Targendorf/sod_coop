using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class SideMissionHandInPreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_rewardModifier;

	private static readonly IntPtr NativeFieldInfoPtr_postersDoor;

	private static readonly IntPtr NativeFieldInfoPtr_cityHall;

	private static readonly IntPtr NativeFieldInfoPtr_blocks;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int rewardModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewardModifier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewardModifier)) = num;
		}
	}

	public unsafe bool postersDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postersDoor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postersDoor)) = flag;
		}
	}

	public unsafe bool cityHall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityHall);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cityHall)) = flag;
		}
	}

	public unsafe List<SideMissionIntroPreset.SideMissionObjectiveBlock> blocks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocks);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<SideMissionIntroPreset.SideMissionObjectiveBlock>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blocks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static SideMissionHandInPreset()
	{
		Il2CppClassPointerStore<SideMissionHandInPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SideMissionHandInPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SideMissionHandInPreset>.NativeClassPtr);
		NativeFieldInfoPtr_rewardModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionHandInPreset>.NativeClassPtr, "rewardModifier");
		NativeFieldInfoPtr_postersDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionHandInPreset>.NativeClassPtr, "postersDoor");
		NativeFieldInfoPtr_cityHall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionHandInPreset>.NativeClassPtr, "cityHall");
		NativeFieldInfoPtr_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideMissionHandInPreset>.NativeClassPtr, "blocks");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SideMissionHandInPreset>.NativeClassPtr, 100674037);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330199, XrefRangeEnd = 330207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SideMissionHandInPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SideMissionHandInPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SideMissionHandInPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
