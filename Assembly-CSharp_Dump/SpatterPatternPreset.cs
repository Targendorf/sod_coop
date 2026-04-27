using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class SpatterPatternPreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_spatterCount;

	private static readonly IntPtr NativeFieldInfoPtr_maxAngleX;

	private static readonly IntPtr NativeFieldInfoPtr_maxAngleY;

	private static readonly IntPtr NativeFieldInfoPtr_rayLength;

	private static readonly IntPtr NativeFieldInfoPtr_spreadCurve;

	private static readonly IntPtr NativeFieldInfoPtr_heavyMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_mediumMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_lightMaterial;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int spatterCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterCount)) = num;
		}
	}

	public unsafe float maxAngleX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAngleX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAngleX)) = num;
		}
	}

	public unsafe float maxAngleY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAngleY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxAngleY)) = num;
		}
	}

	public unsafe Vector2 rayLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayLength);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayLength)) = vector;
		}
	}

	public unsafe AnimationCurve spreadCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spreadCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spreadCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe Material heavyMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heavyMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heavyMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material mediumMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mediumMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material lightMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	static SpatterPatternPreset()
	{
		Il2CppClassPointerStore<SpatterPatternPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SpatterPatternPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpatterPatternPreset>.NativeClassPtr);
		NativeFieldInfoPtr_spatterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterPatternPreset>.NativeClassPtr, "spatterCount");
		NativeFieldInfoPtr_maxAngleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterPatternPreset>.NativeClassPtr, "maxAngleX");
		NativeFieldInfoPtr_maxAngleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterPatternPreset>.NativeClassPtr, "maxAngleY");
		NativeFieldInfoPtr_rayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterPatternPreset>.NativeClassPtr, "rayLength");
		NativeFieldInfoPtr_spreadCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterPatternPreset>.NativeClassPtr, "spreadCurve");
		NativeFieldInfoPtr_heavyMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterPatternPreset>.NativeClassPtr, "heavyMaterial");
		NativeFieldInfoPtr_mediumMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterPatternPreset>.NativeClassPtr, "mediumMaterial");
		NativeFieldInfoPtr_lightMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpatterPatternPreset>.NativeClassPtr, "lightMaterial");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpatterPatternPreset>.NativeClassPtr, 100674047);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330383, XrefRangeEnd = 330384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpatterPatternPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpatterPatternPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SpatterPatternPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
