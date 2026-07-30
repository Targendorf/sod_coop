using System;
using System.Collections.Generic;
using SoDCoop.Network;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-only. Polls every loaded citizen at 5 Hz for their two animation
/// state enums — <c>idleAnimationState</c> (sitting / sweeping / phone /
/// dancing / cooking / etc., 17 values) and <c>armsBoolAnimationState</c>
/// (resting / typing / smoking / reading / etc., 12 values) — and ships a
/// <see cref="ZdoEvents.CITIZEN_ANIM_STATE"/> event to clients only when
/// either changes for that citizen.
///
/// <para>Without this, client peers see SoD's procedural NPCs walking the
/// city in idle pose only — the host's local AI sets per-citizen idle
/// states that drive the dancing / cooking / phone-talking animations,
/// but those state writes never reach the client. The poller closes that
/// gap with O(diff) bandwidth: typical city tick churn is a handful of
/// state transitions per second across 300 citizens, not the full snapshot.</para>
///
/// <para><b>Field verification</b> (Assembly-CSharp_Dump):
/// <list type="bullet">
///   <item><c>Actor.animationController : CitizenAnimationController</c> (Actor.cs:1536)</item>
///   <item><c>CitizenAnimationController.idleAnimationState : IdleAnimationState</c> (1908)</item>
///   <item><c>CitizenAnimationController.armsBoolAnimationState : ArmsBoolSate</c> (1895)</item>
///   <item><c>SetIdleAnimationState(IdleAnimationState)</c> (2527) — receiver-side apply</item>
///   <item><c>SetArmsBoolState(ArmsBoolSate)</c> (2443) — receiver-side apply</item>
/// </list></para>
/// </summary>
public static class CitizenAnimationPoller
{
    public const string NAME = "citizen-anim";

    /// <summary>Last-broadcast (idle, arms) per citizen. Diff vs current
    /// tick → only changed pairs hit the wire.</summary>
    private static readonly Dictionary<int, (byte idle, byte arms)> _last = new();

    /// <summary>Register with a configurable tick rate. The actual scan
    /// behaviour (full vs spatial) is decided per-tick from
    /// CoopSettings.CitizenAnimSync.</summary>
    public static void Register(int hz = 2)
    {
        hz = UnityEngine.Mathf.Clamp(hz, 1, 5);
        ZdoPollerHost.Register(NAME, 1f / hz, Tick, WarmupBaseline);
    }

    /// <summary>Pre-seed <see cref="_last"/> with every citizen's current
    /// (idle, arms) state without broadcasting. Called by
    /// <see cref="ZdoPollerHost"/> on the first tick after a peer connects
    /// so the post-warmup tick sees a stable baseline and only emits
    /// genuine post-connect transitions. Without this, the first real tick
    /// would treat all 300+ citizens as "everything looks new" and flood
    /// the event channel with state the snapshot already delivered.</summary>
    public static void WarmupBaseline()
    {
        try
        {
            if (!CitizenRosterCache.TryGetRoster(out var ids, out var citizens)) return;
            int count = 0;
            for (int ci = 0; ci < citizens.Count; ci++)
            {
                var c = citizens[ci];
                if (c == null) continue;
                int id = ids[ci];
                if (id == 0) continue;
                global::CitizenAnimationController ac;
                try { ac = c.animationController; } catch { continue; }
                if (ac == null) continue;
                byte idle, arms;
                try { idle = (byte)ac.idleAnimationState; }     catch { continue; }
                try { arms = (byte)ac.armsBoolAnimationState; } catch { continue; }
                _last[id] = (idle, arms);
                count++;
            }
            if (count > 0)
                Plugin.Log.LogDebug($"[CitizenAnimationPoller] warmup: pre-seeded {count} citizen anim baselines (no broadcast)");
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenAnimationPoller] warmup: {ex.Message}"); }
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForEvents) return;
        if (!SoDCoop.Network.NetworkManager.IsHost) return;
        if (!SoDCoop.Network.NetworkManager.HasPeers) return;
        TickInner(now);
    }

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// Bypasses the feature-flag / IsHost / HasPeers gates so the field-drift
    /// probe exercises the real SoD-field-deref path even on a solo host.</summary>
    internal static void ProbeBody(float now) => TickInner(now);

    /// <summary>Soft per-tick send cap. Caps the broadcast burst on cold-start
    /// (when <see cref="_last"/> is empty or stale and the diff would otherwise
    /// emit 200-300 events in one frame). Real per-tick churn in an idle city
    /// is single digits, so this only kicks in during the recovery scenario.
    /// Excess deltas update <see cref="_last"/> silently — they'll be picked
    /// up by the next snapshot cursor or simply on the citizen's next real
    /// state change.</summary>
    private const int MAX_SENT_PER_TICK = 32;

    private static void TickInner(float now)
    {
        try
        {
            // Shared managed roster — avoids re-enumerating the Il2Cpp
            // citizenDictionary (per-element native calls) every tick.
            if (!CitizenRosterCache.TryGetRoster(out var ids, out var citizens)) return;

            // ── Mode selection ──────────────────────────────────────────────
            // Disabled: SoD AI is deterministic — clients compute the same
            //   animation states from the same seed. No network sync needed.
            // Auto: scan only citizens within CULL_RADIUS of connected peers
            //   via SpatialGrid (~30-50 instead of 336). Cheap + accurate
            //   near players. Recommended.
            // FixedHz: scan ALL citizens at the configured rate. Most accurate
            //   but heavy IL2CPP interop cost.
            var mode = CoopSettings.CitizenAnimSync?.Value ?? CitizenAnimSyncMode.Auto;
            if (mode == CitizenAnimSyncMode.Disabled) return;

            // Build the set of citizens to scan this tick. In FixedHz mode
            // it's the full roster; in Auto mode it's a subset filtered by
            // proximity to connected peers via SpatialGrid.
            List<int> scanIds = ids;
            List<Human> scanCitizens = citizens;
            int scanCount = citizens.Count;

            if (mode == CitizenAnimSyncMode.Auto && NetworkManager.HasPeers)
            {
                // Collect all in-range citizen IDs from every connected peer's
                // position via SpatialGrid.Query. This is O(visible cells)
                // instead of O(all citizens) — the entire reason Auto mode
                // exists.
                BuildSpatialScanSet(ids, citizens, out scanIds, out scanCitizens);
                scanCount = scanCitizens.Count;
            }

            if (scanCount == 0) return;

            // Cold-start guard: if the baseline for these citizens is empty
            // (first tick after warmup or after a roster change), re-seed
            // silently and skip broadcasting to avoid a burst.
            // In Auto mode we check only the citizens we're about to scan.
            bool needReseed = false;
            if (mode == CitizenAnimSyncMode.Auto)
            {
                // Auto: check if any of the spatially-selected citizens lack
                // a baseline entry.
                for (int ci = 0; ci < scanCount; ci++)
                {
                    if (scanIds[ci] != 0 && !_last.ContainsKey(scanIds[ci]))
                    { needReseed = true; break; }
                }
            }
            else
            {
                // FixedHz: original half-roster heuristic.
                needReseed = (_last.Count < scanCount / 2);
            }

            if (needReseed)
            {
                for (int ci = 0; ci < scanCount; ci++)
                {
                    var cc = scanCitizens[ci];
                    if (cc == null) continue;
                    int cid = scanIds[ci];
                    if (cid == 0) continue;
                    global::CitizenAnimationController cac;
                    try { cac = cc.animationController; } catch { continue; }
                    if (cac == null) continue;
                    byte cidle, carms;
                    try { cidle = (byte)cac.idleAnimationState; }     catch { continue; }
                    try { carms = (byte)cac.armsBoolAnimationState; } catch { continue; }
                    _last[cid] = (cidle, carms);
                }
                return;
            }

            int sent = 0;
            int suppressed = 0;
            for (int ci = 0; ci < scanCount; ci++)
            {
                var c = scanCitizens[ci];
                if (c == null) continue;
                int id = scanIds[ci];
                if (id == 0) continue;

                global::CitizenAnimationController ac;
                try { ac = c.animationController; } catch { continue; }
                if (ac == null) continue;

                byte idle, arms;
                try { idle = (byte)ac.idleAnimationState; }       catch { continue; }
                try { arms = (byte)ac.armsBoolAnimationState; }   catch { continue; }

                if (_last.TryGetValue(id, out var prev) && prev.idle == idle && prev.arms == arms)
                    continue;

                _last[id] = (idle, arms);

                if (sent >= MAX_SENT_PER_TICK)
                {
                    suppressed++;
                    continue;
                }

                try
                {
                    SoDCoop.Zdo.ZdoEvents.SendCitizenAnimState(id, idle, arms);
                    sent++;
                }
                catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenAnimationPoller] send {id}: {ex.Message}"); }
            }

            if (sent > 0 || suppressed > 0)
                Plugin.Log.LogDebug($"[CitizenAnimationPoller] tick ({mode}, {scanCount} citizens): {sent} delta(s){(suppressed > 0 ? $", {suppressed} suppressed" : "")}");
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CitizenAnimationPoller] tick: {ex.Message}"); }
    }

    // ── Spatial scan subset (Auto mode) ─────────────────────────────────

    /// <summary>Reusable lists for the spatial-scan subset. Avoids per-tick
    /// allocation in Auto mode.</summary>
    private static readonly List<int> _spatialIds = new();
    private static readonly List<Human> _spatialCitizens = new();

    /// <summary>Build a (id, citizen) subset containing only citizens within
    /// <see cref="ZdoMan.CULL_RADIUS_M"/> of any connected peer's last-known
    /// position, via <see cref="SpatialGrid.Query"/>. Falls back to the full
    /// roster if SpatialGrid has no indexed citizens (e.g. before the first
    /// CitizenStatePoller tick stamps positions).</summary>
    private static void BuildSpatialScanSet(List<int> allIds, List<Human> allCitizens,
                                             out List<int> outIds, out List<Human> outCitizens)
    {
        _spatialIds.Clear();
        _spatialCitizens.Clear();

        try
        {
            // Query the grid for each connected peer's position. Merge
            // results into a HashSet to dedup citizens near multiple peers.
            var clients = NetworkManager.Clients;
            var inRangeIds = _spatialIdScratch;
            inRangeIds.Clear();

            for (int i = 0; i < clients.Count; i++)
            {
                int peerId = NetworkManager.GetPlayerIdByPeer(clients[i]);
                if (peerId < 0) continue;
                if (NetworkManager.Players == null
                    || !NetworkManager.Players.TryGetValue(peerId, out var info)
                    || info == null
                    || !info.HasKnownPosition) continue;

                var nearZdos = SpatialGrid.Query(info.LastKnownPosition, SoDCoop.Zdo.ZdoMan.CULL_RADIUS_M);
                for (int z = 0; z < nearZdos.Count; z++)
                {
                    int sodId = nearZdos[z].GetInt(ZdoKeys.SodId, int.MinValue);
                    if (sodId != int.MinValue) inRangeIds.Add(sodId);
                }
            }

            if (inRangeIds.Count == 0)
            {
                // No indexed citizens yet — fall back to full roster.
                outIds = allIds;
                outCitizens = allCitizens;
                return;
            }

            // Walk the full roster once, picking only in-range IDs.
            for (int ci = 0; ci < allCitizens.Count; ci++)
            {
                if (allIds[ci] != 0 && inRangeIds.Contains(allIds[ci]))
                {
                    _spatialIds.Add(allIds[ci]);
                    _spatialCitizens.Add(allCitizens[ci]);
                }
            }

            outIds = _spatialIds;
            outCitizens = _spatialCitizens;
        }
        catch
        {
            outIds = allIds;
            outCitizens = allCitizens;
        }
    }

    private static readonly HashSet<int> _spatialIdScratch = new();

    /// <summary>Drop the diff baseline so the next post-load tick treats
    /// every citizen as freshly-discovered (forces a full re-broadcast).
    /// Called after world reset / save reload.</summary>
    public static void ResetBaseline() => _last.Clear();
}
