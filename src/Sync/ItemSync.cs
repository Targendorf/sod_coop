using SoDCoop.Network;
using LiteNetLib;
using SoDCoop.Network.Steam;
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

            Plugin.Log.LogDebug($"[ItemSync] Pickup broadcast id={interactableId}");
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

            Plugin.Log.LogDebug($"[ItemSync] Drop broadcast id={interactableId} pos={dropPos}");
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
    public static void SendSnapshotTo(SteamPeer peer)
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
            Plugin.Log.LogInfo($"[ItemSync] snapshot: pickups={picked} → {peer.SteamId.m_SteamID}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ItemSync.SendSnapshotTo: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
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
        => ApplyPickupFromZdo(senderPlayerId: -1, interactableId: p.InteractableId);

    /// <summary>ZDO entry — invoked from <c>ZdoEvents.OnItemPickup</c>.</summary>
    public static void ApplyPickupFromZdo(int senderPlayerId, int interactableId)
    {
        _ = senderPlayerId;
        var inter = FindInteractableById(interactableId);
        if (inter == null)
        {
            Plugin.Log.LogWarning($"[ItemSync] ApplyPickup: id={interactableId} not found");
            return;
        }

        IsApplyingRemote = true;
        try
        {
            var go = inter.spawnedObject;
            if (go != null && go.activeSelf)
            {
                go.SetActive(false);
                Plugin.Log.LogDebug($"[ItemSync] Applied pickup id={interactableId} (hidden)");
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[ItemSync] ApplyPickup({interactableId}): {ex.Message}");
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
        // Legacy packet carries no rotation; keep the item's own.
        Vector3 euler = default;
        try { var inter = FindInteractableById(p.InteractableId); if (inter != null) euler = inter.wEuler; } catch { }
        ApplyDropFromZdo(-1, p.InteractableId, DROP_HAS_POSITION, p.DropPosition, euler);
    }

    /// <summary>Drop flag: <c>pos</c>/<c>euler</c> say where the item now is.</summary>
    public const byte DROP_HAS_POSITION = 1;
    /// <summary>Drop flag: the item left the world instead (eaten, used up,
    /// destroyed) — receivers keep it hidden.</summary>
    public const byte DROP_GONE = 2;

    /// <summary>Sender side of a drop: read where the item ended up, right after
    /// it left the local inventory.</summary>
    public static void GetDropInfo(int interactableId, out byte flags, out Vector3 pos, out Vector3 euler)
    {
        flags = 0;
        pos = default;
        euler = default;
        try
        {
            var inter = FindInteractableById(interactableId);
            if (inter == null || inter.rem) { flags = DROP_GONE; return; }
            // Handed to someone (an NPC, a container holder) rather than put
            // down: it is not in the world, so receivers must not show it.
            if (inter.inInventory != null) { flags = DROP_GONE; return; }

            var go = inter.spawnedObject;
            if (go != null && go.activeInHierarchy)
            {
                pos = go.transform.position;
                euler = go.transform.eulerAngles;
            }
            else
            {
                pos = inter.wPos;
                euler = inter.wEuler;
            }
            flags = DROP_HAS_POSITION;
        }
        catch { flags = 0; }
    }

    /// <summary>ZDO entry — invoked from <c>ZdoEvents.OnItemDrop</c>.
    ///
    /// <para>Moves the item's DATA, not only its GameObject: SoD despawns and
    /// respawns interactables as rooms load around the player, from
    /// <c>wPos</c>. A transform-only move snapped back the next time the room
    /// reloaded.</para></summary>
    public static void ApplyDropFromZdo(int senderPlayerId, int interactableId,
                                        byte flags = 0, Vector3 pos = default, Vector3 euler = default)
    {
        _ = senderPlayerId;
        var inter = FindInteractableById(interactableId);
        if (inter == null)
        {
            Plugin.Log.LogWarning($"[ItemSync] ApplyDropFromZdo: id={interactableId} not found");
            return;
        }
        IsApplyingRemote = true;
        try
        {
            // Held by someone in THIS world (a joiner starts with a copy of the
            // host's inventory). Moving it would pull it out of that inventory.
            Human holder = null;
            try { holder = inter.inInventory; } catch { }
            if (holder != null)
            {
                Plugin.Log.LogDebug($"[ItemSync] drop id={interactableId}: held locally — left alone.");
                return;
            }

            var go = inter.spawnedObject;
            if ((flags & DROP_GONE) != 0)
            {
                if (go != null && go.activeSelf) go.SetActive(false);
                return;
            }

            if ((flags & DROP_HAS_POSITION) != 0)
            {
                try { inter.MoveInteractable(pos, euler, true); }
                catch (System.Exception ex) { Plugin.Log.LogDebug($"[ItemSync] MoveInteractable({interactableId}): {ex.Message}"); }
                go = inter.spawnedObject;
                if (go != null)
                {
                    go.transform.position = pos;
                    go.transform.eulerAngles = euler;
                }
            }

            if (go != null && !go.activeSelf)
            {
                go.SetActive(true);
                Plugin.Log.LogDebug($"[ItemSync] Applied drop (zdo) id={interactableId}");
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[ItemSync] ApplyDropFromZdo({interactableId}): {ex.Message}");
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
