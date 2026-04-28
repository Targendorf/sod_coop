using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class ParticleEffect : SoCustomComparison
{
	public enum SpatterTrigger
	{
		off,
		onBreak,
		onAnyImpact,
		whileInAirOrAnyImpact
	}

	private static readonly IntPtr NativeFieldInfoPtr_damageBreakPoint;

	private static readonly IntPtr NativeFieldInfoPtr_deleteObject;

	private static readonly IntPtr NativeFieldInfoPtr_effectPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_shatter;

	private static readonly IntPtr NativeFieldInfoPtr_shardSize;

	private static readonly IntPtr NativeFieldInfoPtr_shardEveryXPixels;

	private static readonly IntPtr NativeFieldInfoPtr_shatterForceMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_isGlass;

	private static readonly IntPtr NativeFieldInfoPtr_spatterTrigger;

	private static readonly IntPtr NativeFieldInfoPtr_spatter;

	private static readonly IntPtr NativeFieldInfoPtr_countMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_stickToActors;

	private static readonly IntPtr NativeFieldInfoPtr_spatterIsVandalism;

	private static readonly IntPtr NativeFieldInfoPtr_vandalismFine;

	private static readonly IntPtr NativeFieldInfoPtr_creationTrigger;

	private static readonly IntPtr NativeFieldInfoPtr_objectPool;

	private static readonly IntPtr NativeFieldInfoPtr_instances;

	private static readonly IntPtr NativeFieldInfoPtr_useRandomRotation;

	private static readonly IntPtr NativeFieldInfoPtr_localEuler;

	private static readonly IntPtr NativeFieldInfoPtr_impactEvents;

	private static readonly IntPtr NativeFieldInfoPtr_breakEvents;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float damageBreakPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageBreakPoint);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damageBreakPoint)) = num;
		}
	}

	public unsafe bool deleteObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deleteObject);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deleteObject)) = flag;
		}
	}

	public unsafe GameObject effectPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe bool shatter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shatter);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shatter)) = flag;
		}
	}

	public unsafe Vector3 shardSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shardSize);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shardSize)) = vector;
		}
	}

	public unsafe int shardEveryXPixels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shardEveryXPixels);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shardEveryXPixels)) = num;
		}
	}

	public unsafe float shatterForceMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shatterForceMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shatterForceMultiplier)) = num;
		}
	}

	public unsafe bool isGlass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGlass);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGlass)) = flag;
		}
	}

	public unsafe SpatterTrigger spatterTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterTrigger);
			return *(SpatterTrigger*)num;
		}
		set
		{
			*(SpatterTrigger*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterTrigger)) = spatterTrigger;
		}
	}

	public unsafe SpatterPatternPreset spatter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatter);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpatterPatternPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spatterPatternPreset));
		}
	}

	public unsafe float countMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countMultiplier)) = num;
		}
	}

	public unsafe bool stickToActors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stickToActors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stickToActors)) = flag;
		}
	}

	public unsafe bool spatterIsVandalism
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterIsVandalism);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spatterIsVandalism)) = flag;
		}
	}

	public unsafe int vandalismFine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vandalismFine);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vandalismFine)) = num;
		}
	}

	public unsafe SpatterTrigger creationTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creationTrigger);
			return *(SpatterTrigger*)num;
		}
		set
		{
			*(SpatterTrigger*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creationTrigger)) = spatterTrigger;
		}
	}

	public unsafe List<GameObject> objectPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectPool);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_objectPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int instances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances)) = num;
		}
	}

	public unsafe bool useRandomRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRandomRotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useRandomRotation)) = flag;
		}
	}

	public unsafe Vector3 localEuler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localEuler);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localEuler)) = vector;
		}
	}

	public unsafe List<AudioEvent> impactEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactEvents);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<AudioEvent>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_impactEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AudioEvent> breakEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakEvents);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<AudioEvent>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breakEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ParticleEffect()
	{
		Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ParticleEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr);
		NativeFieldInfoPtr_damageBreakPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "damageBreakPoint");
		NativeFieldInfoPtr_deleteObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "deleteObject");
		NativeFieldInfoPtr_effectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "effectPrefab");
		NativeFieldInfoPtr_shatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "shatter");
		NativeFieldInfoPtr_shardSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "shardSize");
		NativeFieldInfoPtr_shardEveryXPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "shardEveryXPixels");
		NativeFieldInfoPtr_shatterForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "shatterForceMultiplier");
		NativeFieldInfoPtr_isGlass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "isGlass");
		NativeFieldInfoPtr_spatterTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "spatterTrigger");
		NativeFieldInfoPtr_spatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "spatter");
		NativeFieldInfoPtr_countMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "countMultiplier");
		NativeFieldInfoPtr_stickToActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "stickToActors");
		NativeFieldInfoPtr_spatterIsVandalism = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "spatterIsVandalism");
		NativeFieldInfoPtr_vandalismFine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "vandalismFine");
		NativeFieldInfoPtr_creationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "creationTrigger");
		NativeFieldInfoPtr_objectPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "objectPool");
		NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "instances");
		NativeFieldInfoPtr_useRandomRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "useRandomRotation");
		NativeFieldInfoPtr_localEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "localEuler");
		NativeFieldInfoPtr_impactEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "impactEvents");
		NativeFieldInfoPtr_breakEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, "breakEvents");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr, 100674005);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329842, XrefRangeEnd = 329862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ParticleEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleEffect>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ParticleEffect(IntPtr pointer)
		: base(pointer)
	{
	}
}
