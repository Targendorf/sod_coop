using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class ChapterPreset : SoCustomComparison
{
	private static readonly IntPtr NativeFieldInfoPtr_chapterNumber;

	private static readonly IntPtr NativeFieldInfoPtr_scriptObject;

	private static readonly IntPtr NativeFieldInfoPtr_dictionary;

	private static readonly IntPtr NativeFieldInfoPtr_askToEnableTutorial;

	private static readonly IntPtr NativeFieldInfoPtr_startingHour;

	private static readonly IntPtr NativeFieldInfoPtr_startingDate;

	private static readonly IntPtr NativeFieldInfoPtr_startingMonth;

	private static readonly IntPtr NativeFieldInfoPtr_startingYear;

	private static readonly IntPtr NativeFieldInfoPtr_yearZeroLeapYearCycle;

	private static readonly IntPtr NativeFieldInfoPtr_dayZero;

	private static readonly IntPtr NativeFieldInfoPtr_rainAmount;

	private static readonly IntPtr NativeFieldInfoPtr_windAmount;

	private static readonly IntPtr NativeFieldInfoPtr_snowAmount;

	private static readonly IntPtr NativeFieldInfoPtr_fogAmount;

	private static readonly IntPtr NativeFieldInfoPtr_lightningAmount;

	private static readonly IntPtr NativeFieldInfoPtr_transitionSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_usePreSimulation;

	private static readonly IntPtr NativeFieldInfoPtr_minimumPreSimLength;

	private static readonly IntPtr NativeFieldInfoPtr_audioEvents;

	private static readonly IntPtr NativeFieldInfoPtr_dialogEvents;

	private static readonly IntPtr NativeFieldInfoPtr_crimePool;

	private static readonly IntPtr NativeFieldInfoPtr_MOPool;

	private static readonly IntPtr NativeFieldInfoPtr_partNames;

	private static readonly IntPtr NativeFieldInfoPtr_startingPart;

	private static readonly IntPtr NativeMethodInfoPtr_SkipToChapterPart_Public_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int chapterNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chapterNumber);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chapterNumber)) = num;
		}
	}

	public unsafe GameObject scriptObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scriptObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scriptObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe string dictionary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dictionary);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dictionary)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool askToEnableTutorial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_askToEnableTutorial);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_askToEnableTutorial)) = flag;
		}
	}

	public unsafe float startingHour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingHour);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingHour)) = num;
		}
	}

	public unsafe int startingDate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingDate);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingDate)) = num;
		}
	}

	public unsafe int startingMonth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingMonth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingMonth)) = num;
		}
	}

	public unsafe int startingYear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingYear);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingYear)) = num;
		}
	}

	public unsafe int yearZeroLeapYearCycle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearZeroLeapYearCycle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yearZeroLeapYearCycle)) = num;
		}
	}

	public unsafe int dayZero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayZero);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dayZero)) = num;
		}
	}

	public unsafe float rainAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rainAmount)) = num;
		}
	}

	public unsafe float windAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windAmount)) = num;
		}
	}

	public unsafe float snowAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snowAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_snowAmount)) = num;
		}
	}

	public unsafe float fogAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fogAmount)) = num;
		}
	}

	public unsafe float lightningAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightningAmount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightningAmount)) = num;
		}
	}

	public unsafe float transitionSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transitionSpeed)) = num;
		}
	}

	public unsafe bool usePreSimulation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePreSimulation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePreSimulation)) = flag;
		}
	}

	public unsafe float minimumPreSimLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumPreSimLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimumPreSimLength)) = num;
		}
	}

	public unsafe List<AudioEvent> audioEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioEvents);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<AudioEvent>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<DialogPreset> dialogEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogEvents);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<DialogPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dialogEvents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MurderPreset> crimePool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crimePool);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MurderPreset>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crimePool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MurderMO> MOPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MOPool);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MurderMO>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MOPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<string> partNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partNames);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int startingPart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingPart);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startingPart)) = num;
		}
	}

	static ChapterPreset()
	{
		Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ChapterPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr);
		NativeFieldInfoPtr_chapterNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "chapterNumber");
		NativeFieldInfoPtr_scriptObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "scriptObject");
		NativeFieldInfoPtr_dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "dictionary");
		NativeFieldInfoPtr_askToEnableTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "askToEnableTutorial");
		NativeFieldInfoPtr_startingHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "startingHour");
		NativeFieldInfoPtr_startingDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "startingDate");
		NativeFieldInfoPtr_startingMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "startingMonth");
		NativeFieldInfoPtr_startingYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "startingYear");
		NativeFieldInfoPtr_yearZeroLeapYearCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "yearZeroLeapYearCycle");
		NativeFieldInfoPtr_dayZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "dayZero");
		NativeFieldInfoPtr_rainAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "rainAmount");
		NativeFieldInfoPtr_windAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "windAmount");
		NativeFieldInfoPtr_snowAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "snowAmount");
		NativeFieldInfoPtr_fogAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "fogAmount");
		NativeFieldInfoPtr_lightningAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "lightningAmount");
		NativeFieldInfoPtr_transitionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "transitionSpeed");
		NativeFieldInfoPtr_usePreSimulation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "usePreSimulation");
		NativeFieldInfoPtr_minimumPreSimLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "minimumPreSimLength");
		NativeFieldInfoPtr_audioEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "audioEvents");
		NativeFieldInfoPtr_dialogEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "dialogEvents");
		NativeFieldInfoPtr_crimePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "crimePool");
		NativeFieldInfoPtr_MOPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "MOPool");
		NativeFieldInfoPtr_partNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "partNames");
		NativeFieldInfoPtr_startingPart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, "startingPart");
		NativeMethodInfoPtr_SkipToChapterPart_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, 100673840);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr, 100673841);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327805, XrefRangeEnd = 327808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SkipToChapterPart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SkipToChapterPart_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327808, XrefRangeEnd = 327845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChapterPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChapterPreset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChapterPreset(IntPtr pointer)
		: base(pointer)
	{
	}
}
