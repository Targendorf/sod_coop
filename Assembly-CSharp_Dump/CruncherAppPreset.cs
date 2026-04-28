using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class CruncherAppPreset : SoCustomComparison
{
	[System.Serializable]
	public class AppAccess : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rule;

		private static readonly System.IntPtr NativeFieldInfoPtr_traitList;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe CharacterTrait.RuleType rule
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rule);
				return *(CharacterTrait.RuleType*)num;
			}
			set
			{
				*(CharacterTrait.RuleType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rule)) = ruleType;
			}
		}

		public unsafe List<CharacterTrait> traitList
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitList);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CharacterTrait>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static AppAccess()
		{
			Il2CppClassPointerStore<AppAccess>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "AppAccess");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppAccess>.NativeClassPtr);
			NativeFieldInfoPtr_rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppAccess>.NativeClassPtr, "rule");
			NativeFieldInfoPtr_traitList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppAccess>.NativeClassPtr, "traitList");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppAccess>.NativeClassPtr, 100673867);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328043, XrefRangeEnd = 328049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppAccess()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppAccess>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AppAccess(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_loadBackground;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadedBackground;

	private static readonly System.IntPtr NativeFieldInfoPtr_useCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_useTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_timerLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadDemand;

	private static readonly System.IntPtr NativeFieldInfoPtr_alwaysLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_alwaysLoadDemand;

	private static readonly System.IntPtr NativeFieldInfoPtr_desktopIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenLightColourOnLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenLightColourOnFinishLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_alwaysInstalled;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfCorporateSabotageSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_companyOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr_salesRecordsOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfOwner;

	private static readonly System.IntPtr NativeFieldInfoPtr_installationConditions;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyInAddresses;

	private static readonly System.IntPtr NativeFieldInfoPtr_onlyIfResidential;

	private static readonly System.IntPtr NativeFieldInfoPtr_appContent;

	private static readonly System.IntPtr NativeFieldInfoPtr_onStartSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_onExitSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_onFinishedLoadingSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_openOnEnd;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Material loadBackground
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadBackground);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadBackground)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material loadedBackground
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedBackground);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedBackground)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe bool useCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCursor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useCursor)) = flag;
		}
	}

	public unsafe Sprite cursorSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe bool useTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTimer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useTimer)) = flag;
		}
	}

	public unsafe float timerLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timerLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timerLength)) = num;
		}
	}

	public unsafe float loadTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadTime)) = num;
		}
	}

	public unsafe float loadDemand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadDemand);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadDemand)) = num;
		}
	}

	public unsafe bool alwaysLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysLoad);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysLoad)) = flag;
		}
	}

	public unsafe float alwaysLoadDemand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysLoadDemand);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysLoadDemand)) = num;
		}
	}

	public unsafe Sprite desktopIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desktopIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_desktopIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Color screenLightColourOnLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenLightColourOnLoad);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenLightColourOnLoad)) = color;
		}
	}

	public unsafe Color screenLightColourOnFinishLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenLightColourOnFinishLoad);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenLightColourOnFinishLoad)) = color;
		}
	}

	public unsafe bool alwaysInstalled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysInstalled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alwaysInstalled)) = flag;
		}
	}

	public unsafe bool onlyIfCorporateSabotageSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfCorporateSabotageSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfCorporateSabotageSkill)) = flag;
		}
	}

	public unsafe bool companyOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companyOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companyOnly)) = flag;
		}
	}

	public unsafe bool salesRecordsOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_salesRecordsOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_salesRecordsOnly)) = flag;
		}
	}

	public unsafe bool onlyIfOwner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfOwner);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfOwner)) = flag;
		}
	}

	public unsafe List<AppAccess> installationConditions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_installationConditions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AppAccess>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_installationConditions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<AddressPreset> onlyInAddresses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInAddresses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AddressPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyInAddresses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool onlyIfResidential
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfResidential);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onlyIfResidential)) = flag;
		}
	}

	public unsafe List<GameObject> appContent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appContent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appContent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe AudioEvent onStartSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onStartSound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onStartSound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent onExitSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onExitSound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onExitSound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe AudioEvent onFinishedLoadingSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFinishedLoadingSound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onFinishedLoadingSound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioEvent));
		}
	}

	public unsafe CruncherAppPreset openOnEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openOnEnd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CruncherAppPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openOnEnd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cruncherAppPreset));
		}
	}

	static CruncherAppPreset()
	{
		Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CruncherAppPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr);
		NativeFieldInfoPtr_loadBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "loadBackground");
		NativeFieldInfoPtr_loadedBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "loadedBackground");
		NativeFieldInfoPtr_useCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "useCursor");
		NativeFieldInfoPtr_cursorSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "cursorSprite");
		NativeFieldInfoPtr_useTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "useTimer");
		NativeFieldInfoPtr_timerLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "timerLength");
		NativeFieldInfoPtr_loadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "loadTime");
		NativeFieldInfoPtr_loadDemand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "loadDemand");
		NativeFieldInfoPtr_alwaysLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "alwaysLoad");
		NativeFieldInfoPtr_alwaysLoadDemand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "alwaysLoadDemand");
		NativeFieldInfoPtr_desktopIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "desktopIcon");
		NativeFieldInfoPtr_screenLightColourOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "screenLightColourOnLoad");
		NativeFieldInfoPtr_screenLightColourOnFinishLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "screenLightColourOnFinishLoad");
		NativeFieldInfoPtr_alwaysInstalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "alwaysInstalled");
		NativeFieldInfoPtr_onlyIfCorporateSabotageSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "onlyIfCorporateSabotageSkill");
		NativeFieldInfoPtr_companyOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "companyOnly");
		NativeFieldInfoPtr_salesRecordsOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "salesRecordsOnly");
		NativeFieldInfoPtr_onlyIfOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "onlyIfOwner");
		NativeFieldInfoPtr_installationConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "installationConditions");
		NativeFieldInfoPtr_onlyInAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "onlyInAddresses");
		NativeFieldInfoPtr_onlyIfResidential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "onlyIfResidential");
		NativeFieldInfoPtr_appContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "appContent");
		NativeFieldInfoPtr_onStartSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "onStartSound");
		NativeFieldInfoPtr_onExitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "onExitSound");
		NativeFieldInfoPtr_onFinishedLoadingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "onFinishedLoadingSound");
		NativeFieldInfoPtr_openOnEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, "openOnEnd");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr, 100673866);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328049, XrefRangeEnd = 328069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CruncherAppPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CruncherAppPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CruncherAppPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
