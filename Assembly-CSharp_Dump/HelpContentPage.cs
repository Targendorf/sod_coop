using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class HelpContentPage : SoCustomComparison
{
	[System.Serializable]
	public class HelpContentDisplay : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_helpDisplaySetting;

		private static readonly System.IntPtr NativeFieldInfoPtr_clip;

		private static readonly System.IntPtr NativeFieldInfoPtr_image;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe DisplaySetting helpDisplaySetting
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_helpDisplaySetting);
				return *(DisplaySetting*)num;
			}
			set
			{
				*(DisplaySetting*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_helpDisplaySetting)) = displaySetting;
			}
		}

		public unsafe VideoClip clip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clip);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VideoClip>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clip)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)videoClip));
			}
		}

		public unsafe Texture2D image
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_image);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_image)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
			}
		}

		static HelpContentDisplay()
		{
			Il2CppClassPointerStore<HelpContentDisplay>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HelpContentPage>.NativeClassPtr, "HelpContentDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpContentDisplay>.NativeClassPtr);
			NativeFieldInfoPtr_helpDisplaySetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpContentDisplay>.NativeClassPtr, "helpDisplaySetting");
			NativeFieldInfoPtr_clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpContentDisplay>.NativeClassPtr, "clip");
			NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpContentDisplay>.NativeClassPtr, "image");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpContentDisplay>.NativeClassPtr, 100673933);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HelpContentDisplay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpContentDisplay>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public HelpContentDisplay(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum DisplaySetting
	{
		dontDisplay,
		displayBeforeText,
		displayAfterText
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_disabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageID;

	private static readonly System.IntPtr NativeFieldInfoPtr_contentDisplay;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool disabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disabled)) = flag;
		}
	}

	public unsafe string messageID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageID)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<HelpContentDisplay> contentDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentDisplay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HelpContentDisplay>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contentDisplay)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static HelpContentPage()
	{
		Il2CppClassPointerStore<HelpContentPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HelpContentPage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpContentPage>.NativeClassPtr);
		NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpContentPage>.NativeClassPtr, "disabled");
		NativeFieldInfoPtr_messageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpContentPage>.NativeClassPtr, "messageID");
		NativeFieldInfoPtr_contentDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpContentPage>.NativeClassPtr, "contentDisplay");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpContentPage>.NativeClassPtr, 100673932);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328917, XrefRangeEnd = 328925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HelpContentPage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpContentPage>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public HelpContentPage(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
