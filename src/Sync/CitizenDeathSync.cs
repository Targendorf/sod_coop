using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Murder + crime-scene discovery synchronisation.
///
/// SoD's MurderController is fully deterministic when both clients share the same
/// world seed (which they do), so the case schedule is already in sync. What we
/// need to mirror are two visible side-effects:
///
///   • A citizen actually dying (Human.Murder) — the host's NPC sim runs the
///     murder, but the client's local citizen body needs to flip to "dead" too.
///   • The case being marked discovered (MurderController.OnVictimDiscovery) —
///     so a player who hasn't physically walked past the body still gets the
///     case progression on their UI.
///
/// Both are mirrored "as-is" by re-invoking the same SoD method under
/// <see cref="IsApplyingRemote"/> so the patches don't echo. The host's case
/// scheduler stays authoritative; we just keep clients visually in sync.
/// </summary>
public static class CitizenDeathSync
{
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void BroadcastDeath(int victimHumanId, int killerHumanId, int weaponInteractableId, Vector3 deathPos)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (victimHumanId < 0) return;

        try
        {
            var packet = new CitizenDeathPacket
            {
                VictimHumanId        = victimHumanId,
                KillerHumanId        = killerHumanId,
                WeaponInteractableId = weaponInteractableId,
                DeathPosition        = deathPos,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.CitizenDeath, _writer, DeliveryMethod.ReliableOrdered);

            Plugin.Log.LogInfo(
                $"[DeathSync] broadcast death victim={victimHumanId} killer={killerHumanId} weapon={weaponInteractableId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastDeath: {ex.Message}");
        }
    }

    public static void BroadcastDiscovery()
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new CrimeSceneDiscoveredPacket { DiscovererPlayerId = NetworkManager.LocalPlayerId };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.CrimeSceneDiscovered, _writer, DeliveryMethod.ReliableOrdered);

            Plugin.Log.LogInfo($"[DeathSync] broadcast discovery by player {NetworkManager.LocalPlayerId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastDiscovery: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        try
        {
            if (type == PacketType.CitizenDeath)
            {
                var p = new CitizenDeathPacket();
                p.Deserialize(reader);
                ApplyDeath(p);
            }
            else if (type == PacketType.CrimeSceneDiscovered)
            {
                var p = new CrimeSceneDiscoveredPacket();
                p.Deserialize(reader);
                ApplyDiscovery(p);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"CitizenDeathSync.OnPacketReceived({type}): {ex.Message}");
        }
    }

    private static void ApplyDeath(CitizenDeathPacket p)
    {
        // Find victim in citizenDictionary.
        Human victim = null;
        try
        {
            var dict = CityData.Instance?.citizenDictionary;
            if (dict != null) dict.TryGetValue(p.VictimHumanId, out victim);
        }
        catch { /* ignore */ }

        if (victim == null)
        {
            Plugin.Log.LogWarning($"[DeathSync] victim humanID={p.VictimHumanId} not found");
            return;
        }
        if (victim.isDead) return;   // already dead — idempotent

        // Killer / weapon are best-effort: missing on the client is fine, the body
        // still flips to dead. We don't try to construct a MurderController.Murder
        // object; the host's MurderController is the authoritative case driver.
        Human killer = null;
        try
        {
            if (p.KillerHumanId >= 0)
            {
                var dict = CityData.Instance?.citizenDictionary;
                if (dict != null) dict.TryGetValue(p.KillerHumanId, out killer);
            }
        }
        catch { /* ignore */ }

        Interactable weapon = null;
        try
        {
            if (p.WeaponInteractableId >= 0)
            {
                var dir = CityData.Instance?.interactableDirectory;
                if (dir != null && p.WeaponInteractableId < dir.Count)
                    weapon = dir[p.WeaponInteractableId];
            }
        }
        catch { /* ignore */ }

        IsApplyingRemote = true;
        try
        {
            // Try the full Murder call first — it sets up the rag-doll, drop animations,
            // wound state. If it throws (because of the null murder-case argument), fall
            // back to a minimal flag-flip + animator + AI disable.
            try
            {
                victim.Murder(killer, false /* setTimeOfDeath */, null, weapon, 0f);
            }
            catch
            {
                FallbackKill(victim, p.DeathPosition);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyDeath({p.VictimHumanId}): {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    /// <summary>Minimal "make this body look dead" path if Human.Murder throws.</summary>
    private static void FallbackKill(Human victim, Vector3 deathPos)
    {
        try { victim.isDead = true; } catch { }

        // Snap visual to the host's reported death position so it doesn't appear
        // to die mid-walk on the client side.
        try
        {
            if (victim.transform != null && deathPos != Vector3.zero)
                victim.transform.position = deathPos;
        }
        catch { }

        // Stop the local NewAIController so the corpse doesn't keep walking.
        try
        {
            var aic = victim.gameObject.GetComponent("NewAIController")?.TryCast<Behaviour>();
            if (aic != null) aic.enabled = false;
        }
        catch { }

        // Animator → dead pose.
        try
        {
            var anim = victim.gameObject.GetComponentInChildren<CitizenAnimationController>(true);
            if (anim != null) anim.SetDead(true);
        }
        catch { }
    }

    private static void ApplyDiscovery(CrimeSceneDiscoveredPacket p)
    {
        var mc = MurderController.Instance;
        if (mc == null) return;

        IsApplyingRemote = true;
        try
        {
            mc.OnVictimDiscovery();
            Plugin.Log.LogInfo($"[DeathSync] applied remote discovery from player {p.DiscovererPlayerId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyDiscovery: {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }
}
