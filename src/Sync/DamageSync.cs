using System.Collections.Generic;
using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Mirrors NPC damage events across machines.
///
/// Why: <c>Actor.RecieveDamage</c> applies bleeding, ragdolls, blood spatter,
/// shock, alert spread, and (if <c>enableKill</c>) eventual death. Without
/// sync, only the originating machine sees the bleed-out / hit reaction;
/// peers just see the citizen unaffected. Death itself is already covered
/// by <see cref="CitizenDeathSync"/>; this fills the non-lethal middle.
///
/// Player victims are deliberately NOT synced. Each player's health is local
/// state that doesn't carry meaning across machines (same humanID isn't a
/// stable cross-machine identifier for players).
///
/// Spatter / footprint side-effects of the replayed RecieveDamage on the
/// receiver are suppressed via <see cref="IsApplyingRemote"/> being checked
/// in those systems' <c>ShouldSuppressBroadcast</c> cascades.
/// </summary>
public static class DamageSync
{
    public static bool IsApplyingRemote { get; private set; }

    /// <summary>Below this much missing health a received hit is treated as
    /// already applied by the state sync. Matches CitizenStatePoller's health
    /// deadband, so float jitter on the streamed value can't re-trigger a hit.</summary>
    private const float RECONCILE_EPSILON = 0.5f;

    private static readonly NetDataWriter _writer = new();

    /// <summary>Lazy <c>SpatterPatternPreset.name</c> → preset registry.</summary>
    private static Dictionary<string, SpatterPatternPreset> _spatterPresetByName;

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void BroadcastDamage(
        int victimHumanId,
        int attackerHumanId,
        float amount,
        Vector3 hitPosition,
        Vector3 hitDirection,
        SpatterPatternPreset forwardSpatter,
        SpatterPatternPreset backSpatter,
        SpatterSimulation.EraseMode eraseMode,
        bool forceRagdoll,
        float ragdollDuration,
        float shockMP,
        bool enableKill,
        bool allowRecoil,
        float ragdollForceMP)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (victimHumanId < 0) return;

        try
        {
            var packet = new NpcDamagePacket
            {
                SenderId             = NetworkManager.LocalPlayerId,
                VictimHumanId        = victimHumanId,
                AttackerHumanId      = attackerHumanId,
                Amount               = amount,
                HitPosition          = hitPosition,
                HitDirection         = hitDirection,
                ForwardSpatterPreset = forwardSpatter?.name ?? "",
                BackSpatterPreset    = backSpatter?.name    ?? "",
                EraseMode            = (byte)eraseMode,
                ForceRagdoll         = forceRagdoll,
                RagdollDuration      = ragdollDuration,
                ShockMP              = shockMP,
                EnableKill           = enableKill,
                AllowRecoil          = allowRecoil,
                RagdollForceMP       = ragdollForceMP,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.NpcDamage, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogDebug($"[DamageSync] broadcast victim={victimHumanId} attacker={attackerHumanId} amount={amount:F1} kill={enableKill}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"DamageSync.BroadcastDamage: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
    {
        if (type != PacketType.NpcDamage) return;

        try
        {
            var p = new NpcDamagePacket();
            p.Deserialize(reader);
            if (p.SenderId == NetworkManager.LocalPlayerId) return;
            ApplyDamage(p);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"DamageSync.OnPacketReceived: {ex.Message}");
        }
    }

    private static void ApplyDamage(NpcDamagePacket p)
    {
        var fwdSpatter  = ResolveSpatterPreset(p.ForwardSpatterPreset);
        var backSpatter = ResolveSpatterPreset(p.BackSpatterPreset);
        ApplyImpl(
            p.VictimHumanId, p.AttackerHumanId, p.Amount,
            p.HitPosition, p.HitDirection,
            fwdSpatter, backSpatter,
            (SpatterSimulation.EraseMode)p.EraseMode,
            p.ForceRagdoll, p.RagdollDuration, p.ShockMP,
            p.EnableKill, p.AllowRecoil, p.RagdollForceMP);
    }

    /// <summary>ZDO entry — invoked from <c>ZdoEvents.OnNpcDamageRich</c>.
    /// Spatter presets are not in the event payload; receivers use defaults.</summary>
    /// <param name="healthAfter">Host's health for the victim after the hit, or
    /// NaN when the sender didn't provide it.
    ///
    /// <para><b>Why the damage is reconciled rather than applied as sent.</b>
    /// Health reaches receivers twice: as this damage event, which goes through
    /// <c>RecieveDamage</c> and SUBTRACTS, and as the absolute
    /// <c>CurrentHealth</c> key CitizenStatePoller streams on the Citizen ZDO,
    /// which CitizenResolver assigns directly. They travel on different
    /// channels, so arrival order is not guaranteed. Event first is fine —
    /// H−d, then the state confirms H−d. State first is not: H−d from the
    /// state, then the event subtracts again to H−2d, and nothing ever corrects
    /// it, because the host's value didn't change so the key is never re-sent.
    /// At low health that knocks an NPC out on the client while it is still
    /// standing on the host.</para>
    ///
    /// <para>Applying only <c>clientHealth − healthAfter</c> makes both orders
    /// converge on the host's value. When the state already won the race there
    /// is nothing left to apply and the hit is skipped — losing one hit
    /// reaction is cosmetic; double damage is a desync. Death is unaffected: it
    /// propagates as its own Dead state on the Citizen ZDO.</para></param>
    public static void ApplyFromZdo(int victimHumanId, int attackerHumanId, float amount,
                                    Vector3 hitPosition, Vector3 hitDirection, bool enableKill,
                                    float healthAfter = float.NaN)
    {
        // A hit on OUR body in the host's world is a hit on us. Citizens near
        // a client are frozen and host-driven here, so a citizen attacking this
        // player does it on the host, to our twin — this event is the only way
        // that damage reaches the player. The twin's health on the host only
        // approximates ours, so the hit's own size is applied, not health-after.
        int myTwin = SoDCoop.Network.NetworkManager.MyTwinHumanID;
        if (!SoDCoop.Network.NetworkManager.IsHost && myTwin > 0 && victimHumanId == myTwin)
        {
            ApplyToLocalPlayer(amount, attackerHumanId, enableKill);
            return;
        }
        // The HOST's body under our own player's id (shared id — see
        // TwinManager.IsLocalPlayerHuman): the host was hit, not us.
        if (!SoDCoop.Network.NetworkManager.IsHost && SoDCoop.Sync.TwinManager.IsLocalPlayerHuman(victimHumanId))
            return;

        if (!float.IsNaN(healthAfter))
        {
            var victim = ResolveActor(victimHumanId);
            if (victim == null) return;
            float current;
            try { current = victim.currentHealth; }
            catch { current = float.NaN; }

            if (!float.IsNaN(current))
            {
                float missing = current - healthAfter;
                if (missing <= RECONCILE_EPSILON)
                {
                    Plugin.Log.LogDebug(
                        $"[DamageSync] victim={victimHumanId} already at host health {healthAfter:F1} " +
                        $"(state sync arrived first) — hit of {amount:F1} not re-applied.");
                    return;
                }
                amount = missing;
            }
        }

        ApplyImpl(
            victimHumanId, attackerHumanId, amount,
            hitPosition, hitDirection,
            forwardSpatter:  null,
            backSpatter:     null,
            eraseMode:       SpatterSimulation.EraseMode.useDespawnTime,
            forceRagdoll:    false,
            ragdollDuration: 0f,
            shockMP:         1f,
            enableKill:      enableKill,
            allowRecoil:     true,
            ragdollForceMP:  1f);
    }

    /// <summary>Host: a client's hit (<see cref="NpcHitSync"/>), attributed
    /// to that client's twin so the victim and witnesses react to the right
    /// body.</summary>
    internal static void ApplyHit(int victimHumanId, int attackerHumanId, float amount, bool enableKill)
    {
        Vector3 pos = Vector3.zero, dir = Vector3.up;
        try
        {
            var victim = ResolveActor(victimHumanId);
            if (victim == null) return;
            pos = victim.transform.position + Vector3.up;
            var attacker = attackerHumanId > 0 ? ResolveActor(attackerHumanId) : null;
            if (attacker != null)
            {
                Vector3 d = victim.transform.position - attacker.transform.position;
                if (d.sqrMagnitude > 0.0001f) dir = d.normalized;
            }
        }
        catch { }

        ApplyImpl(
            victimHumanId, attackerHumanId, amount, pos, dir,
            forwardSpatter:  null,
            backSpatter:     null,
            eraseMode:       SpatterSimulation.EraseMode.useDespawnTime,
            forceRagdoll:    false,
            ragdollDuration: 0f,
            shockMP:         1f,
            enableKill:      enableKill,
            allowRecoil:     true,
            ragdollForceMP:  1f);
    }

    /// <summary>Damage the local player: a hit that landed on our body in
    /// another machine's world.</summary>
    internal static void ApplyToLocalPlayer(float amount, int attackerHumanId, bool enableKill)
    {
        try
        {
            var p = global::Player.Instance;
            if (p == null || !(amount > 0f)) return;
            Actor attacker = attackerHumanId > 0 ? ResolveActor(attackerHumanId) : null;
            Vector3 pos = p.transform.position + Vector3.up;
            Vector3 dir = Vector3.up;
            try
            {
                if (attacker != null)
                {
                    Vector3 d = p.transform.position - attacker.transform.position;
                    if (d.sqrMagnitude > 0.0001f) dir = d.normalized;
                }
            }
            catch { }

            IsApplyingRemote = true;
            try
            {
                p.RecieveDamage(amount, attacker, pos, dir, null, null,
                    SpatterSimulation.EraseMode.useDespawnTime,
                    /*alertSurrounding*/ true, /*forceRagdoll*/ false, 0f, 1f,
                    enableKill, /*allowRecoil*/ true, 1f);
            }
            finally { IsApplyingRemote = false; }
            Plugin.Log.LogDebug($"[DamageSync] our body was hit in the host's world: {amount:F1}");
        }
        catch (System.Exception ex) { Plugin.Log.LogWarning($"[DamageSync] ApplyToLocalPlayer: {ex.Message}"); }
    }

    private static void ApplyImpl(int victimHumanId, int attackerHumanId, float amount,
                                  Vector3 hitPosition, Vector3 hitDirection,
                                  SpatterPatternPreset forwardSpatter, SpatterPatternPreset backSpatter,
                                  SpatterSimulation.EraseMode eraseMode,
                                  bool forceRagdoll, float ragdollDuration, float shockMP,
                                  bool enableKill, bool allowRecoil, float ragdollForceMP)
    {
        try
        {
            var victim = ResolveActor(victimHumanId);
            if (victim == null)
            {
                Plugin.Log.LogWarning($"[DamageSync] ApplyDamage: victim humanID {victimHumanId} not found");
                return;
            }

            Actor attacker = null;
            if (attackerHumanId >= 0) attacker = ResolveActor(attackerHumanId);

            IsApplyingRemote = true;
            try
            {
                victim.RecieveDamage(
                    amount, attacker, hitPosition, hitDirection,
                    forwardSpatter, backSpatter, eraseMode,
                    /*alertSurrounding*/ true,
                    forceRagdoll, ragdollDuration, shockMP,
                    enableKill, allowRecoil, ragdollForceMP);
                // Our own write, not the local player's hit — NpcHitSync must
                // not report it back to the host as one.
                try { NpcHitSync.NotifyRemoteHealth(victimHumanId, victim.currentHealth); } catch { }

                Plugin.Log.LogDebug($"[DamageSync] applied victim={victimHumanId} amount={amount:F1}");
            }
            finally { IsApplyingRemote = false; }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"DamageSync.ApplyImpl failed: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Lookup helpers
    // ─────────────────────────────────────────────────────────────────────────

    private static Actor ResolveActor(int humanId)
    {
        if (humanId < 0) return null;
        try
        {
            // Citizens — common case.
            var dict = CityData.Instance?.citizenDictionary;
            if (dict != null && dict.TryGetValue(humanId, out var h))
                return h?.TryCast<Actor>() ?? h;

            // Local player fallback (rare — attacker may be us).
            var local = global::Player.Instance;
            if (local != null && local.humanID == humanId)
                return local.TryCast<Actor>() ?? local;
        }
        catch { }
        return null;
    }

    private static SpatterPatternPreset ResolveSpatterPreset(string name)
    {
        if (string.IsNullOrEmpty(name)) return null;

        if (_spatterPresetByName != null && _spatterPresetByName.TryGetValue(name, out var cached))
            return cached;

        try
        {
            _spatterPresetByName = new Dictionary<string, SpatterPatternPreset>();
            var all = Resources.FindObjectsOfTypeAll<SpatterPatternPreset>();
            if (all == null) return null;
            for (int i = 0; i < all.Length; i++)
            {
                var pr = all[i];
                if (pr == null) continue;
                var n = pr.name;
                if (string.IsNullOrEmpty(n)) continue;
                _spatterPresetByName[n] = pr;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"DamageSync.ResolveSpatterPreset: {ex.Message}");
            return null;
        }

        return _spatterPresetByName.TryGetValue(name, out var fresh) ? fresh : null;
    }
}
