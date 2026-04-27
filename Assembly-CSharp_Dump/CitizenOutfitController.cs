using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

public class CitizenOutfitController : MonoBehaviour
{
	public enum CharacterAnchor
	{
		lowerTorso,
		upperTorso,
		Head,
		Hat,
		UpperArmRight,
		UpperArmLeft,
		LowerArmRight,
		LowerArmLeft,
		HandRight,
		HandLeft,
		UpperLegRight,
		UpperLegLeft,
		LowerLegRight,
		LowerLegLeft,
		Midriff,
		RightFoot,
		LeftFoot,
		Hair,
		Glasses,
		ArmsParent,
		beard
	}

	[System.Serializable]
	public class AnchorConfig : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_anchor;

		private static readonly System.IntPtr NativeFieldInfoPtr_trans;

		private static readonly System.IntPtr NativeFieldInfoPtr_outline;

		private static readonly System.IntPtr NativeFieldInfoPtr_captureInSurveillance;

		private static readonly System.IntPtr NativeFieldInfoPtr_weight;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe CharacterAnchor anchor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchor);
				return *(CharacterAnchor*)num;
			}
			set
			{
				*(CharacterAnchor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchor)) = characterAnchor;
			}
		}

		public unsafe Transform trans
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trans);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trans)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
			}
		}

		public unsafe bool outline
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outline);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outline)) = flag;
			}
		}

		public unsafe bool captureInSurveillance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureInSurveillance);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureInSurveillance)) = flag;
			}
		}

		public unsafe float weight
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weight);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weight)) = num;
			}
		}

		static AnchorConfig()
		{
			Il2CppClassPointerStore<AnchorConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "AnchorConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnchorConfig>.NativeClassPtr);
			NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorConfig>.NativeClassPtr, "anchor");
			NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorConfig>.NativeClassPtr, "trans");
			NativeFieldInfoPtr_outline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorConfig>.NativeClassPtr, "outline");
			NativeFieldInfoPtr_captureInSurveillance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorConfig>.NativeClassPtr, "captureInSurveillance");
			NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorConfig>.NativeClassPtr, "weight");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorConfig>.NativeClassPtr, 100667267);
		}

		[CallerCount(0)]
		public unsafe AnchorConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnchorConfig>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AnchorConfig(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class Outfit : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_category;

		private static readonly System.IntPtr NativeFieldInfoPtr_clothes;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ClothesPreset.OutfitCategory category
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category);
				return *(ClothesPreset.OutfitCategory*)num;
			}
			set
			{
				*(ClothesPreset.OutfitCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_category)) = outfitCategory;
			}
		}

		public unsafe List<OutfitClothes> clothes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OutfitClothes>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		static Outfit()
		{
			Il2CppClassPointerStore<Outfit>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "Outfit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Outfit>.NativeClassPtr);
			NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Outfit>.NativeClassPtr, "category");
			NativeFieldInfoPtr_clothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Outfit>.NativeClassPtr, "clothes");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outfit>.NativeClassPtr, 100667268);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 134465, RefRangeEnd = 134468, XrefRangeStart = 134459, XrefRangeEnd = 134465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Outfit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Outfit>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Outfit(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class OutfitClothes : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_clothes;

		private static readonly System.IntPtr NativeFieldInfoPtr_tags;

		private static readonly System.IntPtr NativeFieldInfoPtr_baseColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_color1;

		private static readonly System.IntPtr NativeFieldInfoPtr_color2;

		private static readonly System.IntPtr NativeFieldInfoPtr_color3;

		private static readonly System.IntPtr NativeFieldInfoPtr_borrowed;

		private static readonly System.IntPtr NativeFieldInfoPtr_spawned;

		private static readonly System.IntPtr NativeFieldInfoPtr_rank;

		private static readonly System.IntPtr NativeFieldInfoPtr_incomplete;

		private static readonly System.IntPtr NativeFieldInfoPtr_loadedThisCycle;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string clothes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothes);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothes)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe List<ClothesPreset.ClothesTags> tags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ClothesPreset.ClothesTags>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tags)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe Color baseColor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseColor);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseColor)) = color;
			}
		}

		public unsafe Color color1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color1);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color1)) = color;
			}
		}

		public unsafe Color color2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color2);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color2)) = color;
			}
		}

		public unsafe Color color3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color3);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color3)) = color;
			}
		}

		public unsafe bool borrowed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_borrowed);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_borrowed)) = flag;
			}
		}

		public unsafe Dictionary<CharacterAnchor, List<MeshRenderer>> spawned
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawned);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterAnchor, List<MeshRenderer>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawned)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe int rank
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rank);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rank)) = num;
			}
		}

		public unsafe bool incomplete
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incomplete);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incomplete)) = flag;
			}
		}

		public unsafe bool loadedThisCycle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedThisCycle);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedThisCycle)) = flag;
			}
		}

		static OutfitClothes()
		{
			Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "OutfitClothes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr);
			NativeFieldInfoPtr_clothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr, "clothes");
			NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr, "tags");
			NativeFieldInfoPtr_baseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr, "baseColor");
			NativeFieldInfoPtr_color1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr, "color1");
			NativeFieldInfoPtr_color2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr, "color2");
			NativeFieldInfoPtr_color3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr, "color3");
			NativeFieldInfoPtr_borrowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr, "borrowed");
			NativeFieldInfoPtr_spawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr, "spawned");
			NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr, "rank");
			NativeFieldInfoPtr_incomplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr, "incomplete");
			NativeFieldInfoPtr_loadedThisCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr, "loadedThisCycle");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr, 100667269);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 134479, RefRangeEnd = 134483, XrefRangeStart = 134468, XrefRangeEnd = 134479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutfitClothes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutfitClothes>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public OutfitClothes(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class BackupCovering : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_outfit;

		private static readonly System.IntPtr NativeFieldInfoPtr_preset;

		public unsafe Outfit outfit
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfit);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Outfit>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outfit));
			}
		}

		public unsafe ClothesPreset preset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ClothesPreset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_preset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clothesPreset));
			}
		}

		static BackupCovering()
		{
			Il2CppClassPointerStore<BackupCovering>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "BackupCovering");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackupCovering>.NativeClassPtr);
			NativeFieldInfoPtr_outfit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackupCovering>.NativeClassPtr, "outfit");
			NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackupCovering>.NativeClassPtr, "preset");
		}

		public BackupCovering(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public BackupCovering()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackupCovering>.NativeClassPtr))
		{
		}
	}

	public class NewClothingCreation : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_newPrefab;

		private static readonly System.IntPtr NativeFieldInfoPtr_offset;

		private static readonly System.IntPtr NativeFieldInfoPtr_euler;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe GameObject newPrefab
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newPrefab);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
			}
		}

		public unsafe Vector3 offset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = vector;
			}
		}

		public unsafe Vector3 euler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_euler);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_euler)) = vector;
			}
		}

		static NewClothingCreation()
		{
			Il2CppClassPointerStore<NewClothingCreation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "NewClothingCreation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewClothingCreation>.NativeClassPtr);
			NativeFieldInfoPtr_newPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewClothingCreation>.NativeClassPtr, "newPrefab");
			NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewClothingCreation>.NativeClassPtr, "offset");
			NativeFieldInfoPtr_euler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewClothingCreation>.NativeClassPtr, "euler");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewClothingCreation>.NativeClassPtr, 100667270);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewClothingCreation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewClothingCreation>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public NewClothingCreation(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum ClothingCreatorDirectory
	{
		Tops,
		Bottoms,
		Hats,
		Heads,
		Shoes,
		Underwear,
		Undressed
	}

	public enum Expression
	{
		neutral,
		angry,
		sad,
		surprised,
		happy,
		asleep
	}

	[System.Serializable]
	public class ExpressionSetup : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_expression;

		private static readonly System.IntPtr NativeFieldInfoPtr_eyebrowsEuler;

		private static readonly System.IntPtr NativeFieldInfoPtr_eyebrowsRaise;

		private static readonly System.IntPtr NativeFieldInfoPtr_eyeHeightMultiplier;

		private static readonly System.IntPtr NativeFieldInfoPtr_allowBlinking;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Expression expression
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expression);
				return *(Expression*)num;
			}
			set
			{
				*(Expression*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expression)) = expression;
			}
		}

		public unsafe Vector3 eyebrowsEuler
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyebrowsEuler);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyebrowsEuler)) = vector;
			}
		}

		public unsafe float eyebrowsRaise
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyebrowsRaise);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyebrowsRaise)) = num;
			}
		}

		public unsafe float eyeHeightMultiplier
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyeHeightMultiplier);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyeHeightMultiplier)) = num;
			}
		}

		public unsafe bool allowBlinking
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowBlinking);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowBlinking)) = flag;
			}
		}

		static ExpressionSetup()
		{
			Il2CppClassPointerStore<ExpressionSetup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "ExpressionSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionSetup>.NativeClassPtr);
			NativeFieldInfoPtr_expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionSetup>.NativeClassPtr, "expression");
			NativeFieldInfoPtr_eyebrowsEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionSetup>.NativeClassPtr, "eyebrowsEuler");
			NativeFieldInfoPtr_eyebrowsRaise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionSetup>.NativeClassPtr, "eyebrowsRaise");
			NativeFieldInfoPtr_eyeHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionSetup>.NativeClassPtr, "eyeHeightMultiplier");
			NativeFieldInfoPtr_allowBlinking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionSetup>.NativeClassPtr, "allowBlinking");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionSetup>.NativeClassPtr, 100667271);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpressionSetup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionSetup>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ExpressionSetup(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CitizenOutfitController+<>c__DisplayClass67_0")]
	public sealed class __c__DisplayClass67_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_req;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateOutfits_b__1_Internal_Boolean_ClothesPreset_0;

		public unsafe CharacterAnchor req
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_req);
				return *(CharacterAnchor*)num;
			}
			set
			{
				*(CharacterAnchor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_req)) = characterAnchor;
			}
		}

		static __c__DisplayClass67_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "<>c__DisplayClass67_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr);
			NativeFieldInfoPtr_req = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, "req");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, 100667272);
			NativeMethodInfoPtr__GenerateOutfits_b__1_Internal_Boolean_ClothesPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr, 100667273);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass67_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass67_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134483, XrefRangeEnd = 134485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GenerateOutfits_b__1(ClothesPreset item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateOutfits_b__1_Internal_Boolean_ClothesPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass67_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CitizenOutfitController+<>c__DisplayClass67_1")]
	public sealed class __c__DisplayClass67_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_inc;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__4;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateOutfits_b__2_Internal_Boolean_OutfitClothes_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateOutfits_b__4_Internal_Boolean_OutfitClothes_0;

		public unsafe ClothesPreset.IncompatibilitySetting inc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inc);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ClothesPreset.IncompatibilitySetting>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inc)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)incompatibilitySetting));
			}
		}

		public unsafe Il2CppSystem.Predicate<OutfitClothes> __9__4
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__4);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<OutfitClothes>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___9__4)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c__DisplayClass67_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass67_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "<>c__DisplayClass67_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass67_1>.NativeClassPtr);
			NativeFieldInfoPtr_inc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_1>.NativeClassPtr, "inc");
			NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_1>.NativeClassPtr, "<>9__4");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_1>.NativeClassPtr, 100667274);
			NativeMethodInfoPtr__GenerateOutfits_b__2_Internal_Boolean_OutfitClothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_1>.NativeClassPtr, 100667275);
			NativeMethodInfoPtr__GenerateOutfits_b__4_Internal_Boolean_OutfitClothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_1>.NativeClassPtr, 100667276);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass67_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass67_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134485, XrefRangeEnd = 134487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GenerateOutfits_b__2(OutfitClothes item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateOutfits_b__2_Internal_Boolean_OutfitClothes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GenerateOutfits_b__4(OutfitClothes item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateOutfits_b__4_Internal_Boolean_OutfitClothes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass67_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CitizenOutfitController+<>c__DisplayClass67_2")]
	public sealed class __c__DisplayClass67_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_t;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateOutfits_b__3_Internal_Boolean_OutfitClothes_0;

		public unsafe ClothesPreset.ClothesTags t
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t);
				return *(ClothesPreset.ClothesTags*)num;
			}
			set
			{
				*(ClothesPreset.ClothesTags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t)) = clothesTags;
			}
		}

		static __c__DisplayClass67_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass67_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "<>c__DisplayClass67_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass67_2>.NativeClassPtr);
			NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_2>.NativeClassPtr, "t");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_2>.NativeClassPtr, 100667277);
			NativeMethodInfoPtr__GenerateOutfits_b__3_Internal_Boolean_OutfitClothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_2>.NativeClassPtr, 100667278);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass67_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass67_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134487, XrefRangeEnd = 134489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GenerateOutfits_b__3(OutfitClothes item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateOutfits_b__3_Internal_Boolean_OutfitClothes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass67_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CitizenOutfitController+<>c__DisplayClass67_3")]
	public sealed class __c__DisplayClass67_3 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_t;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateOutfits_b__5_Internal_Boolean_OutfitClothes_0;

		public unsafe ClothesPreset.ClothesTags t
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t);
				return *(ClothesPreset.ClothesTags*)num;
			}
			set
			{
				*(ClothesPreset.ClothesTags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t)) = clothesTags;
			}
		}

		static __c__DisplayClass67_3()
		{
			Il2CppClassPointerStore<__c__DisplayClass67_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "<>c__DisplayClass67_3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass67_3>.NativeClassPtr);
			NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_3>.NativeClassPtr, "t");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_3>.NativeClassPtr, 100667279);
			NativeMethodInfoPtr__GenerateOutfits_b__5_Internal_Boolean_OutfitClothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_3>.NativeClassPtr, 100667280);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass67_3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass67_3>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134489, XrefRangeEnd = 134491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GenerateOutfits_b__5(OutfitClothes item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateOutfits_b__5_Internal_Boolean_OutfitClothes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass67_3(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CitizenOutfitController+<>c__DisplayClass67_4")]
	public sealed class __c__DisplayClass67_4 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pair;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateOutfits_b__6_Internal_Boolean_Outfit_0;

		public unsafe KeyValuePair<ClothesPreset.OutfitCategory, List<CharacterAnchor>> pair
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pair);
				return new KeyValuePair<ClothesPreset.OutfitCategory, List<CharacterAnchor>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<ClothesPreset.OutfitCategory, List<CharacterAnchor>>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pair), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keyValuePair)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<ClothesPreset.OutfitCategory, List<CharacterAnchor>>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static __c__DisplayClass67_4()
		{
			Il2CppClassPointerStore<__c__DisplayClass67_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "<>c__DisplayClass67_4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass67_4>.NativeClassPtr);
			NativeFieldInfoPtr_pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_4>.NativeClassPtr, "pair");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_4>.NativeClassPtr, 100667281);
			NativeMethodInfoPtr__GenerateOutfits_b__6_Internal_Boolean_Outfit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_4>.NativeClassPtr, 100667282);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass67_4()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass67_4>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134491, XrefRangeEnd = 134492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GenerateOutfits_b__6(Outfit item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateOutfits_b__6_Internal_Boolean_Outfit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass67_4(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CitizenOutfitController+<>c__DisplayClass67_5")]
	public sealed class __c__DisplayClass67_5 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_backupCat;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateOutfits_b__7_Internal_Boolean_Outfit_0;

		public unsafe ClothesPreset.OutfitCategory backupCat
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupCat);
				return *(ClothesPreset.OutfitCategory*)num;
			}
			set
			{
				*(ClothesPreset.OutfitCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_backupCat)) = outfitCategory;
			}
		}

		static __c__DisplayClass67_5()
		{
			Il2CppClassPointerStore<__c__DisplayClass67_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "<>c__DisplayClass67_5");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass67_5>.NativeClassPtr);
			NativeFieldInfoPtr_backupCat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass67_5>.NativeClassPtr, "backupCat");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_5>.NativeClassPtr, 100667283);
			NativeMethodInfoPtr__GenerateOutfits_b__7_Internal_Boolean_Outfit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass67_5>.NativeClassPtr, 100667284);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass67_5()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass67_5>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GenerateOutfits_b__7(Outfit item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateOutfits_b__7_Internal_Boolean_Outfit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass67_5(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("CitizenOutfitController+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__67_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__67_8;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__78_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateOutfits_b__67_0_Internal_Int32_OutfitClothes_OutfitClothes_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GenerateOutfits_b__67_8_Internal_Int32_OutfitClothes_OutfitClothes_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveCurrentOutfit_b__78_0_Internal_Boolean_MeshRenderer_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Comparison<OutfitClothes> __9__67_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__67_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<OutfitClothes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__67_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<OutfitClothes> __9__67_8
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__67_8, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<OutfitClothes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__67_8, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Predicate<MeshRenderer> __9__78_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__78_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__78_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__67_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__67_0");
			NativeFieldInfoPtr___9__67_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__67_8");
			NativeFieldInfoPtr___9__78_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__78_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667286);
			NativeMethodInfoPtr__GenerateOutfits_b__67_0_Internal_Int32_OutfitClothes_OutfitClothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667287);
			NativeMethodInfoPtr__GenerateOutfits_b__67_8_Internal_Int32_OutfitClothes_OutfitClothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667288);
			NativeMethodInfoPtr__RemoveCurrentOutfit_b__78_0_Internal_Boolean_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667289);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe int _GenerateOutfits_b__67_0(OutfitClothes p2, OutfitClothes p1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateOutfits_b__67_0_Internal_Int32_OutfitClothes_OutfitClothes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		public unsafe int _GenerateOutfits_b__67_8(OutfitClothes p2, OutfitClothes p1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p2);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p1);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GenerateOutfits_b__67_8_Internal_Int32_OutfitClothes_OutfitClothes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134492, XrefRangeEnd = 134500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RemoveCurrentOutfit_b__78_0(MeshRenderer item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveCurrentOutfit_b__78_0_Internal_Boolean_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CitizenOutfitController+<>c__DisplayClass71_0")]
	public sealed class __c__DisplayClass71_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_req;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__LoadCurrentOutfit_b__1_Internal_Boolean_OutfitClothes_0;

		public unsafe OutfitClothes req
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_req);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OutfitClothes>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_req)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outfitClothes));
			}
		}

		static __c__DisplayClass71_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass71_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "<>c__DisplayClass71_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass71_0>.NativeClassPtr);
			NativeFieldInfoPtr_req = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass71_0>.NativeClassPtr, "req");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass71_0>.NativeClassPtr, 100667290);
			NativeMethodInfoPtr__LoadCurrentOutfit_b__1_Internal_Boolean_OutfitClothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass71_0>.NativeClassPtr, 100667291);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass71_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass71_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134500, XrefRangeEnd = 134501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _LoadCurrentOutfit_b__1(OutfitClothes item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LoadCurrentOutfit_b__1_Internal_Boolean_OutfitClothes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass71_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CitizenOutfitController+<>c__DisplayClass88_0")]
	public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_lookInCategory;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetColourFromUnderneath_b__0_Internal_Boolean_Outfit_0;

		public unsafe ClothesPreset.OutfitCategory lookInCategory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookInCategory);
				return *(ClothesPreset.OutfitCategory*)num;
			}
			set
			{
				*(ClothesPreset.OutfitCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookInCategory)) = outfitCategory;
			}
		}

		static __c__DisplayClass88_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "<>c__DisplayClass88_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr);
			NativeFieldInfoPtr_lookInCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr, "lookInCategory");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr, 100667292);
			NativeMethodInfoPtr__GetColourFromUnderneath_b__0_Internal_Boolean_Outfit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr, 100667293);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass88_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass88_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetColourFromUnderneath_b__0(Outfit item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetColourFromUnderneath_b__0_Internal_Boolean_Outfit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass88_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CitizenOutfitController+<>c__DisplayClass89_0")]
	public sealed class __c__DisplayClass89_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetChance_b__0_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass89_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "<>c__DisplayClass89_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr, 100667294);
			NativeMethodInfoPtr__GetChance_b__0_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr, 100667295);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass89_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass89_0>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetChance_b__0(Human.Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetChance_b__0_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass89_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CitizenOutfitController+<>c__DisplayClass89_1")]
	public sealed class __c__DisplayClass89_1 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetChance_b__1_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass89_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass89_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "<>c__DisplayClass89_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass89_1>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass89_1>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass89_1>.NativeClassPtr, 100667296);
			NativeMethodInfoPtr__GetChance_b__1_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass89_1>.NativeClassPtr, 100667297);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass89_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass89_1>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetChance_b__1(Human.Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetChance_b__1_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass89_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CitizenOutfitController+<>c__DisplayClass89_2")]
	public sealed class __c__DisplayClass89_2 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetChance_b__2_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass89_2()
		{
			Il2CppClassPointerStore<__c__DisplayClass89_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "<>c__DisplayClass89_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass89_2>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass89_2>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass89_2>.NativeClassPtr, 100667298);
			NativeMethodInfoPtr__GetChance_b__2_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass89_2>.NativeClassPtr, 100667299);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass89_2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass89_2>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetChance_b__2(Human.Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetChance_b__2_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass89_2(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("CitizenOutfitController+<>c__DisplayClass89_3")]
	public sealed class __c__DisplayClass89_3 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTrait;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetChance_b__3_Internal_Boolean_Trait_0;

		public unsafe CharacterTrait searchTrait
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterTrait>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_searchTrait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)characterTrait));
			}
		}

		static __c__DisplayClass89_3()
		{
			Il2CppClassPointerStore<__c__DisplayClass89_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "<>c__DisplayClass89_3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass89_3>.NativeClassPtr);
			NativeFieldInfoPtr_searchTrait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass89_3>.NativeClassPtr, "searchTrait");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass89_3>.NativeClassPtr, 100667300);
			NativeMethodInfoPtr__GetChance_b__3_Internal_Boolean_Trait_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass89_3>.NativeClassPtr, 100667301);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass89_3()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass89_3>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _GetChance_b__3(Human.Trait item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetChance_b__3_Internal_Boolean_Trait_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c__DisplayClass89_3(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_SafeDestroyGameObject_Public_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SafeDestroyGameObject_Public_T_T_0, Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SafeDestroy_Public_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SafeDestroy_Public_T_T_0, Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_human;

	private static readonly System.IntPtr NativeFieldInfoPtr_lod;

	private static readonly System.IntPtr NativeFieldInfoPtr_distantLOD;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPoser;

	private static readonly System.IntPtr NativeFieldInfoPtr_poser;

	private static readonly System.IntPtr NativeFieldInfoPtr_anchorConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_anchorReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_pupilParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftPupil;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightPupil;

	private static readonly System.IntPtr NativeFieldInfoPtr_eyebrowParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightEyebrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftEyebrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouth;

	private static readonly System.IntPtr NativeFieldInfoPtr_eyeRenderers;

	private static readonly System.IntPtr NativeFieldInfoPtr_eyebrowRenderers;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouthRenderer;

	private static readonly System.IntPtr NativeFieldInfoPtr_pupilParentOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_expressions;

	private static readonly System.IntPtr NativeFieldInfoPtr_expressionReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_bluePupil;

	private static readonly System.IntPtr NativeFieldInfoPtr_greenPupil;

	private static readonly System.IntPtr NativeFieldInfoPtr_brownPupil;

	private static readonly System.IntPtr NativeFieldInfoPtr_greyPupil;

	private static readonly System.IntPtr NativeFieldInfoPtr_eyebrowMat;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadedOutfit;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentOutfit;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousOutfit;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentlyLoadedClothes;

	private static readonly System.IntPtr NativeFieldInfoPtr_allCurrentMeshes;

	private static readonly System.IntPtr NativeFieldInfoPtr_allCurrentMeshFilters;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentHair;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentHairRend;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentHat;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentHatRend;

	private static readonly System.IntPtr NativeFieldInfoPtr_outfits;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugRenderers;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugOverrideJob;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugOverrideGender;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugOverrideBuild;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugOverrideHair;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugOverrideEyeColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugOverrideShoeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugOverrideLipstick;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugOverrideSkinColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugOverrideHairColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugOverrideExpression;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugOverrideGrub;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableDebugLog;

	private static readonly System.IntPtr NativeFieldInfoPtr_outfitDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_outfitToLoad;

	private static readonly System.IntPtr NativeFieldInfoPtr_newClothingName;

	private static readonly System.IntPtr NativeFieldInfoPtr_directory;

	private static readonly System.IntPtr NativeFieldInfoPtr_newClothingComponents;

	private static readonly System.IntPtr NativeFieldInfoPtr_CreateFlippedArmsAndLegsFromRightSide;

	private static readonly System.IntPtr NativeFieldInfoPtr_coveredAnchors;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateOutfits_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBodyAnchor_Public_Transform_CharacterAnchor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeClothed_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentOutfit_Public_Void_OutfitCategory_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadCurrentOutfit_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpawnClothingElement_Private_Void_OutfitClothes_ClothesPreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMeshRenderer_Private_Void_MeshRenderer_byref_Material_Boolean_byref_OutfitClothes_ModelSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSpecificModel_Private_Void_OutfitClothes_CharacterAnchor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HairHatCompatibilityCheck_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveClothingComponent_Private_Void_OutfitClothes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDebugRenderers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCurrentOutfit_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSpecificOutfit_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectRandomOutfits_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CycleOutfits_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAllOutfits_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewClothingPreset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadExpression_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SafeDestroyGameObject_Public_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SafeDestroy_Public_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PickColourFromPalette_Private_Color_byref_List_1_ColourPalettePreset_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColourFromUnderneath_Private_Color_ClothesPreset_OutfitCategory_ClothingColourSource_byref_Dictionary_2_String_ClothesPreset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChance_Public_Boolean_Human_byref_List_1_TraitPickRule_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__LoadCurrentOutfit_b__71_0_Private_Boolean_Outfit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__LoadExpression_b__84_0_Private_Boolean_ExpressionSetup_0;

	public unsafe Human human
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Human>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human));
		}
	}

	public unsafe LODGroup lod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lod);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LODGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lod)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lODGroup));
		}
	}

	public unsafe MeshRenderer distantLOD
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distantLOD);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distantLOD)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer));
		}
	}

	public unsafe bool isPoser
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPoser);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPoser)) = flag;
		}
	}

	public unsafe ScenePoserController poser
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poser);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScenePoserController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poser)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scenePoserController));
		}
	}

	public unsafe List<AnchorConfig> anchorConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorConfig);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AnchorConfig>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<CharacterAnchor, Transform> anchorReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterAnchor, Transform>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anchorReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Transform pupilParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pupilParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pupilParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform leftPupil
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftPupil);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftPupil)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform rightPupil
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightPupil);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightPupil)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform eyebrowParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyebrowParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyebrowParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform rightEyebrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightEyebrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightEyebrow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform leftEyebrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftEyebrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftEyebrow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Transform mouth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouth);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouth)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe List<MeshRenderer> eyeRenderers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyeRenderers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyeRenderers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MeshRenderer> eyebrowRenderers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyebrowRenderers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyebrowRenderers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe MeshRenderer mouthRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouthRenderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouthRenderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer));
		}
	}

	public unsafe Vector3 pupilParentOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pupilParentOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pupilParentOffset)) = vector;
		}
	}

	public unsafe List<ExpressionSetup> expressions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expressions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ExpressionSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expressions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<Expression, ExpressionSetup> expressionReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expressionReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Expression, ExpressionSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expressionReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Material bluePupil
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bluePupil);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bluePupil)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material greenPupil
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenPupil);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greenPupil)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material brownPupil
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brownPupil);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_brownPupil)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material greyPupil
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greyPupil);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_greyPupil)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material eyebrowMat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyebrowMat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyebrowMat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe ClothesPreset.OutfitCategory loadedOutfit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedOutfit);
			return *(ClothesPreset.OutfitCategory*)num;
		}
		set
		{
			*(ClothesPreset.OutfitCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadedOutfit)) = outfitCategory;
		}
	}

	public unsafe ClothesPreset.OutfitCategory currentOutfit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentOutfit);
			return *(ClothesPreset.OutfitCategory*)num;
		}
		set
		{
			*(ClothesPreset.OutfitCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentOutfit)) = outfitCategory;
		}
	}

	public unsafe ClothesPreset.OutfitCategory previousOutfit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousOutfit);
			return *(ClothesPreset.OutfitCategory*)num;
		}
		set
		{
			*(ClothesPreset.OutfitCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousOutfit)) = outfitCategory;
		}
	}

	public unsafe List<OutfitClothes> currentlyLoadedClothes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentlyLoadedClothes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OutfitClothes>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentlyLoadedClothes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MeshRenderer> allCurrentMeshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allCurrentMeshes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allCurrentMeshes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MeshFilter> allCurrentMeshFilters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allCurrentMeshFilters);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeshFilter>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allCurrentMeshFilters)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe ClothesPreset currentHair
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentHair);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ClothesPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentHair)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clothesPreset));
		}
	}

	public unsafe MeshRenderer currentHairRend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentHairRend);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentHairRend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer));
		}
	}

	public unsafe ClothesPreset currentHat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentHat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ClothesPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentHat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clothesPreset));
		}
	}

	public unsafe MeshRenderer currentHatRend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentHatRend);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentHatRend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshRenderer));
		}
	}

	public unsafe List<Outfit> outfits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfits);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Outfit>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfits)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<MeshRenderer> debugRenderers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRenderers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRenderers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool debugOverride
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverride);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverride)) = flag;
		}
	}

	public unsafe OccupationPreset debugOverrideJob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideJob);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OccupationPreset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideJob)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)occupationPreset));
		}
	}

	public unsafe Human.Gender debugOverrideGender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideGender);
			return *(Human.Gender*)num;
		}
		set
		{
			*(Human.Gender*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideGender)) = gender;
		}
	}

	public unsafe Descriptors.BuildType debugOverrideBuild
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideBuild);
			return *(Descriptors.BuildType*)num;
		}
		set
		{
			*(Descriptors.BuildType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideBuild)) = buildType;
		}
	}

	public unsafe Descriptors.HairStyle debugOverrideHair
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideHair);
			return *(Descriptors.HairStyle*)num;
		}
		set
		{
			*(Descriptors.HairStyle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideHair)) = hairStyle;
		}
	}

	public unsafe Descriptors.EyeColour debugOverrideEyeColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideEyeColour);
			return *(Descriptors.EyeColour*)num;
		}
		set
		{
			*(Descriptors.EyeColour*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideEyeColour)) = eyeColour;
		}
	}

	public unsafe Human.ShoeType debugOverrideShoeType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideShoeType);
			return *(Human.ShoeType*)num;
		}
		set
		{
			*(Human.ShoeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideShoeType)) = shoeType;
		}
	}

	public unsafe float debugOverrideLipstick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideLipstick);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideLipstick)) = num;
		}
	}

	public unsafe Color debugOverrideSkinColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideSkinColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideSkinColour)) = color;
		}
	}

	public unsafe Color debugOverrideHairColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideHairColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideHairColour)) = color;
		}
	}

	public unsafe Expression debugOverrideExpression
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideExpression);
			return *(Expression*)num;
		}
		set
		{
			*(Expression*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideExpression)) = expression;
		}
	}

	public unsafe float debugOverrideGrub
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideGrub);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugOverrideGrub)) = num;
		}
	}

	public unsafe bool enableDebugLog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDebugLog);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableDebugLog)) = flag;
		}
	}

	public unsafe List<string> outfitDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfitDebug);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfitDebug)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ClothesPreset> outfitToLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfitToLoad);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ClothesPreset>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outfitToLoad)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe string newClothingName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newClothingName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newClothingName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe ClothingCreatorDirectory directory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directory);
			return *(ClothingCreatorDirectory*)num;
		}
		set
		{
			*(ClothingCreatorDirectory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directory)) = clothingCreatorDirectory;
		}
	}

	public unsafe List<GameObject> newClothingComponents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newClothingComponents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newClothingComponents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe bool CreateFlippedArmsAndLegsFromRightSide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateFlippedArmsAndLegsFromRightSide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CreateFlippedArmsAndLegsFromRightSide)) = flag;
		}
	}

	public unsafe Dictionary<CharacterAnchor, int> coveredAnchors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coveredAnchors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CharacterAnchor, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coveredAnchors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static CitizenOutfitController()
	{
		Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CitizenOutfitController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr);
		NativeFieldInfoPtr_human = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "human");
		NativeFieldInfoPtr_lod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "lod");
		NativeFieldInfoPtr_distantLOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "distantLOD");
		NativeFieldInfoPtr_isPoser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "isPoser");
		NativeFieldInfoPtr_poser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "poser");
		NativeFieldInfoPtr_anchorConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "anchorConfig");
		NativeFieldInfoPtr_anchorReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "anchorReference");
		NativeFieldInfoPtr_pupilParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "pupilParent");
		NativeFieldInfoPtr_leftPupil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "leftPupil");
		NativeFieldInfoPtr_rightPupil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "rightPupil");
		NativeFieldInfoPtr_eyebrowParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "eyebrowParent");
		NativeFieldInfoPtr_rightEyebrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "rightEyebrow");
		NativeFieldInfoPtr_leftEyebrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "leftEyebrow");
		NativeFieldInfoPtr_mouth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "mouth");
		NativeFieldInfoPtr_eyeRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "eyeRenderers");
		NativeFieldInfoPtr_eyebrowRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "eyebrowRenderers");
		NativeFieldInfoPtr_mouthRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "mouthRenderer");
		NativeFieldInfoPtr_pupilParentOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "pupilParentOffset");
		NativeFieldInfoPtr_expressions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "expressions");
		NativeFieldInfoPtr_expressionReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "expressionReference");
		NativeFieldInfoPtr_bluePupil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "bluePupil");
		NativeFieldInfoPtr_greenPupil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "greenPupil");
		NativeFieldInfoPtr_brownPupil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "brownPupil");
		NativeFieldInfoPtr_greyPupil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "greyPupil");
		NativeFieldInfoPtr_eyebrowMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "eyebrowMat");
		NativeFieldInfoPtr_loadedOutfit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "loadedOutfit");
		NativeFieldInfoPtr_currentOutfit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "currentOutfit");
		NativeFieldInfoPtr_previousOutfit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "previousOutfit");
		NativeFieldInfoPtr_currentlyLoadedClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "currentlyLoadedClothes");
		NativeFieldInfoPtr_allCurrentMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "allCurrentMeshes");
		NativeFieldInfoPtr_allCurrentMeshFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "allCurrentMeshFilters");
		NativeFieldInfoPtr_currentHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "currentHair");
		NativeFieldInfoPtr_currentHairRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "currentHairRend");
		NativeFieldInfoPtr_currentHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "currentHat");
		NativeFieldInfoPtr_currentHatRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "currentHatRend");
		NativeFieldInfoPtr_outfits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "outfits");
		NativeFieldInfoPtr_debugRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "debugRenderers");
		NativeFieldInfoPtr_debugOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "debugOverride");
		NativeFieldInfoPtr_debugOverrideJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "debugOverrideJob");
		NativeFieldInfoPtr_debugOverrideGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "debugOverrideGender");
		NativeFieldInfoPtr_debugOverrideBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "debugOverrideBuild");
		NativeFieldInfoPtr_debugOverrideHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "debugOverrideHair");
		NativeFieldInfoPtr_debugOverrideEyeColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "debugOverrideEyeColour");
		NativeFieldInfoPtr_debugOverrideShoeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "debugOverrideShoeType");
		NativeFieldInfoPtr_debugOverrideLipstick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "debugOverrideLipstick");
		NativeFieldInfoPtr_debugOverrideSkinColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "debugOverrideSkinColour");
		NativeFieldInfoPtr_debugOverrideHairColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "debugOverrideHairColour");
		NativeFieldInfoPtr_debugOverrideExpression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "debugOverrideExpression");
		NativeFieldInfoPtr_debugOverrideGrub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "debugOverrideGrub");
		NativeFieldInfoPtr_enableDebugLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "enableDebugLog");
		NativeFieldInfoPtr_outfitDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "outfitDebug");
		NativeFieldInfoPtr_outfitToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "outfitToLoad");
		NativeFieldInfoPtr_newClothingName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "newClothingName");
		NativeFieldInfoPtr_directory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "directory");
		NativeFieldInfoPtr_newClothingComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "newClothingComponents");
		NativeFieldInfoPtr_CreateFlippedArmsAndLegsFromRightSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "CreateFlippedArmsAndLegsFromRightSide");
		NativeFieldInfoPtr_coveredAnchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, "coveredAnchors");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667239);
		NativeMethodInfoPtr_GenerateOutfits_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667240);
		NativeMethodInfoPtr_GetBodyAnchor_Public_Transform_CharacterAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667241);
		NativeMethodInfoPtr_MakeClothed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667242);
		NativeMethodInfoPtr_SetCurrentOutfit_Public_Void_OutfitCategory_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667243);
		NativeMethodInfoPtr_LoadCurrentOutfit_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667244);
		NativeMethodInfoPtr_SpawnClothingElement_Private_Void_OutfitClothes_ClothesPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667245);
		NativeMethodInfoPtr_AddMeshRenderer_Private_Void_MeshRenderer_byref_Material_Boolean_byref_OutfitClothes_ModelSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667246);
		NativeMethodInfoPtr_RemoveSpecificModel_Private_Void_OutfitClothes_CharacterAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667247);
		NativeMethodInfoPtr_HairHatCompatibilityCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667248);
		NativeMethodInfoPtr_RemoveClothingComponent_Private_Void_OutfitClothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667249);
		NativeMethodInfoPtr_RemoveDebugRenderers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667250);
		NativeMethodInfoPtr_RemoveCurrentOutfit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667251);
		NativeMethodInfoPtr_LoadSpecificOutfit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667252);
		NativeMethodInfoPtr_SelectRandomOutfits_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667253);
		NativeMethodInfoPtr_CycleOutfits_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667254);
		NativeMethodInfoPtr_ResetAllOutfits_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667255);
		NativeMethodInfoPtr_CreateNewClothingPreset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667256);
		NativeMethodInfoPtr_LoadExpression_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667257);
		NativeMethodInfoPtr_SafeDestroyGameObject_Public_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667258);
		NativeMethodInfoPtr_SafeDestroy_Public_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667259);
		NativeMethodInfoPtr_PickColourFromPalette_Private_Color_byref_List_1_ColourPalettePreset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667260);
		NativeMethodInfoPtr_GetColourFromUnderneath_Private_Color_ClothesPreset_OutfitCategory_ClothingColourSource_byref_Dictionary_2_String_ClothesPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667261);
		NativeMethodInfoPtr_GetChance_Public_Boolean_Human_byref_List_1_TraitPickRule_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667262);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667263);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667264);
		NativeMethodInfoPtr__LoadCurrentOutfit_b__71_0_Private_Boolean_Outfit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667265);
		NativeMethodInfoPtr__LoadExpression_b__84_0_Private_Boolean_ExpressionSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr, 100667266);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134501, XrefRangeEnd = 134521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 135953, RefRangeEnd = 135957, XrefRangeStart = 134521, XrefRangeEnd = 135953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateOutfits(bool forceSpecificDebugOutfit = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forceSpecificDebugOutfit);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateOutfits_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 135974, RefRangeEnd = 136007, XrefRangeStart = 135957, XrefRangeEnd = 135974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GetBodyAnchor(CharacterAnchor anchor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&anchor);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBodyAnchor_Public_Transform_CharacterAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 136046, RefRangeEnd = 136050, XrefRangeStart = 136007, XrefRangeEnd = 136046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MakeClothed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeClothed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 136119, RefRangeEnd = 136131, XrefRangeStart = 136050, XrefRangeEnd = 136119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCurrentOutfit(ClothesPreset.OutfitCategory category, bool forceLoad = false, bool forceReload = false, bool ignoreIfDead = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&category);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceLoad;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceReload;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreIfDead;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCurrentOutfit_Public_Void_OutfitCategory_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 136448, RefRangeEnd = 136450, XrefRangeStart = 136131, XrefRangeEnd = 136448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadCurrentOutfit(bool forceLoad = false, bool forceReload = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&forceLoad);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceReload;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadCurrentOutfit_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136690, RefRangeEnd = 136691, XrefRangeStart = 136450, XrefRangeEnd = 136690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpawnClothingElement(OutfitClothes cl, ClothesPreset cp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cl);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpawnClothingElement_Private_Void_OutfitClothes_ClothesPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 136789, RefRangeEnd = 136792, XrefRangeStart = 136691, XrefRangeEnd = 136789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMeshRenderer(MeshRenderer rend, ref Material applyMat, bool isLOD, ref OutfitClothes clothesOutfit, ClothesPreset.ModelSettings model)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rend);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)applyMat);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLOD;
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clothesOutfit);
		*(System.IntPtr**)num2 = &intPtr2;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)model);
		Unsafe.SkipInit(out System.IntPtr intPtr4);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMeshRenderer_Private_Void_MeshRenderer_byref_Material_Boolean_byref_OutfitClothes_ModelSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		System.IntPtr intPtr5 = intPtr;
		applyMat = ((intPtr5 == (System.IntPtr)0) ? null : new Material(intPtr5));
		System.IntPtr intPtr6 = intPtr2;
		clothesOutfit = ((intPtr6 == (System.IntPtr)0) ? null : new OutfitClothes(intPtr6));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 136837, RefRangeEnd = 136839, XrefRangeStart = 136792, XrefRangeEnd = 136837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveSpecificModel(OutfitClothes cl, CharacterAnchor a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cl);
		*(CharacterAnchor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveSpecificModel_Private_Void_OutfitClothes_CharacterAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 136863, RefRangeEnd = 136865, XrefRangeStart = 136839, XrefRangeEnd = 136863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HairHatCompatibilityCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HairHatCompatibilityCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 136947, RefRangeEnd = 136948, XrefRangeStart = 136865, XrefRangeEnd = 136947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveClothingComponent(OutfitClothes cl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cl);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveClothingComponent_Private_Void_OutfitClothes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 136968, RefRangeEnd = 136970, XrefRangeStart = 136948, XrefRangeEnd = 136968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDebugRenderers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDebugRenderers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 137081, RefRangeEnd = 137085, XrefRangeStart = 136970, XrefRangeEnd = 137081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveCurrentOutfit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveCurrentOutfit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137085, XrefRangeEnd = 137088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadSpecificOutfit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSpecificOutfit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137088, XrefRangeEnd = 137091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectRandomOutfits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectRandomOutfits_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 137129, RefRangeEnd = 137131, XrefRangeStart = 137091, XrefRangeEnd = 137129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CycleOutfits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CycleOutfits_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137131, XrefRangeEnd = 137136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAllOutfits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAllOutfits_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(82)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateNewClothingPreset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNewClothingPreset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137136, XrefRangeEnd = 137155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadExpression()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadExpression_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137155, XrefRangeEnd = 137171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T SafeDestroyGameObject<T>(T component) where T : Component
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = component;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref component;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SafeDestroyGameObject_Public_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 137175, RefRangeEnd = 137185, XrefRangeStart = 137171, XrefRangeEnd = 137175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T SafeDestroy<T>(T obj) where T : UnityEngine.Object
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = obj;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref obj;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SafeDestroy_Public_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 137221, RefRangeEnd = 137229, XrefRangeStart = 137185, XrefRangeEnd = 137221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color PickColourFromPalette(ref List<ColourPalettePreset> palettes, string debug = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)palettes);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(debug);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PickColourFromPalette_Private_Color_byref_List_1_ColourPalettePreset_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		palettes = ((intPtr4 == (System.IntPtr)0) ? null : new List<ColourPalettePreset>(intPtr4));
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 137264, RefRangeEnd = 137268, XrefRangeStart = 137229, XrefRangeEnd = 137264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color GetColourFromUnderneath(ClothesPreset thisPreset, ClothesPreset.OutfitCategory category, ClothesPreset.ClothingColourSource source, ref Dictionary<string, ClothesPreset> clothesDictionary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thisPreset);
		*(ClothesPreset.OutfitCategory**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		*(ClothesPreset.ClothingColourSource**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clothesDictionary);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColourFromUnderneath_Private_Color_ClothesPreset_OutfitCategory_ClothingColourSource_byref_Dictionary_2_String_ClothesPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		clothesDictionary = ((intPtr4 == (System.IntPtr)0) ? null : new Dictionary<string, ClothesPreset>(intPtr4));
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 137354, RefRangeEnd = 137357, XrefRangeStart = 137268, XrefRangeEnd = 137354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetChance(Human human, ref List<ClothesPreset.TraitPickRule> pickRules, out int addChance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)human);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pickRules);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref addChance);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChance_Public_Boolean_Human_byref_List_1_TraitPickRule_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		pickRules = ((intPtr4 == (System.IntPtr)0) ? null : new List<ClothesPreset.TraitPickRule>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137357, XrefRangeEnd = 137371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137371, XrefRangeEnd = 137455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CitizenOutfitController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CitizenOutfitController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool _LoadCurrentOutfit_b__71_0(Outfit item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LoadCurrentOutfit_b__71_0_Private_Boolean_Outfit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool _LoadExpression_b__84_0(ExpressionSetup item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__LoadExpression_b__84_0_Private_Boolean_ExpressionSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public CitizenOutfitController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
