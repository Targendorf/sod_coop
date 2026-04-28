using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Mirrors elevator floor-button presses across machines.
///
/// Each elevator is a physical object — SoD doesn't load/unload a separate
/// scene when it travels. Both machines simulate the lift's physics
/// independently from the same starting state. The only thing that needs
/// to cross the wire is the trigger: which floor was requested. Once both
/// sides receive the same <c>CallElevator(floor, up)</c>, their physics
/// move in lockstep.
///
/// Cross-machine identity:
///   <c>(building.buildingID, bottom.globalTileCoord)</c> — both deterministic
///   from the world seed. Lookup walks <c>SessionData.activeElevators</c>
///   for the matching pair.
/// </summary>
public static class ElevatorSync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void BroadcastCall(Elevator elevator, int newFloor, bool upButton)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (elevator == null) return;

        try
        {
            var building = elevator.building;
            var bottom   = elevator.bottom;
            if (building == null || bottom == null) return;

            var packet = new ElevatorCallPacket
            {
                SenderId        = NetworkManager.LocalPlayerId,
                BuildingId      = building.buildingID,
                BottomTileCoord = bottom.globalTileCoord,
                NewFloor        = newFloor,
                UpButton        = upButton,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.ElevatorCall, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[ElevatorSync] call broadcast bld={packet.BuildingId} btm={packet.BottomTileCoord} floor={newFloor} up={upButton}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ElevatorSync.BroadcastCall: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        if (type != PacketType.ElevatorCall) return;

        try
        {
            var p = new ElevatorCallPacket();
            p.Deserialize(reader);
            if (p.SenderId == NetworkManager.LocalPlayerId) return;
            ApplyCall(p);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"ElevatorSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyCall(ElevatorCallPacket p)
    {
        try
        {
            var elevator = ResolveElevator(p.BuildingId, p.BottomTileCoord);
            if (elevator == null)
            {
                Plugin.Log.LogWarning(
                    $"[ElevatorSync] ApplyCall: no elevator for building {p.BuildingId} btm {p.BottomTileCoord}");
                return;
            }

            IsApplyingRemote = true;
            try
            {
                elevator.CallElevator(p.NewFloor, p.UpButton);
                Plugin.Log.LogInfo($"[ElevatorSync] applied call bld={p.BuildingId} floor={p.NewFloor} up={p.UpButton}");
            }
            finally
            {
                IsApplyingRemote = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"ElevatorSync.ApplyCall failed: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Lookup
    // ─────────────────────────────────────────────────────────────────────────

    private static Elevator ResolveElevator(int buildingId, Vector3Int bottomTileCoord)
    {
        try
        {
            var sd = SessionData.Instance;
            var list = sd?.activeElevators;
            if (list == null) return null;

            for (int i = 0; i < list.Count; i++)
            {
                var e = list[i];
                if (e == null) continue;
                if (e.building == null || e.bottom == null) continue;
                if (e.building.buildingID != buildingId) continue;
                if (e.bottom.globalTileCoord != bottomTileCoord) continue;
                return e;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ElevatorSync.ResolveElevator: {ex.Message}");
        }
        return null;
    }
}
