using System;
using System.Collections.Generic;
using SoDCoop.Player;
using SoDCoop.Sync;
using UnityEngine;

namespace SoDCoop.UI.Coop;

/// <summary>
/// 3D preview backend for <see cref="Panels.AppearancePanel"/>.
///
/// <para><b>Persistent pawn strategy:</b> on the first world-ready event
/// (any save loaded — single-player or coop), we deep-clone a real
/// citizen GameObject, strip its AI / physics / behaviour ticks, and
/// park it in <c>DontDestroyOnLoad</c> at a far-off stage location.
/// The clone survives returning to SoD's main menu — Unity won't unload
/// it because it's in the persistent scene, and the
/// <c>CitizenOutfitController</c> machinery it relies on (clothing
/// presets, hair prefabs, social-statistics palettes) lives in
/// global ScriptableObjects that stay loaded for the lifetime of the
/// application.</para>
///
/// <para>That means once the player has loaded any SoD save once during
/// the session, the appearance panel can render a live 3D preview from
/// any context — main menu, lobby, in-world. Cold launch with no save
/// loaded yet still falls back to the placeholder text and tells the
/// user to load a save.</para>
///
/// <para><b>Why deep clone instead of leasing a live citizen:</b>
/// borrowing a real citizen worked while a city was loaded but didn't
/// survive scene transitions — we'd have to restore them on every
/// panel close. The persistent clone simplifies the model: one pawn,
/// owned by us, no city mutation.</para>
/// </summary>
public static class AppearancePreviewStage
{
    private const float StageX = -1500f;
    private const float StageY = 50f;
    private const float StageZ = -1500f;

    public static RenderTexture RenderTex { get; private set; }
    public static bool IsActive { get; private set; }

    private static GameObject _root;
    private static Camera     _camera;
    private static Light      _keyLight;

    // Persistent pawn (lives in DontDestroyOnLoad).
    private static GameObject                    _pawnGo;
    private static global::CitizenOutfitController _pawnCtrl;

    private static float _yaw = 0f;
    private static AppearanceConfig _currentCfg = AppearanceConfig.Default;

    private static bool _eventsHooked;

    // ─────────────────────────────────────────────────────────────────────
    //  Lifecycle hooks
    // ─────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Subscribe to <see cref="WorldReadyGate"/> so we capture a pawn the
    /// first time the user enters any save. Call once from plugin init.
    /// </summary>
    public static void Initialize()
    {
        if (_eventsHooked) return;
        _eventsHooked = true;
        try
        {
            WorldReadyGate.OnWorldReady += OnWorldReady;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"AppearancePreviewStage.Initialize: {ex.Message}");
        }
    }

    private static void OnWorldReady()
    {
        // Eagerly capture so the panel works even if the user goes back to
        // the main menu before opening it.
        try
        {
            BuildStageIfNeeded();
            EnsurePersistentPawn();
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"AppearancePreviewStage.OnWorldReady: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Build (camera + RT + light)
    // ─────────────────────────────────────────────────────────────────────

    private static void BuildStageIfNeeded()
    {
        if (_root != null) return;
        try
        {
            _root = new GameObject("SoDCoop_AppearancePreview");
            UnityEngine.Object.DontDestroyOnLoad(_root);
            _root.SetActive(false);

            // Camera ~2.2m in front of pawn at chest height.
            var camGo = new GameObject("PreviewCamera");
            camGo.transform.SetParent(_root.transform, false);
            camGo.transform.position = new Vector3(StageX, StageY + 1.55f, StageZ + 2.2f);
            camGo.transform.LookAt(new Vector3(StageX, StageY + 1.4f, StageZ));

            _camera = camGo.AddComponent<Camera>();
            _camera.clearFlags     = CameraClearFlags.SolidColor;
            _camera.backgroundColor = new Color(0.04f, 0.05f, 0.07f, 1f);
            _camera.fieldOfView    = 35f;
            _camera.nearClipPlane  = 0.05f;
            _camera.farClipPlane   = 30f;
            _camera.cullingMask    = ~0;
            _camera.depth          = 100;
            _camera.allowHDR       = false;
            _camera.allowMSAA      = false;
            _camera.enabled        = false;

            RenderTex = new RenderTexture(360, 480, 16, RenderTextureFormat.ARGB32)
            {
                name = "SoDCoop_AppearancePreviewRT",
                antiAliasing = 1,
                useMipMap = false,
                wrapMode = TextureWrapMode.Clamp,
                filterMode = FilterMode.Bilinear,
            };
            RenderTex.Create();
            _camera.targetTexture = RenderTex;

            var lightGo = new GameObject("KeyLight");
            lightGo.transform.SetParent(_root.transform, false);
            lightGo.transform.position = new Vector3(StageX + 1.5f, StageY + 4f, StageZ + 1.5f);
            lightGo.transform.LookAt(new Vector3(StageX, StageY + 1.4f, StageZ));
            _keyLight = lightGo.AddComponent<Light>();
            _keyLight.type      = LightType.Directional;
            _keyLight.color     = new Color(1f, 0.96f, 0.85f);
            _keyLight.intensity = 1.1f;
            _keyLight.shadows   = LightShadows.None;
            _keyLight.cullingMask = ~0;

            Plugin.Log.LogInfo("[AppearancePreviewStage] stage built (RT=360x480, persistent).");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"AppearancePreviewStage.BuildStageIfNeeded: {ex}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Persistent pawn capture
    // ─────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Returns true if we already have a usable preview pawn (deep-cloned
    /// citizen sitting in DontDestroyOnLoad). Callers can branch on this
    /// to decide whether to show the placeholder.
    /// </summary>
    public static bool HasPawn => _pawnGo != null && _pawnCtrl != null;

    /// <summary>
    /// If we don't have a persistent pawn yet, clone one from the live
    /// city. No-op if no save is loaded (citizen dictionary empty).
    /// </summary>
    public static void EnsurePersistentPawn()
    {
        if (HasPawn) return;
        try
        {
            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict == null || dict.Count == 0)
            {
                Plugin.Log.LogInfo("[AppearancePreviewStage] no citizens loaded — pawn capture deferred.");
                return;
            }

            int playerHumanId = -1;
            try { playerHumanId = global::Player.Instance?.humanID ?? -1; } catch { }

            HashSet<int> twins = null;
            try
            {
                if (Network.NetworkManager.IsHost)
                    twins = new HashSet<int>(TwinManager.GetAllTwinHumanIDsForCurrentSeed());
            }
            catch { }

            var ids = new List<int>(dict.Count);
            foreach (var kv in dict) ids.Add(kv.Key);
            ids.Sort();

            global::Human picked = null;
            foreach (var id in ids)
            {
                if (id == playerHumanId) continue;
                if (twins != null && twins.Contains(id)) continue;
                if (!dict.TryGetValue(id, out var h) || h == null || h.gameObject == null) continue;
                bool dead = false;
                try { dead = h.isDead; } catch { }
                if (dead) continue;
                if (h.outfitController == null) continue;
                picked = h;
                break;
            }

            if (picked == null)
            {
                Plugin.Log.LogWarning("[AppearancePreviewStage] no eligible citizen to clone for preview pawn.");
                return;
            }

            // Deep-clone the citizen GameObject. Important: parent INTO the
            // already-inactive _root in the same call. Unity skips Awake on
            // a clone whose parent is inactive — which is what we want, so
            // SoD's CitizenOutfitController doesn't re-run GenerateOutfits
            // (which would clear the inherited live-citizen outfit) and the
            // AI / behaviour components don't try to register with global
            // controllers from a freshly-spawned doppelgänger. The clone
            // inherits all post-Awake state from the source citizen, which
            // is exactly what we want for a static preview.
            var clone = UnityEngine.Object.Instantiate(picked.gameObject, _root.transform, worldPositionStays: false);
            clone.name = "SoDCoop_PreviewPawn";
            clone.transform.localPosition = Vector3.zero;
            clone.transform.position      = new Vector3(StageX, StageY, StageZ);
            clone.transform.rotation      = Quaternion.Euler(0f, 180f, 0f);

            StripBehaviours(clone);

            // Force every SkinnedMeshRenderer to recompute bounds each frame.
            // Without this, the renderer's static bounds are stale (computed
            // at the SOURCE citizen's position from before we moved the
            // clone), so Unity culls the pawn against the camera frustum
            // and the preview shows an empty background. Cheap on a single
            // pawn — measured ~0.05 ms even with a dozen sub-meshes.
            int skinned = 0;
            foreach (var smr in clone.GetComponentsInChildren<SkinnedMeshRenderer>(true))
            {
                if (smr == null) continue;
                try { smr.updateWhenOffscreen = true; } catch { }
                try { smr.forceMatrixRecalculationPerRender = true; } catch { }
                skinned++;
            }

            _pawnGo   = clone;
            var humanComp = clone.GetComponent<global::Human>();
            _pawnCtrl = humanComp?.outfitController;

            // The clone is parented under _root which is inactive at startup;
            // Begin() flips the root active and the whole subtree comes alive.
            // Do NOT toggle SetActive on the clone here — that wouldn't help
            // (parent's active state dominates) and would just trip the IL2CPP
            // "only root GameObjects can be made don't-destroy-on-load" hot path.

            int meshes = 0;
            try { foreach (var _ in clone.GetComponentsInChildren<MeshRenderer>(true)) meshes++; } catch { }

            Plugin.Log.LogInfo($"[AppearancePreviewStage] cloned persistent pawn from citizen #{picked.humanID} (skinned-mesh renderers: {skinned}, mesh renderers: {meshes}).");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"AppearancePreviewStage.EnsurePersistentPawn: {ex}");
            // If clone got partway, drop the wreckage.
            if (_pawnGo != null) { try { UnityEngine.Object.Destroy(_pawnGo); } catch { } _pawnGo = null; }
            _pawnCtrl = null;
        }
    }

    /// <summary>
    /// Disable / destroy components on the clone that would tick AI logic,
    /// run physics, or fire colliders against the world. Keeps Transform,
    /// SkinnedMeshRenderer, MeshFilter, Animator, Human, CitizenOutfitController
    /// — i.e. the bare minimum the rendering + LoadCurrentOutfit pipeline
    /// needs.
    /// </summary>
    private static void StripBehaviours(GameObject root)
    {
        try
        {
            // Physics — destroy colliders, joints, rigidbodies anywhere in tree.
            foreach (var col in root.GetComponentsInChildren<Collider>(true))
                try { UnityEngine.Object.Destroy(col); } catch { }
            foreach (var j in root.GetComponentsInChildren<Joint>(true))
                try { UnityEngine.Object.Destroy(j); } catch { }
            foreach (var rb in root.GetComponentsInChildren<Rigidbody>(true))
                try { UnityEngine.Object.Destroy(rb); } catch { }

            // Disable NavMeshAgent so it doesn't try to pathfind on a missing mesh.
            var navTypeName = "NavMeshAgent";
            foreach (var comp in root.GetComponentsInChildren<Behaviour>(true))
            {
                if (comp == null) continue;
                string typeName = "";
                try { typeName = comp.GetIl2CppType()?.Name ?? ""; } catch { }
                if (typeName == navTypeName) { try { UnityEngine.Object.Destroy(comp); } catch { } }
            }

            // Disable known behaviour-tickers we know about. Leaves Animator
            // running so the idle pose is still natural.
            var disableTypeNames = new HashSet<string>
            {
                "NewAIController",
                "AudioSource",
                "VoiceController",
                "FootstepController",
                "BreathController",
            };
            foreach (var comp in root.GetComponentsInChildren<Behaviour>(true))
            {
                if (comp == null) continue;
                string typeName = "";
                try { typeName = comp.GetIl2CppType()?.Name ?? ""; } catch { }
                if (disableTypeNames.Contains(typeName))
                {
                    try { comp.enabled = false; } catch { }
                }
            }

            // Disable shadows on the clone's renderers — at the preview stage
            // there's nothing useful for them to fall on, and they cost FPS.
            foreach (var r in root.GetComponentsInChildren<Renderer>(true))
            {
                if (r == null) continue;
                try { r.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off; } catch { }
                try { r.receiveShadows = false; } catch { }
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"AppearancePreviewStage.StripBehaviours: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Public API used by the panel
    // ─────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Begin a preview session. If we have a persistent pawn (i.e. the
    /// user has loaded any save during this session), enables the camera
    /// and applies the config; otherwise becomes a no-op and
    /// <see cref="IsActive"/> stays false.
    /// </summary>
    public static void Begin(AppearanceConfig cfg)
    {
        try
        {
            BuildStageIfNeeded();
            EnsurePersistentPawn();
            if (!HasPawn) { Plugin.Log.LogInfo("[AppearancePreviewStage] Begin: no pawn, skipping (no save loaded yet?)"); return; }

            _root.SetActive(true);
            _camera.enabled = true;
            _yaw = 0f;
            ApplyPawnRotation();

            _currentCfg = cfg;
            _currentCfg.IsCustomized = true;
            ApplyToPawn(_currentCfg);

            // Force one render immediately so the first frame shows up in
            // the panel without waiting for Unity's normal loop tick (which
            // can lag a frame behind the SetActive in Begin).
            try { _camera.Render(); }
            catch (Exception ex) { Plugin.Log.LogWarning($"[AppearancePreviewStage] forced first-frame render: {ex.Message}"); }

            Plugin.Log.LogInfo($"[AppearancePreviewStage] Begin OK — pawn at {_pawnGo.transform.position}, camera at {_camera.transform.position}, RT={(RenderTex != null ? $"{RenderTex.width}x{RenderTex.height}" : "null")}.");

            IsActive = true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"AppearancePreviewStage.Begin: {ex}");
        }
    }

    public static void Update(AppearanceConfig cfg)
    {
        if (!IsActive) { Begin(cfg); return; }
        _currentCfg = cfg;
        _currentCfg.IsCustomized = true;
        ApplyToPawn(_currentCfg);
    }

    public static void Rotate(float delta)
    {
        if (!IsActive) return;
        _yaw = (_yaw + delta) % 360f;
        ApplyPawnRotation();
    }

    /// <summary>
    /// Stop rendering and hide the stage. The persistent pawn stays
    /// alive in DontDestroyOnLoad — there's nothing to "restore" to.
    /// </summary>
    public static void End()
    {
        if (!IsActive) return;
        try
        {
            if (_camera != null) _camera.enabled = false;
            if (_root != null)   _root.SetActive(false);
        }
        catch { }
        IsActive = false;
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Apply
    // ─────────────────────────────────────────────────────────────────────

    private static void ApplyToPawn(AppearanceConfig cfg)
    {
        if (_pawnCtrl == null) return;
        try { cfg.ApplyTo(_pawnCtrl); }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"AppearancePreviewStage.ApplyToPawn: {ex.Message}");
        }
    }

    private static void ApplyPawnRotation()
    {
        if (_pawnGo == null) return;
        try { _pawnGo.transform.rotation = Quaternion.Euler(0f, 180f + _yaw, 0f); }
        catch { }
    }
}
