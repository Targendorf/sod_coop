using System;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side citizen state diff. Walks <c>CityData.Instance.citizenDictionary</c>
/// at 5 Hz and writes (outfit, inBed, asleep, restrained, restrainTime, stunned)
/// to each citizen's <see cref="ZdoTypeTag.Citizen"/> ZDO. Replaces a chunk of
/// the disabled hot patches around outfit/bed/sleep — the legacy <c>NpcOutfitSync</c>
/// path is bypassed when <see cref="ZdoFeatureFlags.UseZdoForCitizens"/> is on
/// (broadcast-side gate not yet wired here; the ZDO path is additive — same
/// state ends up on the wire either way, but the ZDO path also persists across
/// snapshot restores and disk save).
///
/// <para><b>Field name verification</b> (against
/// <c>D:/sod_coop/Assembly-CSharp_Dump/</c>):</para>
/// <list type="bullet">
///   <item><c>Citizen extends Human extends Actor</c></item>
///   <item><c>Actor.isAsleep</c>, <c>Actor.isInBed</c>, <c>Actor.isStunned</c> — bool</item>
///   <item><c>Actor.ai</c> → <c>NewAIController</c></item>
///   <item><c>NewAIController.restrained</c> bool, <c>NewAIController.restrainTime</c> float</item>
///   <item><c>Human.outfitController</c> → <c>CitizenOutfitController</c></item>
///   <item><c>CitizenOutfitController.currentOutfit</c> → <c>ClothesPreset.OutfitCategory</c> (cast to byte)</item>
/// </list>
/// </summary>
public static class CitizenStatePoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "citizens";

    /// <summary>How many base ticks between "slow-lane" passes. At
    /// <see cref="TICK_HZ"/>=5 a value of 5 makes the slow lane run at ~1 Hz.
    ///
    /// <para><b>Why a slow lane:</b> nourishment / hydration / drunk / bleeding
    /// are floats that decay *continuously* in SoD's sim. <c>Zdo.Set(float)</c>
    /// marks the ZDO dirty on any change (exact equality), so reading these
    /// every 5 Hz tick re-dirties nearly EVERY citizen EVERY tick — the dirty
    /// set stays ~full, and the per-flush serialize cost + bandwidth scale with
    /// it. These fields are slow-moving and cosmetic/HUD-only; syncing them at
    /// ~1 Hz is imperceptible and collapses the steady dirty churn. Discrete,
    /// gameplay-relevant fields (health, restrained, stunned, crouch) stay on
    /// the 5 Hz fast lane — they only mark dirty when they actually change, so
    /// they cost nothing when idle and stay responsive when they don't.</para></summary>
    private const int SLOW_EVERY = 5;
    private static int _tickCounter;

    /// <summary>Below this absolute delta, a float Set() is suppressed. SoD's
    /// bleed/poison/regen ticks write sub-unit fractional changes every frame;
    /// without a deadband <c>Zdo.Set(float)</c> re-dirties the citizen every
    /// fast tick (5 Hz × ~336 citizens = up to 1680 dirty ZDOs/sec that each
    /// get serialised + culled + shipped). Health is the gameplay-relevant
    /// outlier — 0.5 hp deadband is well below one damage tick and keeps
    /// combat death/lethal events crisp while swallowing float jitter.</summary>
    private const float HEALTH_DEADBAND = 0.5f;

    /// <summary>Set <paramref name="key"/> on <paramref name="z"/> only if the
    /// new value differs from the current value by more than
    /// <paramref name="deadband"/>. Avoids the perpetual dirty churn that
    /// <c>Zdo.Set(float)</c> otherwise produces on continuously-decaying SoD
    /// sim fields (currentHealth under bleed, nourishment/hydration decay,
    /// drunk/bleeding decay).</summary>
    private static void SetFloatDeadband(Zdo z, int key, float v, float deadband)
    {
        float prev = z.GetFloat(key, float.NaN);
        if (!float.IsNaN(prev) && UnityEngine.Mathf.Abs(prev - v) < deadband) return;
        z.Set(key, v);
    }

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    /// <summary>Drop the slow-lane tick cursor so the first post-load tick
    /// runs the slow lane immediately (correct outfit/vitals state right
    /// after a save load instead of waiting up to 1 s for the slow lane to
    /// cycle back around). Called from
    /// <c>SodCommonBridge.OnBeforeLoad</c>.</summary>
    public static void ResetBaseline() { _tickCounter = 0; }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForCitizens) return;
        TickInner(now);
    }

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// Bypasses the feature-flag gate so the field-drift probe exercises the
    /// real SoD-field-deref path.</summary>
    internal static void ProbeBody(float now) => TickInner(now);

    private static void TickInner(float now)
    {
        try
        {
            // Shared managed roster — avoids re-enumerating the Il2Cpp
            // citizenDictionary (per-element native calls) every tick.
            if (!CitizenRosterCache.TryGetRoster(out var ids, out var citizens)) return;

            // Slow lane fires once every SLOW_EVERY base ticks (~1 Hz).
            bool slowTick = (_tickCounter++ % SLOW_EVERY) == 0;

            for (int ci = 0; ci < citizens.Count; ci++)
            {
                var c = citizens[ci];
                if (c == null) continue;
                int id = ids[ci];

                // Fast-skip if the live SoD object isn't fully initialised.
                if (id == 0) continue;

                Zdo z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Citizen, id, owner: ZdoMan.LocalPeerUid, persistent: true);

                // ── FAST LANE (every tick, 5 Hz) ─────────────────────────────
                // Position for sector-cull (local-only, no dirty marking) and
                // the discrete gameplay-relevant flags. These only mark the ZDO
                // dirty when they actually transition, so polling them at 5 Hz
                // costs nothing while idle and stays responsive on change.

                // Stamp current world position onto the ZDO so per-peer
                // dispatch can sector-cull it. No dirty marking.
                try
                {
                    var t = c.transform;
                    if (t != null) ZdoMan.NotifyZdoPosition(z, t.position);
                }
                catch { }

                try { z.Set(ZdoKeys.Stunned,  c.isStunned);  } catch { }
                try { z.Set(ZdoKeys.Crouched, c.isCrouched); } catch { }
                // currentHealth: damage/heal is discrete (event-driven), but
                // SoD's bleed/poison tick writes sub-unit fractional drops
                // every frame — without a deadband Zdo.Set(float) re-dirties
                // the citizen every fast tick (5 Hz × 336 = ~1.7k dirty/sec).
                // HEALTH_DEADBAND is well below a single damage event so combat
                // death/lethal transitions stay crisp while float jitter is
                // swallowed.
                try { SetFloatDeadband(z, ZdoKeys.CurrentHealth, c.currentHealth, HEALTH_DEADBAND); } catch { }

                // Restrain state — on NewAIController. The restrained BOOL is
                // the discrete gameplay-relevant transition (combat / arrest),
                // keep it fast. restrainTime is a monotonically-growing timer
                // that's dirty every fast tick for as long as anyone is tied
                // up — moved to the slow lane below (it's cosmetic: how long
                // the NPC has been restrained, not whether they are).
                try
                {
                    var ai = c.ai;
                    if (ai != null)
                    {
                        z.Set(ZdoKeys.Restrained, ai.restrained);
                    }
                }
                catch { /* AI may be uninitialised on early ticks */ }

                if (!slowTick) continue;

                // ── SLOW LANE (~1 Hz) ────────────────────────────────────────
                // Continuously-drifting floats (vitals decay, drunk/bleeding
                // decay) + slow cosmetic state. Reading these every fast tick is
                // what kept ~every citizen perpetually dirty; ~1 Hz is plenty
                // for HUD/cosmetic fields and collapses the steady dirty churn.

                // Outfit category — read via outfitController.currentOutfit.
                try
                {
                    var ctrl = c.outfitController;
                    if (ctrl != null)
                        z.Set(ZdoKeys.OutfitCategory, (byte)ctrl.currentOutfit);
                }
                catch { /* citizen mid-init */ }

                try { z.Set(ZdoKeys.InBed,  c.isInBed);  } catch { }
                try { z.Set(ZdoKeys.Asleep, c.isAsleep); } catch { }

                // restrainTime (monotonic timer while NPC is tied up). Moved
                // here from the fast lane — it's cosmetic and would otherwise
                // dirty every restrained citizen every fast tick for the
                // entire duration of the restraint.
                try
                {
                    var ai = c.ai;
                    if (ai != null) z.Set(ZdoKeys.RestrainedDuration, ai.restrainTime);
                }
                catch { /* AI may be uninitialised on early ticks */ }

                // Visual-state floats — drunk staggers walk, bleeding drips
                // blood. Both auto-drive SoD animation/spatter on the receiver.
                // Field discovery: Human.drunk float (Human.cs:7938),
                // Human.bleeding float (Human.cs:8068).
                try { z.Set(ZdoKeys.Drunk,    c.drunk);    } catch { }
                try { z.Set(ZdoKeys.Bleeding, c.bleeding); } catch { }

                // Vitals (food / water). Slow decay; receiver applies via
                // CitizenResolver (also stamps the receiver's own twin HUD).
                // Field discovery (Assembly-CSharp_Dump):
                //   Human.nourishment float (Human.cs:7808)
                //   Human.hydration   float (Human.cs:7821)
                try { z.Set(ZdoKeys.Nourishment, c.nourishment); } catch { }
                try { z.Set(ZdoKeys.Hydration,   c.hydration);   } catch { }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenStatePoller] tick: {ex.Message}"); }
    }
}
