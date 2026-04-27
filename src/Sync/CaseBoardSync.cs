using System.Collections.Generic;
using SoDCoop.Network;
using LiteNetLib;
using LiteNetLib.Utils;
using UnityEngine;
using DataKey = Evidence.DataKey;
// IL2CPP-side list type (PinToCasePanel and CaseElement.dk use this).
using Il2CppList = Il2CppSystem.Collections.Generic.List<Evidence.DataKey>;

namespace SoDCoop.Sync;

/// <summary>
/// Shared investigation board.
///
/// Three operations are synced:
///   • Pin     — a card is added to the panel.
///   • Unpin   — a card is removed.
///   • Move    — drag-position is streamed at ~20 Hz so the other player sees
///               the card glide in real-time, like in single-player.
///
/// Cross-machine identification:
///   Case   ←  caseID (int)
///   Pin    ←  (caseID, evID, sorted DataKey set)
///
/// Both caseID and evID are deterministic given the same world seed, so we
/// never have to send any object payload — just the IDs.
///
/// Conflict policy: last-write-wins, with the host's packet winning ties.
/// We don't try to lock pins during drag — both players can grab the same
/// card and the latest move packet just overrides whatever's onscreen.
/// </summary>
public static class CaseBoardSync
{
    /// <summary>True while we're applying a remote packet — patches honour this
    /// flag to skip echoing.</summary>
    public static bool IsApplyingRemote { get; private set; }

    private static readonly NetDataWriter _writer = new();

    /// <summary>20 Hz move-broadcast throttle, keyed by pin identity hash.</summary>
    private const float MOVE_THROTTLE = 0.05f;
    private static readonly Dictionary<long, float> _lastMoveSendTime = new();

    /// <summary>
    /// Tracks the last-seen sender for each pin so the host's late packet always
    /// beats a client's earlier one in tight-race situations. (Without this, a
    /// client packet that arrives 1ms after the host's would appear to "win".)
    /// </summary>
    private static readonly Dictionary<long, int> _lastMoveSender = new();

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void BroadcastPin(int caseId, string evId, Il2CppList evKeys, Vector2 pos, bool forceAutoPin)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (string.IsNullOrEmpty(evId)) return;

        try
        {
            var packet = new CaseBoardPinPacket
            {
                CaseId       = caseId,
                EvId         = evId,
                DataKeys     = ToByteArray(evKeys),
                Position     = pos,
                ForceAutoPin = forceAutoPin,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.CaseBoardPin, _writer, DeliveryMethod.ReliableOrdered);

            Plugin.Log.LogInfo($"[CaseBoard] pin broadcast case={caseId} ev={evId} keys={packet.DataKeys.Length}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastPin: {ex.Message}");
        }
    }

    public static void BroadcastUnpin(int caseId, string evId, Il2CppList evKeys)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (string.IsNullOrEmpty(evId)) return;

        try
        {
            var packet = new CaseBoardUnpinPacket
            {
                CaseId   = caseId,
                EvId     = evId,
                DataKeys = ToByteArray(evKeys),
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.CaseBoardUnpin, _writer, DeliveryMethod.ReliableOrdered);

            Plugin.Log.LogInfo($"[CaseBoard] unpin broadcast case={caseId} ev={evId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastUnpin: {ex.Message}");
        }
    }

    /// <summary>
    /// Broadcast a live-drag position. Throttled to 20 Hz per pin and uses
    /// Sequenced delivery (intermediate frames may drop without harm).
    /// </summary>
    public static void BroadcastMove(Case.CaseElement element, Vector2 pos)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (element == null) return;

        try
        {
            // CaseElement.caseID matches its parent's Case.id (both int).
            int caseId = element.caseID;
            string evId = element.id;
            if (string.IsNullOrEmpty(evId)) return;
            byte[] keys = ToByteArray(element.dk);
            long key = PinKey(caseId, evId, keys);

            float now = Time.unscaledTime;
            if (_lastMoveSendTime.TryGetValue(key, out var t) && (now - t) < MOVE_THROTTLE) return;
            _lastMoveSendTime[key] = now;

            var packet = new CaseBoardMovePacket
            {
                CaseId   = caseId,
                EvId     = evId,
                DataKeys = keys,
                Position = pos,
                SenderId = NetworkManager.LocalPlayerId,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            // Sequenced — drop late frames; final position will arrive on drag-end via the same path.
            NetworkManager.SendToAll(PacketType.CaseBoardMove, _writer, DeliveryMethod.Sequenced);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastMove: {ex.Message}");
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Inbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
    {
        try
        {
            if (type == PacketType.CaseBoardPin)
            {
                var p = new CaseBoardPinPacket();
                p.Deserialize(reader);
                ApplyPin(p);
            }
            else if (type == PacketType.CaseBoardUnpin)
            {
                var p = new CaseBoardUnpinPacket();
                p.Deserialize(reader);
                ApplyUnpin(p);
            }
            else if (type == PacketType.CaseBoardMove)
            {
                var p = new CaseBoardMovePacket();
                p.Deserialize(reader);
                ApplyMove(p);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"CaseBoardSync.OnPacketReceived({type}): {ex.Message}");
        }
    }

    private static void ApplyPin(CaseBoardPinPacket p)
    {
        var caseObj = FindCase(p.CaseId);
        var evidence = FindEvidence(p.EvId);
        if (caseObj == null || evidence == null)
        {
            Plugin.Log.LogWarning($"[CaseBoard] ApplyPin: case={p.CaseId} ev={p.EvId} not found");
            return;
        }

        // Already pinned? no-op (idempotent).
        if (FindPinElement(caseObj, p.EvId, p.DataKeys) != null) return;

        var keysList = ToIl2CppList(p.DataKeys);

        IsApplyingRemote = true;
        try
        {
            var cpc = CasePanelController.Instance;
            if (cpc == null) return;
            // PinToCasePanel(toCase, ev, evKeys, forceAutoPin, localPos, debugFlag)
            cpc.PinToCasePanel(caseObj, evidence, keysList, p.ForceAutoPin, p.Position, false);
            Plugin.Log.LogInfo($"[CaseBoard] applied remote pin case={p.CaseId} ev={p.EvId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyPin: {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    private static void ApplyUnpin(CaseBoardUnpinPacket p)
    {
        var caseObj = FindCase(p.CaseId);
        var evidence = FindEvidence(p.EvId);
        if (caseObj == null || evidence == null) return;

        var keysList = ToIl2CppList(p.DataKeys);

        IsApplyingRemote = true;
        try
        {
            var cpc = CasePanelController.Instance;
            if (cpc == null) return;
            // UnPinFromCasePanel(thisCase, ev, evKeys, uniqueKeysOnly=false, forceElement=null)
            cpc.UnPinFromCasePanel(caseObj, evidence, keysList, false, null);
            Plugin.Log.LogInfo($"[CaseBoard] applied remote unpin case={p.CaseId} ev={p.EvId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyUnpin: {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    private static void ApplyMove(CaseBoardMovePacket p)
    {
        // Host-priority tie-break: if our last move came from the host (sender 0)
        // and now a non-host packet arrived in the same frame, ignore the client.
        long key = PinKey(p.CaseId, p.EvId, p.DataKeys);
        if (_lastMoveSender.TryGetValue(key, out var lastSender)
            && lastSender == 0 && p.SenderId != 0)
        {
            float now = Time.unscaledTime;
            if (_lastMoveSendTime.TryGetValue(key, out var lastT) && (now - lastT) < MOVE_THROTTLE)
                return;
        }
        _lastMoveSender[key] = p.SenderId;

        var caseObj = FindCase(p.CaseId);
        if (caseObj == null) return;

        var element = FindPinElement(caseObj, p.EvId, p.DataKeys);
        if (element == null) return;
        var pic = element.pinnedController;
        if (pic == null) return;

        IsApplyingRemote = true;
        try
        {
            pic.SetPostion(p.Position);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyMove: {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Lookup helpers
    // ─────────────────────────────────────────────────────────────────────────

    private static Case FindCase(int caseId)
    {
        try
        {
            var cpc = CasePanelController.Instance;
            if (cpc == null) return null;
            var cases = cpc.activeCases;
            if (cases == null) return null;
            for (int i = 0; i < cases.Count; i++)
            {
                var c = cases[i];
                if (c != null && c.id == caseId) return c;
            }
        }
        catch { }
        return null;
    }

    private static Evidence FindEvidence(string evId)
    {
        if (string.IsNullOrEmpty(evId)) return null;
        try
        {
            var gc = GameplayController.Instance;
            if (gc?.evidenceDictionary == null) return null;
            if (gc.evidenceDictionary.TryGetValue(evId, out var ev)) return ev;
        }
        catch { }
        return null;
    }

    /// <summary>
    /// Walk Case.caseElements looking for one whose id (== evID) and dk
    /// (== DataKey list) match the packet's identifier.
    /// </summary>
    private static Case.CaseElement FindPinElement(Case caseObj, string evId, byte[] keys)
    {
        try
        {
            var elems = caseObj.caseElements;
            if (elems == null) return null;
            for (int i = 0; i < elems.Count; i++)
            {
                var e = elems[i];
                if (e == null) continue;
                if (e.id != evId) continue;
                if (!DataKeysEqual(e.dk, keys)) continue;
                return e;
            }
        }
        catch { }
        return null;
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Key helpers (DataKey list ↔ byte[] / Il2Cpp list, identity hash)
    // ─────────────────────────────────────────────────────────────────────────

    private static byte[] ToByteArray(Il2CppList keys)
    {
        if (keys == null) return System.Array.Empty<byte>();
        int n = keys.Count;
        var arr = new byte[n];
        for (int i = 0; i < n; i++) arr[i] = (byte)keys[i];
        // Stable order so the same set produces the same hash.
        System.Array.Sort(arr);
        return arr;
    }

    private static Il2CppList ToIl2CppList(byte[] keys)
    {
        var list = new Il2CppList();
        if (keys == null) return list;
        for (int i = 0; i < keys.Length; i++) list.Add((DataKey)keys[i]);
        return list;
    }

    private static bool DataKeysEqual(Il2CppList il2Keys, byte[] managed)
    {
        if (managed == null) managed = System.Array.Empty<byte>();
        int n = il2Keys?.Count ?? 0;
        if (n != managed.Length) return false;
        // Compare as sorted sets — ordering on the wire is canonicalised.
        var snap = new byte[n];
        for (int i = 0; i < n; i++) snap[i] = (byte)il2Keys[i];
        System.Array.Sort(snap);
        for (int i = 0; i < n; i++) if (snap[i] != managed[i]) return false;
        return true;
    }

    /// <summary>
    /// Compact 64-bit hash of (caseID, evID, DataKey set). Used as a dictionary
    /// key for per-pin throttling — collisions just mean a pin is throttled
    /// against another, which is harmless.
    /// </summary>
    private static long PinKey(int caseId, string evId, byte[] keys)
    {
        unchecked
        {
            long h = caseId * 397L;
            if (evId != null) h = h * 31L + evId.GetHashCode();
            if (keys != null)
                for (int i = 0; i < keys.Length; i++) h = h * 17L + keys[i];
            return h;
        }
    }
}
