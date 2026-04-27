using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace DigitalRuby.LightningBolt;

public class LightningBoltScript : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_StartObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_StartPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_EndObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_EndPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_Generations;

	private static readonly System.IntPtr NativeFieldInfoPtr_Duration;

	private static readonly System.IntPtr NativeFieldInfoPtr_timer;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChaosFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ManualMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rows;

	private static readonly System.IntPtr NativeFieldInfoPtr_Columns;

	private static readonly System.IntPtr NativeFieldInfoPtr_AnimationMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_RandomGenerator;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineRenderer;

	private static readonly System.IntPtr NativeFieldInfoPtr_segments;

	private static readonly System.IntPtr NativeFieldInfoPtr_startIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_offsets;

	private static readonly System.IntPtr NativeFieldInfoPtr_animationOffsetIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_animationPingPongDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_orthographic;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPerpendicularVector_Private_Void_byref_Vector3_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateLightningBolt_Private_Void_Vector3_Vector3_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomVector_Public_Void_byref_Vector3_byref_Vector3_Single_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectOffsetFromAnimationMode_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLineRenderer_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Trigger_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFromMaterialChange_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject StartObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Vector3 StartPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartPosition)) = vector;
		}
	}

	public unsafe GameObject EndObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EndObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EndObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Vector3 EndPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EndPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EndPosition)) = vector;
		}
	}

	public unsafe int Generations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Generations);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Generations)) = num;
		}
	}

	public unsafe float Duration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Duration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Duration)) = num;
		}
	}

	public unsafe float timer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timer);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timer)) = num;
		}
	}

	public unsafe float ChaosFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChaosFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChaosFactor)) = num;
		}
	}

	public unsafe bool ManualMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ManualMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ManualMode)) = flag;
		}
	}

	public unsafe int Rows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rows);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rows)) = num;
		}
	}

	public unsafe int Columns
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Columns);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Columns)) = num;
		}
	}

	public unsafe LightningBoltAnimationMode AnimationMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationMode);
			return *(LightningBoltAnimationMode*)num;
		}
		set
		{
			*(LightningBoltAnimationMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnimationMode)) = lightningBoltAnimationMode;
		}
	}

	public unsafe Il2CppSystem.Random RandomGenerator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomGenerator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Random>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomGenerator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)random));
		}
	}

	public unsafe LineRenderer lineRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineRenderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lineRenderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lineRenderer));
		}
	}

	public unsafe List<KeyValuePair<Vector3, Vector3>> segments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_segments);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<KeyValuePair<Vector3, Vector3>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_segments)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int startIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startIndex)) = num;
		}
	}

	public unsafe Vector2 size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = vector;
		}
	}

	public unsafe Il2CppStructArray<Vector2> offsets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int animationOffsetIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationOffsetIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationOffsetIndex)) = num;
		}
	}

	public unsafe int animationPingPongDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationPingPongDirection);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animationPingPongDirection)) = num;
		}
	}

	public unsafe bool orthographic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orthographic);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orthographic)) = flag;
		}
	}

	static LightningBoltScript()
	{
		Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DigitalRuby.LightningBolt", "LightningBoltScript");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr);
		NativeFieldInfoPtr_StartObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "StartObject");
		NativeFieldInfoPtr_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "StartPosition");
		NativeFieldInfoPtr_EndObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "EndObject");
		NativeFieldInfoPtr_EndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "EndPosition");
		NativeFieldInfoPtr_Generations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "Generations");
		NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "Duration");
		NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "timer");
		NativeFieldInfoPtr_ChaosFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "ChaosFactor");
		NativeFieldInfoPtr_ManualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "ManualMode");
		NativeFieldInfoPtr_Rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "Rows");
		NativeFieldInfoPtr_Columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "Columns");
		NativeFieldInfoPtr_AnimationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "AnimationMode");
		NativeFieldInfoPtr_RandomGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "RandomGenerator");
		NativeFieldInfoPtr_lineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "lineRenderer");
		NativeFieldInfoPtr_segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "segments");
		NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "startIndex");
		NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "size");
		NativeFieldInfoPtr_offsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "offsets");
		NativeFieldInfoPtr_animationOffsetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "animationOffsetIndex");
		NativeFieldInfoPtr_animationPingPongDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "animationPingPongDirection");
		NativeFieldInfoPtr_orthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, "orthographic");
		NativeMethodInfoPtr_GetPerpendicularVector_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, 100677456);
		NativeMethodInfoPtr_GenerateLightningBolt_Private_Void_Vector3_Vector3_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, 100677457);
		NativeMethodInfoPtr_RandomVector_Public_Void_byref_Vector3_byref_Vector3_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, 100677458);
		NativeMethodInfoPtr_SelectOffsetFromAnimationMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, 100677459);
		NativeMethodInfoPtr_UpdateLineRenderer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, 100677460);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, 100677461);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, 100677462);
		NativeMethodInfoPtr_Trigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, 100677463);
		NativeMethodInfoPtr_UpdateFromMaterialChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, 100677464);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr, 100677465);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 380668, RefRangeEnd = 380669, XrefRangeStart = 380660, XrefRangeEnd = 380668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetPerpendicularVector(ref Vector3 directionNormalized, out Vector3 side)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref directionNormalized);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref side);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPerpendicularVector_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 380680, RefRangeEnd = 380681, XrefRangeStart = 380669, XrefRangeEnd = 380680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateLightningBolt(Vector3 start, Vector3 end, int generation, int totalGenerations, float offsetAmount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &generation;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &totalGenerations;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetAmount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateLightningBolt_Private_Void_Vector3_Vector3_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 380688, RefRangeEnd = 380689, XrefRangeStart = 380681, XrefRangeEnd = 380688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RandomVector(ref Vector3 start, ref Vector3 end, float offsetAmount, out Vector3 result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref start);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref end);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetAmount;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomVector_Public_Void_byref_Vector3_byref_Vector3_Single_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 380706, RefRangeEnd = 380707, XrefRangeStart = 380689, XrefRangeEnd = 380706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectOffsetFromAnimationMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectOffsetFromAnimationMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 380720, RefRangeEnd = 380721, XrefRangeStart = 380707, XrefRangeEnd = 380720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateLineRenderer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateLineRenderer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380721, XrefRangeEnd = 380754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380754, XrefRangeEnd = 380777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 380819, RefRangeEnd = 380820, XrefRangeStart = 380777, XrefRangeEnd = 380819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Trigger()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 380826, RefRangeEnd = 380827, XrefRangeStart = 380820, XrefRangeEnd = 380826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFromMaterialChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFromMaterialChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380827, XrefRangeEnd = 380846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LightningBoltScript()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningBoltScript>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LightningBoltScript(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
