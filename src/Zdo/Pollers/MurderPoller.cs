using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side murder detection poller. Walks
/// <c>CityData.Instance.citizenDictionary</c> at 2 Hz and detects
/// <c>citizen.isDead</c> false→true transitions. Triggers broadcasts via
/// existing <see cref="SoDCoop.Sync.CitizenDeathSync.BroadcastDeath"/>.
///
/// <para>Death context (killer, weapon, deathPos) read from
/// <c>citizen.death</c> (a nested <c>Human.Death</c> object) which carries
/// <c>killer</c> (int humanID), <c>weapon</c> (int interactableID), and
/// <c>victim</c> (int). Field discovery via Assembly-CSharp_Dump/Human.cs
/// line 1683 (class Death) and line 8451 (Human.death property).</para>
///
/// <para>Replaces the Harmony patch on <c>Human.Murder</c> entirely with
/// full attribution preserved. Patch can be disabled.</para>
/// </summary>
public static class MurderPoller
{
    public const float TICK_HZ = 2f;
    public const string NAME = "murder";

    private static readonly HashSet<int> _knownDead = new();

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline() => _knownDead.Clear();

    private static void Tick(float now)
    {
        try
        {
            var dict = CityData.Instance?.citizenDictionary;
            if (dict == null) return;

            foreach (var kv in dict)
            {
                int id = kv.Key;
                var c = kv.Value;
                if (c == null) continue;

                bool dead = false;
                try { dead = c.isDead; } catch { }

                if (!dead)
                {
                    if (_knownDead.Contains(id)) _knownDead.Remove(id);
                    continue;
                }

                if (_knownDead.Contains(id)) continue;
                _knownDead.Add(id);

                // Read killer + weapon from the citizen's Human.death record.
                // SoD populates this in Actor.RecieveDamage when enableKill=true
                // and in Human.Murder, before the postfix would have fired.
                int killerId = -1;
                int weaponId = -1;
                try
                {
                    var d = c.death;
                    if (d != null)
                    {
                        try { killerId = d.killer; } catch { }
                        try { weaponId = d.weapon; } catch { }
                    }
                }
                catch { /* death may be null mid-init */ }

                UnityEngine.Vector3 pos = default;
                try { pos = c.transform.position; } catch { }

                // Phase G.5 (Wave 2.3): write to per-citizen ZDO (same ZDO
                // CitizenStatePoller writes to). CitizenResolver applies on
                // receivers via CitizenDeathSync.ApplyDeathFromZdo.
                try
                {
                    var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Citizen, id,
                        owner: ZdoMan.LocalPeerUid, persistent: true);
                    z.Set(ZdoKeys.Dead,                 true);
                    z.Set(ZdoKeys.KillerHumanId,        killerId);
                    z.Set(ZdoKeys.WeaponInteractableId, weaponId);
                    z.Set(ZdoKeys.DeathPos,             pos);
                }
                catch (Exception ex) { Plugin.Log.LogWarning($"[MurderPoller] zdo {id}: {ex.Message}"); }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[MurderPoller] tick: {ex.Message}"); }
    }
}
