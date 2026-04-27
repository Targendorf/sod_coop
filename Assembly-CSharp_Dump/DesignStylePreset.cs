using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

public class DesignStylePreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_includeInPersonalityMatching;

	private static readonly IntPtr NativeFieldInfoPtr_compatibleAddressTypes;

	private static readonly IntPtr NativeFieldInfoPtr_minimumWealth;

	private static readonly IntPtr NativeFieldInfoPtr_humility;

	private static readonly IntPtr NativeFieldInfoPtr_emotionality;

	private static readonly IntPtr NativeFieldInfoPtr_extraversion;

	private static readonly IntPtr NativeFieldInfoPtr_agreeableness;

	private static readonly IntPtr NativeFieldInfoPtr_conscientiousness;

	private static readonly IntPtr NativeFieldInfoPtr_creativity;

	private static readonly IntPtr NativeFieldInfoPtr_modernity;

	private static readonly IntPtr NativeFieldInfoPtr_allowCoving;

	private static readonly IntPtr NativeFieldInfoPtr_isBasement;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool includeInPersonalityMatching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeInPersonalityMatching);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeInPersonalityMatching)) = flag;
		}
	}

	public unsafe List<LayoutConfiguration> compatibleAddressTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleAddressTypes);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<LayoutConfiguration>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compatibleAddressTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float minimumWealth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumWealth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumWealth)) = num;
		}
	}

	public unsafe int humility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humility);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_humility)) = num;
		}
	}

	public unsafe int emotionality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotionality);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotionality)) = num;
		}
	}

	public unsafe int extraversion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraversion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_extraversion)) = num;
		}
	}

	public unsafe int agreeableness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agreeableness);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_agreeableness)) = num;
		}
	}

	public unsafe int conscientiousness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conscientiousness);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conscientiousness)) = num;
		}
	}

	public unsafe int creativity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creativity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_creativity)) = num;
		}
	}

	public unsafe int modernity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modernity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modernity)) = num;
		}
	}

	public unsafe bool allowCoving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowCoving);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowCoving)) = flag;
		}
	}

	public unsafe bool isBasement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBasement);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBasement)) = flag;
		}
	}

	static DesignStylePreset()
	{
		Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DesignStylePreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr);
		NativeFieldInfoPtr_includeInPersonalityMatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr, "includeInPersonalityMatching");
		NativeFieldInfoPtr_compatibleAddressTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr, "compatibleAddressTypes");
		NativeFieldInfoPtr_minimumWealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr, "minimumWealth");
		NativeFieldInfoPtr_humility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr, "humility");
		NativeFieldInfoPtr_emotionality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr, "emotionality");
		NativeFieldInfoPtr_extraversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr, "extraversion");
		NativeFieldInfoPtr_agreeableness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr, "agreeableness");
		NativeFieldInfoPtr_conscientiousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr, "conscientiousness");
		NativeFieldInfoPtr_creativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr, "creativity");
		NativeFieldInfoPtr_modernity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr, "modernity");
		NativeFieldInfoPtr_allowCoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr, "allowCoving");
		NativeFieldInfoPtr_isBasement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr, "isBasement");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr, 100673874);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328091, XrefRangeEnd = 328099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DesignStylePreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesignStylePreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public DesignStylePreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
