using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class NameGenerator : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__instance;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_NameGenerator_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GenerateName_Public_String_String_Single_String_Single_String_Single_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GenerateName_Public_String_String_Single_String_Single_String_Single_byref_String_byref_String_byref_String_byref_Boolean_byref_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_GenerateName_Public_String_String_Single_String_Single_String_Single_Boolean_Int32_Int32_byref_String_byref_String_byref_String_byref_Boolean_byref_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static NameGenerator _instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<NameGenerator>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nameGenerator));
		}
	}

	public unsafe static NameGenerator Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99422, XrefRangeEnd = 99424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr2);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_NameGenerator_0, (IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NameGenerator>(intPtr) : null;
		}
	}

	static NameGenerator()
	{
		Il2CppClassPointerStore<NameGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NameGenerator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameGenerator>.NativeClassPtr);
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameGenerator>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_NameGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGenerator>.NativeClassPtr, 100666100);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGenerator>.NativeClassPtr, 100666101);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGenerator>.NativeClassPtr, 100666102);
		NativeMethodInfoPtr_GenerateName_Public_String_String_Single_String_Single_String_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGenerator>.NativeClassPtr, 100666103);
		NativeMethodInfoPtr_GenerateName_Public_String_String_Single_String_Single_String_Single_byref_String_byref_String_byref_String_byref_Boolean_byref_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGenerator>.NativeClassPtr, 100666104);
		NativeMethodInfoPtr_GenerateName_Public_String_String_Single_String_Single_String_Single_Boolean_Int32_Int32_byref_String_byref_String_byref_String_byref_Boolean_byref_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGenerator>.NativeClassPtr, 100666105);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameGenerator>.NativeClassPtr, 100666106);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99424, XrefRangeEnd = 99461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99461, XrefRangeEnd = 99482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 99483, RefRangeEnd = 99488, XrefRangeStart = 99482, XrefRangeEnd = 99483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GenerateName(string prefixList, float prefixChance, string mainList, float mainChance, string suffixList, float suffixChance, string useCustomSeed = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prefixList);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &prefixChance;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(mainList);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &mainChance;
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(suffixList);
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &suffixChance;
		*(IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(useCustomSeed);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateName_Public_String_String_Single_String_Single_String_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 99489, RefRangeEnd = 99490, XrefRangeStart = 99488, XrefRangeEnd = 99489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GenerateName(string prefixList, float prefixChance, string mainList, float mainChance, string suffixList, float suffixChance, out string prefixOutput, out string mainOutput, out string suffixOutput, out bool needsSuffixForShortName, out string alternateTags, string useCustomSeed = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[12];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prefixList);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &prefixChance;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(mainList);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &mainChance;
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(suffixList);
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &suffixChance;
		byte* num = (byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		byte* num5 = (byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref needsSuffixForShortName);
		byte* num7 = (byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(IntPtr)));
		nint num8 = 0;
		*(nint**)num7 = &num8;
		*(IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(useCustomSeed);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateName_Public_String_String_Single_String_Single_String_Single_byref_String_byref_String_byref_String_byref_Boolean_byref_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		prefixOutput = IL2CPP.Il2CppStringToManaged((IntPtr)num2);
		mainOutput = IL2CPP.Il2CppStringToManaged((IntPtr)num4);
		suffixOutput = IL2CPP.Il2CppStringToManaged((IntPtr)num6);
		alternateTags = IL2CPP.Il2CppStringToManaged((IntPtr)num8);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 99599, RefRangeEnd = 99617, XrefRangeStart = 99490, XrefRangeEnd = 99599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GenerateName(string prefixList, float prefixChance, string mainList, float mainChance, string suffixList, float suffixChance, bool mainIsCitizenName, int prefixMainAlliterationWeight, int mainSuffixAlliterationWeight, out string prefixOutput, out string mainOutput, out string suffixOutput, out bool needsSuffixForShortName, out string alternateTags, string useCustomSeed = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[15];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prefixList);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &prefixChance;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(mainList);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &mainChance;
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(suffixList);
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &suffixChance;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &mainIsCitizenName;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = &prefixMainAlliterationWeight;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(IntPtr)))) = &mainSuffixAlliterationWeight;
		byte* num = (byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		byte* num5 = (byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		*(void**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref needsSuffixForShortName);
		byte* num7 = (byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(IntPtr)));
		nint num8 = 0;
		*(nint**)num7 = &num8;
		*(IntPtr*)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(useCustomSeed);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateName_Public_String_String_Single_String_Single_String_Single_Boolean_Int32_Int32_byref_String_byref_String_byref_String_byref_Boolean_byref_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		prefixOutput = IL2CPP.Il2CppStringToManaged((IntPtr)num2);
		mainOutput = IL2CPP.Il2CppStringToManaged((IntPtr)num4);
		suffixOutput = IL2CPP.Il2CppStringToManaged((IntPtr)num6);
		alternateTags = IL2CPP.Il2CppStringToManaged((IntPtr)num8);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1783, RefRangeEnd = 1784, XrefRangeStart = 1783, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NameGenerator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameGenerator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NameGenerator(IntPtr pointer)
		: base(pointer)
	{
	}
}
