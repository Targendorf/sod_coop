using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class DoorPairPreset : ScriptableObjectIDSystem
{
	public enum WallSectionClass
	{
		wall,
		window,
		windowLarge,
		entrance,
		ventUpper,
		ventLower,
		ventTop
	}

	private static readonly IntPtr NativeFieldInfoPtr_parentWallsLong;

	private static readonly IntPtr NativeFieldInfoPtr_childWallsLong;

	private static readonly IntPtr NativeFieldInfoPtr_parentWallsShort;

	private static readonly IntPtr NativeFieldInfoPtr_childWallsShort;

	private static readonly IntPtr NativeFieldInfoPtr_corners;

	private static readonly IntPtr NativeFieldInfoPtr_quoins;

	private static readonly IntPtr NativeFieldInfoPtr_optimizeSections;

	private static readonly IntPtr NativeFieldInfoPtr_appearInEditor;

	private static readonly IntPtr NativeFieldInfoPtr_supportsWallProps;

	private static readonly IntPtr NativeFieldInfoPtr_isFence;

	private static readonly IntPtr NativeFieldInfoPtr_divider;

	private static readonly IntPtr NativeFieldInfoPtr_dividerLeft;

	private static readonly IntPtr NativeFieldInfoPtr_dividerRight;

	private static readonly IntPtr NativeFieldInfoPtr_canFeatureDoor;

	private static readonly IntPtr NativeFieldInfoPtr_doorOffset;

	private static readonly IntPtr NativeFieldInfoPtr_sectionClass;

	private static readonly IntPtr NativeFieldInfoPtr_ignoreCullingRaycasts;

	private static readonly IntPtr NativeFieldInfoPtr_raisedFloorOverride;

	private static readonly IntPtr NativeFieldInfoPtr_materialOverride;

	private static readonly IntPtr NativeFieldInfoPtr_mapOverride;

	private static readonly IntPtr NativeFieldInfoPtr_overrideWallNormal;

	private static readonly IntPtr NativeFieldInfoPtr_wallNormalOverrride;

	private static readonly IntPtr NativeFieldInfoPtr_overrideDuctLower;

	private static readonly IntPtr NativeFieldInfoPtr_ductLowerOverrride;

	private static readonly IntPtr NativeFieldInfoPtr_overrideDuctUpper;

	private static readonly IntPtr NativeFieldInfoPtr_ductUpperOverrride;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateIDs_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<GameObject> parentWallsLong
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentWallsLong);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentWallsLong)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameObject> childWallsLong
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childWallsLong);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childWallsLong)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameObject> parentWallsShort
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentWallsShort);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentWallsShort)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameObject> childWallsShort
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childWallsShort);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_childWallsShort)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameObject> corners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_corners);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_corners)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<GameObject> quoins
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quoins);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quoins)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool optimizeSections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optimizeSections);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optimizeSections)) = flag;
		}
	}

	public unsafe bool appearInEditor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appearInEditor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appearInEditor)) = flag;
		}
	}

	public unsafe bool supportsWallProps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsWallProps);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsWallProps)) = flag;
		}
	}

	public unsafe bool isFence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFence);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFence)) = flag;
		}
	}

	public unsafe bool divider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_divider);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_divider)) = flag;
		}
	}

	public unsafe bool dividerLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dividerLeft);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dividerLeft)) = flag;
		}
	}

	public unsafe bool dividerRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dividerRight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dividerRight)) = flag;
		}
	}

	public unsafe bool canFeatureDoor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canFeatureDoor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canFeatureDoor)) = flag;
		}
	}

	public unsafe Vector3 doorOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorOffset)) = vector;
		}
	}

	public unsafe WallSectionClass sectionClass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sectionClass);
			return *(WallSectionClass*)num;
		}
		set
		{
			*(WallSectionClass*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sectionClass)) = wallSectionClass;
		}
	}

	public unsafe bool ignoreCullingRaycasts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreCullingRaycasts);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ignoreCullingRaycasts)) = flag;
		}
	}

	public unsafe DoorPairPreset raisedFloorOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raisedFloorOverride);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DoorPairPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_raisedFloorOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPairPreset));
		}
	}

	public unsafe MaterialGroupPreset materialOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialOverride);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MaterialGroupPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialGroupPreset));
		}
	}

	public unsafe List<Texture2D> mapOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapOverride);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Texture2D>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapOverride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool overrideWallNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideWallNormal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideWallNormal)) = flag;
		}
	}

	public unsafe DoorPairPreset wallNormalOverrride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallNormalOverrride);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DoorPairPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallNormalOverrride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPairPreset));
		}
	}

	public unsafe bool overrideDuctLower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideDuctLower);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideDuctLower)) = flag;
		}
	}

	public unsafe DoorPairPreset ductLowerOverrride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductLowerOverrride);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DoorPairPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductLowerOverrride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPairPreset));
		}
	}

	public unsafe bool overrideDuctUpper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideDuctUpper);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideDuctUpper)) = flag;
		}
	}

	public unsafe DoorPairPreset ductUpperOverrride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductUpperOverrride);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DoorPairPreset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ductUpperOverrride)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)doorPairPreset));
		}
	}

	static DoorPairPreset()
	{
		Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DoorPairPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr);
		NativeFieldInfoPtr_parentWallsLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "parentWallsLong");
		NativeFieldInfoPtr_childWallsLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "childWallsLong");
		NativeFieldInfoPtr_parentWallsShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "parentWallsShort");
		NativeFieldInfoPtr_childWallsShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "childWallsShort");
		NativeFieldInfoPtr_corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "corners");
		NativeFieldInfoPtr_quoins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "quoins");
		NativeFieldInfoPtr_optimizeSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "optimizeSections");
		NativeFieldInfoPtr_appearInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "appearInEditor");
		NativeFieldInfoPtr_supportsWallProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "supportsWallProps");
		NativeFieldInfoPtr_isFence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "isFence");
		NativeFieldInfoPtr_divider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "divider");
		NativeFieldInfoPtr_dividerLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "dividerLeft");
		NativeFieldInfoPtr_dividerRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "dividerRight");
		NativeFieldInfoPtr_canFeatureDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "canFeatureDoor");
		NativeFieldInfoPtr_doorOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "doorOffset");
		NativeFieldInfoPtr_sectionClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "sectionClass");
		NativeFieldInfoPtr_ignoreCullingRaycasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "ignoreCullingRaycasts");
		NativeFieldInfoPtr_raisedFloorOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "raisedFloorOverride");
		NativeFieldInfoPtr_materialOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "materialOverride");
		NativeFieldInfoPtr_mapOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "mapOverride");
		NativeFieldInfoPtr_overrideWallNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "overrideWallNormal");
		NativeFieldInfoPtr_wallNormalOverrride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "wallNormalOverrride");
		NativeFieldInfoPtr_overrideDuctLower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "overrideDuctLower");
		NativeFieldInfoPtr_ductLowerOverrride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "ductLowerOverrride");
		NativeFieldInfoPtr_overrideDuctUpper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "overrideDuctUpper");
		NativeFieldInfoPtr_ductUpperOverrride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, "ductUpperOverrride");
		NativeMethodInfoPtr_UpdateIDs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, 100673882);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr, 100673883);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateIDs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateIDs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328246, XrefRangeEnd = 328280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoorPairPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorPairPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DoorPairPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
