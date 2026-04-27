using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

[Serializable]
public class SideJobMissingPerson : SideJob
{
	private static readonly IntPtr NativeFieldInfoPtr_readyToPost;

	private static readonly IntPtr NativeFieldInfoPtr_exitBuilding;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JobPreset_JobPickData_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_PostJob_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_AcceptJob_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GameWorldLoop_Public_Virtual_Void_0;

	public unsafe bool readyToPost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readyToPost);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readyToPost)) = flag;
		}
	}

	public unsafe NewAIGoal exitBuilding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitBuilding);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NewAIGoal>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exitBuilding)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newAIGoal));
		}
	}

	static SideJobMissingPerson()
	{
		Il2CppClassPointerStore<SideJobMissingPerson>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SideJobMissingPerson");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SideJobMissingPerson>.NativeClassPtr);
		NativeFieldInfoPtr_readyToPost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideJobMissingPerson>.NativeClassPtr, "readyToPost");
		NativeFieldInfoPtr_exitBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SideJobMissingPerson>.NativeClassPtr, "exitBuilding");
		NativeMethodInfoPtr__ctor_Public_Void_JobPreset_JobPickData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SideJobMissingPerson>.NativeClassPtr, 100668351);
		NativeMethodInfoPtr_PostJob_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SideJobMissingPerson>.NativeClassPtr, 100668352);
		NativeMethodInfoPtr_AcceptJob_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SideJobMissingPerson>.NativeClassPtr, 100668353);
		NativeMethodInfoPtr_GameWorldLoop_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SideJobMissingPerson>.NativeClassPtr, 100668354);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170594, XrefRangeEnd = 170598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SideJobMissingPerson(JobPreset newPreset, SideJobController.JobPickData newData, bool immediatePost)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SideJobMissingPerson>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newPreset);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &immediatePost;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_JobPreset_JobPickData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170598, XrefRangeEnd = 170599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void PostJob()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PostJob_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170599, XrefRangeEnd = 170626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void AcceptJob()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AcceptJob_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170626, XrefRangeEnd = 170650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void GameWorldLoop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GameWorldLoop_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SideJobMissingPerson(IntPtr pointer)
		: base(pointer)
	{
	}
}
