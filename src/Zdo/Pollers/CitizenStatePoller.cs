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

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

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
                // currentHealth: damage/heal is discrete (event-driven), so it
                // doesn't churn the dirty set — keep it fast for combat response.
                try { z.Set(ZdoKeys.CurrentHealth, c.currentHealth); } catch { }

                // Restrain state — on NewAIController. State transition (discrete),
                // gameplay-relevant (combat / arrest), keep fast.
                try
                {
                    var ai = c.ai;
                    if (ai != null)
                    {
                        z.Set(ZdoKeys.Restrained,         ai.restrained);
                        z.Set(ZdoKeys.RestrainedDuration, ai.restrainTime);
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
