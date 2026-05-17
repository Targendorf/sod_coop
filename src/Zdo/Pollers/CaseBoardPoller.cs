using System;
using System.Collections.Generic;
using UnityEngine;
using Il2CppList = Il2CppSystem.Collections.Generic.List<Evidence.DataKey>;

namespace SoDCoop.Zdo.Pollers;

/// <summary>
/// Host-side case-board state diff: 2 Hz over <c>CasePanelController.Instance.activeCases</c>.
/// Per case, snapshot the <c>caseElements</c> (pinned cards) and
/// <c>stringColours</c> (links between cards) lists. Diff against the
/// previous tick:
/// <list type="bullet">
///   <item>New pinned card → <see cref="Sync.CaseBoardSync.BroadcastPin"/></item>
///   <item>Removed pinned card → <see cref="Sync.CaseBoardSync.BroadcastUnpin"/></item>
///   <item>Position changed by &gt; 0.5 px → <see cref="Sync.CaseBoardSync.BroadcastMove"/></item>
///   <item>New string-link → <see cref="Sync.CaseBoardSync.BroadcastString"/></item>
///   <item>Removed string-link → <see cref="Sync.CaseBoardSync.BroadcastStringRemoveById"/></item>
/// </list>
///
/// <para>Replaces the disabled multi-key pin/unpin patches and the active
/// single-key pin / move / string patches that all die after the first
/// save-load. Polling is patch-independent and survives the cycle.</para>
///
/// <para>Card identity = <c>(caseId, evID, packed-DataKeys-bytes)</c>. The
/// packed key string lets us store and compare List&lt;DataKey&gt; without
/// marshalling Il2Cpp collections every diff.</para>
///
/// <para>Limitation: client-side pin/unpin/move actions are NOT caught by
/// this poller (host-only). Same constraint as the rest of the host-only
/// state pollers — the host's view is authoritative; client-side mid-game
/// case-board edits past the first save-load window won't sync. Late-join
/// snapshot still delivers correct state.</para>
/// </summary>
public static class CaseBoardPoller
{
    public const float TICK_HZ = 2f;
    public const string NAME   = "case-board";

    private const float MOVE_EPSILON_SQR = 0.25f;     // 0.5 px squared

    private struct PinId : IEquatable<PinId>
    {
        public int    CaseId;
        public string EvId;
        public string Keys;     // packed "k0,k1,..." byte string

        public bool Equals(PinId o)
            => o.CaseId == CaseId && o.EvId == EvId && o.Keys == Keys;
        public override bool Equals(object o) => o is PinId p && Equals(p);
        public override int GetHashCode()
        {
            unchecked
            {
                int h = CaseId;
                h = h * 397 ^ (EvId?.GetHashCode() ?? 0);
                h = h * 397 ^ (Keys?.GetHashCode() ?? 0);
                return h;
            }
        }
    }

    private struct StringId : IEquatable<StringId>
    {
        public int    CaseId;
        public string FromEv;
        public string ToEv;
        public string FromKeys;
        public string ToKeys;

        public bool Equals(StringId o)
            => o.CaseId == CaseId && o.FromEv == FromEv && o.ToEv == ToEv
            && o.FromKeys == FromKeys && o.ToKeys == ToKeys;
        public override bool Equals(object o) => o is StringId s && Equals(s);
        public override int GetHashCode()
        {
            unchecked
            {
                int h = CaseId;
                h = h * 397 ^ (FromEv?.GetHashCode() ?? 0);
                h = h * 397 ^ (ToEv?.GetHashCode() ?? 0);
                h = h * 397 ^ (FromKeys?.GetHashCode() ?? 0);
                h = h * 397 ^ (ToKeys?.GetHashCode() ?? 0);
                return h;
            }
        }
    }

    private static readonly Dictionary<PinId, Vector2>     _lastPins    = new();
    private static readonly Dictionary<StringId, byte>     _lastStrings = new();
    // Hold a reference to the currently-known CaseElement so we can pass it to
    // BroadcastMove (which needs the live SoD object, not the tuple-key).
    private static readonly Dictionary<PinId, Case.CaseElement> _liveElements = new();
    private static bool _initialized;

    public static void Register() => ZdoPollerHost.Register(NAME, 1f / TICK_HZ, Tick);

    public static void ResetBaseline()
    {
        _initialized = false;
        _lastPins.Clear();
        _lastStrings.Clear();
        _liveElements.Clear();
    }

    private static void Tick(float now)
    {
        if (!ZdoFeatureFlags.UseZdoForCaseBoard) return;
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
            var allCases = CasePanelController.Instance?.activeCases;
            if (allCases == null) return;

            var seenPins    = new HashSet<PinId>();
            var seenStrings = new HashSet<StringId>();

            for (int ci = 0; ci < allCases.Count; ci++)
            {
                var c = allCases[ci];
                if (c == null) continue;

                // ── caseElements (pinned cards) ──
                var els = c.caseElements;
                if (els != null)
                {
                    for (int i = 0; i < els.Count; i++)
                    {
                        var el = els[i];
                        if (el == null) continue;
                        var id = new PinId
                        {
                            CaseId = c.id,
                            EvId   = el.id ?? "",
                            Keys   = PackKeys(el.dk),
                        };
                        seenPins.Add(id);
                        _liveElements[id] = el;

                        Vector2 pos = el.v;
                        if (!_initialized) continue;     // baseline pass

                        if (!_lastPins.TryGetValue(id, out var prevPos))
                        {
                            // New pin.
                            try { Sync.CaseBoardSync.BroadcastPin(c.id, id.EvId, el.dk, pos, forceAutoPin: false); }
                            catch (Exception ex) { Plugin.Log.LogWarning($"[CaseBoardPoller] pin: {ex.Message}"); }
                        }
                        else if ((pos - prevPos).sqrMagnitude > MOVE_EPSILON_SQR)
                        {
                            try { Sync.CaseBoardSync.BroadcastMove(el, pos); }
                            catch (Exception ex) { Plugin.Log.LogWarning($"[CaseBoardPoller] move: {ex.Message}"); }
                        }
                    }
                }

                // ── stringColours (links) ──
                var ss = c.stringColours;
                if (ss != null)
                {
                    for (int i = 0; i < ss.Count; i++)
                    {
                        var s = ss[i];
                        if (s == null) continue;
                        var id = new StringId
                        {
                            CaseId   = c.id,
                            FromEv   = s.fromEv ?? "",
                            ToEv     = (s.toEv != null && s.toEv.Count > 0) ? s.toEv[0] ?? "" : "",
                            FromKeys = PackKeys(s.fromDK),
                            ToKeys   = PackKeys(s.toDK),
                        };
                        seenStrings.Add(id);
                        if (!_initialized) continue;

                        if (!_lastStrings.ContainsKey(id))
                        {
                            try
                            {
                                // Reconstruct the destination key list as Il2Cpp,
                                // matching the BroadcastString signature.
                                Sync.CaseBoardSync.BroadcastString(
                                    c.id,
                                    id.FromEv, s.fromDK,
                                    id.ToEv,   s.toDK,
                                    (byte)s.colIndex);
                            }
                            catch (Exception ex) { Plugin.Log.LogWarning($"[CaseBoardPoller] string: {ex.Message}"); }
                        }
                    }
                }
            }

            // ── Detect removed pins ──
            if (_initialized)
            {
                foreach (var kv in _lastPins)
                {
                    if (seenPins.Contains(kv.Key)) continue;
                    // Pin removed since last tick.
                    if (!_liveElements.TryGetValue(kv.Key, out var el) || el == null)
                    {
                        // We only have the tuple-key; rebuild a fresh Il2Cpp list from
                        // packed bytes — receivers match by (caseId, evID, keys).
                        var rebuilt = UnpackKeys(kv.Key.Keys);
                        try { Sync.CaseBoardSync.BroadcastUnpin(kv.Key.CaseId, kv.Key.EvId, rebuilt); }
                        catch (Exception ex) { Plugin.Log.LogWarning($"[CaseBoardPoller] unpin (rebuilt): {ex.Message}"); }
                    }
                    else
                    {
                        try { Sync.CaseBoardSync.BroadcastUnpin(kv.Key.CaseId, kv.Key.EvId, el.dk); }
                        catch (Exception ex) { Plugin.Log.LogWarning($"[CaseBoardPoller] unpin: {ex.Message}"); }
                    }
                    _liveElements.Remove(kv.Key);
                }

                // ── Detect removed strings ──
                foreach (var kv in _lastStrings)
                {
                    if (seenStrings.Contains(kv.Key)) continue;
                    // BroadcastStringRemoveById expects byte[] for keys (its
                    // ZDO RPC payload is byte[]). Convert from packed string
                    // directly without going through Il2CppList.
                    var fromKsBytes = UnpackKeysToBytes(kv.Key.FromKeys);
                    var toKsBytes   = UnpackKeysToBytes(kv.Key.ToKeys);
                    try
                    {
                        Sync.CaseBoardSync.BroadcastStringRemoveById(
                            kv.Key.CaseId,
                            kv.Key.FromEv, fromKsBytes,
                            kv.Key.ToEv,   toKsBytes);
                    }
                    catch (Exception ex) { Plugin.Log.LogWarning($"[CaseBoardPoller] string-remove: {ex.Message}"); }
                }
            }

            // ── Refresh baselines ──
            _lastPins.Clear();
            for (int ci = 0; ci < allCases.Count; ci++)
            {
                var c = allCases[ci];
                if (c == null || c.caseElements == null) continue;
                for (int i = 0; i < c.caseElements.Count; i++)
                {
                    var el = c.caseElements[i];
                    if (el == null) continue;
                    var id = new PinId { CaseId = c.id, EvId = el.id ?? "", Keys = PackKeys(el.dk) };
                    _lastPins[id] = el.v;
                }
            }
            _lastStrings.Clear();
            foreach (var kv in seenStrings) _lastStrings[kv] = 1;     // value unused

            _initialized = true;
        }
        catch (Exception ex) { Plugin.Log.LogWarning($"[CaseBoardPoller] tick: {ex.Message}"); }
    }

    private static string PackKeys(Il2CppList keys)
    {
        if (keys == null || keys.Count == 0) return "";
        var sb = new System.Text.StringBuilder(keys.Count * 4);
        for (int i = 0; i < keys.Count; i++)
        {
            if (i > 0) sb.Append(',');
            sb.Append((byte)keys[i]);
        }
        return sb.ToString();
    }

    private static Il2CppList UnpackKeys(string packed)
    {
        var l = new Il2CppList();
        if (string.IsNullOrEmpty(packed)) return l;
        var parts = packed.Split(',');
        for (int i = 0; i < parts.Length; i++)
        {
            if (byte.TryParse(parts[i], out byte b))
                l.Add((Evidence.DataKey)b);
        }
        return l;
    }

    /// <summary>Direct byte[] variant — saves an Il2CppList allocation when
    /// the consumer (ZDO RPC) wants raw bytes.</summary>
    private static byte[] UnpackKeysToBytes(string packed)
    {
        if (string.IsNullOrEmpty(packed)) return System.Array.Empty<byte>();
        var parts = packed.Split(',');
        var bs = new System.Collections.Generic.List<byte>(parts.Length);
        for (int i = 0; i < parts.Length; i++)
        {
            if (byte.TryParse(parts[i], out byte b)) bs.Add(b);
        }
        return bs.ToArray();
    }
}
