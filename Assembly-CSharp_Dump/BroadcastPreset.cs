using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class BroadcastPreset : SoCustomComparison
{
	public enum ImageOrder
	{
		random,
		ordered
	}

	public enum EndOfShow
	{
		atEndOfAudioEvent,
		onEndOfDynamicClips
	}

	[System.Serializable]
	public class DynamicClip : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_chance;

		private static readonly System.IntPtr NativeFieldInfoPtr_possibleEvents;

		private static readonly System.IntPtr NativeFieldInfoPtr_followingDelay;

		private static readonly System.IntPtr NativeFieldInfoPtr_nextMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_nextIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_onFailToGetEvent;

		private static readonly System.IntPtr NativeFieldInfoPtr_onFailIndex;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe float chance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chance)) = num;
			}
		}

		public unsafe List<DynamicClipEvent> possibleEvents
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleEvents);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DynamicClipEvent>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_possibleEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe float followingDelay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followingDelay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_followingDelay)) = num;
			}
		}

		public unsafe FollowingIndexMode nextMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextMode);
				return *(FollowingIndexMode*)num;
			}
			set
			{
				*(FollowingIndexMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextMode)) = followingIndexMode;
			}
		}

		public unsafe int nextIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextIndex)) = num;
			}
		}

		public unsafe FollowingIndexMode onFailToGetEvent
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFailToGetEvent);
				return *(FollowingIndexMode*)num;
			}
			set
			{
				*(FollowingIndexMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFailToGetEvent)) = followingIndexMode;
			}
		}

		public unsafe int onFailIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFailIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFailIndex)) = num;
			}
		}

		static DynamicClip()
		{
			Il2CppClassPointerStore<DynamicClip>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "DynamicClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicClip>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClip>.NativeClassPtr, "name");
			NativeFieldInfoPtr_chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClip>.NativeClassPtr, "chance");
			NativeFieldInfoPtr_possibleEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClip>.NativeClassPtr, "possibleEvents");
			NativeFieldInfoPtr_followingDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClip>.NativeClassPtr, "followingDelay");
			NativeFieldInfoPtr_nextMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClip>.NativeClassPtr, "nextMode");
			NativeFieldInfoPtr_nextIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClip>.NativeClassPtr, "nextIndex");
			NativeFieldInfoPtr_onFailToGetEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClip>.NativeClassPtr, "onFailToGetEvent");
			NativeFieldInfoPtr_onFailIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClip>.NativeClassPtr, "onFailIndex");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicClip>.NativeClassPtr, 100673810);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326884, XrefRangeEnd = 326890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicClip()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicClip>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DynamicClip(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DynamicClipEvent : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_conditionMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_OrConditions;

		private static readonly System.IntPtr NativeFieldInfoPtr_audioEvents;

		private static readonly System.IntPtr NativeFieldInfoPtr_applyParameters;

		private static readonly System.IntPtr NativeFieldInfoPtr_overrideCrowdNoiseParam;

		private static readonly System.IntPtr NativeFieldInfoPtr_crowdLayerVolume;

		private static readonly System.IntPtr NativeFieldInfoPtr_triggerCrowdReaction;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe ConditionMode conditionMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditionMode);
				return *(ConditionMode*)num;
			}
			set
			{
				*(ConditionMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditionMode)) = conditionMode;
			}
		}

		public unsafe List<DynamicShowCondition> OrConditions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrConditions);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DynamicShowCondition>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OrConditions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<AudioEvent> audioEvents
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioEvents);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AudioEvent>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<DynamicShowParam> applyParameters
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyParameters);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DynamicShowParam>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applyParameters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool overrideCrowdNoiseParam
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideCrowdNoiseParam);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideCrowdNoiseParam)) = flag;
			}
		}

		public unsafe float crowdLayerVolume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crowdLayerVolume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crowdLayerVolume)) = num;
			}
		}

		public unsafe CrowdReaction triggerCrowdReaction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerCrowdReaction);
				return *(CrowdReaction*)num;
			}
			set
			{
				*(CrowdReaction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_triggerCrowdReaction)) = crowdReaction;
			}
		}

		static DynamicClipEvent()
		{
			Il2CppClassPointerStore<DynamicClipEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "DynamicClipEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicClipEvent>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClipEvent>.NativeClassPtr, "name");
			NativeFieldInfoPtr_conditionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClipEvent>.NativeClassPtr, "conditionMode");
			NativeFieldInfoPtr_OrConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClipEvent>.NativeClassPtr, "OrConditions");
			NativeFieldInfoPtr_audioEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClipEvent>.NativeClassPtr, "audioEvents");
			NativeFieldInfoPtr_applyParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClipEvent>.NativeClassPtr, "applyParameters");
			NativeFieldInfoPtr_overrideCrowdNoiseParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClipEvent>.NativeClassPtr, "overrideCrowdNoiseParam");
			NativeFieldInfoPtr_crowdLayerVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClipEvent>.NativeClassPtr, "crowdLayerVolume");
			NativeFieldInfoPtr_triggerCrowdReaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicClipEvent>.NativeClassPtr, "triggerCrowdReaction");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicClipEvent>.NativeClassPtr, 100673811);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326890, XrefRangeEnd = 326908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicClipEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicClipEvent>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DynamicClipEvent(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DynamicShowCondition : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_condition;

		private static readonly System.IntPtr NativeFieldInfoPtr_parametersList;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe DynamicConditionType condition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition);
				return *(DynamicConditionType*)num;
			}
			set
			{
				*(DynamicConditionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition)) = dynamicConditionType;
			}
		}

		public unsafe List<DynamicShowParam> parametersList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parametersList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DynamicShowParam>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parametersList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static DynamicShowCondition()
		{
			Il2CppClassPointerStore<DynamicShowCondition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "DynamicShowCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicShowCondition>.NativeClassPtr);
			NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicShowCondition>.NativeClassPtr, "condition");
			NativeFieldInfoPtr_parametersList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicShowCondition>.NativeClassPtr, "parametersList");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicShowCondition>.NativeClassPtr, 100673812);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326908, XrefRangeEnd = 326914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicShowCondition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicShowCondition>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DynamicShowCondition(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum DynamicConditionType
	{
		IfParamIsPresent,
		IfParamEquals,
		IfParamDoesntEqual,
		team1TakesLeadWithCurrentScore,
		team2TakesLeadWithCurrentScore,
		isDraw,
		team1Wins,
		team2Wins
	}

	[System.Serializable]
	public class DynamicShowParam : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_paramType;

		private static readonly System.IntPtr NativeFieldInfoPtr_applicationMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_value;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShowParamType_Single_0;

		public unsafe ShowParamType paramType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramType);
				return *(ShowParamType*)num;
			}
			set
			{
				*(ShowParamType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paramType)) = showParamType;
			}
		}

		public unsafe ParamApplicationMode applicationMode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applicationMode);
				return *(ParamApplicationMode*)num;
			}
			set
			{
				*(ParamApplicationMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_applicationMode)) = paramApplicationMode;
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

		static DynamicShowParam()
		{
			Il2CppClassPointerStore<DynamicShowParam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "DynamicShowParam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicShowParam>.NativeClassPtr);
			NativeFieldInfoPtr_paramType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicShowParam>.NativeClassPtr, "paramType");
			NativeFieldInfoPtr_applicationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicShowParam>.NativeClassPtr, "applicationMode");
			NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicShowParam>.NativeClassPtr, "value");
			NativeMethodInfoPtr__ctor_Public_Void_ShowParamType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicShowParam>.NativeClassPtr, 100673813);
		}

		[CallerCount(0)]
		public unsafe DynamicShowParam(ShowParamType newParameter, float newValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicShowParam>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&newParameter);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newValue;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ShowParamType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DynamicShowParam(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum ShowParamType
	{
		team1,
		team2,
		scoreTeam1,
		scoreTeam2,
		playersTeamOne1,
		playersTeamTwo1,
		playersTeamOne2,
		playersTeamTwo2,
		playersTeamOne3,
		playersTeamTwo3,
		playerNameInterjection,
		lastPlay,
		currentBalls,
		playersPlayed,
		currentScore,
		currentTeam,
		innings
	}

	public enum ConditionMode
	{
		OR,
		AND
	}

	public enum CrowdReaction
	{
		none,
		cheerSmall,
		cheerMedium,
		cheerLarge,
		boo,
		nearMiss
	}

	public enum ParamApplicationMode
	{
		set,
		add
	}

	public enum FollowingIndexMode
	{
		next,
		goToIndex
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_audioEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeImageEvery;

	private static readonly System.IntPtr NativeFieldInfoPtr_order;

	private static readonly System.IntPtr NativeFieldInfoPtr_endOfShowTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteSheet;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalSpriteCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_useDynamicClips;

	private static readonly System.IntPtr NativeFieldInfoPtr_dynamicClips;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe AudioEvent audioEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe float changeImageEvery
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeImageEvery);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeImageEvery)) = num;
		}
	}

	public unsafe ImageOrder order
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_order);
			return *(ImageOrder*)num;
		}
		set
		{
			*(ImageOrder*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_order)) = imageOrder;
		}
	}

	public unsafe EndOfShow endOfShowTrigger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endOfShowTrigger);
			return *(EndOfShow*)num;
		}
		set
		{
			*(EndOfShow*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endOfShowTrigger)) = endOfShow;
		}
	}

	public unsafe Texture2D spriteSheet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteSheet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteSheet)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Vector2 spriteResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteResolution);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spriteResolution)) = vector;
		}
	}

	public unsafe int indexWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexWidth)) = num;
		}
	}

	public unsafe int indexHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexHeight)) = num;
		}
	}

	public unsafe int totalSpriteCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalSpriteCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalSpriteCount)) = num;
		}
	}

	public unsafe bool useDynamicClips
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDynamicClips);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDynamicClips)) = flag;
		}
	}

	public unsafe List<DynamicClip> dynamicClips
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicClips);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DynamicClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicClips)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static BroadcastPreset()
	{
		Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BroadcastPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr);
		NativeFieldInfoPtr_audioEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "audioEvent");
		NativeFieldInfoPtr_changeImageEvery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "changeImageEvery");
		NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "order");
		NativeFieldInfoPtr_endOfShowTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "endOfShowTrigger");
		NativeFieldInfoPtr_spriteSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "spriteSheet");
		NativeFieldInfoPtr_spriteResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "spriteResolution");
		NativeFieldInfoPtr_indexWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "indexWidth");
		NativeFieldInfoPtr_indexHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "indexHeight");
		NativeFieldInfoPtr_totalSpriteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "totalSpriteCount");
		NativeFieldInfoPtr_useDynamicClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "useDynamicClips");
		NativeFieldInfoPtr_dynamicClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, "dynamicClips");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr, 100673809);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326914, XrefRangeEnd = 326922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BroadcastPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BroadcastPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BroadcastPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
