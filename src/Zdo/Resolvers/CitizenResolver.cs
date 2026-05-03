using System;

namespace SoDCoop.Zdo.Resolvers;

/// <summary>
/// Apply <see cref="ZdoTypeTag.Citizen"/> state to the live <c>Citizen</c>
/// looked up by <c>__sodId = humanID</c>. Receivers mirror outfit, restrained,
/// stunned, asleep, in-bed transitions so guard / suspicion / animation
/// systems on the client see the same actor state the host does. The ZDO
/// state is preserved for snapshot replay so a late-joiner gets the host's
/// truth.
///
/// <para>Idempotent on receivers: setters are guarded with
/// <c>IsApplyingRemote</c> in the legacy syncs we re-use, so the call doesn't
/// echo back. Same-value writes are a no-op on the SoD side.</para>
/// </summary>
public sealed class CitizenResolver : IZdoResolver
{
    public ZdoTypeTag Tag => ZdoTypeTag.Citizen;

    public void Apply(Zdo z)
    {
        if (z == null) return;
        // Host is the authority; never apply on the host.
        if (SoDCoop.Network.NetworkManager.IsHost) return;

        int humanId = z.GetInt(ZdoKeys.SodId, int.MinValue);
        if (humanId == int.MinValue) return;

        try
        {
            if (z.HasKey(ZdoKeys.OutfitCategory))
            {
                byte cat = z.GetByte(ZdoKeys.OutfitCategory, 0);
                SoDCoop.Sync.NpcOutfitSync.ApplyByHumanId(humanId, cat);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenResolver] outfit apply: {ex.Message}"); }

        try
        {
            if (z.HasKey(ZdoKeys.Restrained))
            {
                bool  restrained = z.GetBool (ZdoKeys.Restrained, false);
                float duration   = z.GetFloat(ZdoKeys.RestrainedDuration, 0f);
                SoDCoop.Sync.InventorySync.ApplyRestrainedByHumanId(humanId, restrained, duration);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenResolver] restrained apply: {ex.Message}"); }

        try
        {
            if (z.HasKey(ZdoKeys.Stunned))
            {
                bool stunned = z.GetBool(ZdoKeys.Stunned, false);
                SoDCoop.Sync.InventorySync.ApplyStunnedByHumanId(humanId, stunned);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenResolver] stunned apply: {ex.Message}"); }

        // Drunk + bleeding are visual-only on the receiver — stamp them
        // directly via the public Citizen field setter; SoD's animation /
        // spatter system reads them on the next tick.
        try
        {
            var dict = global::CityData.Instance?.citizenDictionary;
            if (dict == null || !dict.TryGetValue(humanId, out var c) || c == null) return;

            if (z.HasKey(ZdoKeys.Drunk))
            {
                try { c.drunk = z.GetFloat(ZdoKeys.Drunk, 0f); } catch { }
            }
            if (z.HasKey(ZdoKeys.Bleeding))
            {
                try { c.bleeding = z.GetFloat(ZdoKeys.Bleeding, 0f); } catch { }
            }

            // Stance — direct field write triggers SoD's animator transition.
            if (z.HasKey(ZdoKeys.Crouched))
            {
                try { c.isCrouched = z.GetBool(ZdoKeys.Crouched, false); } catch { }
            }

            // Vitals (food / water / HP). Whether they actually need to be
            // mirrored onto the local citizen is mostly cosmetic — SoD's own
            // gameplay loop on the host drives the live values. We mirror so
            // the receiver's view of NPC body anim (e.g. weak-from-hunger
            // walk speed) matches host. The HUD-relevant stamp onto
            // Player.Instance lives below for the player's own twin.
            if (z.HasKey(ZdoKeys.Nourishment))
            {
                try { c.nourishment = z.GetFloat(ZdoKeys.Nourishment, c.nourishment); } catch { }
            }
            if (z.HasKey(ZdoKeys.Hydration))
            {
                try { c.hydration = z.GetFloat(ZdoKeys.Hydration, c.hydration); } catch { }
            }
            if (z.HasKey(ZdoKeys.CurrentHealth))
            {
                try { c.currentHealth = z.GetFloat(ZdoKeys.CurrentHealth, c.currentHealth); } catch { }
            }

            // If this citizen IS the local client's own twin, also stamp
            // Player.Instance with the authoritative vitals so the HUD
            // reflects what host sees. Without this, the client eats food
            // on host's side (host's twin's nourishment goes up) but the
            // client's HUD still shows the old value because Player.Instance
            // ticks independently from the citizen.
            int myTwinId = SoDCoop.Network.NetworkManager.MyTwinHumanID;
            if (myTwinId > 0 && humanId == myTwinId)
            {
                try
                {
                    var p = global::Player.Instance;
                    if (p != null)
                    {
                        if (z.HasKey(ZdoKeys.Nourishment))   { try { p.nourishment   = c.nourishment;   } catch { } }
                        if (z.HasKey(ZdoKeys.Hydration))     { try { p.hydration     = c.hydration;     } catch { } }
                        if (z.HasKey(ZdoKeys.CurrentHealth)) { try { p.currentHealth = c.currentHealth; } catch { } }
                    }
                }
                catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenResolver] my-twin Player.Instance stamp: {ex.Message}"); }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenResolver] drunk/bleeding/vitals apply: {ex.Message}"); }

        // Murder state (Wave 2.3): the dead bool flip drives the receiver to
        // run Human.Murder with the carried killer/weapon. Idempotent —
        // CitizenDeathSync.ApplyDeathFromZdo bails if isDead is already true.
        try
        {
            if (z.HasKey(ZdoKeys.Dead) && z.GetBool(ZdoKeys.Dead, false))
            {
                int killer = z.GetInt(ZdoKeys.KillerHumanId, -1);
                int weapon = z.GetInt(ZdoKeys.WeaponInteractableId, -1);
                UnityEngine.Vector3 pos = z.GetVector3(ZdoKeys.DeathPos, default);
                SoDCoop.Sync.CitizenDeathSync.ApplyDeathFromZdo(humanId, killer, weapon, pos);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenResolver] death apply: {ex.Message}"); }
    }
}
