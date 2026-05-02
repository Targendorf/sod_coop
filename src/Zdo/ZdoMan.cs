using System;
using System.Collections.Generic;
using System.IO;
using LiteNetLib;
using LiteNetLib.Utils;
using SoDCoop.Network;
using UnityEngine;

namespace SoDCoop.Zdo;

/// <summary>
/// Singleton ZDO registry + change-detection driver. Owns:
///   • Primary index: <c>ZDOID → Zdo</c>.
///   • Secondary index by <see cref="ZdoTypeTag"/>.
///   • Per-tick delta flush (default 10 Hz) — collects every dirty ZDO,
///     serialises into one <see cref="PacketType.ZdoDeltaBatch"/>, sends
///     to all peers, clears dirty flags.
///   • Snapshot build / apply for late joiners.
///   • Persistence to disk under <c>&lt;BepInEx&gt;/config/com.sodcoop.mod/zdo/</c>.
///
/// <para>All mutation happens on the Unity main thread inside the
/// <c>CoopUpdateRunner.Update</c> cascade — no locks.</para>
/// </summary>
public static class ZdoMan
{
    public const byte WIRE_VERSION = 1;
    public const float DEFAULT_FLUSH_HZ = 10f;
    public const int   DEFAULT_COMPRESSION_THRESHOLD = 100;

    /// <summary>Local peer's stable uid (FNV-1a-64 of profile clientGuid).
    /// Set on first call to <see cref="EnsureLocalPeerUid"/>.</summary>
    public static ulong LocalPeerUid { get; private set; }

    /// <summary>Monotonic counter for ZDOIDs minted on this peer.</summary>
    private static uint _nextSequence = 1u;

    private static readonly Dictionary<ZDOID, Zdo> _byId = new();
    private static readonly Dictionary<ZdoTypeTag, HashSet<Zdo>> _byType = new();

    /// <summary>Pending ownership transfers awaiting wire delivery.</summary>
    private static readonly Queue<(ZDOID id, ulong newOwner)> _pendingOwnershipBroadcast = new();

    private static float _nextFlushAt;
    private static uint  _flushTickCounter;
    private static bool  _initialized;

    public static event Action<Zdo> OnZdoCreated;
    public static event Action<Zdo> OnZdoDestroyed;
    public static event Action<Zdo, ulong /*old*/, ulong /*new*/> OnOwnershipChanged;

    // Reusable scratch writers / readers.
    private static readonly NetDataWriter _flushScratch = new();
    private static readonly NetDataWriter _snapshotScratch = new();
    private static readonly NetDataWriter _payloadScratch = new();

    // ── Lifecycle ─────────────────────────────────────────────────────

    public static void Initialize()
    {
        if (_initialized) return;
        EnsureLocalPeerUid();
        _initialized = true;
        _nextFlushAt = 0f;
        Plugin.Log.LogInfo($"[ZdoMan] initialized, localPeerUid={LocalPeerUid:X16}");
    }

    public static void Shutdown()
    {
        Clear();
        _initialized = false;
    }

    public static void EnsureLocalPeerUid()
    {
        if (LocalPeerUid != 0ul) return;
        try
        {
            string guid = Player.CharacterIdentity.ClientGuid;
            LocalPeerUid = Hash32.Of64(guid);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[ZdoMan] could not resolve clientGuid: {ex.Message}; using volatile uid");
            LocalPeerUid = (ulong)Guid.NewGuid().GetHashCode();
        }
    }

    public static void Clear()
    {
        _byId.Clear();
        _byType.Clear();
        _pendingOwnershipBroadcast.Clear();
        _nextSequence = 1u;
        _flushTickCounter = 0u;
    }

    // ── Create / Lookup / Destroy ─────────────────────────────────────

    public static Zdo Create(ZdoTypeTag tag, ulong owner = 0ul, bool persistent = true)
    {
        EnsureLocalPeerUid();
        ZDOID id = new ZDOID(LocalPeerUid, _nextSequence++);
        if (owner == 0ul) owner = LocalPeerUid;
        var z = new Zdo(id, tag, owner, persistent);
        Register(z);
        OnZdoCreated?.Invoke(z);
        return z;
    }

    private static void Register(Zdo z)
    {
        _byId[z.Id] = z;
        if (!_byType.TryGetValue(z.ZdoTypeTag, out var set))
        {
            set = new HashSet<Zdo>();
            _byType[z.ZdoTypeTag] = set;
        }
        set.Add(z);
    }

    public static Zdo Lookup(ZDOID id)
    {
        return _byId.TryGetValue(id, out var z) ? z : null;
    }

    public static IEnumerable<Zdo> AllOfType(ZdoTypeTag tag)
    {
        return _byType.TryGetValue(tag, out var set) ? (IEnumerable<Zdo>)set : Array.Empty<Zdo>();
    }

    public static int Count => _byId.Count;

    public static void Destroy(ZDOID id)
    {
        if (!_byId.TryGetValue(id, out var z)) return;
        _byId.Remove(id);
        if (_byType.TryGetValue(z.ZdoTypeTag, out var set)) set.Remove(z);
        OnZdoDestroyed?.Invoke(z);
    }

    /// <summary>Find a ZDO of <paramref name="tag"/> whose <c>__sodId</c> key
    /// matches <paramref name="sodId"/>. O(N_of_tag); typical N ≤ ~1000.</summary>
    public static Zdo FindBySodId(ZdoTypeTag tag, int sodId)
    {
        if (!_byType.TryGetValue(tag, out var set)) return null;
        foreach (var z in set)
        {
            if (z.GetInt(ZdoKeys.SodId, int.MinValue) == sodId) return z;
        }
        return null;
    }

    /// <summary>Variant for ZDOs keyed by string SoD ids (e.g. <c>Evidence.evID</c>).</summary>
    public static Zdo FindBySodIdStr(ZdoTypeTag tag, string sodIdStr)
    {
        if (!_byType.TryGetValue(tag, out var set) || sodIdStr == null) return null;
        foreach (var z in set)
        {
            var s = z.GetString(ZdoKeys.SodIdStr, null);
            if (s != null && s == sodIdStr) return z;
        }
        return null;
    }

    /// <summary>Get-or-create with sodId stamped automatically.</summary>
    public static Zdo GetOrCreateBySodId(ZdoTypeTag tag, int sodId, ulong owner = 0ul, bool persistent = true)
    {
        var existing = FindBySodId(tag, sodId);
        if (existing != null) return existing;
        var z = Create(tag, owner, persistent);
        z.Set(ZdoKeys.SodId, sodId);
        z.Set(ZdoKeys.Type, (byte)tag);
        return z;
    }

    /// <summary>Variant for ZDOs keyed by string SoD ids.</summary>
    public static Zdo GetOrCreateBySodIdStr(ZdoTypeTag tag, string sodIdStr, ulong owner = 0ul, bool persistent = true)
    {
        var existing = FindBySodIdStr(tag, sodIdStr);
        if (existing != null) return existing;
        var z = Create(tag, owner, persistent);
        z.Set(ZdoKeys.SodIdStr, sodIdStr);
        z.Set(ZdoKeys.Type, (byte)tag);
        return z;
    }

    // ── Ownership ─────────────────────────────────────────────────────

    public static void TransferOwnership(ZDOID id, ulong newOwner)
    {
        var z = Lookup(id);
        if (z == null) return;
        ulong old = z.OwnerPeer;
        if (old == newOwner) return;
        z.SetOwnerInternal(newOwner);
        OnOwnershipChanged?.Invoke(z, old, newOwner);
        _pendingOwnershipBroadcast.Enqueue((id, newOwner));
    }

    /// <summary>True if this peer is allowed to write to <paramref name="z"/>.
    /// Owners may write; the host may always write (host-authoritative model
    /// for AI-driven ZDOs).</summary>
    public static bool CanWrite(Zdo z)
    {
        if (z.OwnerPeer == LocalPeerUid) return true;
        if (NetworkManager.IsHost) return true;
        return false;
    }

    // ── Per-tick delta flush ──────────────────────────────────────────

    /// <summary>Called from <c>CoopUpdateRunner.Update</c>. Throttled to
    /// the configured flush rate; no-op when not connected or world not ready.</summary>
    public static void TickDeltaFlush(float now)
    {
        if (!_initialized) return;
        if (!NetworkManager.HasPeers) return;
        if (now < _nextFlushAt) return;

        float interval = 1f / Mathf.Clamp(DEFAULT_FLUSH_HZ, 1f, 30f);
        _nextFlushAt = now + interval;
        _flushTickCounter++;

        // Drain ownership transfers first so ownership-relevant deltas have
        // up-to-date authority by the time they hit the wire.
        DrainOwnershipTransfers();

        // Collect dirty ZDOs.
        BuildAndSendDeltaBatch();
    }

    private static readonly List<Zdo> _dirtyScratch = new();

    private static void BuildAndSendDeltaBatch()
    {
        _dirtyScratch.Clear();
        foreach (var kv in _byId)
        {
            if (kv.Value.IsDirty) _dirtyScratch.Add(kv.Value);
        }
        if (_dirtyScratch.Count == 0) return;

        // Build payload: tickCounter + count + entries.
        _payloadScratch.Reset();
        _payloadScratch.Put(_flushTickCounter);
        _payloadScratch.Put((ushort)_dirtyScratch.Count);

        for (int i = 0; i < _dirtyScratch.Count; i++)
        {
            var z = _dirtyScratch[i];
            z.Id.Write(_payloadScratch);
            _payloadScratch.Put((byte)z.ZdoTypeTag);
            _payloadScratch.Put(z.DataRevision);
            _payloadScratch.Put((ushort)z.DirtyKeys.Count);
            foreach (var dk in z.DirtyKeys)
            {
                _payloadScratch.Put(dk.Key);
                ZdoWire.WriteValue(_payloadScratch, (ZdoValueType)dk.Value, z, dk.Key);
            }
            z.ClearDirty();
        }

        // Wrap with header + optional zstd, then send.
        WrapAndSend(PacketType.ZdoDeltaBatch, _payloadScratch);
    }

    private static void DrainOwnershipTransfers()
    {
        while (_pendingOwnershipBroadcast.Count > 0)
        {
            var (id, newOwner) = _pendingOwnershipBroadcast.Dequeue();
            _payloadScratch.Reset();
            id.Write(_payloadScratch);
            _payloadScratch.Put(newOwner);
            WrapAndSend(PacketType.ZdoOwnershipTransfer, _payloadScratch);
        }
    }

    /// <summary>Apply incoming delta batch to the local registry.</summary>
    public static void ApplyDeltaBatch(NetDataReader r)
    {
        try
        {
            // Unwrap header (compression, length).
            var unwrapped = UnwrapHeader(r);
            uint  tick    = unwrapped.GetUInt();
            ushort count  = unwrapped.GetUShort();

            for (int i = 0; i < count; i++)
            {
                ZDOID id = ZDOID.Read(unwrapped);
                ZdoTypeTag tag = (ZdoTypeTag)unwrapped.GetByte();
                uint dataRev = unwrapped.GetUInt();
                ushort kcount = unwrapped.GetUShort();

                Zdo z = Lookup(id);
                if (z == null)
                {
                    // First time this peer hears about the ZDO. Auto-create with
                    // unknown owner — owner will be set authoritatively by a
                    // ZdoOwnershipTransfer packet or by the next snapshot.
                    z = new Zdo(id, tag, owner: 0ul, persistent: true);
                    Register(z);
                    OnZdoCreated?.Invoke(z);
                }

                for (int k = 0; k < kcount; k++)
                {
                    int keyHash = unwrapped.GetInt();
                    ZdoWire.ReadValueInto(unwrapped, keyHash, z);
                }

                // Dirty flag is set by the Set() calls above; clear it because
                // these mutations originated remote and shouldn't echo back.
                z.ClearDirty();
                _ = dataRev; // currently advisory; honoured via ClearDirty no-rebroadcast policy.

                // Translate ZDO state into live SoD-side mutations.
                Resolvers.ZdoResolverRegistry.Apply(z);
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ZdoMan] ApplyDeltaBatch failed: {ex.Message}");
        }
    }

    public static void ApplyOwnershipTransfer(NetDataReader r)
    {
        try
        {
            var unwrapped = UnwrapHeader(r);
            ZDOID id = ZDOID.Read(unwrapped);
            ulong newOwner = unwrapped.GetULong();
            var z = Lookup(id);
            if (z == null) return;
            ulong old = z.OwnerPeer;
            z.SetOwnerInternal(newOwner);
            OnOwnershipChanged?.Invoke(z, old, newOwner);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ZdoMan] ApplyOwnershipTransfer failed: {ex.Message}");
        }
    }

    // ── Snapshot ──────────────────────────────────────────────────────

    /// <summary>Build the full registry as a single payload. Includes both
    /// persistent and transient ZDOs (joiner needs the full visible state).</summary>
    public static byte[] SerializeAllForSnapshot()
    {
        _snapshotScratch.Reset();
        SerializeAll(_snapshotScratch, persistentOnly: false);
        return CopyBytes(_snapshotScratch);
    }

    /// <summary>Persistent-only snapshot for disk write.</summary>
    public static byte[] SerializeAllPersistent()
    {
        _snapshotScratch.Reset();
        SerializeAll(_snapshotScratch, persistentOnly: true);
        return CopyBytes(_snapshotScratch);
    }

    private static void SerializeAll(NetDataWriter w, bool persistentOnly)
    {
        w.Put(WIRE_VERSION);
        // Count placeholder — patch in after iteration.
        int countPos = w.Length;
        w.Put((uint)0);
        uint actual = 0;
        foreach (var kv in _byId)
        {
            var z = kv.Value;
            if (persistentOnly && !z.Persistent) continue;
            z.Id.Write(w);
            w.Put((byte)z.ZdoTypeTag);
            w.Put(z.OwnerPeer);
            w.Put(z.Persistent);
            w.Put(z.DataRevision);
            w.Put(z.SchemaVersion);
            // Key count placeholder.
            int keyCountPos = w.Length;
            w.Put((ushort)0);
            ushort kc = 0;
            z.EnumerateAllKeys((kh, vt) =>
            {
                w.Put(kh);
                ZdoWire.WriteValue(w, (ZdoValueType)vt, z, kh);
                kc++;
            });
            // Patch key count.
            byte[] data = w.Data;
            data[keyCountPos    ] = (byte)(kc & 0xff);
            data[keyCountPos + 1] = (byte)((kc >> 8) & 0xff);
            actual++;
        }
        // Patch total count.
        byte[] dat = w.Data;
        dat[countPos    ] = (byte)(actual & 0xff);
        dat[countPos + 1] = (byte)((actual >>  8) & 0xff);
        dat[countPos + 2] = (byte)((actual >> 16) & 0xff);
        dat[countPos + 3] = (byte)((actual >> 24) & 0xff);
    }

    public static void RestoreFromSnapshot(byte[] payload)
    {
        if (payload == null || payload.Length == 0) return;
        try
        {
            var r = new NetDataReader(payload);
            byte ver = r.GetByte();
            if (ver != WIRE_VERSION)
            {
                Plugin.Log.LogWarning($"[ZdoMan] snapshot wire version mismatch: {ver} vs {WIRE_VERSION}");
                return;
            }
            uint count = r.GetUInt();
            for (uint i = 0; i < count; i++)
            {
                ZDOID id = ZDOID.Read(r);
                ZdoTypeTag tag = (ZdoTypeTag)r.GetByte();
                ulong owner = r.GetULong();
                bool persistent = r.GetBool();
                uint dataRev = r.GetUInt();
                byte schemaVer = r.GetByte();
                ushort keyCount = r.GetUShort();

                Zdo z = Lookup(id);
                if (z == null)
                {
                    z = new Zdo(id, tag, owner, persistent) { SchemaVersion = schemaVer };
                    Register(z);
                    OnZdoCreated?.Invoke(z);
                }
                else
                {
                    z.SetOwnerInternal(owner);
                    z.SchemaVersion = schemaVer;
                }

                for (int k = 0; k < keyCount; k++)
                {
                    int keyHash = r.GetInt();
                    ZdoWire.ReadValueInto(r, keyHash, z);
                }
                z.ClearDirty();
                _ = dataRev;

                // Translate ZDO state into live SoD-side mutations.
                Resolvers.ZdoResolverRegistry.Apply(z);
            }
            Plugin.Log.LogInfo($"[ZdoMan] restored {count} ZDOs from snapshot.");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ZdoMan] RestoreFromSnapshot failed: {ex}");
        }
    }

    // ── Wire framing (header + optional zstd) ────────────────────────

    private static readonly NetDataWriter _wrapScratch = new();

    private static void WrapAndSend(PacketType pt, NetDataWriter payload)
    {
        if (!NetworkManager.HasPeers) return;
        _wrapScratch.Reset();

        byte[] data = payload.Data;
        int len = payload.Length;

        bool compress = len >= DEFAULT_COMPRESSION_THRESHOLD;
        byte flags = 0;
        if (compress) flags |= 0x01;
        // bit 1 = batched (always 1 for ZdoDeltaBatch by definition; informational).
        if (pt == PacketType.ZdoDeltaBatch) flags |= 0x02;

        _wrapScratch.Put(flags);
        // Phase G.5 wire-tuning: uncompressed length is `int` (was `ushort`)
        // so snapshots / large delta batches > 64 KB don't truncate. Header
        // grows by 2 bytes (negligible vs the payload). Reader matches via
        // a feature-flag bit if we need to keep wire-compat with old peers
        // — currently no old peers exist on the wire, so straight upgrade.
        _wrapScratch.Put(len);

        if (compress)
        {
            byte[] compressed = ZdoCompression.Compress(data, len);
            _wrapScratch.Put(compressed.Length);
            _wrapScratch.Put(compressed, 0, compressed.Length);
        }
        else
        {
            _wrapScratch.Put(len);
            _wrapScratch.Put(data, 0, len);
        }

        // SendToAll already prefixes the PacketType byte.
        NetworkManager.SendToAll(pt, _wrapScratch, DeliveryMethod.ReliableOrdered);
    }

    /// <summary>Strip the (flags, uncompressedLen, payloadLen, payload) wrapper.
    /// Returns a reader positioned at the start of the inner payload.</summary>
    private static NetDataReader UnwrapHeader(NetDataReader r)
    {
        byte flags = r.GetByte();
        int uncompressedLen = r.GetInt();
        int compressedLen = r.GetInt();

        byte[] body = new byte[compressedLen];
        for (int i = 0; i < compressedLen; i++) body[i] = r.GetByte();

        if ((flags & 0x01) != 0)
        {
            byte[] decompressed = ZdoCompression.Decompress(body, uncompressedLen);
            return new NetDataReader(decompressed);
        }
        return new NetDataReader(body);
    }

    private static byte[] CopyBytes(NetDataWriter w)
    {
        byte[] copy = new byte[w.Length];
        Array.Copy(w.Data, copy, w.Length);
        return copy;
    }

    // ── Persistence ──────────────────────────────────────────────────

    public static string PersistencePath()
    {
        try
        {
            string baseDir = Path.Combine(BepInEx.Paths.ConfigPath, "com.sodcoop.mod", "zdo");
            Directory.CreateDirectory(baseDir);
            string seed = "default";
            try
            {
                if (CityData.Instance != null)
                {
                    seed = CityData.Instance.cityName ?? "default";
                }
            }
            catch { }
            string sanitized = "";
            foreach (var c in seed) sanitized += char.IsLetterOrDigit(c) ? c : '_';
            return Path.Combine(baseDir, $"{sanitized}.sodzdo");
        }
        catch
        {
            return null;
        }
    }

    public static void SaveToDisk()
    {
        try
        {
            string path = PersistencePath();
            if (path == null) return;
            byte[] payload = SerializeAllPersistent();
            byte[] compressed = ZdoCompression.Compress(payload, payload.Length);
            string tmp = path + ".tmp";
            File.WriteAllBytes(tmp, compressed);
            if (File.Exists(path)) File.Delete(path);
            File.Move(tmp, path);
            Plugin.Log.LogInfo($"[ZdoMan] saved {payload.Length} → {compressed.Length} B to {path}");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[ZdoMan] SaveToDisk failed: {ex.Message}");
        }
    }

    public static void LoadFromDisk()
    {
        try
        {
            string path = PersistencePath();
            if (path == null || !File.Exists(path)) return;
            byte[] compressed = File.ReadAllBytes(path);
            byte[] decompressed = ZdoCompression.Decompress(compressed, expectedLen: 0);
            RestoreFromSnapshot(decompressed);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[ZdoMan] LoadFromDisk failed: {ex.Message}");
        }
    }

    // ── Snapshot push (host → joiner) ─────────────────────────────────

    public static void SendSnapshotTo(NetPeer peer)
    {
        if (peer == null) return;
        if (!NetworkManager.IsHost) return;
        try
        {
            byte[] payload = SerializeAllForSnapshot();

            _payloadScratch.Reset();
            byte flags = 0x01; // always compressed for snapshots
            byte[] compressed = ZdoCompression.Compress(payload, payload.Length);
            _payloadScratch.Put(flags);
            _payloadScratch.Put((ushort)0); // uncompressedLen unused for snapshot (we store full int below)
            _payloadScratch.Put(payload.Length);
            _payloadScratch.Put(compressed.Length);
            _payloadScratch.Put(compressed, 0, compressed.Length);

            NetworkManager.SendTo(peer, PacketType.ZdoSnapshot, _payloadScratch, DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[ZdoMan] sent snapshot to {peer.Address}: {payload.Length} → {compressed.Length} B, {Count} ZDOs");
        }
        catch (Exception ex)
        {
            Plugin.Log.LogWarning($"[ZdoMan] SendSnapshotTo: {ex.Message}");
        }
    }

    public static void HandleSnapshot(NetDataReader r)
    {
        try
        {
            byte flags = r.GetByte();
            ushort _ = r.GetUShort(); // unused
            int uncompressedLen = r.GetInt();
            int compressedLen = r.GetInt();
            byte[] body = new byte[compressedLen];
            for (int i = 0; i < compressedLen; i++) body[i] = r.GetByte();

            byte[] payload = (flags & 0x01) != 0
                ? ZdoCompression.Decompress(body, uncompressedLen)
                : body;

            RestoreFromSnapshot(payload);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogError($"[ZdoMan] HandleSnapshot failed: {ex}");
        }
    }
}
