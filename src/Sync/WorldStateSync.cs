using SoDCoop.Network;
using LiteNetLib;
using SoDCoop.Network.Steam;
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
        if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForDoors) return; // ZDO path owns this surface
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

    /// <summary>
    /// Door locked / unlocked. Used by lockpicking, key use, scripted unlock —
    /// any path that calls NewDoor.SetLocked.
    /// </summary>
    public static void BroadcastDoorLockState(int interactableId, bool isLocked, bool playSound)
    {
        if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForDoors) return; // ZDO path owns this surface
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new DoorLockStatePacket
            {
                InteractableId = interactableId,
                IsLocked       = isLocked,
                PlaySound      = playSound,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.DoorLockState, _writer, DeliveryMethod.ReliableOrdered);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastDoorLockState({interactableId}): {ex.Message}");
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

    /// <summary>
    /// Broadcast a generic switch (drawer, cabinet, fridge, safe…) toggle.
    /// Called from the <c>Interactable.SetSwitchState</c> postfix, which already
    /// filters out lights so they don't double-broadcast on top of LightState.
    /// </summary>
    public static void BroadcastSwitchState(int interactableId, bool isOn)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new SwitchStatePacket { InteractableId = interactableId, IsOn = isOn };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.SwitchState, _writer, DeliveryMethod.ReliableOrdered);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastSwitchState({interactableId}): {ex.Message}");
        }
    }

    /// <summary>
    /// Walk the city's interactableDirectory and push current door / light /
    /// switch state to a freshly-joined peer so they don't see the world
    /// frozen in its initial-load configuration. Lockpick-opened doors,
    /// player-toggled lights, opened drawers all converge to the host's
    /// authoritative state.
    ///
    /// <para>Cost: O(N) over interactables (~5k–15k in a typical city) once
    /// per join. Each entry checks a couple of component refs and
    /// optionally fires one SendTo. Negligible CPU; bandwidth bounded by
    /// the number of items in non-default state.</para>
    /// </summary>
    public static void SendSnapshotTo(SteamPeer peer)
    {
        if (peer == null) return;
        if (!NetworkManager.IsHost) return;

        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return;

            int doors = 0, locks = 0, lights = 0, switches = 0;

            for (int i = 0; i < dir.Count; i++)
            {
                var inter = dir[i];
                if (inter == null) continue;

                // Door state: open/closed and locked/unlocked.
                NewDoor door = null;
                try { door = inter.spawnedObject?.GetComponent<NewDoor>(); } catch { }
                if (door != null)
                {
                    try
                    {
                        var pkt = new DoorStatePacket { InteractableId = inter.id, IsClosed = door.isClosed };
                        _writer.Reset();
                        pkt.Serialize(_writer);
                        NetworkManager.SendTo(peer, PacketType.DoorState, _writer, DeliveryMethod.ReliableOrdered);
                        doors++;
                    } catch { }

                    try
                    {
                        if (door.isLocked)
                        {
                            var pkt = new DoorLockStatePacket { InteractableId = inter.id, IsLocked = true, PlaySound = false };
                            _writer.Reset();
                            pkt.Serialize(_writer);
                            NetworkManager.SendTo(peer, PacketType.DoorLockState, _writer, DeliveryMethod.ReliableOrdered);
                            locks++;
                        }
                    } catch { }
                    continue; // doors aren't switches
                }

                // Light state: each LightController owns an Interactable.
                LightController light = null;
                try { light = inter.spawnedObject?.GetComponentInChildren<LightController>(true); } catch { }
                if (light != null)
                {
                    try
                    {
                        var pkt = new LightStatePacket { InteractableId = inter.id, IsOn = light.isOn };
                        _writer.Reset();
                        pkt.Serialize(_writer);
                        NetworkManager.SendTo(peer, PacketType.LightState, _writer, DeliveryMethod.ReliableOrdered);
                        lights++;
                    } catch { }
                    continue;
                }

                // Generic switch state (drawers, fridges, cabinets, etc.).
                // Only send when non-default to keep snapshot bandwidth bounded.
                try
                {
                    if (inter.sw0)
                    {
                        var pkt = new SwitchStatePacket { InteractableId = inter.id, IsOn = true };
                        _writer.Reset();
                        pkt.Serialize(_writer);
                        NetworkManager.SendTo(peer, PacketType.SwitchState, _writer, DeliveryMethod.ReliableOrdered);
                        switches++;
                    }
                } catch { }
            }

            Plugin.Log.LogInfo($"[WorldStateSync] snapshot: doors={doors} locks={locks} lights={lights} switches={switches} → {peer.SteamId.m_SteamID}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"WorldStateSync.SendSnapshotTo: {ex.Message}");
        }
    }

    // -------------------------------------------------------------------------
    //  Inbound
    // -------------------------------------------------------------------------

    public static void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
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
            else if (type == PacketType.SwitchState)
            {
                var p = new SwitchStatePacket();
                p.Deserialize(reader);
                ApplySwitchState(p);
            }
            else if (type == PacketType.DoorLockState)
            {
                var p = new DoorLockStatePacket();
                p.Deserialize(reader);
                ApplyDoorLockState(p);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"WorldStateSync.OnPacketReceived({type}): {ex.Message}");
        }
    }

    // ── Public helpers for ZDO resolvers (DoorResolver) ───────────────

    /// <summary>Apply door open/closed by Interactable.id. Wraps the legacy
    /// private ApplyDoorState path so the ZDO DoorResolver doesn't duplicate
    /// the lookup + IsApplyingRemote re-entrancy guard.</summary>
    public static void ApplyDoorStateBySodId(int interactableId, bool isClosed)
    {
        ApplyDoorState(new DoorStatePacket { InteractableId = interactableId, IsClosed = isClosed });
    }

    /// <summary>Apply door locked/unlocked by Interactable.id.</summary>
    public static void ApplyDoorLockBySodId(int interactableId, bool isLocked, bool playSound)
    {
        ApplyDoorLockState(new DoorLockStatePacket { InteractableId = interactableId, IsLocked = isLocked, PlaySound = playSound });
    }

    /// <summary>Apply light on/off by Interactable.id (used by LightResolver).</summary>
    public static void ApplyLightStateBySodId(int interactableId, bool isOn)
    {
        ApplyLightState(new LightStatePacket { InteractableId = interactableId, IsOn = isOn });
    }

    /// <summary>Apply switch on/off by Interactable.id (used by SwitchResolver).</summary>
    public static void ApplySwitchStateBySodId(int interactableId, bool isOn)
    {
        ApplySwitchState(new SwitchStatePacket { InteractableId = interactableId, IsOn = isOn });
    }

    /// <summary>Apply one of the custom1/2/3 switch slots on a remote-broadcast
    /// interactable. Used by <c>SwitchResolver</c> to mirror sw1..sw3 changes
    /// (TV / radio / music-player auxiliary state) — sw0 still flows via
    /// <see cref="ApplySwitchStateBySodId"/>. No-op if the interactable
    /// isn't found or is already at the target value (suppresses echo
    /// broadcasts on the receiver).</summary>
    public static void ApplyCustomSwitchStateBySodId(int interactableId,
        global::InteractablePreset.Switch slot, bool val)
    {
        var inter = FindInteractableById(interactableId);
        if (inter == null) return;

        bool cur = false;
        try
        {
            switch (slot)
            {
                case global::InteractablePreset.Switch.custom1: cur = inter.sw1; break;
                case global::InteractablePreset.Switch.custom2: cur = inter.sw2; break;
                case global::InteractablePreset.Switch.custom3: cur = inter.sw3; break;
                default: return; // only custom1..3 supported here; sw0 has its own path
            }
        }
        catch { return; }
        if (cur == val) return;

        IsApplyingRemote = true;
        try { inter.SetSwtichByType(slot, val, null, true, true); }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyCustomSwitchStateBySodId({interactableId}, {slot}, {val}): {ex.Message}");
        }
        finally { IsApplyingRemote = false; }
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

    /// <summary>
    /// Apply a remote switch toggle by calling Interactable.SetSwitchState directly.
    /// We pass interactor=null and forceUpdate=true so SoD treats it as an
    /// authoritative state change without re-running click animations.
    /// </summary>
    private static void ApplySwitchState(SwitchStatePacket p)
    {
        var inter = FindInteractableById(p.InteractableId);
        if (inter == null) return;
        if (inter.sw0 == p.IsOn) return;

        IsApplyingRemote = true;
        try
        {
            // SetSwitchState(val, interactor, playSFX, forceUpdate, forceInstantLights)
            inter.SetSwitchState(p.IsOn, null, true, true, false);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplySwitchState({p.InteractableId}): {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    private static void ApplyDoorLockState(DoorLockStatePacket p)
    {
        var door = FindDoorByInteractableId(p.InteractableId);
        if (door == null) return;
        if (door.isLocked == p.IsLocked) return;

        IsApplyingRemote = true;
        try
        {
            // SetLocked(val, actor, playSound). Actor=null is fine, it's only
            // used for sound attribution / awareness propagation.
            door.SetLocked(p.IsLocked, null, p.PlaySound);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyDoorLockState({p.InteractableId}): {ex.Message}");
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

    /// <summary>
    /// True if this Interactable's spawnedObject carries a LightController — used
    /// by the SetSwitchState patch to avoid double-broadcasting (lights have their
    /// own dedicated LightState channel).
    /// </summary>
    public static bool IsLightInteractable(Interactable inter)
    {
        try
        {
            var go = inter?.spawnedObject;
            if (go == null) return false;
            return go.GetComponentInChildren<LightController>(true) != null;
        }
        catch { return false; }
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
