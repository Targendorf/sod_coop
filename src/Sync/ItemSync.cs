using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Item pickup / drop synchronisation.
///
/// Both players load an identical city from the same seed, so every Interactable
/// gets the same numeric <c>id</c> on both machines. We exploit that to keep
/// packets tiny: no names, no preset data — just the id and, on drops, the
/// world-space landing position.
///
/// Outbound (host or client — both can pick things up):
///   • Pickup — fired from the <see cref="FirstPersonItemController.PickUpItem"/> postfix.
///              Sent only when the call succeeds (__result == true).
///   • Drop   — fired from the <see cref="FirstPersonItemController.EmptySlot"/> pair.
///              Prefix captures the interactableID; postfix reads the drop position
///              from the interactable's spawnedObject (already placed by the game).
///              Skipped when destroyObject==true (consumed / binned items).
///
/// Inbound:
///   • Pickup → hide spawnedObject. The item is now in someone's inventory.
///   • Drop   → teleport spawnedObject to DropPosition and show it.
///
/// Re-entrancy guard: <see cref="IsApplyingRemote"/> prevents the patches from
/// echoing a remote-applied change back out over the network.
/// </summary>
public static class ItemSync
{
    /// <summary>
    /// True while we are applying a remote packet so the Harmony patches don't
    /// re-broadcast the change.
    /// </summary>
    public static bool IsApplyingRemote { get; private set; }

    /// <summary>
    /// Cooperative scope for systems that need to manipulate inventory slots
    /// without ItemSync's pickup / drop patches re-broadcasting (e.g. the
    /// player-to-player handoff path in <see cref="InventorySync"/>).
    /// Calls must be balanced.
    /// </summary>
    public static void BeginSuppression() => IsApplyingRemote = true;
    public static void EndSuppression()   => IsApplyingRemote = false;

    private static readonly NetDataWriter _writer = new();

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Broadcast that the local player picked up <paramref name="interactableId"/>.
    /// Called from the <c>FirstPersonItemController.PickUpItem</c> postfix.
    /// </summary>
    public static void BroadcastPickup(int interactableId)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new ItemPickupPacket
            {
                PlayerId      = NetworkManager.LocalPlayerId,
                InteractableId = interactableId,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.PlayerPickup, _writer, DeliveryMethod.ReliableOrdered);

            Plugin.Log.LogInfo($"[ItemSync] Pickup broadcast id={interactableId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ItemSync.BroadcastPickup({interactableId}): {ex.Message}");
        }
    }

    /// <summary>
    /// Broadcast that the local player dropped <paramref name="interactableId"/>.
    /// Called from the <c>FirstPersonItemController.EmptySlot</c> postfix.
    /// Reads the drop position from the interactable's spawnedObject — the game
    /// has already placed it in the world before the postfix fires.
    /// </summary>
    public static void BroadcastDrop(int interactableId)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var inter = FindInteractableById(interactableId);
            if (inter == null)
            {
                Plugin.Log.LogWarning($"[ItemSync] BroadcastDrop: interactable {interactableId} not found");
                return;
            }

            // After EmptySlot the spawnedObject is back in the world.
            // Prefer transform.position (physics may have nudged it); fall back to wPos.
            Vector3 dropPos;
            try
            {
                var go = inter.spawnedObject;
                dropPos = (go != null) ? go.transform.position : inter.wPos;
            }
            catch
            {
                dropPos = inter.wPos;
            }

            var packet = new ItemDropPacket
            {
                InteractableId = interactableId,
                DropPosition   = dropPos,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.PlayerDrop, _writer, DeliveryMethod.ReliableOrdered);

            Plugin.Log.LogInfo($"[ItemSync] Drop broadcast id={interactableId} pos={dropPos}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ItemSync.BroadcastDrop({interactableId}): {ex.Message}");
        }
    }

    /// <summary>
    /// Late-join snapshot. Walk the city's interactableDirectory and tell
    /// the freshly-joined peer which items have been picked up (i.e. are
    /// currently in someone's inventory) so they hide the in-world copies
    /// to match the host's authoritative state. Without this, host's
    /// pre-connect pickups stay visible on the client and both players
    /// can race to grab the same coin / document.
    ///
    /// <para>Only emits for items where <c>inInventory != null</c> — that
    /// matches the live <see cref="BroadcastPickup"/> path. Items that were
    /// picked up and dropped at a non-default location aren't covered (no
    /// stable "default position" reference field in Interactable to diff
    /// against). In practice players see misaligned drop positions only
    /// for items host moved before the client connected — an acceptable
    /// gap for v1.</para>
    /// </summary>
    public static void SendSnapshotTo(NetPeer peer)
    {
        if (peer == null) return;
        if (!NetworkManager.IsHost) return;

        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return;

            int picked = 0;
            for (int i = 0; i < dir.Count; i++)
            {
                var inter = dir[i];
                if (inter == null) continue;

                // "Picked up" = held by someone. Apply on receiver hides the
                // spawnedObject; SetActive(false) on an already-hidden item
                // is harmless, so this is idempotent vs the client's own
                // save-restored state.
                Human holder = null;
                try { holder = inter.inInventory; } catch { }
                if (holder == null) continue;

                var pkt = new ItemPickupPacket
                {
                    PlayerId       = NetworkManager.LocalPlayerId,
                    InteractableId = inter.id,
                };
                _writer.Reset();
                pkt.Serialize(_writer);
                NetworkManager.SendTo(peer, PacketType.PlayerPickup, _writer, DeliveryMethod.ReliableOrdered);
                picked++;
            }
            Plugin.Log.LogInfo($"[ItemSync] snapshot: pickups={picked} → {peer.Address}:{peer.Port}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ItemSync.SendSnapshotTo: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        try
        {
            if (type == PacketType.PlayerPickup)
            {
                var p = new ItemPickupPacket();
                p.Deserialize(reader);
                // Ignore echoes of our own packets.
                if (p.PlayerId == NetworkManager.LocalPlayerId) return;
                ApplyPickup(p);
            }
            else if (type == PacketType.PlayerDrop)
            {
                var p = new ItemDropPacket();
                p.Deserialize(reader);
                ApplyDrop(p);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"ItemSync.OnPacketReceived({type}): {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Apply helpers
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Hide the in-world object — it is now inside another player's inventory.
    /// </summary>
    private static void ApplyPickup(ItemPickupPacket p)
    {
        var inter = FindInteractableById(p.InteractableId);
        if (inter == null)
        {
            Plugin.Log.LogWarning($"[ItemSync] ApplyPickup: id={p.InteractableId} not found");
            return;
        }

        IsApplyingRemote = true;
        try
        {
            var go = inter.spawnedObject;
            if (go != null && go.activeSelf)
            {
                go.SetActive(false);
                Plugin.Log.LogInfo($"[ItemSync] Applied pickup id={p.InteractableId} (hidden)");
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[ItemSync] ApplyPickup({p.InteractableId}): {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    /// <summary>
    /// Teleport and show the in-world object — it has been returned to the world.
    /// </summary>
    private static void ApplyDrop(ItemDropPacket p)
    {
        var inter = FindInteractableById(p.InteractableId);
        if (inter == null)
        {
            Plugin.Log.LogWarning($"[ItemSync] ApplyDrop: id={p.InteractableId} not found");
            return;
        }

        IsApplyingRemote = true;
        try
        {
            var go = inter.spawnedObject;
            if (go != null)
            {
                go.transform.position = p.DropPosition;
                if (!go.activeSelf) go.SetActive(true);
                Plugin.Log.LogInfo($"[ItemSync] Applied drop id={p.InteractableId} pos={p.DropPosition}");
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[ItemSync] ApplyDrop({p.InteractableId}): {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Lookup
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// O(1) fast path (id == index) with O(n) fallback for unusual layouts.
    /// Identical pattern to WorldStateSync.FindInteractableById.
    /// </summary>
    private static Interactable FindInteractableById(int id)
    {
        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return null;

            // Fast path — most items have id == list index.
            if (id >= 0 && id < dir.Count)
            {
                var c = dir[id];
                if (c != null && c.id == id) return c;
            }

            // Fallback linear scan.
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
