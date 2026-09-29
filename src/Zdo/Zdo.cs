using System.Collections.Generic;
using UnityEngine;

namespace SoDCoop.Zdo;

/// <summary>
/// Property bag entity. Composite-id, owner-tagged, dirty-tracked. The
/// fundamental unit of replication.
///
/// <para>Property values are typed: only <c>int / float / bool / byte /
/// string / Vector3 / Quaternion / byte[] / ZDOID</c> are supported.
/// Storage is one dictionary per type to avoid boxing on the hot Set path.</para>
///
/// <para>Mutation flow: <c>Set&lt;T&gt;(key, val)</c> writes to the typed
/// dict, marks <c>_dirtyKeys</c> + <c>_dirtyTypes</c>, bumps
/// <c>DataRevision</c>, sets <c>IsDirty=true</c>. <c>ClearDirty</c> is
/// called by <see cref="ZdoMan.TickDeltaFlush"/> after the value has been
/// serialised into the next outgoing batch.</para>
/// </summary>
public sealed class Zdo
{
    public ZDOID    Id          { get; }
    public ulong    OwnerPeer   { get; private set; }
    public ZdoTypeTag ZdoTypeTag { get; }
    public bool     Persistent  { get; }
    public Vector3  Position    { get; set; }
    public uint     DataRevision { get; private set; }
    public bool     IsDirty     { get; private set; }

    /// <summary>Schema version per type. Bumped only when the wire format of a
    /// type changes mid-development; default 1.</summary>
    public byte     SchemaVersion { get; set; } = 1;

    // Per-type property storage. Null until first write of that type, to keep
    // a fresh ZDO cheap (most ZDOs use only 2-3 types).
    private Dictionary<int, int>        _ints;
    private Dictionary<int, float>      _floats;
    private Dictionary<int, bool>       _bools;
    private Dictionary<int, byte>       _bytes;
    private Dictionary<int, string>     _strings;
    private Dictionary<int, Vector3>    _vector3s;
    private Dictionary<int, Quaternion> _quats;
    private Dictionary<int, byte[]>     _blobs;
    private Dictionary<int, ulong>      _ulongs;     // for PeerUid-typed values
    private Dictionary<int, ZDOID>      _zdoids;

    /// <summary>(keyHash → valueTypeTag) for keys mutated since last flush.
    /// valueTypeTag matches <see cref="ZdoValueType"/> byte values.</summary>
    private readonly Dictionary<int, byte> _dirtyKeys = new();

    /// <summary>Tombstoned keys (set/cleared via <see cref="Delete"/>).</summary>
    private readonly HashSet<int> _deletedKeys = new();

    public Zdo(ZDOID id, ZdoTypeTag tag, ulong owner, bool persistent)
    {
        Id          = id;
        ZdoTypeTag  = tag;
        OwnerPeer   = owner;
        Persistent  = persistent;
    }

    // ── Get accessors ─────────────────────────────────────────────────

    public int    GetInt   (int key, int def = 0)           => _ints     != null && _ints   .TryGetValue(key, out var v) ? v : def;
    public float  GetFloat (int key, float def = 0f)        => _floats   != null && _floats .TryGetValue(key, out var v) ? v : def;
    public bool   GetBool  (int key, bool def = false)      => _bools    != null && _bools  .TryGetValue(key, out var v) ? v : def;
    public byte   GetByte  (int key, byte def = 0)          => _bytes    != null && _bytes  .TryGetValue(key, out var v) ? v : def;
    public string GetString(int key, string def = null)     => _strings  != null && _strings.TryGetValue(key, out var v) ? v : def;
    public Vector3    GetVector3   (int key, Vector3 def = default)    => _vector3s != null && _vector3s.TryGetValue(key, out var v) ? v : def;
    public Quaternion GetQuaternion(int key, Quaternion def = default) => _quats    != null && _quats   .TryGetValue(key, out var v) ? v : def;
    public byte[] GetBlob  (int key)                        => _blobs    != null && _blobs  .TryGetValue(key, out var v) ? v : null;
    public ulong  GetULong (int key, ulong def = 0ul)       => _ulongs   != null && _ulongs .TryGetValue(key, out var v) ? v : def;
    public ZDOID  GetZdoid (int key)                        => _zdoids   != null && _zdoids .TryGetValue(key, out var v) ? v : ZDOID.Invalid;

    // ── Set accessors ─────────────────────────────────────────────────

    public void Set(int key, int v)        { (_ints     ??= new()).TryGetValue(key, out var p); if (p == v && _ints.ContainsKey(key)) return; _ints   [key] = v; MarkDirty(key, ZdoValueType.Int); }
    public void Set(int key, float v)      { (_floats   ??= new()).TryGetValue(key, out var p); if (p == v && _floats.ContainsKey(key)) return; _floats [key] = v; MarkDirty(key, ZdoValueType.Float); }
    public void Set(int key, bool v)       { (_bools    ??= new()).TryGetValue(key, out var p); if (p == v && _bools.ContainsKey(key)) return; _bools  [key] = v; MarkDirty(key, ZdoValueType.Bool); }
    public void Set(int key, byte v)       { (_bytes    ??= new()).TryGetValue(key, out var p); if (p == v && _bytes.ContainsKey(key)) return; _bytes  [key] = v; MarkDirty(key, ZdoValueType.Byte); }
    public void Set(int key, string v)     { (_strings  ??= new()).TryGetValue(key, out var p); if (p == v && _strings.ContainsKey(key)) return; _strings[key] = v ?? ""; MarkDirty(key, ZdoValueType.String); }
    public void Set(int key, Vector3 v)    { (_vector3s ??= new()).TryGetValue(key, out var p); if (p == v && _vector3s.ContainsKey(key)) return; _vector3s[key] = v; MarkDirty(key, ZdoValueType.Vector3); }
    public void Set(int key, Quaternion v) { (_quats    ??= new()).TryGetValue(key, out var p); if (p == v && _quats.ContainsKey(key)) return; _quats[key] = v; MarkDirty(key, ZdoValueType.Quaternion); }
    public void Set(int key, byte[] v)     { var nv = v ?? System.Array.Empty<byte>(); _blobs ??= new(); if (_blobs.TryGetValue(key, out var pb) && BlobEquals(pb, nv)) return; _blobs[key] = nv; MarkDirty(key, ZdoValueType.Blob); }
    public void Set(int key, ulong v)      { (_ulongs   ??= new()).TryGetValue(key, out var p); if (p == v && _ulongs.ContainsKey(key)) return; _ulongs [key] = v; MarkDirty(key, ZdoValueType.ULong); }
    public void Set(int key, ZDOID v)      { _zdoids ??= new(); if (_zdoids.TryGetValue(key, out var pz) && pz == v) return; _zdoids[key] = v; MarkDirty(key, ZdoValueType.Zdoid); }

    private static bool BlobEquals(byte[] a, byte[] b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a == null || b == null) return false;
        if (a.Length != b.Length) return false;
        for (int i = 0; i < a.Length; i++) if (a[i] != b[i]) return false;
        return true;
    }

    /// <summary>Mark an existing key dirty with its current value, so the next
    /// flush sends it again. For keys on a Sequenced ZDO that rarely change:
    /// Set() skips unchanged values, so without a periodic touch a single lost
    /// packet would leave the peer's copy wrong until the value next changed.
    /// No-op for a key this ZDO doesn't hold.</summary>
    public void Touch(int key)
    {
        if      (_bools    != null && _bools   .ContainsKey(key)) MarkDirty(key, ZdoValueType.Bool);
        else if (_ints     != null && _ints    .ContainsKey(key)) MarkDirty(key, ZdoValueType.Int);
        else if (_bytes    != null && _bytes   .ContainsKey(key)) MarkDirty(key, ZdoValueType.Byte);
        else if (_floats   != null && _floats  .ContainsKey(key)) MarkDirty(key, ZdoValueType.Float);
        else if (_strings  != null && _strings .ContainsKey(key)) MarkDirty(key, ZdoValueType.String);
        else if (_vector3s != null && _vector3s.ContainsKey(key)) MarkDirty(key, ZdoValueType.Vector3);
        else if (_quats    != null && _quats   .ContainsKey(key)) MarkDirty(key, ZdoValueType.Quaternion);
        else if (_ulongs   != null && _ulongs  .ContainsKey(key)) MarkDirty(key, ZdoValueType.ULong);
    }

    public bool HasKey(int key)
    {
        return (_ints     != null && _ints    .ContainsKey(key))
            || (_floats   != null && _floats  .ContainsKey(key))
            || (_bools    != null && _bools   .ContainsKey(key))
            || (_bytes    != null && _bytes   .ContainsKey(key))
            || (_strings  != null && _strings .ContainsKey(key))
            || (_vector3s != null && _vector3s.ContainsKey(key))
            || (_quats    != null && _quats   .ContainsKey(key))
            || (_blobs    != null && _blobs   .ContainsKey(key))
            || (_ulongs   != null && _ulongs  .ContainsKey(key))
            || (_zdoids   != null && _zdoids  .ContainsKey(key));
    }

    /// <summary>Delete a key. Marked tombstone so the next delta batch
    /// communicates the removal.</summary>
    public void Delete(int key)
    {
        bool removed =
              (_ints     != null && _ints    .Remove(key))
            | (_floats   != null && _floats  .Remove(key))
            | (_bools    != null && _bools   .Remove(key))
            | (_bytes    != null && _bytes   .Remove(key))
            | (_strings  != null && _strings .Remove(key))
            | (_vector3s != null && _vector3s.Remove(key))
            | (_quats    != null && _quats   .Remove(key))
            | (_blobs    != null && _blobs   .Remove(key))
            | (_ulongs   != null && _ulongs  .Remove(key))
            | (_zdoids   != null && _zdoids  .Remove(key));
        if (!removed) return;
        _deletedKeys.Add(key);
        _dirtyKeys[key] = (byte)ZdoValueType.Delete;
        DataRevision++;
        IsDirty = true;
    }

    /// <summary>Internal owner mutation (called by <see cref="ZdoMan"/>).</summary>
    internal void SetOwnerInternal(ulong newOwner)
    {
        if (OwnerPeer == newOwner) return;
        OwnerPeer = newOwner;
        DataRevision++;
        // Ownership changes flow via ZdoOwnershipTransfer packets, NOT via the
        // dirty-key delta channel — but we still bump DataRevision so dirty
        // observers can notice.
    }

    private void MarkDirty(int key, ZdoValueType vt)
    {
        _dirtyKeys[key] = (byte)vt;
        _deletedKeys.Remove(key);
        DataRevision++;
        // Was: IsDirty = true; — left set for backwards compat callers.
        // New: also push self into the central dirty-set so ZdoMan's flush
        // doesn't have to scan all ~19 K ZDOs every 100 ms looking for the
        // few that actually changed (Valheim's ZDOMan keeps a `m_changed`
        // collection and feeds straight from it; we now do the same).
        if (!IsDirty)
        {
            IsDirty = true;
            ZdoMan.NotifyZdoDirty(this);
        }
    }

    // ── Host-only spatial index (Nebula-style tile culling) ─────────────
    /// <summary>Last-known world position of the SoD entity backing this
    /// ZDO. Maintained ONLY on the host side by pollers (CitizenStatePoller,
    /// LightPoller, DoorPoller, etc.) via <see cref="ZdoMan.NotifyZdoPosition"/>.
    /// Used by <c>ZdoMan.BuildAndSendDeltaBatch</c> for per-peer sector
    /// culling: a peer that's far from this position doesn't get this
    /// ZDO's deltas. NEVER serialised — the receiving peer derives its
    /// own copy from received <c>ZdoKeys.Pos</c> when needed. ZDOs without
    /// a position (Money, Weather, Case, VmailThread — global state)
    /// keep <see cref="HasHostPosition"/> false and bypass culling.</summary>
    public UnityEngine.Vector3 HostPosition;
    public bool HasHostPosition;

    /// <summary>Snapshot of dirty keys for batch serialisation; safe to read
    /// while iterating because consumers should not mutate during a flush.</summary>
    public IReadOnlyDictionary<int, byte> DirtyKeys => _dirtyKeys;

    public void ClearDirty()
    {
        _dirtyKeys.Clear();
        _deletedKeys.Clear();
        if (IsDirty)
        {
            IsDirty = false;
            ZdoMan.NotifyZdoClean(this);
        }
    }

    // ── Iteration helpers for snapshot serialisation ─────────────────

    /// <summary>Walk every (keyHash, valueTypeTag) pair currently stored on
    /// this ZDO. Used by snapshot serialisation; order is unspecified.</summary>
    public void EnumerateAllKeys(System.Action<int, byte> visitor)
    {
        if (_ints     != null) foreach (var kv in _ints)     visitor(kv.Key, (byte)ZdoValueType.Int);
        if (_floats   != null) foreach (var kv in _floats)   visitor(kv.Key, (byte)ZdoValueType.Float);
        if (_bools    != null) foreach (var kv in _bools)    visitor(kv.Key, (byte)ZdoValueType.Bool);
        if (_bytes    != null) foreach (var kv in _bytes)    visitor(kv.Key, (byte)ZdoValueType.Byte);
        if (_strings  != null) foreach (var kv in _strings)  visitor(kv.Key, (byte)ZdoValueType.String);
        if (_vector3s != null) foreach (var kv in _vector3s) visitor(kv.Key, (byte)ZdoValueType.Vector3);
        if (_quats    != null) foreach (var kv in _quats)    visitor(kv.Key, (byte)ZdoValueType.Quaternion);
        if (_blobs    != null) foreach (var kv in _blobs)    visitor(kv.Key, (byte)ZdoValueType.Blob);
        if (_ulongs   != null) foreach (var kv in _ulongs)   visitor(kv.Key, (byte)ZdoValueType.ULong);
        if (_zdoids   != null) foreach (var kv in _zdoids)   visitor(kv.Key, (byte)ZdoValueType.Zdoid);
    }

    public int KeyCount =>
          (_ints     ?.Count ?? 0)
        + (_floats   ?.Count ?? 0)
        + (_bools    ?.Count ?? 0)
        + (_bytes    ?.Count ?? 0)
        + (_strings  ?.Count ?? 0)
        + (_vector3s ?.Count ?? 0)
        + (_quats    ?.Count ?? 0)
        + (_blobs    ?.Count ?? 0)
        + (_ulongs   ?.Count ?? 0)
        + (_zdoids   ?.Count ?? 0);
}

/// <summary>Wire-tag for a ZDO property value. Synced with the serialiser
/// in <see cref="ZdoWire"/>.</summary>
public enum ZdoValueType : byte
{
    Int        = 0,
    Float      = 1,
    Bool       = 2,
    Byte       = 3,
    String     = 4,
    Vector3    = 5,
    Quaternion = 6,
    Blob       = 7,
    ULong      = 8,
    Zdoid      = 9,
    Delete     = 10,   // tombstone — key removed
}
