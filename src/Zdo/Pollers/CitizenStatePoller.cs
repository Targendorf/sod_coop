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

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForCitizens) return;
        try
        {
            var dict = CityData.Instance?.citizenDictionary;
            if (dict == null) return;

            foreach (var kv in dict)
            {
                var c = kv.Value;
                if (c == null) continue;
                int id = c.humanID;

                // Fast-skip if the live SoD object isn't fully initialised.
                if (id == 0) continue;

                Zdo z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Citizen, id, owner: ZdoMan.LocalPeerUid, persistent: true);

                // Outfit category — read via outfitController.currentOutfit.
                try
                {
                    var ctrl = c.outfitController;
                    if (ctrl != null)
                    {
                        z.Set(ZdoKeys.OutfitCategory, (byte)ctrl.currentOutfit);
                    }
                }
                catch { /* citizen mid-init */ }

                try { z.Set(ZdoKeys.InBed,    c.isInBed);    } catch { }
                try { z.Set(ZdoKeys.Asleep,   c.isAsleep);   } catch { }
                try { z.Set(ZdoKeys.Stunned,  c.isStunned);  } catch { }

                // Restrain state — on NewAIController.
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
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenStatePoller] tick: {ex.Message}"); }
    }
}
