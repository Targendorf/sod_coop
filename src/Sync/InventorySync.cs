using System.Collections.Generic;
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

    // ─────────────────────────────────────────────────────────────────────────
    //  Placement visual mocks (Phase 2)
    //
    //  Real Interactable lives only on the placer's machine. Other peers
    //  receive a stripped visual copy parented at the same world position so
    //  they can SEE that a codebreaker / wedge / tracker / mine is attached
    //  somewhere — they just can't interact with it. Placer-only functionality
    //  (e.g. codebreaker code reveal) stays single-machine, which is fine
    //  because only the placer's investigation needs that data.
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// All mock visuals we've spawned for remote-placed items, keyed by
    /// (placerPlayerId, placerInteractableId). Tracked so we could later
    /// support a "placement removed" packet that nukes the mock.
    /// </summary>
    private static readonly Dictionary<long, GameObject> _placedMocks = new();

    /// <summary>Lazy InteractablePreset name → preset registry.</summary>
    private static Dictionary<string, InteractablePreset> _presetByName;

    /// <summary>Compose a stable key from (playerId, sourceInteractableId).</summary>
    private static long MockKey(int playerId, int sourceInteractableId)
        => ((long)playerId << 32) | (uint)sourceInteractableId;

    /// <summary>
    /// Diff helper for placement patches: snapshot
    /// <c>CityData.interactableDirectory.Count</c> in the prefix, then walk
    /// new entries in the postfix to find what got placed.
    /// </summary>
    public static int SnapshotInteractableCount()
    {
        try { return CityData.Instance?.interactableDirectory?.Count ?? 0; }
        catch { return 0; }
    }

    /// <summary>
    /// Walk all interactables added to the directory after <paramref name="snapshotCount"/>
    /// and broadcast a placement-visual packet for each.
    /// </summary>
    public static void BroadcastPlacedSince(int snapshotCount)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var dir = CityData.Instance?.interactableDirectory;
            if (dir == null) return;
            if (dir.Count <= snapshotCount) return;

            for (int i = snapshotCount; i < dir.Count; i++)
            {
                var item = dir[i];
                if (item == null) continue;
                BroadcastPlace(item);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"InventorySync.BroadcastPlacedSince: {ex.Message}");
        }
    }

    private static void BroadcastPlace(Interactable item)
    {
        try
        {
            var preset = item.preset;
            if (preset == null || string.IsNullOrEmpty(preset.name)) return;

            // Pull the world transform from the spawnedObject if it exists,
            // else fall back to the interactable's own wPos/eulerAngles.
            Vector3 pos    = item.wPos;
            Vector3 euler  = Vector3.zero;
            try
            {
                var go = item.spawnedObject;
                if (go != null && go.transform != null)
                {
                    pos   = go.transform.position;
                    euler = go.transform.eulerAngles;
                }
            }
            catch { }

            var packet = new ItemPlaceVisualPacket
            {
                PlayerId        = NetworkManager.LocalPlayerId,
                PlacerSourceId  = item.id,
                PresetName      = preset.name,
                Position        = pos,
                EulerRotation   = euler,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.ItemPlaceVisual, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[InventorySync] place broadcast preset=\"{preset.name}\" id={item.id} pos={pos}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"InventorySync.BroadcastPlace: {ex.Message}");
        }
    }

    private static void ApplyPlace(ItemPlaceVisualPacket p)
    {
        try
        {
            var preset = ResolvePreset(p.PresetName);
            if (preset == null || preset.prefab == null)
            {
                Plugin.Log.LogWarning($"[InventorySync] ApplyPlace: preset \"{p.PresetName}\" not found");
                return;
            }

            // Don't double-spawn if we somehow already have a mock for this id.
            long key = MockKey(p.PlayerId, p.PlacerSourceId);
            if (_placedMocks.TryGetValue(key, out var existing) && existing != null) return;

            var go = Object.Instantiate(preset.prefab);
            if (go == null) return;

            go.name = $"CoopPlaceMock_{p.PlayerId}_{p.PlacerSourceId}_{p.PresetName}";
            go.transform.position    = p.Position;
            go.transform.eulerAngles = p.EulerRotation;

            // Strip behaviour components — visual only.
            StripPlacementMockComponents(go);

            _placedMocks[key] = go;
            Plugin.Log.LogInfo($"[InventorySync] applied place mock preset=\"{p.PresetName}\" pos={p.Position}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"InventorySync.ApplyPlace failed: {ex.Message}");
        }
    }

    /// <summary>
    /// Strip components that would re-run game logic on the placement mock
    /// (Interactable, Collider, Rigidbody, AudioSource, …). Leave only the
    /// visual rendering hierarchy.
    /// </summary>
    private static void StripPlacementMockComponents(GameObject go)
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
                // Keep transforms + visual renderers.
                if (typeName == "Transform" || typeName == "MeshFilter" ||
                    typeName == "MeshRenderer" || typeName == "SkinnedMeshRenderer" ||
                    typeName == "Light" || typeName == "LineRenderer" ||
                    typeName == "ParticleSystem" || typeName == "ParticleSystemRenderer")
                    continue;
                try { Object.Destroy(c); } catch { }
            }
        }
        catch { /* best-effort */ }
    }

    /// <summary>
    /// Resolve <c>InteractablePreset.name</c> to the actual preset asset.
    /// Mirrors SpatterSync.ResolvePreset — lazy
    /// <c>Resources.FindObjectsOfTypeAll</c> registry, rebuilt on cache miss.
    /// </summary>
    private static InteractablePreset ResolvePreset(string name)
    {
        if (string.IsNullOrEmpty(name)) return null;

        if (_presetByName != null && _presetByName.TryGetValue(name, out var cached))
            return cached;

        try
        {
            _presetByName = new Dictionary<string, InteractablePreset>();
            var all = Resources.FindObjectsOfTypeAll<InteractablePreset>();
            if (all == null) return null;
            for (int i = 0; i < all.Length; i++)
            {
                var pr = all[i];
                if (pr == null) continue;
                var n = pr.name;
                if (string.IsNullOrEmpty(n)) continue;
                _presetByName[n] = pr;
            }
            Plugin.Log.LogInfo($"[InventorySync] indexed {_presetByName.Count} InteractablePreset assets");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"InventorySync.ResolvePreset: {ex.Message}");
            return null;
        }

        return _presetByName.TryGetValue(name, out var fresh) ? fresh : null;
    }

    /// <summary>
    /// Tear down all mock visuals — called when network disconnects so we
    /// don't leave dangling decoration in the world.
    /// </summary>
    public static void ClearAllMocks()
    {
        try
        {
            foreach (var kv in _placedMocks)
            {
                if (kv.Value != null) Object.Destroy(kv.Value);
            }
        }
        catch { }
        _placedMocks.Clear();
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Phase 3b — NPC state mutations & player-to-NPC item transfer.
    //  Patches sit on the leaf state-changing methods (SetRestrained /
    //  SetStunned / TryGiveItem) so every code path that reaches them — player
    //  Handcuff/Takedown/Give, scripted scenes, cop arrests — is mirrored
    //  uniformly.
    // ─────────────────────────────────────────────────────────────────────────

    public static void BroadcastGive(int recipientHumanId, int itemInteractableId, bool defaultSuccess, bool enableSpeech)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (recipientHumanId < 0 || itemInteractableId < 0) return;

        try
        {
            var packet = new ItemGivePacket
            {
                GiverPlayerId      = NetworkManager.LocalPlayerId,
                RecipientHumanId   = recipientHumanId,
                ItemInteractableId = itemInteractableId,
                DefaultSuccess     = defaultSuccess,
                EnableSpeech       = enableSpeech,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.ItemGive, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[InventorySync] give broadcast item={itemInteractableId} → npc={recipientHumanId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"InventorySync.BroadcastGive: {ex.Message}");
        }
    }

    public static void BroadcastRestrained(int npcHumanId, bool isRestrained, float duration)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (npcHumanId < 0) return;

        try
        {
            var packet = new NpcRestrainedPacket
            {
                SenderId     = NetworkManager.LocalPlayerId,
                NpcHumanId   = npcHumanId,
                IsRestrained = isRestrained,
                Duration     = duration,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.NpcRestrained, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[InventorySync] restrained broadcast npc={npcHumanId} val={isRestrained} dur={duration:F1}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"InventorySync.BroadcastRestrained: {ex.Message}");
        }
    }

    public static void BroadcastStunned(int npcHumanId, bool isStunned)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (npcHumanId < 0) return;

        try
        {
            var packet = new NpcStunnedPacket
            {
                SenderId   = NetworkManager.LocalPlayerId,
                NpcHumanId = npcHumanId,
                IsStunned  = isStunned,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.NpcStunned, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[InventorySync] stunned broadcast npc={npcHumanId} val={isStunned}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"InventorySync.BroadcastStunned: {ex.Message}");
        }
    }

    private static void ApplyGive(ItemGivePacket p)
    {
        try
        {
            var npc = ResolveHumanByHumanId(p.RecipientHumanId);
            if (npc == null)
            {
                Plugin.Log.LogWarning($"[InventorySync] ApplyGive: recipient humanID {p.RecipientHumanId} not found");
                return;
            }
            var item = ResolveInteractableById(p.ItemInteractableId);
            if (item == null)
            {
                Plugin.Log.LogWarning($"[InventorySync] ApplyGive: item id {p.ItemInteractableId} not found");
                return;
            }

            IsApplyingRemote = true;
            try
            {
                // givenBy=null because the host's/client's local Player.Instance
                // doesn't represent the actual giver across machines.
                npc.TryGiveItem(item, null, p.DefaultSuccess, p.EnableSpeech);
                Plugin.Log.LogInfo($"[InventorySync] applied remote give item={p.ItemInteractableId} → npc={p.RecipientHumanId}");
            }
            finally
            {
                IsApplyingRemote = false;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"InventorySync.ApplyGive failed: {ex.Message}");
        }
    }

    private static void ApplyRestrained(NpcRestrainedPacket p)
    {
        try
        {
            var aic = ResolveAIController(p.NpcHumanId);
            if (aic == null) return;

            IsApplyingRemote = true;
            try { aic.SetRestrained(p.IsRestrained, p.Duration); }
            finally { IsApplyingRemote = false; }
            Plugin.Log.LogInfo($"[InventorySync] applied remote restrained npc={p.NpcHumanId} val={p.IsRestrained}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"InventorySync.ApplyRestrained failed: {ex.Message}");
        }
    }

    private static void ApplyStunned(NpcStunnedPacket p)
    {
        try
        {
            var aic = ResolveAIController(p.NpcHumanId);
            if (aic == null) return;

            IsApplyingRemote = true;
            try { aic.SetStunned(p.IsStunned); }
            finally { IsApplyingRemote = false; }
            Plugin.Log.LogInfo($"[InventorySync] applied remote stunned npc={p.NpcHumanId} val={p.IsStunned}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"InventorySync.ApplyStunned failed: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Lookup helpers
    // ─────────────────────────────────────────────────────────────────────────

    private static Human ResolveHumanByHumanId(int humanId)
    {
        try
        {
            var dict = CityData.Instance?.citizenDictionary;
            if (dict != null && dict.TryGetValue(humanId, out var h)) return h;
        }
        catch { }
        return null;
    }

    private static Interactable ResolveInteractableById(int id)
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

    private static NewAIController ResolveAIController(int humanId)
    {
        var human = ResolveHumanByHumanId(humanId);
        if (human == null || human.gameObject == null) return null;
        try
        {
            // IL2CPP-safe lookup: string GetComponent + TryCast (handles
            // the rare case where generic GetComponent throws on certain rigs).
            var c = human.gameObject.GetComponent("NewAIController");
            return c?.TryCast<NewAIController>();
        }
        catch
        {
            try { return human.gameObject.GetComponent<NewAIController>(); }
            catch { return null; }
        }
    }

    public static void BroadcastAction(ItemActionKind action)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new ItemActionPacket
            {
                PlayerId = NetworkManager.LocalPlayerId,
                Action   = (byte)action,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            // Sequenced — late attack frames can be dropped, the next one stomps anyway.
            NetworkManager.SendToAll(PacketType.ItemAction, _writer, DeliveryMethod.Sequenced);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"InventorySync.BroadcastAction({action}): {ex.Message}");
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
            else if (type == PacketType.ItemAction)
            {
                var p = new ItemActionPacket();
                p.Deserialize(reader);
                if (p.PlayerId == NetworkManager.LocalPlayerId) return;
                var rp = RemotePlayerManager.GetPlayer(p.PlayerId);
                if (rp == null) return;
                IsApplyingRemote = true;
                try { rp.ApplyAction(p.Action); }
                finally { IsApplyingRemote = false; }
            }
            else if (type == PacketType.ItemPlaceVisual)
            {
                var p = new ItemPlaceVisualPacket();
                p.Deserialize(reader);
                if (p.PlayerId == NetworkManager.LocalPlayerId) return;
                IsApplyingRemote = true;
                try { ApplyPlace(p); }
                finally { IsApplyingRemote = false; }
            }
            else if (type == PacketType.ItemGive)
            {
                var p = new ItemGivePacket();
                p.Deserialize(reader);
                if (p.GiverPlayerId == NetworkManager.LocalPlayerId) return;
                ApplyGive(p);   // ApplyGive sets IsApplyingRemote internally
            }
            else if (type == PacketType.NpcRestrained)
            {
                var p = new NpcRestrainedPacket();
                p.Deserialize(reader);
                if (p.SenderId == NetworkManager.LocalPlayerId) return;
                ApplyRestrained(p);
            }
            else if (type == PacketType.NpcStunned)
            {
                var p = new NpcStunnedPacket();
                p.Deserialize(reader);
                if (p.SenderId == NetworkManager.LocalPlayerId) return;
                ApplyStunned(p);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"InventorySync.OnPacketReceived({type}): {ex.Message}");
        }
    }
}
