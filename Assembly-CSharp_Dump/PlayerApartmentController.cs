using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class PlayerApartmentController : MonoBehaviour
{
	[System.Serializable]
	public class PlayerFurniture : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_matKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_presetStr;

		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_placement;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Toolbox.MaterialKey matKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matKey);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe string presetStr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presetStr);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_presetStr)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe FurniturePreset preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurniturePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furniturePreset));
			}
		}

		public unsafe FurnitureLocation placement
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placement);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureLocation>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furnitureLocation));
			}
		}

		static PlayerFurniture()
		{
			Il2CppClassPointerStore<PlayerFurniture>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "PlayerFurniture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerFurniture>.NativeClassPtr);
			NativeFieldInfoPtr_matKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFurniture>.NativeClassPtr, "matKey");
			NativeFieldInfoPtr_presetStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFurniture>.NativeClassPtr, "presetStr");
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFurniture>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_placement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFurniture>.NativeClassPtr, "placement");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFurniture>.NativeClassPtr, 100670261);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerFurniture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerFurniture>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public PlayerFurniture(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class FurniturePlacement : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		private static readonly System.IntPtr NativeFieldInfoPtr_existing;

		private static readonly System.IntPtr NativeFieldInfoPtr_materialKey;

		private static readonly System.IntPtr NativeFieldInfoPtr_art;

		private static readonly System.IntPtr NativeFieldInfoPtr_anchorNode;

		private static readonly System.IntPtr NativeFieldInfoPtr_coversNodes;

		private static readonly System.IntPtr NativeFieldInfoPtr_angle;

		private static readonly System.IntPtr NativeFieldInfoPtr_offset;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe FurniturePreset preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurniturePreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furniturePreset));
			}
		}

		public unsafe FurnitureLocation existing
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_existing);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureLocation>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_existing)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furnitureLocation));
			}
		}

		public unsafe Toolbox.MaterialKey materialKey
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialKey);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
			}
		}

		public unsafe ArtPreset art
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_art);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArtPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_art)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)artPreset));
			}
		}

		public unsafe NewNode anchorNode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorNode);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
			}
		}

		public unsafe List<NewNode> coversNodes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coversNodes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NewNode>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coversNodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int angle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle)) = num;
			}
		}

		public unsafe Vector3 offset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = vector;
			}
		}

		static FurniturePlacement()
		{
			Il2CppClassPointerStore<FurniturePlacement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "FurniturePlacement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FurniturePlacement>.NativeClassPtr);
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePlacement>.NativeClassPtr, "preset");
			NativeFieldInfoPtr_existing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePlacement>.NativeClassPtr, "existing");
			NativeFieldInfoPtr_materialKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePlacement>.NativeClassPtr, "materialKey");
			NativeFieldInfoPtr_art = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePlacement>.NativeClassPtr, "art");
			NativeFieldInfoPtr_anchorNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePlacement>.NativeClassPtr, "anchorNode");
			NativeFieldInfoPtr_coversNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePlacement>.NativeClassPtr, "coversNodes");
			NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePlacement>.NativeClassPtr, "angle");
			NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FurniturePlacement>.NativeClassPtr, "offset");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurniturePlacement>.NativeClassPtr, 100670262);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237554, XrefRangeEnd = 237562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FurniturePlacement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FurniturePlacement>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public FurniturePlacement(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class FurnitureChange : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

		static FurnitureChange()
		{
			Il2CppClassPointerStore<FurnitureChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "FurnitureChange");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureChange>.NativeClassPtr, 100670263);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureChange>.NativeClassPtr, 100670264);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureChange>.NativeClassPtr, 100670265);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FurnitureChange>.NativeClassPtr, 100670266);
		}

		[CallerCount(994)]
		[CachedScanResults(RefRangeStart = 10717, RefRangeEnd = 11711, XrefRangeStart = 10717, XrefRangeEnd = 11711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FurnitureChange(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FurnitureChange>.NativeClassPtr))
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

		public FurnitureChange(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator FurnitureChange(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<FurnitureChange>((System.Delegate)P_0);
		}

		public static FurnitureChange operator +(FurnitureChange P_0, FurnitureChange P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<FurnitureChange>();
		}

		public static FurnitureChange operator -(FurnitureChange P_0, FurnitureChange P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<FurnitureChange>();
			}
			return (FurnitureChange)obj;
		}
	}

	[System.Serializable]
	[ObfuscatedName("PlayerApartmentController+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__46_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__48_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__49_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__49_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__49_2;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetFurniturePlacementMode_b__46_0_Internal_Boolean_InventorySlot_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetDecoratingMode_b__48_0_Internal_Boolean_InventorySlot_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__49_0_Internal_Boolean_AirDuctSection_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__49_1_Internal_Boolean_AirDuctSection_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__49_2_Internal_Boolean_FurnitureLocation_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveItemFromStorage_b__64_0_Internal_Boolean_Passed_0;

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

		public unsafe static Il2CppSystem.Predicate<FirstPersonItemController.InventorySlot> __9__46_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__46_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<FirstPersonItemController.InventorySlot>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__46_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<FirstPersonItemController.InventorySlot> __9__48_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__48_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<FirstPersonItemController.InventorySlot>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__48_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<AirDuctGroup.AirDuctSection> __9__49_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<AirDuctGroup.AirDuctSection>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__49_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<AirDuctGroup.AirDuctSection> __9__49_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__49_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<AirDuctGroup.AirDuctSection>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__49_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<FurnitureLocation> __9__49_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__49_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<FurnitureLocation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__49_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		public unsafe static Il2CppSystem.Predicate<Interactable.Passed> __9__64_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__64_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Interactable.Passed>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__64_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__46_0");
			NativeFieldInfoPtr___9__48_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__48_0");
			NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__49_0");
			NativeFieldInfoPtr___9__49_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__49_1");
			NativeFieldInfoPtr___9__49_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__49_2");
			NativeFieldInfoPtr___9__64_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__64_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670268);
			NativeMethodInfoPtr__SetFurniturePlacementMode_b__46_0_Internal_Boolean_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670269);
			NativeMethodInfoPtr__SetDecoratingMode_b__48_0_Internal_Boolean_InventorySlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670270);
			NativeMethodInfoPtr__Update_b__49_0_Internal_Boolean_AirDuctSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670271);
			NativeMethodInfoPtr__Update_b__49_1_Internal_Boolean_AirDuctSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670272);
			NativeMethodInfoPtr__Update_b__49_2_Internal_Boolean_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670273);
			NativeMethodInfoPtr__RemoveItemFromStorage_b__64_0_Internal_Boolean_Passed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670274);
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
		public unsafe bool _SetFurniturePlacementMode_b__46_0(FirstPersonItemController.InventorySlot item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetFurniturePlacementMode_b__46_0_Internal_Boolean_InventorySlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _SetDecoratingMode_b__48_0(FirstPersonItemController.InventorySlot item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetDecoratingMode_b__48_0_Internal_Boolean_InventorySlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _Update_b__49_0(AirDuctGroup.AirDuctSection item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Update_b__49_0_Internal_Boolean_AirDuctSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _Update_b__49_1(AirDuctGroup.AirDuctSection item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Update_b__49_1_Internal_Boolean_AirDuctSection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237562, XrefRangeEnd = 237563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Update_b__49_2(FurnitureLocation item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Update_b__49_2_Internal_Boolean_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _RemoveItemFromStorage_b__64_0(Interactable.Passed item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveItemFromStorage_b__64_0_Internal_Boolean_Passed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_placementCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_placementValidLerpColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_placementInvalidLerpColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureFPSItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_nullCluster;

	private static readonly System.IntPtr NativeFieldInfoPtr_swatches;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_furniturePlacementMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_placeExistingRoomObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnPlacement;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnPlacementRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnedPlacementObj;

	private static readonly System.IntPtr NativeFieldInfoPtr_spawnedPlacementMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_furnitureRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloneMaterials;

	private static readonly System.IntPtr NativeFieldInfoPtr_placementColliders;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialPulse;

	private static readonly System.IntPtr NativeFieldInfoPtr_lerpColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_placementNode;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPlacementValid;

	private static readonly System.IntPtr NativeFieldInfoPtr_decoratingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_decoratingMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_decoratingType;

	private static readonly System.IntPtr NativeFieldInfoPtr_decoratingKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_decoratingRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialKeyWindow;

	private static readonly System.IntPtr NativeFieldInfoPtr_rememberContent;

	private static readonly System.IntPtr NativeFieldInfoPtr_rememberDecorType;

	private static readonly System.IntPtr NativeFieldInfoPtr_rememberRoomStorageShop;

	private static readonly System.IntPtr NativeFieldInfoPtr_rememberDisplayClasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_rememberItemDisplayClasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnFurnitureChange;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnFurnitureChange_Public_add_Void_FurnitureChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnFurnitureChange_Public_rem_Void_FurnitureChange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_PlayerApartmentController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortSwatches_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Step_Public_Int32_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuyNewResidence_Public_Void_ResidenceController_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFurniturePlacementMode_Public_Void_Boolean_FurniturePlacement_NewRoom_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenOrUpdateMaterialWindow_Public_InfoWindow_FurniturePreset_MaterialKey_MaterialGroupPreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDecoratingMode_Public_Void_Boolean_MaterialGroupPreset_MaterialType_MaterialKey_NewRoom_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBeingPlaced_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExistingFurniture_Public_FurnitureLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePlacementColourKey_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFurnitureDesiredPosition_Private_NewNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RotateFurn_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFurnitureRotation_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecutePlacement_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetExisting_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentCost_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelPlacement_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveFurnitureToStorage_Public_Void_FurnitureLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromStorage_Public_Void_FurnitureLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SellFurniture_Public_Void_FurnitureLocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveItemToStorage_Public_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItemFromStorage_Public_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SellItem_Public_Void_Interactable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDecorColourKey_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyDecor_Public_Void_MaterialType_MaterialGroupPreset_MaterialKey_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RevertDecor_Public_Void_MaterialType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaceIndividualCluster_Public_Void_FurnitureCluster_NewAddress_DesignStylePreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__SortSwatches_b__43_0_Private_Int32_Color_Color_0;

	public unsafe Transform placementCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementCursor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementCursor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Color placementValidLerpColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementValidLerpColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementValidLerpColour)) = color;
		}
	}

	public unsafe Color placementInvalidLerpColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementInvalidLerpColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementInvalidLerpColour)) = color;
		}
	}

	public unsafe FirstPersonItem furnitureFPSItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureFPSItem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FirstPersonItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureFPSItem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)firstPersonItem));
		}
	}

	public unsafe FurnitureCluster nullCluster
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nullCluster);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureCluster>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nullCluster)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furnitureCluster));
		}
	}

	public unsafe List<Color> swatches
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_swatches);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Color>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_swatches)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<FurnitureLocation> furnitureStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureStorage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurnitureLocation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureStorage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Interactable> itemStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemStorage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Interactable>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemStorage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool furniturePlacementMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furniturePlacementMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furniturePlacementMode)) = flag;
		}
	}

	public unsafe bool placeExistingRoomObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeExistingRoomObject);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeExistingRoomObject)) = flag;
		}
	}

	public unsafe FurniturePlacement furnPlacement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnPlacement);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurniturePlacement>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnPlacement)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furniturePlacement));
		}
	}

	public unsafe NewRoom furnPlacementRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnPlacementRoom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnPlacementRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
		}
	}

	public unsafe GameObject spawnedPlacementObj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedPlacementObj);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedPlacementObj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe MeshRenderer spawnedPlacementMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedPlacementMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedPlacementMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer));
		}
	}

	public unsafe int furnitureRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureRotation);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureRotation)) = num;
		}
	}

	public unsafe List<Material> cloneMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cloneMaterials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cloneMaterials)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Collider> placementColliders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementColliders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementColliders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float materialPulse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialPulse);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialPulse)) = num;
		}
	}

	public unsafe Color lerpColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lerpColour)) = color;
		}
	}

	public unsafe NewNode placementNode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementNode);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placementNode)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
		}
	}

	public unsafe bool isPlacementValid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlacementValid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlacementValid)) = flag;
		}
	}

	public unsafe bool decoratingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decoratingMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decoratingMode)) = flag;
		}
	}

	public unsafe MaterialGroupPreset decoratingMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decoratingMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decoratingMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
		}
	}

	public unsafe MaterialGroupPreset.MaterialType decoratingType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decoratingType);
			return *(MaterialGroupPreset.MaterialType*)num;
		}
		set
		{
			*(MaterialGroupPreset.MaterialType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decoratingType)) = materialType;
		}
	}

	public unsafe Toolbox.MaterialKey decoratingKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decoratingKey);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Toolbox.MaterialKey>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decoratingKey)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialKey));
		}
	}

	public unsafe NewRoom decoratingRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decoratingRoom);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewRoom>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decoratingRoom)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newRoom));
		}
	}

	public unsafe InfoWindow materialKeyWindow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialKeyWindow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InfoWindow>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialKeyWindow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)infoWindow));
		}
	}

	public unsafe WindowTabPreset.TabContentType rememberContent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rememberContent);
			return *(WindowTabPreset.TabContentType*)num;
		}
		set
		{
			*(WindowTabPreset.TabContentType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rememberContent)) = tabContentType;
		}
	}

	public unsafe MaterialGroupPreset.MaterialType rememberDecorType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rememberDecorType);
			return *(MaterialGroupPreset.MaterialType*)num;
		}
		set
		{
			*(MaterialGroupPreset.MaterialType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rememberDecorType)) = materialType;
		}
	}

	public unsafe FurnishingsController.TabState rememberRoomStorageShop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rememberRoomStorageShop);
			return *(FurnishingsController.TabState*)num;
		}
		set
		{
			*(FurnishingsController.TabState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rememberRoomStorageShop)) = tabState;
		}
	}

	public unsafe List<FurniturePreset.DecorClass> rememberDisplayClasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rememberDisplayClasses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FurniturePreset.DecorClass>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rememberDisplayClasses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<InteractablePreset.ItemClass> rememberItemDisplayClasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rememberItemDisplayClasses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractablePreset.ItemClass>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rememberItemDisplayClasses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe FurnitureChange OnFurnitureChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnFurnitureChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureChange>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnFurnitureChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furnitureChange));
		}
	}

	public unsafe static PlayerApartmentController _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerApartmentController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerApartmentController));
		}
	}

	public unsafe static PlayerApartmentController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237573, XrefRangeEnd = 237575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_PlayerApartmentController_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerApartmentController>(intPtr) : null;
		}
	}

	static PlayerApartmentController()
	{
		Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlayerApartmentController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr);
		NativeFieldInfoPtr_placementCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "placementCursor");
		NativeFieldInfoPtr_placementValidLerpColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "placementValidLerpColour");
		NativeFieldInfoPtr_placementInvalidLerpColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "placementInvalidLerpColour");
		NativeFieldInfoPtr_furnitureFPSItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "furnitureFPSItem");
		NativeFieldInfoPtr_nullCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "nullCluster");
		NativeFieldInfoPtr_swatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "swatches");
		NativeFieldInfoPtr_furnitureStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "furnitureStorage");
		NativeFieldInfoPtr_itemStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "itemStorage");
		NativeFieldInfoPtr_furniturePlacementMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "furniturePlacementMode");
		NativeFieldInfoPtr_placeExistingRoomObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "placeExistingRoomObject");
		NativeFieldInfoPtr_furnPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "furnPlacement");
		NativeFieldInfoPtr_furnPlacementRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "furnPlacementRoom");
		NativeFieldInfoPtr_spawnedPlacementObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "spawnedPlacementObj");
		NativeFieldInfoPtr_spawnedPlacementMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "spawnedPlacementMesh");
		NativeFieldInfoPtr_furnitureRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "furnitureRotation");
		NativeFieldInfoPtr_cloneMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "cloneMaterials");
		NativeFieldInfoPtr_placementColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "placementColliders");
		NativeFieldInfoPtr_materialPulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "materialPulse");
		NativeFieldInfoPtr_lerpColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "lerpColour");
		NativeFieldInfoPtr_placementNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "placementNode");
		NativeFieldInfoPtr_isPlacementValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "isPlacementValid");
		NativeFieldInfoPtr_decoratingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "decoratingMode");
		NativeFieldInfoPtr_decoratingMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "decoratingMaterial");
		NativeFieldInfoPtr_decoratingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "decoratingType");
		NativeFieldInfoPtr_decoratingKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "decoratingKey");
		NativeFieldInfoPtr_decoratingRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "decoratingRoom");
		NativeFieldInfoPtr_materialKeyWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "materialKeyWindow");
		NativeFieldInfoPtr_rememberContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "rememberContent");
		NativeFieldInfoPtr_rememberDecorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "rememberDecorType");
		NativeFieldInfoPtr_rememberRoomStorageShop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "rememberRoomStorageShop");
		NativeFieldInfoPtr_rememberDisplayClasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "rememberDisplayClasses");
		NativeFieldInfoPtr_rememberItemDisplayClasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "rememberItemDisplayClasses");
		NativeFieldInfoPtr_OnFurnitureChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "OnFurnitureChange");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_add_OnFurnitureChange_Public_add_Void_FurnitureChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670227);
		NativeMethodInfoPtr_remove_OnFurnitureChange_Public_rem_Void_FurnitureChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670228);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_PlayerApartmentController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670229);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670230);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670231);
		NativeMethodInfoPtr_SortSwatches_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670232);
		NativeMethodInfoPtr_Step_Public_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670233);
		NativeMethodInfoPtr_BuyNewResidence_Public_Void_ResidenceController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670234);
		NativeMethodInfoPtr_SetFurniturePlacementMode_Public_Void_Boolean_FurniturePlacement_NewRoom_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670235);
		NativeMethodInfoPtr_OpenOrUpdateMaterialWindow_Public_InfoWindow_FurniturePreset_MaterialKey_MaterialGroupPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670236);
		NativeMethodInfoPtr_SetDecoratingMode_Public_Void_Boolean_MaterialGroupPreset_MaterialType_MaterialKey_NewRoom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670237);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670238);
		NativeMethodInfoPtr_RemoveBeingPlaced_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670239);
		NativeMethodInfoPtr_GetExistingFurniture_Public_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670240);
		NativeMethodInfoPtr_UpdatePlacementColourKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670241);
		NativeMethodInfoPtr_UpdateFurnitureDesiredPosition_Private_NewNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670242);
		NativeMethodInfoPtr_RotateFurn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670243);
		NativeMethodInfoPtr_AddFurnitureRotation_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670244);
		NativeMethodInfoPtr_ExecutePlacement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670245);
		NativeMethodInfoPtr_ResetExisting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670246);
		NativeMethodInfoPtr_GetCurrentCost_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670247);
		NativeMethodInfoPtr_CancelPlacement_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670248);
		NativeMethodInfoPtr_MoveFurnitureToStorage_Public_Void_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670249);
		NativeMethodInfoPtr_RemoveFromStorage_Public_Void_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670250);
		NativeMethodInfoPtr_SellFurniture_Public_Void_FurnitureLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670251);
		NativeMethodInfoPtr_MoveItemToStorage_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670252);
		NativeMethodInfoPtr_RemoveItemFromStorage_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670253);
		NativeMethodInfoPtr_SellItem_Public_Void_Interactable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670254);
		NativeMethodInfoPtr_UpdateDecorColourKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670255);
		NativeMethodInfoPtr_ApplyDecor_Public_Void_MaterialType_MaterialGroupPreset_MaterialKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670256);
		NativeMethodInfoPtr_RevertDecor_Public_Void_MaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670257);
		NativeMethodInfoPtr_PlaceIndividualCluster_Public_Void_FurnitureCluster_NewAddress_DesignStylePreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670258);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670259);
		NativeMethodInfoPtr__SortSwatches_b__43_0_Private_Int32_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr, 100670260);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237566, RefRangeEnd = 237568, XrefRangeStart = 237563, XrefRangeEnd = 237566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnFurnitureChange(FurnitureChange value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnFurnitureChange_Public_add_Void_FurnitureChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237571, RefRangeEnd = 237573, XrefRangeStart = 237568, XrefRangeEnd = 237571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnFurnitureChange(FurnitureChange value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnFurnitureChange_Public_rem_Void_FurnitureChange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237575, XrefRangeEnd = 237621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237621, XrefRangeEnd = 237642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237654, RefRangeEnd = 237655, XrefRangeStart = 237642, XrefRangeEnd = 237654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortSwatches()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortSwatches_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237661, RefRangeEnd = 237663, XrefRangeStart = 237655, XrefRangeEnd = 237661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Step(Color colour)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&colour);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Step_Public_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237740, RefRangeEnd = 237742, XrefRangeStart = 237663, XrefRangeEnd = 237740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuyNewResidence(ResidenceController newHome, bool removePreviousResidence = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newHome);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &removePreviousResidence;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuyNewResidence_Public_Void_ResidenceController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 237822, RefRangeEnd = 237830, XrefRangeStart = 237742, XrefRangeEnd = 237822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFurniturePlacementMode(bool val, FurniturePlacement newPlacement, NewRoom forRoom, bool newPlaceExistingRoomObject = false, bool forceUpdate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&val);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPlacement);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forRoom);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newPlaceExistingRoomObject;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceUpdate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFurniturePlacementMode_Public_Void_Boolean_FurniturePlacement_NewRoom_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237867, RefRangeEnd = 237868, XrefRangeStart = 237830, XrefRangeEnd = 237867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InfoWindow OpenOrUpdateMaterialWindow(FurniturePreset furn, Toolbox.MaterialKey useKey, MaterialGroupPreset newSelection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)furn);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)useKey);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newSelection);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenOrUpdateMaterialWindow_Public_InfoWindow_FurniturePreset_MaterialKey_MaterialGroupPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InfoWindow>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 237941, RefRangeEnd = 237946, XrefRangeStart = 237868, XrefRangeEnd = 237941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDecoratingMode(bool val, MaterialGroupPreset materialPreset, MaterialGroupPreset.MaterialType editType = MaterialGroupPreset.MaterialType.walls, Toolbox.MaterialKey editKey = null, NewRoom forRoom = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&val);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPreset);
		*(MaterialGroupPreset.MaterialType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &editType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)editKey);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)forRoom);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDecoratingMode_Public_Void_Boolean_MaterialGroupPreset_MaterialType_MaterialKey_NewRoom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237946, XrefRangeEnd = 237998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238026, RefRangeEnd = 238028, XrefRangeStart = 237998, XrefRangeEnd = 238026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveBeingPlaced()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBeingPlaced_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe FurnitureLocation GetExistingFurniture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExistingFurniture_Public_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FurnitureLocation>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238129, RefRangeEnd = 238130, XrefRangeStart = 238028, XrefRangeEnd = 238129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePlacementColourKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePlacementColourKey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238130, XrefRangeEnd = 238256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NewNode UpdateFurnitureDesiredPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFurnitureDesiredPosition_Private_NewNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238262, RefRangeEnd = 238264, XrefRangeStart = 238256, XrefRangeEnd = 238262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RotateFurn(bool right)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&right);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotateFurn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238264, RefRangeEnd = 238265, XrefRangeStart = 238264, XrefRangeEnd = 238264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddFurnitureRotation(int angle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFurnitureRotation_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238325, RefRangeEnd = 238327, XrefRangeStart = 238265, XrefRangeEnd = 238325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecutePlacement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecutePlacement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 238332, RefRangeEnd = 238335, XrefRangeStart = 238327, XrefRangeEnd = 238332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetExisting()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetExisting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238336, RefRangeEnd = 238338, XrefRangeStart = 238335, XrefRangeEnd = 238336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCurrentCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentCost_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238365, RefRangeEnd = 238367, XrefRangeStart = 238338, XrefRangeEnd = 238365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelPlacement(bool restoreExistingPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&restoreExistingPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelPlacement_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 238410, RefRangeEnd = 238413, XrefRangeStart = 238367, XrefRangeEnd = 238410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveFurnitureToStorage(FurnitureLocation newStorage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newStorage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveFurnitureToStorage_Public_Void_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 238441, RefRangeEnd = 238444, XrefRangeStart = 238413, XrefRangeEnd = 238441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFromStorage(FurnitureLocation newStorage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newStorage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFromStorage_Public_Void_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238482, RefRangeEnd = 238483, XrefRangeStart = 238444, XrefRangeEnd = 238482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SellFurniture(FurnitureLocation newSell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newSell);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SellFurniture_Public_Void_FurnitureLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 238558, RefRangeEnd = 238563, XrefRangeStart = 238483, XrefRangeEnd = 238558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveItemToStorage(Interactable newStorage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newStorage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveItemToStorage_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238563, XrefRangeEnd = 238595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveItemFromStorage(Interactable newStorage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newStorage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveItemFromStorage_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238619, RefRangeEnd = 238620, XrefRangeStart = 238595, XrefRangeEnd = 238619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SellItem(Interactable newSell)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newSell);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SellItem_Public_Void_Interactable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238620, XrefRangeEnd = 238621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDecorColourKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDecorColourKey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 238665, RefRangeEnd = 238668, XrefRangeStart = 238621, XrefRangeEnd = 238665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyDecor(MaterialGroupPreset.MaterialType decorType, MaterialGroupPreset material, Toolbox.MaterialKey key, bool saveChanges)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&decorType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveChanges;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyDecor_Public_Void_MaterialType_MaterialGroupPreset_MaterialKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238691, RefRangeEnd = 238692, XrefRangeStart = 238668, XrefRangeEnd = 238691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RevertDecor(MaterialGroupPreset.MaterialType decorType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&decorType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RevertDecor_Public_Void_MaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 238742, RefRangeEnd = 238746, XrefRangeStart = 238692, XrefRangeEnd = 238742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaceIndividualCluster(FurnitureCluster cluster, NewAddress address, DesignStylePreset styleOverride = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cluster);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)address);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)styleOverride);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaceIndividualCluster_Public_Void_FurnitureCluster_NewAddress_DesignStylePreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238746, XrefRangeEnd = 238790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerApartmentController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerApartmentController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238790, XrefRangeEnd = 238792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _SortSwatches_b__43_0(Color p1, Color p2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&p1);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortSwatches_b__43_0_Private_Int32_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public PlayerApartmentController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
