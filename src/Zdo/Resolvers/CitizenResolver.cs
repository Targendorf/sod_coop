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

            // Stance (crouch) is part of the pose below. A player twin's pose
            // comes from that player's own LocalPlayer ZDO (LocalPlayerResolver),
            // not from here: the host's copy of its OWN twin is a hidden,
            // frozen body that reports "standing" forever.

            // Pose — idle / arms animation state, in bed, asleep. Only for the
            // citizens driven from the host (the ones near this player): their
            // local AI is off, so nothing here poses them but this. A citizen
            // this machine's AI still runs is posed by that AI; stamping the
            // host's "sitting" or "in bed" onto someone it is walking down a
            // street would only fight it. CitizenPositionSync applies the pose
            // from this ZDO when it takes a citizen over.
            if (SoDCoop.Sync.CitizenPositionSync.IsDriven(humanId))
                ApplyPose(c, z);

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
                try
                {
                    c.currentHealth = z.GetFloat(ZdoKeys.CurrentHealth, c.currentHealth);
                    // The mod's write, not the local player's hit.
                    SoDCoop.Sync.NpcHitSync.NotifyRemoteHealth(humanId, c.currentHealth);
                }
                catch { }
            }

            // NOTE: this used to copy our own twin's nourishment, hydration and
            // health onto Player.Instance "so the HUD matches the host". It had
            // the authority backwards. The player's vitals live on the player's
            // own machine — the twin on the host is a frozen body that only
            // MIRRORS them (LocalPlayerResolver) — and a resolver applies every
            // key on every delta, so any change to the twin (a crouch, a health
            // step) stamped its stale food/water/health over the player's: a
            // meal was undone, a heal reverted. Hits the twin takes on the host
            // now reach the player as damage (DamageSync.ApplyFromZdo).
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

    /// <summary>Combat stance last applied per citizen (client).</summary>
    private static readonly System.Collections.Generic.Dictionary<int, bool> _combatApplied = new();

    /// <summary>Forget what was applied to <paramref name="humanId"/> — it is
    /// being taken over fresh (its local AI may have changed its state since).</summary>
    public static void ForgetPose(int humanId) => _combatApplied.Remove(humanId);

    /// <summary>Put <paramref name="c"/> in the pose the host's copy is in:
    /// crouch, idle animation (sitting, phone, leaning, cooking…), arms state (typing,
    /// smoking, reading…), in bed, asleep. Each goes through SoD's own setter
    /// — the calls its AI makes — and only when it differs, so re-applying on
    /// every delta doesn't restart an animation.
    ///
    /// <para><b>What this replaced.</b> The pose travelled as a one-off event,
    /// sent only when it CHANGED and only to peers near the citizen at that
    /// moment; citizens a peer hadn't been near were silently seeded without
    /// a send. So anyone who sat down, went to bed or picked up the phone while
    /// the client was elsewhere stood there idle when the client arrived —
    /// until they happened to change pose again, which for someone at a desk
    /// is hours. As ZDO keys the pose is state: it is in the join snapshot and
    /// in the catch-up a peer gets on entering the area. Bed state was a bare
    /// field write, which the animator never sees; SetInBed is what lays the
    /// body down.</para></summary>
    public static void ApplyPose(global::Human c, Zdo z)
    {
        if (c == null || z == null) return;
        try
        {
            var ac = c.animationController;
            if (ac != null)
            {
                if (z.HasKey(ZdoKeys.AnimIdle))
                {
                    var v = (global::CitizenAnimationController.IdleAnimationState)z.GetByte(ZdoKeys.AnimIdle, 0);
                    if (ac.idleAnimationState != v) ac.SetIdleAnimationState(v);
                }
                if (z.HasKey(ZdoKeys.AnimArms))
                {
                    var v = (global::CitizenAnimationController.ArmsBoolSate)z.GetByte(ZdoKeys.AnimArms, 0);
                    if (ac.armsBoolAnimationState != v) ac.SetArmsBoolState(v);
                }
                if (z.HasKey(ZdoKeys.InCombat))
                {
                    // The animator exposes no getter for it — remember what we
                    // set, so a delta that didn't touch it doesn't re-set it.
                    int humanId = z.GetInt(ZdoKeys.SodId, 0);
                    bool v = z.GetBool(ZdoKeys.InCombat, false);
                    if (!_combatApplied.TryGetValue(humanId, out bool was) || was != v)
                    {
                        ac.SetInCombat(v);
                        _combatApplied[humanId] = v;
                    }
                }
            }
        }
        catch (Exception ex) { Plugin.Log.LogDebug($"[CitizenResolver] pose anim: {ex.Message}"); }

        try
        {
            if (z.HasKey(ZdoKeys.Crouched))
            {
                bool v = z.GetBool(ZdoKeys.Crouched, false);
                if (c.isCrouched != v) c.SetCrouched(v);
            }
            if (z.HasKey(ZdoKeys.InBed))
            {
                bool v = z.GetBool(ZdoKeys.InBed, false);
                if (c.isInBed != v) c.SetInBed(v, z.GetBool(ZdoKeys.LowBed, false));
            }
            if (z.HasKey(ZdoKeys.Asleep))
            {
                bool v = z.GetBool(ZdoKeys.Asleep, false);
                if (c.isAsleep != v) c.isAsleep = v;
            }
        }
        catch (Exception ex) { Plugin.Log.LogDebug($"[CitizenResolver] pose bed: {ex.Message}"); }
    }
}
