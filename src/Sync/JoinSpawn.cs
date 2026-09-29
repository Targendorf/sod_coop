using System;
using SoDCoop.Network;
using SoDCoop.Zdo;
using UnityEngine;

namespace SoDCoop.Sync;

/// <summary>
/// Client-side: once a join has finished loading and synced, put the player
/// next to the host.
///
/// <para><b>Why.</b> Nothing ever placed the joiner. Where they appeared was
/// wherever the world load left them: a share-code join starts a NEW game, and
/// SoD's chapter start (<c>ChapterIntro.OnGameStart</c>, which must run — see
/// its patch) puts a new game's player in the starting apartment, the intro /
/// tutorial house; a Save-Transfer join restores the player position in the
/// host's save, and the chapter start can move that too. Either way the joiner
/// began somewhere across the city from the host.</para>
///
/// <para><b>When.</b> Armed at WorldReady of every join load (first join and
/// every re-sync reload) and again after the chapter start, since that can run
/// after WorldReady and move the player. Fires once the client has the host's
/// world state (<see cref="ZdoMan.ClientSynced"/>), SoD's loading operation is
/// over, and a host position sampled after arming has arrived — the value left
/// over from before a reload is where the host WAS. A joiner already within
/// <see cref="NEAR_ENOUGH_M"/> of the host (a Save-Transfer join usually
/// is) stays where it is.</para>
///
/// <para><b>Where.</b> The walkable node next to the host's, in the same room,
/// so the two bodies don't overlap; the host's own node when it has no free
/// neighbour. <c>Player.Teleport</c> is SoD's own relocation — it updates the
/// player's node / room / building, which a bare transform write would leave
/// pointing at the old place.</para>
/// </summary>
public static class JoinSpawn
{
    private const float NEAR_ENOUGH_M = 6f;
    /// <summary>Let SoD's end-of-load placement settle before moving the player.</summary>
    private const float SETTLE_S = 1.5f;
    private const float RETRY_S = 0.5f;
    /// <summary>Stop trying after this long armed — the host may be somewhere
    /// we can't resolve a node for, and there is no point retrying forever.</summary>
    private const float GIVE_UP_S = 90f;

    private static bool _armed;
    private static float _armedAt;
    private static float _readySince = -1f;
    private static float _nextTryAt;
    private static float _armedHostSampleTime = float.NaN;

    /// <summary>(Re)arm: the next time the joiner is loaded and synced, move it
    /// to the host. Idempotent.</summary>
    public static void Arm(string why)
    {
        if (NetworkManager.IsHost) return;
        _armed = true;
        _armedAt = Time.unscaledTime;
        _readySince = -1f;
        _nextTryAt = 0f;
        _armedHostSampleTime = HostSampleTime();
        Plugin.Log.LogInfo($"[JoinSpawn] armed ({why}) — will place the player next to the host once synced.");
    }

    public static void Reset()
    {
        _armed = false;
        _readySince = -1f;
    }

    /// <summary>Per frame from <c>CoopUpdateRunner</c>. Cheap while disarmed.</summary>
    public static void Update()
    {
        if (!_armed) return;
        float now = Time.unscaledTime;

        if (NetworkManager.IsHost || !NetworkManager.IsConnected) { _armed = false; return; }
        if (now - _armedAt > GIVE_UP_S)
        {
            _armed = false;
            Plugin.Log.LogWarning("[JoinSpawn] gave up — no usable host position. The player stays where the load put them.");
            return;
        }

        bool ready = WorldReadyGate.IsWorldReady && ZdoMan.ClientSynced && !IsLoading();
        if (!ready) { _readySince = -1f; return; }
        if (_readySince < 0f) { _readySince = now; return; }
        if (now - _readySince < SETTLE_S) return;
        if (now < _nextTryAt) return;
        _nextTryAt = now + RETRY_S;

        try
        {
            if (!TryGetHostPosition(out Vector3 hostPos)) return;

            var player = global::Player.Instance;
            if (player == null) return;
            Vector3 me;
            try
            {
                var anchor = player.playerContainer;
                me = anchor != null ? anchor.position : player.transform.position;
            }
            catch { me = player.transform.position; }

            float dist = Vector3.Distance(me, hostPos);
            if (dist <= NEAR_ENOUGH_M)
            {
                _armed = false;
                Plugin.Log.LogInfo($"[JoinSpawn] already {dist:F1} m from the host — staying put.");
                return;
            }

            if (!TryFindSpawnNode(hostPos, out var node, out bool nextTo))
            {
                Plugin.Log.LogDebug($"[JoinSpawn] no node at the host's position {hostPos} yet — retrying.");
                return;
            }

            player.Teleport(node, null, true, false, true);
            _armed = false;
            Plugin.Log.LogInfo(
                $"[JoinSpawn] moved the player {dist:F0} m to the host " +
                $"({(nextTo ? "next to them" : "onto their spot")}, node {node.nodeCoord}).");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[JoinSpawn] {ex.Message}");
        }
    }

    private static bool IsLoading()
    {
        try { return global::CityConstructor.Instance != null && global::CityConstructor.Instance.loadingOperationActive; }
        catch { return false; }
    }

    private static int HostPlayerId()
    {
        var players = NetworkManager.Players;
        if (players == null) return -1;
        foreach (var kv in players)
            if (kv.Value != null && kv.Value.IsHost) return kv.Key;
        return -1;
    }

    /// <summary>Sample time on the host's LocalPlayer ZDO, NaN when none.</summary>
    private static float HostSampleTime()
    {
        int hostId = HostPlayerId();
        if (hostId < 0) return float.NaN;
        var z = ZdoMan.FindBySodId(ZdoTypeTag.LocalPlayer, hostId);
        if (z == null || !z.HasKey(ZdoKeys.PosTime)) return float.NaN;
        return z.GetFloat(ZdoKeys.PosTime, float.NaN);
    }

    /// <summary>The host's current position — only once a sample taken after
    /// arming has arrived (the host re-sends one at least once a second).</summary>
    private static bool TryGetHostPosition(out Vector3 pos)
    {
        pos = default;
        int hostId = HostPlayerId();
        if (hostId < 0) return false;
        var z = ZdoMan.FindBySodId(ZdoTypeTag.LocalPlayer, hostId);
        if (z == null || !z.HasKey(ZdoKeys.Pos) || !z.HasKey(ZdoKeys.PosTime)) return false;
        float t = z.GetFloat(ZdoKeys.PosTime, float.NaN);
        if (float.IsNaN(t)) return false;
        if (!float.IsNaN(_armedHostSampleTime) && t == _armedHostSampleTime) return false;
        pos = z.GetVector3(ZdoKeys.Pos);
        return pos != Vector3.zero;
    }

    /// <summary>The node to put the joiner on: a free walkable neighbour of the
    /// host's node in the same room, else the host's node itself.</summary>
    private static bool TryFindSpawnNode(Vector3 hostPos, out global::NewNode node, out bool nextTo)
    {
        node = null;
        nextTo = false;
        var cd = global::CityData.Instance;
        var pf = global::PathFinder.Instance;
        if (cd == null || pf == null) return false;
        var map = pf.nodeMap;
        if (map == null) return false;

        Vector3Int c = cd.RealPosToNodeInt(hostPos);
        global::NewNode hostNode = null;
        // The body anchor sits on the floor; rounding can land a hair below
        // it, so also try the node level above.
        if (!map.TryGetValue(new Vector3(c.x, c.y, c.z), out hostNode) || hostNode == null)
            map.TryGetValue(new Vector3(c.x, c.y, c.z + 1), out hostNode);
        if (hostNode == null) return false;

        try
        {
            var access = hostNode.accessToOtherNodes;
            if (access != null)
            {
                foreach (var kv in access)
                {
                    var n = kv.Key;
                    var a = kv.Value;
                    if (n == null || a == null) continue;
                    if (!a.walkingAccess || a.door != null) continue;
                    if (n.room != hostNode.room) continue;
                    if (n.isObstacle || n.noAccess || n.isInaccessable) continue;
                    if (n.nodeCoord.z != hostNode.nodeCoord.z) continue;
                    node = n;
                    nextTo = true;
                    return true;
                }
            }
        }
        catch { /* fall back to the host's node */ }

        node = hostNode;
        return true;
    }
}
