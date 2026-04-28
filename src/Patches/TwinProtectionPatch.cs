using System.Collections.Generic;
using HarmonyLib;
using SoDCoop.Network;
using SoDCoop.Sync;

namespace SoDCoop.Patches;

/// <summary>
/// Phase B.3: protect remote-player twin citizens from being randomly
/// selected by SoD's case generator as a murder victim.
///
/// <para><b>Why this hack:</b> <c>MurderController.PickNewVictim</c>
/// internally builds a candidate list and picks via a lambda predicate
/// we can't easily intercept. The path of least invasion is to flip
/// the candidate's <c>isDead</c> flag on each twin for the duration of
/// the picker call — SoD's filter excludes dead citizens — then
/// restore it in the postfix.</para>
///
/// <para>Risk: anything else inspecting <c>isDead</c> during the prefix /
/// postfix window will see twins as dead. <c>PickNewVictim</c> is bounded
/// (single synchronous call, runs once per case generation), so the
/// window is short and on the host's main thread only.</para>
///
/// <para>Host-only: the patch no-ops on clients (no twins exist there).</para>
/// </summary>
[HarmonyPatch(typeof(MurderController), nameof(MurderController.PickNewVictim))]
public static class MurderController_PickNewVictim_Patch
{
    /// <summary>Twins we flipped to isDead in the prefix; restored in postfix.</summary>
    private static List<Human> _suppressed;

    [HarmonyPrefix]
    public static void Prefix()
    {
        _suppressed = null;
        if (!NetworkManager.IsHost) return;

        try
        {
            var ids = TwinManager.GetAllTwinHumanIDsForCurrentSeed();
            if (ids.Count == 0) return;

            var city = global::CityData.Instance;
            if (city == null || city.citizenDictionary == null) return;

            var list = new List<Human>(ids.Count);
            foreach (var id in ids)
            {
                if (!city.citizenDictionary.TryGetValue(id, out var h) || h == null) continue;
                if (h.isDead) continue; // already dead — leave alone
                h.isDead = true;
                list.Add(h);
            }
            if (list.Count > 0) _suppressed = list;
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"PickNewVictim prefix (twin protection): {ex.Message}");
        }
    }

    [HarmonyPostfix]
    public static void Postfix()
    {
        try
        {
            if (_suppressed == null) return;
            foreach (var h in _suppressed)
            {
                if (h == null) continue;
                try { h.isDead = false; } catch { }
            }
            Plugin.Log.LogInfo($"[TwinProtection] PickNewVictim ran with {_suppressed.Count} twin(s) masked as dead.");
        }
        finally
        {
            _suppressed = null;
        }
    }
}
