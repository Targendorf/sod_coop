using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class ParticleDecalPool : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_maxDecals;

	private static readonly IntPtr NativeFieldInfoPtr_decalSizeMin;

	private static readonly IntPtr NativeFieldInfoPtr_decalSizeMax;

	private static readonly IntPtr NativeFieldInfoPtr_decalParticleSystem;

	private static readonly IntPtr NativeFieldInfoPtr_particleDecalDataIndex;

	private static readonly IntPtr NativeFieldInfoPtr_particleData;

	private static readonly IntPtr NativeFieldInfoPtr_particles;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ParticleHit_Public_Void_ParticleCollisionEvent_Gradient_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetParticleData_Private_Void_ParticleCollisionEvent_Gradient_0;

	private static readonly IntPtr NativeMethodInfoPtr_DisplayParticles_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int maxDecals
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDecals);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDecals)) = num;
		}
	}

	public unsafe float decalSizeMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalSizeMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalSizeMin)) = num;
		}
	}

	public unsafe float decalSizeMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalSizeMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalSizeMax)) = num;
		}
	}

	public unsafe ParticleSystem decalParticleSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalParticleSystem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalParticleSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particleSystem));
		}
	}

	public unsafe int particleDecalDataIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleDecalDataIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleDecalDataIndex)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<ParticleDecalData> particleData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleDecalData>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<ParticleSystem.Particle> particles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particles);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ParticleSystem.Particle>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particles)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static ParticleDecalPool()
	{
		Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ParticleDecalPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr);
		NativeFieldInfoPtr_maxDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr, "maxDecals");
		NativeFieldInfoPtr_decalSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr, "decalSizeMin");
		NativeFieldInfoPtr_decalSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr, "decalSizeMax");
		NativeFieldInfoPtr_decalParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr, "decalParticleSystem");
		NativeFieldInfoPtr_particleDecalDataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr, "particleDecalDataIndex");
		NativeFieldInfoPtr_particleData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr, "particleData");
		NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr, "particles");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr, 100670176);
		NativeMethodInfoPtr_ParticleHit_Public_Void_ParticleCollisionEvent_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr, 100670177);
		NativeMethodInfoPtr_SetParticleData_Private_Void_ParticleCollisionEvent_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr, 100670178);
		NativeMethodInfoPtr_DisplayParticles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr, 100670179);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr, 100670180);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236341, XrefRangeEnd = 236354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236354, XrefRangeEnd = 236356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParticleHit(ParticleCollisionEvent particleCollisionEvent, Gradient colorGradient)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&particleCollisionEvent);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorGradient);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParticleHit_Public_Void_ParticleCollisionEvent_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 236372, RefRangeEnd = 236375, XrefRangeStart = 236356, XrefRangeEnd = 236372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetParticleData(ParticleCollisionEvent particleCollisionEvent, Gradient colorGradient)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&particleCollisionEvent);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)colorGradient);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParticleData_Private_Void_ParticleCollisionEvent_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 236391, RefRangeEnd = 236394, XrefRangeStart = 236375, XrefRangeEnd = 236391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayParticles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisplayParticles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236394, XrefRangeEnd = 236397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ParticleDecalPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleDecalPool>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ParticleDecalPool(IntPtr pointer)
		: base(pointer)
	{
	}
}
