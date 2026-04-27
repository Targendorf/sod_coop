using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class SwitchSyncBehaviour : MonoBehaviour
{
	public enum BasicBehaviour
	{
		none,
		hideWhenOn,
		hideWhenOff
	}

	private static readonly IntPtr NativeFieldInfoPtr_syncWithState;

	private static readonly IntPtr NativeFieldInfoPtr_isOn;

	private static readonly IntPtr NativeFieldInfoPtr_inverted;

	private static readonly IntPtr NativeFieldInfoPtr_basicBehaviour;

	private static readonly IntPtr NativeFieldInfoPtr_basicBehaviourObjects;

	private static readonly IntPtr NativeFieldInfoPtr_syncInteractable;

	private static readonly IntPtr NativeFieldInfoPtr_onlySyncWhenParentIsOn;

	private static readonly IntPtr NativeMethodInfoPtr_SetOn_Public_Virtual_New_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe InteractablePreset.Switch syncWithState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncWithState);
			return *(InteractablePreset.Switch*)num;
		}
		set
		{
			*(InteractablePreset.Switch*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncWithState)) = obj;
		}
	}

	public unsafe bool isOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOn)) = flag;
		}
	}

	public unsafe bool inverted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inverted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inverted)) = flag;
		}
	}

	public unsafe BasicBehaviour basicBehaviour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basicBehaviour);
			return *(BasicBehaviour*)num;
		}
		set
		{
			*(BasicBehaviour*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basicBehaviour)) = basicBehaviour;
		}
	}

	public unsafe List<GameObject> basicBehaviourObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basicBehaviourObjects);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basicBehaviourObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe InteractableController syncInteractable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncInteractable);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InteractableController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_syncInteractable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactableController));
		}
	}

	public unsafe bool onlySyncWhenParentIsOn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlySyncWhenParentIsOn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlySyncWhenParentIsOn)) = flag;
		}
	}

	static SwitchSyncBehaviour()
	{
		Il2CppClassPointerStore<SwitchSyncBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SwitchSyncBehaviour");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchSyncBehaviour>.NativeClassPtr);
		NativeFieldInfoPtr_syncWithState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSyncBehaviour>.NativeClassPtr, "syncWithState");
		NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSyncBehaviour>.NativeClassPtr, "isOn");
		NativeFieldInfoPtr_inverted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSyncBehaviour>.NativeClassPtr, "inverted");
		NativeFieldInfoPtr_basicBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSyncBehaviour>.NativeClassPtr, "basicBehaviour");
		NativeFieldInfoPtr_basicBehaviourObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSyncBehaviour>.NativeClassPtr, "basicBehaviourObjects");
		NativeFieldInfoPtr_syncInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSyncBehaviour>.NativeClassPtr, "syncInteractable");
		NativeFieldInfoPtr_onlySyncWhenParentIsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSyncBehaviour>.NativeClassPtr, "onlySyncWhenParentIsOn");
		NativeMethodInfoPtr_SetOn_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchSyncBehaviour>.NativeClassPtr, 100670170);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchSyncBehaviour>.NativeClassPtr, 100670171);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 236255, RefRangeEnd = 236260, XrefRangeStart = 236208, XrefRangeEnd = 236255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetOn(bool val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&val);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetOn_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 236269, RefRangeEnd = 236276, XrefRangeStart = 236260, XrefRangeEnd = 236269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SwitchSyncBehaviour()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwitchSyncBehaviour>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SwitchSyncBehaviour(IntPtr pointer)
		: base(pointer)
	{
	}
}
