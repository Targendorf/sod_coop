using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class EditorFloorTile : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_floorCoord;

	private static readonly IntPtr NativeFieldInfoPtr_edgeTile;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector2Int floorCoord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorCoord);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_floorCoord)) = vector2Int;
		}
	}

	public unsafe bool edgeTile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_edgeTile);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_edgeTile)) = flag;
		}
	}

	static EditorFloorTile()
	{
		Il2CppClassPointerStore<EditorFloorTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EditorFloorTile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorFloorTile>.NativeClassPtr);
		NativeFieldInfoPtr_floorCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorFloorTile>.NativeClassPtr, "floorCoord");
		NativeFieldInfoPtr_edgeTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorFloorTile>.NativeClassPtr, "edgeTile");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorFloorTile>.NativeClassPtr, 100666617);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EditorFloorTile()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorFloorTile>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EditorFloorTile(IntPtr pointer)
		: base(pointer)
	{
	}
}
