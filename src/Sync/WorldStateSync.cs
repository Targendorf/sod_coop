using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Doors + lights synchronisation.
///
/// Network ID = Interactable.id (sequential int per city, deterministic given
/// the same world seed). NewDoor exposes its Interactable via doorInteractable;
/// LightController exposes it via interactable.
///
/// Outbound: Harmony patches detect local state changes and call BroadcastXxx.
/// Inbound: ApplyXxx routes via Interactable lookup, calls SetOpen / SetOn,
/// guarded by IsApplyingRemote so the patch doesn't echo back.
/// </summary>
public static class WorldStateSync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    // -------------------------------------------------------------------------
    //  Outbound
    // -------------------------------------------------------------------------

    public static void BroadcastDoorState(int interactableId, bool isClosed)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new DoorStatePacket { InteractableId = interactableId, IsClosed = isClosed };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.DoorState, _writer, DeliveryMethod.ReliableOrdered);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastDoorState({interactableId}): {ex.Message}");
        }
    }

    public static void BroadcastLightState(int interactableId, bool isOn)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new LightStatePacket { InteractableId = interactableId, IsOn = isOn };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.LightState, _writer, DeliveryMethod.ReliableOrdered);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastLightState({interactableId}): {ex.Message}");
        }
    }

    // -------------------------------------------------------------------------
    //  Inbound
    // -------------------------------------------------------------------------

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        try
        {
            if (type == PacketType.DoorState)
            {
                var p = new DoorStatePacket();
                p.Deserialize(reader);
                ApplyDoorState(p);
            }
            else if (type == PacketType.LightState)
            {
                var p = new LightStatePacket();
                p.Deserialize(reader);
                ApplyLightState(p);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"WorldStateSync.OnPacketReceived({type}): {ex.Message}");
        }
    }

    private static void ApplyDoorState(DoorStatePacket p)
    {
        var door = FindDoorByInteractableId(p.InteractableId);
        if (door == null) return;
        if (door.isClosed == p.IsClosed) return;

        IsApplyingRemote = true;
        try
        {
            float angle = p.IsClosed ? 0f : door.openAngle;
            // SetOpen(angle, openedBy, isClosing, speedMP)
            door.SetOpen(angle, null, p.IsClosed, 1f);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyDoorState({p.InteractableId}): {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    private static void ApplyLightState(LightStatePacket p)
    {
        var light = FindLightByInteractableId(p.InteractableId);
        if (light == null) return;
        if (light.isOn == p.IsOn) return;

        IsApplyingRemote = true;
        try
        {
            // SetOn(on, instant)
            light.SetOn(p.IsOn, true);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyLightState({p.InteractableId}): {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    // -------------------------------------------------------------------------
    //  Lookup helpers
    // -------------------------------------------------------------------------

    /// <summary>
    /// Linear scan of CityData.doorDictionary looking for a NewDoor whose
    /// doorInteractable.id matches. SoD has ~hundreds of doors per city so
    /// this is cheap enough for once-per-packet lookup.
    /// </summary>
    private static NewDoor FindDoorByInteractableId(int id)
    {
        try
        {
            var dict = CityData.Instance?.doorDictionary;
            if (dict == null) return null;

            foreach (var kv in dict)
            {
                var d = kv.Value;
                if (d == null) continue;
                if (d.doorInteractable != null && d.doorInteractable.id == id)
                    return d;
            }
        }
        catch { }
        return null;
    }

    /// <summary>
    /// Look up an Interactable by id, then find LightController on its spawnedObject.
    /// </summary>
    private static LightController FindLightByInteractableId(int id)
    {
        try
        {
            var inter = FindInteractableById(id);
            if (inter == null) return null;

            // spawnedObject is the in-world GameObject of this interactable.
            var go = inter.spawnedObject;
            if (go == null) return null;

            // LightController is an Assembly-CSharp type — generic GetComponent works.
            return go.GetComponentInChildren<LightController>(true);
        }
        catch { }
        return null;
    }

    private static Interactable FindInteractableById(int id)
    {
        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return null;

            // Most-likely fast path: directory index == id.
            if (id >= 0 && id < dir.Count)
            {
                var candidate = dir[id];
                if (candidate != null && candidate.id == id) return candidate;
            }

            // Fallback: linear scan.
            for (int i = 0; i < dir.Count; i++)
            {
                var c = dir[i];
                if (c != null && c.id == id) return c;
            }
        }
        catch { }
        return null;
    }
}
