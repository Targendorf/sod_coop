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

    public void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
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
    }

    private void OnRemotePlayerPosition(PlayerPositionPacket packet)
    {
        if (packet.PlayerId < 0) return;
        if (packet.PlayerId == NetworkManager.LocalPlayerId) return;

        var rp = RemotePlayerManager.GetPlayer(packet.PlayerId);
        if (rp == null)
        {
            RemotePlayerManager.SpawnRemotePlayer(packet.PlayerId, $"Player {packet.PlayerId}");
            rp = RemotePlayerManager.GetPlayer(packet.PlayerId);
        }
        rp?.ApplyPositionState(packet);
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
