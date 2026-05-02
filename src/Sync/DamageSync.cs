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
            Plugin.Log.LogInfo($"[DamageSync] broadcast victim={victimHumanId} attacker={attackerHumanId} amount={amount:F1} kill={enableKill}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"DamageSync.BroadcastDamage: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
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
    public static void ApplyFromZdo(int victimHumanId, int attackerHumanId, float amount,
                                    Vector3 hitPosition, Vector3 hitDirection, bool enableKill)
    {
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

                Plugin.Log.LogInfo($"[DamageSync] applied victim={victimHumanId} amount={amount:F1}");
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
