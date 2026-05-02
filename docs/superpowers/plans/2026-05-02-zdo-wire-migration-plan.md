# ZDO Wire Migration — Phase G.5

**Date:** 2026-05-02
**Status:** In progress
**Context:** Spec `2026-05-02-zdo-architecture-design.md` Phases A-G are mostly complete but ~15 pollers detect mutations via the new ZdoPollerHost yet still call legacy `SoDCoop.Sync.X.Broadcast*` methods to ship state across the wire. This sub-phase migrates the wire format to `ZdoDeltaBatch` (compressed, queued) so Phase H cleanup can safely delete the legacy `Sync.*` classes.

---

## 1. Audit — current data flow per poller

| Poller | Currently sends via | Should send via | Risk |
|---|---|---|---|
| WeatherPoller | `WeatherSync.BroadcastSetWeather` (5 floats) | Singleton `Weather` ZDO + `WeatherResolver.Apply` | **Low** |
| ElevatorPoller | `ElevatorSync.BroadcastCall(floor, up)` | `Elevator` ZDO with `(callSeq:int, lastFloor:int, lastUp:bool)` | Medium |
| EvidenceCreationPoller | `EvidenceSync.BroadcastNewEvidenceSince` (snapshot+diff) | `EvidenceObject` ZDO per new ev (preset+pos+creator) | High (creator-side complex) |
| EvidenceNotePoller | `EvidenceSync.BroadcastSetNote` | Mutate existing `EvidenceObject` ZDO | Medium |
| CaseStatusPoller | `CaseBoardSync.BroadcastStatus(id, byte, bool)` | `Case` ZDO `status:byte` key | **Low** |
| SideJobPoller | `SideJobSync.BroadcastFromCtor / BroadcastStateChange` | `SideJob` ZDO with full upsert | High (12 fields) |
| CaseBoardPoller | `CaseBoardSync.Broadcast{Pin,Unpin,Move,String,...}` | `CaseBoardCard` + `CaseBoardString` ZDOs | High (4 broadcast types) |
| MurderPoller | `CitizenDeathSync.BroadcastDeath` | Citizen ZDO mutation (`dead:bool`, `killer:int`, `weapon:int`, `deathPos:Vector3`) + `ZdoEvents.MURDER_CINEMATIC` | Medium |
| MurderDiscoveryPoller | `CitizenDeathSync.BroadcastDiscovery` (no payload) | `ZdoEvents.CRIME_DISCOVERED` event | **Low** |
| NpcDamagePoller | `DamageSync.BroadcastDamage` (rich event payload) | `ZdoEvents.NPC_DAMAGE` event | Medium |
| HeldItemPoller | `InventorySync.BroadcastHeldRaw` (interactableID) | `LocalPlayer` ZDO key `heldItemId:int` | **Low** |
| MoneyPoller (legacy path) | `MoneySync.BroadcastAddMoney` | Already routes through `ZdoEvents.MONEY_ADDED` via wire-flag | ✅ Done in Round 10 |
| ComputerStatePoller | `ComputerSync.BroadcastLogin / BroadcastApp` | `Computer` ZDO with `(loggedInHumanId, appPreset, forceUpdate)` | **Low** |
| PlayerInputPoller (raised/flashlight) | `InventorySync.BroadcastRaised / BroadcastFlashlight` | `LocalPlayer` ZDO keys `raised:bool`, `flashlight:bool` | **Low** |
| PlayerInputPoller (pickup/drop) | `ItemSync.BroadcastPickup / BroadcastDrop` | `ZdoEvents.ITEM_PICKUP / ITEM_DROP` | **Low** |
| PlayerInputPoller (place/throw) | `InventorySync.BroadcastNewItemsSince` | `PlacedItem` / `ThrownItem` ZDOs per new entry | High (visual-mock spawn) |
| LocalPlayerPoller (player damage) | `PlayerDamageSync.BroadcastDamage` | `ZdoEvents.PLAYER_DAMAGE` event | **Low** |

**Already pure-ZDO** (no work needed): DoorPoller, LightPoller, SwitchPoller, CitizenStatePoller, PhoneCallPoller, FingerprintPoller, FootprintPoller, SpatterPoller, VmailThreadPoller (write-side), LocalPlayerPoller (state keys), PauseStatePoller (via ZdoEvents).

---

## 2. Migration order — by risk × impact

### Wave 1 — Low-risk, high-cleanup-value (do first)
1. **Weather** — singleton ZDO, 5 floats, 1 resolver method
2. **CaseStatus** — Case ZDO single byte key
3. **HeldItem** — add `heldItemId` to LocalPlayer ZDO
4. **Raised + Flashlight** — add to LocalPlayer ZDO
5. **MurderDiscovery** — single ZdoEventRpc registration
6. **Player Damage event** — single ZdoEventRpc registration
7. **Pickup/Drop events** — two ZdoEventRpc registrations

After Wave 1: 7 legacy Sync surfaces become wire-redundant. Zero risk to existing flows because legacy paths stay alive during transition.

### Wave 2 — Medium risk
8. **NPC Damage** — ZdoEventRpc with rich payload (~14 fields)
9. **Computer state** — Computer ZDO with 3 keys
10. **Elevator call** — per-elevator ZDO with seq counter
11. **Evidence note text** — mutation on existing EvidenceObject ZDO
12. **Murder state** — Citizen ZDO key mutation

### Wave 3 — High risk (do last; needs careful review)
13. **Evidence creation** — full snapshot + per-evidence ZDO setup, complex receiver
14. **Side jobs** — 12-field upsert, lifecycle states
15. **Case board pin/unpin/move/string** — 4 broadcast types, complex Il2Cpp List marshaling
16. **Place/Throw** — visual mock spawn on receiver, preset registry lookup

---

## 3. Per-migration template

For each item:

1. **Add ZdoTypeTag entry** (if new) in `ZdoTypeTag.cs`.
2. **Add property keys** in `ZdoKeys.cs` (FNV-1a hashed at static init).
3. **Update poller** — replace `Sync.X.Broadcast*` call with `Zdo.GetOrCreateBySodId(...)` + `z.Set(...)` for each value.
4. **Add resolver** at `src/Zdo/Resolvers/XResolver.cs` implementing `IZdoResolver.Apply(Zdo z)` — reads keys and calls the legacy `SyncX.Apply*` helper or directly mutates the SoD object.
5. **Register resolver** in `ZdoBootstrap.RegisterAll()`.
6. **Feature flag** — gate the wire format via `ZdoFeatureFlags.UseZdoForXWire` (default true after the migration is verified).
7. **Mark legacy Broadcast no-op** when flag is on (defensive — the poller no longer calls it but other callers might).

---

## 4. After all 16 done — Phase H is unlocked

Then we can:
- Delete legacy `Sync/X.cs` classes (~25 files)
- Collapse `SyncManager.OnPacketReceived` from 34 if/else if branches to a 5-way switch
- Delete ~95 entries from `PacketType` enum
- Remove `ZdoFeatureFlags` (each feature is now ZDO-only)
- Remove Pause/Resume rudiments from Plugin.cs

---

## 5. Notes

- **Receiver-side compatibility**: every wave keeps both wire paths alive (feature flag). Older clients on legacy wire still work; new clients on ZDO wire still work. Cutover happens after both peers are on the new build.
- **No Snapshot regression**: ZdoSnapshot already covers ZDO state. Pollers writing to ZDO automatically participate in late-join replay. Legacy `SendSnapshotTo` calls become dead code in Phase H.
- **BetterNetworking parity**: every wave moves another chunk of wire under zstd compression + PeerSendQueue + 10 Hz rate cap. After Wave 3, 100% of state-sync wire is BetterNetworking-equivalent.
