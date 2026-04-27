using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

public class DebugBlob : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_pos;

	private static readonly IntPtr NativeFieldInfoPtr_left;

	private static readonly IntPtr NativeFieldInfoPtr_right;

	private static readonly IntPtr NativeFieldInfoPtr_up;

	private static readonly IntPtr NativeFieldInfoPtr_down;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector2 pos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pos)) = vector;
		}
	}

	public unsafe bool left
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_left);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_left)) = flag;
		}
	}

	public unsafe bool right
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_right);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_right)) = flag;
		}
	}

	public unsafe bool up
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_up);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_up)) = flag;
		}
	}

	public unsafe bool down
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_down);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_down)) = flag;
		}
	}

	static DebugBlob()
	{
		Il2CppClassPointerStore<DebugBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DebugBlob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugBlob>.NativeClassPtr);
		NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugBlob>.NativeClassPtr, "pos");
		NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugBlob>.NativeClassPtr, "left");
		NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugBlob>.NativeClassPtr, "right");
		NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugBlob>.NativeClassPtr, "up");
		NativeFieldInfoPtr_down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugBlob>.NativeClassPtr, "down");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugBlob>.NativeClassPtr, 100667627);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugBlob()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugBlob>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DebugBlob(IntPtr pointer)
		: base(pointer)
	{
	}
}
