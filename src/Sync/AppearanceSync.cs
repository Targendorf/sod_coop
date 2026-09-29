using LiteNetLib;
using SoDCoop.Network.Steam;
using LiteNetLib.Utils;
using SoDCoop.Network;
using SoDCoop.Player;

namespace SoDCoop.Sync;

/// <summary>
/// Mirrors a player's chosen <see cref="AppearanceConfig"/> across all
/// peers. Each peer applies the overrides to its local copy of the
/// sender's twin citizen so guards, mirrors, and other clients render
/// the customized look identically.
///
/// <para><b>Flow:</b></para>
/// <list type="number">
///   <item>Client confirms in <c>AppearancePanel</c> →
///         <see cref="BroadcastLocal"/> sends a packet with
///         <c>SenderId=local</c>, <c>TwinHumanId=0</c>.</item>
///   <item>Host receives, resolves the twin humanID via
///         <see cref="TwinManager"/>, applies overrides locally, persists
///         to <c>CharacterStore</c>, and re-broadcasts to other peers
///         with <c>TwinHumanId</c> rewritten via
///         <see cref="RemapForForward"/>.</item>
///   <item>Other peers apply overrides to their local
///         <c>citizenDictionary[TwinHumanId]</c>.</item>
/// </list>
///
/// <para><b>Late-join:</b> <see cref="SendSnapshotTo"/> is called from the
/// host's handshake completion path (and reconnect path) so a fresh peer
/// receives every existing player's appearance immediately. Snapshots
/// are sent host-direct (not relayed) and already carry the correct
/// twin humanID.</para>
/// </summary>
public static class AppearanceSync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    // ─────────────────────────────────────────────────────────────────────
    //  Outbound — client confirms appearance
    // ─────────────────────────────────────────────────────────────────────

    /// <summary>The local player changed their look: show it on our own
    /// body and send it to everyone. The one entry point for every UI path
    /// (lobby "Customize", editing the active profile while connected).</summary>
    public static void PublishOwn(AppearanceConfig cfg)
    {
        try
        {
            var ctrl = global::Player.Instance?.outfitController;
            if (ctrl != null) cfg.ApplyTo(ctrl);
        }
        catch (System.Exception ex) { Plugin.Log.LogWarning($"AppearanceSync.PublishOwn local apply: {ex.Message}"); }
        BroadcastLocal(cfg);
    }

    /// <summary>
    /// Send local-player appearance to everyone. From a client it goes to the
    /// host, which applies, persists and forwards it (with twin remap).
    ///
    /// <para>From the HOST it goes straight to the clients, so it must carry
    /// the host's own body id: it used to carry 0 like a client's, clients
    /// resolve the body from that field alone, and every host appearance
    /// change was dropped with "no twin for sender".</para>
    /// </summary>
    public static void BroadcastLocal(AppearanceConfig cfg)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new PlayerAppearancePacket
            {
                SenderId    = NetworkManager.LocalPlayerId,
                TwinHumanId = NetworkManager.IsHost ? OwnBodyId() : 0,
                Config      = cfg,
            };

            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.PlayerAppearance, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogDebug($"[AppearanceSync] broadcast local appearance customized={cfg.IsCustomized}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"AppearanceSync.BroadcastLocal: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
    {
        if (type != PacketType.PlayerAppearance) return;

        try
        {
            var p = new PlayerAppearancePacket();
            p.Deserialize(reader);
            if (p.SenderId == NetworkManager.LocalPlayerId) return;

            int twin = NetworkManager.IsHost
                ? TwinManager.GetTwinHumanIDForSender(p.SenderId)
                : p.TwinHumanId;
            // Older senders left the body id out; the roster has it.
            if (twin <= 0 && !NetworkManager.IsHost
                && NetworkManager.Players != null
                && NetworkManager.Players.TryGetValue(p.SenderId, out var sender) && sender != null)
                twin = sender.TwinHumanID;

            if (twin <= 0)
            {
                Plugin.Log.LogWarning($"[AppearanceSync] no twin for sender={p.SenderId}, dropping.");
                return;
            }

            ApplyToHumanLocal(twin, p.Config);

            if (NetworkManager.IsHost)
            {
                // Persist for reconnect/restart and broadcast snapshot resends.
                if (NetworkManager.Players.TryGetValue(p.SenderId, out var info)
                    && !string.IsNullOrEmpty(info?.ClientGuid))
                {
                    CharacterStore.SetAppearance(CharacterStore.CurrentSeed(), info.ClientGuid, p.Config);
                }
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"AppearanceSync.OnPacketReceived: {ex.Message}");
        }
    }

    /// <summary>
    /// Apply config to the citizen with this humanID on the local machine,
    /// guarded by <see cref="IsApplyingRemote"/> so any patches that observe
    /// outfit changes don't re-broadcast. Also forwards to the matching
    /// RemotePlayer avatar (if one exists) so other players see the
    /// customized look on each other's in-world body, not just on the twin
    /// NPC sitting frozen in the city.
    /// </summary>
    public static void ApplyToHumanLocal(int humanId, AppearanceConfig cfg)
    {
        if (humanId <= 0) return;
        try
        {
            // The body under this id is OUR player on a machine that shares
            // the host's player id (TwinManager.IsLocalPlayerHuman) — dressing
            // it would dress us. The RemotePlayer's stand-in body gets it below.
            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict != null && !TwinManager.IsLocalPlayerHuman(humanId)
                && dict.TryGetValue(humanId, out var human) && human != null)
            {
                var ctrl = human.outfitController;
                if (ctrl != null)
                {
                    IsApplyingRemote = true;
                    try
                    {
                        cfg.ApplyTo(ctrl);
                        Plugin.Log.LogDebug($"[AppearanceSync] applied appearance to twin humanID={humanId} (custom={cfg.IsCustomized})");
                    }
                    finally { IsApplyingRemote = false; }
                }
            }

            // Also apply to the RemotePlayer avatar for this peer so the
            // in-world body (the cloned citizen visual the player actually
            // sees moving around) reflects the customization. Resolve the
            // playerId from the twin humanID via the player roster.
            try
            {
                int playerId = ResolvePlayerIdForTwin(humanId);
                if (playerId >= 0)
                {
                    var rp = SoDCoop.Player.RemotePlayerManager.GetPlayer(playerId);
                    rp?.ApplyAppearance(cfg);
                }
            }
            catch { /* RemotePlayer may not exist yet — twin-only apply is fine */ }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"AppearanceSync.ApplyToHumanLocal({humanId}): {ex.Message}");
        }
    }

    /// <summary>Resolve the network playerId whose twin citizen matches the
    /// given humanID. Reverse of TwinManager.GetTwinHumanIDForSender.
    /// Returns -1 if no match (e.g. the twin belongs to a disconnected
    /// peer or the local host — neither has a RemotePlayer).</summary>
    private static int ResolvePlayerIdForTwin(int humanId)
    {
        if (humanId <= 0) return -1;
        try
        {
            if (NetworkManager.Players == null) return -1;
            foreach (var kv in NetworkManager.Players)
            {
                var info = kv.Value;
                if (info == null) continue;
                if (info.TwinHumanID == humanId) return kv.Key;
            }
        }
        catch { }
        return -1;
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Host — re-broadcast remap
    // ─────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Host-side rewrite during star-topology forwarding: stamp the sender's
    /// twin humanID into the packet so other clients can resolve the target
    /// citizen without their own access to the host's CharacterStore.
    /// </summary>
    public static NetDataWriter RemapForForward(byte[] body, int bodyLen, int senderId, NetDataWriter outBuf)
    {
        if (!NetworkManager.IsHost) return null;
        int twin = TwinManager.GetTwinHumanIDForSender(senderId);
        if (twin <= 0) return null;

        try
        {
            var reader = new NetDataReader(body, 0, bodyLen);
            var p = new PlayerAppearancePacket();
            p.Deserialize(reader);
            p.TwinHumanId = twin;
            outBuf.Reset();
            p.Serialize(outBuf);
            return outBuf;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"AppearanceSync.RemapForForward: {ex.Message}");
            return null;
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Late-join snapshot
    // ─────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Push the appearance of every stored client (in the host's current
    /// seed) to a freshly-joined peer. Each entry carries the resolved
    /// twin humanID so the receiver can apply locally without further
    /// lookups.
    /// </summary>
    public static void SendSnapshotTo(SteamPeer peer)
    {
        if (peer == null) return;
        if (!NetworkManager.IsHost) return;

        try
        {
            string seed = CharacterStore.CurrentSeed();
            int sent = 0;
            foreach (var rec in CharacterStore.AllForSeed(seed))
            {
                if (rec == null) continue;
                if (rec.HumanID <= 0) continue;
                if (!rec.Appearance.IsCustomized) continue;

                int senderPlayerId = ResolvePlayerIdForGuid(rec.ClientGuid);
                if (senderPlayerId == int.MinValue) senderPlayerId = 0;

                var p = new PlayerAppearancePacket
                {
                    SenderId    = senderPlayerId,
                    TwinHumanId = rec.HumanID,
                    Config      = rec.Appearance,
                };
                _writer.Reset();
                p.Serialize(_writer);
                NetworkManager.SendTo(peer, PacketType.PlayerAppearance, _writer);
                sent++;
            }
            // The host's own look. It has no CharacterStore record (the host
            // never submits a character to itself), so it was never in this
            // snapshot: a joiner always saw the host's body in its seeded
            // clothes. It lives in the host's active profile.
            try
            {
                var own = SoDCoop.Player.ProfileStore.Active?.Appearance ?? AppearanceConfig.Default;
                int body = OwnBodyId();
                if (own.IsCustomized && body > 0)
                {
                    var p = new PlayerAppearancePacket
                    {
                        SenderId    = NetworkManager.LocalPlayerId,
                        TwinHumanId = body,
                        Config      = own,
                    };
                    _writer.Reset();
                    p.Serialize(_writer);
                    NetworkManager.SendTo(peer, PacketType.PlayerAppearance, _writer);
                    sent++;
                }
            }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"AppearanceSync host self snapshot: {ex.Message}"); }

            if (sent > 0) Plugin.Log.LogInfo($"[AppearanceSync] sent {sent} appearance snapshot(s) to peer {peer.SteamId.m_SteamID}.");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"AppearanceSync.SendSnapshotTo: {ex.Message}");
        }
    }

    /// <summary>This machine's body id in the shared world: the host's is its
    /// player's own humanID, a client's is the twin the host assigned.</summary>
    private static int OwnBodyId()
    {
        try
        {
            if (NetworkManager.Players != null
                && NetworkManager.Players.TryGetValue(NetworkManager.LocalPlayerId, out var me)
                && me != null && me.TwinHumanID > 0)
                return me.TwinHumanID;
            if (NetworkManager.IsHost) return global::Player.Instance?.humanID ?? 0;
            return NetworkManager.MyTwinHumanID;
        }
        catch { return 0; }
    }

    private static int ResolvePlayerIdForGuid(string clientGuid)
    {
        if (string.IsNullOrEmpty(clientGuid)) return int.MinValue;
        try
        {
            foreach (var kv in NetworkManager.Players)
            {
                if (kv.Value?.ClientGuid == clientGuid) return kv.Key;
            }
        }
        catch { }
        // Fallback: not currently connected — caller will substitute 0.
        return int.MinValue;
    }
}
