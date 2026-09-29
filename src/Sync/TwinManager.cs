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
            FreezeTwin(picked);
            Plugin.Log.LogInfo(
                $"[TwinManager] assigned twin humanID={picked} to {record.FirstName} {record.Surname} (client {record.ClientGuid})");
            return picked;
        }

        return 0;
    }

    /// <summary>
    /// Returns the twin humanID assigned to the network player <paramref name="senderId"/>,
    /// or 0 if no remap should happen. Returns 0 for: non-host runtime, the
    /// host's own player, unknown senderId, sender without a stored character
    /// record, or sender whose record has no twin assigned yet.
    ///
    /// <para>Used by forensics-style sync handlers (fingerprints, footprints,
    /// evidence creation) on the host to translate a remote player's
    /// "self-attributed" humanID — which is meaningless on the host (it's
    /// the client's local Player.Instance.humanID) — into the twin citizen
    /// the host has chosen to represent that player in its world.</para>
    /// </summary>
    public static int GetTwinHumanIDForSender(int senderId)
    {
        try
        {
            if (!Network.NetworkManager.IsHost) return 0;
            if (senderId == Network.NetworkManager.LocalPlayerId) return 0;
            if (!Network.NetworkManager.Players.TryGetValue(senderId, out var info)) return 0;
            if (string.IsNullOrEmpty(info?.ClientGuid)) return 0;

            var rec = CharacterStore.TryGet(CharacterStore.CurrentSeed(), info.ClientGuid);
            return rec?.HumanID ?? 0;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[TwinManager] GetTwinHumanIDForSender({senderId}): {ex.Message}");
            return 0;
        }
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

        // Freeze every twin: SoD just reloaded citizens with their AI enabled,
        // so we have to re-disable for our claimed identities every host start.
        FreezeAllTwins();
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

    // ─────────────────────────────────────────────────────────────────────
    //  Phase B.3 — protection / removal-from-simulation
    // ─────────────────────────────────────────────────────────────────────

    /// <summary>True iff this humanID is currently a twin for any client in the host's current seed.</summary>
    public static bool IsTwin(int humanID)
    {
        if (humanID <= 0) return false;
        try
        {
            string seed = CharacterStore.CurrentSeed();
            foreach (var rec in CharacterStore.AllForSeed(seed))
                if (rec.HumanID == humanID) return true;
        }
        catch { }
        return false;
    }

    /// <summary>
    /// All currently-claimed twin humanIDs for the host's current seed.
    /// Used by the murder-victim protection prefix in
    /// <c>SoDCoop.Patches.GamePatches</c> to temporarily isDead-mask
    /// twins during SoD's victim-picking pass.
    /// </summary>
    public static List<int> GetAllTwinHumanIDsForCurrentSeed()
    {
        var list = new List<int>();
        try
        {
            string seed = CharacterStore.CurrentSeed();
            foreach (var rec in CharacterStore.AllForSeed(seed))
                if (rec.HumanID > 0) list.Add(rec.HumanID);
        }
        catch { }
        return list;
    }

    /// <summary>
    /// Disable each twin's <c>NewAIController</c> so they stop walking their
    /// daily schedule and freeze in place. Called after <see cref="ReapplyAll"/>
    /// (host startup) and after each fresh <see cref="EnsureTwinAssigned"/>.
    ///
    /// <para>Trade-off: the twin's body stops moving, but the citizen record
    /// stays alive in city DB so phone calls / ID papers / employment / case
    /// board references all keep resolving correctly. This is the
    /// "remove from schedule" behaviour the user requested for B.3.</para>
    /// </summary>
    public static void FreezeAllTwins()
    {
        int frozen = 0;
        foreach (var humanID in GetAllTwinHumanIDsForCurrentSeed())
        {
            if (FreezeTwin(humanID)) frozen++;
        }
        if (frozen > 0) Plugin.Log.LogInfo($"[TwinManager] froze {frozen} twin(s) (NewAIController disabled).");

        HideOwnTwinBody();
    }

    /// <summary>Hide the LOCAL player's own twin so they don't walk past a
    /// frozen copy of themselves.
    ///
    /// <para>The twin has to keep existing: it is the citizen record every
    /// machine attributes this player's fingerprints, footprints and other
    /// forensic traces to, so deleting it would break evidence. It just has no
    /// reason to be <i>visible</i> on the owner's own machine — the owner is
    /// <c>Player.Instance</c>, and the twin is a motionless duplicate standing
    /// wherever it was first claimed.</para>
    ///
    /// <para>Renderers are disabled rather than the GameObject deactivated:
    /// switching the object off would take the <c>Human</c> component, and with
    /// it the forensic record and every lookup through
    /// <c>citizenDictionary</c>, down with it.</para>
    ///
    /// <para>OTHER players' twins are deliberately left alone — since 54a3512
    /// they ARE the visible body of a remote player.</para></summary>
    /// <summary>Id of the twin whose renderers we have already switched off, so
    /// the per-frame call is an int compare in the steady state instead of a
    /// GetComponentsInChildren walk. Reset on world unload — a reload rebuilds
    /// the citizen hierarchy with its renderers back on.</summary>
    private static int _ownTwinHidden;

    public static void HideOwnTwinBody()
    {
        try
        {
            int myTwin = SoDCoop.Network.NetworkManager.MyTwinHumanID;
            if (myTwin <= 0) return;
            // The twin id only becomes known at handshake, well after
            // FreezeAllTwins runs, so this is also called from the frame
            // cascade until it lands.
            if (_ownTwinHidden == myTwin) return;
            SetTwinRenderersEnabled(myTwin, false);
            _ownTwinHidden = myTwin;
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[TwinManager] HideOwnTwinBody: {ex.Message}"); }
    }

    /// <summary>Forget which twin we hid. Called on world unload / session end
    /// so the next world re-hides against its freshly built citizen rig.</summary>
    public static void ResetOwnTwinHidden() => _ownTwinHidden = 0;

    private static float _nextPeerTwinFreezeAt;
    private static readonly HashSet<int> _loggedLocalFreeze = new();

    /// <summary>Keep every player's twin frozen in THIS machine's world, on
    /// every peer — not only on the host.
    ///
    /// <para><b>What was broken:</b> twins were only ever frozen by
    /// <see cref="FreezeAllTwins"/>, which reads the host's
    /// <c>CharacterStore</c> and runs at host start. A client loads the world
    /// fresh, with every citizen's AI enabled, and nothing froze the twins
    /// there. So on a client the host's twin and other players' twins — the
    /// bodies <c>RemotePlayer</c> drives — ran their daily schedule underneath
    /// the network position every frame (sitting down, walking off, using
    /// doors); and the client's OWN twin, hidden since dae7875, walked the city
    /// invisibly, opening doors and switching lights that existed on that
    /// client only.</para>
    ///
    /// <para>Twin ids come from the roster every peer receives in the
    /// handshake. Re-checked once a second because SoD can switch a citizen's
    /// AI back on by itself (knock-out recovery, waking up).</para></summary>
    public static void FreezePeerTwinsLocally()
    {
        float now = UnityEngine.Time.unscaledTime;
        if (now < _nextPeerTwinFreezeAt) return;
        _nextPeerTwinFreezeAt = now + 1f;

        if (!SoDCoop.Network.NetworkManager.IsConnected) return;
        if (!WorldReadyGate.IsWorldReady) return;

        try
        {
            var players = SoDCoop.Network.NetworkManager.Players;
            var dict = global::CityData.Instance?.citizenDictionary;
            if (players == null || dict == null) return;

            foreach (var kv in players)
            {
                int id = kv.Value?.TwinHumanID ?? 0;
                if (id <= 0) continue;
                if (!dict.TryGetValue(id, out var human) || human == null) continue;
                var ai = human.ai;
                if (ai == null || !ai.enabled) continue;
                ai.enabled = false;
                if (_loggedLocalFreeze.Add(id))
                    Plugin.Log.LogInfo($"[TwinManager] froze twin #{id} ({kv.Value.PlayerName}) in this machine's world.");
            }
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[TwinManager] FreezePeerTwinsLocally: {ex.Message}"); }
    }

    /// <summary>Put a twin's renderers back. Called when the player releases a
    /// twin (character reset) so a citizen that returns to the city's normal
    /// population isn't left invisible.</summary>
    public static void ShowTwinBody(int humanID) => SetTwinRenderersEnabled(humanID, true);

    private static void SetTwinRenderersEnabled(int humanID, bool enabled)
    {
        try
        {
            var city = global::CityData.Instance;
            if (city == null || city.citizenDictionary == null) return;
            if (!city.citizenDictionary.TryGetValue(humanID, out var human) || human == null) return;
            var go = human.gameObject;
            if (go == null) return;

            // includeInactive: true — parts of SoD's citizen rig sit on
            // inactive children (held items, alternate meshes) and would
            // otherwise reappear the moment the game enables them.
            var renderers = go.GetComponentsInChildren<UnityEngine.Renderer>(true);
            if (renderers == null) return;
            int n = 0;
            for (int i = 0; i < renderers.Length; i++)
            {
                var r = renderers[i];
                if (r == null || r.enabled == enabled) continue;
                r.enabled = enabled;
                n++;
            }
            if (n > 0)
                Plugin.Log.LogInfo($"[TwinManager] own twin #{humanID}: {(enabled ? "showed" : "hid")} {n} renderer(s).");
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[TwinManager] SetTwinRenderersEnabled({humanID},{enabled}): {ex.Message}"); }
    }

    /// <summary>
    /// Inverse of <see cref="FreezeTwin"/>. Re-enables the twin's
    /// <c>NewAIController</c> so they rejoin the daily simulation. Used when
    /// a client resets their character on this world — the formerly-claimed
    /// citizen returns to ordinary NPC behaviour (still with the
    /// player-given name though; we don't restore the original name because
    /// we never stored it).
    /// </summary>
    private static bool UnfreezeTwin(int humanID)
    {
        try
        {
            var city = global::CityData.Instance;
            if (city == null || city.citizenDictionary == null) return false;
            if (!city.citizenDictionary.TryGetValue(humanID, out var human) || human == null || human.gameObject == null) return false;

            var comp = human.gameObject.GetComponent("NewAIController");
            if (comp == null) return false;
            var ai = comp.TryCast<NewAIController>();
            if (ai == null || ai.enabled) return false;
            ai.enabled = true;
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[TwinManager] UnfreezeTwin({humanID}): {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// Host-side handler for <see cref="Network.PacketType.CharacterReset"/>.
    /// Removes the client's record from the store, unfreezes their old twin
    /// citizen so they rejoin the simulation, and returns true on success.
    /// Caller is responsible for disconnecting the peer afterwards.
    /// </summary>
    public static bool ReleaseRecord(string seed, string clientGuid)
    {
        try
        {
            var rec = CharacterStore.TryGet(seed, clientGuid);
            if (rec == null)
            {
                Plugin.Log.LogInfo($"[TwinManager] ReleaseRecord: no record for {clientGuid} in seed \"{seed}\" — nothing to do.");
                return false;
            }

            int humanID = rec.HumanID;
            string name = $"{rec.FirstName} {rec.Surname}".Trim();

            CharacterStore.Delete(seed, clientGuid);
            if (humanID > 0)
            {
                UnfreezeTwin(humanID);
                // The citizen rejoins the normal population — it must be
                // visible again, and the hide must be re-evaluated for
                // whatever twin replaces it.
                ShowTwinBody(humanID);
                if (_ownTwinHidden == humanID) _ownTwinHidden = 0;
            }

            Plugin.Log.LogInfo($"[TwinManager] released character \"{name}\" (humanID={humanID}, client={clientGuid}); citizen rejoins simulation.");
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[TwinManager] ReleaseRecord({clientGuid}): {ex}");
            return false;
        }
    }

    private static bool FreezeTwin(int humanID)
    {
        try
        {
            var city = global::CityData.Instance;
            if (city == null || city.citizenDictionary == null) return false;
            if (!city.citizenDictionary.TryGetValue(humanID, out var human) || human == null || human.gameObject == null) return false;

            var comp = human.gameObject.GetComponent("NewAIController");
            if (comp == null) return false;
            var ai = comp.TryCast<NewAIController>();
            if (ai == null) return false;
            if (!ai.enabled) return false;
            ai.enabled = false;
            return true;
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[TwinManager] FreezeTwin({humanID}): {ex.Message}");
            return false;
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
