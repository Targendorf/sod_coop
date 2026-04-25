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
            var pars = _animator.parameters;
            if (pars == null) return;
            for (int i = 0; i < pars.Length; i++)
            {
                var p = pars[i];
                if (p == null || string.IsNullOrEmpty(p.name)) continue;
                var n = p.name.ToLowerInvariant();
                if (_animSpeedHash == -1 && (n == "speed" || n == "movespeed" || n == "movementspeed"))
                    _animSpeedHash = p.nameHash;
                else if (_animIsRunningHash == -1 && (n == "isrunning" || n == "running" || n == "issprinting" || n == "sprint"))
                    _animIsRunningHash = p.nameHash;
                else if (_animIsCrouchingHash == -1 && (n == "iscrouching" || n == "crouch" || n == "iscrouched"))
                    _animIsCrouchingHash = p.nameHash;
            }
            Plugin.Log.LogInfo($"RemotePlayer {PlayerId} animator params: speed={_animSpeedHash}, run={_animIsRunningHash}, crouch={_animIsCrouchingHash}");
        }
        catch { }
    }

    /// <summary>
    /// Stub for legacy callers — animation is now derived from position+flags.
    /// </summary>
    [HideFromIl2Cpp]
    public void ApplyAnimationState(PlayerAnimationPacket packet) { /* no-op */ }

    /// <summary>Called by RemotePlayerManager when a citizen-clone visual is parented under us.</summary>
    [HideFromIl2Cpp]
    public void OnVisualUpgraded()
    {
        _animator = GetComponentInChildren<Animator>();
        _animatorParamsScanned = false;
        _animSpeedHash = _animIsRunningHash = _animIsCrouchingHash = -1;
    }

    /// <summary>Called when we revert to the capsule fallback (citizen rig destroyed).</summary>
    [HideFromIl2Cpp]
    public void OnVisualReverted()
    {
        _animator = null;
        _animatorParamsScanned = false;
        _animSpeedHash = _animIsRunningHash = _animIsCrouchingHash = -1;
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
