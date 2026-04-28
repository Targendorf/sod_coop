using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

public class ResidencePreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_habitable;

	private static readonly IntPtr NativeFieldInfoPtr_enableForSale;

	private static readonly IntPtr NativeFieldInfoPtr_furnitureIfUnihabited;

	private static readonly IntPtr NativeFieldInfoPtr_isHotelRoom;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool habitable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_habitable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_habitable)) = flag;
		}
	}

	public unsafe bool enableForSale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableForSale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableForSale)) = flag;
		}
	}

	public unsafe bool furnitureIfUnihabited
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureIfUnihabited);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_furnitureIfUnihabited)) = flag;
		}
	}

	public unsafe bool isHotelRoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHotelRoom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHotelRoom)) = flag;
		}
	}

	static ResidencePreset()
	{
		Il2CppClassPointerStore<ResidencePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ResidencePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResidencePreset>.NativeClassPtr);
		NativeFieldInfoPtr_habitable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResidencePreset>.NativeClassPtr, "habitable");
		NativeFieldInfoPtr_enableForSale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResidencePreset>.NativeClassPtr, "enableForSale");
		NativeFieldInfoPtr_furnitureIfUnihabited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResidencePreset>.NativeClassPtr, "furnitureIfUnihabited");
		NativeFieldInfoPtr_isHotelRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResidencePreset>.NativeClassPtr, "isHotelRoom");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResidencePreset>.NativeClassPtr, 100674009);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329871, XrefRangeEnd = 329872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResidencePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResidencePreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ResidencePreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
