using System.Collections.Generic;
using Il2CppInterop.Runtime.Attributes;
using SoDCoop.Network;
using UnityEngine;

namespace SoDCoop.Player;

/// <summary>
/// Represents a remote player in the game world.
/// Uses snapshot interpolation: keeps a small buffer of recent state snapshots
/// and renders ~INTERP_DELAY ms behind the latest, lerping between snapshots
/// straddling the render time. Falls back to velocity extrapolation for a short
/// window if packets stop arriving.
/// </summary>
public class RemotePlayer : MonoBehaviour
{
    public RemotePlayer(System.IntPtr ptr) : base(ptr) { }

    #region Properties

    public int PlayerId { get; private set; }
    public string PlayerName { get; private set; }
    public Vector3 CurrentPosition => transform.position;
    public Quaternion CurrentRotation => transform.rotation;

    #endregion

    #region Tuning

    /// <summary>How far behind realtime to render. Larger = smoother but more lag.</summary>
    private const float INTERP_DELAY = 0.10f;

    /// <summary>Max time we'll extrapolate past the newest snapshot before freezing.</summary>
    private const float MAX_EXTRAPOLATION = 0.25f;

    /// <summary>If we receive a snapshot more than this far from current pos, teleport.</summary>
    private const float TELEPORT_THRESHOLD = 8f;

    /// <summary>Snapshot ring capacity. ~12 covers ~600ms of history at 20Hz.</summary>
    private const int BUFFER_CAPACITY = 12;

    /// <summary>Rotation slerp speed when applying interpolated target each frame.</summary>
    private const float ROTATION_LERP_SPEED = 18f;

    #endregion

    #region Snapshot Buffer

    private struct Snapshot
    {
        public ushort Sequence;
        public float ArrivalTime;   // local Time.unscaledTime when packet was received
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Velocity;
        public byte Flags;
    }

    // Newest at end. Linear lookup is fine for tiny capacity.
    private readonly List<Snapshot> _buffer = new(BUFFER_CAPACITY);
    private ushort _newestSeq;
    private bool _hasReceivedAny;

    #endregion

    #region Components

    private Animator _animator;
    private bool _animatorParamsScanned;
    private int _animSpeedHash      = -1;
    private int _animIsRunningHash  = -1;
    private int _animIsCrouchingHash = -1;

    #endregion

    private bool _initialized;

    [HideFromIl2Cpp]
    public void Initialize(int playerId, string playerName)
    {
        PlayerId = playerId;
        PlayerName = playerName;
        _initialized = true;

        // Animator may live on the citizen-clone added later; re-resolve lazily.
        _animator = GetComponentInChildren<Animator>();

        gameObject.SetActive(true);
        Plugin.Log.LogInfo($"RemotePlayer {PlayerName} (ID: {PlayerId}) initialized.");
    }

    /// <summary>
    /// Late name update. If a position packet arrived before the player-joined
    /// event, the RemotePlayer was spawned with a placeholder; this lets the
    /// join handler patch in the real name without recreating the avatar.
    /// </summary>
    [HideFromIl2Cpp]
    public void UpdateName(string playerName)
    {
        if (string.IsNullOrEmpty(playerName)) return;
        if (PlayerName == playerName) return;
        PlayerName = playerName;
        try { gameObject.name = $"RemotePlayer_{PlayerId}_{playerName}"; } catch { }
    }

    /// <summary>
    /// Called by PlayerSync when a position packet arrives.
    /// </summary>
    [HideFromIl2Cpp]
    public void ApplyPositionState(PlayerPositionPacket packet)
    {
        // Out-of-order: drop. Sequence is ushort with wraparound — use signed diff.
        if (_hasReceivedAny)
        {
            short diff = (short)(packet.Sequence - _newestSeq);
            if (diff <= 0) return;
        }

        // Hard teleport on huge jumps (scene change, respawn).
        if (_hasReceivedAny)
        {
            float dist = Vector3.Distance(transform.position, packet.Position);
            if (dist > TELEPORT_THRESHOLD)
            {
                Plugin.Log.LogInfo($"RemotePlayer {PlayerId} teleported (Δ={dist:F1}m).");
                transform.position = packet.Position;
                transform.rotation = packet.Rotation;
                _buffer.Clear();
            }
        }

        var snap = new Snapshot
        {
            Sequence    = packet.Sequence,
            ArrivalTime = Time.unscaledTime,
            Position    = packet.Position,
            Rotation    = packet.Rotation,
            Velocity    = packet.Velocity,
            Flags       = packet.Flags,
        };

        if (_buffer.Count >= BUFFER_CAPACITY) _buffer.RemoveAt(0);
        _buffer.Add(snap);

        _newestSeq      = packet.Sequence;
        _hasReceivedAny = true;
    }

    void Update()
    {
        if (!_initialized || _buffer.Count == 0) return;

        float renderTime = Time.unscaledTime - INTERP_DELAY;
        Vector3 targetPos;
        Quaternion targetRot;

        if (TryFindStraddlingPair(renderTime, out var older, out var newer))
        {
            float span = newer.ArrivalTime - older.ArrivalTime;
            float t = span > 1e-4f ? Mathf.Clamp01((renderTime - older.ArrivalTime) / span) : 1f;
            targetPos = Vector3.Lerp(older.Position, newer.Position, t);
            targetRot = Quaternion.Slerp(older.Rotation, newer.Rotation, t);
        }
        else
        {
            // No future snapshot — extrapolate from newest using its velocity.
            var newest = _buffer[_buffer.Count - 1];
            float ahead = Mathf.Min(renderTime - newest.ArrivalTime, MAX_EXTRAPOLATION);
            ahead = Mathf.Max(ahead, 0f);
            targetPos = newest.Position + newest.Velocity * ahead;
            targetRot = newest.Rotation;
        }

        // Direct position assignment — interpolation already smoothed it.
        transform.position = targetPos;
        // Slight rotation easing to mask packet jitter on yaw.
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, Time.unscaledDeltaTime * ROTATION_LERP_SPEED);

        DriveAnimator();
    }

    /// <summary>
    /// Find two snapshots in the buffer such that older.ArrivalTime &lt;= renderTime &lt; newer.ArrivalTime.
    /// </summary>
    [HideFromIl2Cpp]
    private bool TryFindStraddlingPair(float renderTime, out Snapshot older, out Snapshot newer)
    {
        for (int i = _buffer.Count - 1; i >= 1; i--)
        {
            if (_buffer[i].ArrivalTime >= renderTime && _buffer[i - 1].ArrivalTime <= renderTime)
            {
                older = _buffer[i - 1];
                newer = _buffer[i];
                return true;
            }
        }
        older = default; newer = default;
        return false;
    }

    /// <summary>
    /// Best-effort animator feed. SoD citizens have varying parameter names — we scan once
    /// and use whatever exists. Wrapped in try/catch because IL2CPP-injected Animator access
    /// can throw on weird rigs.
    /// </summary>
    [HideFromIl2Cpp]
    private void DriveAnimator()
    {
        try
        {
            if (_animator == null)
            {
                _animator = GetComponentInChildren<Animator>();
                if (_animator == null) return;
            }

            if (!_animatorParamsScanned)
            {
                _animatorParamsScanned = true;
                ScanAnimatorParams();
            }

            // Compute speed from buffer — last two snapshots.
            float speed = 0f;
            if (_buffer.Count >= 2)
            {
                var a = _buffer[_buffer.Count - 2];
                var b = _buffer[_buffer.Count - 1];
                float dt = Mathf.Max(b.ArrivalTime - a.ArrivalTime, 0.01f);
                speed = Vector3.Distance(a.Position, b.Position) / dt;
            }
            else
            {
                speed = _buffer[_buffer.Count - 1].Velocity.magnitude;
            }

            var newest = _buffer[_buffer.Count - 1];
            bool isRunning   = (newest.Flags & (byte)MovementFlags.Running)   != 0;
            bool isCrouching = (newest.Flags & (byte)MovementFlags.Crouching) != 0;

            if (_animSpeedHash      != -1) _animator.SetFloat(_animSpeedHash, speed);
            if (_animIsRunningHash  != -1) _animator.SetBool(_animIsRunningHash, isRunning);
            if (_animIsCrouchingHash != -1) _animator.SetBool(_animIsCrouchingHash, isCrouching);
        }
        catch
        {
            // Don't spam logs — animator missing/odd is OK, body just won't animate.
        }
    }

    [HideFromIl2Cpp]
    private void ScanAnimatorParams()
    {
        try
        {
            // ── Dump ALL parameters once for discovery in the log ─────────────
            int paramCount = _animator.parameterCount;
            Plugin.Log.LogInfo($"RemotePlayer {PlayerId}: scanning {paramCount} animator params…");
            for (int i = 0; i < paramCount; i++)
            {
                var param = _animator.GetParameter(i);
                Plugin.Log.LogInfo($"  AnimParam[{i}]: \"{param.name}\" hash={param.nameHash} type={param.type}");
            }

            // ── Match against all known SoD / Unity citizen parameter names ───
            // Uses _animator.parameters because it returns a managed array.
            var pars = _animator.parameters;
            if (pars == null) return;
            for (int i = 0; i < pars.Length; i++)
            {
                var p = pars[i];
                if (p == null || string.IsNullOrEmpty(p.name)) continue;
                var n = p.name.ToLowerInvariant();

                // Speed / movement magnitude
                if (_animSpeedHash == -1 &&
                    (n == "speed" || n == "movespeed" || n == "movementspeed" ||
                     n == "velocity" || n == "forwardspeed"))
                    _animSpeedHash = p.nameHash;

                // Running / sprinting — also covers bare "run" seen in SoD logs
                else if (_animIsRunningHash == -1 &&
                    (n == "isrunning" || n == "running" || n == "run" ||
                     n == "issprinting" || n == "sprint" || n == "sprinting"))
                    _animIsRunningHash = p.nameHash;

                // Crouching — also covers bare "crouch" seen in SoD logs
                else if (_animIsCrouchingHash == -1 &&
                    (n == "iscrouching" || n == "crouching" || n == "crouch" ||
                     n == "iscrouched" || n == "duck" || n == "isducking"))
                    _animIsCrouchingHash = p.nameHash;
            }

            Plugin.Log.LogInfo(
                $"RemotePlayer {PlayerId} animator mapped: " +
                $"speed={_animSpeedHash}, run={_animIsRunningHash}, crouch={_animIsCrouchingHash}");
        }
        catch { }
    }

    /// <summary>
    /// Stub for legacy callers — animation is now derived from position+flags.
    /// </summary>
    [HideFromIl2Cpp]
    public void ApplyAnimationState(PlayerAnimationPacket packet) { /* no-op */ }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inventory-driven visual state (held item / raised / flashlight)
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>Interactable.id currently visualised in the right hand, or -1 for empty.</summary>
    private int _heldInteractableId = -1;
    /// <summary>The instantiated copy of the held item's preset prefab, parented to the right hand.</summary>
    private GameObject _heldVisual;
    /// <summary>True when the avatar holds the item raised (combat-ready stance).</summary>
    private bool _isRaised;
    /// <summary>The flashlight Light component on the right hand, lazily created.</summary>
    private Light _flashlight;

    /// <summary>
    /// Apply the held-item state from a remote player. -1 means empty hands.
    /// Re-runs harmlessly with the same id (idempotent).
    /// </summary>
    [HideFromIl2Cpp]
    public void ApplyHeldItem(int interactableId)
    {
        if (_heldInteractableId == interactableId) return;
        _heldInteractableId = interactableId;
        RebuildHeldVisual();
    }

    /// <summary>Apply remote raised / holstered stance.</summary>
    [HideFromIl2Cpp]
    public void ApplyRaised(bool isRaised)
    {
        if (_isRaised == isRaised) return;
        _isRaised = isRaised;
        // Best-effort: poke the citizen animator if it has an "isAiming" / "isRaised" parameter.
        try
        {
            if (_animator == null) _animator = GetComponentInChildren<Animator>();
            if (_animator == null) return;
            var pars = _animator.parameters;
            if (pars == null) return;
            for (int i = 0; i < pars.Length; i++)
            {
                var p = pars[i];
                if (p == null || string.IsNullOrEmpty(p.name)) continue;
                var n = p.name.ToLowerInvariant();
                if (n == "israised" || n == "raised" || n == "isaiming" || n == "aim" || n == "aiming")
                {
                    _animator.SetBool(p.nameHash, isRaised);
                    break;
                }
            }
        }
        catch { /* animator quirks — non-fatal */ }
    }

    /// <summary>
    /// Fire a one-shot combat action animation. Walks the citizen animator's
    /// parameters for a likely-matching trigger or bool — if none, logs once
    /// and gives up (the wire event still went through; animation is cosmetic).
    /// </summary>
    [HideFromIl2Cpp]
    public void ApplyAction(byte actionKind)
    {
        try
        {
            if (_animator == null) _animator = GetComponentInChildren<Animator>();
            if (_animator == null) return;

            // Candidate parameter names per action.
            string[] candidates = actionKind switch
            {
                0 => new[] { "MeleeAttack", "Attack", "Swing", "Punch", "Strike", "Hit" },
                1 => new[] { "Block", "Blocking", "Guard", "Defend" },
                2 => new[] { "CounterAttack", "Counter", "Riposte" },
                _ => System.Array.Empty<string>(),
            };

            var pars = _animator.parameters;
            if (pars == null) return;
            for (int i = 0; i < pars.Length; i++)
            {
                var p = pars[i];
                if (p == null || string.IsNullOrEmpty(p.name)) continue;
                for (int j = 0; j < candidates.Length; j++)
                {
                    if (!string.Equals(p.name, candidates[j], System.StringComparison.OrdinalIgnoreCase)) continue;
                    if (p.type == AnimatorControllerParameterType.Trigger)
                        _animator.SetTrigger(p.nameHash);
                    else if (p.type == AnimatorControllerParameterType.Bool)
                    {
                        // Bool: pulse on / schedule off via flag-only. Simpler:
                        // set true, leave it; SoD's animator state should clear it.
                        _animator.SetBool(p.nameHash, true);
                    }
                    return;
                }
            }
        }
        catch { /* animator quirks — non-fatal */ }
    }

    /// <summary>Apply remote flashlight on / off.</summary>
    [HideFromIl2Cpp]
    public void ApplyFlashlight(bool isOn)
    {
        try
        {
            if (isOn)
            {
                EnsureFlashlight();
                if (_flashlight != null) _flashlight.enabled = true;
            }
            else
            {
                if (_flashlight != null) _flashlight.enabled = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"RemotePlayer.ApplyFlashlight: {ex.Message}");
        }
    }

    /// <summary>
    /// Find a "right hand" transform on the avatar — Animator humanoid bone first,
    /// fallback to a name search, fallback to a fixed offset under the root.
    /// </summary>
    [HideFromIl2Cpp]
    private Transform GetRightHandTransform()
    {
        try
        {
            if (_animator == null) _animator = GetComponentInChildren<Animator>();
            if (_animator != null && _animator.isHuman)
            {
                var t = _animator.GetBoneTransform(HumanBodyBones.RightHand);
                if (t != null) return t;
            }
        }
        catch { }

        // Fallback: search by common bone names.
        try
        {
            var children = GetComponentsInChildren<Transform>(true);
            for (int i = 0; i < children.Length; i++)
            {
                var n = children[i]?.name;
                if (string.IsNullOrEmpty(n)) continue;
                var lo = n.ToLowerInvariant();
                if (lo == "righthand" || lo == "hand_r" || lo == "r_hand" || lo == "rightpalm") return children[i];
            }
        }
        catch { }

        // Last resort: dummy offset relative to root.
        return transform;
    }

    [HideFromIl2Cpp]
    private void RebuildHeldVisual()
    {
        // Tear down the previous visual.
        if (_heldVisual != null)
        {
            try { Object.Destroy(_heldVisual); } catch { }
            _heldVisual = null;
        }
        if (_heldInteractableId < 0) return;

        try
        {
            var inter = FindInteractableById(_heldInteractableId);
            if (inter == null) return;
            var preset = inter.preset;
            if (preset == null || preset.prefab == null) return;

            var hand = GetRightHandTransform();
            if (hand == null) return;

            _heldVisual = Object.Instantiate(preset.prefab, hand);
            _heldVisual.transform.localPosition = Vector3.zero;
            _heldVisual.transform.localEulerAngles = preset.prefabLocalEuler;
            _heldVisual.transform.localScale      = preset.prefabLocalScale != Vector3.zero
                ? preset.prefabLocalScale
                : Vector3.one;

            // Strip any behaviour that would re-run game logic on this clone
            // (Interactable, Rigidbody, Collider) — it's a static visual only.
            StripHeldVisualComponents(_heldVisual);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"RemotePlayer.RebuildHeldVisual({_heldInteractableId}): {ex.Message}");
        }
    }

    [HideFromIl2Cpp]
    private static void StripHeldVisualComponents(GameObject go)
    {
        try
        {
            var comps = go.GetComponentsInChildren<Component>(true);
            for (int i = 0; i < comps.Length; i++)
            {
                var c = comps[i];
                if (c == null) continue;
                string typeName = null;
                try { typeName = c.GetIl2CppType()?.Name; } catch { }
                if (typeName == null) continue;
                if (typeName == "Transform" || typeName == "MeshFilter" ||
                    typeName == "MeshRenderer" || typeName == "SkinnedMeshRenderer")
                    continue;
                // Kill colliders, rigidbodies, interactable behaviours, audio sources.
                try { Object.Destroy(c); } catch { }
            }
        }
        catch { }
    }

    [HideFromIl2Cpp]
    private static Interactable FindInteractableById(int id)
    {
        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return null;
            if (id >= 0 && id < dir.Count)
            {
                var c = dir[id];
                if (c != null && c.id == id) return c;
            }
            for (int i = 0; i < dir.Count; i++)
            {
                var c = dir[i];
                if (c != null && c.id == id) return c;
            }
        }
        catch { }
        return null;
    }

    [HideFromIl2Cpp]
    private void EnsureFlashlight()
    {
        if (_flashlight != null) return;
        try
        {
            var hand = GetRightHandTransform();
            if (hand == null) return;
            var go = new GameObject("RemoteFlashlight");
            go.transform.SetParent(hand, false);
            go.transform.localPosition = Vector3.zero;
            go.transform.localRotation = Quaternion.identity;
            _flashlight = go.AddComponent<Light>();
            _flashlight.type      = LightType.Spot;
            _flashlight.color     = new Color(1f, 0.96f, 0.85f, 1f);
            _flashlight.intensity = 4f;
            _flashlight.range     = 18f;
            _flashlight.spotAngle = 55f;
            _flashlight.shadows   = LightShadows.None;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"RemotePlayer.EnsureFlashlight: {ex.Message}");
        }
    }

    /// <summary>Called by RemotePlayerManager when a citizen-clone visual is parented under us.</summary>
    [HideFromIl2Cpp]
    public void OnVisualUpgraded()
    {
        _animator = GetComponentInChildren<Animator>();
        _animatorParamsScanned = false;
        _animSpeedHash = _animIsRunningHash = _animIsCrouchingHash = -1;
        // Reattach inventory visuals to the new rig's right-hand bone.
        _flashlight = null;
        RebuildHeldVisual();
        if (_heldInteractableId >= 0) ApplyRaised(_isRaised);
    }

    /// <summary>Called when we revert to the capsule fallback (citizen rig destroyed).</summary>
    [HideFromIl2Cpp]
    public void OnVisualReverted()
    {
        _animator = null;
        _animatorParamsScanned = false;
        _animSpeedHash = _animIsRunningHash = _animIsCrouchingHash = -1;
        // Citizen rig destroyed — drop attached visuals so they don't dangle.
        if (_heldVisual != null)
        {
            try { Object.Destroy(_heldVisual); } catch { }
            _heldVisual = null;
        }
        _flashlight = null;
    }

    [HideFromIl2Cpp]
    private void SetupNameTag()
    {
        // Name tag rendered screen-space via NameTagOverlay.
    }

    void OnDestroy()
    {
        _initialized = false;
        _buffer.Clear();
    }
}

/// <summary>
/// Makes a transform always face the camera. Kept for backward compat — the screen-space
/// NameTagOverlay made this redundant for nicknames, but the type is registered with IL2CPP
/// so we leave the class in place.
/// </summary>
public class BillboardLabel : MonoBehaviour
{
    public BillboardLabel(System.IntPtr ptr) : base(ptr) { }

    private Camera _mainCamera;

    void LateUpdate()
    {
        if (_mainCamera == null)
        {
            _mainCamera = Camera.main;
            if (_mainCamera == null) return;
        }
        transform.LookAt(transform.position + _mainCamera.transform.forward, Vector3.up);
    }
}
