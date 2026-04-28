using SoDCoop.Network;
using SoDCoop.Player;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Per-player inventory visibility (Phase 1).
///
/// Inventories themselves are intentionally NOT shared — each player carries
/// their own slots privately. What we DO share is what the other player is
/// visibly doing with their items:
///
///   • Held item       — Interactable currently equipped in the right hand.
///   • Raised stance   — combat-ready vs holstered.
///   • Flashlight      — torch on / off.
///
/// Held item is poll-based: we read <c>FirstPersonItemController.Instance</c>
/// each frame in <see cref="Update"/>, resolve which inventory slot's
/// <c>FirstPersonItem</c> matches <c>currentItem</c>, and broadcast the slot's
/// <c>interactableID</c> on change. This avoids hooking every internal SoD
/// path that swaps the equipped item (hotkeys, pickups, slot drops, etc).
///
/// Raised / flashlight are event-based: Harmony postfix patches in
/// <see cref="GamePatches"/> call <see cref="BroadcastRaised"/> and
/// <see cref="BroadcastFlashlight"/> immediately when the local player changes
/// state.
/// </summary>
public static class InventorySync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    // Last-broadcast state — only emit on actual change.
    private static int  _lastHeldId       = int.MinValue;
    private static bool _lastRaised;
    private static bool _lastFlashlight;
    private static bool _hasLastRaised;
    private static bool _hasLastFlashlight;

    // ─────────────────────────────────────────────────────────────────────────
    //  Update — poll currentItem and broadcast on change
    // ─────────────────────────────────────────────────────────────────────────

    public static void Update()
    {
        if (!NetworkManager.IsConnected) return;
        if (NetworkManager.LocalPlayerId < 0) return;

        try
        {
            var fpc = FirstPersonItemController.Instance;
            int currentId = -1;
            if (fpc != null)
            {
                var fpi = fpc.currentItem;
                if (fpi != null)
                {
                    currentId = ResolveHeldInteractableId(fpc, fpi);
                }
            }

            if (currentId == _lastHeldId) return;
            _lastHeldId = currentId;
            BroadcastHeldRaw(currentId);
        }
        catch { /* swallow — held-item polling is best-effort */ }
    }

    /// <summary>
    /// Walk <c>fpc.slots</c> and find the slot whose <c>GetFirstPersonItem()</c>
    /// matches the equipped one — its <c>interactableID</c> is what's in hand.
    /// </summary>
    private static int ResolveHeldInteractableId(FirstPersonItemController fpc, FirstPersonItem fpi)
    {
        try
        {
            var slots = fpc.slots;
            if (slots == null) return -1;
            for (int i = 0; i < slots.Count; i++)
            {
                var s = slots[i];
                if (s == null) continue;
                FirstPersonItem item = null;
                try { item = s.GetFirstPersonItem(); } catch { }
                if (item != null && item.Pointer == fpi.Pointer)
                {
                    int id = s.interactableID;
                    return id > 0 ? id : -1;
                }
            }
        }
        catch { }
        return -1;
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound
    // ─────────────────────────────────────────────────────────────────────────

    private static void BroadcastHeldRaw(int interactableId)
    {
        try
        {
            var packet = new ItemHeldPacket
            {
                PlayerId       = NetworkManager.LocalPlayerId,
                InteractableId = interactableId,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.ItemHeld, _writer, DeliveryMethod.ReliableOrdered);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"InventorySync.BroadcastHeld: {ex.Message}");
        }
    }

    public static void BroadcastRaised(bool isRaised)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (_hasLastRaised && _lastRaised == isRaised) return;
        _hasLastRaised = true;
        _lastRaised = isRaised;

        try
        {
            var packet = new ItemRaisedPacket
            {
                PlayerId  = NetworkManager.LocalPlayerId,
                IsRaised  = isRaised,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.ItemRaised, _writer, DeliveryMethod.ReliableOrdered);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"InventorySync.BroadcastRaised: {ex.Message}");
        }
    }

    public static void BroadcastFlashlight(bool isOn)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (_hasLastFlashlight && _lastFlashlight == isOn) return;
        _hasLastFlashlight = true;
        _lastFlashlight = isOn;

        try
        {
            var packet = new ItemFlashlightPacket
            {
                PlayerId = NetworkManager.LocalPlayerId,
                IsOn     = isOn,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.ItemFlashlight, _writer, DeliveryMethod.ReliableOrdered);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"InventorySync.BroadcastFlashlight: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound — apply onto the matching RemotePlayer
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        try
        {
            if (type == PacketType.ItemHeld)
            {
                var p = new ItemHeldPacket();
                p.Deserialize(reader);
                if (p.PlayerId == NetworkManager.LocalPlayerId) return;
                var rp = RemotePlayerManager.GetPlayer(p.PlayerId);
                if (rp == null) return;
                IsApplyingRemote = true;
                try { rp.ApplyHeldItem(p.InteractableId); }
                finally { IsApplyingRemote = false; }
            }
            else if (type == PacketType.ItemRaised)
            {
                var p = new ItemRaisedPacket();
                p.Deserialize(reader);
                if (p.PlayerId == NetworkManager.LocalPlayerId) return;
                var rp = RemotePlayerManager.GetPlayer(p.PlayerId);
                if (rp == null) return;
                IsApplyingRemote = true;
                try { rp.ApplyRaised(p.IsRaised); }
                finally { IsApplyingRemote = false; }
            }
            else if (type == PacketType.ItemFlashlight)
            {
                var p = new ItemFlashlightPacket();
                p.Deserialize(reader);
                if (p.PlayerId == NetworkManager.LocalPlayerId) return;
                var rp = RemotePlayerManager.GetPlayer(p.PlayerId);
                if (rp == null) return;
                IsApplyingRemote = true;
                try { rp.ApplyFlashlight(p.IsOn); }
                finally { IsApplyingRemote = false; }
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"InventorySync.OnPacketReceived({type}): {ex.Message}");
        }
    }
}
