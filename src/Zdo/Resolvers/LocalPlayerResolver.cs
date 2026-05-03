using System;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Apply <see cref="ZdoTypeTag.LocalPlayer"/> ZDO state to the live
/// <c>RemotePlayer</c> on receivers. Each peer owns its own LocalPlayer
/// ZDO keyed by <c>__sodId = LocalPlayerId</c>; on remote peers the same
/// key resolves to the matching <c>RemotePlayer</c> mirror.
///
/// <para>Phase G.5 (Wave 1.3-4): currently handles held-item + raised
/// stance + flashlight. Position / rotation / vitals stay on the
/// existing <see cref="SoDCoop.Sync.PlayerSync"/> wire path during
/// transition (will move in a later wave).</para>
/// </summary>
public sealed class LocalPlayerResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.LocalPlayer;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        int playerId = z.GetInt(ZdoKeys.SodId, int.MinValue);
        if (playerId == int.MinValue) return;
        if (playerId == SoDCoop.Network.NetworkManager.LocalPlayerId) return; // own

        var rp = SoDCoop.Player.RemotePlayerManager.GetPlayer(playerId);
        if (rp == null) return;

        try
        {
            if (z.HasKey(ZdoKeys.Held))
            {
                int heldId = z.GetInt(ZdoKeys.Held, -1);
                rp.ApplyHeldItem(heldId);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerResolver] held: {ex.Message}"); }

        try
        {
            if (z.HasKey(ZdoKeys.Raised))
            {
                bool raised = z.GetBool(ZdoKeys.Raised, false);
                rp.ApplyRaised(raised);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerResolver] raised: {ex.Message}"); }

        try
        {
            if (z.HasKey(ZdoKeys.Flashlight))
            {
                bool flashlight = z.GetBool(ZdoKeys.Flashlight, false);
                rp.ApplyFlashlight(flashlight);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerResolver] flashlight: {ex.Message}"); }

        // Host-only: a remote peer pushed its self-state — mirror crouch /
        // KO / HP onto that peer's twin citizen in our world. Next tick
        // CitizenStatePoller writes the same fields onto the twin's Citizen
        // ZDO so every other peer also picks up the change. Without this
        // mirror, a client crouching is invisible to anyone except the
        // client themselves.
        if (SoDCoop.Network.NetworkManager.IsHost)
        {
            try
            {
                int twinId = SoDCoop.Sync.TwinManager.GetTwinHumanIDForSender(playerId);
                if (twinId > 0)
                {
                    var dict = global::CityData.Instance?.citizenDictionary;
                    if (dict != null && dict.TryGetValue(twinId, out var twin) && twin != null)
                    {
                        if (z.HasKey(ZdoKeys.Crouched))
                        {
                            bool crouched = z.GetBool(ZdoKeys.Crouched, false);
                            try { twin.isCrouched = crouched; } catch { }
                        }
                        if (z.HasKey(ZdoKeys.Ko))
                        {
                            bool ko = z.GetBool(ZdoKeys.Ko, false);
                            // Map Player KO → citizen "stunned" state. Same
                            // animator path SoD uses for being-knocked-out on
                            // NPCs, so the visual matches.
                            try { twin.isStunned = ko; } catch { }
                        }
                        if (z.HasKey(ZdoKeys.CurrentHealth))
                        {
                            float hp = z.GetFloat(ZdoKeys.CurrentHealth, twin.currentHealth);
                            try { twin.currentHealth = hp; } catch { }
                        }

                        if (z.HasKey(ZdoKeys.Activity))
                        {
                            byte raw = z.GetByte(ZdoKeys.Activity, 0);
                            ApplyActivityToTwin(twin, (SoDCoop.Player.PlayerActivity)raw);
                        }
                    }
                }
            }
            catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerResolver] host-twin mirror: {ex.Message}"); }
        }
    }

    /// <summary>Map a coarse-grained <see cref="SoDCoop.Player.PlayerActivity"/>
    /// onto the twin citizen's NPC anim states. SetArmsBoolState +
    /// SetIdleAnimationState are SoD's own setters — the same path the
    /// game uses internally when a citizen does the same activity, so the
    /// visual is identical to a normal NPC doing it. Once host writes
    /// these onto the twin, CitizenAnimationPoller picks them up next
    /// tick and replicates to every peer.</summary>
    private static void ApplyActivityToTwin(global::Human twin, SoDCoop.Player.PlayerActivity activity)
    {
        if (twin == null) return;
        var ac = twin.animationController;
        if (ac == null) return;

        global::CitizenAnimationController.ArmsBoolSate arms;
        global::CitizenAnimationController.IdleAnimationState idle;
        switch (activity)
        {
            case SoDCoop.Player.PlayerActivity.Lockpicking:
                arms = global::CitizenAnimationController.ArmsBoolSate.armsLocking;
                idle = global::CitizenAnimationController.IdleAnimationState.none;
                break;
            case SoDCoop.Player.PlayerActivity.ComputerUse:
                arms = global::CitizenAnimationController.ArmsBoolSate.armsTyping;
                idle = global::CitizenAnimationController.IdleAnimationState.none;
                break;
            case SoDCoop.Player.PlayerActivity.PhoneCall:
                arms = global::CitizenAnimationController.ArmsBoolSate.none;
                idle = global::CitizenAnimationController.IdleAnimationState.telephone;
                break;
            case SoDCoop.Player.PlayerActivity.Searching:
                arms = global::CitizenAnimationController.ArmsBoolSate.armsUse;
                idle = global::CitizenAnimationController.IdleAnimationState.none;
                break;
            case SoDCoop.Player.PlayerActivity.Hiding:
                // No specific NPC anim — the hiding interactable handles
                // visual itself once the twin is parented in. Tag still
                // serves as a debug signal in CitizenAnimationPoller logs.
                arms = global::CitizenAnimationController.ArmsBoolSate.none;
                idle = global::CitizenAnimationController.IdleAnimationState.none;
                break;
            default:
                arms = global::CitizenAnimationController.ArmsBoolSate.none;
                idle = global::CitizenAnimationController.IdleAnimationState.none;
                break;
        }

        try { ac.SetArmsBoolState(arms); }
        catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerResolver] SetArmsBoolState({arms}): {ex.Message}"); }
        try { ac.SetIdleAnimationState(idle); }
        catch (Exception ex) { Plugin.Log.LogWarning($"[LocalPlayerResolver] SetIdleAnimationState({idle}): {ex.Message}"); }
    }
}
