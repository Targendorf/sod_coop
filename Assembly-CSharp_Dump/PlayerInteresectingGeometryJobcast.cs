using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerInteresectingGeometryJobcast : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_characterController;

	private static readonly IntPtr NativeFieldInfoPtr_fpsController;

	private static readonly IntPtr NativeFieldInfoPtr__origin;

	private static readonly IntPtr NativeFieldInfoPtr__direction;

	private static readonly IntPtr NativeFieldInfoPtr_mask;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CharacterController characterController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterController));
		}
	}

	public unsafe FirstPersonController fpsController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FirstPersonController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)firstPersonController));
		}
	}

	public unsafe Vector3 _origin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__origin);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__origin)) = vector;
		}
	}

	public unsafe Vector3 _direction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__direction);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__direction)) = vector;
		}
	}

	public unsafe LayerMask mask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mask);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mask)) = layerMask;
		}
	}

	static PlayerInteresectingGeometryJobcast()
	{
		Il2CppClassPointerStore<PlayerInteresectingGeometryJobcast>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlayerInteresectingGeometryJobcast");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInteresectingGeometryJobcast>.NativeClassPtr);
		NativeFieldInfoPtr_characterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteresectingGeometryJobcast>.NativeClassPtr, "characterController");
		NativeFieldInfoPtr_fpsController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteresectingGeometryJobcast>.NativeClassPtr, "fpsController");
		NativeFieldInfoPtr__origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteresectingGeometryJobcast>.NativeClassPtr, "_origin");
		NativeFieldInfoPtr__direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteresectingGeometryJobcast>.NativeClassPtr, "_direction");
		NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInteresectingGeometryJobcast>.NativeClassPtr, "mask");
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteresectingGeometryJobcast>.NativeClassPtr, 100667663);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInteresectingGeometryJobcast>.NativeClassPtr, 100667664);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145636, XrefRangeEnd = 145710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerInteresectingGeometryJobcast()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInteresectingGeometryJobcast>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PlayerInteresectingGeometryJobcast(IntPtr pointer)
		: base(pointer)
	{
	}
}
