using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class DoorMovementPreset : SoCustomComparison
{
	public enum PhysicsBehaviour
	{
		ignore,
		physicsEnabled,
		stopDoorMovement
	}

	private static readonly IntPtr NativeFieldInfoPtr_closedRelativePos;

	private static readonly IntPtr NativeFieldInfoPtr_openRelativePos;

	private static readonly IntPtr NativeFieldInfoPtr_closedRelativeEuler;

	private static readonly IntPtr NativeFieldInfoPtr_openRelativeEuler;

	private static readonly IntPtr NativeFieldInfoPtr_closedRelativeScale;

	private static readonly IntPtr NativeFieldInfoPtr_openRelativeScale;

	private static readonly IntPtr NativeFieldInfoPtr_doorOpenSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_doorCloseSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_animationCurve;

	private static readonly IntPtr NativeFieldInfoPtr_collisionBehaviour;

	private static readonly IntPtr NativeFieldInfoPtr_behaviourAppliesWhenOpening;

	private static readonly IntPtr NativeFieldInfoPtr_behaviourAppliesWhenClosing;

	private static readonly IntPtr NativeFieldInfoPtr_openAction;

	private static readonly IntPtr NativeFieldInfoPtr_closeAction;

	private static readonly IntPtr NativeFieldInfoPtr_openFinished;

	private static readonly IntPtr NativeFieldInfoPtr_closeFinished;

	private static readonly IntPtr NativeFieldInfoPtr_objectImpact;

	private static readonly IntPtr NativeFieldInfoPtr_ignoreOcclusion;

	private static readonly IntPtr NativeFieldInfoPtr_switchState1AnimationSync;

	private static readonly IntPtr NativeFieldInfoPtr_useFixedUpdate;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector3 closedRelativePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closedRelativePos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closedRelativePos)) = vector;
		}
	}

	public unsafe Vector3 openRelativePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openRelativePos);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openRelativePos)) = vector;
		}
	}

	public unsafe Vector3 closedRelativeEuler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closedRelativeEuler);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closedRelativeEuler)) = vector;
		}
	}

	public unsafe Vector3 openRelativeEuler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openRelativeEuler);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openRelativeEuler)) = vector;
		}
	}

	public unsafe Vector3 closedRelativeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closedRelativeScale);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closedRelativeScale)) = vector;
		}
	}

	public unsafe Vector3 openRelativeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openRelativeScale);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openRelativeScale)) = vector;
		}
	}

	public unsafe float doorOpenSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorOpenSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorOpenSpeed)) = num;
		}
	}

	public unsafe float doorCloseSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorCloseSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorCloseSpeed)) = num;
		}
	}

	public unsafe AnimationCurve animationCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationCurve);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe PhysicsBehaviour collisionBehaviour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionBehaviour);
			return *(PhysicsBehaviour*)num;
		}
		set
		{
			*(PhysicsBehaviour*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionBehaviour)) = physicsBehaviour;
		}
	}

	public unsafe bool behaviourAppliesWhenOpening
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_behaviourAppliesWhenOpening);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_behaviourAppliesWhenOpening)) = flag;
		}
	}

	public unsafe bool behaviourAppliesWhenClosing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_behaviourAppliesWhenClosing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_behaviourAppliesWhenClosing)) = flag;
		}
	}

	public unsafe AudioEvent openAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openAction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent closeAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeAction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent openFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openFinished);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openFinished)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent closeFinished
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeFinished);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeFinished)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent objectImpact
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectImpact);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectImpact)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe bool ignoreOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreOcclusion)) = flag;
		}
	}

	public unsafe bool switchState1AnimationSync
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchState1AnimationSync);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_switchState1AnimationSync)) = flag;
		}
	}

	public unsafe bool useFixedUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFixedUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useFixedUpdate)) = flag;
		}
	}

	static DoorMovementPreset()
	{
		Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DoorMovementPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr);
		NativeFieldInfoPtr_closedRelativePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "closedRelativePos");
		NativeFieldInfoPtr_openRelativePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "openRelativePos");
		NativeFieldInfoPtr_closedRelativeEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "closedRelativeEuler");
		NativeFieldInfoPtr_openRelativeEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "openRelativeEuler");
		NativeFieldInfoPtr_closedRelativeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "closedRelativeScale");
		NativeFieldInfoPtr_openRelativeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "openRelativeScale");
		NativeFieldInfoPtr_doorOpenSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "doorOpenSpeed");
		NativeFieldInfoPtr_doorCloseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "doorCloseSpeed");
		NativeFieldInfoPtr_animationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "animationCurve");
		NativeFieldInfoPtr_collisionBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "collisionBehaviour");
		NativeFieldInfoPtr_behaviourAppliesWhenOpening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "behaviourAppliesWhenOpening");
		NativeFieldInfoPtr_behaviourAppliesWhenClosing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "behaviourAppliesWhenClosing");
		NativeFieldInfoPtr_openAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "openAction");
		NativeFieldInfoPtr_closeAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "closeAction");
		NativeFieldInfoPtr_openFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "openFinished");
		NativeFieldInfoPtr_closeFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "closeFinished");
		NativeFieldInfoPtr_objectImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "objectImpact");
		NativeFieldInfoPtr_ignoreOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "ignoreOcclusion");
		NativeFieldInfoPtr_switchState1AnimationSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "switchState1AnimationSync");
		NativeFieldInfoPtr_useFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, "useFixedUpdate");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr, 100673881);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328225, XrefRangeEnd = 328246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoorMovementPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorMovementPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DoorMovementPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
