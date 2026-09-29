using System;
using System.Collections.Generic;
using SoDCoop.Network;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-only. Polls the citizens near connected peers for their pose —
/// <c>idleAnimationState</c> (sitting / sweeping / phone / dancing / cooking /
/// etc.), <c>armsBoolAnimationState</c> (typing / smoking / reading / cuffed /
/// etc.) and whether they are in bed — and writes it to each citizen's
/// <see cref="ZdoTypeTag.Citizen"/> ZDO (<see cref="ZdoKeys.AnimIdle"/>,
/// <see cref="ZdoKeys.AnimArms"/>, <see cref="ZdoKeys.InBed"/> /
/// <see cref="ZdoKeys.LowBed"/>). Clients pose the citizens they drive from it
/// (<c>CitizenResolver.ApplyPose</c>).
///
/// <para><b>State, not events (2026-09-29).</b> This used to send a
/// <see cref="ZdoEvents.CITIZEN_ANIM_STATE"/> event on each change, spatially
/// culled to the peers near the citizen at that moment, and silently seeded a
/// baseline — no send — for any citizen it saw for the first time. A client
/// therefore only ever learned a pose that CHANGED while it was nearby: walk
/// into an office where people had sat down before you arrived and they all
/// stood idle at their desks. As ZDO keys the pose rides the join snapshot,
/// the catch-up a peer gets when it enters an area, and reliable deltas;
/// <c>Zdo.Set</c> already skips unchanged values, so a quiet city costs
/// nothing on the wire.</para>
///
/// <para><b>Field verification</b> (Assembly-CSharp_Dump):
/// <list type="bullet">
///   <item><c>Actor.animationController : CitizenAnimationController</c> (Actor.cs:1536)</item>
///   <item><c>CitizenAnimationController.idleAnimationState : IdleAnimationState</c> (1908)</item>
///   <item><c>CitizenAnimationController.armsBoolAnimationState : ArmsBoolSate</c> (1895)</item>
///   <item><c>Actor.isInBed</c> / <c>Actor.isInLowBed</c> bool (Actor.cs:1165/1178)</item>
/// </list></para>
/// </summary>
public static class CitizenAnimationPoller
{
    public const string NAME = "citizen-anim";

    /// <summary>Scan rate in Auto mode. Auto only reads the citizens near a
    /// peer, so it can afford a rate at which someone sitting down is seen
    /// sitting within a quarter of a second.</summary>
    public const int AUTO_HZ = 4;

    /// <summary>Register with a configurable tick rate. The actual scan
    /// behaviour (full vs spatial) is decided per-tick from
    /// CoopSettings.CitizenAnimSync.</summary>
    public static void Register(int hz = AUTO_HZ)
    {
        hz = UnityEngine.Mathf.Clamp(hz, 1, 5);
        ZdoPollerHost.Register(NAME, 1f / hz, Tick);
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForCitizens) return;
        if (!SoDCoop.Network.NetworkManager.IsHost) return;
        if (!SoDCoop.Network.NetworkManager.HasPeers) return;
        TickInner(now);
    }

    /// <summary>Probe-time entry point used by <see cref="PollerHealthCheck"/>.
    /// Bypasses the feature-flag / IsHost / HasPeers gates so the field-drift
    /// probe exercises the real SoD-field-deref path even on a solo host.</summary>
    internal static void ProbeBody(float now) => TickInner(now);

    private static void TickInner(float now)
    {
        try
        {
            // Shared managed roster — avoids re-enumerating the Il2Cpp
            // citizenDictionary (per-element native calls) every tick.
            if (!CitizenRosterCache.TryGetRoster(out var ids, out var citizens)) return;

            // ── Mode selection ──────────────────────────────────────────────
            // Disabled: no pose sync (not registered at all).
            // Auto: scan only citizens within CULL_RADIUS of connected peers
            //   via SpatialGrid (~30-50 instead of 336). Cheap + accurate
            //   near players. Recommended.
            // FixedHz: scan ALL citizens at the configured rate. Most accurate
            //   but heavy IL2CPP interop cost.
            var mode = CoopSettings.CitizenAnimSync?.Value ?? CitizenAnimSyncMode.Auto;
            if (mode == CitizenAnimSyncMode.Disabled) return;

            List<int> scanIds = ids;
            List<Human> scanCitizens = citizens;
            int scanCount = citizens.Count;

            if (mode == CitizenAnimSyncMode.Auto && NetworkManager.HasPeers)
            {
                // O(visible cells) instead of O(all citizens) — the entire
                // reason Auto mode exists.
                BuildSpatialScanSet(ids, citizens, out scanIds, out scanCitizens);
                scanCount = scanCitizens.Count;
            }

            if (scanCount == 0) return;

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

                var z = ZdoMan.GetOrCreateBySodId(ZdoTypeTag.Citizen, id, owner: ZdoMan.LocalPeerUid, persistent: true);
                z.Set(ZdoKeys.AnimIdle, idle);
                z.Set(ZdoKeys.AnimArms, arms);

                // Bed — here rather than only on CitizenStatePoller's 1 Hz slow
                // lane, so lying down shows at the pose rate. Same key, same
                // value from both: Set() makes the second write a no-op.
                try
                {
                    bool inBed = c.isInBed;
                    z.Set(ZdoKeys.InBed, inBed);
                    if (inBed) z.Set(ZdoKeys.LowBed, c.isInLowBed);
                }
                catch { }

                // Combat stance. The swings themselves are NOT mirrored: the
                // attack animation fires CitizenAnimationEvents.MeleeAttackTrigger,
                // which would run the hit on the client's copy too — the host
                // already delivers that damage.
                try
                {
                    var ai = c.ai;
                    if (ai != null) z.Set(ZdoKeys.InCombat, ai.inCombat);
                }
                catch { }
            }
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
                    var nz = nearZdos[z];
                    // MUST filter by type. SpatialGrid indexes every ZDO with a
                    // host position — doors, lights, switches, computers — not
                    // just citizens, and their __sodId values live in unrelated
                    // ID spaces that collide freely with humanIDs. Without this
                    // check the "citizens near a peer" set was really "citizens
                    // whose humanID happens to equal some nearby door's or
                    // light's id", i.e. an arbitrary subset: animations synced
                    // for NPCs nobody was looking at and stayed frozen for the
                    // ones right in front of the player.
                    if (nz.ZdoTypeTag != ZdoTypeTag.Citizen) continue;
                    int sodId = nz.GetInt(ZdoKeys.SodId, int.MinValue);
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

    /// <summary>Kept for the world-reset call sites. The pose now lives on the
    /// citizen ZDOs, which a reload rebuilds; there is no baseline here.</summary>
    public static void ResetBaseline() { }
}
