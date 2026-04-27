using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class ScenePoserController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_outfitController;

	private static readonly IntPtr NativeFieldInfoPtr_human;

	private static readonly IntPtr NativeFieldInfoPtr_node;

	private static readonly IntPtr NativeFieldInfoPtr_outfit;

	private static readonly IntPtr NativeFieldInfoPtr_spawnedLeft;

	private static readonly IntPtr NativeFieldInfoPtr_spawnedRight;

	private static readonly IntPtr NativeMethodInfoPtr_SetupCitizen_Public_Void_ActorCapture_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CitizenOutfitController outfitController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfitController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CitizenOutfitController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfitController)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)citizenOutfitController));
		}
	}

	public unsafe Human human
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
		}
	}

	public unsafe NewNode node
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NewNode>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_node)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newNode));
		}
	}

	public unsafe ClothesPreset.OutfitCategory outfit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfit);
			return *(ClothesPreset.OutfitCategory*)num;
		}
		set
		{
			*(ClothesPreset.OutfitCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfit)) = outfitCategory;
		}
	}

	public unsafe GameObject spawnedLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedLeft);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedLeft)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe GameObject spawnedRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedRight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnedRight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	static ScenePoserController()
	{
		Il2CppClassPointerStore<ScenePoserController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ScenePoserController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScenePoserController>.NativeClassPtr);
		NativeFieldInfoPtr_outfitController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScenePoserController>.NativeClassPtr, "outfitController");
		NativeFieldInfoPtr_human = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScenePoserController>.NativeClassPtr, "human");
		NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScenePoserController>.NativeClassPtr, "node");
		NativeFieldInfoPtr_outfit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScenePoserController>.NativeClassPtr, "outfit");
		NativeFieldInfoPtr_spawnedLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScenePoserController>.NativeClassPtr, "spawnedLeft");
		NativeFieldInfoPtr_spawnedRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScenePoserController>.NativeClassPtr, "spawnedRight");
		NativeMethodInfoPtr_SetupCitizen_Public_Void_ActorCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenePoserController>.NativeClassPtr, 100667304);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenePoserController>.NativeClassPtr, 100667305);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 137846, RefRangeEnd = 137847, XrefRangeStart = 137468, XrefRangeEnd = 137846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupCitizen(SceneRecorder.ActorCapture newCapture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newCapture);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCitizen_Public_Void_ActorCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScenePoserController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScenePoserController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ScenePoserController(IntPtr pointer)
		: base(pointer)
	{
	}
}
