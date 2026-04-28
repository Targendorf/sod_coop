using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class PhysicsProfile : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_mass;

	private static readonly IntPtr NativeFieldInfoPtr_drag;

	private static readonly IntPtr NativeFieldInfoPtr_angularDrag;

	private static readonly IntPtr NativeFieldInfoPtr_heldEuler;

	private static readonly IntPtr NativeFieldInfoPtr_tamperDistanceModifier;

	private static readonly IntPtr NativeFieldInfoPtr_throwForceMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_throwDamageMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_treatAsCausedByPlayer;

	private static readonly IntPtr NativeFieldInfoPtr_collisionMode;

	private static readonly IntPtr NativeFieldInfoPtr_removeOnReset;

	private static readonly IntPtr NativeFieldInfoPtr_physicsCollisionAudio;

	private static readonly IntPtr NativeFieldInfoPtr_useDifferentSoundForWallImpacts;

	private static readonly IntPtr NativeFieldInfoPtr_wallCollisionAudio;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float mass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mass);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mass)) = num;
		}
	}

	public unsafe float drag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drag);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drag)) = num;
		}
	}

	public unsafe float angularDrag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularDrag);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angularDrag)) = num;
		}
	}

	public unsafe Vector3 heldEuler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heldEuler);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heldEuler)) = vector;
		}
	}

	public unsafe float tamperDistanceModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperDistanceModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tamperDistanceModifier)) = num;
		}
	}

	public unsafe float throwForceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwForceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwForceMultiplier)) = num;
		}
	}

	public unsafe float throwDamageMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwDamageMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_throwDamageMultiplier)) = num;
		}
	}

	public unsafe bool treatAsCausedByPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treatAsCausedByPlayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_treatAsCausedByPlayer)) = flag;
		}
	}

	public unsafe CollisionDetectionMode collisionMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionMode);
			return *(CollisionDetectionMode*)num;
		}
		set
		{
			*(CollisionDetectionMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collisionMode)) = collisionDetectionMode;
		}
	}

	public unsafe bool removeOnReset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeOnReset);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeOnReset)) = flag;
		}
	}

	public unsafe AudioEvent physicsCollisionAudio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsCollisionAudio);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_physicsCollisionAudio)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe bool useDifferentSoundForWallImpacts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDifferentSoundForWallImpacts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDifferentSoundForWallImpacts)) = flag;
		}
	}

	public unsafe AudioEvent wallCollisionAudio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallCollisionAudio);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallCollisionAudio)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	static PhysicsProfile()
	{
		Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PhysicsProfile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr);
		NativeFieldInfoPtr_mass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, "mass");
		NativeFieldInfoPtr_drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, "drag");
		NativeFieldInfoPtr_angularDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, "angularDrag");
		NativeFieldInfoPtr_heldEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, "heldEuler");
		NativeFieldInfoPtr_tamperDistanceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, "tamperDistanceModifier");
		NativeFieldInfoPtr_throwForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, "throwForceMultiplier");
		NativeFieldInfoPtr_throwDamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, "throwDamageMultiplier");
		NativeFieldInfoPtr_treatAsCausedByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, "treatAsCausedByPlayer");
		NativeFieldInfoPtr_collisionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, "collisionMode");
		NativeFieldInfoPtr_removeOnReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, "removeOnReset");
		NativeFieldInfoPtr_physicsCollisionAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, "physicsCollisionAudio");
		NativeFieldInfoPtr_useDifferentSoundForWallImpacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, "useDifferentSoundForWallImpacts");
		NativeFieldInfoPtr_wallCollisionAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, "wallCollisionAudio");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr, 100674006);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329862, XrefRangeEnd = 329863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PhysicsProfile()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsProfile>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PhysicsProfile(IntPtr pointer)
		: base(pointer)
	{
	}
}
