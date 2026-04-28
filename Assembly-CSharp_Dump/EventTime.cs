using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

public class EventTime : Il2CppSystem.Object
{
	public enum RecallAccuracy
	{
		veryLow,
		low,
		med,
		high,
		veryHigh
	}

	public sealed class OnCalledUponTimeUpdate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static OnCalledUponTimeUpdate()
		{
			Il2CppClassPointerStore<OnCalledUponTimeUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "OnCalledUponTimeUpdate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCalledUponTimeUpdate>.NativeClassPtr, 100672179);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCalledUponTimeUpdate>.NativeClassPtr, 100672180);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCalledUponTimeUpdate>.NativeClassPtr, 100672181);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCalledUponTimeUpdate>.NativeClassPtr, 100672182);
		}

		[CallerCount(994)]
		[CachedScanResults(RefRangeStart = 10717, RefRangeEnd = 11711, XrefRangeStart = 10717, XrefRangeEnd = 11711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnCalledUponTimeUpdate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnCalledUponTimeUpdate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11711, RefRangeEnd = 11712, XrefRangeStart = 11711, XrefRangeEnd = 11712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public OnCalledUponTimeUpdate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnCalledUponTimeUpdate(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<OnCalledUponTimeUpdate>((System.Delegate)P_0);
		}

		public static OnCalledUponTimeUpdate operator +(OnCalledUponTimeUpdate P_0, OnCalledUponTimeUpdate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnCalledUponTimeUpdate>();
		}

		public static OnCalledUponTimeUpdate operator -(OnCalledUponTimeUpdate P_0, OnCalledUponTimeUpdate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnCalledUponTimeUpdate>();
			}
			return (OnCalledUponTimeUpdate)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_parentMemory;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcedAccuracy;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcedAccuracyToMinutes;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcedRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_forcedTimeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeMidPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_accurateString;

	private static readonly System.IntPtr NativeFieldInfoPtr_startString;

	private static readonly System.IntPtr NativeFieldInfoPtr_endString;

	private static readonly System.IntPtr NativeFieldInfoPtr_roundedTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_recallAccuracy;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnCalledUponTimeUpdated;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnCalledUponTimeUpdated_Public_add_Void_OnCalledUponTimeUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnCalledUponTimeUpdated_Public_rem_Void_OnCalledUponTimeUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimelineEvent_Boolean_Int32_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateTimings_Public_Void_0;

	public unsafe TimelineEvent parentMemory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentMemory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimelineEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentMemory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timelineEvent));
		}
	}

	public unsafe bool forcedAccuracy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedAccuracy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedAccuracy)) = flag;
		}
	}

	public unsafe int forcedAccuracyToMinutes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedAccuracyToMinutes);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedAccuracyToMinutes)) = num;
		}
	}

	public unsafe bool forcedRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedRange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedRange)) = flag;
		}
	}

	public unsafe Vector2 forcedTimeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedTimeRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forcedTimeRange)) = vector;
		}
	}

	public unsafe float timeStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStart);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStart)) = num;
		}
	}

	public unsafe float timeEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeEnd);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeEnd)) = num;
		}
	}

	public unsafe float timeMidPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeMidPoint);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeMidPoint)) = num;
		}
	}

	public unsafe Vector2 timeRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeRange)) = vector;
		}
	}

	public unsafe string accurateString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accurateString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_accurateString)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string startString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startString)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string endString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endString)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float roundedTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roundedTo);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roundedTo)) = num;
		}
	}

	public unsafe RecallAccuracy recallAccuracy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recallAccuracy);
			return *(RecallAccuracy*)num;
		}
		set
		{
			*(RecallAccuracy*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recallAccuracy)) = recallAccuracy;
		}
	}

	public unsafe OnCalledUponTimeUpdate OnCalledUponTimeUpdated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCalledUponTimeUpdated);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnCalledUponTimeUpdate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCalledUponTimeUpdated)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onCalledUponTimeUpdate));
		}
	}

	static EventTime()
	{
		Il2CppClassPointerStore<EventTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EventTime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventTime>.NativeClassPtr);
		NativeFieldInfoPtr_parentMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "parentMemory");
		NativeFieldInfoPtr_forcedAccuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "forcedAccuracy");
		NativeFieldInfoPtr_forcedAccuracyToMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "forcedAccuracyToMinutes");
		NativeFieldInfoPtr_forcedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "forcedRange");
		NativeFieldInfoPtr_forcedTimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "forcedTimeRange");
		NativeFieldInfoPtr_timeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "timeStart");
		NativeFieldInfoPtr_timeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "timeEnd");
		NativeFieldInfoPtr_timeMidPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "timeMidPoint");
		NativeFieldInfoPtr_timeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "timeRange");
		NativeFieldInfoPtr_accurateString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "accurateString");
		NativeFieldInfoPtr_startString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "startString");
		NativeFieldInfoPtr_endString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "endString");
		NativeFieldInfoPtr_roundedTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "roundedTo");
		NativeFieldInfoPtr_recallAccuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "recallAccuracy");
		NativeFieldInfoPtr_OnCalledUponTimeUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventTime>.NativeClassPtr, "OnCalledUponTimeUpdated");
		NativeMethodInfoPtr_add_OnCalledUponTimeUpdated_Public_add_Void_OnCalledUponTimeUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTime>.NativeClassPtr, 100672175);
		NativeMethodInfoPtr_remove_OnCalledUponTimeUpdated_Public_rem_Void_OnCalledUponTimeUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTime>.NativeClassPtr, 100672176);
		NativeMethodInfoPtr__ctor_Public_Void_TimelineEvent_Boolean_Int32_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTime>.NativeClassPtr, 100672177);
		NativeMethodInfoPtr_CalculateTimings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventTime>.NativeClassPtr, 100672178);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 288880, RefRangeEnd = 288882, XrefRangeStart = 288877, XrefRangeEnd = 288880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnCalledUponTimeUpdated(OnCalledUponTimeUpdate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnCalledUponTimeUpdated_Public_add_Void_OnCalledUponTimeUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288882, XrefRangeEnd = 288885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnCalledUponTimeUpdated(OnCalledUponTimeUpdate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnCalledUponTimeUpdated_Public_rem_Void_OnCalledUponTimeUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288903, RefRangeEnd = 288904, XrefRangeStart = 288885, XrefRangeEnd = 288903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EventTime(TimelineEvent newParent, bool forceAccuracy = false, int forceAccuracyToMinutes = 0, bool forceRange = false, float forcedFrom = 0f, float forcedTo = 0f)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventTime>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newParent);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceAccuracy;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceAccuracyToMinutes;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceRange;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedFrom;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &forcedTo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TimelineEvent_Boolean_Int32_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 288925, RefRangeEnd = 288926, XrefRangeStart = 288904, XrefRangeEnd = 288925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateTimings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateTimings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EventTime(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
