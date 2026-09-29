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

    /// <summary>How far behind realtime to render. Larger = smoother but more
    /// lag.
    ///
    /// <para>Must cover at least two send intervals, otherwise one lost packet
    /// leaves no snapshot newer than the render time and playback falls into
    /// velocity extrapolation — a visible hitch. Position packets go out
    /// Sequenced (unreliable, no retransmit), so losing one is routine, not
    /// exceptional. Positions arrive with the 20 Hz ZDO delta flush
    /// (LocalPlayerPoller → LocalPlayer ZDO; the old PlayerSync packets are
    /// off), so 120 ms is 2.4 intervals. It was only 1.2 while the flush ran
    /// at 10 Hz — the hitch this rule exists to prevent.</para></summary>
    private const float INTERP_DELAY = 0.12f;

    /// <summary>Max time we'll extrapolate past the newest snapshot before freezing.</summary>
    private const float MAX_EXTRAPOLATION = 0.25f;

    /// <summary>If we receive a snapshot more than this far from current pos, teleport.</summary>
    private const float TELEPORT_THRESHOLD = 8f;

    /// <summary>Snapshot ring capacity. ~12 covers ~600ms of history at 20Hz.</summary>
    private const int BUFFER_CAPACITY = 12;

    /// <summary>Rotation smoothing rate, per second. Fed through an
    /// exponential so the result is frame-rate independent — see
    /// <see cref="SmoothingFactor"/>.</summary>
    private const float ROTATION_LERP_SPEED = 18f;

    // ── Sender-timed playback (peers that stamp ZdoKeys.PosTime) ──────────
    // INTERP_DELAY above only applies to arrival-timed playback. Timed
    // playback renders behind the sender's clock by an adaptive delay —
    // RemoteClock — bounded here.

    /// <summary>Nominal spacing of the sender's samples (20 Hz poller, a little
    /// slack for frames it runs late).</summary>
    private const float SAMPLE_GAP_S = 0.06f;
    private const float MIN_DELAY_S  = 0.08f;
    private const float MAX_DELAY_S  = 0.35f;

    /// <summary>Smoothing rate for the speed fed to the walk animation — the
    /// raw per-pair speed steps at every sample.</summary>
    private const float ANIM_SPEED_RATE = 12f;

    #endregion

    #region Snapshot Buffer

    private struct Snapshot
    {
        public ushort Sequence;
        public float ArrivalTime;   // local Time.unscaledTime when packet was received
        /// <summary>Playback timeline: the sender's sample time when the peer
        /// stamps one, otherwise <see cref="ArrivalTime"/>.</summary>
        public float T;
        public Vector3 Position;
        public Quaternion Rotation;
        public Vector3 Velocity;
        public byte Flags;
    }

    // Newest at end. Linear lookup is fine for tiny capacity.
    private readonly List<Snapshot> _buffer = new(BUFFER_CAPACITY);
    private ushort _newestSeq;
    private bool _hasReceivedAny;

    /// <summary>True while the buffer is on the sender's clock.</summary>
    private bool _timed;
    private float _newestT;
    private readonly SoDCoop.Sync.RemoteClock _clock = new();
    /// <summary>Smoothed playback speed, m/s — drives the walk cycle.</summary>
    private float _renderSpeed;

    #endregion

    #region Components

    private Animator _animator;
    private bool _animatorParamsScanned;
    private int _animSpeedHash      = -1;
    private int _animWalkSpeedHash  = -1;   // SoD citizen rig: drives the walk-cycle blend tree
    private int _animIsRunningHash  = -1;
    private int _animIsCrouchingHash = -1;

    #endregion

    private bool _initialized;

    /// <summary>
    /// True when this remote player is downed (lethal damage / dead). On
    /// entry, the visual body is detached from this wrapper, given a single
    /// Rigidbody + CapsuleCollider, and an impulse in the hit direction so
    /// it falls like a sack. The wrapper transform keeps following snapshot
    /// updates (the nametag label hovers wherever the live player position
    /// reports — usually frozen for the dead).
    /// </summary>
    public bool IsDown { get; private set; }

    /// <summary>Detached corpse, kept so we can destroy it on revive.</summary>
    private GameObject _corpse;

    /// <summary>Last-received appearance customization for this remote
    /// player. Re-applied whenever the citizen visual is (re)cloned —
    /// without this the avatar renders the random citizen's procedural
    /// look instead of the player's chosen clothes / hair / skin. Updated
    /// by <see cref="ApplyAppearance"/> (called from AppearanceSync).</summary>
    private SoDCoop.Player.AppearanceConfig? _pendingAppearance;

    /// <summary>
    /// Toggle the downed state. <paramref name="hitDirection"/> sets the
    /// initial impulse direction (zero vector → fall straight forward).
    /// Idempotent.
    /// </summary>
    [HideFromIl2Cpp]
    public void SetDown(bool isDown, Vector3 hitDirection = default)
    {
        if (IsDown == isDown) return;
        IsDown = isDown;

        try
        {
            if (isDown)
            {
                // The twin is the body: let IT fall, in SoD's own ragdoll.
                // The corpse path below detaches the STAND-IN, which is hidden
                // while the twin drives — the player used to go down as an
                // invisible corpse, a capsule popping up beside it and their
                // real body still standing.
                if (TwinIsBody && SetTwinRagdoll(true))
                {
                    _twinDown = true;
                    Plugin.Log.LogInfo($"[RemotePlayer] {PlayerName} down — body #{_twin.humanID} ragdolled.");
                    return;
                }
                if (TwinIsBody)
                {
                    // No ragdoll: hide the twin and show the stand-in's corpse.
                    SoDCoop.Sync.TwinManager.SetBodyVisible(_twin.humanID, false);
                    _twinHiddenForCorpse = _twin.humanID;
                }
                _corpse = RemotePlayerManager.DetachVisualAsCorpse(PlayerId, hitDirection);
                Plugin.Log.LogInfo($"[RemotePlayer] {PlayerName} down — detached visual as corpse.");
            }
            else
            {
                if (_twinDown)
                {
                    _twinDown = false;
                    SetTwinRagdoll(false);
                    Plugin.Log.LogInfo($"[RemotePlayer] {PlayerName} revived — body back on its feet.");
                    return;
                }
                RemotePlayerManager.DestroyCorpseAndRespawnVisual(PlayerId, _corpse);
                _corpse = null;
                // Re-resolve animator on the freshly attached visual.
                _animator = null;
                _animatorParamsScanned = false;
                if (_twinHiddenForCorpse > 0)
                {
                    SoDCoop.Sync.TwinManager.SetBodyVisible(_twinHiddenForCorpse, true);
                    _twinHiddenForCorpse = 0;
                }
                // The respawned stand-in is visible; if the twin drives, the
                // next frame must hide it again.
                _standInHidden = false;
                Plugin.Log.LogInfo($"[RemotePlayer] {PlayerName} revived — corpse cleared, visual respawned.");
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"RemotePlayer.SetDown({isDown}) for {PlayerName}: {ex.Message}");
        }
    }

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

        if (_timed) { _buffer.Clear(); _clock.Reset(); _timed = false; }

        var snap = new Snapshot
        {
            Sequence    = packet.Sequence,
            ArrivalTime = Time.unscaledTime,
            T           = Time.unscaledTime,
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

    /// <summary>
    /// ZDO-side counterpart to <see cref="ApplyPositionState"/>. Called from
    /// <c>LocalPlayerResolver.Apply</c> when a peer's <c>LocalPlayer</c> ZDO
    /// arrives with a fresh position. Converts the (position, rotation,
    /// dataRevision) triple into the same snapshot buffer the legacy packet
    /// path feeds, so the existing interpolation / teleport / extrapolation
    /// logic in <see cref="Update"/> is reused verbatim.
    ///
    /// <para><paramref name="dataRevision"/> is the ZDO's monotonic
    /// DataRevision at serialise time — used as a stand-in for the legacy
    /// packet's ushort Sequence. Cast to ushort (collisions only across
    /// ~65k revisions, irrelevant for position-ordering).</para>
    ///
    /// <para>Replaces the legacy <c>PlayerPositionPacket</c> path once
    /// <c>ZdoFeatureFlags.UseZdoForPlayerState</c> is on — the host/peer no
    /// longer ships a separate Sequenced packet for position, the state
    /// rides the unified LocalPlayer ZDO delta channel instead. The legacy
    /// <see cref="ApplyPositionState"/> stays for mixed-version peers and
    /// as the receive path for any old <c>PlayerPosition</c> packets.</para>
    /// </summary>
    [HideFromIl2Cpp]
    public void ApplyPositionFromZdo(Vector3 position, Quaternion rotation, uint dataRevision, Vector3 velocity, byte flags,
                                     float sampleTime = float.NaN)
    {
        float now = Time.unscaledTime;
        bool timed = !float.IsNaN(sampleTime);

        // Switching timeline (peer started/stopped stamping) invalidates what
        // is buffered — the two kinds of time are not comparable.
        if (_hasReceivedAny && timed != _timed) { _buffer.Clear(); _clock.Reset(); }

        if (timed)
        {
            // Not a new sample: this delta carried other keys (held item,
            // health keyframe…) and the resolver re-read the unchanged
            // position. It used to be buffered as a fresh sample at its
            // arrival time, holding the body in place for a beat — a hitch
            // every time any other key changed. A big step BACK is a sender
            // whose clock restarted; RemoteClock resets on it.
            if (_hasReceivedAny && _timed && sampleTime <= _newestT && _newestT - sampleTime < 2f)
                return;
            if (_clock.Observe(sampleTime, now)) _buffer.Clear();
            _newestT = sampleTime;
        }
        else
        {
            // Out-of-order guard mirrors ApplyPositionState. ushort diff
            // handles wraparound at 65k; DataRevision is monotonic per-ZDO.
            ushort seq = (ushort)dataRevision;
            if (_hasReceivedAny && !_timed)
            {
                short diff = (short)(seq - _newestSeq);
                if (diff <= 0) return;
            }
            _newestSeq = seq;
        }
        _timed = timed;

        // Hard teleport on huge jumps (scene change, respawn, far spawn).
        if (_hasReceivedAny)
        {
            float dist = Vector3.Distance(transform.position, position);
            if (dist > TELEPORT_THRESHOLD)
            {
                Plugin.Log.LogInfo($"RemotePlayer {PlayerId} teleported (Δ={dist:F1}m) [zdo].");
                transform.position = position;
                transform.rotation = rotation;
                _buffer.Clear();
            }
        }

        var snap = new Snapshot
        {
            Sequence    = (ushort)dataRevision,
            ArrivalTime = now,
            T           = timed ? sampleTime : now,
            Position    = position,
            Rotation    = rotation,
            Velocity    = velocity,
            Flags       = flags,
        };

        if (_buffer.Count >= BUFFER_CAPACITY) _buffer.RemoveAt(0);
        _buffer.Add(snap);

        _hasReceivedAny = true;
    }

    void Update()
    {
        if (!_initialized || _buffer.Count == 0) return;

        float now = Time.unscaledTime;
        float dt  = Time.unscaledDeltaTime;
        float renderTime;
        if (_timed)
        {
            _clock.Advance(dt, SAMPLE_GAP_S, MIN_DELAY_S, MAX_DELAY_S);
            renderTime = _clock.RenderTime(now);
        }
        else
        {
            renderTime = now - INTERP_DELAY;
        }

        Vector3 targetPos;
        Quaternion targetRot;
        float speed;

        if (TryFindStraddlingPair(renderTime, out var older, out var newer))
        {
            float span = newer.T - older.T;
            float t = span > 1e-4f ? Mathf.Clamp01((renderTime - older.T) / span) : 1f;
            targetPos = Vector3.Lerp(older.Position, newer.Position, t);
            targetRot = Quaternion.Slerp(older.Rotation, newer.Rotation, t);
            speed = span > 1e-3f ? Vector3.Distance(older.Position, newer.Position) / span : 0f;
        }
        else
        {
            // No future snapshot — extrapolate from newest using its velocity.
            var newest = _buffer[_buffer.Count - 1];
            float ahead = Mathf.Min(renderTime - newest.T, MAX_EXTRAPOLATION);
            ahead = Mathf.Max(ahead, 0f);
            targetPos = newest.Position + newest.Velocity * ahead;
            targetRot = newest.Rotation;
            speed = ahead < MAX_EXTRAPOLATION ? newest.Velocity.magnitude : 0f;
        }

        // The per-pair speed steps at every sample boundary; the walk cycle
        // reads it every frame, so ease it.
        _renderSpeed = Mathf.Lerp(_renderSpeed, speed, SmoothingFactor(ANIM_SPEED_RATE, dt));

        // Direct position assignment — interpolation already smoothed it.
        // The wrapper transform stays authoritative for nametags, map markers
        // and CurrentPosition even when the twin is the visible body.
        transform.position = targetPos;
        // Slight rotation easing to mask packet jitter on yaw.
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot,
            SmoothingFactor(ROTATION_LERP_SPEED, Time.unscaledDeltaTime));

        // Prefer the twin citizen as this player's body. Falls back to the
        // stand-in clone when no twin is assigned yet.
        if (!DriveTwin(targetPos))
            DriveAnimator();
    }

    /// <summary>Frame-rate-independent exponential smoothing factor.
    ///
    /// <para>The old form was <c>Slerp(a, b, dt * rate)</c>, which makes the
    /// amount of smoothing depend on frame rate: at 60 FPS that is t≈0.30 per
    /// frame, at 30 FPS t≈0.60, and past ~55 ms per frame it exceeds 1 and
    /// clamps, turning the ease into a snap. So remote players turned at
    /// visibly different rates depending on the viewer's FPS — and worst
    /// exactly when the host was hitching. <c>1 - exp(-rate·dt)</c> converges
    /// at the same real-world rate regardless of how the frame time is
    /// carved up.</para></summary>
    [HideFromIl2Cpp]
    private static float SmoothingFactor(float rate, float dt)
        => 1f - Mathf.Exp(-rate * Mathf.Max(dt, 0f));

    // ── Twin-driven body ────────────────────────────────────────────────
    //
    // A remote player needs to be TWO things at once: something you can see,
    // and something the game's AI can perceive. The original design solved
    // those with two separate objects — this RemotePlayer wrapper carrying a
    // stripped clone of a random citizen for the visuals, and a frozen "twin"
    // citizen for everything logical (forensics attribution, suspicion flags,
    // outfit, the player's chosen name and appearance).
    //
    // Splitting them is the bug. The clone is not an Actor, so SoD's AI cannot
    // see it at all; the twin is an Actor but never moved, so NPC perception,
    // trespass reactions and witness logic all ran against a body standing
    // wherever it was first claimed. PlayerSuspicionSync exists purely to paper
    // over that, pushing the trespass FLAGS to the host's twin because the
    // POSITION could not be trusted.
    //
    // Every established co-op mod for a singleplayer game converges on the
    // opposite pattern: ONE entity per remote player, which is a real engine
    // actor, with its local AI disabled and its transform driven by the
    // network. Skyrim Together is explicit about it — remote players "operate
    // like NPCs" there, to the point that a standing player can give away a
    // sneaking one to the AI, which is only possible because the remote player
    // is a genuine perceivable actor at a genuine position.
    //
    // So the twin becomes the body. It is already a real Human in
    // citizenDictionary with the player's actual appearance, it is already
    // frozen by TwinManager (ai.enabled = false) so nothing fights us for the
    // transform, and driving it from the interpolation this class already
    // computes costs nothing extra. The stand-in clone is hidden while a twin
    // is available, so there is exactly one body.
    //
    // Only OTHER players' twins are driven, which this class gives us for free:
    // a RemotePlayer only ever exists for a remote peer. The local player is
    // represented by Player.Instance, which the AI already perceives normally —
    // moving your own twin would spawn a duplicate of you.

    private global::Human _twin;
    private float _nextTwinResolveAt;
    private bool _loggedOwnIdTwin;
    private Animator _twinAnimator;
    private bool _twinAnimResolved;
    private bool _standInHidden;
    private int _twinMoveSpeedHash = -1;
    private int _twinWalkSpeedHash = -1;

    /// <summary>Root motion suppressed on the twin while we drive it — see
    /// <see cref="SoDCoop.Sync.RootMotionGuard"/>. We feed moveSpeed on the twin
    /// and write its transform ourselves; left on, root motion adds its own step
    /// after our write every frame.</summary>
    private readonly SoDCoop.Sync.RootMotionGuard _twinRootMotion = new();

    /// <summary>Drive this player's twin citizen to <paramref name="targetPos"/>
    /// and feed its locomotion animation. Returns true when the twin took over
    /// as the body, false when the caller should keep using the stand-in.</summary>
    [HideFromIl2Cpp]
    private bool DriveTwin(Vector3 targetPos)
    {
        // Downed players hand their body to the corpse system, which detaches
        // the STAND-IN visual and gives it physics. That path needs the stand-in
        // back — driving the twin here would leave an invisible corpse on the
        // floor while the twin stayed upright. Same restore when the feature is
        // switched off at runtime.
        if (CoopSettings.RemotePlayerUsesTwinBody?.Value == false)
        {
            RestoreStandIn();
            return false;
        }
        if (IsDown)
        {
            // Lying in its own ragdoll: nothing to drive. Otherwise the
            // stand-in's corpse is the body and the twin is hidden.
            return _twinDown;
        }

        try
        {
            if (_twin == null)
            {
                // No twin (not resolved yet, or lost — destroyed by a world
                // reload, or dropped after an exception). The stand-in MUST be
                // visible meanwhile: the caller falls back to animating it, and
                // if it were still hidden from an earlier twin the player would
                // simply vanish.
                RestoreStandIn();

                // Throttled: the twin id arrives with the handshake, but a
                // position packet can outrace it, and the citizen itself may
                // not exist until the world finishes loading.
                float now = Time.unscaledTime;
                if (now < _nextTwinResolveAt) return false;
                _nextTwinResolveAt = now + 2f;
                if (!TryResolveTwin()) return false;
            }

            var t = _twin.transform;
            if (t == null) { DropTwin(); return false; }

            // TwinManager froze the AI, so nothing else writes this transform.
            t.position = targetPos;
            t.rotation = transform.rotation;

            if (!_standInHidden)
            {
                _twinRootMotion.Suppress(_twin);
                RemotePlayerManager.SetStandInVisualVisible(PlayerId, false);
                _standInHidden = true;
                Plugin.Log.LogInfo(
                    $"[RemotePlayer] {PlayerName} is now driven through twin citizen #{_twin.humanID} — " +
                    "stand-in clone hidden, game AI can perceive this player.");
                OnBodyChanged();
            }

            DriveTwinAnimator();
            return true;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[RemotePlayer] DriveTwin({PlayerName}): {ex.Message}");
            DropTwin();
            return false;
        }
    }

    /// <summary>Stop using the twin as the body and bring the stand-in back.</summary>
    [HideFromIl2Cpp]
    private void DropTwin()
    {
        _twinDown = false;
        _twinHiddenForCorpse = 0;
        _twin = null;
        _twinAnimator = null;
        _twinAnimResolved = false;
        RestoreStandIn();
    }

    /// <summary>Put the stand-in body back on screen after the twin stops
    /// driving (player downed, twin lost, or the feature switched off
    /// mid-session), and hand the twin's root motion back.</summary>
    [HideFromIl2Cpp]
    private void RestoreStandIn()
    {
        _twinRootMotion.Restore();
        if (!_standInHidden) return;
        _standInHidden = false;
        RemotePlayerManager.SetStandInVisualVisible(PlayerId, true);
        OnBodyChanged();
    }

    // ── What the visible body wears and does ────────────────────────────
    //
    // Held item, torch, raised stance, bed, hiding. All of these used to be
    // put on the RemotePlayer's own hierarchy — the stand-in clone — which is
    // HIDDEN while the twin is the body (the default). So another player was
    // seen walking about empty-handed in the dark, never raising a weapon,
    // never lying down: the item hung off an invisible hand. They now go to
    // whichever body is on screen and move with it when that changes.

    /// <summary>True while the twin citizen is the visible body.</summary>
    private bool TwinIsBody => _twin != null && _standInHidden;

    /// <summary>The twin lies in its own ragdoll (player downed).</summary>
    private bool _twinDown;
    /// <summary>Twin hidden while the stand-in's corpse shows (no ragdoll).</summary>
    private int _twinHiddenForCorpse;
    private bool _flashlightOn;
    private bool _hiding;
    private bool _combatStanceSet;

    /// <summary>The visible body changed (twin took over, or the stand-in came
    /// back): move the held item and torch onto its hand and re-apply the
    /// states that live on the body.</summary>
    [HideFromIl2Cpp]
    private void OnBodyChanged()
    {
        try
        {
            if (_flashlight != null)
            {
                try { Object.Destroy(_flashlight.gameObject); } catch { }
                _flashlight = null;
            }
            _combatStanceSet = false;
            RebuildHeldVisual();
            if (_flashlightOn) ApplyFlashlight(true);
            ApplyRaisedToBody();
            if (_bedKnown && _inBed) ApplyBedToBody();
            if (_hiding) ApplyBodyHidden(true);
            // A re-resolved twin (world reload) is a fresh citizen in its
            // seeded clothes — dress it again.
            if (TwinIsBody && _pendingAppearance.HasValue)
            {
                try
                {
                    var ctrl = _twin.outfitController;
                    if (ctrl != null) _pendingAppearance.Value.ApplyTo(ctrl);
                }
                catch { }
            }
        }
        catch (System.Exception ex) { Plugin.Log.LogDebug($"[RemotePlayer] OnBodyChanged({PlayerName}): {ex.Message}"); }
    }

    /// <summary>SoD's own ragdoll on the twin — the body falls as any citizen
    /// knocked out does. False when it isn't available.</summary>
    [HideFromIl2Cpp]
    private bool SetTwinRagdoll(bool on)
    {
        try
        {
            var ac = _twin != null ? _twin.animationController : null;
            if (ac == null) return false;
            ac.SetRagdoll(on, false);
            return true;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[RemotePlayer] SetRagdoll({on}) on {PlayerName}'s body: {ex.Message}");
            return false;
        }
    }

    /// <summary>Raised weapon / fists: the twin takes SoD's combat stance
    /// (the one a citizen squaring up to a fight uses); the stand-in gets the
    /// best-effort animator parameter.</summary>
    [HideFromIl2Cpp]
    private void ApplyRaisedToBody()
    {
        if (TwinIsBody)
        {
            if (!_isRaised && !_combatStanceSet) return;
            try { _twin.animationController?.SetInCombat(_isRaised); } catch { }
            _combatStanceSet = _isRaised;
            return;
        }
        SetStandInBool(_isRaised, "israised", "raised", "isaiming", "aim", "aiming");
    }

    /// <summary>Player is hiding (closet, under a bed…): the body is hidden
    /// with them rather than standing inside the furniture.</summary>
    [HideFromIl2Cpp]
    public void ApplyHiding(bool hiding)
    {
        if (_hiding == hiding) return;
        _hiding = hiding;
        ApplyBodyHidden(hiding);
    }

    [HideFromIl2Cpp]
    private void ApplyBodyHidden(bool hidden)
    {
        try
        {
            if (TwinIsBody) SoDCoop.Sync.TwinManager.SetBodyVisible(_twin.humanID, !hidden);
            else RemotePlayerManager.SetStandInVisualVisible(PlayerId, !hidden);
            if (_heldVisual != null) _heldVisual.SetActive(!hidden);
            if (_flashlight != null) _flashlight.enabled = !hidden && _flashlightOn;
        }
        catch { }
    }

    /// <summary>Set the first bool parameter matching one of <paramref name="names"/>
    /// on the stand-in's animator (its rig's parameter names are not known).</summary>
    [HideFromIl2Cpp]
    private void SetStandInBool(bool value, params string[] names)
    {
        try
        {
            if (_animator == null) _animator = GetComponentInChildren<Animator>();
            if (_animator == null) return;
            var pars = _animator.parameters;
            if (pars == null) return;
            for (int i = 0; i < pars.Length; i++)
            {
                var p = pars[i];
                if (p == null || string.IsNullOrEmpty(p.name) || p.type != AnimatorControllerParameterType.Bool) continue;
                var n = p.name.ToLowerInvariant();
                for (int j = 0; j < names.Length; j++)
                {
                    if (n != names[j]) continue;
                    _animator.SetBool(p.nameHash, value);
                    return;
                }
            }
        }
        catch { }
    }

    [HideFromIl2Cpp]
    private bool TryResolveTwin()
    {
        int twinId = 0;
        if (NetworkManager.Players != null
            && NetworkManager.Players.TryGetValue(PlayerId, out var info)
            && info != null)
        {
            twinId = info.TwinHumanID;
        }
        if (twinId <= 0) return false;

        // On a machine whose own player shares this id (it loaded the host's
        // save, or began a new game in the same city) the "twin" IS the local
        // player — driving it would glue us to this remote player. Stay on
        // the stand-in body. See TwinManager.IsLocalPlayerHuman.
        if (SoDCoop.Sync.TwinManager.IsLocalPlayerHuman(twinId))
        {
            if (!_loggedOwnIdTwin)
            {
                _loggedOwnIdTwin = true;
                Plugin.Log.LogWarning(
                    $"[RemotePlayer] {PlayerName}'s body #{twinId} is this machine's own player — " +
                    "using the stand-in body instead.");
            }
            return false;
        }

        var dict = global::CityData.Instance?.citizenDictionary;
        if (dict == null) return false;
        if (!dict.TryGetValue(twinId, out var human) || human == null) return false;

        _twin = human;
        _twinAnimResolved = false;
        _twinAnimator = null;
        return true;
    }

    /// <summary>Feed the twin's locomotion parameters from the interpolated
    /// speed. Its AI is frozen and therefore publishes no speed of its own, so
    /// without this the body slides along in its idle pose — the same artefact
    /// the stand-in path hit and fixed by driving BOTH parameters.</summary>
    [HideFromIl2Cpp]
    private void DriveTwinAnimator()
    {
        try
        {
            if (!_twinAnimResolved) ResolveTwinAnimator();
            if (_twinAnimator == null) return;

            // The speed of what is being PLAYED, not of the two newest
            // arrivals: two packets landing in one frame read as a sprint, a
            // late one as a stop, and the legs flickered between them.
            float speed = _renderSpeed;

            _twinAnimator.SetFloat(_twinMoveSpeedHash, speed);
            _twinAnimator.SetFloat(_twinWalkSpeedHash, Mathf.Clamp01(speed / 1.5f));
        }
        catch { /* animator missing or odd — position still syncs */ }
    }

    [HideFromIl2Cpp]
    private void ResolveTwinAnimator()
    {
        _twinAnimResolved = true;
        try { _twinAnimator = _twin.GetComponentInChildren<Animator>(); } catch { _twinAnimator = null; }
        if (_twinAnimator != null)
        {
            _twinMoveSpeedHash = Animator.StringToHash("moveSpeed");
            _twinWalkSpeedHash = Animator.StringToHash("walkAnimSpeed");
        }
    }

    /// <summary>
    /// Find two snapshots in the buffer such that older.T &lt;= renderTime &lt; newer.T.
    /// </summary>
    [HideFromIl2Cpp]
    private bool TryFindStraddlingPair(float renderTime, out Snapshot older, out Snapshot newer)
    {
        for (int i = _buffer.Count - 1; i >= 1; i--)
        {
            if (_buffer[i].T >= renderTime && _buffer[i - 1].T <= renderTime)
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

            // Speed of the interpolated playback (see DriveTwinAnimator).
            float speed = _renderSpeed;

            var newest = _buffer[_buffer.Count - 1];
            bool isRunning   = (newest.Flags & (byte)MovementFlags.Running)   != 0;
            bool isCrouching = (newest.Flags & (byte)MovementFlags.Crouching) != 0;

            // moveSpeed: raw m/s — the animator's blend tree threshold on
            // SoD's citizen rig is roughly 0=idle, 1.5=walk, 4+=run.
            if (_animSpeedHash      != -1) _animator.SetFloat(_animSpeedHash, speed);
            // walkAnimSpeed: normalised 0..1 — SoD's walk-cycle blend tree
            // reads this to fade between idle and walk-in-place. Without it
            // the body slides without animating. Derive from speed: below
            // ~1.5 m/s treat as idle, above ramp to 1 by ~5 m/s.
            if (_animWalkSpeedHash   != -1)
            {
                float walkNorm = Mathf.Clamp01(speed / 1.5f);
                _animator.SetFloat(_animWalkSpeedHash, walkNorm);
            }
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

                // Speed / movement magnitude. SoD's citizen rig uses
                // "moveSpeed" (primary) and "walkAnimSpeed" (secondary, also
                // drives the walk-cycle blend tree). Map BOTH so whichever
                // one the animator's blend tree reads gets a real value —
                // without walkAnimSpeed the body stays in the idle pose even
                // when transform.position is moving (playtest 2026-06-16:
                // players saw each other slide without walking anim).
                if (_animSpeedHash == -1 &&
                    (n == "speed" || n == "movespeed" || n == "movementspeed" ||
                     n == "velocity" || n == "forwardspeed"))
                    _animSpeedHash = p.nameHash;
                if (_animWalkSpeedHash == -1 &&
                    (n == "walkanimspeed" || n == "walkspeed" || n == "walkspeedscale"))
                    _animWalkSpeedHash = p.nameHash;

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
                $"speed={_animSpeedHash}, walk={_animWalkSpeedHash}, run={_animIsRunningHash}, crouch={_animIsCrouchingHash}");
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
        ApplyRaisedToBody();
    }

    /// <summary>
    /// Fire a one-shot combat action animation. Walks the citizen animator's
    /// parameters for a likely-matching trigger or bool — if none, logs once
    /// and gives up (the wire event still went through; animation is cosmetic).
    /// </summary>
    [HideFromIl2Cpp]
    public void ApplyAction(byte actionKind)
    {
        // Not on the twin: a citizen's swing animation fires
        // CitizenAnimationEvents.MeleeAttackTrigger, which runs the hit through
        // that citizen's AI — a phantom attack from a frozen body. The real
        // hit already travels as NpcHitSync / damage events.
        if (TwinIsBody) return;
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

    /// <summary>Last in-bed state received (see ApplyInBed).</summary>
    private bool _bedKnown, _inBed, _lowBed;

    /// <summary>Apply remote in-bed state. Called on every delta of the
    /// player's ZDO — acts only when it changes.</summary>
    [HideFromIl2Cpp]
    public void ApplyInBed(bool isInBed, bool isLowBed)
    {
        if (_bedKnown && _inBed == isInBed && _lowBed == isLowBed) return;
        _bedKnown = true;
        _inBed = isInBed;
        _lowBed = isLowBed;
        ApplyBedToBody();
    }

    [HideFromIl2Cpp]
    private void ApplyBedToBody()
    {
        bool isInBed = _inBed, isLowBed = _lowBed;
        if (TwinIsBody)
        {
            // SetInBed is what lays a citizen down; the animator parameter
            // guess below is for the stand-in rig.
            try { if (_twin.isInBed != isInBed) _twin.SetInBed(isInBed, isLowBed); } catch { }
            return;
        }
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
                if ((n == "isinbed" || n == "inbed" || n == "islayingdown") &&
                    p.type == AnimatorControllerParameterType.Bool)
                    _animator.SetBool(p.nameHash, isInBed);
                else if ((n == "islowbed" || n == "lowbed") &&
                    p.type == AnimatorControllerParameterType.Bool)
                    _animator.SetBool(p.nameHash, isLowBed);
            }
        }
        catch { /* animator quirks — non-fatal */ }
    }

    /// <summary>Apply remote asleep state.</summary>
    [HideFromIl2Cpp]
    public void ApplyAsleep(bool isAsleep)
    {
        if (TwinIsBody)
        {
            try { if (_twin.isAsleep != isAsleep) _twin.isAsleep = isAsleep; } catch { }
            return;
        }
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
                if ((n == "isasleep" || n == "asleep" || n == "sleeping" || n == "issleeping") &&
                    p.type == AnimatorControllerParameterType.Bool)
                {
                    _animator.SetBool(p.nameHash, isAsleep);
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
        _flashlightOn = isOn;
        try
        {
            if (isOn)
            {
                EnsureFlashlight();
                if (_flashlight != null) _flashlight.enabled = !_hiding;
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
        // The twin's hand while it is the body. SoD's outfit controller keeps
        // an anchor per body part (the one it hangs gloves / held props on).
        if (TwinIsBody)
        {
            try
            {
                var a = _twin.outfitController?.GetBodyAnchor(global::CitizenOutfitController.CharacterAnchor.HandRight);
                if (a != null) return a;
            }
            catch { }
            try
            {
                if (!_twinAnimResolved) ResolveTwinAnimator();
                if (_twinAnimator != null && _twinAnimator.isHuman)
                {
                    var t = _twinAnimator.GetBoneTransform(HumanBodyBones.RightHand);
                    if (t != null) return t;
                }
            }
            catch { }
            return _twin.transform;
        }

        // Stand-in: the cloned rig keeps its CitizenOutfitController, whose
        // anchors Instantiate remapped onto the clone's own bones.
        try
        {
            var ctrl = GetComponentInChildren<global::CitizenOutfitController>();
            var a = ctrl != null ? ctrl.GetBodyAnchor(global::CitizenOutfitController.CharacterAnchor.HandRight) : null;
            if (a != null && a.IsChildOf(transform)) return a;
        }
        catch { }

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
            if (_hiding) _heldVisual.SetActive(false);
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
        if (_standInHidden)
        {
            // The twin is the body: the fresh stand-in must not show next to
            // it, and the held item / torch stay on the twin's hand.
            RemotePlayerManager.SetStandInVisualVisible(PlayerId, false);
        }
        else
        {
            // Reattach inventory visuals to the new rig's right-hand bone.
            OnBodyChanged();
        }
        // Re-apply any appearance customization received before the visual
        // existed. CitizenVisualCloner now keeps CitizenOutfitController on
        // the clone, so ApplyTo can stamp debugOverride* + LoadCurrentOutfit.
        if (_pendingAppearance.HasValue)
        {
            try { ApplyAppearance(_pendingAppearance.Value); } catch { }
        }
    }

    /// <summary>Apply the peer's chosen appearance (clothes / hair / skin /
    /// build / etc.) to this RemotePlayer's citizen-clone visual. Called
    /// from <see cref="SoDCoop.Sync.AppearanceSync"/> when a
    /// <c>PlayerAppearance</c> packet arrives, and re-applied from
    /// <see cref="OnVisualUpgraded"/> whenever the visual is re-cloned
    /// (e.g. after a world reload). Safe to call before the citizen visual
    /// exists — the config is stashed and replayed on upgrade.
    ///
    /// <para>Without this, players see a random citizen's procedural outfit
    /// on each other's avatars instead of the customized look they chose in
    /// the AppearancePanel.</para></summary>
    [HideFromIl2Cpp]
    public void ApplyAppearance(SoDCoop.Player.AppearanceConfig cfg)
    {
        _pendingAppearance = cfg;
        try
        {
            // Find the CitizenOutfitController on the clone (CitizenVisualCloner
            // preserves it). If the visual hasn't been upgraded yet (still on
            // the capsule fallback), stash + bail — OnVisualUpgraded replays.
            var ctrl = GetComponentInChildren<global::CitizenOutfitController>();
            if (ctrl == null) return;
            cfg.ApplyTo(ctrl);
        }
        catch { /* outfitController may be mid-init — replay on next upgrade */ }
    }

    /// <summary>Called when we revert to the capsule fallback (citizen rig destroyed).</summary>
    [HideFromIl2Cpp]
    public void OnVisualReverted()
    {
        _animator = null;
        _animatorParamsScanned = false;
        _animSpeedHash = _animIsRunningHash = _animIsCrouchingHash = -1;
        // Citizen rig destroyed — drop attached visuals so they don't dangle.
        // (They are rebuilt on whichever body shows next — OnBodyChanged.)
        if (_heldVisual != null)
        {
            try { Object.Destroy(_heldVisual); } catch { }
            _heldVisual = null;
        }
        if (_flashlight != null)
        {
            try { Object.Destroy(_flashlight.gameObject); } catch { }
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
        // The player left (or the session ended) while we were driving their
        // twin. Hand the twin's root motion back — a twin released to the city
        // later (character reset → UnfreezeTwin) would otherwise walk without
        // it. The twin's transform is left where the player last stood.
        try { _twinRootMotion.Restore(); } catch { }
        try
        {
            if (_twinDown) SetTwinRagdoll(false);
            if (_twin != null && (_hiding || _twinHiddenForCorpse > 0))
                SoDCoop.Sync.TwinManager.SetBodyVisible(_twin.humanID, true);
            if (_twin != null && _combatStanceSet) _twin.animationController?.SetInCombat(false);
        }
        catch { }
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
