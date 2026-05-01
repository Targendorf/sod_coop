# ZDO Architecture — Implementation Plan

**Goal:** Replace the per-feature `Sync` class architecture with a unified ZDO replication layer per `docs/superpowers/specs/2026-05-02-zdo-architecture-design.md`.

**Verification model:** every task ends with `dotnet build -c Release` returning **0 errors**. Manual playtest is documented per phase but cannot be executed in autonomous mode.

**Source generator note:** `SoDCoop.Generators/NetPacketGenerator.cs` auto-emits Serialize/Deserialize for `[NetPacket]` partial structs. New ZDO wire types use this generator where field shapes fit; complex variable-length payloads (per-key value encoding, key-set diffs) are hand-written for control over format.

---

## Phase A — Infrastructure

**Files (new):**
- `src/Zdo/Hash32.cs` — FNV-1a 32-bit hasher.
- `src/Zdo/ZDOID.cs` — composite identity struct.
- `src/Zdo/ZdoTypeTag.cs` — discriminator enum.
- `src/Zdo/ZdoKeys.cs` — reserved key hashes + per-feature key constants pre-computed at static init.
- `src/Zdo/Zdo.cs` — property-bag entity.
- `src/Zdo/ZdoMan.cs` — singleton registry + delta-flush driver.
- `src/Zdo/ZdoWire.cs` — hand-written binary read/write helpers for ZDO payloads (ZDOID, value-tag-prefixed property values, optional zstd).
- `src/Zdo/ZdoDeltaBatch.cs` — packet wrapper.
- `src/Zdo/ZdoSnapshot.cs` — packet wrapper.
- `src/Zdo/ZdoOwnershipTransfer.cs` — packet wrapper.
- `src/Zdo/ZdoEventDispatcher.cs` — name-keyed event registry for `ZdoEventRpc`.
- `src/Zdo/ZdoVersionMismatch.cs` — packet wrapper for protocol mismatch.
- `src/Zdo/PeerSendQueue.cs` — application-layer outbound queue with backpressure.
- `src/Zdo/ZdoFeatureFlags.cs` — per-feature toggles for atomic legacy↔ZDO swap during phases B-G.

**Files (modified):**
- `SoDCoop.csproj` — add `ZstdSharp.Port` NuGet.
- `src/Plugin.cs` — strip Pause/Resume; init `ZdoMan`; register `ZdoMan.TickDeltaFlush` in `CoopUpdateRunner.Update`.
- `src/Integration/SodCommonBridge.cs` — drop `Plugin.PausePatchesForLoad` / `Plugin.ScheduleResume` calls; just close/open `SyncGate` symmetrically with `ZdoMan.Clear` on `OnBeforeLoad`.
- `src/Sync/WorldReadyGate.cs` — call `ZdoMan.Clear` on `OnWorldUnready` (already calls `BroadcastBudget.Reset` + `SyncGate.Close`).
- `src/Network/Packets.cs` — add new `PacketType` enum entries (200-204).
- `src/Sync/SyncManager.cs` — extend `OnPacketReceived` with switch arms for new packet types (legacy paths preserved during migration).
- `src/Network/NetworkManager.cs` — pipe outbound through `PeerSendQueue` (new helper next to existing `SendTo` / `SendToAll`).

**Tasks:**
- A.1 Add `ZstdSharp.Port` package to csproj.
- A.2 Implement `Hash32`, `ZDOID`, `ZdoTypeTag`, `ZdoKeys`.
- A.3 Implement `Zdo` (property bag) and `ZdoMan` (registry + dirty tracking + delta-flush tick).
- A.4 Implement `ZdoWire` (binary helpers for property-bag values + zstd wrapper).
- A.5 Implement packet wrappers `ZdoDeltaBatch`, `ZdoSnapshot`, `ZdoOwnershipTransfer`, `ZdoEventDispatcher`, `ZdoVersionMismatch`.
- A.6 Implement `PeerSendQueue` with 80% backpressure log.
- A.7 Add new `PacketType` enum entries 200-204 in `src/Network/Packets.cs`.
- A.8 Strip Pause/Resume code from `Plugin.cs` (sections from `IsPatchPaused` through `DrainGradualResume`, plus call site in `CoopUpdateRunner.Update` and the resume-related event hooks).
- A.9 Strip Pause/Resume calls from `SodCommonBridge.cs`.
- A.10 Initialize `ZdoMan` in `Plugin.InitializeSystems`; tick from `CoopUpdateRunner.Update`; call `ZdoMan.Clear` on `OnWorldUnready` and `OnBeforeLoad`.
- A.11 Wire dispatcher arms for new packet types into `SyncManager.OnPacketReceived` (legacy ranges preserved).
- A.12 Build clean (`dotnet build -c Release`, 0 errors).
- A.13 Commit: "phase A: ZDO infrastructure + Pause/Resume removal".

**Verification:** `dotnet build -c Release` returns 0 errors. Plugin loads without crash (smoke test by inspection — no disk-state access at init). Old Sync classes still work; no behaviour change visible to a peer.

---

## Phase B — Doors

**Files (new):**
- `src/Zdo/Resolvers/DoorResolver.cs` — find live `NewDoor` by `__sodId = Interactable.id`; apply `closed` and `locked` keys.
- `src/Zdo/Pollers/DoorPoller.cs` — host-side 10 Hz diff over `CityData.Instance.doorDictionary`.

**Files (modified):**
- `src/Zdo/ZdoTypeTag.cs` — `Door = 1` already present.
- `src/Zdo/ZdoKeys.cs` — add `closed`, `locked`, `playSound` key hashes.
- `src/Zdo/ZdoMan.cs` — register the resolver.
- `src/Zdo/ZdoFeatureFlags.cs` — add `UseZdoForDoors` (default `true`).
- `src/Sync/WorldStateSync.cs` — `BroadcastDoorState` / `BroadcastDoorLockState` no-op when ZDO flag is on; keep apply paths (called from `ZdoDeltaApplier`).
- `src/Plugin.cs` — register `DoorPoller` start/stop in lifecycle.

**Tasks:**
- B.1 Implement `DoorResolver`.
- B.2 Implement `DoorPoller`.
- B.3 Add feature flag and gate legacy broadcasts.
- B.4 Wire poller registration into `Plugin.InitializeSystems` after `WorldReadyGate`.
- B.5 Build clean.
- B.6 Commit: "phase B: doors via ZDO".

---

## Phase C — World state batch

**Files (new):**
- `src/Zdo/Resolvers/LightResolver.cs` (`__sodId = Interactable.id`, key `on`).
- `src/Zdo/Resolvers/SwitchResolver.cs` (`__sodId = Interactable.id`, key `on`).
- `src/Zdo/Resolvers/CitizenResolver.cs` (`__sodId = humanID`, keys `outfitCategory`, `inBed`, `asleep`, `restrained`, `restrainedDuration`, `stunned`).
- `src/Zdo/Resolvers/PhoneCallResolver.cs` (composite key `(callerId, calleeId)`, key `active`).
- `src/Zdo/Pollers/LightPoller.cs`, `SwitchPoller.cs`, `CitizenStatePoller.cs`, `PhoneCallPoller.cs`.

**Files (modified):**
- `ZdoFeatureFlags`: add `UseZdoForLights`, `UseZdoForSwitches`, `UseZdoForCitizens`, `UseZdoForPhoneCalls`.
- Legacy sync classes gate on flags.

**Tasks:**
- C.1-C.4 Implement four pollers + resolvers.
- C.5 Build clean.
- C.6 Commit: "phase C: lights/switches/citizens/phone via ZDO".

---

## Phase D — Forensics

**Files (new):**
- `src/Zdo/Resolvers/{Fingerprint,Footprint,Spatter}Resolver.cs`.
- `src/Zdo/Pollers/{Fingerprint,Footprint,Spatter}Poller.cs` — additive cursor pattern (track tail-append index, emit new entries since baseline).

**Tasks:**
- D.1-D.3 Implement three pollers + resolvers.
- D.4 Build, commit: "phase D: forensics via ZDO".

---

## Phase E — Case board + evidence

**Files (new):**
- `src/Zdo/Resolvers/{Case,CaseBoardCard,CaseBoardString,EvidenceObject,VmailThread}Resolver.cs`.
- `src/Zdo/Pollers/{EvidenceNote,VmailThread}Poller.cs` — replace hot patches at `GamePatches.cs:1257` and `:1517`.

**Files (modified):**
- `src/Patches/GamePatches.cs` — disable `[HarmonyPatch]` on `Toolbox.NewVmailThread` and `Evidence.SetNote` AFTER pollers validated.

**Tasks:**
- E.1 Implement evidence + case-board resolvers.
- E.2 Implement EvidenceNotePoller + VmailThreadPoller.
- E.3 Route patch-detected case-board events through ZDO.
- E.4 Disable two hot-path patches.
- E.5 Build, commit: "phase E: case board + evidence via ZDO".

---

## Phase F — Player state

**Files (new):**
- `src/Zdo/Resolvers/{LocalPlayer,PlayerTwin}Resolver.cs`.
- `src/Zdo/Pollers/LocalPlayerPoller.cs` — position/vitals/suspicion at existing rates (20 Hz position, 4 Hz suspicion, 1 Hz vitals).

**Tasks:**
- F.1-F.2 Implement player resolvers + poller.
- F.3 Migrate appearance, outfit, in-bed, asleep keys.
- F.4 Build, commit: "phase F: player state via ZDO".

---

## Phase G — Events to RPC

**Files (modified):**
- All event-style `Sync` calls (chat, ping, banner, side-job accept/handin, damage banners) reroute through `ZdoEventDispatcher.Send`.

**Tasks:**
- G.1 Register event names: `chat`, `map-ping`, `pause-banner`, `phone-banner`, `side-job-banner`, `side-job-accept`, `side-job-handin`, `crime-scene-discovered`, `npc-damage-banner`, `player-damage-banner`.
- G.2 Each Sync class with an event-style Broadcast switches to `ZdoEventDispatcher.Send(name, writer)` when feature flag is on.
- G.3 Build, commit: "phase G: events via ZdoEventRpc".

---

## Phase H — Cleanup

**Tasks:**
- H.1 Delete legacy `PacketType` enum entries (keep only ZDO-related + connection-flow).
- H.2 Delete legacy Sync class internals replaced by ZDO. Migration order: `WorldStateSync` → `EvidenceSync` → `CaseBoardSync` → forensics trio → player state → events.
- H.3 Replace `SyncManager.OnPacketReceived`'s 200-line dispatcher with the 5-way switch from spec section 4.6.
- H.4 Remove all feature flags from `ZdoFeatureFlags` (each feature is now ZDO-only).
- H.5 Final feature audit: walk every row in spec section 6 manually.
- H.6 Build clean, commit: "phase H: legacy cleanup".

---

## Conventions

- Hashes: `Hash32.Of("keyName")` everywhere; never `string.GetHashCode`.
- ZDOs created on **owner** peer; non-owners receive via delta batch.
- Pollers run **only on host** (`if (!NetworkManager.IsHost) return;`).
- Pollers gate on `WorldReadyGate.IsWorldReady && !WorldReadyGate.IsInInitGrace && SyncGate.IsOpen`.
- Each phase is independently revertible. Feature flags stay until Phase H.
- After each task: `dotnet build -c Release` 0 errors, then commit.
- Do not push to origin without explicit user approval.

---

## Out of scope (do not implement in this plan)

- Host migration (spec 12.8).
- Chunked snapshot for >50 KB (spec 8.2 future extension).
- Per-payload-type compression thresholds (spec 12.10).
- Save/load mid-coop with multi-user disk locking.
- Steamworks transport (spec 1.3 non-goal).
