using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class UpgradeEffectController : MonoBehaviour
{
	[System.Serializable]
	public class AppliedEffect : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_disk;

		private static readonly System.IntPtr NativeFieldInfoPtr_effect;

		private static readonly System.IntPtr NativeFieldInfoPtr_value;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe UpgradesController.Upgrades disk
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disk);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UpgradesController.Upgrades>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disk)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)upgrades));
			}
		}

		public unsafe SyncDiskPreset.Effect effect
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effect);
				return *(SyncDiskPreset.Effect*)num;
			}
			set
			{
				*(SyncDiskPreset.Effect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effect)) = effect;
			}
		}

		public unsafe float value
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_value)) = num;
			}
		}

		static AppliedEffect()
		{
			Il2CppClassPointerStore<AppliedEffect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr, "AppliedEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppliedEffect>.NativeClassPtr);
			NativeFieldInfoPtr_disk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppliedEffect>.NativeClassPtr, "disk");
			NativeFieldInfoPtr_effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppliedEffect>.NativeClassPtr, "effect");
			NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppliedEffect>.NativeClassPtr, "value");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppliedEffect>.NativeClassPtr, 100672894);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppliedEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppliedEffect>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AppliedEffect(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_appliedEffects;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInstall_Public_Void_Upgrades_Effect_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUninstall_Public_Void_Upgrades_Effect_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpgrade_Public_Void_Upgrades_UpgradeEffect_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSyncDiskChange_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_UpgradeEffectController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUpgradeEffect_Public_Single_Effect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<AppliedEffect> appliedEffects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedEffects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AppliedEffect>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appliedEffects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static UpgradeEffectController _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UpgradeEffectController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)upgradeEffectController));
		}
	}

	public unsafe static UpgradeEffectController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307749, XrefRangeEnd = 307751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_UpgradeEffectController_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UpgradeEffectController>(intPtr) : null;
		}
	}

	static UpgradeEffectController()
	{
		Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UpgradeEffectController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr);
		NativeFieldInfoPtr_appliedEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr, "appliedEffects");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_OnInstall_Public_Void_Upgrades_Effect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr, 100672886);
		NativeMethodInfoPtr_OnUninstall_Public_Void_Upgrades_Effect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr, 100672887);
		NativeMethodInfoPtr_OnUpgrade_Public_Void_Upgrades_UpgradeEffect_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr, 100672888);
		NativeMethodInfoPtr_OnSyncDiskChange_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr, 100672889);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_UpgradeEffectController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr, 100672890);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr, 100672891);
		NativeMethodInfoPtr_GetUpgradeEffect_Public_Single_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr, 100672892);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr, 100672893);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307693, XrefRangeEnd = 307699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInstall(UpgradesController.Upgrades disk, SyncDiskPreset.Effect effect, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)disk);
		*(SyncDiskPreset.Effect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &effect;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnInstall_Public_Void_Upgrades_Effect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUninstall(UpgradesController.Upgrades disk, SyncDiskPreset.Effect effect, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)disk);
		*(SyncDiskPreset.Effect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &effect;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUninstall_Public_Void_Upgrades_Effect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307699, XrefRangeEnd = 307700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpgrade(UpgradesController.Upgrades disk, SyncDiskPreset.UpgradeEffect effect, float value, int level)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)disk);
		*(SyncDiskPreset.UpgradeEffect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &effect;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpgrade_Public_Void_Upgrades_UpgradeEffect_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 307746, RefRangeEnd = 307749, XrefRangeStart = 307700, XrefRangeEnd = 307746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSyncDiskChange(bool forceUpdate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceUpdate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSyncDiskChange_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307751, XrefRangeEnd = 307788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(90)]
	[CachedScanResults(RefRangeStart = 307795, RefRangeEnd = 307885, XrefRangeStart = 307788, XrefRangeEnd = 307795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetUpgradeEffect(SyncDiskPreset.Effect effect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&effect);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUpgradeEffect_Public_Single_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307885, XrefRangeEnd = 307894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UpgradeEffectController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpgradeEffectController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public UpgradeEffectController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
