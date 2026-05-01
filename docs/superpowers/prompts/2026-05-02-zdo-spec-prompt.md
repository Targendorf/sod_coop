# Prompt: Write ZDO + BetterNetworking Architecture Design for SoD Coop Mod

> Use this prompt verbatim when dispatching a subagent (or invoking yourself)
> to produce the design specification document. Output is a comprehensive
> design doc, NOT implementation. Implementation plan is a separate document
> derived from this spec later.

---

## Role

You are an architect writing a comprehensive design specification for a major refactor of the **SoD Coop mod** — a BepInEx 6 IL2CPP plugin that adds peer-to-peer cooperative multiplayer to *Shadow of Doubt* (a single-player detective game by ColePowered Games on Unity 2021.3).

The new architecture replaces ~10 ad-hoc per-feature `Sync` classes with a unified ZDO (Z-Data Object) replication layer modeled on Valheim's networking architecture, plus optimisations adopted from the BetterNetworking-Valheim mod (zstd compression, batching, queue management).

**This is a DESIGN document, not an implementation.** The output guides a future implementation that will land in 5–10 phased commits over several weeks.

## Required pre-reading (read fully before writing)

1. `D:\sod_coop\docs\superpowers\specs\2026-05-01-coop-patch-architecture-design.md` — current Phase 1 architecture spec (the one we're superseding).
2. `D:\sod_coop\docs\superpowers\plans\2026-05-01-coop-patch-architecture-plan.md` — current Phase 1 plan.
3. `D:\sod_coop\src\Plugin.cs` — entry point with current Pause / gradual Resume cycle.
4. `D:\sod_coop\src\Network\NetworkManager.cs` — LiteNetLib transport + connection state machine.
5. `D:\sod_coop\src\Network\Packets.cs` — current ~115 packet types (the volume problem we're solving).
6. `D:\sod_coop\src\Sync\SyncManager.cs` — current dispatcher (giant if/else if chain).
7. `D:\sod_coop\src\Sync\WorldStateSync.cs` — representative example of a per-feature sync class (door / light / switch broadcast pattern).
8. `D:\sod_coop\src\Patches\GamePatches.cs` — 49 active + 17 disabled Harmony patches; first 200 lines for shape, then grep.
9. `D:\sod_coop\src\Sync\WorldReadyGate.cs` — world-ready state tracking (`OnWorldReady` / `OnWorldUnready` events).
10. `D:\sod_coop\src\Integration\SodCommonBridge.cs` — SOD.Common save-load hooks.

## Reference architectures (cite where used)

- **Valheim ZDO/ZNet**: https://github.com/Valheim-Modding/Wiki/wiki/RPC-System-Reference-Sheet — owner-based replication, ZDOMan registry, ZRoutedRpc for events.
- **BetterNetworking-Valheim**: https://github.com/CW-Jesse/valheim-betternetworking — zstd compression patches, send-rate config, queue management.
- **Jotunn RPC tutorial**: https://valheim-modding.github.io/Jotunn/tutorials/rpcs.html — modder-friendly wrapper over Valheim RPC.

Cite these when you say "Valheim does X" or "BetterNetworking does Y". Do not paraphrase without citation.

## Output

Write to: **`D:\sod_coop\docs\superpowers\specs\2026-05-02-zdo-architecture-design.md`**

Length: 800–1500 lines. Anything shorter is incomplete. Anything longer probably has duplication.

After writing, commit immediately:

```bash
git -C D:/sod_coop add docs/superpowers/specs/2026-05-02-zdo-architecture-design.md
git -C D:/sod_coop commit -m "docs: ZDO + BetterNetworking architecture design spec

Replaces the per-feature Sync class architecture (10+ classes, 115+
packet types) with a unified ZDO replication layer modelled on
Valheim's ZDO/ZNet, plus zstd compression and batching from
BetterNetworking-Valheim.

Spec covers full feature parity with current sync surface."
```

## Mandatory sections (every one required, in this order)

### 1. Problem statement
What's broken about the current architecture. Concrete pain points:
- 115+ packet types each with hand-written serialise/deserialise/dispatch.
- 10+ Sync classes duplicating boilerplate (`if (!IsConnected) return; if (IsApplyingRemote) return;` etc.).
- Per-feature `OnPlayerJoined` snapshot logic copy-pasted with bugs.
- No formal ownership model → implicit conventions, occasional ping-pong races.
- New sync feature = 80–200 lines of boilerplate.
- Late-joiner state delivery has gaps.
- 64KB/s LiteNetLib practical bandwidth ceiling per peer; current architecture has high header overhead.

What success looks like (concrete & measurable, not aspirational).

Non-goals (explicitly call out what we're NOT solving in this refactor):
- IL2CPP wrapper trampoline cost (separate problem; handled via patch audit).
- SOD save format compatibility (independent dimension).
- Cross-version peer compatibility (separate versioning concern).

### 2. Reference architecture survey
Subsection per source:

**2.1 Valheim ZDO/ZNet** — what we adopt verbatim, what we adapt:
- ZDO: composite ID `(peerUid, sequence)`, owner field, property bag, dirty flag, last-modified timestamp.
- ZDOMan: global registry, ownership transfer, GC of orphaned ZDOs.
- ZNetView: per-game-object handle with helper API (`Set<T>(hash, value)` / `Get<T>(hash)`).
- ZRoutedRpc: separate RPC channel for one-shot events (murder, vmail-arrived, etc.).
- Proximity-based replication: clients only get ZDOs within range of their player.

**2.2 BetterNetworking-Valheim** — what we adopt:
- zstd compression (`ZstdSharp.Port` NuGet) with configurable level.
- Outgoing queue size config (don't drop packets at the LiteNetLib boundary).
- Send-rate config (Hz).
- Compression threshold (don't compress payloads below ~100 bytes).

**2.3 IL2CPP-specific constraints** we must honour:
- HarmonyX wrapper trampoline cost (~10–50µs per call) is a hard floor.
- `UnpatchSelf` does NOT undo native detours.
- Re-PatchAll on top of existing detours stacks trampolines (verified: causes crash on ESC, see commit `b118093`).
- IL2CPP-Interop reflection over SoD types is required (no source).
- `Il2CppSystem.Collections.Generic.List<>` ≠ `System.Collections.Generic.List<>`; serializer must handle both.

### 3. Core domain model
Define every type with realistic C# signature.

**3.1 ZDOID** — composite identity
```csharp
public readonly struct ZDOID : IEquatable<ZDOID> {
    public readonly ulong PeerUid;   // creator peer
    public readonly uint  Sequence;  // per-peer monotonic
    // ...
}
```

**3.2 ZDO** — the property bag entity
```csharp
public class Zdo {
    public ZDOID Id { get; }
    public ulong  OwnerPeer { get; private set; }
    public uint   ZdoTypeTag { get; }      // discriminator (Door, Citizen, Evidence, ...)
    public bool   Persistent { get; }      // saved to disk?
    public Vector3 Position { get; set; }  // for proximity culling
    public int    DataRevision { get; private set; }

    public T  Get<T>(int keyHash);
    public void Set<T>(int keyHash, T value);  // marks dirty + bumps revision
    public bool IsDirty { get; }
    public void ClearDirty();
}
```
Specify supported `T`: `int`, `bool`, `byte`, `float`, `string`, `Vector3`, `Quaternion`, `byte[]`, `ZDOID`. Reject everything else at API level.

**3.3 ZdoMan** — singleton registry
- Methods: `Register`, `Lookup(ZDOID)`, `LookupByGameObjectId(int)`, `TransferOwnership`, `GetAllOwnedBy(peer)`, `GetAllInRange(pos, radius)`, `Persist`, `Restore`.
- Internal storage: `Dictionary<ZDOID, Zdo>` + secondary indexes.
- GC policy: ZDO with `Persistent=false` whose owner has disconnected and no ref-holder remains → drop.

**3.4 ZdoTypeTag** — discriminator enum
List every ZDO type the mod defines. Pre-populate from feature mapping in section 6.

**3.5 Reserved property keys**
- `__type` — ZdoTypeTag (redundant w/ field but useful for debugging).
- `__version` — schema version per type.
- `__owner` — owner peer (snapshot of OwnerPeer at last write).
- `__pos`, `__rot` — position/rotation if applicable.

Use `int` hash of name string for keys (Valheim convention: `"closed".GetStableHashCode()`). Document the hash function — must be **identical** across peers and **stable across .NET versions** (so use a deterministic FNV-1a or similar, NOT `string.GetHashCode()` which is randomised in .NET 6+).

### 4. Network layer
**4.1 Packet types** (entire mod will end up with ~5 packet types instead of 115+):
- `ZdoDeltaBatch` — list of (ZDOID, dirty key set, values) for changed ZDOs in this tick.
- `ZdoSnapshot` — full ZDO dump for late joiner.
- `ZdoOwnershipTransfer` — owner change RPC.
- `ZdoEventRpc` — fire-and-forget event (replaces ChatMessage, MapPing, etc.).
- `ConnectionFlow*` — handshake / character submit / etc. (kept as-is from existing code).

**4.2 Wire format**
```
[1 byte]  PacketType
[1 byte]  flags (compressed? batched?)
[2 byte]  uncompressed length
[N bytes] zstd-compressed payload (if compressed flag set)
```
Compressed only if uncompressed > 100 bytes (BetterNetworking threshold). Document.

**4.3 Delta batching**
- Collect all dirty ZDOs in a per-tick queue.
- At configurable rate (default 10 Hz), flush queue: serialise → maybe compress → send as single `ZdoDeltaBatch`.
- Per-ZDO inside batch: only dirty keys (not full state).

**4.4 Compression**
- `ZstdSharp.Port` NuGet, level 3 (default), configurable 1–22.
- Reuse `ZstdSharp.Compressor` instances (avoid per-packet allocation).

**4.5 Queue management** (BetterNetworking pattern)
- Outbound queue per peer, capacity configurable (default 1024 packets).
- If queue full: drop oldest unreliable, never drop reliable.
- Backpressure log warning at 80% full.

**4.6 Reliability matrix**
For each packet type, specify:
| Packet | Channel | Notes |
|---|---|---|
| `ZdoDeltaBatch` | ReliableOrdered | last-writer-wins requires ordering |
| `ZdoSnapshot` | ReliableOrdered | one-shot on join |
| `ZdoOwnershipTransfer` | ReliableOrdered | must arrive before next delta |
| `ZdoEventRpc` (chat) | ReliableOrdered | user-facing |
| `ZdoEventRpc` (ping) | UnreliableSequenced | transient |

### 5. Detection layer (the unavoidable problem)

This section MUST be honest about the trade-off.

ZDO is a transport layer. It does NOT auto-magically detect SoD field changes. We still need to detect changes via:

- **Polling** (preferred where possible): per-tick diff against last-known state. Cost = O(N) field reads per tick. Zero IL2CPP wrapper cost.
- **Harmony patches** (where polling is impractical, e.g. player input): wrapper cost applies; restricted to cold methods.
- **Game's own C# events** (where they exist): zero cost; preferred when available.

**5.1 Detection mechanism per ZDO type** — table in section 6.

**5.2 Patch lifecycle policy** — the BIG architectural recommendation:
- Install Harmony patches once at plugin load.
- Never `UnpatchSelf` + re-`PatchAll` (proven to corrupt trampolines).
- Patches that target init-burst-hot methods (Toolbox.NewVmailThread, Evidence.SetNote, Fact.SetCustomName, SideJob ctor, Case.* generation) must NOT exist — replace with polling.
- Patches that target cold player-input methods (FirstPersonItemController.*, CasePanelController.Pin*, etc.) stay attached for the life of the process.

This eliminates the Pause/Resume cycle entirely. No wrapper-trampoline corruption. Clean.

### 6. Feature mapping table

**The most important section.** Cover EVERY currently-synced feature. For each row:

| Feature | Current impl | ZDO type | Owner | Property keys | Detection | Notes |
|---|---|---|---|---|---|---|

Required rows (do not skip any — grep `src/Sync/*.cs` to ensure coverage):

- Doors (open/close/lock) — `WorldStateSync`
- Lights (on/off) — `WorldStateSync`
- Switches — `WorldStateSync`
- NPC outfits — `PlayerOutfitSync.BroadcastNpcOutfit`
- NPC sleep state (in-bed, asleep) — currently disabled, needs new mechanism
- NPC phone calls — `PhoneSync`
- Fingerprints — `FingerprintSync`
- Footprints — `FootprintSync`
- Spatter — `SpatterSync`
- Vmail threads — `VmailSync`
- Evidence creation/discovery/notes/custom-name — `EvidenceSync`
- Case board pin/unpin — `CaseBoardSync`
- Case board strings — `CaseBoardSync`
- Case board fact rename — `CaseBoardSync`
- Case board status / hidden / resolve — `CaseBoardSync`
- Murder events — `CitizenDeathSync`
- Side jobs lifecycle (creation / state) — `SideJobSync`
- Side job accept/handin — `SideJobSync`
- Money — `MoneySync`
- NPC damage — `DamageSync`
- Player damage — `PlayerDamageSync`
- Item pickup/drop — `ItemSync`
- Inventory visibility (held, raised, flashlight) — `InventorySync`
- Item place / throw / give / handoff — `InventorySync`
- NPC restrained / stunned — `InventorySync`
- Computer login / app — `ComputerSync`
- Map markers / pings — `CoopMapMarkers` / `PingSystem`
- Elevator calls — `ElevatorSync`
- Time progression — `TimeSync`
- Weather — `WeatherSync`
- Player position + state — `PlayerSync`
- Player suspicion / trespass — `PlayerSuspicionSync`
- Player outfit — `PlayerOutfitSync.BroadcastSetOutfit`
- Player appearance — `AppearanceSync`
- Surveillance camera (save tape, acquire name) — patches in `EvidenceSync` neighbourhood
- Pause state — `PingSystem.NotifyLocalPauseChanged`
- Twin protection — `TwinProtectionPatch` interactions
- Chat messages — `CoopUI` chat broadcast
- Side-job notification banner — `SideJobSync`

**For each row** specify: what becomes a long-lived ZDO (replicated continuously), what becomes a one-shot `ZdoEventRpc` (fire-and-forget), and what stays purely local (deterministic-from-seed).

### 7. Determinism contract

Some SoD state is deterministic from world seed. We do NOT replicate these — both peers simulate independently.

List the trusted-deterministic subsystems explicitly:
- NPC daily schedule baseline (before any player interaction).
- Default NPC outfits at city init.
- Procedural building layouts.
- Vmail seed text (initial population).
- Evidence chain at city init.

Risk: **NPC AI reacts to RemotePlayer presence** — the AI's decisions depend on which players are nearby in which client's world. This breaks determinism. Document the mitigation:
- AI state is host-authoritative (host's NPCs are the truth).
- Client's local NPCs are visual-only proxies driven by host ZDO updates.
- Each player-twin position drives the host's AI inputs as if that player were locally present.

This is the same model Valheim uses (AI runs on the world owner; clients observe).

### 8. Save / load handling

**8.1 ZDOMan persistence** — where on disk?
- Option A: alongside SoD save file, custom `.sodb_coop` extension via SOD.Common save hooks. Pro: bundled. Con: SOD.Common API dependency.
- Option B: separate file in BepInEx config dir, keyed by save name. Pro: independent. Con: orphan if user renames save.
- Pick one and justify.

**8.2 Late joiner snapshot** — full ZDO dump:
- On `OnPlayerJoined`, host serialises every ZDO in `ZdoMan` → zstd → send.
- Client receives, calls `ZdoMan.Restore(payload)` which populates registry.
- Estimate snapshot size: 50 NPC × ~200 bytes + 5000 interactables × ~50 bytes ≈ 250KB raw → ~50KB zstd. Document target.

**8.3 Init-burst handling** without Pause/Resume:
- No Harmony patches on init-burst-hot methods (per section 5.2 policy).
- Pollers gated on `WorldReadyGate.IsWorldReady && !WorldReadyGate.IsInInitGrace`.
- During init-grace (30s post-WorldReady), pollers don't broadcast even if world is "ready".
- ZDO updates start flowing only after grace closes.

### 9. Migration plan

Phased migration. Each phase independently shippable. Co-existence with old system during migration.

Suggested phasing (the writer should refine if a better order suggests itself during analysis):

**Phase A — Infrastructure** (1 week)
- ZDOID, Zdo, ZdoMan, hash function, property bag, serialisers.
- Wire format types (`ZdoDeltaBatch`, `ZdoSnapshot`).
- zstd compression integration.
- No actual feature migration.
- Old Sync classes untouched and still working.

**Phase B — First feature: doors** (3 days)
- Migrate `WorldStateSync` door logic only.
- Old `BroadcastDoorState` call sites switched to `Zdo.Set("closed", ...)`.
- Verify in 2-PC coop.

**Phase C — World state batch** (1 week)
- Lights, switches, NPC outfits, sleep, phone calls.
- Convert pollers from current spec (Phase 2-3) into ZDO-writers.

**Phase D — Forensics** (3 days)
- Fingerprints, footprints, spatter — additive ZDO collections.

**Phase E — Case board + evidence** (1 week)
- Largest migration. CaseBoardSync has the most complex state.

**Phase F — Player state** (3 days)
- Position, health, outfit, suspicion, appearance.

**Phase G — Events to RPC** (3 days)
- Chat, ping, map marker, side-job notification → `ZdoEventRpc`.

**Phase H — Cleanup** (3 days)
- Delete obsolete `Sync` classes.
- Delete obsolete packet types.
- Final feature audit.

Total estimate: 4–5 weeks. Document explicitly.

### 10. Testing approach

Per-phase manual playtest checklists (this codebase has no automated test harness). For each phase, list specific 2-PC and 3-PC scenarios.

Edge cases to specifically cover:
- Peer disconnects while owning many ZDOs → ownership transfer or GC?
- Late join during murder cinematic → ordered delivery of cinematic ZDOs.
- Host migration (host quits, client takes over) — out of scope or planned?
- Save / load mid-coop session (if supported).

### 11. Git workflow

**Before any new code:**
```bash
git -C D:/sod_coop tag archive/pre-zdo-2026-05-02
git -C D:/sod_coop branch archive/phase1-gradual-resume
git -C D:/sod_coop push origin archive/pre-zdo-2026-05-02
git -C D:/sod_coop push origin archive/phase1-gradual-resume
```

`main` continues from current HEAD. New commits land on main as ZDO architecture. The archive branch / tag preserves the current Phase 1' / gradual-resume work for reference (and rollback).

Document this workflow in the spec for future readers' traceability.

### 12. Risks & open questions

Concrete numbered list. Each item: short title, what's unknown, how we'd resolve during implementation, severity (Low / Medium / High).

Examples (the writer should expand):
1. **Hash function determinism across .NET versions** — `string.GetHashCode` is randomised. Need stable hash. Severity: High. Resolution: implement FNV-1a.
2. **SoD class field name compatibility across game updates** — our reflection-based lookup of `Interactable.sw0` etc. could break on patch. Severity: Medium. Resolution: cache MethodInfo at plugin load with fallback by attribute/index.
3. **Migration co-existence bugs** — old `BroadcastDoorState` and new `Zdo.Set("closed")` coexist for one phase; double-broadcast risk. Severity: Medium. Resolution: add feature flags and deprecate one path at a time.
4. **Late-join snapshot ordering** — client receiving snapshot mid-deltabatch.
5. **Owner peer disconnects during state mutation** — partial state visible to other peers.
6. **Save file format schema versioning** — adding ZDO types between releases must not corrupt older saves.
7. **Bandwidth on 4-player + heavy event** — murder + 4 peers + 50 spatter ZDOs = stress test required.

### 13. Glossary

Define every term used: ZDO, ZDOID, ZDOMan, ZNetView (we may or may not use), ZRoutedRpc, owner peer, dirty flag, snapshot, delta batch, init-burst, gate, etc.

## Nuances to specifically address (do not skip any)

These are sharp edges from this project's history. Address each in the relevant section:

1. **IL2CPP wrapper cost**: ZDO does NOT make Harmony patches free. Wrapper trampoline still fires. The fix is "don't patch hot methods", not "use ZDO instead of patches".

2. **No SoD source**: all class introspection via dnSpy on `global-metadata.dat` + Il2CppInterop reflection. Field names verified by re-reading existing patches in `src/Patches/GamePatches.cs` (those patches were authored against runtime-verified field names).

3. **Save file safety**: ZDOMan persistence must NOT mutate or corrupt SoD's own save file. Pick option A or B from section 8.1 with justification.

4. **Backward incompatibility with old peers**: spec out a version-mismatch handshake. New client connecting to old host → fail with clear error. Don't silently corrupt.

5. **Player twin system interaction**: SoD's existing per-client character names + twin citizen claim (Phase A+B history; see `MEMORY.md` for context: project_sod_coop_character.md) — twin citizen is local Citizen object that represents the remote player. Must integrate cleanly with player-owned ZDO.

6. **Late-join during heavy event** (murder cinematic, mass arrest): document delivery ordering invariants.

7. **Snapshot bandwidth budget**: target <50KB compressed for default-sized city. Bigger cities (>50 NPCs) → split snapshot into chunks.

8. **Determinism violations from RemotePlayer**: as covered in section 7, NPC AI reacts to remote-player twin presence, which is a closed-loop dependency on client positions. The host is the AI authority — clients observe via ZDO. Document the implication: client-side AI changes are ignored / overwritten.

9. **Pause/Resume elimination**: the WHOLE POINT of moving to ZDO + polling-only detection is to never need `UnpatchSelf` + re-`PatchAll`. Document explicitly: the gradual Resume in commit `48146cc` is a Phase 1 stopgap that the ZDO architecture obviates.

10. **Compression overhead on tiny payloads**: zstd has ~20 byte fixed overhead. For a 10-byte payload, compression makes it WORSE. Document the 100-byte threshold.

11. **Migration co-existence**: during phase-by-phase migration, `WorldStateSync.BroadcastDoorState` (old) and `Zdo.Set("closed", ...)` (new) coexist for ~1 phase. Document the cutoff strategy: feature flag OR atomic swap.

12. **Reflection cost at runtime**: SoD field lookup via reflection has per-call cost. Cache `FieldInfo` / `MethodInfo` at plugin load, never mid-frame.

13. **Il2CppSystem.Collections vs System.Collections**: SoD lists are `Il2CppSystem.Collections.Generic.List<T>`. Standard LINQ won't work. Document pattern for iteration.

14. **HarmonyX `[HarmonyPatch]` attribute auto-discovery**: when migrating away from per-patch class to ZDO writes, the attribute removal must be coordinated with the new poller registration so we don't lose detection.

15. **OnWorldUnready re-pause**: when the player returns to title menu, ZDO state for that world should be discarded (next world load is a new session). Document the lifecycle.

## Format / quality requirements

- Markdown headers (`#`, `##`, `###`).
- Tables for the feature mapping (section 6) and reliability matrix (section 4.6).
- Code blocks for type signatures, packet wire format, hash function pseudocode.
- Every claim about "Valheim does X" cites the source URL.
- No "TBD", "TODO", "implement later", "fill in details" placeholders. If something is genuinely unknown, frame it as a numbered open question in section 12.
- Every section ≥1 paragraph (or table). Section headers without content fail review.

## Self-review (do this before saving)

After writing the doc, scan once for:
1. **Placeholders**: search for "TBD", "TODO", "fill in", "etc.", "...". Replace each with concrete content or move to section 12.
2. **Internal contradictions**: e.g., section 4 says compression always-on, section 5 says skip below 100 bytes — pick one and unify.
3. **Coverage gaps**: cross-reference section 6 feature mapping against `grep -l "public static void Broadcast" src/Sync/`. Every Broadcast method should map to a row.
4. **Type consistency**: `ZdoMan` in one section, `ZDOMan` in another — pick one.
5. **Numeric estimates**: every "~Xks" or "~Yms" claim has either a citation or a reasoned derivation.

Fix issues inline. Then save.

## Out of scope (to prevent scope creep in the doc)

- The new networking transport choice (LiteNetLib vs Steamworks vs ENet). Stay with LiteNetLib.
- Bandwidth budget enforcement at the kernel/socket level — out of scope.
- Steamworks integration — separate future effort.
- Voice chat — out of scope.
- Server browser / matchmaking — out of scope.
- Modded compatibility surface — out of scope; current "AssetBundleLoader" / "DDSLoader" coexistence is enough.

## Final reporting

Once the doc is written, committed, and self-reviewed:

Report **DONE** with:
- File path + line count.
- `git log -1 --oneline` of the commit.
- Brief summary of the most contentious design decision (e.g., "chose option B for save persistence because…").
- Any open questions you couldn't resolve, listed by their section 12 number.

If you encounter a blocker (file you can't read, contradiction in pre-reading you can't resolve, etc.) report **BLOCKED** with specifics.
