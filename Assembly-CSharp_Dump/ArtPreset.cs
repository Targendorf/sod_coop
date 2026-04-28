using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArtPreset : SoCustomComparison
{
	public enum ArtOrientation
	{
		portrait,
		landscape,
		square,
		poster,
		litter,
		wallGrimeTop,
		wallGrimeBottom,
		dynamicClue,
		graffiti
	}

	[System.Serializable]
	public class ArtPreference : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_trait;

		private static readonly System.IntPtr NativeFieldInfoPtr_modifier;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe CharacterTrait trait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		public unsafe int modifier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifier);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modifier)) = num;
			}
		}

		static ArtPreference()
		{
			Il2CppClassPointerStore<ArtPreference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "ArtPreference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArtPreference>.NativeClassPtr);
			NativeFieldInfoPtr_trait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreference>.NativeClassPtr, "trait");
			NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreference>.NativeClassPtr, "modifier");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArtPreference>.NativeClassPtr, 100673788);
		}

		[CallerCount(0)]
		public unsafe ArtPreference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArtPreference>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ArtPreference(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum DynamicTextSouce
	{
		weaponsDealerPassword,
		blackMarketTraderPassword
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_disable;

	private static readonly System.IntPtr NativeFieldInfoPtr_texturePreview;

	private static readonly System.IntPtr NativeFieldInfoPtr_material;

	private static readonly System.IntPtr NativeFieldInfoPtr_orientationCompatibility;

	private static readonly System.IntPtr NativeFieldInfoPtr_pixelScaleMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowInResidential;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowInCommerical;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowInLobby;

	private static readonly System.IntPtr NativeFieldInfoPtr_allowOnStreet;

	private static readonly System.IntPtr NativeFieldInfoPtr_basePriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_colourMatching;

	private static readonly System.IntPtr NativeFieldInfoPtr_colourMatchingScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumWealth;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumWealth;

	private static readonly System.IntPtr NativeFieldInfoPtr_roomMatchingScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_modernity;

	private static readonly System.IntPtr NativeFieldInfoPtr_cleanness;

	private static readonly System.IntPtr NativeFieldInfoPtr_loudness;

	private static readonly System.IntPtr NativeFieldInfoPtr_emotive;

	private static readonly System.IntPtr NativeFieldInfoPtr_mustRequireTraitFromBelow;

	private static readonly System.IntPtr NativeFieldInfoPtr_traitModifiers;

	private static readonly System.IntPtr NativeFieldInfoPtr_useDynamicText;

	private static readonly System.IntPtr NativeFieldInfoPtr_dynamicTextSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_textFont;

	private static readonly System.IntPtr NativeFieldInfoPtr_textColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_textSize;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateColourMatching_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool disable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disable)) = flag;
		}
	}

	public unsafe Texture2D texturePreview
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texturePreview);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texturePreview)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Material material
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe List<ArtOrientation> orientationCompatibility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orientationCompatibility);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ArtOrientation>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orientationCompatibility)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe float pixelScaleMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelScaleMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pixelScaleMultiplier)) = num;
		}
	}

	public unsafe bool allowInResidential
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInResidential);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInResidential)) = flag;
		}
	}

	public unsafe bool allowInCommerical
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInCommerical);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInCommerical)) = flag;
		}
	}

	public unsafe bool allowInLobby
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInLobby);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowInLobby)) = flag;
		}
	}

	public unsafe bool allowOnStreet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowOnStreet);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowOnStreet)) = flag;
		}
	}

	public unsafe int basePriority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basePriority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basePriority)) = num;
		}
	}

	public unsafe List<Color> colourMatching
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourMatching);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Color>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourMatching)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int colourMatchingScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourMatchingScale);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colourMatchingScale)) = num;
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

	public unsafe float maximumWealth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumWealth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumWealth)) = num;
		}
	}

	public unsafe int roomMatchingScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomMatchingScale);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomMatchingScale)) = num;
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

	public unsafe int cleanness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cleanness);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cleanness)) = num;
		}
	}

	public unsafe int loudness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loudness);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loudness)) = num;
		}
	}

	public unsafe int emotive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotive);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emotive)) = num;
		}
	}

	public unsafe bool mustRequireTraitFromBelow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustRequireTraitFromBelow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mustRequireTraitFromBelow)) = flag;
		}
	}

	public unsafe List<ArtPreference> traitModifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ArtPreference>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traitModifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool useDynamicText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDynamicText);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useDynamicText)) = flag;
		}
	}

	public unsafe DynamicTextSouce dynamicTextSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicTextSource);
			return *(DynamicTextSouce*)num;
		}
		set
		{
			*(DynamicTextSouce*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamicTextSource)) = dynamicTextSouce;
		}
	}

	public unsafe TMP_FontAsset textFont
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textFont);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textFont)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tMP_FontAsset));
		}
	}

	public unsafe Color textColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textColour)) = color;
		}
	}

	public unsafe float textSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSize)) = num;
		}
	}

	static ArtPreset()
	{
		Il2CppClassPointerStore<ArtPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ArtPreset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr);
		NativeFieldInfoPtr_disable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "disable");
		NativeFieldInfoPtr_texturePreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "texturePreview");
		NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "material");
		NativeFieldInfoPtr_orientationCompatibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "orientationCompatibility");
		NativeFieldInfoPtr_pixelScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "pixelScaleMultiplier");
		NativeFieldInfoPtr_allowInResidential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "allowInResidential");
		NativeFieldInfoPtr_allowInCommerical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "allowInCommerical");
		NativeFieldInfoPtr_allowInLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "allowInLobby");
		NativeFieldInfoPtr_allowOnStreet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "allowOnStreet");
		NativeFieldInfoPtr_basePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "basePriority");
		NativeFieldInfoPtr_colourMatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "colourMatching");
		NativeFieldInfoPtr_colourMatchingScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "colourMatchingScale");
		NativeFieldInfoPtr_minimumWealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "minimumWealth");
		NativeFieldInfoPtr_maximumWealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "maximumWealth");
		NativeFieldInfoPtr_roomMatchingScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "roomMatchingScale");
		NativeFieldInfoPtr_modernity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "modernity");
		NativeFieldInfoPtr_cleanness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "cleanness");
		NativeFieldInfoPtr_loudness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "loudness");
		NativeFieldInfoPtr_emotive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "emotive");
		NativeFieldInfoPtr_mustRequireTraitFromBelow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "mustRequireTraitFromBelow");
		NativeFieldInfoPtr_traitModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "traitModifiers");
		NativeFieldInfoPtr_useDynamicText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "useDynamicText");
		NativeFieldInfoPtr_dynamicTextSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "dynamicTextSource");
		NativeFieldInfoPtr_textFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "textFont");
		NativeFieldInfoPtr_textColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "textColour");
		NativeFieldInfoPtr_textSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, "textSize");
		NativeMethodInfoPtr_GenerateColourMatching_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, 100673786);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr, 100673787);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateColourMatching()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateColourMatching_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326688, XrefRangeEnd = 326707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ArtPreset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArtPreset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ArtPreset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
