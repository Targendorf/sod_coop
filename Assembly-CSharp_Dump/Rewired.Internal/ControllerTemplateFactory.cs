using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Rewired.Internal;

public static class ControllerTemplateFactory : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__defaultTemplateTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr__defaultTemplateInterfaceTypes;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_templateTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0;

	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> _defaultTemplateTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__defaultTemplateTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__defaultTemplateTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> _defaultTemplateInterfaceTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__defaultTemplateInterfaceTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__defaultTemplateInterfaceTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> templateTypes
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349549, XrefRangeEnd = 349553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_templateTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr) : null;
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> templateInterfaceTypes
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349553, XrefRangeEnd = 349557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr) : null;
		}
	}

	static ControllerTemplateFactory()
	{
		Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Internal", "ControllerTemplateFactory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr);
		NativeFieldInfoPtr__defaultTemplateTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, "_defaultTemplateTypes");
		NativeFieldInfoPtr__defaultTemplateInterfaceTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, "_defaultTemplateInterfaceTypes");
		NativeMethodInfoPtr_get_templateTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100675063);
		NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100675064);
		NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100675065);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 349571, RefRangeEnd = 349572, XrefRangeStart = 349557, XrefRangeEnd = 349571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IControllerTemplate Create(Il2CppSystem.Guid typeGuid, Il2CppSystem.Object payload)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&typeGuid);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)payload);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplate>(intPtr) : null;
	}

	public ControllerTemplateFactory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
