using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Mirrors the local player's <c>Actor</c>-level trespass / illegal-status
/// flags onto the host so the host's NPC AI can react correctly to remote
/// players' behaviour.
///
/// <para><b>Why:</b> SoD's guards / employees decide to chase, alert, or
/// ignore a person based on flags on that person's <c>Actor</c>:
/// <c>isTrespassing</c>, <c>illegalActionActive</c>, <c>illegalAreaActive</c>,
/// <c>illegalStatus</c>, <c>trespassingEscalation</c>. These are set on
/// each machine's local <c>Player.Instance</c> by SoD when the player
/// crosses into a restricted zone. The host's twin citizen never had them
/// flipped (the twin doesn't move — see TwinManager.FreezeAllTwins),
/// so guards saw the remote player's body but treated them as innocent.
/// We poll the local flags and push them to the host's twin so the AI
/// reacts to the actual remote behaviour.</para>
///
/// <para><b>Architecture:</b> client polls its own <c>Player.Instance</c>
/// flags every Update tick. On change → broadcast a single packet
/// reliably-ordered. Host receives, looks up the sender's twin via
/// <see cref="TwinManager.GetTwinHumanIDForSender"/>, and stamps the
/// flags onto that <c>Human</c> (which is an <c>Actor</c>). Other peers
/// don't apply (they don't have a host-side twin reference); the apply
/// path is host-only.</para>
/// </summary>
public static class PlayerSuspicionSync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();
    private static PlayerSuspicionPacket _lastSent;
    private static bool _hasLastSent;

    /// <summary>How often to poll. Cheap enough to run every frame, but pace it.</summary>
    private const float POLL_INTERVAL_S = 0.25f;
    private static float _nextPollAt;

    // ─────────────────────────────────────────────────────────────────────
    //  Outbound — called from CoopUpdateRunner
    // ─────────────────────────────────────────────────────────────────────

    public static void Update()
    {
        // Host doesn't need to send — its own player IS the local player on
        // its machine, and host-side NPC AI reads flags directly off
        // Player.Instance / its citizenDictionary[player.humanID].
        if (!NetworkManager.IsConnected) return;
        if (NetworkManager.IsHost) return;

        float now = Time.unscaledTime;
        if (now < _nextPollAt) return;
        _nextPollAt = now + POLL_INTERVAL_S;

        try
        {
            var p = global::Player.Instance;
            if (p == null) return;

            var packet = new PlayerSuspicionPacket
            {
                PlayerId              = NetworkManager.LocalPlayerId,
                IsTrespassing         = SafeBool(() => p.isTrespassing),
                IllegalActionActive   = SafeBool(() => p.illegalActionActive),
                IllegalAreaActive     = SafeBool(() => p.illegalAreaActive),
                IllegalStatus         = SafeBool(() => p.illegalStatus),
                TrespassingEscalation = SafeInt (() => p.trespassingEscalation),
            };

            // Skip the wire if no flag changed since last send.
            if (_hasLastSent && packet.SameAs(_lastSent)) return;

            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.PlayerSuspicion, _writer, DeliveryMethod.ReliableOrdered);

            _lastSent    = packet;
            _hasLastSent = true;

            Plugin.Log.LogInfo($"[PlayerSuspicionSync] sent trespass={packet.IsTrespassing} illegalAction={packet.IllegalActionActive} illegalArea={packet.IllegalAreaActive} status={packet.IllegalStatus} esc={packet.TrespassingEscalation}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"PlayerSuspicionSync.Update: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Inbound — host-only apply
    // ─────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        if (type != PacketType.PlayerSuspicion) return;

        try
        {
            var p = new PlayerSuspicionPacket();
            p.Deserialize(reader);
            ApplyToTwin(p, senderId);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"PlayerSuspicionSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyToTwin(PlayerSuspicionPacket p, int senderId)
    {
        if (!NetworkManager.IsHost) return; // client peers don't run guard AI

        int twinHumanId = TwinManager.GetTwinHumanIDForSender(senderId);
        if (twinHumanId <= 0)
        {
            // Senders with no twin yet (mid character-creation etc.) — skip.
            return;
        }

        try
        {
            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict == null) return;
            if (!dict.TryGetValue(twinHumanId, out var twin) || twin == null) return;

            IsApplyingRemote = true;
            try
            {
                // Actor base fields are accessible on Human via inheritance.
                try { twin.isTrespassing         = p.IsTrespassing;         } catch { }
                try { twin.illegalActionActive   = p.IllegalActionActive;   } catch { }
                try { twin.illegalAreaActive     = p.IllegalAreaActive;     } catch { }
                try { twin.illegalStatus         = p.IllegalStatus;         } catch { }
                try { twin.trespassingEscalation = p.TrespassingEscalation; } catch { }
            }
            finally
            {
                IsApplyingRemote = false;
            }

            Plugin.Log.LogInfo($"[PlayerSuspicionSync] applied to twin humanID={twinHumanId} trespass={p.IsTrespassing} illegalArea={p.IllegalAreaActive} esc={p.TrespassingEscalation}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"PlayerSuspicionSync.ApplyToTwin: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Helpers
    // ─────────────────────────────────────────────────────────────────────

    private static bool SafeBool(System.Func<bool> f) { try { return f(); } catch { return false; } }
    private static int  SafeInt (System.Func<int>  f) { try { return f(); } catch { return 0; } }
}
