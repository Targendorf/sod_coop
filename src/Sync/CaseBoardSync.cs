using System.Collections.Generic;
using SoDCoop.Network;
using LiteNetLib;
using SoDCoop.Network.Steam;
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

    /// <summary>
    /// Push every active case's runtime state to a freshly-joined peer so
    /// the case board converges to the host's view. Without this, a
    /// mid-session client sees an empty board even though the host has
    /// been investigating for hours — pins, threads, and resolve answers
    /// are all only broadcast on change, so the joiner missed everything.
    ///
    /// <para>Sent per active case:</para>
    /// <list type="bullet">
    ///   <item><c>CaseBoardPin</c> per <c>caseElement</c> — pinned card
    ///         identity (evID + DataKey set), board position, auto-pin flag.</item>
    ///   <item><c>CaseBoardString</c> per (StringColours, target) — one
    ///         packet per coloured thread between pinned cards. SoD's
    ///         StringColours can have multiple targets per source so we
    ///         emit one packet per <c>toEv</c> entry.</item>
    ///   <item><c>CaseBoardResolveAnswer</c> per ResolveQuestion with
    ///         non-zero progress — investigation answers (suspect /
    ///         location / time picks).</item>
    ///   <item><c>CaseBoardStatus</c> — the case's current
    ///         <c>caseStatus</c> (active / solved / failed).</item>
    /// </list>
    ///
    /// <para>What's still NOT snapshot'd:</para>
    /// <list type="bullet">
    ///   <item>Hidden-fact toggles (<c>Case.hiddenConnections</c> stores
    ///         them as opaque packed strings — reverse-engineering the
    ///         encoding isn't worth the value; players rarely hide facts).</item>
    ///   <item>Per-fact custom names (<c>Fact.SetCustomName</c>) — would
    ///         require walking every fact on every evidence linked to
    ///         every case-element. Live broadcasts work fine, only
    ///         late-joiners miss pre-existing renames.</item>
    /// </list>
    /// </summary>
    public static void SendSnapshotTo(SteamPeer peer)
    {
        if (peer == null) return;
        if (!NetworkManager.IsHost) return;

        try
        {
            var cpc = global::CasePanelController.Instance;
            var cases = cpc?.activeCases;
            if (cases == null || cases.Count == 0) return;

            int pins = 0, strings = 0, answers = 0, statuses = 0;

            for (int i = 0; i < cases.Count; i++)
            {
                var c = cases[i];
                if (c == null) continue;

                // ─── Pinned cards ────────────────────────────────────────
                try
                {
                    var els = c.caseElements;
                    if (els != null)
                    {
                        for (int j = 0; j < els.Count; j++)
                        {
                            var el = els[j];
                            if (el == null) continue;
                            if (string.IsNullOrEmpty(el.id)) continue;

                            byte[] keyBytes = DataKeyListToBytes(el.dk);

                            var pkt = new CaseBoardPinPacket
                            {
                                CaseId       = c.id,
                                EvId         = el.id,
                                DataKeys     = keyBytes,
                                Position     = el.v,
                                ForceAutoPin = el.ap,
                            };
                            _writer.Reset();
                            pkt.Serialize(_writer);
                            NetworkManager.SendTo(peer, PacketType.CaseBoardPin, _writer, DeliveryMethod.ReliableOrdered);
                            pins++;
                        }
                    }
                }
                catch { }

                // ─── Coloured strings between pinned cards ───────────────
                try
                {
                    var sc = c.stringColours;
                    if (sc != null)
                    {
                        for (int j = 0; j < sc.Count; j++)
                        {
                            var s = sc[j];
                            if (s == null) continue;
                            string fromEv = s.fromEv;
                            if (string.IsNullOrEmpty(fromEv)) continue;

                            byte[] fromKeys = DataKeyListToBytes(s.fromDK);
                            byte[] toKeys   = DataKeyListToBytes(s.toDK);
                            byte   colour   = (byte)System.Math.Max(0, System.Math.Min(255, s.colIndex));

                            var toEvList = s.toEv;
                            if (toEvList == null) continue;

                            // SoD allows one StringColours to fan out to many
                            // toEv entries. Our wire packet is 1-to-1 so we
                            // emit one per target.
                            for (int t = 0; t < toEvList.Count; t++)
                            {
                                string toEv = toEvList[t];
                                if (string.IsNullOrEmpty(toEv)) continue;

                                var pkt = new CaseBoardStringPacket
                                {
                                    CaseId   = c.id,
                                    FromEvId = fromEv,
                                    FromKeys = fromKeys,
                                    ToEvId   = toEv,
                                    ToKeys   = toKeys,
                                    Colour   = colour,
                                };
                                _writer.Reset();
                                pkt.Serialize(_writer);
                                NetworkManager.SendTo(peer, PacketType.CaseBoardString, _writer, DeliveryMethod.ReliableOrdered);
                                strings++;
                            }
                        }
                    }
                }
                catch { }

                // ─── Resolve-question answer progress ────────────────────
                try
                {
                    var qs = c.resolveQuestions;
                    if (qs != null)
                    {
                        for (int j = 0; j < qs.Count; j++)
                        {
                            var q = qs[j];
                            if (q == null) continue;
                            float progress = 0f;
                            try { progress = q.progress; } catch { }
                            if (progress <= 0f) continue; // skip untouched

                            var pkt = new CaseBoardResolveAnswerPacket
                            {
                                CaseId        = c.id,
                                QuestionIndex = j,
                                Progress      = progress,
                                ForceTrigger  = false,
                            };
                            _writer.Reset();
                            pkt.Serialize(_writer);
                            NetworkManager.SendTo(peer, PacketType.CaseBoardResolveAnswer, _writer, DeliveryMethod.ReliableOrdered);
                            answers++;
                        }
                    }
                }
                catch { }

                // ─── Status ──────────────────────────────────────────────
                try
                {
                    var pkt = new CaseBoardStatusPacket
                    {
                        CaseId           = c.id,
                        Status           = (byte)c.caseStatus,
                        CancelObjectives = false,
                    };
                    _writer.Reset();
                    pkt.Serialize(_writer);
                    NetworkManager.SendTo(peer, PacketType.CaseBoardStatus, _writer, DeliveryMethod.ReliableOrdered);
                    statuses++;
                }
                catch { }
            }

            Plugin.Log.LogInfo($"[CaseBoardSync] snapshot: pins={pins} strings={strings} answers={answers} statuses={statuses} → {peer.SteamId.m_SteamID}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"CaseBoardSync.SendSnapshotTo: {ex.Message}");
        }
    }

    private static byte[] DataKeyListToBytes(Il2CppList list)
    {
        try
        {
            int n = list?.Count ?? 0;
            if (n == 0) return System.Array.Empty<byte>();
            var buf = new byte[n];
            for (int i = 0; i < n; i++) buf[i] = (byte)list[i];
            return buf;
        }
        catch { return System.Array.Empty<byte>(); }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Outbound
    // ─────────────────────────────────────────────────────────────────────────

    public static void BroadcastPin(int caseId, string evId, Il2CppList evKeys, Vector2 pos, bool forceAutoPin)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (string.IsNullOrEmpty(evId)) return;

        // Phase G.5 (Wave 3.6): unified RPC channel.
        if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForEvents)
        {
            try { SoDCoop.Zdo.ZdoEvents.SendCbPin(caseId, evId, ToByteArray(evKeys), pos, forceAutoPin); }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"BroadcastPin (zdo): {ex.Message}"); }
            return;
        }

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

            Plugin.Log.LogDebug($"[CaseBoard] pin broadcast case={caseId} ev={evId} keys={packet.DataKeys.Length}");
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

        if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForEvents)
        {
            try { SoDCoop.Zdo.ZdoEvents.SendCbUnpin(caseId, evId, ToByteArray(evKeys)); }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"BroadcastUnpin (zdo): {ex.Message}"); }
            return;
        }

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

            Plugin.Log.LogDebug($"[CaseBoard] unpin broadcast case={caseId} ev={evId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastUnpin: {ex.Message}");
        }
    }

    public static void BroadcastString(int caseId, string fromEvId, Il2CppList fromKeys,
                                       string toEvId, Il2CppList toKeys, byte colour)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (string.IsNullOrEmpty(fromEvId) || string.IsNullOrEmpty(toEvId)) return;

        if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForEvents)
        {
            try { SoDCoop.Zdo.ZdoEvents.SendCbString(caseId, fromEvId, ToByteArray(fromKeys), toEvId, ToByteArray(toKeys), colour); }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"BroadcastString (zdo): {ex.Message}"); }
            return;
        }

        try
        {
            var packet = new CaseBoardStringPacket
            {
                CaseId   = caseId,
                FromEvId = fromEvId,
                FromKeys = ToByteArray(fromKeys),
                ToEvId   = toEvId,
                ToKeys   = ToByteArray(toKeys),
                Colour   = colour,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.CaseBoardString, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogDebug($"[CaseBoard] string broadcast case={caseId} {fromEvId}→{toEvId} colour={colour}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastString: {ex.Message}");
        }
    }

    public static void BroadcastHide(int caseId, Fact fact, bool isHidden)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (fact == null) return;

        try
        {
            // Fact.fromEvidence / toEvidence are lists (multi-source / multi-target).
            // For v1 we take the first element on each side — this covers all
            // 1-to-1 facts which is the common case for player-pinned threads.
            string fromEv = FirstEvId(fact.fromEvidence);
            string toEv   = FirstEvId(fact.toEvidence);
            if (string.IsNullOrEmpty(fromEv) || string.IsNullOrEmpty(toEv)) return;

            var packet = new CaseBoardHidePacket
            {
                CaseId   = caseId,
                FromEvId = fromEv,
                FromKeys = ToByteArray(fact.fromDataKeys),
                ToEvId   = toEv,
                ToKeys   = ToByteArray(fact.toDataKeys),
                IsHidden = isHidden,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.CaseBoardHide, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogDebug($"[CaseBoard] hide broadcast case={caseId} {fromEv}→{toEv} hidden={isHidden}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastHide: {ex.Message}");
        }
    }

    public static void BroadcastResolveAnswer(int caseId, int questionIndex, float progress, bool forceTrigger)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (questionIndex < 0) return;

        try
        {
            var packet = new CaseBoardResolveAnswerPacket
            {
                CaseId        = caseId,
                QuestionIndex = questionIndex,
                Progress      = progress,
                ForceTrigger  = forceTrigger,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.CaseBoardResolveAnswer, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogDebug($"[CaseBoard] resolve-answer broadcast case={caseId} q={questionIndex} p={progress:F2}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastResolveAnswer: {ex.Message}");
        }
    }

    public static void BroadcastResolve(int caseId)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new CaseBoardResolvePacket { CaseId = caseId };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.CaseBoardResolve, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogDebug($"[CaseBoard] resolve broadcast case={caseId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastResolve: {ex.Message}");
        }
    }

    /// <summary>
    /// Broadcast removal of a thread by its frozen identifier. The patch must
    /// snapshot DataKeys before RemoveCustomLink runs (it may null out the
    /// connection during cleanup), and pass the snapshot back here.
    /// </summary>
    public static void BroadcastStringRemoveById(
        int caseId,
        string fromEvId, byte[] fromKeys,
        string toEvId,   byte[] toKeys)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (string.IsNullOrEmpty(fromEvId) || string.IsNullOrEmpty(toEvId)) return;

        if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForEvents)
        {
            try { SoDCoop.Zdo.ZdoEvents.SendCbStringRemove(caseId, fromEvId, fromKeys, toEvId, toKeys); }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"BroadcastStringRemoveById (zdo): {ex.Message}"); }
            return;
        }

        try
        {
            var packet = new CaseBoardStringRemovePacket
            {
                CaseId   = caseId,
                FromEvId = fromEvId,
                FromKeys = fromKeys ?? System.Array.Empty<byte>(),
                ToEvId   = toEvId,
                ToKeys   = toKeys ?? System.Array.Empty<byte>(),
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.CaseBoardStringRemove, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogDebug($"[CaseBoard] string-remove broadcast case={caseId} {fromEvId}→{toEvId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastStringRemoveById: {ex.Message}");
        }
    }

    /// <summary>
    /// Public version of <see cref="ToByteArray"/> for the patch to take a
    /// stable copy of CaseElement.dk before RemoveCustomLink runs.
    /// </summary>
    public static byte[] SnapshotDataKeys(Il2CppList keys) => ToByteArray(keys);

    public static void BroadcastFactName(Fact fact, string customName)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;
        if (fact == null) return;

        try
        {
            string fromEv = FirstEvId(fact.fromEvidence);
            string toEv   = FirstEvId(fact.toEvidence);
            if (string.IsNullOrEmpty(fromEv) || string.IsNullOrEmpty(toEv)) return;

            var packet = new CaseBoardFactNamePacket
            {
                FromEvId   = fromEv,
                FromKeys   = ToByteArray(fact.fromDataKeys),
                ToEvId     = toEv,
                ToKeys     = ToByteArray(fact.toDataKeys),
                CustomName = customName ?? "",
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.CaseBoardFactName, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogDebug($"[CaseBoard] fact-name broadcast {fromEv}→{toEv} = \"{customName}\"");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastFactName: {ex.Message}");
        }
    }

    public static void BroadcastStatus(int caseId, byte status, bool cancelObjectives)
    {
        if (!NetworkManager.IsConnected) return;
        if (IsApplyingRemote) return;

        try
        {
            var packet = new CaseBoardStatusPacket
            {
                CaseId            = caseId,
                Status            = status,
                CancelObjectives  = cancelObjectives,
            };
            _writer.Reset();
            packet.Serialize(_writer);
            NetworkManager.SendToAll(PacketType.CaseBoardStatus, _writer, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogDebug($"[CaseBoard] status broadcast case={caseId} status={status}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"BroadcastStatus: {ex.Message}");
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

            // Phase G.5 (Wave 3.6): unified RPC channel.
            if (SoDCoop.Zdo.ZdoFeatureFlags.UseZdoForEvents)
            {
                try { SoDCoop.Zdo.ZdoEvents.SendCbMove(caseId, evId, keys, pos); }
                catch (System.Exception ex) { Plugin.Log.LogWarning($"BroadcastMove (zdo): {ex.Message}"); }
                return;
            }

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

    public static void OnPacketReceived(PacketType type, NetDataReader reader, int senderId)
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
            else if (type == PacketType.CaseBoardString)
            {
                var p = new CaseBoardStringPacket();
                p.Deserialize(reader);
                ApplyString(p);
            }
            else if (type == PacketType.CaseBoardHide)
            {
                var p = new CaseBoardHidePacket();
                p.Deserialize(reader);
                ApplyHide(p);
            }
            else if (type == PacketType.CaseBoardStatus)
            {
                var p = new CaseBoardStatusPacket();
                p.Deserialize(reader);
                ApplyStatus(p);
            }
            else if (type == PacketType.CaseBoardResolveAnswer)
            {
                var p = new CaseBoardResolveAnswerPacket();
                p.Deserialize(reader);
                ApplyResolveAnswer(p);
            }
            else if (type == PacketType.CaseBoardResolve)
            {
                var p = new CaseBoardResolvePacket();
                p.Deserialize(reader);
                ApplyResolve(p);
            }
            else if (type == PacketType.CaseBoardFactName)
            {
                var p = new CaseBoardFactNamePacket();
                p.Deserialize(reader);
                ApplyFactName(p);
            }
            else if (type == PacketType.CaseBoardStringRemove)
            {
                var p = new CaseBoardStringRemovePacket();
                p.Deserialize(reader);
                ApplyStringRemove(p);
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogError($"CaseBoardSync.OnPacketReceived({type}): {ex.Message}");
        }
    }

    private static void ApplyPin(CaseBoardPinPacket p)
        => ApplyPinFromZdo(p.CaseId, p.EvId, p.DataKeys, p.Position, p.ForceAutoPin);

    /// <summary>ZDO entry — invoked from <c>ZdoEvents.OnCbPin</c>.</summary>
    public static void ApplyPinFromZdo(int caseId, string evId, byte[] dataKeys,
                                        UnityEngine.Vector2 position, bool forceAutoPin)
    {
        var caseObj = FindCase(caseId);
        var evidence = FindEvidence(evId);
        if (caseObj == null || evidence == null)
        {
            Plugin.Log.LogWarning($"[CaseBoard] ApplyPin: case={caseId} ev={evId} not found");
            return;
        }
        if (FindPinElement(caseObj, evId, dataKeys) != null) return;

        var keysList = ToIl2CppList(dataKeys);

        IsApplyingRemote = true;
        try
        {
            var cpc = CasePanelController.Instance;
            if (cpc == null) return;
            cpc.PinToCasePanel(caseObj, evidence, keysList, forceAutoPin, position, false);
            Plugin.Log.LogDebug($"[CaseBoard] applied remote pin case={caseId} ev={evId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyPin: {ex.Message}");
        }
        finally { IsApplyingRemote = false; }
    }

    private static void ApplyUnpin(CaseBoardUnpinPacket p)
        => ApplyUnpinFromZdo(p.CaseId, p.EvId, p.DataKeys);

    /// <summary>ZDO entry — invoked from <c>ZdoEvents.OnCbUnpin</c>.</summary>
    public static void ApplyUnpinFromZdo(int caseId, string evId, byte[] dataKeys)
    {
        var caseObj = FindCase(caseId);
        var evidence = FindEvidence(evId);
        if (caseObj == null || evidence == null) return;

        var keysList = ToIl2CppList(dataKeys);

        IsApplyingRemote = true;
        try
        {
            var cpc = CasePanelController.Instance;
            if (cpc == null) return;
            cpc.UnPinFromCasePanel(caseObj, evidence, keysList, false, null);
            Plugin.Log.LogDebug($"[CaseBoard] applied remote unpin case={caseId} ev={evId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyUnpin: {ex.Message}");
        }
        finally { IsApplyingRemote = false; }
    }

    private static void ApplyMove(CaseBoardMovePacket p)
        => ApplyMoveFromZdo(p.CaseId, p.EvId, p.DataKeys, p.Position, p.SenderId);

    /// <summary>ZDO entry — invoked from <c>ZdoEvents.OnCbMove</c>. Same throttle
    /// + host-priority logic as the legacy ApplyMove.</summary>
    public static void ApplyMoveFromZdo(int caseId, string evId, byte[] dataKeys,
                                         UnityEngine.Vector2 position, int senderId)
    {
        long key = PinKey(caseId, evId, dataKeys);
        if (_lastMoveSender.TryGetValue(key, out var lastSender)
            && lastSender == 0 && senderId != 0)
        {
            float now = Time.unscaledTime;
            if (_lastMoveSendTime.TryGetValue(key, out var lastT) && (now - lastT) < MOVE_THROTTLE)
                return;
        }
        _lastMoveSender[key] = senderId;

        var caseObj = FindCase(caseId);
        if (caseObj == null) return;

        var element = FindPinElement(caseObj, evId, dataKeys);
        if (element == null) return;
        var pic = element.pinnedController;
        if (pic == null) return;

        IsApplyingRemote = true;
        try
        {
            pic.SetPostion(position);
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyMove: {ex.Message}");
        }
        finally { IsApplyingRemote = false; }
    }

    private static void ApplyString(CaseBoardStringPacket p)
        => ApplyStringFromZdo(p.CaseId, p.FromEvId, p.FromKeys, p.ToEvId, p.ToKeys, p.Colour);

    /// <summary>ZDO entry — invoked from <c>ZdoEvents.OnCbString</c>.</summary>
    public static void ApplyStringFromZdo(int caseId, string fromEvId, byte[] fromKeys,
                                           string toEvId, byte[] toKeys, byte colour)
    {
        var caseObj = FindCase(caseId);
        if (caseObj == null) return;

        var link = FindFactLink(fromEvId, fromKeys, toEvId, toKeys);
        if (link == null)
        {
            Plugin.Log.LogWarning($"[CaseBoard] ApplyString: link {fromEvId}→{toEvId} not found");
            return;
        }

        IsApplyingRemote = true;
        try
        {
            caseObj.AddNewStringColour(link, (InterfaceControls.EvidenceColours)colour);
            Plugin.Log.LogDebug($"[CaseBoard] applied remote string case={caseId} colour={colour}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyString: {ex.Message}");
        }
        finally { IsApplyingRemote = false; }
    }

    private static void ApplyHide(CaseBoardHidePacket p)
    {
        var caseObj = FindCase(p.CaseId);
        if (caseObj == null) return;

        var link = FindFactLink(p.FromEvId, p.FromKeys, p.ToEvId, p.ToKeys);
        var fact = link?.fact;
        if (fact == null)
        {
            Plugin.Log.LogWarning($"[CaseBoard] ApplyHide: fact {p.FromEvId}→{p.ToEvId} not found");
            return;
        }

        IsApplyingRemote = true;
        try
        {
            caseObj.SetHidden(fact, p.IsHidden);
            Plugin.Log.LogDebug($"[CaseBoard] applied remote hide case={p.CaseId} hidden={p.IsHidden}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyHide: {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    private static void ApplyStatus(CaseBoardStatusPacket p)
        => ApplyStatusImpl(p.CaseId, p.Status, p.CancelObjectives);

    /// <summary>ZDO entry-point — invoked from <c>CaseResolver.Apply</c>
    /// after a <see cref="ZdoTypeTag.Case"/> delta arrives with a status flip.</summary>
    public static void ApplyStatusFromZdo(int caseId, byte status, bool cancelObjectives)
        => ApplyStatusImpl(caseId, status, cancelObjectives);

    private static void ApplyStatusImpl(int caseId, byte status, bool cancelObjectives)
    {
        var caseObj = FindCase(caseId);
        if (caseObj == null) return;
        if ((byte)caseObj.caseStatus == status) return;   // idempotent

        IsApplyingRemote = true;
        try
        {
            caseObj.SetStatus((Case.CaseStatus)status, cancelObjectives);
            Plugin.Log.LogDebug($"[CaseBoard] applied remote status case={caseId} status={status}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyStatus: {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    private static void ApplyResolveAnswer(CaseBoardResolveAnswerPacket p)
    {
        var caseObj = FindCase(p.CaseId);
        if (caseObj == null) return;
        var questions = caseObj.resolveQuestions;
        if (questions == null) return;
        if (p.QuestionIndex < 0 || p.QuestionIndex >= questions.Count) return;

        var q = questions[p.QuestionIndex];
        if (q == null) return;

        IsApplyingRemote = true;
        try
        {
            q.SetProgress(p.Progress, p.ForceTrigger);
            Plugin.Log.LogDebug($"[CaseBoard] applied remote resolve-answer case={p.CaseId} q={p.QuestionIndex} p={p.Progress:F2}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyResolveAnswer: {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    private static void ApplyResolve(CaseBoardResolvePacket p)
    {
        var caseObj = FindCase(p.CaseId);
        if (caseObj == null) return;
        if (caseObj.isSolved) return;        // idempotent

        IsApplyingRemote = true;
        try
        {
            caseObj.Resolve();
            Plugin.Log.LogDebug($"[CaseBoard] applied remote resolve case={p.CaseId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyResolve: {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    private static void ApplyFactName(CaseBoardFactNamePacket p)
    {
        var link = FindFactLink(p.FromEvId, p.FromKeys, p.ToEvId, p.ToKeys);
        var fact = link?.fact;
        if (fact == null)
        {
            Plugin.Log.LogWarning($"[CaseBoard] ApplyFactName: fact {p.FromEvId}→{p.ToEvId} not found");
            return;
        }

        IsApplyingRemote = true;
        try
        {
            fact.SetCustomName(p.CustomName ?? "");
            Plugin.Log.LogDebug($"[CaseBoard] applied remote fact-name = \"{p.CustomName}\"");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyFactName: {ex.Message}");
        }
        finally
        {
            IsApplyingRemote = false;
        }
    }

    private static void ApplyStringRemove(CaseBoardStringRemovePacket p)
        => ApplyStringRemoveFromZdo(p.CaseId, p.FromEvId, p.FromKeys, p.ToEvId, p.ToKeys);

    /// <summary>ZDO entry — invoked from <c>ZdoEvents.OnCbStringRemove</c>.</summary>
    public static void ApplyStringRemoveFromZdo(int caseId, string fromEvId, byte[] fromKeys,
                                                 string toEvId, byte[] toKeys)
    {
        var sc = FindStringController(caseId, fromEvId, fromKeys, toEvId, toKeys);
        if (sc == null)
        {
            Plugin.Log.LogWarning(
                $"[CaseBoard] ApplyStringRemove: no StringController for case={caseId} {fromEvId}→{toEvId}");
            return;
        }

        IsApplyingRemote = true;
        try
        {
            sc.RemoveCustomLink();
            Plugin.Log.LogDebug($"[CaseBoard] applied remote string-remove case={caseId} {fromEvId}→{toEvId}");
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"ApplyStringRemove: {ex.Message}");
        }
        finally { IsApplyingRemote = false; }
    }

    // ─────────────────────────────────────────────────────────────────────────
    //  Lookup helpers
    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Resolve a Fact (string / hidden) by its 4-tuple identifier.
    /// We start from the source Evidence's <c>factDictionary</c>, because that's
    /// where the FactLink list is keyed by source DataKey, then narrow by
    /// destination evidence + destination keys.
    /// </summary>
    private static Evidence.FactLink FindFactLink(
        string fromEvId, byte[] fromKeys,
        string toEvId,   byte[] toKeys)
    {
        if (string.IsNullOrEmpty(fromEvId) || string.IsNullOrEmpty(toEvId)) return null;
        var fromEv = FindEvidence(fromEvId);
        if (fromEv == null) return null;

        try
        {
            var keysList = ToIl2CppList(fromKeys);
            var links = fromEv.GetFactsForDataKey(keysList);
            if (links == null) return null;

            for (int i = 0; i < links.Count; i++)
            {
                var l = links[i];
                if (l == null) continue;
                // FactLink.destinationEvidence is a list (multi-target). First match wins.
                string destEv = FirstEvId(l.destinationEvidence);
                if (string.IsNullOrEmpty(destEv) || destEv != toEvId) continue;
                if (!DataKeysEqual(l.destinationKeys, toKeys)) continue;
                return l;
            }
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"FindFactLink: {ex.Message}");
        }
        return null;
    }

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
    /// <summary>
    /// Find the local StringController whose endpoints match the given
    /// (caseID, fromEv+keys, toEv+keys) tuple. Walks
    /// <c>CasePanelController.spawnedStrings</c> and matches both endpoints
    /// in either direction (the connection from/to order may differ between
    /// machines if SoD spawned them in different order).
    /// </summary>
    private static StringController FindStringController(
        int caseId,
        string fromEvId, byte[] fromKeys,
        string toEvId,   byte[] toKeys)
    {
        try
        {
            var cpc = CasePanelController.Instance;
            var list = cpc?.spawnedStrings;
            if (list == null) return null;

            for (int i = 0; i < list.Count; i++)
            {
                var sc = list[i];
                var conn = sc?.connection;
                var fromElem = conn?.from?.caseElement;
                var toElem   = conn?.to?.caseElement;
                if (fromElem == null || toElem == null) continue;
                if (fromElem.caseID != caseId) continue;

                if (Matches(fromElem, fromEvId, fromKeys) && Matches(toElem, toEvId, toKeys)) return sc;
                // Direction-swapped match — same logical thread.
                if (Matches(fromElem, toEvId, toKeys) && Matches(toElem, fromEvId, fromKeys)) return sc;
            }
        }
        catch { }
        return null;
    }

    private static bool Matches(Case.CaseElement elem, string evId, byte[] keys)
    {
        if (elem == null || elem.id != evId) return false;
        return DataKeysEqual(elem.dk, keys);
    }

    /// <summary>
    /// Walk activeCases to find the Case that owns the given ResolveQuestion,
    /// returning (Case, questionIndex). Returns (null, -1) if not found.
    /// </summary>
    public static (Case caseObj, int index) FindOwnerOfResolveQuestion(Case.ResolveQuestion question)
    {
        if (question == null) return (null, -1);
        try
        {
            var cpc = CasePanelController.Instance;
            if (cpc?.activeCases == null) return (null, -1);
            for (int i = 0; i < cpc.activeCases.Count; i++)
            {
                var c = cpc.activeCases[i];
                var qs = c?.resolveQuestions;
                if (qs == null) continue;
                for (int j = 0; j < qs.Count; j++)
                {
                    if (qs[j] != null && qs[j].Pointer == question.Pointer) return (c, j);
                }
            }
        }
        catch { }
        return (null, -1);
    }

    /// <summary>
    /// First evID from an Il2Cpp list of Evidence (or null if empty).
    /// Used to collapse multi-target Fact / FactLink references to a single
    /// stable wire identifier.
    /// </summary>
    private static string FirstEvId(Il2CppSystem.Collections.Generic.List<Evidence> list)
    {
        try
        {
            if (list == null || list.Count == 0) return null;
            var first = list[0];
            return first?.evID;
        }
        catch { return null; }
    }

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
