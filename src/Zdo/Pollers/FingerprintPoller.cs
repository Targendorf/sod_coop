using System;
using System.Collections.Generic;
using SoDCoop.Network;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Fingerprint replication. Runs on every peer, with a different job on each.
///
/// <para><b>Host:</b> the authority for the city's prints. Watches every
/// interactable's <c>df</c> (DynamicFingerprint list) and emits one
/// <see cref="ZdoTypeTag.Fingerprint"/> ZDO per new print, carrying
/// <c>(interactableId, humanId, life)</c>; receivers replay it through
/// <c>FingerprintSync.ApplyAddDirect</c>.</para>
///
/// <para><b>Client:</b> reports the prints ITS OWN player leaves, which exist
/// only in the client's world, to the host through the existing
/// <c>FingerprintSync.BroadcastAdd</c> packet. The host already remaps those to
/// the client's twin (<c>FingerprintSync.ApplyAdd</c>), adds them to its world,
/// and from there they reach everyone as ordinary host prints.</para>
///
/// <para><b>What was broken, and why (2026-09-29).</b> This is a detective
/// game; who touched what is the core mechanic, and the sync got all of it
/// wrong:</para>
/// <list type="bullet">
///   <item><description><b>Every replicated print was attributed to human 0.</b>
///   The ZDO wrote <c>HumanId = 0</c> on the grounds that "live adds are
///   detected via the active patch path with the human id" — but that patch
///   (<c>Interactable.AddNewDynamicFingerprint</c>) is disabled. Receivers
///   looked up citizen 0, got null, and passed null to
///   AddNewDynamicFingerprint. <c>DynamicFingerprint</c> carries no Human
///   reference — only <c>id / created / seed / life</c> — and <c>id</c> is the
///   identity the game has for the print, so it is what we send now. A one-shot
///   diagnostic logs the first few ids against the citizen roster to confirm
///   that reading on a real session.</description></item>
///   <item><description><b>Objects whose <c>df</c> was allocated after the scan
///   passed them were missed forever.</b> An interactable only entered the
///   cache if <c>df != null</c> at the single moment the incremental scan
///   reached it. Every interactable is now indexed by position, and anything
///   near a player is re-checked every tick, so a print appearing where anyone
///   can see it is caught within one tick however lazily the game allocated
///   the list.</description></item>
///   <item><description><b>Client prints never reached the host at all</b> — the
///   host poller only sees the host's world, and the client-side patch is the
///   same disabled one.</description></item>
///   <item><description><b>First sight re-broadcast every existing print.</b>
///   The baseline defaulted to 0, so the first time the sweep reached an
///   interactable it emitted all of its prints as new — duplicates on any
///   client that already had them, which with Save-Transfer is every client.
///   First sight now only records the baseline.</description></item>
/// </list>
/// </summary>
public static class FingerprintPoller
{
    public const float TICK_HZ = 5f;
    public const string NAME = "fingerprints";

    // ── Shared ─────────────────────────────────────────────────────────────
    //
    // Every interactable and its position come from InteractableSpatialCache,
    // which WorldEditSync shares. This poller only keeps its own cursor for the
    // host-side "does it carry prints" classification.

    /// <summary>Directory index up to which entries have been classified for
    /// <see cref="_bearing"/>. Separate from the shared cache's cursor because
    /// another caller may have advanced the cache past entries we haven't
    /// looked at yet.</summary>
    private static int _classifiedTo;

    /// <summary>df.Count per interactable id as last observed. Absent = never
    /// seen: the first observation only records the baseline.</summary>
    private static readonly Dictionary<int, int> _lastCount = new();

    private static readonly List<UnityEngine.Vector3> _anchors = new();
    private static readonly List<int> _near = new();
    private static readonly HashSet<int> _nearSeen = new();

    // ── Host: print-bearing cache + sweep ─────────────────────────────────

    /// <summary>Directory indices known to carry a <c>df</c> list — the set the
    /// city-wide sweep walks.</summary>
    private static readonly List<int> _bearing = new();
    private static readonly HashSet<int> _bearingSet = new();

    /// <summary>Print-bearing entries examined per tick by the city-wide sweep.</summary>
    private const int SWEEP_PER_TICK = 128;
    private static int _sweepCursor;
    private static uint _seq = 1;

    // ── Client: own-print detection ────────────────────────────────────────

    /// <summary>A player can only leave prints on what they are touching; this
    /// radius around the local player is all the client has to watch.</summary>
    private const float OWN_TOUCH_RADIUS_M = 6f;

    // ── Diagnostics ────────────────────────────────────────────────────────

    private static int _idDiagnosticsLeft = 5;

    public static void Register() => ZdoPollerHost.RegisterAnyPeer(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline()
    {
        InteractableSpatialCache.Reset();
        _classifiedTo = 0;
        _lastCount.Clear();
        _bearing.Clear();
        _bearingSet.Clear();
        _sweepCursor = 0;
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForFingerprints) return;
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
            int before = InteractableSpatialCache.ScannedTo;
            InteractableSpatialCache.Advance();
            if (InteractableSpatialCache.ScannedTo < before) _classifiedTo = 0;   // directory rebuilt under us

            if (NetworkManager.IsHost)
            {
                ClassifyBearing();
                HostTick();
            }
            else ClientTick();
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[FingerprintPoller] tick: {ex.Message}"); }
    }

    /// <summary>Host: note which newly cached interactables already carry a
    /// print list, so the city-wide sweep knows where to look.</summary>
    private static void ClassifyBearing()
    {
        int end = InteractableSpatialCache.ScannedTo;
        for (int i = _classifiedTo; i < end; i++)
        {
            var inter = InteractableSpatialCache.Get(i);
            if (inter == null) continue;
            object df = null;
            try { df = inter.df; } catch { }
            if (df != null) MarkBearing(i);
        }
        _classifiedTo = end;
    }

    private static void MarkBearing(int dirIdx)
    {
        if (_bearingSet.Add(dirIdx)) _bearing.Add(dirIdx);
    }

    // ════════════════════════════════════════════════════════════════════
    // Host
    // ════════════════════════════════════════════════════════════════════

    private static void HostTick()
    {
        // Tier 1: everything near any player, every tick. Checks df directly,
        // so an object that only now got its list is picked up here.
        InteractableSpatialCache.QueryNearPlayers(_anchors, _near, _nearSeen);
        for (int k = 0; k < _near.Count; k++)
        {
            int d = _near[k];
            if (HostCheck(d)) MarkBearing(d);
        }

        // Tier 2: bounded sweep over the known print-bearing set.
        int total = _bearing.Count;
        int sweep = Math.Min(SWEEP_PER_TICK, total);
        for (int n = 0; n < sweep; n++)
        {
            if (_sweepCursor >= total) _sweepCursor = 0;
            int d = _bearing[_sweepCursor++];
            if (_nearSeen.Contains(d)) continue;
            HostCheck(d);
        }
    }

    /// <summary>Emit a ZDO for every print added to directory entry
    /// <paramref name="d"/> since we last looked. Returns true if the entry
    /// carries a print list at all.</summary>
    private static bool HostCheck(int d)
    {
        var inter = InteractableSpatialCache.Get(d);
        if (inter == null) return false;

        Il2CppSystem.Collections.Generic.List<Interactable.DynamicFingerprint> prints = null;
        try { prints = inter.df; } catch { }
        if (prints == null) return false;

        int interId;
        int curCount;
        try { interId = inter.id; curCount = prints.Count; }
        catch { return true; }

        if (!_lastCount.TryGetValue(interId, out int prev))
        {
            // First sight: record, don't replay. Prints that already existed
            // are in every peer's world already (Save-Transfer ships them in
            // the save), so emitting them would only duplicate.
            _lastCount[interId] = curCount;
            return true;
        }
        if (curCount <= prev)
        {
            if (curCount < prev) _lastCount[interId] = curCount;   // wiped / expired
            return true;
        }

        for (int k = prev; k < curCount; k++)
        {
            Interactable.DynamicFingerprint fp = null;
            try { fp = prints[k]; } catch { }
            if (fp == null) continue;

            int humanId = 0;
            byte life = 0;
            try { humanId = fp.id; } catch { }
            try { life = (byte)fp.life; } catch { }
            LogIdDiagnostic(interId, humanId);

            // Composite SoD id: (interactableId << 16) | host-local sequence.
            int compositeId = unchecked((interId << 16) | (int)(_seq++ & 0xffff));
            var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Fingerprint, compositeId,
                owner: ZdoMan.LocalPeerUid, persistent: true);
            z.Set(ZdoKeys.InteractableId, interId);
            z.Set(ZdoKeys.HumanId, humanId);
            z.Set(ZdoKeys.Life, life);
        }
        _lastCount[interId] = curCount;
        return true;
    }

    /// <summary>First few prints only: log the print's id and whether it names a
    /// citizen, so a real session confirms <c>DynamicFingerprint.id</c> is the
    /// owner's humanID — the reading the attribution fix relies on.</summary>
    private static void LogIdDiagnostic(int interId, int humanId)
    {
        if (_idDiagnosticsLeft <= 0) return;
        _idDiagnosticsLeft--;
        bool isCitizen = false, isPlayer = false;
        try { isCitizen = CityData.Instance?.citizenDictionary?.ContainsKey(humanId) ?? false; } catch { }
        try { isPlayer = global::Player.Instance != null && global::Player.Instance.humanID == humanId; } catch { }
        Plugin.Log.LogInfo(
            $"[FingerprintPoller/Diag] new print on interactable {interId}: fp.id={humanId} " +
            $"isCitizen={isCitizen} isHostPlayer={isPlayer}");
    }

    // ════════════════════════════════════════════════════════════════════
    // Client
    // ════════════════════════════════════════════════════════════════════

    private static void ClientTick()
    {
        int me;
        UnityEngine.Vector3 myPos;
        try
        {
            var p = global::Player.Instance;
            if (p == null) return;
            me = p.humanID;
            myPos = p.transform.position;
        }
        catch { return; }

        _near.Clear();
        _nearSeen.Clear();
        InteractableSpatialCache.Query(myPos, OWN_TOUCH_RADIUS_M, _near, _nearSeen, maxDy: 3.5f);

        for (int k = 0; k < _near.Count; k++)
        {
            var inter = InteractableSpatialCache.Get(_near[k]);
            if (inter == null) continue;

            Il2CppSystem.Collections.Generic.List<Interactable.DynamicFingerprint> prints = null;
            try { prints = inter.df; } catch { }
            if (prints == null) continue;

            int interId, curCount;
            try { interId = inter.id; curCount = prints.Count; }
            catch { continue; }

            if (!_lastCount.TryGetValue(interId, out int prev))
            {
                _lastCount[interId] = curCount;
                continue;
            }
            if (curCount <= prev)
            {
                if (curCount < prev) _lastCount[interId] = curCount;
                continue;
            }

            for (int i = prev; i < curCount; i++)
            {
                Interactable.DynamicFingerprint fp = null;
                try { fp = prints[i]; } catch { }
                if (fp == null) continue;
                int owner; byte life;
                try { owner = fp.id; life = (byte)fp.life; } catch { continue; }

                // Only OUR prints. Everything else in this world is either
                // already the host's (it arrived through the ZDO) or local AI
                // noise the host is authoritative over.
                if (owner != me) continue;

                // Host remaps our humanID to our twin and adds it to its world;
                // it then comes back to us as a ZDO print attributed to the
                // twin, which FingerprintResolver skips as our own echo.
                try { SoDCoop.Sync.FingerprintSync.BroadcastAdd(interId, owner, life); }
                catch (Exception ex) { Plugin.Log.LogWarning($"[FingerprintPoller] own print report: {ex.Message}"); }
            }
            _lastCount[interId] = curCount;
        }
    }
}
