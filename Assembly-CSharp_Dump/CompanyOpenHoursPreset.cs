using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class CompanyOpenHoursPreset : SoCustomComparison
{
	[System.Serializable]
	public class CompanyShift : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_shiftType;

		private static readonly System.IntPtr NativeFieldInfoPtr_decimalHours;

		private static readonly System.IntPtr NativeFieldInfoPtr_monday;

		private static readonly System.IntPtr NativeFieldInfoPtr_tuesday;

		private static readonly System.IntPtr NativeFieldInfoPtr_wednesday;

		private static readonly System.IntPtr NativeFieldInfoPtr_thursday;

		private static readonly System.IntPtr NativeFieldInfoPtr_friday;

		private static readonly System.IntPtr NativeFieldInfoPtr_saturday;

		private static readonly System.IntPtr NativeFieldInfoPtr_sunday;

		private static readonly System.IntPtr NativeFieldInfoPtr_assigned;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugAssigned;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe OccupationPreset.ShiftType shiftType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftType);
				return *(OccupationPreset.ShiftType*)num;
			}
			set
			{
				*(OccupationPreset.ShiftType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiftType)) = shiftType;
			}
		}

		public unsafe Vector2 decimalHours
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decimalHours);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decimalHours)) = vector;
			}
		}

		public unsafe bool monday
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monday);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monday)) = flag;
			}
		}

		public unsafe bool tuesday
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuesday);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuesday)) = flag;
			}
		}

		public unsafe bool wednesday
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wednesday);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wednesday)) = flag;
			}
		}

		public unsafe bool thursday
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thursday);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thursday)) = flag;
			}
		}

		public unsafe bool friday
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_friday);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_friday)) = flag;
			}
		}

		public unsafe bool saturday
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saturday);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saturday)) = flag;
			}
		}

		public unsafe bool sunday
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunday);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunday)) = flag;
			}
		}

		public unsafe List<Occupation> assigned
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assigned);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Occupation>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assigned)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int debugAssigned
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugAssigned);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugAssigned)) = num;
			}
		}

		static CompanyShift()
		{
			Il2CppClassPointerStore<CompanyShift>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr, "CompanyShift");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr, "name");
			NativeFieldInfoPtr_shiftType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr, "shiftType");
			NativeFieldInfoPtr_decimalHours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr, "decimalHours");
			NativeFieldInfoPtr_monday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr, "monday");
			NativeFieldInfoPtr_tuesday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr, "tuesday");
			NativeFieldInfoPtr_wednesday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr, "wednesday");
			NativeFieldInfoPtr_thursday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr, "thursday");
			NativeFieldInfoPtr_friday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr, "friday");
			NativeFieldInfoPtr_saturday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr, "saturday");
			NativeFieldInfoPtr_sunday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr, "sunday");
			NativeFieldInfoPtr_assigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr, "assigned");
			NativeFieldInfoPtr_debugAssigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr, "debugAssigned");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr, 100673855);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327964, RefRangeEnd = 327966, XrefRangeStart = 327956, XrefRangeEnd = 327964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompanyShift()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompanyShift>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public CompanyShift(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_retailOpenHours;

	private static readonly System.IntPtr NativeFieldInfoPtr_monday;

	private static readonly System.IntPtr NativeFieldInfoPtr_tuesday;

	private static readonly System.IntPtr NativeFieldInfoPtr_wednesday;

	private static readonly System.IntPtr NativeFieldInfoPtr_thursday;

	private static readonly System.IntPtr NativeFieldInfoPtr_friday;

	private static readonly System.IntPtr NativeFieldInfoPtr_saturday;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunday;

	private static readonly System.IntPtr NativeFieldInfoPtr_shifts;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector2 retailOpenHours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retailOpenHours);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_retailOpenHours)) = vector;
		}
	}

	public unsafe bool monday
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monday);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_monday)) = flag;
		}
	}

	public unsafe bool tuesday
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuesday);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tuesday)) = flag;
		}
	}

	public unsafe bool wednesday
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wednesday);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wednesday)) = flag;
		}
	}

	public unsafe bool thursday
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thursday);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thursday)) = flag;
		}
	}

	public unsafe bool friday
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_friday);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_friday)) = flag;
		}
	}

	public unsafe bool saturday
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saturday);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saturday)) = flag;
		}
	}

	public unsafe bool sunday
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunday);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sunday)) = flag;
		}
	}

	public unsafe List<CompanyShift> shifts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shifts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CompanyShift>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shifts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static CompanyOpenHoursPreset()
	{
		Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CompanyOpenHoursPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr);
		NativeFieldInfoPtr_retailOpenHours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr, "retailOpenHours");
		NativeFieldInfoPtr_monday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr, "monday");
		NativeFieldInfoPtr_tuesday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr, "tuesday");
		NativeFieldInfoPtr_wednesday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr, "wednesday");
		NativeFieldInfoPtr_thursday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr, "thursday");
		NativeFieldInfoPtr_friday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr, "friday");
		NativeFieldInfoPtr_saturday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr, "saturday");
		NativeFieldInfoPtr_sunday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr, "sunday");
		NativeFieldInfoPtr_shifts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr, "shifts");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr, 100673854);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327966, XrefRangeEnd = 327974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CompanyOpenHoursPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompanyOpenHoursPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CompanyOpenHoursPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
