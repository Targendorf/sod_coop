using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class SceneRecorder : Il2CppSystem.Object
{
	public sealed class OnCapture : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static OnCapture()
		{
			Il2CppClassPointerStore<OnCapture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "OnCapture");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCapture>.NativeClassPtr, 100670100);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCapture>.NativeClassPtr, 100670101);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCapture>.NativeClassPtr, 100670102);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnCapture>.NativeClassPtr, 100670103);
		}

		[CallerCount(994)]
		[CachedScanResults(RefRangeStart = 10717, RefRangeEnd = 11711, XrefRangeStart = 10717, XrefRangeEnd = 11711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnCapture(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnCapture>.NativeClassPtr))
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

		public OnCapture(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator OnCapture(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<OnCapture>((System.Delegate)P_0);
		}

		public static OnCapture operator +(OnCapture P_0, OnCapture P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<OnCapture>();
		}

		public static OnCapture operator -(OnCapture P_0, OnCapture P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<OnCapture>();
			}
			return (OnCapture)obj;
		}
	}

	[System.Serializable]
	public class SceneCapture : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_recorder;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_drp;

		private static readonly System.IntPtr NativeFieldInfoPtr_t;

		private static readonly System.IntPtr NativeFieldInfoPtr_k;

		private static readonly System.IntPtr NativeFieldInfoPtr_l;

		private static readonly System.IntPtr NativeFieldInfoPtr_a;

		private static readonly System.IntPtr NativeFieldInfoPtr_rCap;

		private static readonly System.IntPtr NativeFieldInfoPtr_dCap;

		private static readonly System.IntPtr NativeFieldInfoPtr_aCap;

		private static readonly System.IntPtr NativeFieldInfoPtr_oCap;

		private static readonly System.IntPtr NativeFieldInfoPtr_oSCap;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SceneRecorder_Boolean_Boolean_Boolean_Boolean_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SceneCapture_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetCaptureGamelocation_Public_NewGameLocation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetCaptureRoom_Public_NewRoom_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDecimalClock_Public_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetCaptureWorldPosition_Public_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetCaptureWorldRotation_Public_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetUniqueIDForInstance_Public_String_0;

		public unsafe SceneRecorder recorder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recorder);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SceneRecorder>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_recorder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sceneRecorder));
			}
		}

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe List<DynamicRecordPosition> drp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drp);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DynamicRecordPosition>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe float t
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t)) = num;
			}
		}

		public unsafe bool k
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k)) = flag;
			}
		}

		public unsafe int l
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_l);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_l)) = num;
			}
		}

		public unsafe int a
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a)) = num;
			}
		}

		public unsafe List<RoomCapture> rCap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rCap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoomCapture>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rCap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<DoorCapture> dCap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dCap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DoorCapture>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dCap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<ActorCapture> aCap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aCap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ActorCapture>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aCap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<InteractableCapture> oCap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oCap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractableCapture>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oCap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe List<InteractableStateCapture> oSCap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oSCap);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractableStateCapture>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oSCap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static SceneCapture()
		{
			Il2CppClassPointerStore<SceneCapture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "SceneCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr);
			NativeFieldInfoPtr_recorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "recorder");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "id");
			NativeFieldInfoPtr_drp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "drp");
			NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "t");
			NativeFieldInfoPtr_k = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "k");
			NativeFieldInfoPtr_l = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "l");
			NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "a");
			NativeFieldInfoPtr_rCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "rCap");
			NativeFieldInfoPtr_dCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "dCap");
			NativeFieldInfoPtr_aCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "aCap");
			NativeFieldInfoPtr_oCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "oCap");
			NativeFieldInfoPtr_oSCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, "oSCap");
			NativeMethodInfoPtr__ctor_Public_Void_SceneRecorder_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670104);
			NativeMethodInfoPtr__ctor_Public_Void_SceneCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670105);
			NativeMethodInfoPtr_GetCaptureGamelocation_Public_NewGameLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670106);
			NativeMethodInfoPtr_GetCaptureRoom_Public_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670107);
			NativeMethodInfoPtr_GetDecimalClock_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670108);
			NativeMethodInfoPtr_GetCaptureWorldPosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670109);
			NativeMethodInfoPtr_GetCaptureWorldRotation_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670110);
			NativeMethodInfoPtr_GetUniqueIDForInstance_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr, 100670111);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233722, XrefRangeEnd = 234076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneCapture(SceneRecorder newRecorder, bool detailedCapture, bool flashLightActive = false, bool flashActive = false, bool includePlayerModel = true, bool cctvCapture = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRecorder);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &detailedCapture;
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flashLightActive;
			*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flashActive;
			*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &includePlayerModel;
			*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &cctvCapture;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SceneRecorder_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234076, XrefRangeEnd = 234136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneCapture(SceneCapture copyFrom)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneCapture>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyFrom);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SceneCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 234140, RefRangeEnd = 234145, XrefRangeStart = 234136, XrefRangeEnd = 234140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewGameLocation GetCaptureGamelocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCaptureGamelocation_Public_NewGameLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewGameLocation>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234145, XrefRangeEnd = 234149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewRoom GetCaptureRoom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCaptureRoom_Public_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234161, RefRangeEnd = 234162, XrefRangeStart = 234149, XrefRangeEnd = 234161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDecimalClock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDecimalClock_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 234165, RefRangeEnd = 234169, XrefRangeStart = 234162, XrefRangeEnd = 234165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetCaptureWorldPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCaptureWorldPosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234169, XrefRangeEnd = 234171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetCaptureWorldRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCaptureWorldRotation_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234171, XrefRangeEnd = 234172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUniqueIDForInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUniqueIDForInstance_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		public SceneCapture(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DynamicRecordPosition : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pos;

		private static readonly System.IntPtr NativeFieldInfoPtr_rot;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Vector3 pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector;
			}
		}

		public unsafe Vector3 rot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rot);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rot)) = vector;
			}
		}

		static DynamicRecordPosition()
		{
			Il2CppClassPointerStore<DynamicRecordPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "DynamicRecordPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicRecordPosition>.NativeClassPtr);
			NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicRecordPosition>.NativeClassPtr, "pos");
			NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicRecordPosition>.NativeClassPtr, "rot");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicRecordPosition>.NativeClassPtr, 100670112);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicRecordPosition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicRecordPosition>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public DynamicRecordPosition(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class RoomCapture : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_light;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetRoom_Public_NewRoom_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe bool light
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_light);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_light)) = flag;
			}
		}

		static RoomCapture()
		{
			Il2CppClassPointerStore<RoomCapture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "RoomCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomCapture>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCapture>.NativeClassPtr, "id");
			NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomCapture>.NativeClassPtr, "light");
			NativeMethodInfoPtr_GetRoom_Public_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomCapture>.NativeClassPtr, 100670113);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomCapture>.NativeClassPtr, 100670114);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234177, RefRangeEnd = 234179, XrefRangeStart = 234172, XrefRangeEnd = 234177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewRoom GetRoom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRoom_Public_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoomCapture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoomCapture>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public RoomCapture(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class TransformCapture : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_wP;

		private static readonly System.IntPtr NativeFieldInfoPtr_wR;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_0;

		public unsafe Vector3 wP
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wP);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wP)) = vector;
			}
		}

		public unsafe Quaternion wR
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wR);
				return *(Quaternion*)num;
			}
			set
			{
				*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wR)) = quaternion;
			}
		}

		static TransformCapture()
		{
			Il2CppClassPointerStore<TransformCapture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "TransformCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformCapture>.NativeClassPtr);
			NativeFieldInfoPtr_wP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformCapture>.NativeClassPtr, "wP");
			NativeFieldInfoPtr_wR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformCapture>.NativeClassPtr, "wR");
			NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformCapture>.NativeClassPtr, 100670115);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 234186, RefRangeEnd = 234192, XrefRangeStart = 234179, XrefRangeEnd = 234186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformCapture(Vector3 pos, Quaternion rot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformCapture>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&pos);
			*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rot;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public TransformCapture(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class DoorCapture : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_a;

		private static readonly System.IntPtr NativeFieldInfoPtr_t;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NewDoor_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetDoor_Public_NewDoor_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsOpen_Public_Boolean_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe int a
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a)) = num;
			}
		}

		public unsafe bool t
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t)) = flag;
			}
		}

		static DoorCapture()
		{
			Il2CppClassPointerStore<DoorCapture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "DoorCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorCapture>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorCapture>.NativeClassPtr, "id");
			NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorCapture>.NativeClassPtr, "a");
			NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorCapture>.NativeClassPtr, "t");
			NativeMethodInfoPtr__ctor_Public_Void_NewDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorCapture>.NativeClassPtr, 100670116);
			NativeMethodInfoPtr_GetDoor_Public_NewDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorCapture>.NativeClassPtr, 100670117);
			NativeMethodInfoPtr_IsOpen_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorCapture>.NativeClassPtr, 100670118);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234193, RefRangeEnd = 234195, XrefRangeStart = 234192, XrefRangeEnd = 234193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorCapture(NewDoor door)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorCapture>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)door);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NewDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234200, RefRangeEnd = 234202, XrefRangeStart = 234195, XrefRangeEnd = 234200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewDoor GetDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDoor_Public_NewDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewDoor>(intPtr) : null;
		}

		[CallerCount(0)]
		public unsafe bool IsOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOpen_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public DoorCapture(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class InteractableCapture : TransformCapture
	{
		[System.Serializable]
		[ObfuscatedName("SceneRecorder+InteractableCapture+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__3_0_Internal_Boolean_Passed_0;

			public unsafe static __c __9
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
				}
			}

			public unsafe static Il2CppSystem.Predicate<Interactable.Passed> __9__3_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable.Passed>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__3_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractableCapture>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__3_0");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670124);
				NativeMethodInfoPtr___ctor_b__3_0_Internal_Boolean_Passed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670125);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			public unsafe bool __ctor_b__3_0(Interactable.Passed item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__3_0_Internal_Boolean_Passed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("SceneRecorder+InteractableCapture+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_pr;

			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_FurnitureLocation_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__1_Internal_Boolean_ArtPreset_0;

			public unsafe InteractablePreset pr
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pr);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactablePreset));
				}
			}

			public unsafe InteractableCapture __4__this
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractableCapture>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactableCapture));
				}
			}

			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractableCapture>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr);
				NativeFieldInfoPtr_pr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, "pr");
				NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100670126);
				NativeMethodInfoPtr__Load_b__0_Internal_Boolean_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100670127);
				NativeMethodInfoPtr__Load_b__1_Internal_Boolean_ArtPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr, 100670128);
			}

			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass5_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			public unsafe bool _Load_b__0(FurnitureLocation item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Load_b__0_Internal_Boolean_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234202, XrefRangeEnd = 234205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__1(ArtPreset item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Load_b__1_Internal_Boolean_ArtPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c__DisplayClass5_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_p;

		private static readonly System.IntPtr NativeFieldInfoPtr_d;

		private static readonly System.IntPtr NativeFieldInfoPtr_poser;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Interactable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPreset_Public_InteractablePreset_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Unload_Public_Void_0;

		public unsafe string p
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe List<string> d
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe GameObject poser
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poser);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poser)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		static InteractableCapture()
		{
			Il2CppClassPointerStore<InteractableCapture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "InteractableCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableCapture>.NativeClassPtr);
			NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableCapture>.NativeClassPtr, "p");
			NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableCapture>.NativeClassPtr, "d");
			NativeFieldInfoPtr_poser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableCapture>.NativeClassPtr, "poser");
			NativeMethodInfoPtr__ctor_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCapture>.NativeClassPtr, 100670119);
			NativeMethodInfoPtr_GetPreset_Public_InteractablePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCapture>.NativeClassPtr, 100670120);
			NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCapture>.NativeClassPtr, 100670121);
			NativeMethodInfoPtr_Unload_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableCapture>.NativeClassPtr, 100670122);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234290, RefRangeEnd = 234291, XrefRangeStart = 234205, XrefRangeEnd = 234290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractableCapture(Interactable newInter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableCapture>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newInter);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234291, XrefRangeEnd = 234295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractablePreset GetPreset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreset_Public_InteractablePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractablePreset>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234513, RefRangeEnd = 234514, XrefRangeStart = 234295, XrefRangeEnd = 234513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234553, RefRangeEnd = 234554, XrefRangeStart = 234514, XrefRangeEnd = 234553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unload_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public InteractableCapture(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class InteractableStateCapture : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_sw;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Interactable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetInteractable_Public_Interactable_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe bool sw
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sw);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sw)) = flag;
			}
		}

		static InteractableStateCapture()
		{
			Il2CppClassPointerStore<InteractableStateCapture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "InteractableStateCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableStateCapture>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableStateCapture>.NativeClassPtr, "id");
			NativeFieldInfoPtr_sw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableStateCapture>.NativeClassPtr, "sw");
			NativeMethodInfoPtr__ctor_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableStateCapture>.NativeClassPtr, 100670129);
			NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableStateCapture>.NativeClassPtr, 100670130);
			NativeMethodInfoPtr_GetInteractable_Public_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableStateCapture>.NativeClassPtr, 100670131);
		}

		[CallerCount(0)]
		public unsafe InteractableStateCapture(Interactable i)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableStateCapture>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)i);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234554, XrefRangeEnd = 234571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 234576, RefRangeEnd = 234579, XrefRangeStart = 234571, XrefRangeEnd = 234576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Interactable GetInteractable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInteractable_Public_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
		}

		public InteractableStateCapture(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class ActorCapture : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_o;

		private static readonly System.IntPtr NativeFieldInfoPtr_pos;

		private static readonly System.IntPtr NativeFieldInfoPtr_rot;

		private static readonly System.IntPtr NativeFieldInfoPtr_main;

		private static readonly System.IntPtr NativeFieldInfoPtr_arms;

		private static readonly System.IntPtr NativeFieldInfoPtr_sp;

		private static readonly System.IntPtr NativeFieldInfoPtr_limb;

		private static readonly System.IntPtr NativeFieldInfoPtr_lH;

		private static readonly System.IntPtr NativeFieldInfoPtr_rH;

		private static readonly System.IntPtr NativeFieldInfoPtr_poser;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Human_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHuman_Public_Human_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Unload_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__13_0_Private_Boolean_ScenePoserController_0;

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe int o
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_o);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_o)) = num;
			}
		}

		public unsafe Vector3 pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector;
			}
		}

		public unsafe Vector3 rot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rot);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rot)) = vector;
			}
		}

		public unsafe int main
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_main);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_main)) = num;
			}
		}

		public unsafe int arms
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arms);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arms)) = num;
			}
		}

		public unsafe int sp
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sp);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sp)) = num;
			}
		}

		public unsafe List<LimbCapture> limb
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limb);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LimbCapture>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limb)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe HandItemCapture lH
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lH);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HandItemCapture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lH)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handItemCapture));
			}
		}

		public unsafe HandItemCapture rH
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rH);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HandItemCapture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rH)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handItemCapture));
			}
		}

		public unsafe ScenePoserController poser
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poser);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScenePoserController>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poser)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scenePoserController));
			}
		}

		static ActorCapture()
		{
			Il2CppClassPointerStore<ActorCapture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "ActorCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr);
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, "id");
			NativeFieldInfoPtr_o = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, "o");
			NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, "pos");
			NativeFieldInfoPtr_rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, "rot");
			NativeFieldInfoPtr_main = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, "main");
			NativeFieldInfoPtr_arms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, "arms");
			NativeFieldInfoPtr_sp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, "sp");
			NativeFieldInfoPtr_limb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, "limb");
			NativeFieldInfoPtr_lH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, "lH");
			NativeFieldInfoPtr_rH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, "rH");
			NativeFieldInfoPtr_poser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, "poser");
			NativeMethodInfoPtr__ctor_Public_Void_Human_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, 100670132);
			NativeMethodInfoPtr_GetHuman_Public_Human_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, 100670133);
			NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, 100670134);
			NativeMethodInfoPtr_Unload_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, 100670135);
			NativeMethodInfoPtr__Load_b__13_0_Private_Boolean_ScenePoserController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr, 100670136);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234734, RefRangeEnd = 234735, XrefRangeStart = 234579, XrefRangeEnd = 234734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActorCapture(Human newHuman, bool limbCapture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActorCapture>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newHuman);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &limbCapture;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Human_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 164352, RefRangeEnd = 164359, XrefRangeStart = 164352, XrefRangeEnd = 164359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Human GetHuman()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHuman_Public_Human_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234836, RefRangeEnd = 234837, XrefRangeStart = 234735, XrefRangeEnd = 234836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234864, RefRangeEnd = 234865, XrefRangeStart = 234837, XrefRangeEnd = 234864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unload_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234865, XrefRangeEnd = 234876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Load_b__13_0(ScenePoserController item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Load_b__13_0_Private_Boolean_ScenePoserController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public ActorCapture(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class LimbCapture : TransformCapture
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_a;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CharacterAnchor_Vector3_Quaternion_0;

		public unsafe int a
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a)) = num;
			}
		}

		static LimbCapture()
		{
			Il2CppClassPointerStore<LimbCapture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "LimbCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LimbCapture>.NativeClassPtr);
			NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimbCapture>.NativeClassPtr, "a");
			NativeMethodInfoPtr__ctor_Public_Void_CharacterAnchor_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimbCapture>.NativeClassPtr, 100670137);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234876, XrefRangeEnd = 234877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LimbCapture(CitizenOutfitController.CharacterAnchor anchor, Vector3 pos, Quaternion rot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LimbCapture>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&anchor);
			*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
			*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rot;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CharacterAnchor_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public LimbCapture(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class HandItemCapture : TransformCapture
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_i;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_Vector3_Quaternion_0;

		public unsafe string i
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static HandItemCapture()
		{
			Il2CppClassPointerStore<HandItemCapture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "HandItemCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandItemCapture>.NativeClassPtr);
			NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandItemCapture>.NativeClassPtr, "i");
			NativeMethodInfoPtr__ctor_Public_Void_GameObject_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandItemCapture>.NativeClassPtr, 100670138);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234877, XrefRangeEnd = 234879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandItemCapture(GameObject obj, Vector3 pos, Quaternion rot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandItemCapture>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
			*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rot;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GameObject_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public HandItemCapture(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_interactable;

	private static readonly System.IntPtr NativeFieldInfoPtr_coversRooms;

	private static readonly System.IntPtr NativeFieldInfoPtr_coveredNodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_scenePoserPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_objectPoserPool;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCaptureAt;

	private static readonly System.IntPtr NativeFieldInfoPtr_assignCapID;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnNewCapture;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnNewCapture_Public_add_Void_OnCapture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnNewCapture_Public_rem_Void_OnCapture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshCoveredArea_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteCapture_Public_SceneCapture_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;

	public unsafe Interactable interactable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Interactable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactable));
		}
	}

	public unsafe List<NewRoom> coversRooms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coversRooms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewRoom>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coversRooms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<NewNode, List<int>> coveredNodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coveredNodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<NewNode, List<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coveredNodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static List<ScenePoserController> scenePoserPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_scenePoserPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ScenePoserController>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_scenePoserPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static Dictionary<string, List<GameObject>> objectPoserPool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_objectPoserPool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, List<GameObject>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_objectPoserPool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe float lastCaptureAt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCaptureAt);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCaptureAt)) = num;
		}
	}

	public unsafe static int assignCapID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_assignCapID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_assignCapID, (void*)(&num));
		}
	}

	public unsafe OnCapture OnNewCapture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnNewCapture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OnCapture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnNewCapture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)onCapture));
		}
	}

	static SceneRecorder()
	{
		Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SceneRecorder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr);
		NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "interactable");
		NativeFieldInfoPtr_coversRooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "coversRooms");
		NativeFieldInfoPtr_coveredNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "coveredNodes");
		NativeFieldInfoPtr_scenePoserPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "scenePoserPool");
		NativeFieldInfoPtr_objectPoserPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "objectPoserPool");
		NativeFieldInfoPtr_lastCaptureAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "lastCaptureAt");
		NativeFieldInfoPtr_assignCapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "assignCapID");
		NativeFieldInfoPtr_OnNewCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, "OnNewCapture");
		NativeMethodInfoPtr_add_OnNewCapture_Public_add_Void_OnCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, 100670094);
		NativeMethodInfoPtr_remove_OnNewCapture_Public_rem_Void_OnCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, 100670095);
		NativeMethodInfoPtr__ctor_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, 100670096);
		NativeMethodInfoPtr_RefreshCoveredArea_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, 100670097);
		NativeMethodInfoPtr_ExecuteCapture_Public_SceneCapture_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr, 100670098);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234879, XrefRangeEnd = 234882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnNewCapture(OnCapture value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnNewCapture_Public_add_Void_OnCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234885, RefRangeEnd = 234887, XrefRangeStart = 234882, XrefRangeEnd = 234885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnNewCapture(OnCapture value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnNewCapture_Public_rem_Void_OnCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 234917, RefRangeEnd = 234919, XrefRangeStart = 234887, XrefRangeEnd = 234917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SceneRecorder(Interactable newInteractable)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneRecorder>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newInteractable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 235129, RefRangeEnd = 235132, XrefRangeStart = 234919, XrefRangeEnd = 235129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshCoveredArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshCoveredArea_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 235165, RefRangeEnd = 235170, XrefRangeStart = 235132, XrefRangeEnd = 235165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SceneCapture ExecuteCapture(bool onlyIfMovement, bool detailedCapture = false, bool prepToSaveCapture = true, bool useFlashlight = false, bool useFlash = false, bool includePlayerModel = true, bool cctvCapture = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&onlyIfMovement);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &detailedCapture;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &prepToSaveCapture;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &useFlashlight;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &useFlash;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &includePlayerModel;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &cctvCapture;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteCapture_Public_SceneCapture_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SceneCapture>(intPtr) : null;
	}

	public SceneRecorder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
