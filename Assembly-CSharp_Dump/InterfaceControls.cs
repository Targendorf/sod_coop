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
using UnityEngine.UI;

public class InterfaceControls : MonoBehaviour
{
	public enum Icon
	{
		lookingGlass,
		lightBulb,
		key,
		agent,
		citizen,
		pin,
		footprint,
		document,
		door,
		location,
		questionMark,
		eye,
		books,
		star,
		building,
		hand,
		run,
		money,
		message,
		lockpick,
		notebook,
		empty,
		skull,
		passedOut,
		telephone,
		printScanner,
		resolve,
		time,
		tick,
		cross,
		camera,
		vandalism,
		robbery,
		picture,
		fist,
		handcuffs,
		trash,
		food
	}

	[System.Serializable]
	public class IconConfig : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_iconType;

		private static readonly System.IntPtr NativeFieldInfoPtr_sprite;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Icon iconType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconType);
				return *(Icon*)num;
			}
			set
			{
				*(Icon*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconType)) = icon;
			}
		}

		public unsafe Sprite sprite
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprite);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
			}
		}

		static IconConfig()
		{
			Il2CppClassPointerStore<IconConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "IconConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconConfig>.NativeClassPtr);
			NativeFieldInfoPtr_iconType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconConfig>.NativeClassPtr, "iconType");
			NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconConfig>.NativeClassPtr, "sprite");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconConfig>.NativeClassPtr, 100674113);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IconConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconConfig>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public IconConfig(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum EvidenceColours
	{
		red,
		blue,
		yellow,
		green,
		purple,
		white,
		black
	}

	[System.Serializable]
	public class PinColours : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_colour;

		private static readonly System.IntPtr NativeFieldInfoPtr_actualColour;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe EvidenceColours colour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour);
				return *(EvidenceColours*)num;
			}
			set
			{
				*(EvidenceColours*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colour)) = evidenceColours;
			}
		}

		public unsafe Color actualColour
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actualColour);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actualColour)) = color;
			}
		}

		static PinColours()
		{
			Il2CppClassPointerStore<PinColours>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "PinColours");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PinColours>.NativeClassPtr);
			NativeFieldInfoPtr_colour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinColours>.NativeClassPtr, "colour");
			NativeFieldInfoPtr_actualColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinColours>.NativeClassPtr, "actualColour");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinColours>.NativeClassPtr, 100674114);
		}

		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 82, XrefRangeStart = 0, XrefRangeEnd = 82, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PinColours()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PinColours>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public PinColours(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionCursorMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionCursorMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionCursorSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionTextColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionTextDistanceColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionTextIllegalColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowHealthIndicatorThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_controlIconDisplayTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableTooltips;

	private static readonly System.IntPtr NativeFieldInfoPtr_tooltipWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_tooltipObjectPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_toolTipDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_toolTipFadeInSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultTextColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_contextMenuWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimapRootParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerApartmentSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapLoadingGraphic;

	private static readonly System.IntPtr NativeFieldInfoPtr_unknownIconLarge;

	private static readonly System.IntPtr NativeFieldInfoPtr_companyIconLarge;

	private static readonly System.IntPtr NativeFieldInfoPtr_doubleClickDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_stickyNoteButtonSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockedSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlockedSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_hudCanvas;

	private static readonly System.IntPtr NativeFieldInfoPtr_hudCanvasRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_speechBubbleParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_reticleContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr_locationTextContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenshotModeToggleObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenShotModeAllowDialogObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionControlTextColourNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_windowTakeItemIconDefaultColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionControlTextNormalHex;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionControlTextColourIllegal;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionControlTextIllegalHex;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameMessageTextRevealSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameMessageDestroyDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_weaponSwitchAnchor;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstPersonItemsParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionTextNormalColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_trespassingEscalationZero;

	private static readonly System.IntPtr NativeFieldInfoPtr_trespassingEscalationOne;

	private static readonly System.IntPtr NativeFieldInfoPtr_fastForwardArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_movieBarHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockpicksText;

	private static readonly System.IntPtr NativeFieldInfoPtr_cashText;

	private static readonly System.IntPtr NativeFieldInfoPtr_socialRankText;

	private static readonly System.IntPtr NativeFieldInfoPtr_plottedRouteText;

	private static readonly System.IntPtr NativeFieldInfoPtr_notificationGlowCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_notificationColorMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_notificationColorMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageGrey;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageRed;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageGreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageBlue;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageYellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_starchLogo;

	private static readonly System.IntPtr NativeFieldInfoPtr_elGenLogo;

	private static readonly System.IntPtr NativeFieldInfoPtr_kensingtonLogo;

	private static readonly System.IntPtr NativeFieldInfoPtr_KaizenLogo;

	private static readonly System.IntPtr NativeFieldInfoPtr_candorLogo;

	private static readonly System.IntPtr NativeFieldInfoPtr_blackMarketLogo;

	private static readonly System.IntPtr NativeFieldInfoPtr_iconReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_spotted;

	private static readonly System.IntPtr NativeFieldInfoPtr_speech;

	private static readonly System.IntPtr NativeFieldInfoPtr_awarenessDistanceThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_spottedNormalEmission;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrowNormalEmission;

	private static readonly System.IntPtr NativeFieldInfoPtr_awarenessAlertEmission;

	private static readonly System.IntPtr NativeFieldInfoPtr_textSpaceBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_textBubbleMinWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_textBubbleMaxWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerSpeechColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_callerSpeechColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_visualTalkDisplaySpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_visualTalkDisplayDestroyDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_visualTalkDisplayStringLengthModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_visualTalkTextSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_speechMinMaxScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_indicatorMinMaxScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxIndicatorDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_uiPointerDistanceRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_caseSolvedText;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenMessageFadeRenderers;

	private static readonly System.IntPtr NativeFieldInfoPtr_resolveQuestionsDisplayParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_caseSolvedAlphaAnim;

	private static readonly System.IntPtr NativeFieldInfoPtr_caseSolvedKerningAnim;

	private static readonly System.IntPtr NativeFieldInfoPtr_handbookWindowPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightOrbSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_stealthModeOrbSizeTransitionIn;

	private static readonly System.IntPtr NativeFieldInfoPtr_stealthModeOrbSizeTransitionOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightOrbRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightOrbFillImg;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightOrbOutline;

	private static readonly System.IntPtr NativeFieldInfoPtr_seenImg;

	private static readonly System.IntPtr NativeFieldInfoPtr_seenRenderer;

	private static readonly System.IntPtr NativeFieldInfoPtr_seenJuice;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionULRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionURRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionBLRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionBRRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionFadeInImages;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionBoundImages;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionTextContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactionText;

	private static readonly System.IntPtr NativeFieldInfoPtr_readingTextContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr_readingContainerRend;

	private static readonly System.IntPtr NativeFieldInfoPtr_readingText;

	private static readonly System.IntPtr NativeFieldInfoPtr_readingTextRend;

	private static readonly System.IntPtr NativeFieldInfoPtr_readingBoxMaxSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_haveKeyIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockedIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockedImg;

	private static readonly System.IntPtr NativeFieldInfoPtr_forbiddenIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_seenIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockStrengthText;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionInteractionDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionInteractionAnchor;

	private static readonly System.IntPtr NativeFieldInfoPtr_actionInteractionText;

	private static readonly System.IntPtr NativeFieldInfoPtr_unheardSoundIconColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_heardSoundIconColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_stringWidthRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoPinDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_pinnedEvidenceRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_angleStepsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_caseBoardRigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_caseBoardCursorRBContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr_caseBoardCursorRigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_caseBoardContentContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr_pinnedLinearDrag;

	private static readonly System.IntPtr NativeFieldInfoPtr_movingLinearDrag;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraScreenshot;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraScreenshotRenderTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_pinnedMovementIntertiaMultiplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultCaseFileColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumEvidenceItemHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr_pinColours;

	private static readonly System.IntPtr NativeFieldInfoPtr_citizenPhoto;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimizeEvidenceOnPinned;

	private static readonly System.IntPtr NativeFieldInfoPtr_markedLinkColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_neutralColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_incriminatingColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_innocentColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_nullPhotoReference;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultWindowLocation;

	private static readonly System.IntPtr NativeFieldInfoPtr_windowCountOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimizingAnimationSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectionColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_nonSelectionColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_closeSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_closeColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimizeSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimizeColour;

	private static readonly System.IntPtr NativeFieldInfoPtr_normalCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorResizeHorizonal;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorResizeVertical;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorResizeDiagonalRightLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorResizeDiagonalLeftRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_cursorTextEdit;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactionInvestigateSightSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactionInvestigateSoundSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactionPersueSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactionSearchSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactionAvoidSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactionInvestigateSightTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactionInvestigateSoundTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactionPersueTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactionSearchTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_reactionAvoidTex;

	private static readonly System.IntPtr NativeFieldInfoPtr__instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_InterfaceControls_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector2 interactionCursorMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionCursorMin);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionCursorMin)) = vector;
		}
	}

	public unsafe Vector2 interactionCursorMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionCursorMax);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionCursorMax)) = vector;
		}
	}

	public unsafe float interactionCursorSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionCursorSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionCursorSpeed)) = num;
		}
	}

	public unsafe Color interactionTextColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionTextColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionTextColour)) = color;
		}
	}

	public unsafe Color interactionTextDistanceColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionTextDistanceColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionTextDistanceColour)) = color;
		}
	}

	public unsafe Color interactionTextIllegalColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionTextIllegalColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionTextIllegalColour)) = color;
		}
	}

	public unsafe float lowHealthIndicatorThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowHealthIndicatorThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowHealthIndicatorThreshold)) = num;
		}
	}

	public unsafe float controlIconDisplayTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlIconDisplayTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlIconDisplayTime)) = num;
		}
	}

	public unsafe bool enableTooltips
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableTooltips);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableTooltips)) = flag;
		}
	}

	public unsafe float tooltipWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tooltipWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tooltipWidth)) = num;
		}
	}

	public unsafe GameObject tooltipObjectPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tooltipObjectPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tooltipObjectPrefab)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe float toolTipDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toolTipDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toolTipDelay)) = num;
		}
	}

	public unsafe float toolTipFadeInSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toolTipFadeInSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toolTipFadeInSpeed)) = num;
		}
	}

	public unsafe Color defaultTextColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultTextColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultTextColour)) = color;
		}
	}

	public unsafe float contextMenuWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contextMenuWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_contextMenuWidth)) = num;
		}
	}

	public unsafe RectTransform minimapRootParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimapRootParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimapRootParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe Sprite playerApartmentSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerApartmentSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerApartmentSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe GameObject mapLoadingGraphic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapLoadingGraphic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapLoadingGraphic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe Sprite unknownIconLarge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unknownIconLarge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unknownIconLarge)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite companyIconLarge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companyIconLarge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_companyIconLarge)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe float doubleClickDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doubleClickDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doubleClickDelay)) = num;
		}
	}

	public unsafe Sprite stickyNoteButtonSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stickyNoteButtonSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stickyNoteButtonSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite lockedSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockedSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockedSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite unlockedSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlockedSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Canvas hudCanvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hudCanvas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Canvas>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hudCanvas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvas));
		}
	}

	public unsafe RectTransform hudCanvasRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hudCanvasRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hudCanvasRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RectTransform speechBubbleParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speechBubbleParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speechBubbleParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RectTransform reticleContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reticleContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reticleContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RectTransform locationTextContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationTextContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locationTextContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe List<RectTransform> screenshotModeToggleObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenshotModeToggleObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenshotModeToggleObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<RectTransform> screenShotModeAllowDialogObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenShotModeAllowDialogObjects);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenShotModeAllowDialogObjects)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Color interactionControlTextColourNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionControlTextColourNormal);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionControlTextColourNormal)) = color;
		}
	}

	public unsafe Color windowTakeItemIconDefaultColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowTakeItemIconDefaultColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowTakeItemIconDefaultColor)) = color;
		}
	}

	public unsafe string interactionControlTextNormalHex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionControlTextNormalHex);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionControlTextNormalHex)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Color interactionControlTextColourIllegal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionControlTextColourIllegal);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionControlTextColourIllegal)) = color;
		}
	}

	public unsafe string interactionControlTextIllegalHex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionControlTextIllegalHex);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionControlTextIllegalHex)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe float gameMessageTextRevealSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameMessageTextRevealSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameMessageTextRevealSpeed)) = num;
		}
	}

	public unsafe float gameMessageDestroyDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameMessageDestroyDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameMessageDestroyDelay)) = num;
		}
	}

	public unsafe RectTransform weaponSwitchAnchor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponSwitchAnchor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_weaponSwitchAnchor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe Transform firstPersonItemsParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstPersonItemsParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstPersonItemsParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform));
		}
	}

	public unsafe Color interactionTextNormalColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionTextNormalColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionTextNormalColour)) = color;
		}
	}

	public unsafe Color trespassingEscalationZero
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trespassingEscalationZero);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trespassingEscalationZero)) = color;
		}
	}

	public unsafe Color trespassingEscalationOne
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trespassingEscalationOne);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trespassingEscalationOne)) = color;
		}
	}

	public unsafe RectTransform fastForwardArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastForwardArrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastForwardArrow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe float movieBarHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movieBarHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movieBarHeight)) = num;
		}
	}

	public unsafe TextMeshProUGUI lockpicksText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockpicksText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockpicksText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI cashText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cashText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cashText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI socialRankText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialRankText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_socialRankText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI plottedRouteText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plottedRouteText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_plottedRouteText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe AnimationCurve notificationGlowCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notificationGlowCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notificationGlowCurve)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe Color notificationColorMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notificationColorMax);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notificationColorMax)) = color;
		}
	}

	public unsafe Color notificationColorMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notificationColorMin);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_notificationColorMin)) = color;
		}
	}

	public unsafe Color messageGrey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageGrey);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageGrey)) = color;
		}
	}

	public unsafe Color messageRed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageRed);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageRed)) = color;
		}
	}

	public unsafe Color messageGreen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageGreen);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageGreen)) = color;
		}
	}

	public unsafe Color messageBlue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageBlue);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageBlue)) = color;
		}
	}

	public unsafe Color messageYellow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageYellow);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageYellow)) = color;
		}
	}

	public unsafe Sprite starchLogo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starchLogo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starchLogo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite elGenLogo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elGenLogo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elGenLogo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite kensingtonLogo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kensingtonLogo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kensingtonLogo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite KaizenLogo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KaizenLogo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KaizenLogo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite candorLogo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_candorLogo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_candorLogo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite blackMarketLogo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackMarketLogo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blackMarketLogo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe List<IconConfig> iconReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IconConfig>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Material arrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material spotted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spotted);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spotted)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe Material speech
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speech);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speech)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material));
		}
	}

	public unsafe float awarenessDistanceThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awarenessDistanceThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awarenessDistanceThreshold)) = num;
		}
	}

	public unsafe Color spottedNormalEmission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spottedNormalEmission);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spottedNormalEmission)) = color;
		}
	}

	public unsafe Color arrowNormalEmission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrowNormalEmission);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrowNormalEmission)) = color;
		}
	}

	public unsafe Color awarenessAlertEmission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awarenessAlertEmission);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_awarenessAlertEmission)) = color;
		}
	}

	public unsafe Vector2 textSpaceBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpaceBuffer);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpaceBuffer)) = vector;
		}
	}

	public unsafe float textBubbleMinWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textBubbleMinWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textBubbleMinWidth)) = num;
		}
	}

	public unsafe float textBubbleMaxWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textBubbleMaxWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textBubbleMaxWidth)) = num;
		}
	}

	public unsafe Color playerSpeechColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSpeechColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSpeechColour)) = color;
		}
	}

	public unsafe Color callerSpeechColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callerSpeechColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callerSpeechColour)) = color;
		}
	}

	public unsafe float visualTalkDisplaySpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visualTalkDisplaySpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visualTalkDisplaySpeed)) = num;
		}
	}

	public unsafe float visualTalkDisplayDestroyDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visualTalkDisplayDestroyDelay);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visualTalkDisplayDestroyDelay)) = num;
		}
	}

	public unsafe float visualTalkDisplayStringLengthModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visualTalkDisplayStringLengthModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visualTalkDisplayStringLengthModifier)) = num;
		}
	}

	public unsafe float visualTalkTextSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visualTalkTextSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visualTalkTextSize)) = num;
		}
	}

	public unsafe Vector2 speechMinMaxScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speechMinMaxScale);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speechMinMaxScale)) = vector;
		}
	}

	public unsafe Vector2 indicatorMinMaxScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indicatorMinMaxScale);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indicatorMinMaxScale)) = vector;
		}
	}

	public unsafe float maxIndicatorDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxIndicatorDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxIndicatorDistance)) = num;
		}
	}

	public unsafe Vector2 uiPointerDistanceRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiPointerDistanceRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uiPointerDistanceRange)) = vector;
		}
	}

	public unsafe TextMeshProUGUI caseSolvedText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseSolvedText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseSolvedText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe List<CanvasRenderer> screenMessageFadeRenderers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenMessageFadeRenderers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CanvasRenderer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenMessageFadeRenderers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe RectTransform resolveQuestionsDisplayParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolveQuestionsDisplayParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolveQuestionsDisplayParent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe AnimationCurve caseSolvedAlphaAnim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseSolvedAlphaAnim);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseSolvedAlphaAnim)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve caseSolvedKerningAnim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseSolvedKerningAnim);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseSolvedKerningAnim)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe Vector2 handbookWindowPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbookWindowPosition);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handbookWindowPosition)) = vector;
		}
	}

	public unsafe Vector2 lightOrbSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOrbSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOrbSize)) = vector;
		}
	}

	public unsafe AnimationCurve stealthModeOrbSizeTransitionIn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthModeOrbSizeTransitionIn);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthModeOrbSizeTransitionIn)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe AnimationCurve stealthModeOrbSizeTransitionOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthModeOrbSizeTransitionOut);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stealthModeOrbSizeTransitionOut)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve));
		}
	}

	public unsafe RectTransform lightOrbRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOrbRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOrbRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe Image lightOrbFillImg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOrbFillImg);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOrbFillImg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Image lightOrbOutline
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOrbOutline);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightOrbOutline)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Image seenImg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seenImg);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seenImg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe CanvasRenderer seenRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seenRenderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seenRenderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvasRenderer));
		}
	}

	public unsafe JuiceController seenJuice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seenJuice);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<JuiceController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seenJuice)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)juiceController));
		}
	}

	public unsafe RectTransform interactionRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RectTransform interactionULRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionULRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionULRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RectTransform interactionURRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionURRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionURRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RectTransform interactionBLRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionBLRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionBLRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RectTransform interactionBRRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionBRRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionBRRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe List<Image> interactionFadeInImages
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionFadeInImages);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Image>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionFadeInImages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Image> interactionBoundImages
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionBoundImages);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Image>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionBoundImages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe RectTransform interactionTextContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionTextContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionTextContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe TextMeshProUGUI interactionText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactionText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe RectTransform readingTextContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingTextContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingTextContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe CanvasRenderer readingContainerRend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingContainerRend);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingContainerRend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvasRenderer));
		}
	}

	public unsafe TextMeshProUGUI readingText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe CanvasRenderer readingTextRend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingTextRend);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingTextRend)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)canvasRenderer));
		}
	}

	public unsafe Vector2 readingBoxMaxSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingBoxMaxSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readingBoxMaxSize)) = vector;
		}
	}

	public unsafe RectTransform haveKeyIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveKeyIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_haveKeyIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RectTransform lockedIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockedIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockedIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe Image lockedImg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockedImg);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockedImg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe RectTransform forbiddenIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forbiddenIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forbiddenIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RectTransform seenIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seenIcon);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seenIcon)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe TextMeshProUGUI lockStrengthText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockStrengthText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockStrengthText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe RectTransform actionInteractionDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionInteractionDisplay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionInteractionDisplay)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RectTransform actionInteractionAnchor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionInteractionAnchor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionInteractionAnchor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe TextMeshProUGUI actionInteractionText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionInteractionText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actionInteractionText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe Color unheardSoundIconColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unheardSoundIconColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unheardSoundIconColour)) = color;
		}
	}

	public unsafe Color heardSoundIconColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heardSoundIconColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heardSoundIconColour)) = color;
		}
	}

	public unsafe Vector2 stringWidthRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringWidthRange);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stringWidthRange)) = vector;
		}
	}

	public unsafe float autoPinDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPinDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoPinDistance)) = num;
		}
	}

	public unsafe float pinnedEvidenceRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinnedEvidenceRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinnedEvidenceRadius)) = num;
		}
	}

	public unsafe int angleStepsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angleStepsCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angleStepsCount)) = num;
		}
	}

	public unsafe Rigidbody2D caseBoardRigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseBoardRigidbody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseBoardRigidbody)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody2D));
		}
	}

	public unsafe RectTransform caseBoardCursorRBContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseBoardCursorRBContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseBoardCursorRBContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe Rigidbody2D caseBoardCursorRigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseBoardCursorRigidbody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseBoardCursorRigidbody)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rigidbody2D));
		}
	}

	public unsafe RectTransform caseBoardContentContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseBoardContentContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caseBoardContentContainer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe float pinnedLinearDrag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinnedLinearDrag);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinnedLinearDrag)) = num;
		}
	}

	public unsafe float movingLinearDrag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movingLinearDrag);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_movingLinearDrag)) = num;
		}
	}

	public unsafe RawImage cameraScreenshot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraScreenshot);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RawImage>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraScreenshot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawImage));
		}
	}

	public unsafe RenderTexture cameraScreenshotRenderTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraScreenshotRenderTex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraScreenshotRenderTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderTexture));
		}
	}

	public unsafe float pinnedMovementIntertiaMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinnedMovementIntertiaMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinnedMovementIntertiaMultiplier)) = num;
		}
	}

	public unsafe Color defaultCaseFileColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultCaseFileColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultCaseFileColour)) = color;
		}
	}

	public unsafe int maximumEvidenceItemHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumEvidenceItemHistory);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maximumEvidenceItemHistory)) = num;
		}
	}

	public unsafe List<PinColours> pinColours
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinColours);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PinColours>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinColours)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Sprite citizenPhoto
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenPhoto);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_citizenPhoto)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe bool minimizeEvidenceOnPinned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimizeEvidenceOnPinned);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimizeEvidenceOnPinned)) = flag;
		}
	}

	public unsafe Color markedLinkColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markedLinkColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_markedLinkColour)) = color;
		}
	}

	public unsafe Color neutralColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neutralColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neutralColour)) = color;
		}
	}

	public unsafe Color incriminatingColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incriminatingColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incriminatingColour)) = color;
		}
	}

	public unsafe Color innocentColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_innocentColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_innocentColour)) = color;
		}
	}

	public unsafe Texture2D nullPhotoReference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nullPhotoReference);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nullPhotoReference)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Vector2 defaultWindowLocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWindowLocation);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultWindowLocation)) = vector;
		}
	}

	public unsafe Vector2 windowCountOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowCountOffset);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_windowCountOffset)) = vector;
		}
	}

	public unsafe float minimizingAnimationSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimizingAnimationSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimizingAnimationSpeed)) = num;
		}
	}

	public unsafe Color selectionColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectionColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectionColour)) = color;
		}
	}

	public unsafe Color nonSelectionColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonSelectionColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nonSelectionColour)) = color;
		}
	}

	public unsafe Sprite closeSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Color closeColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeColour)) = color;
		}
	}

	public unsafe Sprite minimizeSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimizeSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimizeSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Color minimizeColour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimizeColour);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minimizeColour)) = color;
		}
	}

	public unsafe Texture2D normalCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalCursor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalCursor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Texture2D cursorMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorMove);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorMove)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Texture2D cursorResizeHorizonal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorResizeHorizonal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorResizeHorizonal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Texture2D cursorResizeVertical
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorResizeVertical);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorResizeVertical)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Texture2D cursorResizeDiagonalRightLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorResizeDiagonalRightLeft);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorResizeDiagonalRightLeft)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Texture2D cursorResizeDiagonalLeftRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorResizeDiagonalLeftRight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorResizeDiagonalLeftRight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Texture2D cursorTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Texture2D cursorButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Texture2D cursorTextEdit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorTextEdit);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cursorTextEdit)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe Sprite reactionInvestigateSightSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionInvestigateSightSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionInvestigateSightSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite reactionInvestigateSoundSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionInvestigateSoundSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionInvestigateSoundSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite reactionPersueSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionPersueSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionPersueSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite reactionSearchSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionSearchSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionSearchSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Sprite reactionAvoidSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionAvoidSprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionAvoidSprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite));
		}
	}

	public unsafe Texture reactionInvestigateSightTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionInvestigateSightTex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionInvestigateSightTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture));
		}
	}

	public unsafe Texture reactionInvestigateSoundTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionInvestigateSoundTex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionInvestigateSoundTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture));
		}
	}

	public unsafe Texture reactionPersueTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionPersueTex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionPersueTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture));
		}
	}

	public unsafe Texture reactionSearchTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionSearchTex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionSearchTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture));
		}
	}

	public unsafe Texture reactionAvoidTex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionAvoidTex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reactionAvoidTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture));
		}
	}

	public unsafe static InterfaceControls _instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InterfaceControls>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interfaceControls));
		}
	}

	public unsafe static InterfaceControls Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331517, XrefRangeEnd = 331519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_InterfaceControls_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InterfaceControls>(intPtr) : null;
		}
	}

	static InterfaceControls()
	{
		Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InterfaceControls");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr);
		NativeFieldInfoPtr_interactionCursorMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionCursorMin");
		NativeFieldInfoPtr_interactionCursorMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionCursorMax");
		NativeFieldInfoPtr_interactionCursorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionCursorSpeed");
		NativeFieldInfoPtr_interactionTextColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionTextColour");
		NativeFieldInfoPtr_interactionTextDistanceColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionTextDistanceColour");
		NativeFieldInfoPtr_interactionTextIllegalColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionTextIllegalColour");
		NativeFieldInfoPtr_lowHealthIndicatorThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "lowHealthIndicatorThreshold");
		NativeFieldInfoPtr_controlIconDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "controlIconDisplayTime");
		NativeFieldInfoPtr_enableTooltips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "enableTooltips");
		NativeFieldInfoPtr_tooltipWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "tooltipWidth");
		NativeFieldInfoPtr_tooltipObjectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "tooltipObjectPrefab");
		NativeFieldInfoPtr_toolTipDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "toolTipDelay");
		NativeFieldInfoPtr_toolTipFadeInSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "toolTipFadeInSpeed");
		NativeFieldInfoPtr_defaultTextColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "defaultTextColour");
		NativeFieldInfoPtr_contextMenuWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "contextMenuWidth");
		NativeFieldInfoPtr_minimapRootParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "minimapRootParent");
		NativeFieldInfoPtr_playerApartmentSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "playerApartmentSprite");
		NativeFieldInfoPtr_mapLoadingGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "mapLoadingGraphic");
		NativeFieldInfoPtr_unknownIconLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "unknownIconLarge");
		NativeFieldInfoPtr_companyIconLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "companyIconLarge");
		NativeFieldInfoPtr_doubleClickDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "doubleClickDelay");
		NativeFieldInfoPtr_stickyNoteButtonSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "stickyNoteButtonSprite");
		NativeFieldInfoPtr_lockedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "lockedSprite");
		NativeFieldInfoPtr_unlockedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "unlockedSprite");
		NativeFieldInfoPtr_hudCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "hudCanvas");
		NativeFieldInfoPtr_hudCanvasRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "hudCanvasRect");
		NativeFieldInfoPtr_speechBubbleParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "speechBubbleParent");
		NativeFieldInfoPtr_reticleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "reticleContainer");
		NativeFieldInfoPtr_locationTextContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "locationTextContainer");
		NativeFieldInfoPtr_screenshotModeToggleObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "screenshotModeToggleObjects");
		NativeFieldInfoPtr_screenShotModeAllowDialogObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "screenShotModeAllowDialogObjects");
		NativeFieldInfoPtr_interactionControlTextColourNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionControlTextColourNormal");
		NativeFieldInfoPtr_windowTakeItemIconDefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "windowTakeItemIconDefaultColor");
		NativeFieldInfoPtr_interactionControlTextNormalHex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionControlTextNormalHex");
		NativeFieldInfoPtr_interactionControlTextColourIllegal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionControlTextColourIllegal");
		NativeFieldInfoPtr_interactionControlTextIllegalHex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionControlTextIllegalHex");
		NativeFieldInfoPtr_gameMessageTextRevealSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "gameMessageTextRevealSpeed");
		NativeFieldInfoPtr_gameMessageDestroyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "gameMessageDestroyDelay");
		NativeFieldInfoPtr_weaponSwitchAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "weaponSwitchAnchor");
		NativeFieldInfoPtr_firstPersonItemsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "firstPersonItemsParent");
		NativeFieldInfoPtr_interactionTextNormalColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionTextNormalColour");
		NativeFieldInfoPtr_trespassingEscalationZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "trespassingEscalationZero");
		NativeFieldInfoPtr_trespassingEscalationOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "trespassingEscalationOne");
		NativeFieldInfoPtr_fastForwardArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "fastForwardArrow");
		NativeFieldInfoPtr_movieBarHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "movieBarHeight");
		NativeFieldInfoPtr_lockpicksText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "lockpicksText");
		NativeFieldInfoPtr_cashText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "cashText");
		NativeFieldInfoPtr_socialRankText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "socialRankText");
		NativeFieldInfoPtr_plottedRouteText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "plottedRouteText");
		NativeFieldInfoPtr_notificationGlowCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "notificationGlowCurve");
		NativeFieldInfoPtr_notificationColorMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "notificationColorMax");
		NativeFieldInfoPtr_notificationColorMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "notificationColorMin");
		NativeFieldInfoPtr_messageGrey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "messageGrey");
		NativeFieldInfoPtr_messageRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "messageRed");
		NativeFieldInfoPtr_messageGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "messageGreen");
		NativeFieldInfoPtr_messageBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "messageBlue");
		NativeFieldInfoPtr_messageYellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "messageYellow");
		NativeFieldInfoPtr_starchLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "starchLogo");
		NativeFieldInfoPtr_elGenLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "elGenLogo");
		NativeFieldInfoPtr_kensingtonLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "kensingtonLogo");
		NativeFieldInfoPtr_KaizenLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "KaizenLogo");
		NativeFieldInfoPtr_candorLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "candorLogo");
		NativeFieldInfoPtr_blackMarketLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "blackMarketLogo");
		NativeFieldInfoPtr_iconReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "iconReference");
		NativeFieldInfoPtr_arrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "arrow");
		NativeFieldInfoPtr_spotted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "spotted");
		NativeFieldInfoPtr_speech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "speech");
		NativeFieldInfoPtr_awarenessDistanceThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "awarenessDistanceThreshold");
		NativeFieldInfoPtr_spottedNormalEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "spottedNormalEmission");
		NativeFieldInfoPtr_arrowNormalEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "arrowNormalEmission");
		NativeFieldInfoPtr_awarenessAlertEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "awarenessAlertEmission");
		NativeFieldInfoPtr_textSpaceBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "textSpaceBuffer");
		NativeFieldInfoPtr_textBubbleMinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "textBubbleMinWidth");
		NativeFieldInfoPtr_textBubbleMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "textBubbleMaxWidth");
		NativeFieldInfoPtr_playerSpeechColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "playerSpeechColour");
		NativeFieldInfoPtr_callerSpeechColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "callerSpeechColour");
		NativeFieldInfoPtr_visualTalkDisplaySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "visualTalkDisplaySpeed");
		NativeFieldInfoPtr_visualTalkDisplayDestroyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "visualTalkDisplayDestroyDelay");
		NativeFieldInfoPtr_visualTalkDisplayStringLengthModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "visualTalkDisplayStringLengthModifier");
		NativeFieldInfoPtr_visualTalkTextSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "visualTalkTextSize");
		NativeFieldInfoPtr_speechMinMaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "speechMinMaxScale");
		NativeFieldInfoPtr_indicatorMinMaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "indicatorMinMaxScale");
		NativeFieldInfoPtr_maxIndicatorDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "maxIndicatorDistance");
		NativeFieldInfoPtr_uiPointerDistanceRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "uiPointerDistanceRange");
		NativeFieldInfoPtr_caseSolvedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "caseSolvedText");
		NativeFieldInfoPtr_screenMessageFadeRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "screenMessageFadeRenderers");
		NativeFieldInfoPtr_resolveQuestionsDisplayParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "resolveQuestionsDisplayParent");
		NativeFieldInfoPtr_caseSolvedAlphaAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "caseSolvedAlphaAnim");
		NativeFieldInfoPtr_caseSolvedKerningAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "caseSolvedKerningAnim");
		NativeFieldInfoPtr_handbookWindowPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "handbookWindowPosition");
		NativeFieldInfoPtr_lightOrbSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "lightOrbSize");
		NativeFieldInfoPtr_stealthModeOrbSizeTransitionIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "stealthModeOrbSizeTransitionIn");
		NativeFieldInfoPtr_stealthModeOrbSizeTransitionOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "stealthModeOrbSizeTransitionOut");
		NativeFieldInfoPtr_lightOrbRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "lightOrbRect");
		NativeFieldInfoPtr_lightOrbFillImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "lightOrbFillImg");
		NativeFieldInfoPtr_lightOrbOutline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "lightOrbOutline");
		NativeFieldInfoPtr_seenImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "seenImg");
		NativeFieldInfoPtr_seenRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "seenRenderer");
		NativeFieldInfoPtr_seenJuice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "seenJuice");
		NativeFieldInfoPtr_interactionRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionRect");
		NativeFieldInfoPtr_interactionULRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionULRect");
		NativeFieldInfoPtr_interactionURRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionURRect");
		NativeFieldInfoPtr_interactionBLRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionBLRect");
		NativeFieldInfoPtr_interactionBRRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionBRRect");
		NativeFieldInfoPtr_interactionFadeInImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionFadeInImages");
		NativeFieldInfoPtr_interactionBoundImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionBoundImages");
		NativeFieldInfoPtr_interactionTextContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionTextContainer");
		NativeFieldInfoPtr_interactionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "interactionText");
		NativeFieldInfoPtr_readingTextContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "readingTextContainer");
		NativeFieldInfoPtr_readingContainerRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "readingContainerRend");
		NativeFieldInfoPtr_readingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "readingText");
		NativeFieldInfoPtr_readingTextRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "readingTextRend");
		NativeFieldInfoPtr_readingBoxMaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "readingBoxMaxSize");
		NativeFieldInfoPtr_haveKeyIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "haveKeyIcon");
		NativeFieldInfoPtr_lockedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "lockedIcon");
		NativeFieldInfoPtr_lockedImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "lockedImg");
		NativeFieldInfoPtr_forbiddenIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "forbiddenIcon");
		NativeFieldInfoPtr_seenIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "seenIcon");
		NativeFieldInfoPtr_lockStrengthText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "lockStrengthText");
		NativeFieldInfoPtr_actionInteractionDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "actionInteractionDisplay");
		NativeFieldInfoPtr_actionInteractionAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "actionInteractionAnchor");
		NativeFieldInfoPtr_actionInteractionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "actionInteractionText");
		NativeFieldInfoPtr_unheardSoundIconColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "unheardSoundIconColour");
		NativeFieldInfoPtr_heardSoundIconColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "heardSoundIconColour");
		NativeFieldInfoPtr_stringWidthRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "stringWidthRange");
		NativeFieldInfoPtr_autoPinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "autoPinDistance");
		NativeFieldInfoPtr_pinnedEvidenceRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "pinnedEvidenceRadius");
		NativeFieldInfoPtr_angleStepsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "angleStepsCount");
		NativeFieldInfoPtr_caseBoardRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "caseBoardRigidbody");
		NativeFieldInfoPtr_caseBoardCursorRBContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "caseBoardCursorRBContainer");
		NativeFieldInfoPtr_caseBoardCursorRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "caseBoardCursorRigidbody");
		NativeFieldInfoPtr_caseBoardContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "caseBoardContentContainer");
		NativeFieldInfoPtr_pinnedLinearDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "pinnedLinearDrag");
		NativeFieldInfoPtr_movingLinearDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "movingLinearDrag");
		NativeFieldInfoPtr_cameraScreenshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "cameraScreenshot");
		NativeFieldInfoPtr_cameraScreenshotRenderTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "cameraScreenshotRenderTex");
		NativeFieldInfoPtr_pinnedMovementIntertiaMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "pinnedMovementIntertiaMultiplier");
		NativeFieldInfoPtr_defaultCaseFileColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "defaultCaseFileColour");
		NativeFieldInfoPtr_maximumEvidenceItemHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "maximumEvidenceItemHistory");
		NativeFieldInfoPtr_pinColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "pinColours");
		NativeFieldInfoPtr_citizenPhoto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "citizenPhoto");
		NativeFieldInfoPtr_minimizeEvidenceOnPinned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "minimizeEvidenceOnPinned");
		NativeFieldInfoPtr_markedLinkColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "markedLinkColour");
		NativeFieldInfoPtr_neutralColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "neutralColour");
		NativeFieldInfoPtr_incriminatingColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "incriminatingColour");
		NativeFieldInfoPtr_innocentColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "innocentColour");
		NativeFieldInfoPtr_nullPhotoReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "nullPhotoReference");
		NativeFieldInfoPtr_defaultWindowLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "defaultWindowLocation");
		NativeFieldInfoPtr_windowCountOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "windowCountOffset");
		NativeFieldInfoPtr_minimizingAnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "minimizingAnimationSpeed");
		NativeFieldInfoPtr_selectionColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "selectionColour");
		NativeFieldInfoPtr_nonSelectionColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "nonSelectionColour");
		NativeFieldInfoPtr_closeSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "closeSprite");
		NativeFieldInfoPtr_closeColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "closeColour");
		NativeFieldInfoPtr_minimizeSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "minimizeSprite");
		NativeFieldInfoPtr_minimizeColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "minimizeColour");
		NativeFieldInfoPtr_normalCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "normalCursor");
		NativeFieldInfoPtr_cursorMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "cursorMove");
		NativeFieldInfoPtr_cursorResizeHorizonal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "cursorResizeHorizonal");
		NativeFieldInfoPtr_cursorResizeVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "cursorResizeVertical");
		NativeFieldInfoPtr_cursorResizeDiagonalRightLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "cursorResizeDiagonalRightLeft");
		NativeFieldInfoPtr_cursorResizeDiagonalLeftRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "cursorResizeDiagonalLeftRight");
		NativeFieldInfoPtr_cursorTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "cursorTarget");
		NativeFieldInfoPtr_cursorButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "cursorButton");
		NativeFieldInfoPtr_cursorTextEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "cursorTextEdit");
		NativeFieldInfoPtr_reactionInvestigateSightSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "reactionInvestigateSightSprite");
		NativeFieldInfoPtr_reactionInvestigateSoundSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "reactionInvestigateSoundSprite");
		NativeFieldInfoPtr_reactionPersueSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "reactionPersueSprite");
		NativeFieldInfoPtr_reactionSearchSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "reactionSearchSprite");
		NativeFieldInfoPtr_reactionAvoidSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "reactionAvoidSprite");
		NativeFieldInfoPtr_reactionInvestigateSightTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "reactionInvestigateSightTex");
		NativeFieldInfoPtr_reactionInvestigateSoundTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "reactionInvestigateSoundTex");
		NativeFieldInfoPtr_reactionPersueTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "reactionPersueTex");
		NativeFieldInfoPtr_reactionSearchTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "reactionSearchTex");
		NativeFieldInfoPtr_reactionAvoidTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "reactionAvoidTex");
		NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, "_instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_InterfaceControls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, 100674109);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, 100674110);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, 100674111);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr, 100674112);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331519, XrefRangeEnd = 331559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331559, XrefRangeEnd = 331580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331580, XrefRangeEnd = 331625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InterfaceControls()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterfaceControls>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InterfaceControls(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
