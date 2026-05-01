# Co-op Mod — Patch Architecture Redesign

**Date:** 2026-05-01
**Status:** Draft → pending user review
**Supersedes:** Pause/Resume PatchAll cycle (commits `9df6dcd`, `38ea93f`, `8918492`, `5116d7a`, `0a45bbc`)

---

## 1. Problem statement

The current Harmony patch architecture freezes the game (~1 frame per minute) immediately after a save-load cycle, in **both single-player and coop modes**. Disabling 15 known hot-path patches (commit `0a45bbc`) did not resolve the freeze — verified by user log on 2026-04-30 showing `Applied 49 Harmony patches at plugin load` followed by complete UI lock-up after `Harmony patches RESUMED — fresh instance #1`.

Players also reported per-second gameplay stutter ("каждую секунду лагает") even with `SyncGate.IsOpen` body-bail in place, before the freeze regression was introduced.

The mod must:

1. Run save-load at near-vanilla speed.
2. Maintain stable frame rate during gameplay.
3. **Preserve every implemented sync feature** — doors, lights, fingerprints, footprints, spatter, NPC outfits/sleep, phone calls, case board, evidence, vmail, side jobs, money, surveillance, combat, etc.

## 2. Root cause analysis

Two independent failure modes, both rooted in the Pause/Resume cycle:

### 2.1 Trampoline corruption from re-PatchAll

`OnAfterLoad` schedules a `PatchAll()` 2 seconds later. SoD's actual post-load init burst — case-board generation, evidence-chain seeding, vmail thread creation — runs for **5+ minutes** after `OnAfterLoad` fires (per the comment block in `Plugin.cs:88-105`). Re-installing detours on methods that are still on the active call stack corrupts the trampoline chain. The 2-second deferral is not enough; the burst is far longer.

Symptoms in the log: PatchAll completes, `[SyncGate] OPEN` logs, then the log file ends mid-burst. Next user-visible state is ~1 frame per minute.

### 2.2 `UnpatchSelf` does not undo native detours

The `BepInEx/LogOutput.log` shows zero `Removing detour` / `Restoring original` lines anywhere across the plugin lifetime. `Harmony.UnpatchSelf()` clears HarmonyX's internal patch registry but does not unwire the native code modification done by Dobby. Each subsequent `PatchAll()` adds **another** layer to the detour chain — observable in the log as the same source address (e.g., `0x7FFC74035340`) being detoured 4+ times across plugin load → SOD.Common load → first PatchAll → resume PatchAll, each with a different trampoline address.

Even on the first save-load cycle, methods shared with SOD.Common end up 3-deep in wrappers. Subsequent reloads compound this.

### 2.3 Why disabling 15 hot patches did not help

`0a45bbc` removed `[HarmonyPatch]` attributes from 15 ambient patches in the hope that wrapper trampoline cost × NPC ambient call rate was the bottleneck. The next user log (49 patches active) still froze, confirming the wrapper-cost hypothesis was not the dominant factor — **trampoline corruption from re-PatchAll** is.

## 3. Architecture redesign

Five-part change, executable as a single coherent migration. All five must land together; partial application leaves the codebase incoherent.

### 3.1 Patch lifecycle: install once, never re-install

Remove every Pause/Resume code path. Patches are installed once at plugin load via `PatchAll(Assembly.GetExecutingAssembly())` and remain attached for the lifetime of the process. `UnpatchSelf` is invoked only on `Plugin.Unload()` (i.e., never in practice — BepInEx unloads on game exit).

**Code to delete in `Plugin.cs`:**

- `PausePatchesForLoad()`
- `ResumePatchesAfterLoad()`
- `SchedulePatchResume()`
- `DrainPendingResume()`
- `_pendingResumeAt` field
- `IsPatchPaused` property
- `_harmonySessionCounter` field and fresh-instance reassignment
- `IsInstallingPatches` / `PatchTypesRemaining` / `PatchTypesTotal` / `DrainPatchInstaller` / `StartProgressiveInstall` stubs
- The call to `Plugin.DrainPendingResume()` from `CoopUpdateRunner.Update`

**Code to keep / adjust in `SodCommonBridge.cs`:**

- `OnBeforeLoad` handler: keep `_loadSw.Restart()` and `SyncGate.Close()`. **Remove** `Plugin.PausePatchesForLoad()`.
- `OnAfterLoad` handler: keep `_loadSw.Stop()` and load-time logging. **Replace** `Plugin.SchedulePatchResume()` with a direct `SyncGate.Open()`.

**Code to keep in `WorldReadyGate.cs`:**

- `IsInInitGrace` property and the 30-second window logic remain — used by Evidence/Vmail broadcast suppression to prevent the init-burst broadcast storm. The init-grace check inside the body of those broadcasts continues to work because patches are now always live, not paused.
- The init-grace-close log line stays, since it's a useful diagnostic for "we crossed the heaviest part of init".

**`SyncGate` semantics unchanged:** `IsOpen == false` during the OnBeforeLoad → OnAfterLoad span. Every patch body's first line is `if (!SyncGate.IsOpen) return;`. The IL2CPP wrapper still fires per call during save-load, but the body bails in <1µs and broadcasts nothing.

### 3.2 Polling subsystem for ambient state

Replace 15 ambient hot-path patches with timed state pollers.

New file: `src/Sync/Polling/StatePoller.cs` — abstract base with:

```csharp
public abstract class StatePoller<TKey, TValue> {
    private readonly Dictionary<TKey, TValue> _last = new();
    private float _nextTickAt;
    public abstract float TickInterval { get; }     // seconds, e.g., 0.1 for 10 Hz
    public abstract IEnumerable<KeyValuePair<TKey, TValue>> EnumerateCurrent();
    public abstract void OnDelta(TKey key, TValue prev, TValue curr);
    public abstract void OnRemoved(TKey key, TValue prev);
    public void Tick(float now) {
        if (now < _nextTickAt) return;
        _nextTickAt = now + TickInterval;
        if (!SyncGate.IsOpen) return;
        if (!NetworkManager.IsHost) return;
        // diff …
    }
    public void ResetBaseline();   // called on OnBeforeLoad — next tick re-reads the world
    public Snapshot Capture();      // for OnPeerConnected snapshot
    public void ApplySnapshot(Snapshot s);   // client side
}
```

**Concrete pollers (under `src/Sync/Polling/`):**

| Poller | Replaces patches | Source enumeration | Key | Tracked field(s) | Tick rate |
|---|---|---|---|---|---|
| `DoorStatePoller` | `NewDoor.OnOpen/OnClose/SetLocked` | `CityData.Instance.<doors>` | `Interactable.id` | `(isClosed, locked)` | 10 Hz |
| `LightStatePoller` | `LightController.SetOn` | light registry | `Interactable.id` | `bool isOn` | 10 Hz |
| `OutfitStatePoller` | `CitizenOutfitController.SetCurrentOutfit` | citizen list | `Citizen.humanID` | `int outfitCategory` | 5 Hz |
| `SleepStatePoller` | `Actor.SetInBed/GoToSleep/WakeUp` | citizen list | `Citizen.humanID` | `(inBed, asleep)` byte | 5 Hz |
| `PhoneCallPoller` | `TelephoneController.AddActiveCall/RemoveActiveCall` | phone registry | `(callerId, calleeId)` | active flag | 5 Hz |
| `FingerprintPoller` | `Interactable.AddNewDynamicFingerprint/RemoveManuallyCreatedFingerprints` | iterates `Interactable` instances; tracks `(interactableId → fingerprintCount)`. On count increase, reads the *last N* entries of `Interactable.fingerprints` (where N = delta) and broadcasts those. On count decrease, broadcasts a "clear" delta. | `Interactable.id` | `int count` baseline | 5 Hz |
| `FootprintPoller` | `FootprintController.Setup` | tracks `_lastBroadcastIndex` against the global active list's count; broadcasts entries at `[_lastBroadcastIndex, currentCount)` then advances cursor | global cursor | tail-append index | 5 Hz |
| `SpatterPoller` | `SpatterSimulation.Execute` | same cursor pattern as `FootprintPoller` against the scene's spatter registry | global cursor | tail-append index | 2 Hz (rare event) |
| `VmailThreadPoller` | `Toolbox.NewVmailThread` | iterates `Toolbox.Instance.allVMail`; tracks `(threadId → existence)` | thread id | bool present | 2 Hz |

**Coalescing:** Each poller emits at most **one packet per tick** containing all detected diffs. A 50-NPC outfit change frame becomes one `OutfitDeltaPacket{ entries: [...] }`, not 50 individual packets.

**Reverse direction (client receives):** Clients do **not** poll. They receive delta packets and apply them via the same code paths the host's Harmony patches used to invoke. The existing `WorldStateSync.IsApplyingRemote` re-entrancy guard remains the single source of truth for "we are applying a remote change, do not re-broadcast".

**Tick driver:** `CoopUpdateRunner.Update` calls a single `WorldStatePollers.TickAll(Time.unscaledTime)` that fans out to each registered poller. Each poller schedules its own next-tick time so pollers with different rates aren't coupled.

**Cost ceiling:** A 500-door / 1000-light / 50-NPC city polled at 10 Hz is ~15,500 field reads per second on the host. This is a few microseconds total per tick — small fraction of a frame budget. No allocations in the hot path (the diff dictionary is reused).

### 3.3 Patch surface audit

After migration, the active patch surface drops from 49 → ~30, all on cold paths. Going through `src/Patches/GamePatches.cs`:

**KEEP — player-triggered, low frequency (~30):**

- `SessionData.TogglePause` — UI menu transition.
- `CasePanelController.PinToCasePanel` (both overloads), `UnPinFromCasePanel`.
- `PinnedItemController.SetPostion`.
- `Case.AddNewStringColour`, `SetHidden`, `SetStatus`, `Resolve`.
- `Case.ResolveQuestion.SetProgress`.
- `StringController.RemoveCustomLink`.
- `Fact.SetCustomName`.
- `Human.Murder`, `MurderController.OnVictimDiscovery`.
- `SessionData.SetWeather`.
- All `FirstPersonItemController.*` — 14 entries, all player-input only.
- `Evidence.AddDiscovery`, `Evidence.AddOrSetCustomName`.
- `SurveillanceApp.SaveToTapeButton`, `AcquireNameButton`.
- `GameplayController.AddMoney`.
- `ComputerController.SetLoggedIn`, `SetComputerApp`.
- `MapController.OpenMap`.
- `Elevator.CallElevator`.
- `Actor.RecieveDamage`.
- `SideJob` constructor, `SetJobState`, `OnPlayerCall`, `OnRewarded`.
- `SideJobController.JobCreationCheck`.
- `Human.TryGiveItem`.
- `NewAIController.SetRestrained`, `SetStunned`.

**MIGRATE — replaced by pollers (≈17):**

- 15 currently-disabled hot-path patches → 8 pollers (see table in 3.2).
- `Toolbox.NewVmailThread` → `VmailThreadPoller` (2 Hz). Mid-session vmails created by NPC actions are NOT assumed deterministic across peers (player presence affects NPC schedules); explicit poll-and-sync.
- `Evidence.SetNote` → new `EvidenceNotePoller` (5 Hz) tracks `(evidenceId → noteContentHash)` and broadcasts when the hash changes. Most note assignments happen during the init burst, so under `!SyncGate.IsOpen` the poller's baseline is reset and the post-load tick will not re-broadcast init-burst notes (they'll be in baseline). User-edited notes from gameplay sync normally.

**Total active patches after migration: ~30.** All on player input paths, called O(1)-O(10) times per second under heavy player activity. Wrapper trampoline cost becomes negligible.

**Polling adds 9 new background workers** (Door, Light, Outfit, Sleep, PhoneCall, Fingerprint, Footprint, Spatter, Vmail, EvidenceNote — 10 total counting Vmail and EvidenceNote). Their combined cost is bounded by `TickRate × Σ(EnumeratedItems)` and runs only on the host.

### 3.4 Snapshot on connect

When a client connects mid-session, polling diffs alone cannot bring them up to date — they need the *current* state, not deltas from now. Extend the existing snapshot mechanism (modeled on `CaseBoardSync.SendSnapshotTo`):

1. New packet `WorldStateSnapshotPacket` containing per-poller payloads:
    - door states (id → packed state byte)
    - light states (id → on/off)
    - citizen outfits (humanID → category byte)
    - citizen sleep state
    - active phone calls
    - fingerprint summary (interactableId → count)
    - footprint cursor + last N entries
    - spatter cursor + last N entries
    - vmail thread set (thread id list)
    - evidence note hashes (evidenceId → hash)
2. Host sends on `OnPeerConnected`.
3. Client applies via each poller's `ApplySnapshot()` — this sets the receiver's `_lastKnown` baseline so subsequent deltas merge cleanly.

Estimated wire cost for a typical city: ≈ 500 doors × 3 B + 1000 lights × 2 B + 50 NPC × 6 B + 5000 interactables × 4 B (fingerprint count map, sparse so probably < 500 entries × 6 B) + ~100 vmail summaries × 32 B ≈ 30 KB. Sent once, fully acceptable.

### 3.5 Save-load behaviour

With 3.1 in place, the load sequence becomes:

1. User clicks Load Save → `OnBeforeLoad` fires → `SyncGate.Close()` + reset poller baselines + load-stopwatch starts.
2. SoD's load pipeline runs. Patches are still attached. Every patched method's body bails fast (`!SyncGate.IsOpen`). IL2CPP wrapper cost is unavoidable but bounded — same as v1 baseline before any pause/resume hackery existed.
3. `OnAfterLoad` fires → load-stopwatch stops, log wall-clock → `SyncGate.Open()`.
4. From the next frame, pollers begin diffing against their reset baselines. First broadcast contains everything that changed during load (a single batched delta per poller).

We accept that save-load is slower than vanilla. The acceptable upper bound is the v1 baseline (~50s in user logs, vs ~10s vanilla). If measured cost exceeds 90s, follow-up optimization becomes necessary — but is **out of scope** for this design. The first version of this redesign prioritizes "game runs and all features sync"; save-load optimization is a separate, smaller project.

## 4. Migration plan

Five sequential PRs, each independently shippable and reversible:

1. **Strip Pause/Resume** — Section 3.1 only. After this PR, save-load is slower but the game does not freeze. Validates the diagnosis.
2. **Polling base + first 3 pollers** — `StatePoller<,>` + `DoorStatePoller` + `LightStatePoller` + `OutfitStatePoller`. Disable the 3 corresponding old patches. Validates the polling pattern end-to-end.
3. **Remaining pollers** — Sleep, PhoneCall, Fingerprint, Footprint, Spatter, Vmail, EvidenceNote. Disable corresponding patches.
4. **Snapshot-on-connect** — `WorldStateSnapshotPacket` + per-poller `Capture()` / `ApplySnapshot()` + wiring into `OnPeerConnected`.
5. **Patch audit & prune** — disable `[HarmonyPatch]` attribute on `Toolbox.NewVmailThread` and `Evidence.SetNote` (both now covered by their pollers). Walk the KEEP list against the live codebase to confirm no patch is doing ambient work that escaped the audit.

Each PR is testable in isolation: build, deploy, load a save, confirm game runs, confirm relevant feature still syncs in a 2-player coop session.

## 5. Out of scope

- Lazy / progressive patch installation. Already proven crash-prone (commits `418dd27`, `29c72ce`).
- Replacing Harmony with another hooking framework.
- Reducing IL2CPP wrapper marshalling cost itself (would require Il2CppInterop modifications).
- Sub-feature: dynamic snapshot diffing for very-large-city saves (>100k interactables) — current design assumes default city size.

## 6. Risks & rollback

| Risk | Likelihood | Mitigation |
|---|---|---|
| One of the 30 KEEP patches turns out to be on a hot path we missed | medium | PR 1 lands first → if gameplay stutters return, profile that PR alone; no polling code touched yet |
| Polling tick cost exceeds budget on very large worlds | low | Pollers self-throttle via configurable tick rate; can drop to 2 Hz globally |
| Snapshot packet fragments at >MTU on huge cities | low | LiteNetLib auto-chunks reliable channel; tested patterns exist (`CaseBoardSync.SendSnapshotTo`) |
| Save-load slows past 90s under "patches always live" | medium | If measured, follow-up PR adds Section 3.1 inverse: temporarily *disable* selected patches' bodies via per-patch flags during load (no native unpatch — flag check only) |
| Fingerprint/footprint additive polling proves too expensive (5000 interactables × per-tick scan) | medium | Switch to "cursor + global registry" pattern if SoD exposes one; otherwise scope poll to player's loaded cell only |

Rollback path: each migration PR is a single revert. PR 1's revert restores the broken pause/resume but documents the regression for the next iteration.

## 7. Testing approach

- **PR 1**: load save in SP, confirm game playable. Load save in 2-player coop, confirm chat / inventory / case board still sync.
- **PR 2**: in 2-player coop, host opens door, client sees it close & open within 200ms. Same for light. Same for NPC scheduled outfit change.
- **PR 3**: kill an NPC on host machine, client sees blood spatter; both see fingerprints on objects NPC interacted with.
- **PR 4**: host plays for 30 minutes, then a third client joins; third client's world matches in <5s.
- **PR 5**: full session run, no stutter, all features verified manually against a coop test checklist.

No automated test harness exists for this codebase; all verification is manual playtesting per the existing project workflow.

## 8. Glossary

- **Pause/Resume cycle** — the deprecated `UnpatchSelf` + `PatchAll` dance around save-load.
- **Trampoline** — Dobby's machine-code shim that intercepts a target method.
- **Body-bail** — the `if (!SyncGate.IsOpen) return;` line at the top of every patch body.
- **Init burst** — the 5+ minute window after `OnAfterLoad` where SoD continues setting up case-board / vmail / evidence-chain state.
- **Poller baseline** — the dictionary of last-known values each poller diffs against.
