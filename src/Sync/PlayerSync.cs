using SoDCoop.Network;
using SoDCoop.Player;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Sends local player state at an adaptive rate (4–30 Hz) and applies remote
/// snapshots to RemotePlayer instances.
/// </summary>
public class PlayerSync
{
    #region Tuning

    // Send-rate buckets, picked by current speed.
    private const float RATE_IDLE     = 0.25f;  // 4 Hz keepalive when standing still
    private const float RATE_WALK     = 1f / 15f;
    private const float RATE_RUN      = 1f / 30f;
    private const float SPEED_WALK    = 0.15f;  // m/s threshold above which we count as moving
    private const float SPEED_RUN     = 3.0f;   // ~jog/run threshold

    // Deadband: even at the chosen rate, skip if nothing meaningful changed.
    private const float POSITION_DEADBAND = 0.005f;
    private const float ROTATION_DEADBAND = 0.5f;
    // ...except force a keepalive at least this often.
    private const float KEEPALIVE_INTERVAL = 0.5f;

    #endregion

    #region State

    private float _lastSendTime;
    private float _lastKeepaliveTime;
    private Vector3 _lastSentPosition;
    private Quaternion _lastSentRotation = Quaternion.identity;
    private Vector3 _lastFramePosition;
    private float _lastFrameTime;
    private ushort _sequence;
    private readonly NetDataWriter _writer = new();

    // Vitals — small float bundle, sent at 1 Hz. Cached on remote players for HUD.
    private float _lastVitalsSendTime;
    private const float VITALS_INTERVAL = 1.0f;
    private readonly NetDataWriter _vitalsWriter = new();

    /// <summary>Latest vitals received per remote player (PlayerId → packet).</summary>
    private static readonly System.Collections.Generic.Dictionary<int, PlayerVitalsPacket> _remoteVitals = new();
    public static System.Collections.Generic.IReadOnlyDictionary<int, PlayerVitalsPacket> RemoteVitals => _remoteVitals;

    #endregion

    public void Update()
    {
        if (!NetworkManager.IsConnected) return;
        if (NetworkManager.LocalPlayerId < 0) return;

        var player = GetLocalPlayer();
        if (player == null) return;

        var pos = player.transform.position;
        var rot = player.transform.rotation;

        // Estimate velocity from frame delta (Rigidbody.velocity isn't reliable on SoD's controller).
        Vector3 velocity = Vector3.zero;
        float now = Time.unscaledTime;
        float frameDt = now - _lastFrameTime;
        if (_lastFrameTime > 0f && frameDt > 1e-4f)
        {
            velocity = (pos - _lastFramePosition) / frameDt;
        }
        _lastFramePosition = pos;
        _lastFrameTime = now;

        float speed = velocity.magnitude;
        float interval = speed >= SPEED_RUN ? RATE_RUN
                       : speed >= SPEED_WALK ? RATE_WALK
                       : RATE_IDLE;

        if (now - _lastSendTime < interval) return;

        // Deadband: if barely changed and keepalive isn't due, skip.
        float posDelta = Vector3.Distance(pos, _lastSentPosition);
        float rotDelta = Quaternion.Angle(rot, _lastSentRotation);
        bool changed = posDelta > POSITION_DEADBAND || rotDelta > ROTATION_DEADBAND;
        bool keepaliveDue = (now - _lastKeepaliveTime) >= KEEPALIVE_INTERVAL;
        if (!changed && !keepaliveDue) return;

        SendPosition(pos, rot, velocity, speed);

        _lastSendTime = now;
        _lastSentPosition = pos;
        _lastSentRotation = rot;
        if (!changed || keepaliveDue) _lastKeepaliveTime = now;

        // Vitals at 1 Hz alongside position.
        if (now - _lastVitalsSendTime >= VITALS_INTERVAL)
        {
            _lastVitalsSendTime = now;
            SendVitals();
        }
    }

    private void SendVitals()
    {
        try
        {
            var p = global::Player.Instance;
            if (p == null) return;

            var packet = new PlayerVitalsPacket
            {
                PlayerId    = NetworkManager.LocalPlayerId,
                Nourishment = PlayerVitalsPacket.Pack(SafeGetVital(p, "nourishment")),
                Hydration   = PlayerVitalsPacket.Pack(SafeGetVital(p, "hydration")),
                Energy      = PlayerVitalsPacket.Pack(SafeGetVital(p, "energy")),
                IsDead      = SafeGetIsDead(p),
            };

            _vitalsWriter.Reset();
            packet.Serialize(_vitalsWriter);
            NetworkManager.SendToAll(PacketType.PlayerVitals, _vitalsWriter, DeliveryMethod.Sequenced);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"SendVitals: {ex.Message}");
        }
    }

    private static float SafeGetVital(global::Player p, string field)
    {
        // Player extends Human — these vitals live on Human (nourishment/hydration/energy).
        try
        {
            switch (field)
            {
                case "nourishment": return p.nourishment;
                case "hydration":   return p.hydration;
                case "energy":      return p.energy;
            }
        }
        catch { }
        return 1f;
    }

    private static bool SafeGetIsDead(global::Player p)
    {
        try { return p.isDead; } catch { return false; }
    }

    private void SendPosition(Vector3 pos, Quaternion rot, Vector3 velocity, float speed)
    {
        byte flags = 0;
        if (speed >= SPEED_RUN) flags |= (byte)MovementFlags.Running;
        // Crouch/Grounded reads disabled until we confirm SoD's Player API field names —
        // the protocol bits are preserved so we can flip them on without a wire change.

        var packet = new PlayerPositionPacket
        {
            PlayerId  = NetworkManager.LocalPlayerId,
            Sequence  = unchecked(_sequence++),
            Flags     = flags,
            Position  = pos,
            Rotation  = rot,
            Velocity  = velocity,
            Timestamp = Time.unscaledTime,
        };

        _writer.Reset();
        packet.Serialize(_writer);
        NetworkManager.SendToAll(PacketType.PlayerPosition, _writer, DeliveryMethod.Sequenced);
    }

    public void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
    {
        if (type == PacketType.PlayerPosition)
        {
            var packet = new PlayerPositionPacket();
            packet.Deserialize(reader);
            if (packet.PlayerId == NetworkManager.LocalPlayerId) return;
            OnRemotePlayerPosition(packet);
        }
        else if (type == PacketType.PlayerInteraction)
        {
            var packet = new PlayerInteractionPacket();
            packet.Deserialize(reader);
            if (packet.PlayerId == NetworkManager.LocalPlayerId) return;
            // TODO: apply interaction
        }
        else if (type == PacketType.PlayerVitals)
        {
            var packet = new PlayerVitalsPacket();
            packet.Deserialize(reader);
            if (packet.PlayerId == NetworkManager.LocalPlayerId) return;

            // Drive RemotePlayer's downed pose from the IsDead bit. This is
            // the resilient path: even if a PlayerDamage event packet got
            // dropped, the next vitals tick will bring the visual into sync.
            // PlayerDamage is the immediate path; this one is the safety net.
            try
            {
                _remoteVitals.TryGetValue(packet.PlayerId, out var prev);
                bool prevDead = prev.IsDead;
                if (prevDead != packet.IsDead)
                {
                    var rp = SoDCoop.Player.RemotePlayerManager.GetPlayer(packet.PlayerId);
                    rp?.SetDown(packet.IsDead);
                }
            }
            catch { }

            _remoteVitals[packet.PlayerId] = packet;
        }
    }

    private void OnRemotePlayerPosition(PlayerPositionPacket packet)
    {
        if (packet.PlayerId < 0) return;
        if (packet.PlayerId == NetworkManager.LocalPlayerId) return;

        var rp = RemotePlayerManager.GetPlayer(packet.PlayerId);
        if (rp == null)
        {
            // Look up the real name from the player roster; only fall back to
            // the placeholder if the position packet outraced the join event.
            string name = ResolveName(packet.PlayerId);
            RemotePlayerManager.SpawnRemotePlayer(packet.PlayerId, name);
            rp = RemotePlayerManager.GetPlayer(packet.PlayerId);
        }
        rp?.ApplyPositionState(packet);
    }

    private static string ResolveName(int playerId)
    {
        if (NetworkManager.Players != null
            && NetworkManager.Players.TryGetValue(playerId, out var info)
            && !string.IsNullOrEmpty(info.PlayerName))
        {
            return info.PlayerName;
        }
        return $"Player {playerId}";
    }

    public void SendInteraction(InteractionType type, int targetId, Vector3 targetPosition)
    {
        if (!NetworkManager.IsConnected) return;

        var packet = new PlayerInteractionPacket
        {
            PlayerId = NetworkManager.LocalPlayerId,
            InteractionType = type,
            TargetId = targetId,
            TargetPosition = targetPosition
        };
        _writer.Reset();
        packet.Serialize(_writer);
        NetworkManager.SendToAll(PacketType.PlayerInteraction, _writer, DeliveryMethod.ReliableOrdered);
    }

    private GameObject GetLocalPlayer()
    {
        try
        {
            var p = global::Player.Instance;
            if (p != null) return p.gameObject;
        }
        catch { }
        return null;
    }

}
