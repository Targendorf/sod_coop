using System;
using System.Collections.Generic;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Host-side. Phase B of the per-client character system: each connected
/// client gets a "twin" — an existing city citizen on the host whose
/// firstName/surName/citizenName fields are overwritten with the client's
/// chosen name. From SoD's perspective, that citizen IS the remote player
/// for purposes of NPC dialog references, ID papers, banking records,
/// employer rosters, and so on.
///
/// <para>The twin is picked deterministically (FNV-1a hash of the client
/// GUID, modulo the candidate pool) so the same client returns to the
/// same identity on reconnect. Picks skip the host's own player citizen,
/// dead citizens, and any humanID already claimed by another client.</para>
///
/// <para>This intentionally does NOT remove the twin from city simulation —
/// they keep their apartment, schedule, and job (it's the "Variant 1"
/// trade-off the user accepted: free integration with SoD's identity
/// machinery, at the cost of the player potentially bumping into "themselves"
/// in-world). Phase B.2 / B.3 can address those edges later.</para>
/// </summary>
public static class TwinManager
{
    /// <summary>
    /// Ensures the record has a HumanID assigned and that citizen's name
    /// fields match the record. Returns the resolved humanID, or 0 on
    /// failure (no city loaded, no candidates left, etc.).
    /// </summary>
    public static int EnsureTwinAssigned(string seed, CharacterStore.Record record)
    {
        if (record == null) return 0;

        // Already assigned and citizen still resolvable → just (re)apply name.
        if (record.HumanID > 0)
        {
            if (TryApplyName(record.HumanID, record.FirstName, record.Surname))
                return record.HumanID;

            Plugin.Log.LogWarning(
                $"[TwinManager] stored humanID {record.HumanID} for {record.FirstName} {record.Surname} no longer resolves — repicking.");
            record.HumanID = 0;
        }

        int picked = PickCandidate(seed, record.ClientGuid);
        if (picked <= 0)
        {
            Plugin.Log.LogWarning("[TwinManager] no eligible citizen to pick as twin (city not loaded? all taken?)");
            return 0;
        }

        if (TryApplyName(picked, record.FirstName, record.Surname))
        {
            record.HumanID = picked;
            CharacterStore.Persist(seed);
            Plugin.Log.LogInfo(
                $"[TwinManager] assigned twin humanID={picked} to {record.FirstName} {record.Surname} (client {record.ClientGuid})");
            return picked;
        }

        return 0;
    }

    /// <summary>
    /// Re-applies all stored twin name overrides for the given seed. Called
    /// from <c>StartHost</c> so that whatever vanilla SoD reset on save load
    /// gets re-stamped with our names. Records without a HumanID yet are
    /// left alone — they'll get one on the owning client's next connect.
    /// </summary>
    public static void ReapplyAll(string seed)
    {
        int applied = 0, skipped = 0, repicked = 0;
        foreach (var rec in CharacterStore.AllForSeed(seed))
        {
            if (rec.HumanID <= 0) { skipped++; continue; }
            if (TryApplyName(rec.HumanID, rec.FirstName, rec.Surname)) { applied++; continue; }

            // Stored citizen is gone or unreachable — try to repick so the
            // player at least keeps their identity if they reconnect.
            Plugin.Log.LogWarning(
                $"[TwinManager] stored humanID {rec.HumanID} for {rec.FirstName} {rec.Surname} not resolvable — repicking.");
            int newPick = PickCandidate(seed, rec.ClientGuid);
            if (newPick > 0 && TryApplyName(newPick, rec.FirstName, rec.Surname))
            {
                rec.HumanID = newPick;
                repicked++;
            }
        }

        if (applied + repicked + skipped > 0)
        {
            Plugin.Log.LogInfo($"[TwinManager] reapply: applied={applied}, repicked={repicked}, skipped(no humanID yet)={skipped}");
            if (repicked > 0) CharacterStore.Persist(seed);
        }
    }

    // ─────────────────────────────────────────────────────────────────────
    //  Internals
    // ─────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Direct write of firstName/surName/citizenName on the live Human in
    /// <c>CityData.Instance.citizenDictionary</c>. Returns false if the
    /// city isn't loaded or the citizen vanished.
    /// </summary>
    private static bool TryApplyName(int humanID, string firstName, string surName)
    {
        try
        {
            var city = global::CityData.Instance;
            if (city == null || city.citizenDictionary == null) return false;
            if (!city.citizenDictionary.TryGetValue(humanID, out var human) || human == null) return false;

            human.firstName   = firstName ?? "";
            human.surName     = surName ?? "";
            human.citizenName = string.IsNullOrEmpty(surName) ? (firstName ?? "") : $"{firstName} {surName}";
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[TwinManager] TryApplyName({humanID}): {ex.GetType().Name}: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// Picks a fresh humanID for a client. Filters out:
    ///   • the host's own player citizen (so the player doesn't become its
    ///     own client),
    ///   • already-taken humanIDs from other records in this seed,
    ///   • dead citizens (they wouldn't be referenceable as a living
    ///     identity in IDs / banking / employment).
    /// Selection is deterministic via FNV-1a(clientGuid) % candidates.
    /// </summary>
    private static int PickCandidate(string seed, string clientGuid)
    {
        try
        {
            var city = global::CityData.Instance;
            if (city == null || city.citizenDictionary == null || city.citizenDictionary.Count == 0)
                return 0;

            int playerHumanID = -1;
            try { playerHumanID = global::Player.Instance?.humanID ?? -1; } catch { }

            var taken = new HashSet<int>();
            foreach (var rec in CharacterStore.AllForSeed(seed))
                if (rec.HumanID > 0) taken.Add(rec.HumanID);

            var candidates = new List<int>(city.citizenDictionary.Count);
            foreach (var kv in city.citizenDictionary)
            {
                int id = kv.Key;
                var h = kv.Value;
                if (id == playerHumanID) continue;
                if (taken.Contains(id)) continue;
                try { if (h != null && h.isDead) continue; } catch { }
                candidates.Add(id);
            }
            if (candidates.Count == 0) return 0;

            // Stable order — Dictionary iteration is not ordered. Sort by
            // humanID so the hash → index mapping is reproducible across
            // host runs even if SoD changes its internal ordering.
            candidates.Sort();

            uint hash = StableHash(clientGuid);
            int idx = (int)(hash % (uint)candidates.Count);
            return candidates[idx];
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[TwinManager] PickCandidate failed: {ex}");
            return 0;
        }
    }

    /// <summary>FNV-1a 32-bit. Stable across runtimes (unlike <c>string.GetHashCode</c>).</summary>
    private static uint StableHash(string s)
    {
        unchecked
        {
            uint hash = 2166136261u;
            if (!string.IsNullOrEmpty(s))
            {
                foreach (var c in s) hash = (hash ^ c) * 16777619u;
            }
            return hash;
        }
    }
}
