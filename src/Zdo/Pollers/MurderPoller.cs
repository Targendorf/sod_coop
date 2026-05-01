using System;
using System.Collections.Generic;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side murder detection poller. Walks
/// <c>CityData.Instance.citizenDictionary</c> at 2 Hz and detects
/// <c>citizen.isDead</c> false→true transitions. Triggers broadcasts via
/// existing <see cref="SoDCoop.Sync.CitizenDeathSync.BroadcastDeath"/>.
///
/// <para>Death context (killer, weapon, deathPos) is taken from
/// <c>citizen.deathController</c> if available; otherwise uses safe
/// defaults (-1 humanId, -1 weaponId, citizen.transform.position).</para>
///
/// <para>Replaces the Harmony patch on <c>Human.Murder</c> for
/// post-save-load survival.</para>
/// </summary>
public static class MurderPoller
{
    public const float TICK_HZ = 2f;
    public const string NAME = "murder";

    private static readonly HashSet<int> _knownDead = new();

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

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

                // Killer/weapon attribution unavailable from polling-side state
                // (Human.GetMurder is in nested helper class, hard to reach via
                // Il2CppInterop). Pass sentinels; receivers handle gracefully.
                int killerId = -1;
                int weaponId = -1;
                UnityEngine.Vector3 pos = default;
                try { pos = c.transform.position; } catch { }

                try { SoDCoop.Sync.CitizenDeathSync.BroadcastDeath(id, killerId, weaponId, pos); }
                catch (Exception ex) { Plugin.Log.LogWarning($"[MurderPoller] broadcast {id}: {ex.Message}"); }
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[MurderPoller] tick: {ex.Message}"); }
    }
}
