using SoDCoop.Network;
using SoDCoop.UI;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Manages all synchronization subsystems.
/// </summary>
public static class SyncManager
{
    /// <summary>
    /// Player position and state synchronization.
    /// </summary>
    public static PlayerSync PlayerSync { get; private set; }
    
    /// <summary>
    /// World/NPC state synchronization.
    /// </summary>
    public static WorldSync WorldSync { get; private set; }
    
    /// <summary>
    /// Game time synchronization.
    /// </summary>
    public static TimeSync TimeSync { get; private set; }
    
    /// <summary>
    /// Investigation/case progress synchronization.
    /// </summary>
    public static CaseSync CaseSync { get; private set; }
    
    /// <summary>
    /// Whether sync systems are active.
    /// </summary>
    public static bool IsActive { get; private set; }
    
    public static void Initialize()
    {
        Plugin.Log.LogInfo("SyncManager initializing...");
        
        PlayerSync = new PlayerSync();
        WorldSync = new WorldSync();
        TimeSync = new TimeSync();
        CaseSync = new CaseSync();
        
        // Subscribe to network events
        NetworkManager.OnConnected += OnConnected;
        NetworkManager.OnDisconnected += OnDisconnected;
        NetworkManager.OnPacketReceived += OnPacketReceived;
        NetworkManager.OnPlayerLeft += OnPlayerLeft;

        // Weather is host-authoritative; needs OnPlayerJoined to push state to late-joiners.
        WeatherSync.Initialize();

        Plugin.Log.LogInfo("SyncManager initialized.");
    }
    
    public static void Shutdown()
    {
        IsActive = false;

        WeatherSync.Shutdown();

        NetworkManager.OnConnected -= OnConnected;
        NetworkManager.OnDisconnected -= OnDisconnected;
        NetworkManager.OnPacketReceived -= OnPacketReceived;
        NetworkManager.OnPlayerLeft -= OnPlayerLeft;
        
        PlayerSync = null;
        WorldSync = null;
        TimeSync = null;
        CaseSync = null;
        
        Plugin.Log.LogInfo("SyncManager shutdown.");
    }
    
    public static void Update()
    {
        if (!IsActive || !NetworkManager.IsConnected) return;
        
        PlayerSync?.Update();
        WorldSync?.Update();
        TimeSync?.Update();
        CaseSync?.Update();
    }
    
    private static void OnConnected()
    {
        IsActive = true;
        Plugin.Log.LogInfo("SyncManager activated.");
        
        // If we're the host, sync the world seed
        if (NetworkManager.IsHost)
        {
            WorldSync?.SyncWorldSeed();
        }
    }
    
    private static void OnDisconnected(string reason)
    {
        IsActive = false;
        // Drop all placement-mock visuals so they don't dangle in the world
        // after we lose the connection.
        try { InventorySync.ClearAllMocks(); } catch { }
        // Drop any in-flight save-transfer state so a half-shipped transfer
        // (host side) or half-reassembled save (client side) doesn't leak
        // across sessions / into a reconnect.
        try { SaveTransfer.Reset(); } catch { }
        // Drop joiner-bootstrap state. WorldAutoLoad.Reset had NO callers, so a
        // join that aborted before WorldReady left IsBootstrappingWorld true
        // and OnWorldReadyAfterAutoLoad still subscribed — it would then fire
        // on the player's next SOLO world load and run ApplyAllToLiveWorld +
        // SendToHost(ClientWorldReady) against a session that no longer exists.
        // Also clears JoinedSessionActive so the tutorial-suppression patches
        // stop keying on a dead session (today the compound
        // `IsConnected && !IsHost` gate covers that, but the flag should not
        // outlive its session on its own).
        try { WorldAutoLoad.Reset(); } catch { }
        // Hand every network-driven citizen back to its local AI. A citizen
        // left with ai.enabled=false after the session ends would stand
        // motionless in the player's own single-player game.
        try { CitizenPositionSync.Reset(); } catch { }
        // Ownership state was never cleared anywhere: a host kept citizens a
        // departed client had claimed paused for good, and a client carried
        // stale claimed ids into its next world.
        try { WorldSync?.OnSessionEnded(); } catch { }
        // Client: we are no longer in the host's world — client pollers stop
        // until the next session's snapshot — and the twins we froze in this
        // world go back to their lives.
        try { SoDCoop.Zdo.ZdoMan.MarkClientUnsynced(); } catch { }
        try { TwinManager.ReleaseLocallyFrozenTwins(); } catch { }
        try { WorldEditSync.Reset(); } catch { }
        try { NpcHitSync.Reset(); } catch { }
        try { JoinSpawn.Reset(); } catch { }
        Plugin.Log.LogInfo($"SyncManager deactivated: {reason}");
    }

    /// <summary>Host: a peer left mid-session. Hand back any citizens it had
    /// claimed for interaction, or their host-side AI stays paused.</summary>
    private static void OnPlayerLeft(int playerId, string name)
    {
        try { WorldSync?.OnPeerLeft(playerId); } catch { }
    }
    
    private static void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
    {
        // Route packet to appropriate sync system
        try
        {
            // ── ZDO unified transport (200-204). Handled before legacy fan-out
            //    so a packet whose enum value happens to overlap a legacy range
            //    (none currently — we picked 200+) doesn't accidentally land
            //    in the wrong handler.
            if (type == PacketType.ZdoDeltaBatch)
            {
                // Pass senderId so host-side ApplyDeltaBatch can validate
                // that each ZDO delta came from its OwnerPeer (anti-mutation
                // by joiners on ZDOs they don't own).
                SoDCoop.Zdo.ZdoMan.ApplyDeltaBatch(reader, senderId);
                return;
            }
            if (type == PacketType.ZdoSnapshot)
            {
                SoDCoop.Zdo.ZdoMan.HandleSnapshot(reader);
                return;
            }
            if (type == PacketType.ZdoOwnershipTransfer)
            {
                SoDCoop.Zdo.ZdoMan.ApplyOwnershipTransfer(reader);
                return;
            }
            if (type == PacketType.ZdoEventRpc)
            {
                SoDCoop.Zdo.ZdoEventDispatcher.Dispatch(reader, senderId);
                return;
            }
            if (type == PacketType.ZdoVersionMismatch)
            {
                // Version mismatch is informational; logged + UI surfaced via NetworkManager.
                Plugin.Log.LogWarning("[SyncManager] received ZdoVersionMismatch — connection will close.");
                return;
            }
            // ── Save-Transfer (Mode 3) bootstrap channel. Handled here in the
            //    early-return block (before legacy fan-out) because the enum
            //    values 207-209 don't match any legacy range and would
            //    otherwise fall through to no handler and silently drop.
            if (type == PacketType.CitizenPositions)
            {
                SoDCoop.Sync.CitizenPositionSync.HandlePacket(reader, senderId);
                return;
            }
            if (type == PacketType.SaveTransferHeader)
            {
                SoDCoop.Sync.SaveTransfer.HandleHeader(reader, senderId);
                return;
            }
            if (type == PacketType.SaveTransferChunk)
            {
                SoDCoop.Sync.SaveTransfer.HandleChunk(reader, senderId);
                return;
            }
            if (type == PacketType.SaveTransferComplete)
            {
                SoDCoop.Sync.SaveTransfer.HandleComplete(reader, senderId);
                return;
            }

            // We could use ranges from Packets.cs to optimize, but for now simple dispatch
            // Each manager checks if the type belongs to it

            // Item pickup / drop (14, 15) — handled by ItemSync, not PlayerSync.
            if (type == PacketType.PlayerPickup || type == PacketType.PlayerDrop)
            {
                ItemSync.OnPacketReceived(type, reader, senderId);
            }
            // Inventory visibility (20-29) — held item, stance, flashlight, actions,
            // placements, give-to-NPC, NPC restrained / stunned, place-remove, throws.
            else if (type == PacketType.ItemHeld
                  || type == PacketType.ItemRaised
                  || type == PacketType.ItemFlashlight
                  || type == PacketType.ItemAction
                  || type == PacketType.ItemPlaceVisual
                  || type == PacketType.ItemGive
                  || type == PacketType.NpcRestrained
                  || type == PacketType.NpcStunned
                  || type == PacketType.ItemPlaceRemove
                  || type == PacketType.ItemThrow
                  || type == PacketType.PlayerHandoff)
            {
                InventorySync.OnPacketReceived(type, reader, senderId);
            }
            // Player sleep / in-bed (38, 39).
            else if (type == PacketType.PlayerInBed || type == PacketType.PlayerAsleep)
            {
                PlayerStateSync.OnPacketReceived(type, reader, senderId);
            }
            // Money add/remove (40).
            else if (type == PacketType.MoneyAdded)
            {
                MoneySync.OnPacketReceived(type, reader, senderId);
            }
            // Host lobby status (41).
            else if (type == PacketType.HostStatus)
            {
                HostStatusSync.OnPacketReceived(type, reader, senderId);
            }
            // Player Packets: 10-29 (excluding 14, 15, 20-29 handled above)
            else if ((int)type >= 10 && (int)type <= 29)
            {
                PlayerSync?.OnPacketReceived(type, reader, senderId);
            }
            // Evidence object creation (30) — generic Evidence sync.
            else if (type == PacketType.EvidenceCreate)
            {
                EvidenceSync.OnPacketReceived(type, reader, senderId);
            }
            // Evidence discovery added (109) — fact-knowledge graph propagation.
            else if (type == PacketType.EvidenceDiscoveryAdd
                  || type == PacketType.EvidenceSetNote
                  || type == PacketType.EvidenceCustomName)
            {
                EvidenceSync.OnPacketReceived(type, reader, senderId);
            }
            // Non-lethal NPC damage (31).
            else if (type == PacketType.NpcDamage)
            {
                DamageSync.OnPacketReceived(type, reader, senderId);
            }
            // Local-player damage events (104) — chat banner + RemotePlayer down pose.
            else if (type == PacketType.PlayerDamage)
            {
                PlayerDamageSync.OnPacketReceived(type, reader, senderId);
            }
            // Side-job lifecycle notifications (105) — host → all, banner-only.
            else if (type == PacketType.SideJobNotification)
            {
                SideJobSync.OnPacketReceived(type, reader, senderId);
            }
            // Side-job accept request (108) — client → host, runs OnPlayerCall and re-broadcasts upsert.
            else if (type == PacketType.SideJobAcceptRequest
                  || type == PacketType.SideJobHandInRequest)
            {
                SideJobSync.OnPacketReceived(type, reader, senderId);
            }
            // Trespass / illegal-status flags (106) — client → host, applied to twin.
            else if (type == PacketType.PlayerSuspicion)
            {
                PlayerSuspicionSync.OnPacketReceived(type, reader, senderId);
            }
            // Outfit / disguise category (107) — client → host, applied to twin.
            else if (type == PacketType.PlayerOutfit)
            {
                PlayerOutfitSync.OnPacketReceived(type, reader, senderId);
            }
            // NPC scheduled outfit change (113) — host → clients.
            else if (type == PacketType.NpcOutfit)
            {
                NpcOutfitSync.OnPacketReceived(type, reader, senderId);
            }
            // Player appearance customization (114) — client → host → all peers.
            else if (type == PacketType.PlayerAppearance)
            {
                AppearanceSync.OnPacketReceived(type, reader, senderId);
            }
            // Elevator floor call (32).
            else if (type == PacketType.ElevatorCall)
            {
                ElevatorSync.OnPacketReceived(type, reader, senderId);
            }
            // Computer login + foreground app (34, 35). DoorLockState=33 is
            // routed above via the WorldStateSync 50-range cluster.
            else if (type == PacketType.ComputerLogin || type == PacketType.ComputerApp)
            {
                ComputerSync.OnPacketReceived(type, reader, senderId);
            }
            // Voicemail thread created (36).
            else if (type == PacketType.VmailCreated)
            {
                VmailSync.OnPacketReceived(type, reader, senderId);
            }
            // Doors + lights + switches (50-59) — go to WorldStateSync, not WorldSync.
            else if (type == PacketType.DoorState
                  || type == PacketType.LightState
                  || type == PacketType.SwitchState
                  || type == PacketType.DoorLockState)
            {
                WorldStateSync.OnPacketReceived(type, reader, senderId);
            }
            // Fingerprint events (53, 54) — own handler, captured before
            // generic 30-49 dispatch so WorldSync doesn't grab them.
            else if (type == PacketType.FingerprintAdd
                  || type == PacketType.FingerprintClearManual)
            {
                FingerprintSync.OnPacketReceived(type, reader, senderId);
            }
            // Footprint decals (55) — separate handler.
            else if (type == PacketType.FootprintAdd)
            {
                FootprintSync.OnPacketReceived(type, reader, senderId);
            }
            // Blood / dirt spatter (56).
            else if (type == PacketType.SpatterAdd)
            {
                SpatterSync.OnPacketReceived(type, reader, senderId);
            }
            // Weather (34) — host-authoritative, dedicated handler.
            else if (type == PacketType.WeatherSync)
            {
                WeatherSync.OnPacketReceived(type, reader, senderId);
            }
            // Citizen death + crime-scene discovery (100, 102).
            else if (type == PacketType.CitizenDeath || type == PacketType.CrimeSceneDiscovered)
            {
                CitizenDeathSync.OnPacketReceived(type, reader, senderId);
            }
            // Phone call notification banner (103).
            else if (type == PacketType.PhoneCallNotify)
            {
                PhoneSync.OnPacketReceived(type, reader, senderId);
            }
            // World Packets: 30-49 + 1 (WorldSeed) + Critical (100+) → WorldSync (NPCs, time, etc.)
            else if (((int)type >= 30 && (int)type <= 49) || type == PacketType.WorldSeed || (int)type >= 100)
            {
                WorldSync?.OnPacketReceived(type, reader, senderId);
            }
            // Shared case board (66-74) — own handler.
            else if (type == PacketType.CaseBoardPin
                  || type == PacketType.CaseBoardUnpin
                  || type == PacketType.CaseBoardMove
                  || type == PacketType.CaseBoardString
                  || type == PacketType.CaseBoardHide
                  || type == PacketType.CaseBoardStatus
                  || type == PacketType.CaseBoardResolveAnswer
                  || type == PacketType.CaseBoardResolve
                  || type == PacketType.CaseBoardFactName
                  || type == PacketType.CaseBoardStringRemove)
            {
                CaseBoardSync.OnPacketReceived(type, reader, senderId);
            }
            // Other Case Packets: 60-79
            else if ((int)type >= 60 && (int)type <= 79)
            {
                CaseSync?.OnPacketReceived(type, reader, senderId);
            }
            // NOTE: the branches below are part of the same else-if chain on
            // purpose — a packet matches at most ONE handler, preventing
            // double-dispatch if a future type overlaps a range branch above.
            else if (type == PacketType.TimeSync)
            {
                TimeSync?.OnPacketReceived(type, reader, senderId);
            }
            // Chat / UI packets (80-99)
            else if (type == PacketType.ChatMessage)
            {
                CoopUI.OnChatPacketReceived(reader, senderId);
            }
            else if (type == PacketType.MapPing || type == PacketType.PauseState)
            {
                PingSystem.OnPacketReceived(type, reader, senderId);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"Error handling packet {type} from player {senderId}: {ex}");
        }
    }
}
