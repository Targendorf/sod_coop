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

        // Snapshot-restore guard: the playtest 2026-06-16 regression (every
        // NPC naked + crouched + falling over) was caused by the snapshot
        // carrying outfit=0 / crouched=true / stunned=true values that the
        // host's CitizenStatePoller had stamped DURING its own init-grace
        // window — before SoD's CitizenOutfitController had finished
        // initialising. Those early-write defaults got into the snapshot and
        // were then applied verbatim on joiners.
        //
        // The surgical fix: skip applying cosmetic/derived keys whose value
        // is the UNINITIALISED default. A genuine host-side transition
        // (outfit=3 for a real citizen, crouched=true from actual gameplay)
        // has a non-default value and is still applied. This lets real state
        // through while swallowing the init-time noise. The per-tick
        // CitizenStatePoller re-stamps correct values once SoD's init
        // completes (its own diff baseline is seeded by WarmupBaseline so
        // only genuine post-init transitions hit the wire).
        bool inCatchup = SoDCoop.Sync.WorldReadyGate.IsInInitGrace;

        try
        {
            if (z.HasKey(ZdoKeys.OutfitCategory))
            {
                byte cat = z.GetByte(ZdoKeys.OutfitCategory, 0);
                // cat==0 is the "None" / uninitialized outfit — applying it
                // would strip the citizen naked. Skip only during catch-up;
                // post-grace a real 0 (citizen genuinely undressed) is valid.
                if (!(inCatchup && cat == 0))
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
                // restrained=false is the default — skip during catch-up
                // (no-one is tied up at world init).
                if (!(inCatchup && !restrained))
                    SoDCoop.Sync.InventorySync.ApplyRestrainedByHumanId(humanId, restrained, duration);
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenResolver] restrained apply: {ex.Message}"); }

        try
        {
            if (z.HasKey(ZdoKeys.Stunned))
            {
                bool stunned = z.GetBool(ZdoKeys.Stunned, false);
                if (!(inCatchup && !stunned))
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

            // For drunk/bleeding/nourishment/hydration: skip only when BOTH
            // (a) we're in catch-up AND (b) the value is 0/default — i.e.
            // probably an init-time stamp of a freshly-spawned citizen. A
            // real "citizen is bleeding 2.3" from gameplay is applied
            // regardless of grace state.
            if (z.HasKey(ZdoKeys.Drunk))
            {
                float v = z.GetFloat(ZdoKeys.Drunk, 0f);
                if (!(inCatchup && v == 0f)) try { c.drunk = v; } catch { }
            }
            if (z.HasKey(ZdoKeys.Bleeding))
            {
                float v = z.GetFloat(ZdoKeys.Bleeding, 0f);
                if (!(inCatchup && v == 0f)) try { c.bleeding = v; } catch { }
            }

            // Stance — direct field write triggers SoD's animator transition.
            if (z.HasKey(ZdoKeys.Crouched))
            {
                bool v = z.GetBool(ZdoKeys.Crouched, false);
                if (!(inCatchup && !v)) try { c.isCrouched = v; } catch { }
            }

            // Sleep / bed. CitizenStatePoller has been shipping both of these
            // on every slow tick since the cadence split, but NOTHING read them
            // on the receiving side — the keys crossed the wire, sat in the ZDO
            // and in every snapshot, and were dropped. A citizen asleep in bed
            // on the host stayed awake and standing for the joiner. Same
            // direct-field-write treatment as Crouched above: SoD's animator
            // and AI read these on their next tick.
            if (z.HasKey(ZdoKeys.InBed))
            {
                bool v = z.GetBool(ZdoKeys.InBed, false);
                if (!(inCatchup && !v)) try { c.isInBed = v; } catch { }
            }
            if (z.HasKey(ZdoKeys.Asleep))
            {
                bool v = z.GetBool(ZdoKeys.Asleep, false);
                if (!(inCatchup && !v)) try { c.isAsleep = v; } catch { }
            }

            // Vitals (food / water / HP). Whether they actually need to be
            // mirrored onto the local citizen is mostly cosmetic — SoD's own
            // gameplay loop on the host drives the live values. We mirror so
            // the receiver's view of NPC body anim (e.g. weak-from-hunger
            // walk speed) matches host. The HUD-relevant stamp onto
            // Player.Instance lives below for the player's own twin.
            if (z.HasKey(ZdoKeys.Nourishment))
            {
                float v = z.GetFloat(ZdoKeys.Nourishment, c.nourishment);
                if (!(inCatchup && v <= 0f)) try { c.nourishment = v; } catch { }
            }
            if (z.HasKey(ZdoKeys.Hydration))
            {
                float v = z.GetFloat(ZdoKeys.Hydration, c.hydration);
                if (!(inCatchup && v <= 0f)) try { c.hydration = v; } catch { }
            }
            // currentHealth is always applied — a real HP value is gameplay-
            // critical (combat/death sync). Even 0 is meaningful (corpse).
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
