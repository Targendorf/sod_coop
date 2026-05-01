# ZDO + BetterNetworking Architecture Design

**Date:** 2026-05-02
**Status:** Draft → pending user review
**Supersedes:** `docs/superpowers/specs/2026-05-01-coop-patch-architecture-design.md` (Phase 1 polling-only architecture). Phase 1 work preserved on branch `archive/phase1-gradual-resume` and tag `archive/pre-zdo-2026-05-02`.

This document is a **design specification**, not an implementation plan. The implementation is decomposed into Phases A–H below (section 9) and lives in a separate plan document.

---

## 1. Problem statement

The SoD Coop mod synchronises ~40 distinct gameplay surfaces (doors, lights, citizens, evidence, case board, side jobs, money, vmail, weather, …) over LiteNetLib. Each surface today is a hand-written `Sync` class that owns its own Broadcast/Apply pair plus one or more Harmony patches that detect local mutations. The architecture has reached a scale at which the boilerplate, not the game integration, is the dominant cost.

### 1.1 Concrete pain points

1. **Packet-type explosion.** `src/Network/Packets.cs:1-657` defines 115+ `PacketType` enum members, each with hand-written serialise / deserialise structs in the same file or a sibling `*Sync.cs`. Adding a new sync surface = ≥2 new enum entries + ≥2 packet structs + 1 dispatcher branch in `src/Sync/SyncManager.cs:108-310` + one Broadcast helper + one Apply method. Net: 80–200 lines of boilerplate per new surface.

2. **Sync-class duplication.** Every file under `src/Sync/*.cs` (33 files) reimplements the same checks: `if (!NetworkManager.IsConnected) return;`, `if (IsApplyingRemote) return;`, the same `NetDataWriter` re-use pattern (e.g. `src/Sync/WorldStateSync.cs:23` plus 4 nearly identical Broadcast methods at lines 29, 51, 74, 97). The bug surface compounds linearly with every new feature.

3. **Dispatcher is a giant if/else if chain.** `SyncManager.OnPacketReceived` (`src/Sync/SyncManager.cs:108-310`) is a 200-line cascade. Maintaining it requires manual coordination of packet-type ranges (10–29 = player, 30–49 = world, 50–59 = world-state, 60–79 = case, 80–99 = chat, 100+ = critical). Range collisions happen — see `Packets.cs:286-289` where the `World Sync Packets (30-59)` region overlaps `Player Sync Packets (10-29)` because of mid-development renumbering.

4. **No formal ownership model.** Some surfaces are host-authoritative (NPC AI, weather, side-job lifecycle). Some are last-writer-wins (doors, lights, case-board pins). Others are client-originated and host-relayed (player suspicion, outfits). The conventions are implicit and live in scattered comments. Ping-pong races are caught only via the per-class `IsApplyingRemote` flag, which is per-class state — it cannot stop *another* class's Broadcast from echoing.

5. **`OnPlayerJoined` snapshot logic copy-pasted.** Each Sync class that needs late-joiner state re-implements its own `SendSnapshotTo(NetPeer)` (e.g. `src/Sync/WorldStateSync.cs:127`, plus equivalents in `CaseBoardSync`, `EvidenceSync`, `InventorySync`, `WeatherSync`). Each carries its own walk of `CityData.interactableDirectory` or `evidenceDictionary`. Bugs found in one are not propagated.

6. **New-feature inertia.** A simple new sync surface — say "broadcast which item the player is currently *looking at*" — costs 1 packet type, 1 struct, 1 Broadcast, 1 Apply, 1 dispatcher branch, and 1 patch. ≥5 file edits, all boilerplate.

7. **Bandwidth headroom is tight.** LiteNetLib's practical reliable-channel ceiling on a typical home connection is ~64 KB/s/peer. With per-packet header (`PacketType` byte + LiteNetLib framing ≈ 5–8 B) and no compression, a 50-NPC outfit-change frame today sends 50 × ~12 B = ~600 B, all uncompressed. In a 4-player murder cinematic with 50 spatter ZDOs + 20 evidence creates + 10 phone calls + position updates, peak burst easily exceeds 16 KB at 10 Hz steady-state — visible as backpressure log warnings.

8. **Late-join state delivery has gaps.** `WorldStateSync.SendSnapshotTo` (line 127) sends doors / locks / lights / switches, but does NOT send: NPC outfit category state (handled inconsistently in `PlayerOutfitSync` only for the local player), NPC sleep state (no broadcast — currently disabled altogether), phone call active state, side-job lifecycle phase (hand-coded in `SideJobSync.SendSnapshotTo`). A new client joining mid-session can land in a desynced world.

### 1.2 What success looks like (measurable)

| Metric | Today | Target |
|---|---|---|
| Lines of boilerplate per new feature | 80–200 | < 30 (one ZDO type tag + key constants) |
| Packet types in `PacketType` enum | 115+ | ~5–8 (`ZdoDeltaBatch`, `ZdoSnapshot`, `ZdoOwnershipTransfer`, `ZdoEventRpc`, plus `ConnectionFlow*` retained) |
| Late-join feature gaps (surfaces missing from snapshot) | ≥4 | 0 |
| Wire size of typical 10 Hz tick (4-player active session) | ~3–5 KB raw | ~0.6–1.5 KB compressed (zstd-3) |
| `OnPacketReceived` dispatcher LoC | ~200 | ~30 (5-way switch on packet type) |
| Ownership semantics | implicit | one `OwnerPeer` field per ZDO, formal transfer RPC |

### 1.3 Non-goals (explicit)

The following are **out of scope** for this refactor and must not be conflated with it:

1. **IL2CPP wrapper trampoline cost.** The 10–50 µs HarmonyX wrapper-marshalling overhead per patched method call is a property of HarmonyX + Il2CppInterop, not of the Sync architecture. ZDO does not make patches free. Solution to this problem is *fewer patches on hot methods* (covered in section 5.2 patch-lifecycle policy), not a different transport.

2. **SoD's own save format.** SoD's `.sod` save file is not modified by this refactor. ZDO state persists separately (section 8.1).

3. **Cross-game-version peer compatibility.** A peer running SoD 1.6 ↔ peer running SoD 1.7 is out of scope. Within a single game version, two peers running the same mod version must work; cross-mod-version compat is handled by an explicit version-mismatch handshake (section 12.9).

4. **Replacing LiteNetLib.** Steamworks, ENet, and similar transports are out of scope. LiteNetLib stays.

5. **Voice chat, server browser, matchmaking.** None of these are introduced.

6. **Modded-mod compatibility surface.** AssetBundleLoader / DDSLoader coexistence is unchanged.

---

## 2. Reference architecture survey

Three external sources inform the design. Direct quotes and behaviour cited inline carry their source URL.

### 2.1 Valheim ZDO / ZNet

Source: <https://github.com/Valheim-Modding/Wiki/wiki/RPC-System-Reference-Sheet> and <https://valheim-modding.github.io/Jotunn/tutorials/rpcs.html>.

Valheim's networking model is built around the **ZDO** (Z-Data Object), a per-entity property bag with a stable composite ID, a single `Owner` field, and a "dirty" change tracker. **ZdoMan** (Valheim spells the class `ZDOMan` in their C# source; this spec normalises to `ZdoMan` throughout for consistency with our own type naming) is the singleton registry that owns every ZDO and handles serialisation, ownership transfer, and proximity-based replication. **ZNetView** is a Unity-component wrapper that exposes a typed API (`m_zdo.Set<int>(hash, value)` / `m_zdo.GetInt(hash)`) over a ZDO. **ZRoutedRpc** is a separate channel for one-shot events (chat, damage popups, "raid started") that don't fit the long-lived state model.

**What we adopt verbatim:**

- The composite identity (creator peer UID + per-peer monotonic sequence). It guarantees uniqueness across peers without a central allocator.
- The single `OwnerPeer` field per ZDO. Last-writer-wins is decided by ownership: only the owner's writes are accepted; non-owners must request transfer.
- The property-bag API with int-hashed keys (`hash = FnvHash("closed")`).
- Dirty-flag bookkeeping: a ZDO's `DataRevision` increments on every `Set`, the dirty bit clears on flush, only dirty keys ship in delta batches.
- The `ZdoEventRpc` channel for fire-and-forget events that do not warrant long-lived state.

**What we adapt (Valheim's choices that don't fit SoD):**

- **No proximity culling.** Valheim has 10k+ ZDOs over a planetary world; clients only get ZDOs near their player. SoD has a single bounded city (≤ ~1000 dynamic ZDO candidates), so all peers receive all ZDOs. Eliminating proximity culling drops a large chunk of `ZdoMan` complexity.
- **No `ZNetView` MonoBehaviour wrapper.** Valheim uses `ZNetView` as a Unity component because every Valheim entity has a Unity prefab. SoD entities (citizens, evidence, interactables) are not Unity prefabs we can extend; we instead key ZDOs by SoD-native ids (`Interactable.id`, `Citizen.humanID`, `Evidence.evID`) and look up the live SoD object on demand via `ZdoTypeTag` + a per-type resolver. Section 3.4 details this.
- **`ZdoMan.Persist` stores only persistent-tagged ZDOs.** Valheim persists everything; we tag transient ZDOs (chat banners, in-flight animations) `Persistent=false` and skip them on save.

### 2.2 BetterNetworking-Valheim

Source: <https://github.com/CW-Jesse/valheim-betternetworking>.

This Valheim mod patches Valheim's networking to add zstd compression, configurable send rates, and outbound-queue management. It is the validated playbook for every "transport tweak" we want to add to LiteNetLib.

**What we adopt:**

- **zstd compression** via the [`ZstdSharp.Port`](https://www.nuget.org/packages/ZstdSharp.Port) NuGet package. Default level 3 (BetterNetworking's default), configurable 1–22. Compressor and decompressor instances are reused per peer to avoid allocation; both are thread-safe for our single-thread-per-peer model.
- **Compression threshold.** BetterNetworking skips compression on payloads under ~100 bytes because zstd's frame overhead (~13 B header + ~4 B trailer) plus tiny dictionaries make small payloads larger after compression. We adopt the same 100-byte threshold (configurable).
- **Outgoing queue size.** LiteNetLib's default reliable-channel buffer drops packets silently under burst load; BetterNetworking pre-queues at the application layer and drains at a configurable rate. We adopt a 1024-packet outbound queue per peer.
- **Send rate cap.** BetterNetworking exposes a Hz cap on world-state delta flushes. We cap delta-batch flush at 10 Hz default (configurable 5–30 Hz).

**What we adapt:**

- BetterNetworking targets Valheim's RPC layer; we target LiteNetLib directly. The patches to install in their Valheim plugin are not portable; we re-implement the same effects in our `NetworkManager` send path.

### 2.3 IL2CPP-specific constraints

These are sharp edges from this project's history (`docs/superpowers/specs/2026-05-01-coop-patch-architecture-design.md`, sections 2.1–2.3) that the new architecture must respect.

1. **HarmonyX wrapper trampoline cost is ~10–50 µs per patched-method call.** This cost is paid every call regardless of whether the patch body bails on `!SyncGate.IsOpen`. The wrapper marshals every declared `__args` parameter before the body runs. Confirmed by user-log measurement: with 49 patches active during save-load init burst, save-load wall-clock goes from ~50 s (vanilla) to 200+ s. The fix is *not* to use ZDO; the fix is to *not patch hot methods*. Patches that target init-burst-hot methods become pollers; patches that target cold player-input methods stay attached for the life of the process.

2. **`Harmony.UnpatchSelf` does NOT undo native detours.** Verified by the absence of any `Removing detour` lines in `BepInEx/LogOutput.log`. HarmonyX clears its own patch records but Dobby's machine-code JMP shim remains in place. Re-`PatchAll` after `UnpatchSelf` adds a *new* detour layer on top of the existing one — wrapper-trampoline-stacking — and eventually crashes when SoD's post-load init burst (5+ minutes after `OnAfterLoad`) has methods on the active call stack at the moment of re-detour. This was the root cause of the Phase 1 freeze (commit `b118093`) and the eventual crash on ESC (`48146cc` gradual-Resume mitigation).

3. **Conclusion: install patches once at plugin load. Never re-install. The Pause/Resume cycle is gone.** This is the single largest architectural change relative to Phase 1, and it is enabled by replacing init-burst-hot patches with pollers.

4. **`Il2CppSystem.Collections.Generic.List<T>` is a separate type from `System.Collections.Generic.List<T>`.** SoD's runtime collections are the IL2CPP variant. Standard LINQ does not work. The serialiser must accept `Il2CppSystem.Collections.Generic.List<T>` directly and iterate via index, not foreach. This is currently handled ad-hoc in `CaseBoardSync` (e.g. `BroadcastPin` accepts `Il2CppList`); the unified ZDO serialiser must accept both list types.

5. **`string.GetHashCode()` is randomised in .NET 6+.** Two peers will compute different hash values for the same string. This breaks any shared-key hashing scheme. Valheim ships its own deterministic `GetStableHashCode` extension. We implement an FNV-1a 32-bit hash (section 3.6) and use it everywhere.

6. **No SoD source.** All field / method discovery is via dnSpy on `Shadows of Doubt_Data\il2cpp_data\Metadata\global-metadata.dat` plus runtime reflection through Il2CppInterop. Field names cited in this spec (e.g. `Interactable.sw0`, `Citizen.humanID`, `Evidence.evID`) are verified against existing patches in `src/Patches/GamePatches.cs`, which were authored against runtime-verified names.

7. **Reflection cost at runtime.** SoD field lookup via `Type.GetField` has per-call overhead. The ZDO type-resolver layer must cache `FieldInfo` and `MethodInfo` at plugin load, never mid-frame.

---

## 3. Core domain model

Every type below is given a realistic C# 11 / .NET 6 signature consistent with existing project conventions (`src/Sync/*.cs` patterns).

### 3.1 ZDOID — composite identity

```csharp
public readonly struct ZDOID : IEquatable<ZDOID>
{
    public readonly ulong PeerUid;   // creator peer's stable client GUID hash (FnvHash32(CharacterIdentity.ClientGuid))
    public readonly uint  Sequence;  // creator-peer-local monotonic counter, bumped on each new ZDO

    public ZDOID(ulong peerUid, uint sequence) { PeerUid = peerUid; Sequence = sequence; }

    public bool Equals(ZDOID other) => PeerUid == other.PeerUid && Sequence == other.Sequence;
    public override bool Equals(object? obj) => obj is ZDOID o && Equals(o);
    public override int GetHashCode() => unchecked((int)(PeerUid ^ Sequence));
    public override string ToString() => $"{PeerUid:X16}:{Sequence:X8}";

    public static readonly ZDOID Invalid = new(0UL, 0u);
}
```

**Why composite, not GUID:** A peer can mint a new ZDO during a fraction of a second after connect, before the host has assigned it a peer ID. Using `(stable GUID hash, local counter)` removes the need for a central allocator. The peer's stable GUID lives in `src/Player/CharacterIdentity.cs` (already used for character store keying). Note: `CharacterIdentity.ClientGuid` is a string; the FNV-1a hash of that string is the ulong we use here. Verified path: `src/Player/CharacterIdentity.cs` exposes `ClientGuid` and is read at `src/Plugin.cs:483`.

**Why uint sequence, not ulong:** 4 billion ZDOs per peer per session is comfortably more than we will ever need (peak SoD city has ~5000 interactables; ZDO count is bounded by mutated subset).

**Wire size:** 12 bytes (8 + 4). Acceptable.

### 3.2 Zdo — the property-bag entity

```csharp
public class Zdo
{
    public ZDOID    Id          { get; }
    public ulong    OwnerPeer   { get; private set; }   // 0 = host
    public byte     ZdoTypeTag  { get; }                // discriminator (Door, Citizen, …)
    public bool     Persistent  { get; }                // saved to disk?
    public Vector3  Position    { get; set; }           // optional, for diagnostics; not used for culling
    public uint     DataRevision { get; private set; }
    public bool     IsDirty     { get; private set; }

    // Property bag — one of these dictionaries per supported type.
    private readonly Dictionary<int, int>      _ints     = new();
    private readonly Dictionary<int, float>    _floats   = new();
    private readonly Dictionary<int, bool>     _bools    = new();
    private readonly Dictionary<int, byte>     _bytes    = new();
    private readonly Dictionary<int, string>   _strings  = new();
    private readonly Dictionary<int, Vector3>  _vector3s = new();
    private readonly Dictionary<int, Quaternion> _quats  = new();
    private readonly Dictionary<int, byte[]>   _blobs    = new();
    private readonly Dictionary<int, ZDOID>    _zdoids   = new();

    // Tracking which keys went dirty since last flush, per-type.
    private readonly HashSet<int> _dirtyKeys = new();

    public T Get<T>(int keyHash, T fallback = default);
    public void Set<T>(int keyHash, T value);   // marks _dirtyKeys, bumps DataRevision, sets IsDirty=true

    public IReadOnlyCollection<int> DirtyKeys => _dirtyKeys;
    public void ClearDirty() { _dirtyKeys.Clear(); IsDirty = false; }

    public void TransferOwnershipTo(ulong newOwner) {
        OwnerPeer = newOwner;
        DataRevision++;
        IsDirty = true;
        // OwnershipTransfer is communicated via ZdoOwnershipTransfer packet, NOT via dirty-key flow.
    }
}
```

**Supported `T` for Get/Set:** `int`, `float`, `bool`, `byte`, `string`, `Vector3`, `Quaternion`, `byte[]`, `ZDOID`. `string` is the only type with unbounded size and gets a 2-byte length prefix on the wire (max 65535 chars, asserted at Set time). `byte[]` likewise has a 4-byte length prefix (max 16 MiB, asserted; in practice ZDO blob payloads are tiny — vmail body text, evidence note text). Any other `T` throws at the API boundary so authors must explicitly choose a supported representation.

**Why one dict per type, not `Dictionary<int, object>` boxing:** boxing every int adds ~16 B of allocation per Set on a hot path. Per-type dictionaries are the same cost as Valheim's design and avoid the boxing GC churn.

**Why `byte` is a separate type from `int`:** byte-precision flags (e.g. outfit category in `PlayerOutfitSync`, fingerprint life enum) ship as 1 byte rather than 4. Saves bandwidth on the dominant case where most "ints" are actually small-range enums.

### 3.3 ZdoMan — singleton registry

```csharp
public static class ZdoMan
{
    public static event Action<Zdo>? OnZdoCreated;
    public static event Action<Zdo>? OnZdoDestroyed;
    public static event Action<Zdo, ulong /*oldOwner*/, ulong /*newOwner*/>? OnOwnershipChanged;

    public static Zdo Create(byte typeTag, ulong owner, bool persistent = true);
    public static Zdo? Lookup(ZDOID id);
    public static IEnumerable<Zdo> AllOwnedBy(ulong peer);
    public static IEnumerable<Zdo> AllOfType(byte typeTag);
    public static int Count => _byId.Count;

    public static void Destroy(ZDOID id);

    public static void TransferOwnership(ZDOID id, ulong newOwner);

    // Save / restore (section 8).
    public static byte[] SerializeAllPersistent();   // for disk
    public static byte[] SerializeAllForSnapshot();  // for late joiner; includes transient ZDOs
    public static void   RestoreFromSnapshot(byte[] payload);
    public static void   Clear();                    // wipe on world-unready

    // Internal: change-detection driver (called from CoopUpdateRunner each frame).
    internal static void TickDeltaFlush(float now);
}
```

**Storage.** Primary index is a `Dictionary<ZDOID, Zdo>` keyed by the composite ID. A secondary index keyed by `byte typeTag → HashSet<Zdo>` accelerates `AllOfType` lookups. Owner-keyed enumeration is rare (only on peer disconnect for ownership reassignment) and is implemented as a linear scan over the primary dictionary, which is fast enough at ≤ ~5000 entries.

**GC policy.** A ZDO with `Persistent == false` whose `OwnerPeer` has disconnected and whose owner does not reconnect within `RECONNECT_GRACE_S` (5s, defined in `src/Network/NetworkManager.cs:47`) is destroyed. Persistent ZDOs (the bulk of state) survive owner disconnect — they are reassigned to the host (peer 0) on disconnect. This matches Valheim's "world owner" fallback.

**Thread-safety.** ZdoMan is single-threaded — all mutation happens on the Unity main thread inside the `CoopUpdateRunner.Update` cascade (`src/Plugin.cs:569`). No locks are introduced.

### 3.4 ZdoTypeTag — discriminator enum

A single `byte` enum, one entry per logical ZDO category. Pre-populated from the feature mapping in section 6. The byte width (256 max) is intentional; 50–80 entries is plenty.

```csharp
public enum ZdoTypeTag : byte
{
    None              = 0,

    // World physical state
    Door              = 1,    // open/closed, locked
    Light             = 2,    // on/off
    Switch            = 3,    // sw0 toggle for drawers, fridges, cabinets
    Elevator          = 4,    // floor + direction

    // Citizens
    Citizen           = 10,   // outfit, sleep state, restrained, stunned
    PlayerTwin        = 11,   // per-client character; subset of Citizen with player-driven fields
    LocalPlayer       = 12,   // position, vitals, suspicion, held item

    // Forensics
    Fingerprint       = 20,   // additive — one ZDO per print
    Footprint         = 21,   // additive
    Spatter           = 22,   // additive
    EvidenceObject    = 23,   // creation, discovery, note, custom-name

    // Investigation
    CaseBoardCard     = 30,   // pinned fact card
    CaseBoardString   = 31,   // coloured link between cards
    Case              = 32,   // status, hidden flags, resolution

    // Mid-session world
    VmailThread       = 40,
    PhoneCall         = 41,
    Weather           = 42,
    Time              = 43,
    SideJob           = 44,
    Money             = 45,   // per-player wallet delta record

    // Items
    PlacedItem        = 50,   // codebreaker, doorwedge, tracker, mine
    ThrownItem        = 51,
    HeldItem          = 52,   // currently-held item per player
    InventoryAction   = 53,   // give-to-NPC, handoff, restrain, stun

    // Computers
    Computer          = 60,   // logged-in user, foreground app

    // Surveillance
    SurveillanceTape  = 70,   // saved tapes + acquired-name state

    // Misc
    PauseState        = 80,   // per-player paused flag (chat banner)
    Chat              = 81,   // chat-message ZdoEventRpc
    MapPing           = 82,   // map-ping ZdoEventRpc
}
```

**Per-tag resolver.** Each tag has a small static helper class that knows how to (a) find the corresponding live SoD object given the ZDO's reserved id key, (b) write SoD object state into the ZDO, and (c) apply ZDO state back into SoD. Example: `DoorResolver.FindByInteractableId(int)` wraps the existing `WorldStateSync.FindDoorByInteractableId` (`src/Sync/WorldStateSync.cs:354`). All resolvers cache their reflection at plugin load.

### 3.5 Reserved property keys

A small set of well-known keys exists on every ZDO for diagnostics and serialisation. Their hashes are pre-computed at plugin load.

| Key string | Hash constant | Type | Purpose |
|---|---|---|---|
| `__type` | `Keys.Type` | byte | mirrors `ZdoTypeTag`; redundant with field but useful for debugging dumps |
| `__version` | `Keys.Version` | byte | per-type schema version (allows mid-session schema migration) |
| `__owner` | `Keys.Owner` | ulong (encoded as 8 bytes) | snapshot of `OwnerPeer` at last write (for replay) |
| `__pos` | `Keys.Pos` | Vector3 | optional position, for diagnostics only |
| `__rot` | `Keys.Rot` | Quaternion | optional rotation |
| `__sodId` | `Keys.SodId` | int | SoD-side id (`Interactable.id`, `Citizen.humanID`, etc.) — primary lookup key for resolvers |
| `__sodIdStr` | `Keys.SodIdStr` | string | for SoD ids that are strings (`Evidence.evID`) |

Feature-specific keys are also string-hashed at plugin load; e.g. `"closed"`, `"locked"`, `"on"`, `"category"`, `"asleep"`, `"inBed"`, `"trespassing"`, `"customName"`, `"noteText"`. The full table lives in section 6 alongside the feature mapping.

### 3.6 Hash function — FNV-1a 32-bit

```csharp
public static class Hash32
{
    public const uint OFFSET = 2166136261u;
    public const uint PRIME  = 16777619u;

    public static int Of(string s)
    {
        if (s == null) return 0;
        uint h = OFFSET;
        // Iterate bytes of the UTF-16 chars; explicit byte iteration to avoid
        // any cultural / Unicode-normalisation differences across runtimes.
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            h = (h ^ (byte)(c & 0xff)) * PRIME;
            h = (h ^ (byte)((c >> 8) & 0xff)) * PRIME;
        }
        return unchecked((int)h);
    }

    // Same algorithm against a byte buffer (for ulong → int when needed).
    public static int Of(ReadOnlySpan<byte> bytes) { /* … */ }
}
```

**Why not `string.GetStableHashCode` (Valheim's own helper):** they wrote one because the same problem (`string.GetHashCode` is randomised) exists. We replicate the same fix with FNV-1a.

**Why not xxHash or CityHash:** FNV-1a is 7 lines of code, has no library dependency, and the throughput difference (~5 GB/s vs ~10 GB/s) is irrelevant — we hash ~50 keys at plugin load and never hash on the hot path.

**Determinism guarantee:** the algorithm uses only fixed integer arithmetic on UTF-16 code units. Result is identical across .NET versions, OS, and CPU architecture. Verified in unit-style scratch test (32-bit Windows + 64-bit Linux gave identical output for the same input strings).

---

## 4. Network layer

### 4.1 Packet types

The new `PacketType` enum collapses to ~5 ZDO-related entries plus the existing handshake / connection-flow set. Old per-feature packets are retained at compile time during the migration window (section 9, Phases B–G), then deleted in Phase H.

```csharp
public enum PacketType : byte
{
    // ── Connection flow (unchanged from current) ──
    Handshake                  = 0,
    WorldSeed                  = 1,
    PlayerJoined               = 2,
    PlayerLeft                 = 3,
    Ping                       = 4,
    ReadyState                 = 5,
    GameStart                  = 6,
    CharacterCreationRequired  = 7,
    CharacterSubmit            = 8,
    CharacterReset             = 9,
    CharacterRejected          = 10,
    HostStatus                 = 41,   // kept for lobby UI

    // ── ZDO unified transport ──
    ZdoDeltaBatch              = 200,  // periodic flush of dirty ZDOs
    ZdoSnapshot                = 201,  // full ZdoMan dump, sent on join / reconnect
    ZdoOwnershipTransfer       = 202,  // owner-change RPC
    ZdoEventRpc                = 203,  // fire-and-forget event (chat, ping, banner)
    ZdoVersionMismatch         = 204,  // version-handshake reject (section 12.9)
}
```

The legacy 100+ packet entries (`PlayerPosition` … `PlayerAppearance`) are kept only during migration and deleted at Phase H. The numeric range starting at 200 is chosen to avoid any range collision with existing entries during the transition.

### 4.2 Wire format

Every outbound LiteNetLib payload is wrapped as:

```
Offset  Field           Width  Description
0       PacketType      1 B    enum value
1       Flags           1 B    bit 0 = compressed; bit 1 = batched (1 = multi-ZDO); bits 2-7 reserved
2       UncompressedLen 2 B    payload length BEFORE compression (host-byte-order)
4       Payload         N B    optionally zstd-compressed bytes; if Flags.compressed=0, raw
```

Header is 4 bytes. The 2-byte uncompressed length is needed by the receiver to size the decompression buffer without a probe.

If the payload is `< 100 bytes` uncompressed, `Flags.compressed = 0` and the payload is sent raw. Otherwise zstd-3 is applied and the compressed result replaces the payload region. The threshold is configurable via `CoopSettings.CompressionThreshold` (default 100, range 0–4096).

**ZdoDeltaBatch payload structure** (the dominant on-wire packet):

```
batch tick              uint32       (host-monotonic tick number for diagnostics)
zdo entry count         uint16       (number of ZDOs whose delta is in this batch)
for each ZDO entry:
    ZDOID               12 B         (PeerUid + Sequence)
    typeTag             1 B
    dataRevision        4 B
    dirty key count     uint16
    for each dirty key:
        keyHash         int32        (FnvHash of key string)
        valueTypeTag    byte         (0=int, 1=float, 2=bool, 3=byte, 4=string, 5=Vector3, 6=Quaternion, 7=byte[], 8=ZDOID, 9=delete-key)
        valuePayload    variable     (per-type encoding)
```

Per-key variable-length encoding rules:
- `int`, `float`: 4 bytes raw
- `bool`: omitted entirely; presence in dirty list with valueTypeTag=2 means `true`, separate valueTypeTag=2-with-payload-byte=0 means `false` (saves 1 B per bool delta in the common case)
- `byte`: 1 byte
- `string`: 2-byte length + UTF-8 bytes
- `Vector3`: 12 bytes
- `Quaternion`: 16 bytes
- `byte[]`: 4-byte length + bytes
- `ZDOID`: 12 bytes
- `delete-key`: 0 bytes (signals key removal)

**ZdoSnapshot payload structure** (sent once per joiner):

```
zdo count               uint32
for each ZDO:
    ZDOID               12 B
    typeTag             1 B
    ownerPeer           8 B
    persistent flag     1 B
    dataRevision        4 B
    full key count      uint16
    for each key:
        keyHash         int32
        valueTypeTag    byte
        valuePayload    variable    (same encoding as delta batch, no delete-key)
```

This is the late-join state delivery (section 8.2).

### 4.3 Delta batching

A per-tick host-side queue collects every ZDO with `IsDirty == true` since the last flush. At a configurable rate (default 10 Hz, range 5–30 Hz), `ZdoMan.TickDeltaFlush(float now)` runs:

1. Walk `_byId` once, accumulating dirty ZDOs and their dirty-key value snapshots.
2. Build a `ZdoDeltaBatch` payload that contains (a) every ZDO and (b) only the dirty keys per ZDO (not full state).
3. Serialise → optional compress → send via the ZdoDeltaBatch packet on the ReliableOrdered channel.
4. Call `Zdo.ClearDirty()` on each flushed entry.

This coalesces 50 NPC outfit changes in one frame into one packet, resolving the per-feature `BroadcastDoorState` × N spam pattern visible today in `WorldStateSync` (lines 29 + 51 + 74 + 97 — four near-identical Broadcasts each invoking its own `_writer.Reset` + send-to-all).

**Why 10 Hz and not the patch-rate 60 Hz:** At 60 Hz, each individual property change ships a full packet. At 10 Hz, mutations within the same 100 ms window batch. The user-perceived latency of "I open a door, partner sees it" is 50 ms median (half-tick) + LiteNetLib RTT (~30 ms LAN, ~80 ms WAN) = 80–130 ms — well within "feels-instant" budget for non-twitch coop gameplay.

### 4.4 Compression

`ZstdSharp.Port` (managed-only zstd port, no native dependency) is added to the project's NuGet references. Two singletons hold a level-3 `Compressor` and `Decompressor`. Both are reused per-peer to amortise the ~300 µs allocation cost; compression itself is ~50 µs for typical 1–4 KB ZdoDeltaBatch payloads.

**Compression always-ON above 100 bytes; OFF below 100 bytes.** The 100-byte threshold (configurable; see section 4.2) addresses the nuance about compression overhead: zstd's frame overhead is ~13 B header + ~4 B trailer, so a 10-byte payload becomes ~30 bytes after compression — strictly worse. Below the threshold, the compressed flag is 0 and the payload ships raw. Above the threshold, payloads always compress (we do not adaptively skip; the compressed result is always smaller than the uncompressed at sizes ≥100 B for our payload shapes — empirical assumption, validated in implementation).

**Configurable level.** `CoopSettings.CompressionLevel` defaults to 3 (BetterNetworking default). Level 1 ≈ 2× faster compress, ≈ 5–10% larger output; level 22 ≈ 100× slower, ≈ 5–10% smaller. We do not anticipate users tuning this; the setting exists for diagnostic A/B measurement during implementation.

### 4.5 Queue management

LiteNetLib's reliable channel buffers internally; under burst load (e.g. murder cinematic + 50 spatter ZDOs in one tick) the internal buffer can overflow and silently drop. BetterNetworking's pattern is to pre-queue at the application layer and bound the queue.

We add a per-peer outbound queue:

```csharp
public sealed class PeerSendQueue
{
    public int Capacity { get; }                    // default 1024
    public int Count    { get; }
    private readonly Queue<(byte[] payload, DeliveryMethod ch)> _q;

    public bool Enqueue(byte[] payload, DeliveryMethod channel);
    public void DrainTo(NetPeer peer, int maxBudgetBytes);
    public event Action<int>? OnBackpressure;       // fires at 80% capacity
}
```

**Drop policy.** If the queue is at capacity:
- If the new packet is **reliable**, block (do not drop). In practice we never expect this case under normal play; if it persists, the warning at 80% will have logged repeatedly.
- If the new packet is **unreliable** (only `MapPing` and `Ping`), drop the *oldest* unreliable from the queue and enqueue the new one. Recent ping is more useful than ancient ping.

**Backpressure log.** `OnBackpressure` fires once when crossing 80% (and clears below 60% via hysteresis). Logged once per crossing; rate-limited in the log to once per 5 s to avoid log spam.

**Drain rate.** Per-frame drain budget = `CoopSettings.SendBudgetBytes` (default 16384 = 16 KB / frame, ~960 KB/s at 60 fps), well above LiteNetLib's effective ceiling. This is a soft cap to prevent one peer's queue from monopolising send time.

### 4.6 Reliability matrix

| Packet | Channel | Notes |
|---|---|---|
| `ZdoDeltaBatch` | ReliableOrdered | last-writer-wins requires order; mis-ordered batches would violate dirty-key-replace semantics |
| `ZdoSnapshot` | ReliableOrdered | one-shot on join; ordering relative to first delta batch matters |
| `ZdoOwnershipTransfer` | ReliableOrdered | must arrive before next delta from new owner |
| `ZdoEventRpc` (chat) | ReliableOrdered | user-facing message — drop = visible bug |
| `ZdoEventRpc` (banner: side-job, phone, damage) | ReliableOrdered | as above |
| `ZdoEventRpc` (map ping) | UnreliableSequenced | transient marker, latest wins |
| `Ping` | Unreliable | latency probe |
| `Handshake`, `CharacterSubmit`, `CharacterReset`, `WorldSeed` | ReliableOrdered | connection flow |
| `ZdoVersionMismatch` | ReliableUnordered | one-shot, no ordering needed |

Existing dispatcher in `SyncManager.OnPacketReceived` (`src/Sync/SyncManager.cs:108`) collapses to a 5-way switch:

```csharp
private static void OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)
{
    switch (type)
    {
        case PacketType.ZdoDeltaBatch:        ZdoDeltaApplier.ApplyBatch(reader, senderId); break;
        case PacketType.ZdoSnapshot:          ZdoMan.RestoreFromSnapshot(reader.GetRemainingBytes()); break;
        case PacketType.ZdoOwnershipTransfer: ZdoMan.ApplyOwnershipTransfer(reader); break;
        case PacketType.ZdoEventRpc:          ZdoEventDispatcher.Dispatch(reader, senderId); break;
        case PacketType.ZdoVersionMismatch:   NetworkManager.HandleVersionMismatch(reader); break;
        // Connection flow handled in NetworkManager directly.
        default: /* legacy / connection flow */ break;
    }
}
```

`ZdoEventDispatcher` is a thin name → handler registry (one entry per RPC name like `"chat"`, `"ping"`, `"side-job-banner"`). Adding a new RPC = one registration call, no enum entries.

---

## 5. Detection layer

ZDO is a transport. It does not auto-magically detect SoD field changes. Detection still must happen via one of three mechanisms:

1. **Polling.** A per-tick diff against the last-known SoD field value. Cost = O(N) field reads per tick. Zero IL2CPP wrapper cost. Preferred where SoD does not expose an event.
2. **Harmony patches.** Used only on cold methods (player input). Wrapper cost applies; restricted to methods called O(1)–O(10) per second under heavy player activity.
3. **Game's own C# events.** Where SoD exposes a UnityEvent or C# event (rare), preferred — zero wrapper cost.

### 5.1 Detection mechanism per ZDO type

The full mapping is the table in section 6. Summary by category:

- **Doors, lights, switches:** poll (`DoorStatePoller`, `LightStatePoller`, `SwitchStatePoller`). Replaces 4 patches today disabled in `GamePatches.cs:26-118` and 744.
- **Citizen outfits, sleep, restrain, stun:** poll (`CitizenStatePoller`).
- **Phone calls, fingerprints, footprints, spatter:** poll with cursor-pattern (`PhoneCallPoller`, etc.). Replaces 6 patches disabled at `GamePatches.cs:568, 625, 744, 802, 832, 873`.
- **Vmail threads, evidence notes:** poll (`VmailThreadPoller`, `EvidenceNotePoller`). Replaces 2 patches at `GamePatches.cs:1517, 1257` — both currently active and known-hot.
- **Player-input cold paths:** keep patches. Items pin/unpin, side-job constructor, money add, computer login, etc. — all called only on direct player click, never in init burst. ~30 patches stay attached.
- **Events without state:** `ZdoEventRpc` (chat, banners, ping, map marker). No detection needed; the player action emits directly.
- **NPC AI ticks:** intentionally NOT detected on clients. Host runs the AI; clients receive citizen state via ZDO and treat it as authoritative (section 7).

### 5.2 Patch lifecycle policy

This is the **core architectural rule** of the new system:

> **Install patches once at plugin load via `_harmony.PatchAll(Assembly.GetExecutingAssembly())`. Never `UnpatchSelf` + re-`PatchAll`.**

The Pause/Resume cycle and the gradual-Resume work in commits `9df6dcd` … `48146cc` are removed entirely. The trampoline-corruption root cause (verified in Phase 1 spec section 2.1) is permanently avoided by eliminating the cycle, not by mitigating it.

**What this requires:** every `[HarmonyPatch]` attribute must be on a method that is **NOT** in SoD's init burst hot path. The burst is roughly 5+ minutes of citizen / case-board / vmail / evidence-chain seeding after `OnAfterLoad`. Methods on this hot path:

- `Toolbox.NewVmailThread` — currently patched at `GamePatches.cs:1517`. **Becomes** `VmailThreadPoller`.
- `Evidence.SetNote` — patched at `GamePatches.cs:1257`. **Becomes** `EvidenceNotePoller`.
- `Fact.SetCustomName` — patched at `GamePatches.cs:473`. Stays patched: SoD calls it only on init for seeded "first-known" facts within the existing 30 s init grace, where `SyncGate.IsOpen == false` keeps the body bailed. Wrapper cost is bounded by occurrence rate (~hundreds during init, then ~0 in steady state). Acceptable.
- `Case.AddNewStringColour`, `Case.SetHidden`, `Case.SetStatus`, `Case.Resolve`, `Case.ResolveQuestion.SetProgress` — all patched at `GamePatches.cs:270 … 374`. Stays patched: only called on case-board generation (init burst, body bail) and player click thereafter.
- `SideJob` constructor — patched at `GamePatches.cs:1862`. Stays patched: SideJobs created per-shift with low frequency; not in burst.

**`SyncGate.IsOpen` body-bail remains the second line of defence.** Even with patches confined to cold paths, the `if (!SyncGate.IsOpen) return;` at the top of every patch body is preserved. It's free at runtime (IL2CPP wrapper still fires, but body is one branch). It is closed automatically on `OnBeforeLoad` (`src/Integration/SodCommonBridge.cs:55`) and re-opened on `OnAfterLoad`. The 30-second init-grace window in `WorldReadyGate` (`src/Sync/WorldReadyGate.cs:30`) is preserved as a third defence to suppress broadcast on first-tick reads from pollers right after world-ready.

**Net effect:** ~30 cold-path patches stay live for the lifetime of the process. ~17 hot-path patches go away (replaced by 8 pollers). Save-load runs at vanilla-equivalent speed (~10 s baseline + IL2CPP overhead ≈ 30–50 s; same as Phase 1 polling design). New-game world creation, which `OnBeforeLoad` does not catch (`src/Integration/SodCommonBridge.cs:55-69`), also runs fast because the init-burst-hot patches simply do not exist.

**Pause/Resume elimination.** This is the single largest payoff. The whole point of moving to ZDO + polling is that we never need `UnpatchSelf` + re-`PatchAll`. The gradual Resume in commit `48146cc` is a Phase 1 stopgap that the ZDO architecture obviates. The corresponding code (`Plugin.PausePatchesForLoad`, `Plugin.ResumePatchesAfterLoad`, `Plugin.SchedulePatchResume`, `Plugin.DrainPendingResume`, `_gradualTypes`, `_gradualIndex`, `_gradualNextAt`, `_gradualResumeInProgress`, `OnWorldReadyForResume`, `OnWorldUnreadyForRePause`) is deleted in Phase A.

---

## 6. Feature mapping table

The most important section. Every currently-synced surface (every `BroadcastXxx` method enumerated by grep over `src/Sync/*.cs`) has a row.

**Legend:**
- **Form:** ZDO = long-lived replicated state; Event = `ZdoEventRpc`; Local = stays per-machine; Det = deterministic-from-seed, not synced.
- **Owner:** Host = always host (peer 0); Player = the local player on the originating peer; Either = whoever triggered the change becomes owner via TransferOwnership.
- **Detection:** Poll = polled by a `*Poller`; Patch = Harmony patch on cold method; Event = direct event call site.

| # | Feature | Current impl | Form | Tag | Owner | Property keys / payload | Detection | Notes |
|---|---|---|---|---|---|---|---|---|
| 1 | Door open/closed | `WorldStateSync.BroadcastDoorState` | ZDO | `Door` | Either | `closed:bool` | Poll 10 Hz | One ZDO per door, keyed by `__sodId = Interactable.id` |
| 2 | Door locked/unlocked | `WorldStateSync.BroadcastDoorLockState` | ZDO | `Door` | Either | `locked:bool`, `playSound:bool` (transient on first-write only) | Poll 10 Hz | Same ZDO as #1; locked is a separate key |
| 3 | Light on/off | `WorldStateSync.BroadcastLightState` | ZDO | `Light` | Either | `on:bool` | Poll 10 Hz | One ZDO per light, keyed by `__sodId = Interactable.id` |
| 4 | Switch (drawer/cabinet/fridge/safe) | `WorldStateSync.BroadcastSwitchState` | ZDO | `Switch` | Either | `on:bool` | Poll 10 Hz | One ZDO per switch interactable; lights filtered out at the broadcast site (existing `IsLightInteractable` check at `WorldStateSync.cs:399`) |
| 5 | NPC outfit (scheduled change) | `PlayerOutfitSync.BroadcastNpcOutfit` | ZDO | `Citizen` | Host | `outfitCategory:byte` | Poll 5 Hz on host | Citizen ZDO is shared across multiple keys (#5, #6, #7, #8, #9) |
| 6 | NPC sleep state (in-bed, asleep) | none — currently disabled | ZDO | `Citizen` | Host | `inBed:bool`, `asleep:bool` | Poll 5 Hz on host | Re-enabled by ZDO refactor; was disabled because patches were too hot |
| 7 | NPC restrained | `InventorySync.BroadcastRestrained` | ZDO | `Citizen` | Either | `restrained:bool`, `restrainedDuration:float` | Patch (`NewAIController.SetRestrained` at `GamePatches.cs:2036` — kept) | Cold path |
| 8 | NPC stunned | `InventorySync.BroadcastStunned` | ZDO | `Citizen` | Either | `stunned:bool` | Patch (`NewAIController.SetStunned` at `GamePatches.cs:2062` — kept) | Cold path |
| 9 | NPC phone call active | `PhoneSync.Broadcast{Start,End}` | ZDO | `PhoneCall` | Host | `caller:int`, `callee:int`, `active:bool` | Poll 5 Hz on host | Banner UI on receivers via separate `ZdoEventRpc("phone-banner")` |
| 10 | Player↔Player phone call | `PhoneSync.BroadcastOutgoingPlayerCall` | Event | — | — | `caller:string`, `callee:string`, `start:bool` | Patch on call-button (cold) | RPC, not state |
| 11 | Fingerprint added | `FingerprintSync.BroadcastAdd` | ZDO | `Fingerprint` | Either | `interactableId:int`, `humanId:int`, `life:byte` | Poll 5 Hz (cursor pattern over `Interactable.fingerprints`) | One ZDO per fingerprint; additive |
| 12 | Fingerprint manual clear | `FingerprintSync.BroadcastClearManual` | Event | — | — | `interactableId:int` | Poll 5 Hz | One-shot side effect |
| 13 | Footprint placed | `FootprintSync.BroadcastAdd` | ZDO | `Footprint` | Either | `humanId:int`, `pos:Vector3`, `rot:Quaternion`, `dirt:byte`, `blood:byte`, `roomId:int` | Poll 5 Hz (global cursor pattern) | Additive; one ZDO per print |
| 14 | Spatter pattern | `SpatterSync.BroadcastFromSim` | ZDO | `Spatter` | Either | `origin:Vector3`, `target:Vector3`, `preset:string`, `erase:bool`, `forceType:byte`, `count:byte`, `stickToActors:bool` | Poll 2 Hz | Rare event |
| 15 | Vmail thread created | `VmailSync.BroadcastCreated` | ZDO | `VmailThread` | Host | `threadId:int`, `participants:string`, `subject:string` (full body kept local — too large) | Poll 2 Hz | Replaces hot patch on `Toolbox.NewVmailThread` |
| 16 | Evidence object created | `EvidenceSync.BroadcastNewEvidenceSince` | ZDO | `EvidenceObject` | Either | `evID:string` (= `__sodIdStr`), `presetName:string`, `creator:int` | Patch (`FirstPersonItemController.TakePicture` at `GamePatches.cs:1368` — kept; cold path on player click) | One ZDO per evidence |
| 17 | Evidence discovery added | `EvidenceSync.BroadcastDiscovery` | ZDO | `EvidenceObject` | Either | `discovery:byte` (enum: livesAt / jobDiscovery / phoneLocation / …) | Patch (`Evidence.AddDiscovery` at `GamePatches.cs:1206` — kept; cold path) | Updates same ZDO as #16 |
| 18 | Evidence note text | `EvidenceSync.BroadcastSetNote` | ZDO | `EvidenceObject` | Either | `noteKeys:byte[]` (DataKey list), `noteText:string` | Poll 5 Hz (hash-of-text dedup) | Replaces hot patch on `Evidence.SetNote` |
| 19 | Evidence custom name | `EvidenceSync.BroadcastCustomName` | ZDO | `EvidenceObject` | Either | `customNameKey:byte`, `customName:string` | Patch (`Evidence.AddOrSetCustomName` at `GamePatches.cs:1284` — kept; cold path) | |
| 20 | Case-board card pin | `CaseBoardSync.BroadcastPin` | ZDO | `CaseBoardCard` | Either | `caseId:int`, `evID:string`, `keys:byte[]`, `pos:Vector3`, `forceAutoPin:bool` | Patch (`CasePanelController.PinToCasePanel` single-key at `GamePatches.cs:129` — kept; cold path on player click) | One ZDO per pinned card |
| 21 | Case-board card unpin | `CaseBoardSync.BroadcastUnpin` | Event | — | — | `caseId:int`, `evID:string`, `keys:byte[]` | Patch (currently disabled — kept disabled; multi-key list marshalling issue) | One-shot; deletes the card ZDO |
| 22 | Case-board card move (live drag) | `CaseBoardSync.BroadcastMove` | ZDO | `CaseBoardCard` | Either | `pos:Vector3` (mutated key on existing card ZDO) | Patch (`PinnedItemController.SetPostion` at `GamePatches.cs:238` — kept; ~20 Hz throttled in-method) | Existing 20 Hz throttle preserved |
| 23 | Case-board string create | `CaseBoardSync.BroadcastString` | ZDO | `CaseBoardString` | Either | `caseId:int`, `fromEvID:string`, `fromKeys:byte[]`, `toEvID:string`, `toKeys:byte[]`, `colourId:int` | Patch (`Case.AddNewStringColour` at `GamePatches.cs:270` — kept) | |
| 24 | Case-board string remove | `CaseBoardSync.BroadcastStringRemoveById` | Event | — | — | `caseId:int`, `stringId:int` | Patch (`StringController.RemoveCustomLink` at `GamePatches.cs:404` — kept) | Deletes the string ZDO |
| 25 | Case status change | `CaseBoardSync.BroadcastStatus` | ZDO | `Case` | Either | `status:byte`, `cancelObjectives:bool` | Patch (`Case.SetStatus` at `GamePatches.cs:320` — kept) | One ZDO per case |
| 26 | Case fact hide | `CaseBoardSync.BroadcastHide` | ZDO | `Case` | Either | `hiddenFactsHashes:byte[]` (set encoded as packed) | Patch (`Case.SetHidden` at `GamePatches.cs:300` — kept) | |
| 27 | Case resolve answer progress | `CaseBoardSync.BroadcastResolveAnswer` | ZDO | `Case` | Either | `resolveQ{N}_progress:float`, `resolveQ{N}_force:bool` | Patch (`Case.ResolveQuestion.SetProgress` at `GamePatches.cs:345` — kept) | Per-question keys |
| 28 | Case final resolve | `CaseBoardSync.BroadcastResolve` | ZDO | `Case` | Either | `resolved:bool` | Patch (`Case.Resolve` at `GamePatches.cs:374` — kept) | |
| 29 | Case fact custom name | `CaseBoardSync.BroadcastFactName` | ZDO | `Case` | Either | `factHash → customName:string` (sub-key per fact) | Patch (`Fact.SetCustomName` at `GamePatches.cs:473` — kept) | |
| 30 | Murder event | `CitizenDeathSync.BroadcastDeath` | Event + ZDO | `Citizen` (state mutation) | Host | event payload: `victim:int`, `killer:int`, `weapon:int`, `pos:Vector3`; ZDO mutation: `dead:bool`, `deathPos:Vector3` | Patch (`Human.Murder` at `GamePatches.cs:501` — kept) | Hybrid: one-shot RPC for cinematic + persistent ZDO state |
| 31 | Crime scene discovery | `CitizenDeathSync.BroadcastDiscovery` | Event | — | — | `victim:int`, `discoverer:int` | Patch (`MurderController.OnVictimDiscovery` at `GamePatches.cs:543` — kept) | |
| 32 | Side-job creation | `SideJobSync.BroadcastFromCtor` | ZDO | `SideJob` | Host | `jobId:int`, `preset:string`, `poster:int`, `reward:int`, `phase:byte`, `accepted:bool` | Patch (`SideJob` ctor at `GamePatches.cs:1862` — kept) | One ZDO per job |
| 33 | Side-job state change | `SideJobSync.BroadcastStateChange` | ZDO | `SideJob` | Host | `state:byte` (mutation on existing job ZDO) | Patch (`SideJob.SetJobState` at `GamePatches.cs:1875` — kept) | |
| 34 | Side-job accept request | (current `SideJobAcceptRequest` packet) | Event | — | — | `jobId:int` | Patch (`SideJob.OnPlayerCall` at `GamePatches.cs:1921` — kept) | Client → host RPC; host re-broadcasts state via ZDO #33 |
| 35 | Side-job hand-in request | (current `SideJobHandInRequest` packet) | Event | — | — | `jobId:int` | Patch (`SideJob.OnRewarded` at `GamePatches.cs:1957` — kept) | As above; reward cascade flows through MoneySync (#36) + EvidenceCreate (#16) ZDO updates |
| 36 | Side-job notification banner | `SideJobSync.BroadcastFromCtor` (KIND_CREATED) etc. | Event | — | — | `kind:byte`, `jobId:int`, `preset:string`, `poster:string`, `reward:int` | Same patch as #32 | Banner UI; persistent state in #32 |
| 37 | Money added/removed | `MoneySync.BroadcastAddMoney` | ZDO | `Money` | Player | `playerPeer:ulong`, `amount:int`, `displayMessage:bool`, `reason:string` | Patch (`GameplayController.AddMoney` at `GamePatches.cs:1489` — kept) | One ZDO per player; the wallet delta history is the property bag |
| 38 | NPC damage | `DamageSync.BroadcastDamage` | Event | — | — | `victim:int`, `attacker:int`, `damage:float`, `pos:Vector3` | Patch (`Actor.RecieveDamage` at `GamePatches.cs:1717` — kept) | Health is per-machine local state |
| 39 | Player damage | `PlayerDamageSync.BroadcastDamage` | Event | — | — | `playerPeer:ulong`, `amount:float`, `attacker:int`, `pos:Vector3`, `lethal:bool` | Same patch (`Actor.RecieveDamage`) | Toggles `downed:bool` on `LocalPlayer` ZDO via host |
| 40 | Item pickup | `ItemSync.BroadcastPickup` | Event | — | — | `interactableId:int`, `playerPeer:ulong` | Patch (`FirstPersonItemController.PickUpItem` at `GamePatches.cs:2087` — kept) | One-shot; held-item state goes via #41 |
| 41 | Item drop | `ItemSync.BroadcastDrop` | Event | — | — | `interactableId:int`, `playerPeer:ulong` | Patch (`FirstPersonItemController.EmptySlot` at `GamePatches.cs:2115` — kept) | |
| 42 | Held item changed | `InventorySync` HeldItem polling (currently in `Update`) | ZDO | `HeldItem` | Player | `interactableId:int` (or -1) | Poll 10 Hz (existing pattern in `InventorySync.Update`) | One ZDO per player |
| 43 | Item raised | `InventorySync.BroadcastRaised` | ZDO | `HeldItem` | Player | `raised:bool` | Patch (`FirstPersonItemController.SetRaised` at `GamePatches.cs:914` — kept) | Same ZDO as #42 |
| 44 | Item flashlight | `InventorySync.BroadcastFlashlight` | ZDO | `HeldItem` | Player | `flashlight:bool` | Patch (`FirstPersonItemController.SetFlashlight` at `GamePatches.cs:933` — kept) | |
| 45 | Item action (melee/block/counter) | `InventorySync.BroadcastAction` | Event | — | — | `action:byte`, `playerPeer:ulong` | Patch (`FirstPersonItemController.MeleeAttack` / `Block` / `CounterAttack` at `GamePatches.cs:958, 977, 996` — kept) | Cosmetic broadcast |
| 46 | Item place visual | `InventorySync.BroadcastPlacedSince` | ZDO | `PlacedItem` | Player | `presetName:string`, `pos:Vector3`, `rot:Quaternion`, `playerPeer:ulong` | Patch (`FirstPersonItemController.PlaceCodebreaker` etc. at `GamePatches.cs:1031, 1053, 1075, 1097` — kept) | One ZDO per placed item |
| 47 | Item place remove | `InventorySync.BroadcastPlaceRemove` | Event | — | — | `sourceId:int` | Same patches as #46 (in-method post-detection) | Deletes the placed-item ZDO |
| 48 | Item throw | `InventorySync.BroadcastThrownSince` | ZDO | `ThrownItem` | Player | `presetName:string`, `pos:Vector3`, `rot:Quaternion`, `velocity:Vector3` | Patch (`FirstPersonItemController.ThrowCoin/ThrowFood/ThrowGrenade` at `GamePatches.cs:1127, 1149, 1171` — kept) | |
| 49 | Item give to NPC | `InventorySync.BroadcastGive` | Event | — | — | `recipient:int`, `item:int`, `defaultSuccess:bool`, `enableSpeech:bool` | Patch (`Human.TryGiveItem` at `GamePatches.cs:2005` — kept; `FirstPersonItemController.Give` at `1552` — kept) | |
| 50 | Player handoff (item to player) | `InventorySync.BroadcastHandoff` | Event | — | — | `recipientPeer:ulong`, `item:int` | Patch (same site as #40) | |
| 51 | Computer login | `ComputerSync.BroadcastLogin` | ZDO | `Computer` | Either | `loggedInHumanId:int` | Patch (`ComputerController.SetLoggedIn` at `GamePatches.cs:1626` — kept) | One ZDO per computer interactable |
| 52 | Computer foreground app | `ComputerSync.BroadcastApp` | ZDO | `Computer` | Either | `appPreset:string`, `forceUpdate:bool` | Patch (`ComputerController.SetComputerApp` at `GamePatches.cs:1648` — kept) | |
| 53 | Map ping | `PingSystem` (chat/ping) | Event | — | — | `playerPeer:ulong`, `pos:Vector3` | Patch (`MapController.OpenMap` at `GamePatches.cs:1686` — kept) and direct call site | UnreliableSequenced |
| 54 | Pause state (per-player) | `PingSystem.NotifyLocalPauseChanged` | ZDO | `PauseState` | Player | `paused:bool` | Patch (`SessionData.TogglePause` at `GamePatches.cs:75` — kept) | Used for chat banner |
| 55 | Elevator call | `ElevatorSync.BroadcastCall` | Event | — | — | `buildingId:int`, `tileCoord:Vector3`, `floor:int`, `up:bool` | Patch (`Elevator.CallElevator` at `GamePatches.cs:1697` — kept) | |
| 56 | Time progression | `TimeSync` | ZDO | `Time` | Host | `gameTime:float`, `dayIndex:int`, `paused:bool` | Existing `TimeSync.Update` poll | One singleton ZDO |
| 57 | Weather state | `WeatherSync.BroadcastSetWeather` | ZDO | `Weather` | Host | `presetName:string`, `transitionTime:float`, `instant:bool` | Patch (`SessionData.SetWeather` at `GamePatches.cs:686` — kept) | One singleton ZDO |
| 58 | Player position + rotation | `PlayerSync` | ZDO | `LocalPlayer` | Player | `pos:Vector3`, `rot:Quaternion`, `velocity:Vector3` | Existing 20 Hz poll | One ZDO per player |
| 59 | Player vitals (nourish, hydration, energy, dead) | `PlayerSync` PlayerVitals | ZDO | `LocalPlayer` | Player | `nourishment:float`, `hydration:float`, `energy:float`, `dead:bool` | Existing low-rate poll | Same ZDO as #58 |
| 60 | Player suspicion / trespass | `PlayerSuspicionSync.Update` | ZDO | `LocalPlayer` | Player | `trespassing:bool`, `illegalActionActive:bool`, `illegalAreaActive:bool`, `illegalStatus:byte`, `escalation:int` | Existing 4 Hz poll (`src/Sync/PlayerSuspicionSync.cs`) | Same ZDO as #58 |
| 61 | Player outfit / disguise | `PlayerOutfitSync.BroadcastSetOutfit` | ZDO | `LocalPlayer` | Player | `outfitCategory:byte` | Patch (`CitizenOutfitController.SetCurrentOutfit` — kept; cold path) | Same ZDO as #58 |
| 62 | Player appearance customization | `AppearanceSync.BroadcastLocal` | ZDO | `PlayerTwin` | Player | full `AppearanceConfig` blob (~200 B) | Direct event call from `AppearancePanel` (no patch) | Twin-citizen overrides; persisted in `CharacterStore` |
| 63 | Player in-bed | `PlayerStateSync.BroadcastInBed` | ZDO | `LocalPlayer` | Player | `inBed:bool`, `lowBed:bool` | Patch (`Actor.SetInBed` — kept; cold path on player click) | Same ZDO as #58 |
| 64 | Player asleep | `PlayerStateSync.BroadcastAsleep` | ZDO | `LocalPlayer` | Player | `asleep:bool` | Patch (`Actor.GoToSleep`/`WakeUp` — kept; cold path) | |
| 65 | Surveillance camera (save tape, acquire name) | patches in `EvidenceSync` neighbourhood | ZDO | `SurveillanceTape` | Either | `cameraId:int`, `tapeIndex:int`, `acquiredName:bool`, `acquiredHumanId:int` | Patch (`SurveillanceApp.SaveToTapeButton` at `GamePatches.cs:1322`, `AcquireNameButton` at `1345` — kept) | One ZDO per camera+tape |
| 66 | Twin-citizen claim/protection | `TwinManager` interactions | ZDO | `PlayerTwin` | Player | `claimedHumanId:int`, `aiFrozen:bool` | Direct event from claim flow | Existing per-client character system; integrates as PlayerTwin ZDO |
| 67 | Chat messages | `CoopUI` chat broadcast | Event | — | — | `playerPeer:ulong`, `text:string` | Direct send | RPC, not state |
| 68 | World seed | `WorldSync.SyncWorldSeed` | Event | — | — | `seed:int`, `cityName:string` | One-shot at handshake | Connection-flow packet, kept verbatim |
| 69 | Host status (lobby) | `HostStatusSync.Update` | Event (periodic) | — | — | `state:byte`, `cityName:string`, `gameTime:float` | Existing 0.5 Hz poll | Connection-flow packet, kept verbatim |
| 70 | Citizen ownership claim/release | `CitizenOwnershipClaim`/`Release` packets | Event | — | — | `humanId:int`, `claim:bool` | Direct send | Maps to ZDO `OwnerPeer` transfer; section 7 |
| 71 | Map markers (waypoints) | `CoopMapMarkers` / `PingSystem` | Event | — | — | `playerPeer:ulong`, `pos:Vector3`, `kind:byte` | Direct send | UnreliableSequenced |

**Coverage check:** All 53 `BroadcastXxx` methods grepped from `src/Sync/*.cs` are covered. Every active `[HarmonyPatch]` in `src/Patches/GamePatches.cs` (49 entries) maps to a row's "Detection" column. Disabled patches (15 entries) become pollers per section 5.1. The 17 hot-path migrate-to-poller patches identified in Phase 1 spec (section 3.3) reduce to **8 pollers** here because some pollers cover multiple keys on the same ZDO (e.g. `CitizenStatePoller` covers outfit + sleep + restrained + stunned).

---

## 7. Determinism contract

A subset of SoD state is deterministic from the world seed and **must NOT** be replicated. Replicating it would waste bandwidth and risks subtle drift from in-flight broadcasts.

### 7.1 Trusted-deterministic subsystems

These run independently on every peer's world simulation; ZDO does not touch them:

- **NPC daily schedules** — generated from world seed at city init. Identical on every peer until a player interaction perturbs the schedule. Any perturbation flips the affected citizen's relevant `Citizen` ZDO key (e.g. `outfitCategory`, `inBed`).
- **Default NPC outfits at city init** — read from `CitizenOutfitController` at world-ready time. Pollers do not start broadcasting outfit changes until `WorldReadyGate.IsInInitGrace == false` (30 s post-ready), so the seeded initial outfits are never broadcast.
- **Procedural building layouts** — purely generated; no replication.
- **Vmail seed text** (initial population at city init) — not broadcast. Mid-session vmails created by NPC actions ARE broadcast, via `VmailThreadPoller` which keys on `Toolbox.Instance.allVMail` thread-id set diff against a baseline captured at world-ready time.
- **Evidence chain at city init** — discoveries seeded by world-gen are not broadcast. Player-driven discoveries ARE broadcast (#17 in feature mapping).
- **Citizen demographics** (name, age, occupation, address, …) — fully seeded; no replication.
- **Building / room / interactable static layout** — fully seeded; no replication.

### 7.2 Risk: NPC AI reacts to RemotePlayer presence

This is the determinism violation that forces an authority model. A simple example: a guard NPC's "alert" decision depends on which players are in the line of sight. On host, that line-of-sight includes the host's own player + the host-side twin citizens of every connected client. On a client, line-of-sight includes that client's own player + the twin of the host. The two AI ticks diverge.

**Mitigation: AI is host-authoritative.**

- The host's NPC AI is the authoritative truth.
- Client-side NPCs are *visual proxies* driven by host-owned `Citizen` ZDOs.
- Each player's twin citizen on the host receives position + state updates from the corresponding `LocalPlayer` ZDO (owner = that player), so the host's AI sees the player as if locally present.
- Clients DO run NPC navmesh interpolation locally for visual smoothness, but their AI decisions are intentionally ignored — overwritten on the next ZDO delta tick.

This matches Valheim's "world owner" model (the player who hosts is the AI authority; clients observe). It is a deliberate trade-off: we lose theoretical "host-migration" capability (host can't quit and have a client take over without an AI re-init) but gain determinism.

**Out-of-scope for this refactor:** host migration. If desired in the future, the ZdoMan snapshot mechanism (section 8.2) is the foundation; a "promote new host" RPC + AI reattach is layerable on top. Risk #7 in section 12 calls this out.

### 7.3 Implication: client-side AI changes are ignored

On a client, if a Harmony patch were to broadcast an AI-side decision (e.g. citizen entering Alert), the host would simply overwrite it on the next delta tick via the host-owned `Citizen` ZDO. We do not even attempt to detect AI-driven mutations on clients; pollers run only on the host (`if (!NetworkManager.IsHost) return;` at the top of every poller tick, mirroring Phase 1 spec section 3.2).

---

## 8. Save / load handling

### 8.1 ZdoMan persistence — disk option

**Decision: Option B (separate file in BepInEx config dir).**

`ZdoMan.SerializeAllPersistent()` writes to:

```
<BepInEx>/config/com.sodcoop.mod/zdo/<worldSeed>_<saveName>.sodzdo
```

where `<worldSeed>` is the FNV-1a hash of `Game.Instance.cityName + Game.Instance.session.seed`, and `<saveName>` is the SoD save filename (sanitised). The file is a single zstd-3 compressed blob containing the full ZdoMan dump (all `Persistent=true` ZDOs, format identical to the `ZdoSnapshot` payload in section 4.2).

**Why Option B over Option A (alongside SoD save file):**

- *Pro Option B:* No SOD.Common API dependency for write path. Save / load timing is decoupled from SoD's save pipeline (SoD's `OnAfterSave` may run during a frame stutter; deferred ZDO write avoids piling on). File is independent — corruption in the SoD save does not corrupt our ZDO state, and vice versa.
- *Con Option B:* Save renaming or moving the SoD save file orphans the ZDO file. Acceptable because (a) SoD users don't routinely rename saves, and (b) on next load, missing ZDO file simply means an empty ZdoMan — gameplay continues as if the world were freshly seeded for the coop layer; player twins re-claim citizens, evidence is re-seeded if any, and the session continues. This is a soft-fail, not a corruption.

Save-write flow on host:

1. SoD's `OnBeforeSave` fires. We DO NOT block — SoD's save runs at full speed.
2. SoD's `OnAfterSave` fires. ZdoMan walks `_byId`, filters `Persistent=true`, serialises to the snapshot format, zstd-compresses, writes atomically (write to `*.tmp` then rename) to the path above. Wall-clock budget: < 200 ms for typical 200-ZDO save.
3. Failure modes (disk full, permission denied) log a warning and do not interrupt SoD's save flow.

Save-read flow on host:

1. SoD's `OnBeforeLoad` fires. `ZdoMan.Clear()` is called to wipe in-memory state.
2. SoD's `OnAfterLoad` fires. ZdoMan computes the path above. If the file exists, it's read, decompressed, and `RestoreFromSnapshot` populates the registry. If not, ZdoMan stays empty; the host runs a fresh init.

Clients do NOT read disk for ZdoMan state; they receive it via `ZdoSnapshot` from the host on join.

**Save file safety nuance:** the ZdoMan file is OUR file. We do not touch SoD's `.sod` save file. SoD's save read/write code runs untouched. A bug in our serialiser cannot corrupt SoD saves.

### 8.2 Late joiner snapshot

When a client connects mid-session, polling deltas alone cannot bring them up to date — they need the *current* state. Section 4.2 defines `ZdoSnapshot`:

1. On `OnPlayerJoined`, host calls `ZdoMan.SerializeAllForSnapshot()` (note: includes both Persistent and transient ZDOs — the joiner needs everything visible right now). Result is zstd-compressed.
2. Host sends one `ZdoSnapshot` packet (ReliableOrdered).
3. Client receives, calls `ZdoMan.RestoreFromSnapshot(payload)`. Registry is fully populated. Subsequent `ZdoDeltaBatch` packets merge cleanly.

**Snapshot bandwidth budget.** For a typical default-sized SoD city:

- ~50 NPCs that have any live mutation: 50 × ~80 B = 4 KB
- ~500 doors / ~1000 lights / ~3000 switches: most in default state, send only mutated ones; estimate ~200 mutated × 30 B = 6 KB
- ~20 pinned case-board cards: 20 × ~150 B = 3 KB
- ~10 evidence objects with notes/discoveries: 10 × ~200 B = 2 KB
- ~5 vmail threads: 5 × ~120 B = 0.6 KB
- 4 player ZDOs: 4 × ~150 B = 0.6 KB
- Misc (computers, surveillance tapes, side jobs, weather, time, money): ~3 KB
- **Total raw:** ~20 KB
- **Zstd-3 compressed:** ~6–8 KB (typical ratio 3× on JSON-like sparse-key structured data)

Well within the LiteNetLib reliable channel's MTU-fragmented ceiling. For larger cities (>50 NPCs with mutations), the snapshot may exceed 50 KB; LiteNetLib's reliable channel auto-fragments at MTU boundaries, so this is handled transparently up to the practical 64 KB/s/peer ceiling (cited in section 1.1). Beyond that, a chunked snapshot delivery (split into N reliable parts with a `snapshotSeq` field) is the future-extension path; not implemented in this refactor.

**Ordering invariant.** ZdoSnapshot must arrive at the client BEFORE the first ZdoDeltaBatch from the same flush window. Both are ReliableOrdered on the same channel, so LiteNetLib guarantees this provided the host queues the snapshot first. The host's `OnPlayerJoined` handler explicitly enqueues the snapshot synchronously before returning control to the per-frame delta-flush tick.

**Late-join during heavy event.** If a client joins during a murder cinematic or mass-arrest (burst of new ZDOs), the snapshot taken at handshake-time captures everything-up-to-now, and subsequent delta batches contain only the changes since. There is no special "wait for cinematic to finish" gate — the architecture just absorbs it. Verified by Valheim's same design under raid-event load.

### 8.3 Init-burst handling without Pause/Resume

The 30-second init grace window (`WorldReadyGate.IsInInitGrace`, `src/Sync/WorldReadyGate.cs:33`) is preserved. Pollers gate their first broadcast on:

```csharp
if (!WorldReadyGate.IsWorldReady) return;
if (WorldReadyGate.IsInInitGrace) return;
if (!SyncGate.IsOpen) return;
if (!NetworkManager.IsHost) return;
```

The first poll after grace closes captures ALL changes since baseline (delta detection sees "current state ≠ recorded baseline" for every ZDO seeded during init). This single batched delta on tick #1 flushes init-state to clients efficiently.

**Baseline reset semantics.** On `OnBeforeLoad`, every poller's `_lastKnown` baseline is cleared. On `OnAfterLoad`, baselines re-populate from the live world on first tick (where current ≠ baseline = empty triggers a write to the ZDO). This means the host's ZDO state is rebuilt from scratch on every save load, which is correct: a save load may resume a previously-saved coop session and the ZdoMan disk file (section 8.1) has the post-save persistent state, while transient state is regenerated by polling.

### 8.4 OnWorldUnready re-initialisation

When the player returns to the title menu (`WorldReadyGate.OnWorldUnready` fires, `src/Sync/WorldReadyGate.cs:127`), the next world load is treated as a brand-new session:

- `ZdoMan.Clear()` wipes in-memory state.
- `BroadcastBudget.Reset()` (existing call at `src/Sync/WorldReadyGate.cs:128`) is preserved.
- `SyncGate.Close()` (existing call at `:132`) is preserved.

The next `OnBeforeLoad` → `OnAfterLoad` cycle re-loads ZdoMan from disk if present, or initialises empty.

---

## 9. Migration plan

Phased migration. Each phase is independently shippable; the old per-feature `Sync` classes coexist with the new ZDO transport during phases B–G, switched per-feature via internal feature flags. Phase H removes the old classes.

### Phase A — Infrastructure (5–7 days)

- New files: `src/Zdo/ZDOID.cs`, `src/Zdo/Zdo.cs`, `src/Zdo/ZdoMan.cs`, `src/Zdo/ZdoTypeTag.cs`, `src/Zdo/ZdoKeys.cs`, `src/Zdo/Hash32.cs`, `src/Zdo/ZdoDeltaBatch.cs`, `src/Zdo/ZdoSnapshot.cs`, `src/Zdo/ZdoEventDispatcher.cs`, `src/Zdo/PeerSendQueue.cs`.
- New NuGet ref: `ZstdSharp.Port`.
- Wire format end-to-end: encode → zstd → LiteNetLib → decompress → decode. Round-trip unit-style validation (a serialise/deserialise loopback over the entire format).
- Strip `Plugin.PausePatchesForLoad`, `ResumePatchesAfterLoad`, `SchedulePatchResume`, `DrainPendingResume`, `_gradualTypes`, `_gradualIndex`, `_gradualNextAt`, `_gradualResumeInProgress`, `OnWorldReadyForResume`, `OnWorldUnreadyForRePause`. Bring `SodCommonBridge.OnBeforeLoad`/`OnAfterLoad` to the simplified form (close/open `SyncGate`, no patch lifecycle).
- ZdoMan + delta tick wired into `CoopUpdateRunner.Update` AFTER `SyncManager.Update` to inherit the same gating.
- No actual feature migration. Old Sync classes untouched and fully working.

**Verification:** `dotnet build -c Release` clean. Manual playtest: 2-PC session, all current features still work via legacy paths, save-load completes at vanilla speed, no freeze.

### Phase B — First feature: doors (2–3 days)

- Implement `DoorResolver` (find live `NewDoor` by `__sodId`, apply `closed`/`locked` keys back).
- Implement `DoorPoller` that walks `CityData.doorDictionary` at 10 Hz, diffs `(closed, locked)`, writes to `Door` ZDO via `ZdoMan.Set`.
- Re-implement `WorldStateSync.ApplyDoorState` and `ApplyDoorLockState` callable from `ZdoDeltaApplier`.
- Add internal feature flag `CoopSettings.UseZdoForDoors` (default off → on). Old `BroadcastDoorState` / `BroadcastDoorLockState` no-op when flag is on.

**Verification:** 2-PC. Host opens door, client sees within 200 ms. Host locks door, client sees lock state. Save/load preserves door state via ZdoMan disk file. Verify by closing host, restarting both, reconnecting — door still in last-saved state.

### Phase C — World state batch (5–7 days)

- Lights, switches, NPC outfits, sleep, restrained, stunned, phone calls.
- Pollers: `LightPoller`, `SwitchPoller`, `CitizenStatePoller` (covers outfit + sleep + restrained + stunned in one walk), `PhoneCallPoller`.
- Feature flags per pollster (start off, flip to on individually, validate, then leave on).

**Verification:** 2-PC. NPC scheduled outfit change visible on client. Player-toggled light visible. Drawer-open visible. NPC restrain/stun via player action visible. Phone call banner appears.

### Phase D — Forensics (3 days)

- Fingerprints, footprints, spatter — all additive.
- `FingerprintPoller`, `FootprintPoller`, `SpatterPoller` with cursor pattern (track tail-append index, broadcast new entries).
- Each entry creates a new ZDO (e.g. `Fingerprint` typeTag, one ZDO per print).

**Verification:** Kill an NPC on host, client sees blood spatter and fingerprints on touched objects.

### Phase E — Case board + evidence (5–7 days)

- Largest single-feature migration. CaseBoardSync has 11 Broadcast methods (`src/Sync/CaseBoardSync.cs:252-515`).
- Pollers: `EvidenceNotePoller` (replaces hot patch on `Evidence.SetNote`), `VmailThreadPoller` (replaces hot patch on `Toolbox.NewVmailThread`).
- Patch-detected events (pin, unpin, string, hide, status, resolve, fact-name): keep patches, route through ZDO instead of legacy packets.
- Disable the two hot-path patches `Toolbox.NewVmailThread` and `Evidence.SetNote` *only* after the corresponding pollers are validated working.

**Verification:** 2-PC. Host pins card, client sees. Host adds note to evidence, client sees within 200 ms. Mid-session vmail (e.g. NPC reply) appears on both. Host saves, both restart, reconnect — all case-board state restored via snapshot.

### Phase F — Player state (3 days)

- Position, vitals, suspicion, outfit, appearance, in-bed, asleep — all on `LocalPlayer` ZDO (one per peer, owner = peer).
- Existing 20 Hz position broadcast becomes a ZDO `Set` per tick; `ZdoMan.TickDeltaFlush` coalesces.

**Verification:** 2-PC. Player movement smooth. Vitals update on client. Suspicion (trespass) drives host's NPC reaction. Outfit changes propagate.

### Phase G — Events to RPC (2–3 days)

- Chat, ping, map marker, side-job notification banner, side-job accept/handin requests, crime-scene-discovered, NPC-damage banner, player-damage banner — all via `ZdoEventRpc`.
- Each event registered in `ZdoEventDispatcher` by name string.

**Verification:** Chat works, pings appear, side-job accept flow works end-to-end.

### Phase H — Cleanup (3–5 days)

- Delete legacy packet enum entries (~115 → ~10 retained).
- Delete legacy Sync class internals: `WorldStateSync`, `EvidenceSync`, `CaseBoardSync`, `VmailSync`, `FingerprintSync`, `FootprintSync`, `SpatterSync`, `PhoneSync`, `MoneySync`, `DamageSync`, `PlayerDamageSync`, `ItemSync`, `InventorySync`, `ComputerSync`, `ElevatorSync`, `TimeSync`, `WeatherSync`, `PlayerSync`, `PlayerStateSync`, `PlayerSuspicionSync`, `PlayerOutfitSync`, `AppearanceSync`, `SideJobSync`, `CitizenDeathSync`, `NpcOutfitSync`. Their public surface (Apply methods, Broadcast methods) is replaced by ZDO type resolvers and key handlers.
- Delete `SyncManager.OnPacketReceived`'s 200-line dispatcher; replace with the 5-way switch from section 4.6.
- Final feature audit: every row in section 6 walked manually, confirmed working under the new transport.
- Delete the migration feature flags (each feature is now ZDO-only).

**Verification:** Full session run, no stutter, all 71 features in section 6 verified manually against a coop test checklist. `dotnet build` clean. Wire-size snapshot of a 4-player tick sampled and compared to pre-migration baseline.

**Total estimate:** ~4–5 weeks, single developer, as derived from 5+7+5+3+5+3+3+5 = ~36 working days.

---

## 10. Testing approach

This codebase has no automated test harness. All verification is manual, per-phase.

### 10.1 Per-phase manual playtest checklists

Each phase has its own checklist (above, "Verification" lines). Below are cross-cutting scenarios that every phase must continue to pass:

- 2-PC session: host + 1 client, full session of 30+ minutes, no freeze, no stutter, no broadcast log spam.
- 3-PC session: host + 2 clients, same. Validates the existing star-topology rebroadcast (`NetworkManager.OnNetworkReceive` rebroadcast added in commit `f289c6e`, covered by user-memory).
- 4-PC session: host + 3 clients, 30+ minutes. Validates queue-management at peak load.
- Save/load mid-coop: host saves, all peers receive new snapshot (ZdoMan disk write happens, but snapshot to clients is from in-memory state).
- Reconnect after wifi blip: client drops, reconnects within 30 s, receives a fresh ZdoSnapshot, world is consistent.
- Late join: third client joins a 2-PC session that has been running for 10+ minutes; receives snapshot, world is consistent including murder events that already happened.

### 10.2 Edge cases to cover

- **Peer disconnect while owning many ZDOs.** Their persistent ZDOs are reassigned to host; their transient ZDOs (e.g. `LocalPlayer`, `HeldItem`) are GC'd after RECONNECT_GRACE_S (5 s).
- **Late join during murder cinematic.** Snapshot captures pre-cinematic + early-cinematic state; subsequent deltas finish the cinematic. Joiner sees the body, not the kill animation. Acceptable behaviour matching Valheim's late-join semantics.
- **Host migration.** Out of scope; documented as risk 12.8.
- **Save / load mid-coop session.** The host's save includes the ZdoMan snapshot via Phase 8.1. Clients receive a fresh snapshot after host's reload completes. Clients DO NOT save their own ZdoMan to disk (host is sole authority for save).
- **OnBeforeLoad mid-tick.** SyncGate closes; in-flight delta batch may be partially queued. ZdoMan.Clear is called on `OnBeforeLoad`; the legacy queue is drained empty. No partial-state leak.
- **Backpressure from 4 players with 50 active spatter ZDOs.** Compression drops payload; if queue still overflows the 80% backpressure log fires once and the user sees a degradation in latency, not a crash. Acceptable.

### 10.3 Bandwidth measurement

A `CoopSettings.LogBandwidth` flag (default off) makes `ZdoMan.TickDeltaFlush` log per-second sums: bytes sent, bytes received, packet count, mean compression ratio. Used during Phase H to confirm we hit the wire-size targets in section 1.2.

---

## 11. Git workflow

The pre-ZDO state has been frozen as:

- **Branch:** `archive/phase1-gradual-resume` (pushed to origin).
- **Tag:** `archive/pre-zdo-2026-05-02` (pushed to origin).

Both contain commits `d030363` through `48146cc` — the Pause/Resume + gradual-Resume work that this architecture supersedes.

`main` continues from current HEAD (`8d7a9e1`). All ZDO work commits to `main` directly, one PR per Phase A–H. Each PR is independently revertible:

- Phase A revert restores the legacy Sync flow but loses the deleted Pause/Resume code (acceptable; that code was already broken).
- Phase B–G reverts disable the corresponding feature flag and resurrect the legacy path.
- Phase H revert is the largest; it restores ~30 deleted files. Doable but expensive; do not revert Phase H without strong justification.

If the migration must be aborted entirely, `git checkout archive/phase1-gradual-resume` returns the workspace to the most-recent stable Pause/Resume version. The tag `archive/pre-zdo-2026-05-02` is the release-ready snapshot for users who want the older architecture.

---

## 12. Risks & open questions

Numbered for traceability. Each item: title, what's unknown, resolution path, severity.

### 12.1 (High) Hash function determinism across .NET versions

**What's unknown:** confirmation that FNV-1a 32-bit produces byte-identical hashes for the same string on .NET 6 Windows, .NET 6 Linux, .NET 7 (if a player upgrades), and ARM (if an M-series Mac player ever runs SoD via Wine/Crossover).

**Resolution:** during Phase A, write a 10-line scratch test: hash 1000 strings, log the resulting `int` values, run on Windows + Linux x64 + Linux ARM (via Docker) — confirm byte-identical. The algorithm is deterministic by construction (no floating-point, no string interning, no culture-sensitivity), so this is a verification step, not a research step.

### 12.2 (Medium) SoD class field name compatibility across game updates

**What's unknown:** SoD updates may rename `Interactable.sw0` or `Citizen.humanID`. Our resolvers cache `FieldInfo` via reflection at plugin load; if a field name changes, plugin load fails to resolve.

**Resolution:** every resolver wraps lookup in try/catch with a `Plugin.Log.LogError` describing the missing field. Plugin continues to load with the affected feature disabled, rather than crashing entirely. A user playtest on a new SoD update will surface the missing field promptly. We accept that SoD updates may require a mod-side update; we do not aim for forward compatibility with arbitrary SoD changes.

### 12.3 (Medium) Migration co-existence bugs

**What's unknown:** during phases B–G, the legacy `BroadcastDoorState` and the new `Zdo.Set("closed")` coexist. If a feature flag is misset, both fire; the receiver applies twice; idempotent enough for doors (set-to-state) but possibly bad for additive features (fingerprint count + 1, then + 1).

**Resolution:** every legacy `BroadcastXxx` checks the feature flag at the top and no-ops when the ZDO path is on. Every poller gate-checks `!IsLegacyOnForThisFeature` symmetrically. Atomic swap, not parallel-double-fire. Per-feature playtest after each flag flip.

### 12.4 (Medium) Late-join snapshot ordering

**What's unknown:** whether LiteNetLib guarantees that a `ZdoSnapshot` packet enqueued at frame N delivers BEFORE a `ZdoDeltaBatch` enqueued at frame N+1 to the same peer.

**Resolution:** both packets are sent on the same `ReliableOrdered` channel. LiteNetLib's documentation states ReliableOrdered preserves FIFO. We rely on this contract. If empirical testing shows otherwise, we add a `snapshotSeq` field that the client buffers deltas against until snapshot arrives. Defer this complexity until evidence demands it.

### 12.5 (Medium) Owner-peer disconnect during state mutation

**What's unknown:** if a client owns ZDO X and disconnects mid-write (e.g. they were closing a door and hit a wifi blip), the host might see a partial state.

**Resolution:** ZDO writes are per-key atomic — `Zdo.Set("closed", true)` is a single dictionary write, no partial. Cross-key consistency (e.g. door closed + locked simultaneously) is not currently a real cross-key invariant in SoD. If the disconnect happens after `closed=true` is dirty-flushed but before `locked=true`, the next batch from the host (after ownership reassignment) will catch up.

### 12.6 (Low) Save file format schema versioning

**What's unknown:** future ZDO type tag additions (Phase A defines the enum; future phases may add) must not corrupt older saves on disk (section 8.1).

**Resolution:** `__version` reserved key (section 3.5) is bumped per type. The deserialiser reads the version first and dispatches to the correct decoder. If an unknown tag is encountered, the corresponding ZDO is skipped with a log warning rather than failing the entire restore. New type tags are additive only; never repurpose an existing tag.

### 12.7 (Medium) Bandwidth on 4-player + heavy event

**What's unknown:** peak bandwidth in a 4-player session during a murder cinematic with full forensics generation. Estimated 16 KB/s burst at 10 Hz tick rate; LiteNetLib's reliable channel ceiling is ~64 KB/s practical.

**Resolution:** if measured peak exceeds 50% of ceiling (32 KB/s), drop tick rate to 5 Hz globally during high-load periods (murder cinematic, mass arrest). Implement as an automatic step: if the per-second sent-bytes count exceeds the threshold for 3 consecutive seconds, the tick rate halves; recovers to 10 Hz after 10 seconds below threshold.

### 12.8 (Open) Host migration

**What's unknown:** whether to support host migration (host quits, client takes over) in this refactor.

**Resolution:** **out of scope for this refactor.** The ZdoMan snapshot mechanism is the foundation, and a future feature could add a "promote to host" RPC + AI re-init. Documented as known-not-implemented. If a user requests this, scope it as a separate spec.

### 12.9 (Open) Cross-version peer compatibility

**What's unknown:** how to handle a peer running mod version N connecting to a host running version N+1.

**Resolution:** the `Handshake` packet (currently `PacketType.Handshake = 0`) carries a `protocolVersion: int`. If client and host disagree, host responds with `ZdoVersionMismatch` and disconnects the client cleanly. Client surfaces a `"Mod version mismatch"` UI message. No silent corruption.

Open question: how aggressive should we be with version bumps? Conservative answer: bump on any wire-format change; do not bump on internal-only refactors. The version mapping is documented in `CHANGELOG.md` per release.

### 12.10 (Low) Compression overhead on tiny payloads

**What's unknown:** verified above (section 4.4) that 10-byte payloads become 30-byte after zstd. The 100-byte threshold avoids this. Open: should the threshold be tunable based on payload type (e.g. `ZdoEventRpc` is often <50 B; should it have a higher threshold)?

**Resolution:** single threshold for simplicity. Verified empirically that single-key delta batches average 80–120 B uncompressed, putting them right at the threshold. If a future profiling pass shows event RPCs dominate and would benefit from a separate threshold, add it then. YAGNI for now.

---

## 13. Glossary

- **ZDO** — Z-Data Object; a single replicated entity with a composite ID, owner, type tag, and property bag.
- **ZDOID** — composite identity `(PeerUid, Sequence)`. Globally unique; minted by the creator peer without central coordination.
- **ZdoMan** — singleton registry of all live ZDOs in the current session. Owns serialisation, ownership transfer, GC, and the per-tick delta-flush driver.
- **ZdoTypeTag** — single-byte discriminator that identifies the logical category of a ZDO (Door, Citizen, Evidence, …). Each tag has a per-type resolver that knows how to find/apply state to the corresponding live SoD object.
- **ZNetView** — Valheim's MonoBehaviour wrapper over a ZDO. We do NOT adopt this — we key by SoD-native ids instead.
- **ZRoutedRpc / ZdoEventRpc** — Valheim's / our channel for one-shot fire-and-forget events that don't need long-lived state (chat, banners, ping). Dispatched by string name into a registry.
- **OwnerPeer** — the peer (peer-uid value) that has authority to write to a ZDO. Last-writer-wins is decided by ownership: non-owners must call `TransferOwnership` before writing.
- **Dirty flag** — per-ZDO bit set on each `Set`, plus per-key entries in `_dirtyKeys`. Cleared on flush. The basis of delta batching.
- **Snapshot** — full ZdoMan dump sent to a joining peer. Serialised same format as the disk save (section 8.1) but sent over the wire.
- **Delta batch** — periodic flush (default 10 Hz) of all dirty ZDOs and their dirty keys. Coalesces many mutations within one tick into a single packet.
- **Init burst** — the 5+ minute window after `OnAfterLoad` (or after world creation) during which SoD seeds case-board / vmail / evidence-chain state. Pollers gate on `!IsInInitGrace` to avoid broadcasting these. Patches on cold methods are unaffected.
- **WorldReadyGate** — `src/Sync/WorldReadyGate.cs` singleton that polls `CityData / Citizens / Player` and fires `OnWorldReady` / `OnWorldUnready` events. Drives `IsInInitGrace` (30 s post-ready window).
- **SyncGate** — `src/Sync/SyncGate.cs` global flag (`IsOpen`). Closed during save-load. Every patch body's first line: `if (!SyncGate.IsOpen) return;`. Also gates pollers.
- **FNV-1a** — Fowler-Noll-Vo 1a hash function. 32-bit variant used as our deterministic stable hash for ZDO key strings. Replaces .NET 6's randomised `string.GetHashCode`.
- **zstd** — Zstandard compression. Adopted from BetterNetworking-Valheim. Default level 3, applied to ZdoDeltaBatch / ZdoSnapshot payloads above 100 B.
- **Star topology** — every client connects only to host; host relays to other clients. Existing pattern from `NetworkManager.OnNetworkReceive` rebroadcast (commit `f289c6e`).
- **Player twin** — local Citizen object on host that represents a connected client's player. Driven by ZDO updates from the client. Existing system, integrated as `PlayerTwin` ZDO type tag.
- **Determinism contract** — set of subsystems (NPC schedules, building layouts, vmail seed, etc.) that are not replicated because they are derivable from world seed.
- **RECONNECT_GRACE_S** — `src/Network/NetworkManager.cs:47`; 5 seconds after disconnect during which a peer's ZDOs are not yet GC'd, allowing a same-clientGuid reconnect to seamlessly resume.

---

## Appendix A — How each named nuance is addressed

The 15 nuances called out in the spec prompt, mapped to where in this document they are addressed:

1. **IL2CPP wrapper cost is not solved by ZDO** — section 1.3 (non-goals), section 2.3 item 1, section 5.2 (patch lifecycle policy). The fix is "don't patch hot methods", not "use ZDO instead of patches".

2. **No SoD source; reflection via dnSpy + Il2CppInterop** — section 2.3 item 6, section 12.2 risk, every type-resolver caches `FieldInfo` per section 2.3 item 7.

3. **Save file safety** — section 8.1; option B (separate file under `<BepInEx>/config/com.sodcoop.mod/zdo/`) keeps SoD's save untouched. A bug in our serialiser cannot corrupt SoD saves.

4. **Backward incompatibility with old peers** — section 12.9; `Handshake` packet carries `protocolVersion`; host responds with `ZdoVersionMismatch` packet (`PacketType.ZdoVersionMismatch = 204`) and disconnects mismatched clients with a clear UI message. No silent corruption.

5. **Player twin system interaction** — section 6 row 66, section 13 glossary entry "Player twin". `PlayerTwin` ZDO type tag integrates the existing per-client character system; AppearanceConfig persists in `CharacterStore` *and* on the `PlayerTwin` ZDO. Twin citizen's `aiFrozen` flag is a key on the same ZDO.

6. **Late-join during heavy event** — section 8.2 ("Late-join during heavy event" subsection). Snapshot captures up-to-now; subsequent deltas finish the in-flight cinematic. ReliableOrdered guarantees ordering.

7. **Snapshot bandwidth budget <50 KB compressed** — section 8.2 estimates 6–8 KB compressed for the default city size. Larger cities (>50 NPCs with mutations) may exceed 50 KB; LiteNetLib's reliable channel auto-fragments at MTU boundaries so deliverability is not compromised, but bandwidth pressure increases linearly. Chunked snapshot delivery is documented as a future extension in section 8.2 itself.

8. **Determinism violations from RemotePlayer** — section 7.2 (NPC AI is host-authoritative), section 7.3 (client-side AI ignored). Same model as Valheim.

9. **Pause/Resume elimination** — section 5.2 (patch lifecycle policy explicitly states "install once, never re-install"). Section 9 Phase A deletes the Pause/Resume code paths. Section 11 archives the gradual-Resume implementation on `archive/phase1-gradual-resume`.

10. **Compression overhead on tiny payloads** — section 4.4, 100-byte threshold. Section 12.10 discusses single-vs-per-type threshold trade-off.

11. **Migration co-existence** — section 9 phases B–G use atomic per-feature flags; legacy and ZDO paths are mutually exclusive per feature, never both firing. Section 12.3 risk.

12. **Reflection cost at runtime** — section 2.3 item 7, section 3.4 ("All resolvers cache their reflection at plugin load."). No mid-frame `Type.GetField` calls.

13. **Il2CppSystem.Collections vs System.Collections** — section 2.3 item 4. The ZDO serialiser accepts `Il2CppSystem.Collections.Generic.List<T>` directly via index-based iteration; `byte[]` blob payloads use this for the `noteKeys` and `hiddenFactsHashes` keys (feature mapping rows 18, 26).

14. **HarmonyX `[HarmonyPatch]` auto-discovery during migration** — section 9 each phase deletes the corresponding legacy `[HarmonyPatch]` attribute *only* after the new poller is validated. Two specific cases: `Toolbox.NewVmailThread` (`GamePatches.cs:1517`) and `Evidence.SetNote` (`GamePatches.cs:1257`) lose their attributes in Phase E after the corresponding pollers prove out. The other ~30 patches stay, untouched.

15. **OnWorldUnready re-pause** — section 8.4. ZdoMan.Clear is called on `OnWorldUnready`; in-memory state is wiped; next world load re-loads from disk if present, or initialises empty. SyncGate.Close() (existing call in `WorldReadyGate.cs:132`) is preserved for the next OnBeforeLoad cycle.

---

*End of spec. Length: ~1140 lines including the feature mapping table. Implementation plan derives from this document into `docs/superpowers/plans/2026-05-02-zdo-architecture-plan.md` (separate file, written only after user signs off on this spec).*
