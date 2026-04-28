using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class StairwellPreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_spawnObject;

	private static readonly IntPtr NativeFieldInfoPtr_objectTop;

	private static readonly IntPtr NativeFieldInfoPtr_centralSteps;

	private static readonly IntPtr NativeFieldInfoPtr_featuresElevator;

	private static readonly IntPtr NativeFieldInfoPtr_elevatorObject;

	private static readonly IntPtr NativeFieldInfoPtr_elevatorMaxSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_elevatorAcceleration;

	private static readonly IntPtr NativeFieldInfoPtr_accelerateWhileThisFarAway;

	private static readonly IntPtr NativeFieldInfoPtr_liftDelay;

	private static readonly IntPtr NativeFieldInfoPtr_movementDelay;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject spawnObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject objectTop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectTop);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectTop)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject centralSteps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centralSteps);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_centralSteps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe bool featuresElevator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featuresElevator);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_featuresElevator)) = flag;
		}
	}

	public unsafe GameObject elevatorObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe float elevatorMaxSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorMaxSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorMaxSpeed)) = num;
		}
	}

	public unsafe float elevatorAcceleration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorAcceleration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorAcceleration)) = num;
		}
	}

	public unsafe float accelerateWhileThisFarAway
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accelerateWhileThisFarAway);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accelerateWhileThisFarAway)) = num;
		}
	}

	public unsafe float liftDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liftDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_liftDelay)) = num;
		}
	}

	public unsafe float movementDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movementDelay)) = num;
		}
	}

	static StairwellPreset()
	{
		Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StairwellPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr);
		NativeFieldInfoPtr_spawnObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr, "spawnObject");
		NativeFieldInfoPtr_objectTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr, "objectTop");
		NativeFieldInfoPtr_centralSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr, "centralSteps");
		NativeFieldInfoPtr_featuresElevator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr, "featuresElevator");
		NativeFieldInfoPtr_elevatorObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr, "elevatorObject");
		NativeFieldInfoPtr_elevatorMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr, "elevatorMaxSpeed");
		NativeFieldInfoPtr_elevatorAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr, "elevatorAcceleration");
		NativeFieldInfoPtr_accelerateWhileThisFarAway = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr, "accelerateWhileThisFarAway");
		NativeFieldInfoPtr_liftDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr, "liftDelay");
		NativeFieldInfoPtr_movementDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr, "movementDelay");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr, 100674048);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330384, XrefRangeEnd = 330385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StairwellPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StairwellPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StairwellPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
