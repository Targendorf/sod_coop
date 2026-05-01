# Coop Patch Architecture Redesign — Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Eliminate the post-load freeze and per-second gameplay stutter by removing the Pause/Resume PatchAll cycle and replacing 17 hot-path Harmony patches with timed state pollers, while preserving every implemented sync feature.

**Architecture:** PatchAll once at plugin load, never re-install. SyncGate body-bail keeps fast-bail during save-load. Ambient world state (doors, lights, NPC outfits/sleep, phone calls, fingerprints, footprints, spatter, vmails, evidence notes) is reconciled via per-system pollers running 2–10 Hz on the host only, broadcasting coalesced delta packets. Late-joiners receive a single `WorldStateSnapshotPacket` on connect that primes their poller baselines.

**Tech Stack:** C# 11, BepInEx 6 IL2CPP (Unity 2021.3), HarmonyX, Il2CppInterop, LiteNetLib (reliable-ordered channel for state sync), .NET 6.

**Codebase root:** `D:\sod_coop`. Build via `dotnet build -c Release` from repo root. Output `SoDCoop.dll` is auto-deployed to `C:\Users\blued\AppData\Roaming\com.kesomannen.gale\shadows-of-doubt\profiles\Default\BepInEx\plugins\SoDCoop\` by the existing post-build step (verify after first build).

**Verification model:** This codebase has **no automated test harness**. Every task ends with two checks: (1) `dotnet build -c Release` returns 0 errors, and (2) the listed manual playtest step. No xUnit, no NUnit, no in-engine test framework. Pollers are validated by hosting a 2-PC coop session and observing whether ambient state crosses the wire within the documented latency budget.

**Spec reference:** `docs/superpowers/specs/2026-05-01-coop-patch-architecture-design.md`. Read it before starting Task 1.

---

## File Structure

**New files (created in this plan):**
- `src/Sync/Polling/StatePoller.cs` — abstract base for all pollers (Phase 2).
- `src/Sync/Polling/WorldStatePollers.cs` — registry + tick fan-out (Phase 2).
- `src/Sync/Polling/DoorStatePoller.cs` (Phase 2).
- `src/Sync/Polling/LightStatePoller.cs` (Phase 2).
- `src/Sync/Polling/OutfitStatePoller.cs` (Phase 2).
- `src/Sync/Polling/SleepStatePoller.cs` (Phase 3).
- `src/Sync/Polling/PhoneCallPoller.cs` (Phase 3).
- `src/Sync/Polling/FingerprintPoller.cs` (Phase 3).
- `src/Sync/Polling/FootprintPoller.cs` (Phase 3).
- `src/Sync/Polling/SpatterPoller.cs` (Phase 3).
- `src/Sync/Polling/VmailThreadPoller.cs` (Phase 3).
- `src/Sync/Polling/EvidenceNotePoller.cs` (Phase 3).
- `src/Sync/Snapshot/WorldStateSnapshot.cs` — packet definition + serialize/deserialize (Phase 4).

**Modified files:**
- `src/Plugin.cs` — strip Pause/Resume code (Phase 1) + register pollers (Phase 2-3) + wire snapshot (Phase 4).
- `src/Integration/SodCommonBridge.cs` — strip Pause/Resume hooks (Phase 1) + reset poller baselines (Phase 2).
- `src/Network/Packets.cs` — add new PacketType enum entries (Phase 2-4).
- `src/Patches/GamePatches.cs` — disable two more `[HarmonyPatch]` attributes (Phase 5).
- `src/Sync/SyncManager.cs` — route inbound poller-delta packets to apply methods (Phase 2-3).
- `src/Sync/PlayerStateSync.cs` — add NPC sleep broadcast helpers (Phase 3) — only if existing `BroadcastInBed` / `BroadcastAsleep` are scoped to local player.

**Deleted/cleared code blocks (not files):**
- `Plugin.PausePatchesForLoad` + `ResumePatchesAfterLoad` + `SchedulePatchResume` + `DrainPendingResume` + supporting fields/properties/stubs (Phase 1).
- `CoopUpdateRunner.Update` line `Plugin.DrainPendingResume();` (Phase 1).
- `SodCommonBridge.OnBeforeLoad` line calling `Plugin.PausePatchesForLoad()` (Phase 1).
- `SodCommonBridge.OnAfterLoad` line calling `Plugin.SchedulePatchResume()` (Phase 1).

---

## Phase 1 — Strip Pause/Resume Cycle

**Goal:** After this phase the game must boot, load a save, and run gameplay without the 1-frame-per-minute freeze. Save-load duration may regress to v1 baseline (~50s); that is expected and out of scope.

### Task 1.1: Remove Pause/Resume methods and fields from Plugin.cs

**Files:**
- Modify: `src/Plugin.cs`

- [ ] **Step 1: Open `src/Plugin.cs` and locate the `// ─── Patch pause/resume around save-load (vanilla load speed) ───` comment block (around line 186).**

- [ ] **Step 2: Delete the entire block from that comment header through the end of `DrainPendingResume()` method.**

The exact deletion span is:
- Comment block at `// ─── Patch pause/resume …`
- Property `public static bool IsPatchPaused { get; private set; }`
- Field `private static float _pendingResumeAt;`
- Method `PausePatchesForLoad()` (full body)
- Field `private static int _harmonySessionCounter;`
- Method `ResumePatchesAfterLoad()` (full body)
- Stub properties `IsInstallingPatches`, `PatchTypesRemaining`, `PatchTypesTotal`
- Stub methods `DrainPatchInstaller()`, `StartProgressiveInstall()`
- Method `SchedulePatchResume()`
- Method `DrainPendingResume()`

After deletion the next code below the deleted block should be `private void InitializeSystems()`.

- [ ] **Step 3: In `CoopUpdateRunner.Update()` (bottom of `Plugin.cs`, around line 402), remove the lines:**

```csharp
            Plugin.DrainPatchInstaller();
            Plugin.DrainPendingResume();
```

- [ ] **Step 4: Build and confirm clean compile.**

Run: `dotnet build -c Release` from `D:\sod_coop`.
Expected: `Build succeeded.` with `0 Error(s)`. Pre-existing warnings (CS0414, NETPKT001) may remain — that is fine.

If the build fails on missing `IsInstallingPatches` or `IsPatchPaused`, search the codebase for the offending reference:

```
grep -rn "IsInstallingPatches\|IsPatchPaused\|PatchTypesRemaining\|PatchTypesTotal\|DrainPatchInstaller\|StartProgressiveInstall\|PausePatchesForLoad\|ResumePatchesAfterLoad\|SchedulePatchResume\|DrainPendingResume" src/
```

For each remaining hit:
  - If it is in `src/UI/CoopUI.cs` rendering a "patch install banner", delete the banner method invocation and the method itself; the banner is no longer meaningful.
  - If it is anywhere else, replace with a no-op or remove the surrounding `if` branch.
- Re-run the build until clean.

- [ ] **Step 5: Commit.**

```
git add src/Plugin.cs
git -C D:/sod_coop commit -m "refactor: remove Plugin Pause/Resume PatchAll cycle

Plugin.PausePatchesForLoad / ResumePatchesAfterLoad / SchedulePatchResume
/ DrainPendingResume / DrainPatchInstaller and supporting fields are
removed. The cycle stacked native detours and corrupted trampolines on
re-PatchAll mid-init-burst (see spec
docs/superpowers/specs/2026-05-01-coop-patch-architecture-design.md
sections 2.1-2.2). Save-load now runs with patches always live, body-bailed
via SyncGate.IsOpen.

Part 1 of 5 in patch-architecture redesign."
```

### Task 1.2: Update SodCommonBridge to skip the deleted methods

**Files:**
- Modify: `src/Integration/SodCommonBridge.cs:55-95`

- [ ] **Step 1: Open `src/Integration/SodCommonBridge.cs` and locate the `lib.OnBeforeLoad` handler (line ~55).**

- [ ] **Step 2: Replace the `OnBeforeLoad` handler body so it no longer calls `Plugin.PausePatchesForLoad()`. Final form:**

```csharp
            lib.OnBeforeLoad += (sender, args) =>
            {
                try
                {
                    _loadSw.Restart();
                    // Close the patch body gate. Patches stay attached but their
                    // bodies fast-bail in <1µs, so SoD's heavy save-load init
                    // burst runs without our network/state code firing.
                    SoDCoop.Sync.SyncGate.Close();
                    // Reset poller baselines so the post-load tick re-reads the
                    // world fresh and broadcasts a single coalesced delta per
                    // poller (instead of replaying state that was identical
                    // before the load).
                    SoDCoop.Sync.Polling.WorldStatePollers.ResetAllBaselines();
                    Plugin.Log.LogInfo($"[SODCommon] OnBeforeLoad: {args?.FilePath} — timer started, sync gate closed");
                }
                catch (Exception ex) { Plugin.Log.LogError($"OnBeforeLoad handler: {ex.Message}"); }
            };
```

NOTE: The `WorldStatePollers.ResetAllBaselines()` call references a class created in Phase 2. To keep this Phase 1 step compiling on its own, **comment out** the `ResetAllBaselines()` line for now and add a `// TODO Phase 2: uncomment once WorldStatePollers exists` comment beside it. Phase 2 Task 2.2 will uncomment.

- [ ] **Step 3: Replace the `OnAfterLoad` handler body. Final form:**

```csharp
            lib.OnAfterLoad += (sender, args) =>
            {
                try
                {
                    _loadSw.Stop();
                    LastLoadSeconds = _loadSw.Elapsed.TotalSeconds;
                    Plugin.Log.LogInfo($"[SODCommon] OnAfterLoad: {args?.FilePath} — save-load wall-clock {LastLoadSeconds:F2}s");
                    // Open the gate. Pollers (registered in CoopUpdateRunner)
                    // begin diffing on the next frame.
                    SoDCoop.Sync.SyncGate.Open();
                }
                catch (Exception ex) { Plugin.Log.LogError($"OnAfterLoad handler: {ex.Message}"); }
            };
```

- [ ] **Step 4: Build and confirm clean compile.**

Run: `dotnet build -c Release`. Expected: 0 errors.

- [ ] **Step 5: Commit.**

```
git add src/Integration/SodCommonBridge.cs
git -C D:/sod_coop commit -m "refactor: SodCommonBridge no longer pauses/resumes patches

OnBeforeLoad now closes SyncGate only; OnAfterLoad opens it. Patches
remain attached for the full session.

Part 1 of 5 in patch-architecture redesign."
```

### Task 1.3: Phase 1 manual playtest

**Files:** none (verification only).

- [ ] **Step 1: Confirm DLL is deployed.**

Check the timestamp of `C:\Users\blued\AppData\Roaming\com.kesomannen.gale\shadows-of-doubt\profiles\Default\BepInEx\plugins\SoDCoop\SoDCoop.dll` is newer than the latest `dotnet build` run. If a post-build copy step exists in `SoDCoop.csproj`, this should be automatic. Otherwise copy manually from `bin/Release/net6.0/SoDCoop.dll`.

- [ ] **Step 2: Launch Shadows of Doubt → Load Save → wait for world to load.**

Expected:
- BepInEx log shows `Applied 49 Harmony patches at plugin load`.
- After load: `[SODCommon] OnAfterLoad: … save-load wall-clock <N>s` followed by `[SyncGate] OPEN`. **No** `Patch resume scheduled` line — that method is deleted.
- Game is **interactive within 5 seconds** of "world is READY" log line. Player can move, mouse looks around, NPCs walk.
- Save-load wall-clock may be 50s+ (slower than the previous cached 42s). This is acceptable per spec section 3.5.

If frame rate is fine but save-load exceeds 90 seconds, **stop and re-read spec section 6 — Risks**: the fallback is per-patch body flags, not reverting Phase 1.

- [ ] **Step 3: Document the result.**

Write a one-line note in `docs/superpowers/plans/2026-05-01-coop-patch-architecture-plan.md` under a new `## Phase 1 Verification` section:

```
- 2026-MM-DD: SP load OK, wall-clock <N>s, FPS stable at <X>.
```

- [ ] **Step 4: Commit playtest note.**

```
git add docs/superpowers/plans/2026-05-01-coop-patch-architecture-plan.md
git -C D:/sod_coop commit -m "test: Phase 1 manual playtest result"
```

---

## Phase 2 — Polling Infrastructure + First 3 Pollers

**Goal:** End of phase: the 3 currently-disabled patches `NewDoor.OnOpen/OnClose/SetLocked`, `LightController.SetOn`, and `CitizenOutfitController.SetCurrentOutfit` are **replaced** by pollers that produce identical sync behavior, with end-to-end coop verification.

### Task 2.1: Create the abstract StatePoller base

**Files:**
- Create: `src/Sync/Polling/StatePoller.cs`

- [ ] **Step 1: Create directory and file.**

Run: `mkdir -p src/Sync/Polling` then create `src/Sync/Polling/StatePoller.cs`.

- [ ] **Step 2: Write the base class.**

```csharp
using System.Collections.Generic;
using SoDCoop.Network;

namespace SoDCoop.Sync.Polling;

/// <summary>
/// Abstract base for state pollers. Each concrete poller is responsible
/// for ONE category of ambient world state (doors, lights, NPC outfits, …).
///
/// <para>Lifecycle:</para>
/// <list type="bullet">
///   <item>Plugin load → <see cref="WorldStatePollers.RegisterAll"/> creates
///         instances and registers them.</item>
///   <item>Every frame → <see cref="WorldStatePollers.TickAll"/> calls
///         <see cref="Tick"/>; each poller self-throttles by
///         <see cref="TickInterval"/>.</item>
///   <item>OnBeforeLoad → <see cref="ResetBaseline"/> clears
///         <see cref="_last"/> so the post-load tick re-reads the world fresh.</item>
///   <item>OnPlayerJoined (host) → <see cref="Capture"/> serializes the
///         current baseline into a snapshot blob (Phase 4).</item>
///   <item>Client receives snapshot → <see cref="ApplySnapshot"/> primes its
///         baseline so subsequent deltas merge cleanly.</item>
/// </list>
///
/// <para>Pollers run only on the host (gated inside <see cref="Tick"/>).
/// Clients receive deltas via dedicated packets and replay them through
/// the existing Broadcast* infrastructure with
/// <c>WorldStateSync.IsApplyingRemote = true</c>.</para>
/// </summary>
public abstract class StatePoller<TKey, TValue>
{
    /// <summary>Last known value per key. Cleared on
    /// <see cref="ResetBaseline"/>. Reused per tick — no allocations in
    /// the hot path.</summary>
    protected readonly Dictionary<TKey, TValue> _last = new();

    /// <summary>Scratch set used per tick to detect removals.
    /// Reused — caller must <c>Clear()</c> before each pass.</summary>
    private readonly HashSet<TKey> _seenThisTick = new();

    /// <summary>Time of next scheduled tick, in <c>Time.unscaledTime</c>.</summary>
    private float _nextTickAt;

    /// <summary>Seconds between ticks. Override per poller.</summary>
    public abstract float TickInterval { get; }

    /// <summary>Human-readable name for diagnostic logging.</summary>
    public abstract string Name { get; }

    /// <summary>Enumerate the current world state for this poller's
    /// category. Implementer reads SoD game classes (e.g.,
    /// <c>CityData.Instance.<...></c>). Must be allocation-free in steady
    /// state — return an iterable over a pre-existing collection if possible.</summary>
    public abstract IEnumerable<KeyValuePair<TKey, TValue>> EnumerateCurrent();

    /// <summary>Called once per tick AFTER <see cref="EnumerateCurrent"/>
    /// returns its first batch of changes for this tick. Implementer is
    /// expected to flush a single coalesced delta packet here. Empty
    /// changeset → implementer returns immediately.</summary>
    /// <param name="adds">Keys whose value newly appeared (not in
    /// <see cref="_last"/> last tick).</param>
    /// <param name="changes">Keys whose value changed compared to
    /// <see cref="_last"/>.</param>
    /// <param name="removes">Keys present last tick but absent now.</param>
    public abstract void FlushDelta(
        List<KeyValuePair<TKey, TValue>> adds,
        List<KeyValuePair<TKey, TValue>> changes,
        List<TKey> removes);

    /// <summary>True iff <paramref name="a"/> and <paramref name="b"/>
    /// represent the same logical state. Default: <see cref="object.Equals(object,object)"/>.
    /// Override for floating-point or struct values that need tolerance.</summary>
    protected virtual bool ValuesEqual(TValue a, TValue b)
        => EqualityComparer<TValue>.Default.Equals(a, b);

    // Reusable scratch lists — never grown beyond the highest-water-mark size,
    // never allocated inside the tick loop after the first frame.
    private readonly List<KeyValuePair<TKey, TValue>> _adds = new();
    private readonly List<KeyValuePair<TKey, TValue>> _changes = new();
    private readonly List<TKey> _removes = new();

    /// <summary>Master tick entry point. Called every frame from
    /// <see cref="WorldStatePollers.TickAll"/>; self-throttles by
    /// <see cref="TickInterval"/>. Skips if save-load is in flight or if
    /// we're not the host.</summary>
    public void Tick(float now)
    {
        if (now < _nextTickAt) return;
        _nextTickAt = now + TickInterval;

        if (!SyncGate.IsOpen) return;
        if (!NetworkManager.IsConnected) return;
        if (!NetworkManager.IsHost) return;

        try
        {
            DiffOnce();
        }
        catch (System.Exception ex)
        {
            Plugin.Log.LogWarning($"[{Name}] Tick: {ex.Message}");
        }
    }

    private void DiffOnce()
    {
        _adds.Clear();
        _changes.Clear();
        _removes.Clear();
        _seenThisTick.Clear();

        foreach (var kv in EnumerateCurrent())
        {
            _seenThisTick.Add(kv.Key);
            if (_last.TryGetValue(kv.Key, out var prev))
            {
                if (!ValuesEqual(prev, kv.Value))
                {
                    _changes.Add(kv);
                    _last[kv.Key] = kv.Value;
                }
            }
            else
            {
                _adds.Add(kv);
                _last[kv.Key] = kv.Value;
            }
        }

        // Detect removals: anything in _last not seen this tick.
        // Snapshot keys to avoid mutating dictionary during enumeration.
        foreach (var key in _last.Keys)
        {
            if (!_seenThisTick.Contains(key))
                _removes.Add(key);
        }
        for (int i = 0; i < _removes.Count; i++)
            _last.Remove(_removes[i]);

        if (_adds.Count == 0 && _changes.Count == 0 && _removes.Count == 0)
            return;

        FlushDelta(_adds, _changes, _removes);
    }

    /// <summary>Clears the baseline. Called on OnBeforeLoad. Next tick
    /// after the gate re-opens treats every current entry as new
    /// (broadcasts only when paired with state actually different from
    /// what clients have — which is true if they were also reset).</summary>
    public virtual void ResetBaseline()
    {
        _last.Clear();
    }
}
```

- [ ] **Step 3: Build.**

Run: `dotnet build -c Release`. Expected: 0 errors.

- [ ] **Step 4: Commit.**

```
git add src/Sync/Polling/StatePoller.cs
git -C D:/sod_coop commit -m "feat: StatePoller abstract base for ambient state sync

Generic diff-and-broadcast pattern reused by every concrete poller
(Door, Light, Outfit, Sleep, PhoneCall, Fingerprint, Footprint,
Spatter, Vmail, EvidenceNote). Self-throttling, host-gated,
allocation-free in steady state.

Part 2 of 5 in patch-architecture redesign."
```

### Task 2.2: Create the WorldStatePollers registry

**Files:**
- Create: `src/Sync/Polling/WorldStatePollers.cs`
- Modify: `src/Plugin.cs` (CoopUpdateRunner.Update + InitializeSystems)
- Modify: `src/Integration/SodCommonBridge.cs` (uncomment ResetAllBaselines call)

- [ ] **Step 1: Create `src/Sync/Polling/WorldStatePollers.cs`.**

```csharp
using System.Collections.Generic;
using UnityEngine;

namespace SoDCoop.Sync.Polling;

/// <summary>
/// Registry of all active world-state pollers. Owns the per-frame fan-out
/// from <c>CoopUpdateRunner.Update</c> and the bulk baseline-reset on
/// save-load. Plugin.Load() calls <see cref="RegisterAll"/> once.
/// </summary>
public static class WorldStatePollers
{
    private static readonly List<IPollerHandle> _pollers = new();
    private static bool _registered;

    /// <summary>Register every concrete poller. Called once from
    /// <c>Plugin.InitializeSystems</c>.</summary>
    public static void RegisterAll()
    {
        if (_registered) return;
        _registered = true;

        Add(new DoorStatePoller());
        Add(new LightStatePoller());
        Add(new OutfitStatePoller());
        // Phase 3 will append: Sleep, PhoneCall, Fingerprint, Footprint,
        // Spatter, Vmail, EvidenceNote.

        Plugin.Log.LogInfo($"[WorldStatePollers] registered {_pollers.Count} pollers.");
    }

    private static void Add<TK, TV>(StatePoller<TK, TV> poller)
    {
        _pollers.Add(new PollerHandle<TK, TV>(poller));
    }

    /// <summary>Tick every registered poller. Cheap if none are due —
    /// they all self-check elapsed time. Called every frame from
    /// <c>CoopUpdateRunner.Update</c>.</summary>
    public static void TickAll(float now)
    {
        for (int i = 0; i < _pollers.Count; i++)
            _pollers[i].Tick(now);
    }

    /// <summary>Clear every poller's baseline. Called on
    /// <c>SodCommonBridge.OnBeforeLoad</c> so the post-load tick re-reads
    /// the world from scratch.</summary>
    public static void ResetAllBaselines()
    {
        for (int i = 0; i < _pollers.Count; i++)
            _pollers[i].ResetBaseline();
    }

    // Type-erasing wrapper so the list can hold pollers of mixed generic args.
    private interface IPollerHandle
    {
        void Tick(float now);
        void ResetBaseline();
    }

    private sealed class PollerHandle<TK, TV> : IPollerHandle
    {
        private readonly StatePoller<TK, TV> _p;
        public PollerHandle(StatePoller<TK, TV> p) { _p = p; }
        public void Tick(float now) => _p.Tick(now);
        public void ResetBaseline() => _p.ResetBaseline();
    }
}
```

- [ ] **Step 2: Add `WorldStatePollers.RegisterAll()` to `Plugin.InitializeSystems()`.**

In `src/Plugin.cs`, find the body of `InitializeSystems()` and add **after** `WorldReadyGate.Initialize();` and **before** `RemotePlayerManager.Initialize();`:

```csharp
        Log.LogInfo("Registering world-state pollers...");
        SoDCoop.Sync.Polling.WorldStatePollers.RegisterAll();
```

- [ ] **Step 3: Add `WorldStatePollers.TickAll` to `CoopUpdateRunner.Update`.**

In `src/Plugin.cs`, find the `void Update()` method of `CoopUpdateRunner`. Add a single line, **before** the existing `WorldReadyGate.Tick();` call:

```csharp
            SoDCoop.Sync.Polling.WorldStatePollers.TickAll(Time.unscaledTime);
```

- [ ] **Step 4: Uncomment the deferred `ResetAllBaselines()` in `SodCommonBridge.cs`.**

In `src/Integration/SodCommonBridge.cs`, find the `// TODO Phase 2: uncomment …` line you added in Task 1.2. Replace the commented line with the active call. Final form of that section:

```csharp
                    SoDCoop.Sync.SyncGate.Close();
                    SoDCoop.Sync.Polling.WorldStatePollers.ResetAllBaselines();
                    Plugin.Log.LogInfo($"[SODCommon] OnBeforeLoad: {args?.FilePath} — timer started, sync gate closed");
```

- [ ] **Step 5: This task references `DoorStatePoller`, `LightStatePoller`, `OutfitStatePoller` which don't exist yet.**

Don't build yet — Task 2.3-2.5 create those. Skip the build/commit until Task 2.5.

### Task 2.3: Implement DoorStatePoller

**Files:**
- Create: `src/Sync/Polling/DoorStatePoller.cs`

**Prerequisite reading:** Open the existing `src/Sync/WorldStateSync.cs` (already in the codebase) — confirm the signatures of `BroadcastDoorState(int interactableId, bool isClosed)` and `BroadcastDoorLockState(int interactableId, bool isLocked, bool playSound)`. The poller will call these directly, so that no new packet type is needed for Phase 2.

**Game-API source for enumeration:** Doors are reachable via `CityData.Instance.interactableDirectory`, which is an `Il2CppList<Interactable>`. Each `Interactable` has a `door` property (typed `NewDoor`) that is non-null when the interactable is a door. The door's open/closed state is `Interactable.sw0` (the "switch zero" flag SoD uses) AND/OR `NewDoor.<some closed/open field>`. Cross-check with the disabled `NewDoor_OnOpen_Patch.Postfix` body in `src/Patches/GamePatches.cs:30-45` — that patch uses `__instance.doorInteractable.id` for the network id and broadcasts `isClosed: false` when `OnOpen` was called. The patch was working before disable, so the same fields are correct here.

If `Interactable.sw0` proves to not match the open/closed semantics, fall back to enumerating `NewDoor` instances via `UnityEngine.Object.FindObjectsOfType<NewDoor>(false)` and reading `NewDoor.<isClosed-field>`. Confirm the field name by reading the SoD-decompiled `NewDoor.cs` (use dnSpy on `Shadows of Doubt_Data\il2cpp_data\Metadata\global-metadata.dat` if needed — or simply search for `doorInteractable` in the existing `GamePatches.cs` for clues; the patch wrote to a property named the same way SoD reads it).

- [ ] **Step 1: Create the file.**

```csharp
using System.Collections.Generic;
using SoDCoop.Network;

namespace SoDCoop.Sync.Polling;

/// <summary>
/// Polls every Interactable that hosts a NewDoor and broadcasts open/close +
/// locked diffs. Replaces the disabled <c>NewDoor.OnOpen / OnClose / SetLocked</c>
/// Harmony patches.
/// </summary>
public sealed class DoorStatePoller : StatePoller<int, DoorStatePoller.State>
{
    public override float TickInterval => 0.1f;   // 10 Hz
    public override string Name => "DoorStatePoller";

    /// <summary>(closed, locked) flags packed into one struct.</summary>
    public readonly struct State
    {
        public readonly bool Closed;
        public readonly bool Locked;
        public State(bool closed, bool locked) { Closed = closed; Locked = locked; }
        public override bool Equals(object obj) => obj is State s && s.Closed == Closed && s.Locked == Locked;
        public override int GetHashCode() => (Closed ? 1 : 0) | (Locked ? 2 : 0);
    }

    public override IEnumerable<KeyValuePair<int, State>> EnumerateCurrent()
    {
        var city = global::CityData.Instance;
        if (city == null) yield break;
        var dir = city.interactableDirectory;
        if (dir == null) yield break;
        for (int i = 0; i < dir.Count; i++)
        {
            var inter = dir[i];
            if (inter == null) continue;
            var door = inter.door;
            if (door == null) continue;
            // SoD stores closed/open in Interactable.sw0 (true == closed, false == open).
            // If this proves wrong empirically, swap to the NewDoor-side field.
            bool closed = inter.sw0;
            bool locked = inter.locked;
            yield return new KeyValuePair<int, State>(inter.id, new State(closed, locked));
        }
    }

    public override void FlushDelta(
        List<KeyValuePair<int, State>> adds,
        List<KeyValuePair<int, State>> changes,
        List<int> removes)
    {
        // adds and changes both broadcast through the same path; removes ignored
        // (a door cannot be removed from the city at runtime).
        for (int i = 0; i < adds.Count; i++)
        {
            var kv = adds[i];
            // First time we see a door — only broadcast if its state diverges
            // from the implicit default (closed=true, locked=false). Otherwise
            // we'd broadcast every door once at session start.
            if (kv.Value.Closed && !kv.Value.Locked) continue;
            WorldStateSync.BroadcastDoorState(kv.Key, kv.Value.Closed);
            if (kv.Value.Locked)
                WorldStateSync.BroadcastDoorLockState(kv.Key, isLocked: true, playSound: false);
        }
        for (int i = 0; i < changes.Count; i++)
        {
            var kv = changes[i];
            // We can't tell whether closed OR locked changed without remembering
            // both prev and curr. Broadcast both — receivers no-op if value
            // matches their state.
            WorldStateSync.BroadcastDoorState(kv.Key, kv.Value.Closed);
            WorldStateSync.BroadcastDoorLockState(kv.Key, kv.Value.Locked, playSound: false);
        }
    }
}
```

- [ ] **Step 2: Don't build yet — needs Light + Outfit.**

### Task 2.4: Implement LightStatePoller

**Files:**
- Create: `src/Sync/Polling/LightStatePoller.cs`

**Prerequisite reading:** Existing `WorldStateSync.BroadcastLightState(int interactableId, bool isOn)`. The disabled `LightController_SetOn_Patch` (in `GamePatches.cs:99-150` ish) reads `__instance.interactable.id` and the `val` argument. So per-Interactable: `inter.lightController` non-null indicates a light; `inter.lightController.lightOn` is the on/off state.

- [ ] **Step 1: Create the file.**

```csharp
using System.Collections.Generic;
using SoDCoop.Network;

namespace SoDCoop.Sync.Polling;

/// <summary>
/// Polls every Interactable that hosts a LightController and broadcasts on/off diffs.
/// Replaces the disabled <c>LightController.SetOn</c> Harmony patch.
/// </summary>
public sealed class LightStatePoller : StatePoller<int, bool>
{
    public override float TickInterval => 0.1f;   // 10 Hz
    public override string Name => "LightStatePoller";

    public override IEnumerable<KeyValuePair<int, bool>> EnumerateCurrent()
    {
        var city = global::CityData.Instance;
        if (city == null) yield break;
        var dir = city.interactableDirectory;
        if (dir == null) yield break;
        for (int i = 0; i < dir.Count; i++)
        {
            var inter = dir[i];
            if (inter == null) continue;
            var lc = inter.lightController;
            if (lc == null) continue;
            yield return new KeyValuePair<int, bool>(inter.id, lc.lightOn);
        }
    }

    public override void FlushDelta(
        List<KeyValuePair<int, bool>> adds,
        List<KeyValuePair<int, bool>> changes,
        List<int> removes)
    {
        // First-sight adds: only broadcast if light is ON (default off is implicit).
        for (int i = 0; i < adds.Count; i++)
            if (adds[i].Value)
                WorldStateSync.BroadcastLightState(adds[i].Key, isOn: true);

        for (int i = 0; i < changes.Count; i++)
            WorldStateSync.BroadcastLightState(changes[i].Key, changes[i].Value);
    }
}
```

- [ ] **Step 2: Don't build yet — needs Outfit.**

### Task 2.5: Implement OutfitStatePoller

**Files:**
- Create: `src/Sync/Polling/OutfitStatePoller.cs`

**Prerequisite reading:** Existing `PlayerOutfitSync.BroadcastNpcOutfit(int humanId, byte category)`. NPC outfits live on `Citizen.currentOutfitController.currentCategory` (an enum cast to int → byte). Each citizen has `humanID`. Source: iterate `CityData.Instance.citizenDictionary.Values` and skip `Citizen.isPlayer == true` (those are local players, handled by `PlayerOutfitSync` already).

- [ ] **Step 1: Create the file.**

```csharp
using System.Collections.Generic;
using SoDCoop.Network;

namespace SoDCoop.Sync.Polling;

/// <summary>
/// Polls citizen outfit category and broadcasts diffs. Replaces the
/// disabled <c>CitizenOutfitController.SetCurrentOutfit</c> Harmony patch.
/// </summary>
public sealed class OutfitStatePoller : StatePoller<int, byte>
{
    public override float TickInterval => 0.2f;   // 5 Hz
    public override string Name => "OutfitStatePoller";

    public override IEnumerable<KeyValuePair<int, byte>> EnumerateCurrent()
    {
        var city = global::CityData.Instance;
        if (city?.citizenDictionary == null) yield break;
        foreach (var pair in city.citizenDictionary)
        {
            var c = pair.Value;
            if (c == null) continue;
            if (c.isPlayer) continue;     // local-player outfit handled separately
            var ctl = c.currentOutfitController;
            if (ctl == null) continue;
            byte cat = (byte)ctl.currentCategory;   // SoD enum → byte
            yield return new KeyValuePair<int, byte>(c.humanID, cat);
        }
    }

    public override void FlushDelta(
        List<KeyValuePair<int, byte>> adds,
        List<KeyValuePair<int, byte>> changes,
        List<int> removes)
    {
        // Broadcast every add — the default outfit is per-NPC and clients
        // can't infer it; safer to push the full state up-front than to
        // skip and have late-game outfits diverge silently.
        for (int i = 0; i < adds.Count; i++)
            PlayerOutfitSync.BroadcastNpcOutfit(adds[i].Key, adds[i].Value);

        for (int i = 0; i < changes.Count; i++)
            PlayerOutfitSync.BroadcastNpcOutfit(changes[i].Key, changes[i].Value);
    }
}
```

- [ ] **Step 2: Build.**

Run: `dotnet build -c Release`. Expected: 0 errors.

If the build fails on `inter.sw0`, `inter.locked`, `inter.lightController.lightOn`, `inter.door`, `c.currentOutfitController.currentCategory`, OR `c.humanID` — those are SoD-side IL2CPP fields whose names I inferred from the disabled patches. Fix by:
  1. Open `src/Patches/GamePatches.cs` and re-read the disabled patch body for the same method (e.g., `NewDoor_OnOpen_Patch` for the door fields).
  2. Adjust the field name to match what the patch used.
  3. If still failing, decompile the SoD class via dnSpy and copy the exact field name.

- [ ] **Step 3: Commit.**

```
git add src/Sync/Polling/WorldStatePollers.cs \
        src/Sync/Polling/DoorStatePoller.cs \
        src/Sync/Polling/LightStatePoller.cs \
        src/Sync/Polling/OutfitStatePoller.cs \
        src/Plugin.cs \
        src/Integration/SodCommonBridge.cs
git -C D:/sod_coop commit -m "feat: polling subsystem + Door/Light/Outfit pollers

Replaces the currently-disabled NewDoor.OnOpen/OnClose/SetLocked,
LightController.SetOn, and CitizenOutfitController.SetCurrentOutfit
Harmony patches. Pollers run host-side at 10/10/5 Hz, diff against
last-known state, broadcast through existing WorldStateSync /
PlayerOutfitSync APIs.

Part 2 of 5 in patch-architecture redesign."
```

### Task 2.6: Phase 2 manual playtest

**Files:** none.

- [ ] **Step 1: Confirm the 3 target patches are still disabled.**

Run: `grep -n "DISABLED hot-path: NPC door pass\|DISABLED hot-path: ambient light state changes\|DISABLED hot-path: NPC scheduled outfit change" src/Patches/GamePatches.cs`. Expect 3 matches. If any match is missing, re-disable that patch (the polling alternative is now wired).

- [ ] **Step 2: Launch a 2-PC coop session.**

PC A hosts. PC B joins. Both load the same save.

- [ ] **Step 3: Door round-trip test.**

PC A: walk to a closed door, open it.
PC B: should see the door swing open within 200ms (1 poller tick at 10 Hz + network RTT).
Then PC A closes it. PC B sees it close within 200ms.

If door does NOT cross the wire:
  - Check PC A's BepInEx log for `[DoorStatePoller] Tick:` exception lines.
  - If `inter.sw0` was wrong, the door state never changes in the diff. Confirm via host-side log: temporarily add `Plugin.Log.LogInfo($"door {inter.id} closed={inter.sw0}")` inside `EnumerateCurrent` (remove before commit). If always-true, swap to `__instance.<correct field>`.

- [ ] **Step 4: Light round-trip test.**

PC A flips a wall switch. PC B sees the light state change within 200ms.

- [ ] **Step 5: NPC outfit round-trip test.**

Wait for an NPC scheduled shift change (in-game time crossing 7am, 9am, 5pm — outfits flip). PC B should see the same NPC change clothes within 1 second. (5 Hz tick + network = up to 400ms; allow 1s buffer for shift-change timing variance.)

- [ ] **Step 6: Document results.**

Append to `docs/superpowers/plans/2026-05-01-coop-patch-architecture-plan.md` under `## Phase 2 Verification`:

```
- 2026-MM-DD: Door OK (<X>ms latency), Light OK, Outfit OK.
```

- [ ] **Step 7: Commit playtest note.**

```
git add docs/superpowers/plans/2026-05-01-coop-patch-architecture-plan.md
git -C D:/sod_coop commit -m "test: Phase 2 manual playtest result"
```

---

## Phase 3 — Remaining 7 Pollers

**Goal:** end of phase: all 17 ambient patches from spec section 3.3 (15 disabled + Vmail + EvidenceNote) are functionally replaced. Two pollers (Vmail, EvidenceNote) shadow STILL-active patches at this stage; their `[HarmonyPatch]` attributes are removed in Phase 5 — keeping them through Phase 3 is intentional so a regression in the poller during testing does not lose features.

### Task 3.1: Implement SleepStatePoller

**Files:**
- Create: `src/Sync/Polling/SleepStatePoller.cs`
- Modify: `src/Sync/PlayerStateSync.cs` (if NPC broadcast helpers don't exist)
- Modify: `src/Network/Packets.cs` (new `PacketType.NpcSleepState = 120`)
- Modify: `src/Sync/SyncManager.cs` (route inbound packet)

**Prerequisite reading:** `Actor.isInBed`, `Actor.isAsleep` are existing fields used by the disabled `Actor.SetInBed / GoToSleep / WakeUp` patches in `GamePatches.cs:1412-1487`. `PlayerStateSync.BroadcastInBed` and `BroadcastAsleep` already exist but are scoped to the local player. We need NPC variants.

- [ ] **Step 1: Add `PacketType.NpcSleepState = 120` in `src/Network/Packets.cs`.**

Open the file, find the highest existing packet ID (currently `PlayerAppearance = 114`). Add a new region or append:

```csharp
    /// <summary>
    /// Coalesced batch: NPC sleep/in-bed flag deltas. Sent by host every
    /// 200ms when any NPC's sleep state changed.
    /// </summary>
    NpcSleepState = 120,
```

- [ ] **Step 2: Define the packet struct in the same file (after the enum).**

Search for `public class WeatherStatePacket` or similar to see the existing pattern. Add at the bottom:

```csharp
/// <summary>
/// Batched NPC sleep state deltas. One packet per OutfitStatePoller tick.
/// </summary>
public class NpcSleepBatchPacket
{
    public List<Entry> Entries = new();

    public struct Entry
    {
        public int HumanId;
        public bool InBed;
        public bool Asleep;
    }

    public void Serialize(NetDataWriter w)
    {
        w.Put((ushort)Entries.Count);
        for (int i = 0; i < Entries.Count; i++)
        {
            var e = Entries[i];
            w.Put(e.HumanId);
            w.Put(e.InBed);
            w.Put(e.Asleep);
        }
    }

    public void Deserialize(NetPacketReader r)
    {
        int n = r.GetUShort();
        Entries.Clear();
        for (int i = 0; i < n; i++)
            Entries.Add(new Entry { HumanId = r.GetInt(), InBed = r.GetBool(), Asleep = r.GetBool() });
    }
}
```

If `using System.Collections.Generic;` is not at the top of `Packets.cs`, add it.
If `using LiteNetLib.Utils;` is not at the top, add it.

- [ ] **Step 3: Add NPC broadcast + apply helpers to `src/Sync/PlayerStateSync.cs`.**

Add at the bottom of the class:

```csharp
    private static readonly NetDataWriter _npcWriter = new();

    /// <summary>Host-only. Send a batch of NPC sleep state deltas.
    /// Called by SleepStatePoller.</summary>
    public static void BroadcastNpcSleepBatch(List<NpcSleepBatchPacket.Entry> entries)
    {
        if (!NetworkManager.IsConnected) return;
        if (!NetworkManager.IsHost) return;
        if (entries.Count == 0) return;

        try
        {
            var pkt = new NpcSleepBatchPacket { Entries = entries };
            _npcWriter.Reset();
            pkt.Serialize(_npcWriter);
            NetworkManager.SendToAll(PacketType.NpcSleepState, _npcWriter, DeliveryMethod.ReliableOrdered);
        }
        catch (System.Exception ex) { Plugin.Log.LogWarning($"BroadcastNpcSleepBatch: {ex.Message}"); }
    }

    /// <summary>Client-side handler for an inbound NPC sleep batch.</summary>
    public static void ApplyNpcSleepBatch(NetPacketReader reader)
    {
        var pkt = new NpcSleepBatchPacket();
        pkt.Deserialize(reader);
        var city = global::CityData.Instance;
        if (city?.citizenDictionary == null) return;

        for (int i = 0; i < pkt.Entries.Count; i++)
        {
            var e = pkt.Entries[i];
            if (!city.citizenDictionary.TryGetValue(e.HumanId, out var c) || c == null) continue;
            try
            {
                // Apply through the SoD methods directly. The local Actor
                // patches were disabled in commit 0a45bbc, so there is no
                // re-entrancy risk — but if Phase 5 turns out to need them
                // re-attached, gate this with a local IsApplyingRemote flag.
                if (c.isInBed != e.InBed) c.SetInBed(e.InBed, isLowBed: false);
                if (c.isAsleep != e.Asleep)
                {
                    if (e.Asleep) c.GoToSleep(); else c.WakeUp();
                }
            }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"ApplyNpcSleepBatch entry {e.HumanId}: {ex.Message}"); }
        }
    }
```

If the code references `NpcSleepBatchPacket`, ensure the `using SoDCoop.Network;` import is at the top of `PlayerStateSync.cs`.

- [ ] **Step 4: Wire inbound dispatch in `src/Sync/SyncManager.cs`.**

The dispatch in `OnPacketReceived(PacketType type, NetPacketReader reader, int senderId)` is a long `if / else if` chain (not a `switch`). Find a logical home for the new branch — placing it near the other `PlayerStateSync` cases (search for `PacketType.PlayerInBed` to find the cluster). Insert **as a new branch**:

```csharp
            // NPC sleep state batch (120) — host → clients.
            else if (type == PacketType.NpcSleepState)
            {
                PlayerStateSync.ApplyNpcSleepBatch(reader);
            }
```

Place this BEFORE any catch-all range checks like `(int)type >= 10 && (int)type <= 29` to avoid being shadowed.

- [ ] **Step 5: Create `src/Sync/Polling/SleepStatePoller.cs`.**

```csharp
using System.Collections.Generic;
using SoDCoop.Network;

namespace SoDCoop.Sync.Polling;

/// <summary>
/// Polls citizen sleep flags. Replaces the disabled
/// <c>Actor.SetInBed / GoToSleep / WakeUp</c> Harmony patches.
/// </summary>
public sealed class SleepStatePoller : StatePoller<int, SleepStatePoller.State>
{
    public override float TickInterval => 0.2f;   // 5 Hz
    public override string Name => "SleepStatePoller";

    public readonly struct State
    {
        public readonly bool InBed;
        public readonly bool Asleep;
        public State(bool inBed, bool asleep) { InBed = inBed; Asleep = asleep; }
        public override bool Equals(object o) => o is State s && s.InBed == InBed && s.Asleep == Asleep;
        public override int GetHashCode() => (InBed ? 1 : 0) | (Asleep ? 2 : 0);
    }

    private readonly List<NpcSleepBatchPacket.Entry> _batch = new();

    public override IEnumerable<KeyValuePair<int, State>> EnumerateCurrent()
    {
        var city = global::CityData.Instance;
        if (city?.citizenDictionary == null) yield break;
        foreach (var pair in city.citizenDictionary)
        {
            var c = pair.Value;
            if (c == null || c.isPlayer) continue;
            yield return new KeyValuePair<int, State>(c.humanID, new State(c.isInBed, c.isAsleep));
        }
    }

    public override void FlushDelta(
        List<KeyValuePair<int, State>> adds,
        List<KeyValuePair<int, State>> changes,
        List<int> removes)
    {
        _batch.Clear();
        // First sight: only broadcast if the NPC starts in bed or asleep.
        for (int i = 0; i < adds.Count; i++)
        {
            var kv = adds[i];
            if (!kv.Value.InBed && !kv.Value.Asleep) continue;
            _batch.Add(new NpcSleepBatchPacket.Entry { HumanId = kv.Key, InBed = kv.Value.InBed, Asleep = kv.Value.Asleep });
        }
        for (int i = 0; i < changes.Count; i++)
        {
            var kv = changes[i];
            _batch.Add(new NpcSleepBatchPacket.Entry { HumanId = kv.Key, InBed = kv.Value.InBed, Asleep = kv.Value.Asleep });
        }
        if (_batch.Count > 0)
            PlayerStateSync.BroadcastNpcSleepBatch(_batch);
    }
}
```

- [ ] **Step 6: Register in `WorldStatePollers.RegisterAll()`.**

Open `src/Sync/Polling/WorldStatePollers.cs` and add **after** the existing `Add(new OutfitStatePoller());`:

```csharp
        Add(new SleepStatePoller());
```

- [ ] **Step 7: Build and commit.**

```
dotnet build -c Release
```
Expected: 0 errors. Then:
```
git add src/Sync/Polling/SleepStatePoller.cs \
        src/Sync/Polling/WorldStatePollers.cs \
        src/Sync/PlayerStateSync.cs \
        src/Sync/SyncManager.cs \
        src/Network/Packets.cs
git -C D:/sod_coop commit -m "feat: SleepStatePoller for NPC bed/sleep state

Replaces the disabled Actor.SetInBed / GoToSleep / WakeUp patches.
Adds PacketType.NpcSleepState (120) and NpcSleepBatchPacket.

Part 3 of 5."
```

- [ ] **Step 8: Manual playtest.**

In a 2-PC session, advance time on the host until evening. NPCs go to bed. PC B should see the NPCs lying in beds + sleeping animations within 1s.

### Task 3.2: Implement PhoneCallPoller

**Files:**
- Create: `src/Sync/Polling/PhoneCallPoller.cs`
- Modify: `src/Network/Packets.cs` (`PacketType.PhoneCallBatch = 121`)
- Modify: `src/Sync/PhoneSync.cs` (add `BroadcastPhoneBatch` + `ApplyPhoneBatch` helpers)
- Modify: `src/Sync/SyncManager.cs` (route inbound)
- Modify: `src/Sync/Polling/WorldStatePollers.cs` (register)

**Prerequisite reading:** `PhoneSync.cs:39-42` already has `BroadcastCallStart(callerHumanId, callerName)` and `BroadcastCallEnd(callerHumanId, callerName)`. Active calls live on `Toolbox.Instance.allTelephoneControllers` → each `TelephoneController.activeCalls` is an `Il2CppList<…>`. The disabled `TelephoneController_AddActiveCall_Patch` (in `GamePatches.cs:570-624`) shows what fields to read for caller id + name.

- [ ] **Step 1: Add `PacketType.PhoneCallBatch = 121` and the packet class to `Packets.cs`.**

```csharp
    PhoneCallBatch = 121,
```

```csharp
public class PhoneCallBatchPacket
{
    public List<Entry> Entries = new();

    public struct Entry
    {
        public int CallerHumanId;
        public string CallerName;     // empty string == call ended
        public bool Active;
    }

    public void Serialize(NetDataWriter w)
    {
        w.Put((ushort)Entries.Count);
        for (int i = 0; i < Entries.Count; i++)
        {
            var e = Entries[i];
            w.Put(e.CallerHumanId);
            w.Put(e.CallerName ?? "");
            w.Put(e.Active);
        }
    }

    public void Deserialize(NetPacketReader r)
    {
        int n = r.GetUShort();
        Entries.Clear();
        for (int i = 0; i < n; i++)
            Entries.Add(new Entry { CallerHumanId = r.GetInt(), CallerName = r.GetString(), Active = r.GetBool() });
    }
}
```

- [ ] **Step 2: Add helpers to `PhoneSync.cs`.**

```csharp
    private static readonly NetDataWriter _phoneBatchWriter = new();

    public static void BroadcastPhoneBatch(List<PhoneCallBatchPacket.Entry> entries)
    {
        if (!NetworkManager.IsConnected || !NetworkManager.IsHost || entries.Count == 0) return;
        try
        {
            var pkt = new PhoneCallBatchPacket { Entries = entries };
            _phoneBatchWriter.Reset();
            pkt.Serialize(_phoneBatchWriter);
            NetworkManager.SendToAll(PacketType.PhoneCallBatch, _phoneBatchWriter, DeliveryMethod.ReliableOrdered);
        }
        catch (System.Exception ex) { Plugin.Log.LogWarning($"BroadcastPhoneBatch: {ex.Message}"); }
    }

    public static void ApplyPhoneBatch(NetPacketReader reader)
    {
        var pkt = new PhoneCallBatchPacket();
        pkt.Deserialize(reader);
        for (int i = 0; i < pkt.Entries.Count; i++)
        {
            var e = pkt.Entries[i];
            try
            {
                // Reuse the existing banner code path. We deliberately do NOT
                // call BroadcastCallStart/End — those are host-only and would
                // no-op on the client, swallowing the banner.
                var nb = new PhoneCallNotifyPacket
                {
                    CallerHumanId = e.CallerHumanId,
                    CallerName    = e.CallerName ?? "",
                    IsStarting    = e.Active,
                    CalleeName    = "",
                };
                ShowBanner(nb);
            }
            catch (System.Exception ex) { Plugin.Log.LogWarning($"ApplyPhoneBatch entry {e.CallerHumanId}: {ex.Message}"); }
        }
    }
```

Make sure `private static void ShowBanner(PhoneCallNotifyPacket packet)` is changed to `public` (or `internal`) so `ApplyPhoneBatch` can reach it. If you prefer to keep `ShowBanner` private, factor the banner-show logic into a new `public static void ShowIncomingCallBanner(int humanId, string name, bool isStarting)` and call that from both `ShowBanner` and `ApplyPhoneBatch`.

- [ ] **Step 3: Wire inbound in `SyncManager.cs` (if/else if chain — see Task 3.1 step 4 for placement guidance).**

```csharp
            // Phone call batch (121) — host → clients, NPC phone activity.
            else if (type == PacketType.PhoneCallBatch)
            {
                PhoneSync.ApplyPhoneBatch(reader);
            }
```

- [ ] **Step 4: Create the poller.**

`src/Sync/Polling/PhoneCallPoller.cs`:

```csharp
using System.Collections.Generic;
using SoDCoop.Network;

namespace SoDCoop.Sync.Polling;

/// <summary>
/// Polls active phone calls across all TelephoneControllers in the city.
/// Replaces the disabled <c>TelephoneController.AddActiveCall / RemoveActiveCall</c>
/// Harmony patches.
/// </summary>
public sealed class PhoneCallPoller : StatePoller<int, string>
{
    public override float TickInterval => 0.2f;   // 5 Hz
    public override string Name => "PhoneCallPoller";

    private readonly List<PhoneCallBatchPacket.Entry> _batch = new();

    public override IEnumerable<KeyValuePair<int, string>> EnumerateCurrent()
    {
        var tb = global::Toolbox.Instance;
        if (tb == null) yield break;
        var phones = tb.allTelephoneControllers;
        if (phones == null) yield break;
        for (int i = 0; i < phones.Count; i++)
        {
            var p = phones[i];
            if (p == null) continue;
            var calls = p.activeCalls;
            if (calls == null) continue;
            for (int j = 0; j < calls.Count; j++)
            {
                var call = calls[j];
                if (call == null) continue;
                // The disabled patch (GamePatches.cs around line 590) shows the
                // caller is reachable via call.<caller field>. Use the same field name.
                var caller = call.caller;
                if (caller == null) continue;
                yield return new KeyValuePair<int, string>(caller.humanID, caller.GetCitizenName());
            }
        }
    }

    public override void FlushDelta(
        List<KeyValuePair<int, string>> adds,
        List<KeyValuePair<int, string>> changes,
        List<int> removes)
    {
        _batch.Clear();
        for (int i = 0; i < adds.Count; i++)
            _batch.Add(new PhoneCallBatchPacket.Entry { CallerHumanId = adds[i].Key, CallerName = adds[i].Value, Active = true });
        for (int i = 0; i < changes.Count; i++)
            _batch.Add(new PhoneCallBatchPacket.Entry { CallerHumanId = changes[i].Key, CallerName = changes[i].Value, Active = true });
        for (int i = 0; i < removes.Count; i++)
            _batch.Add(new PhoneCallBatchPacket.Entry { CallerHumanId = removes[i], CallerName = "", Active = false });
        if (_batch.Count > 0)
            PhoneSync.BroadcastPhoneBatch(_batch);
    }
}
```

- [ ] **Step 5: Register, build, commit, playtest.**

In `WorldStatePollers.cs` add `Add(new PhoneCallPoller());`.

Build. Commit:
```
git -C D:/sod_coop commit -m "feat: PhoneCallPoller for NPC phone activity

Replaces the disabled TelephoneController.AddActiveCall / RemoveActiveCall
patches. Adds PacketType.PhoneCallBatch (121).

Part 3 of 5."
```

Playtest: in a 2-PC session, wait until an NPC makes a call. PC B should see the same caller ID notification within 200ms.

### Task 3.3: Implement FingerprintPoller

**Files:**
- Create: `src/Sync/Polling/FingerprintPoller.cs`
- Modify: `src/Sync/Polling/WorldStatePollers.cs`

**Prerequisite reading:** `FingerprintSync.BroadcastAdd(int interactableId, int humanId, byte life)` exists. Each `Interactable.fingerprints` is `Il2CppList<Fingerprint>` with `Fingerprint.print` (string id of the citizen) and `Fingerprint.life` (byte 0-255). Diff is by `(interactableId → count)`. On count increase, read entries `[count - delta, count)` from `Interactable.fingerprints` and broadcast each.

- [ ] **Step 1: Create the file.**

```csharp
using System.Collections.Generic;
using SoDCoop.Network;

namespace SoDCoop.Sync.Polling;

/// <summary>
/// Polls per-Interactable fingerprint counts. On count increase, broadcasts
/// the newly-appended entries. On count decrease, broadcasts a clear.
/// Replaces the disabled <c>Interactable.AddNewDynamicFingerprint /
/// RemoveManuallyCreatedFingerprints</c> Harmony patches.
/// </summary>
public sealed class FingerprintPoller : StatePoller<int, int>
{
    public override float TickInterval => 0.2f;   // 5 Hz
    public override string Name => "FingerprintPoller";

    public override IEnumerable<KeyValuePair<int, int>> EnumerateCurrent()
    {
        var city = global::CityData.Instance;
        if (city?.interactableDirectory == null) yield break;
        var dir = city.interactableDirectory;
        for (int i = 0; i < dir.Count; i++)
        {
            var inter = dir[i];
            if (inter == null) continue;
            var fps = inter.fingerprints;
            if (fps == null) continue;
            int n = fps.Count;
            if (n == 0)
            {
                // Don't yield zero-count entries — they bloat the baseline
                // dictionary with O(N) entries. Treat absence-from-dictionary
                // as count==0.
                continue;
            }
            yield return new KeyValuePair<int, int>(inter.id, n);
        }
    }

    public override void FlushDelta(
        List<KeyValuePair<int, int>> adds,
        List<KeyValuePair<int, int>> changes,
        List<int> removes)
    {
        // adds = first time we saw fingerprints on this interactable — broadcast all of them
        for (int i = 0; i < adds.Count; i++)
            BroadcastTail(adds[i].Key, fromIndex: 0, toCount: adds[i].Value);

        // changes = count went up OR down on existing interactable
        for (int i = 0; i < changes.Count; i++)
        {
            int id = changes[i].Key;
            int newCount = changes[i].Value;
            int oldCount;
            // _last has already been overwritten with newCount by the time we're called.
            // We need the previous count: it was the third arg before overwrite. Workaround:
            // store previous in our own shadow dictionary. To keep this simple we just
            // re-broadcast every fingerprint from index 0 — it's idempotent on the
            // receiving FingerprintSync (life-clamp + dedup by (interactable, citizen)).
            BroadcastTail(id, fromIndex: 0, toCount: newCount);
        }

        // removes = list went to zero on a previously-tracked interactable
        for (int i = 0; i < removes.Count; i++)
            FingerprintSync.BroadcastClearManual(removes[i]);
    }

    private static void BroadcastTail(int interactableId, int fromIndex, int toCount)
    {
        if (toCount <= fromIndex) return;
        var inter = LookupInteractable(interactableId);
        if (inter == null) return;
        var fps = inter.fingerprints;
        if (fps == null) return;
        for (int i = fromIndex; i < toCount && i < fps.Count; i++)
        {
            var fp = fps[i];
            if (fp == null) continue;
            int humanId = ResolveHumanId(fp.print);
            if (humanId == 0) continue;
            FingerprintSync.BroadcastAdd(interactableId, humanId, fp.life);
        }
    }

    private static global::Interactable LookupInteractable(int id)
    {
        var dir = global::CityData.Instance?.interactableDirectory;
        if (dir == null) return null;
        for (int i = 0; i < dir.Count; i++)
            if (dir[i] != null && dir[i].id == id) return dir[i];
        return null;
    }

    private static int ResolveHumanId(string fingerprintIdString)
    {
        // SoD encodes "<humanID>" as the fingerprint.print string.
        if (string.IsNullOrEmpty(fingerprintIdString)) return 0;
        if (int.TryParse(fingerprintIdString, out var n)) return n;
        // Fall back to lookup by name in citizenDictionary if needed.
        return 0;
    }
}
```

- [ ] **Step 2: Register, build, commit, playtest.**

Register in `WorldStatePollers.RegisterAll()`. Build clean. Commit:

```
git -C D:/sod_coop commit -m "feat: FingerprintPoller for additive fingerprint sync

Replaces the disabled Interactable.AddNewDynamicFingerprint /
RemoveManuallyCreatedFingerprints patches via per-interactable
count-diff with re-broadcast on increase. Receiver dedups via existing
FingerprintSync.

Part 3 of 5."
```

Playtest: PC A picks up an item with no fingerprints, then watches an NPC pick it up. On PC B, dust the same object — fingerprints should appear within 1s.

### Task 3.4: Implement FootprintPoller

**Files:**
- Create: `src/Sync/Polling/FootprintPoller.cs`
- Modify: `src/Sync/Polling/WorldStatePollers.cs`

**Prerequisite reading:** `FootprintSync.BroadcastAdd(GameplayController.Footprint fp)` exists. Footprints live in `GameplayController.Instance.footprints` (Il2CppList). The poller is **append-only**: tracks last broadcast index, broadcasts entries `[lastIdx, currentCount)`, advances cursor.

- [ ] **Step 1: Create.**

```csharp
using System.Collections.Generic;
using SoDCoop.Network;

namespace SoDCoop.Sync.Polling;

/// <summary>
/// Polls the global footprint registry. Append-only: tracks last broadcast
/// index, broadcasts new entries each tick. Replaces the disabled
/// <c>FootprintController.Setup</c> Harmony patch.
/// </summary>
public sealed class FootprintPoller : StatePoller<int, int>
{
    // We use the singleton key 0 → broadcast cursor. The diff machinery in
    // the base class is overkill for a pure cursor, but keeping the same
    // pattern simplifies reasoning.
    public override float TickInterval => 0.2f;   // 5 Hz
    public override string Name => "FootprintPoller";

    public override IEnumerable<KeyValuePair<int, int>> EnumerateCurrent()
    {
        var gc = global::GameplayController.Instance;
        if (gc == null) yield break;
        var prints = gc.footprints;
        if (prints == null) yield break;
        yield return new KeyValuePair<int, int>(0, prints.Count);
    }

    public override void FlushDelta(
        List<KeyValuePair<int, int>> adds,
        List<KeyValuePair<int, int>> changes,
        List<int> removes)
    {
        int newCount;
        if (adds.Count > 0) newCount = adds[0].Value;
        else if (changes.Count > 0) newCount = changes[0].Value;
        else return;

        // Determine where we left off. After base class wrote to _last, the
        // cursor is the new value. We need the OLD value. Workaround:
        // shadow it.
        int oldCount = _shadowCursor;
        _shadowCursor = newCount;

        if (newCount <= oldCount) return;

        var gc = global::GameplayController.Instance;
        var prints = gc?.footprints;
        if (prints == null) return;

        for (int i = oldCount; i < newCount && i < prints.Count; i++)
        {
            var fp = prints[i];
            if (fp == null) continue;
            FootprintSync.BroadcastAdd(fp);
        }
    }

    public override void ResetBaseline()
    {
        base.ResetBaseline();
        _shadowCursor = 0;
    }

    private int _shadowCursor;
}
```

- [ ] **Step 2: Register, build, commit, playtest.**

Register. Build. Commit:
```
git -C D:/sod_coop commit -m "feat: FootprintPoller for cursor-based footprint sync

Replaces the disabled FootprintController.Setup patch via append-only
broadcast of [_shadowCursor, currentCount).

Part 3 of 5."
```

Playtest: PC A walks through a wet/dirty area. PC B should see the same footprint trail within 1s.

### Task 3.5: Implement SpatterPoller

**Files:**
- Create: `src/Sync/Polling/SpatterPoller.cs`
- Modify: `src/Sync/Polling/WorldStatePollers.cs`

**Prerequisite reading:** `SpatterSync.BroadcastFromSim(SpatterSimulation sim)`. Spatter sims live on murder scenes; usually only a handful per session. Cursor pattern same as Footprints, against `Toolbox.Instance.allSpatter` (verify field name in disabled `SpatterSimulation_Execute_Patch` at `GamePatches.cs:875`).

- [ ] **Step 1: Create.**

```csharp
using System.Collections.Generic;
using SoDCoop.Network;

namespace SoDCoop.Sync.Polling;

public sealed class SpatterPoller : StatePoller<int, int>
{
    public override float TickInterval => 0.5f;   // 2 Hz
    public override string Name => "SpatterPoller";

    private int _shadowCursor;

    public override IEnumerable<KeyValuePair<int, int>> EnumerateCurrent()
    {
        var tb = global::Toolbox.Instance;
        if (tb == null) yield break;
        var spats = tb.allSpatter;
        if (spats == null) yield break;
        yield return new KeyValuePair<int, int>(0, spats.Count);
    }

    public override void FlushDelta(
        List<KeyValuePair<int, int>> adds,
        List<KeyValuePair<int, int>> changes,
        List<int> removes)
    {
        int newCount = adds.Count > 0 ? adds[0].Value : (changes.Count > 0 ? changes[0].Value : -1);
        if (newCount < 0) return;

        int oldCount = _shadowCursor;
        _shadowCursor = newCount;
        if (newCount <= oldCount) return;

        var tb = global::Toolbox.Instance;
        var spats = tb?.allSpatter;
        if (spats == null) return;

        for (int i = oldCount; i < newCount && i < spats.Count; i++)
        {
            var sim = spats[i];
            if (sim == null) continue;
            SpatterSync.BroadcastFromSim(sim);
        }
    }

    public override void ResetBaseline()
    {
        base.ResetBaseline();
        _shadowCursor = 0;
    }
}
```

- [ ] **Step 2: Register, build, commit, playtest.**

Register. Build. Commit:
```
git -C D:/sod_coop commit -m "feat: SpatterPoller for murder-scene spatter sync

Replaces the disabled SpatterSimulation.Execute patch via cursor-based
append-only broadcast.

Part 3 of 5."
```

Playtest: in a coop session, host kills an NPC. Both peers should see blood spatter at the kill site within 1s.

### Task 3.6: Implement VmailThreadPoller

**Files:**
- Create: `src/Sync/Polling/VmailThreadPoller.cs`
- Modify: `src/Sync/Polling/WorldStatePollers.cs`

**Prerequisite reading:** `VmailSync.BroadcastCreated(StateSaveData.MessageThreadSave thread)` exists. Threads live in `Toolbox.Instance.allMessageThreads` (verify name in existing `Toolbox.NewVmailThread` patch at `GamePatches.cs:1517`). Each `MessageThreadSave` has a thread id field — likely `id` or `messageID`.

- [ ] **Step 1: Create.**

```csharp
using System.Collections.Generic;

namespace SoDCoop.Sync.Polling;

public sealed class VmailThreadPoller : StatePoller<int, bool>
{
    public override float TickInterval => 0.5f;   // 2 Hz
    public override string Name => "VmailThreadPoller";

    public override IEnumerable<KeyValuePair<int, bool>> EnumerateCurrent()
    {
        var tb = global::Toolbox.Instance;
        var threads = tb?.allMessageThreads;
        if (threads == null) yield break;
        for (int i = 0; i < threads.Count; i++)
        {
            var t = threads[i];
            if (t == null) continue;
            yield return new KeyValuePair<int, bool>(t.id, true);
        }
    }

    public override void FlushDelta(
        List<KeyValuePair<int, bool>> adds,
        List<KeyValuePair<int, bool>> changes,
        List<int> removes)
    {
        // Init-burst suppression: if WorldReadyGate.IsInInitGrace, skip the
        // adds — they're SoD's deterministic per-citizen vmail seed and would
        // flood. Treat them as part of the baseline; gameplay deltas will
        // flow normally after grace closes.
        if (WorldReadyGate.IsInInitGrace) return;

        // We only care about adds (new threads). Removes = thread deletion,
        // which doesn't happen in SoD post-creation.
        var tb = global::Toolbox.Instance;
        var threads = tb?.allMessageThreads;
        if (threads == null) return;

        for (int i = 0; i < adds.Count; i++)
        {
            int id = adds[i].Key;
            // Find the corresponding thread to broadcast.
            for (int j = 0; j < threads.Count; j++)
            {
                if (threads[j] != null && threads[j].id == id)
                {
                    VmailSync.BroadcastCreated(threads[j]);
                    break;
                }
            }
        }
    }
}
```

- [ ] **Step 2: Register, build, commit, playtest.**

Register. Build. Commit:
```
git -C D:/sod_coop commit -m "feat: VmailThreadPoller for vmail thread sync

Polls Toolbox.allMessageThreads at 2 Hz; broadcasts new threads via
existing VmailSync.BroadcastCreated. Init-grace-window suppresses
the deterministic per-citizen seed flood. The Toolbox.NewVmailThread
patch is still attached at this point — Phase 5 will disable it once
the poller is verified.

Part 3 of 5."
```

Playtest: open vmail UI on PC A. Wait until an NPC sends a new vmail (in-game scripted event). PC B should see the same thread appear in inbox within 2s.

### Task 3.7: Implement EvidenceNotePoller

**Files:**
- Create: `src/Sync/Polling/EvidenceNotePoller.cs`
- Modify: `src/Sync/Polling/WorldStatePollers.cs`

**Prerequisite reading:** `EvidenceSync.BroadcastSetNote(string evId, …, string text)` exists. Evidence lives in `Toolbox.Instance.allEvidence`; each has `string evID` and `string note`. Hash via `string.GetHashCode()` for the diff key (cheap, no false positives in practice for short note strings).

- [ ] **Step 1: Create.**

```csharp
using System.Collections.Generic;

namespace SoDCoop.Sync.Polling;

public sealed class EvidenceNotePoller : StatePoller<string, int>
{
    public override float TickInterval => 0.2f;   // 5 Hz
    public override string Name => "EvidenceNotePoller";

    public override IEnumerable<KeyValuePair<string, int>> EnumerateCurrent()
    {
        var tb = global::Toolbox.Instance;
        var ev = tb?.allEvidence;
        if (ev == null) yield break;
        for (int i = 0; i < ev.Count; i++)
        {
            var e = ev[i];
            if (e == null || string.IsNullOrEmpty(e.evID)) continue;
            int hash = (e.note ?? "").GetHashCode();
            yield return new KeyValuePair<string, int>(e.evID, hash);
        }
    }

    public override void FlushDelta(
        List<KeyValuePair<string, int>> adds,
        List<KeyValuePair<string, int>> changes,
        List<string> removes)
    {
        // Skip init-burst — most SetNote calls happen there and the snapshot
        // baseline absorbs them.
        if (WorldReadyGate.IsInInitGrace) return;

        var tb = global::Toolbox.Instance;
        var ev = tb?.allEvidence;
        if (ev == null) return;

        // For each delta, look up the evidence and call BroadcastSetNote with
        // its current note text + datakey list.
        BroadcastByIds(ev, changes);
        BroadcastByIds(ev, adds);
    }

    private static void BroadcastByIds(
        Il2CppSystem.Collections.Generic.List<global::Evidence> ev,
        List<KeyValuePair<string, int>> deltas)
    {
        for (int i = 0; i < deltas.Count; i++)
        {
            string id = deltas[i].Key;
            for (int j = 0; j < ev.Count; j++)
            {
                var e = ev[j];
                if (e != null && e.evID == id)
                {
                    EvidenceSync.BroadcastSetNote(id, e.dks, e.note ?? "");
                    break;
                }
            }
        }
    }
}
```

- [ ] **Step 2: Register, build, commit, playtest.**

Register. Build. Commit:
```
git -C D:/sod_coop commit -m "feat: EvidenceNotePoller for case-board note sync

Polls every Evidence's note hash at 5 Hz; broadcasts changes via existing
EvidenceSync.BroadcastSetNote. Init-grace-window suppresses the heavy
init-burst SetNote storm.

Part 3 of 5."
```

Playtest: on PC A, write a note on an evidence item. PC B should see the same note text within 200ms.

---

## Phase 4 — Snapshot On Connect

**Goal:** When a third (or N-th) client joins mid-session, host sends a single `WorldStateSnapshotPacket` with full current state. Client applies it to set its poller baselines correctly so subsequent deltas merge cleanly.

### Task 4.1: Define snapshot packet and per-poller Capture/Apply

**Files:**
- Create: `src/Sync/Snapshot/WorldStateSnapshot.cs`
- Modify: `src/Network/Packets.cs` (`PacketType.WorldStateSnapshot = 122`)
- Modify: each poller in `src/Sync/Polling/*.cs` — add public `void Capture(NetDataWriter w)` and `void ApplyAndPrime(NetPacketReader r)` overrides.

- [ ] **Step 1: Add packet enum.**

In `Packets.cs`:
```csharp
    WorldStateSnapshot = 122,
```

- [ ] **Step 2: Create the snapshot packet.**

`src/Sync/Snapshot/WorldStateSnapshot.cs`:

```csharp
using LiteNetLib.Utils;
using SoDCoop.Sync.Polling;

namespace SoDCoop.Sync.Snapshot;

/// <summary>
/// Single packet containing every poller's current baseline. Sent by host
/// once per joining peer. Field order MUST match the order pollers were
/// registered in <see cref="WorldStatePollers.RegisterAll"/> — both sides
/// serialize/deserialize the exact same sequence.
/// </summary>
public static class WorldStateSnapshot
{
    /// <summary>Host-side: serialize every poller's state into the writer.</summary>
    public static void WriteAll(NetDataWriter w)
    {
        WorldStatePollers.CaptureAll(w);
    }

    /// <summary>Client-side: read every poller's state from the reader and
    /// prime baselines.</summary>
    public static void ReadAll(NetPacketReader r)
    {
        WorldStatePollers.ApplyAndPrimeAll(r);
    }
}
```

- [ ] **Step 3: Add `CaptureAll` and `ApplyAndPrimeAll` to `WorldStatePollers.cs`.**

```csharp
    public static void CaptureAll(NetDataWriter w)
    {
        for (int i = 0; i < _pollers.Count; i++)
            _pollers[i].Capture(w);
    }

    public static void ApplyAndPrimeAll(NetPacketReader r)
    {
        for (int i = 0; i < _pollers.Count; i++)
            _pollers[i].ApplyAndPrime(r);
    }
```

Add to `IPollerHandle`:
```csharp
    private interface IPollerHandle
    {
        void Tick(float now);
        void ResetBaseline();
        void Capture(NetDataWriter w);
        void ApplyAndPrime(NetPacketReader r);
    }
```

And implement in `PollerHandle<TK,TV>`:
```csharp
        public void Capture(NetDataWriter w) => _p.Capture(w);
        public void ApplyAndPrime(NetPacketReader r) => _p.ApplyAndPrime(r);
```

- [ ] **Step 4: Add abstract `Capture` / `ApplyAndPrime` to `StatePoller<,>`.**

In `src/Sync/Polling/StatePoller.cs`:

```csharp
    /// <summary>Host-side: serialize the current baseline into the writer.
    /// Implementer writes <c>(ushort)_last.Count</c> followed by N
    /// (key, value) pairs. Order doesn't matter as long as it's
    /// self-describing.</summary>
    public abstract void Capture(LiteNetLib.Utils.NetDataWriter w);

    /// <summary>Client-side: read what <see cref="Capture"/> wrote and
    /// populate <see cref="_last"/> so the next observed delta diffs
    /// against this baseline. Does NOT apply the values to the world —
    /// the world has already been loaded from the same save and is
    /// expected to match.</summary>
    public abstract void ApplyAndPrime(LiteNetLib.Utils.NetPacketReader r);
```

- [ ] **Step 5: Implement Capture/ApplyAndPrime in each poller.**

Pattern for `DoorStatePoller`:

```csharp
    public override void Capture(LiteNetLib.Utils.NetDataWriter w)
    {
        w.Put((ushort)_last.Count);
        foreach (var kv in _last)
        {
            w.Put(kv.Key);
            w.Put(kv.Value.Closed);
            w.Put(kv.Value.Locked);
        }
    }

    public override void ApplyAndPrime(LiteNetLib.Utils.NetPacketReader r)
    {
        _last.Clear();
        int n = r.GetUShort();
        for (int i = 0; i < n; i++)
        {
            int id = r.GetInt();
            bool closed = r.GetBool();
            bool locked = r.GetBool();
            _last[id] = new State(closed, locked);
        }
    }
```

Apply equivalent shape to each of: `LightStatePoller`, `OutfitStatePoller`, `SleepStatePoller`, `PhoneCallPoller`, `FingerprintPoller`, `FootprintPoller` (cursor: 1 ushort), `SpatterPoller` (cursor: 1 ushort), `VmailThreadPoller` (just thread id list), `EvidenceNotePoller` (string + int hash list).

For `FootprintPoller`/`SpatterPoller` cursor-style, encode just the cursor:
```csharp
    public override void Capture(NetDataWriter w) { w.Put((ushort)_shadowCursor); }
    public override void ApplyAndPrime(NetPacketReader r) { _shadowCursor = r.GetUShort(); _last.Clear(); }
```

- [ ] **Step 6: Build clean.**

Run `dotnet build -c Release`. 0 errors expected.

- [ ] **Step 7: Commit.**

```
git -C D:/sod_coop commit -m "feat: WorldStateSnapshot — Capture/ApplyAndPrime per poller

Each poller serializes its baseline into a NetDataWriter and rebuilds
it from a NetPacketReader. Foundation for the snapshot-on-connect
flow wired in Task 4.2.

Part 4 of 5."
```

### Task 4.2: Wire snapshot send on host, receive on client

**Files:**
- Modify: `src/Sync/Polling/WorldStatePollers.cs` (add `OnPlayerJoined` hook)
- Modify: `src/Sync/SyncManager.cs` (route inbound `WorldStateSnapshot`)

- [ ] **Step 1: In `WorldStatePollers.cs`, add hook registration.**

Add a new method:

```csharp
    private static readonly LiteNetLib.Utils.NetDataWriter _snapshotWriter = new();
    private static bool _hookedNet;

    /// <summary>Register the OnPlayerJoined hook. Call after
    /// <see cref="RegisterAll"/>; idempotent.</summary>
    public static void HookNetwork()
    {
        if (_hookedNet) return;
        _hookedNet = true;
        SoDCoop.Network.NetworkManager.OnPlayerJoined += OnPlayerJoined;
    }

    private static void OnPlayerJoined(int playerId, string playerName)
    {
        if (!SoDCoop.Network.NetworkManager.IsHost) return;
        try
        {
            _snapshotWriter.Reset();
            CaptureAll(_snapshotWriter);
            // Send only to the joining peer if SendToPeer exists; else SendToAll
            // (existing peers' ApplyAndPrime is idempotent — overwrites _last with
            // current host state, which already matches).
            SoDCoop.Network.NetworkManager.SendToAll(
                SoDCoop.Network.PacketType.WorldStateSnapshot,
                _snapshotWriter,
                LiteNetLib.DeliveryMethod.ReliableOrdered);
            Plugin.Log.LogInfo($"[WorldStateSnapshot] sent to all on player {playerId} join ({_snapshotWriter.Length} bytes).");
        }
        catch (System.Exception ex) { Plugin.Log.LogWarning($"OnPlayerJoined snapshot: {ex.Message}"); }
    }
```

If `NetworkManager` exposes a `SendTo(int playerId, …)` method, swap `SendToAll` for the targeted variant — read `NetworkManager.cs` to find it. The change is safe-by-default with `SendToAll` because `ApplyAndPrime` overwrites baselines (not state).

- [ ] **Step 2: Call `HookNetwork()` from `Plugin.InitializeSystems()`.**

After the `WorldStatePollers.RegisterAll();` line you added earlier, add:

```csharp
        SoDCoop.Sync.Polling.WorldStatePollers.HookNetwork();
```

- [ ] **Step 3: Wire inbound dispatch in `SyncManager.cs` (if/else if chain — see Task 3.1 step 4 for placement guidance).**

```csharp
            // World state snapshot (122) — host → joining peer, primes pollers.
            else if (type == PacketType.WorldStateSnapshot)
            {
                SoDCoop.Sync.Polling.WorldStatePollers.ApplyAndPrimeAll(reader);
                Plugin.Log.LogInfo("[WorldStateSnapshot] received and applied.");
            }
```

- [ ] **Step 4: Build clean.**

Run: `dotnet build -c Release`. Expected: 0 errors.

- [ ] **Step 5: Commit.**

```
git -C D:/sod_coop commit -m "feat: snapshot on player joined — wire send/receive

Host serializes every poller baseline on OnPlayerJoined and broadcasts
the WorldStateSnapshot packet. Clients apply on receive, priming
their _last dictionaries so subsequent deltas merge cleanly.

Part 4 of 5."
```

### Task 4.3: Phase 4 manual playtest (3-PC)

**Files:** none.

- [ ] **Step 1: Three-PC test.**

PC A hosts. PC B joins. Both play for ≥ 5 minutes — opening doors, NPCs go through their schedule, an NPC commits a murder, fingerprints accumulate.

PC C joins fresh. Within 5 seconds of `OnConnected` log line:
- All doors on PC C should be in the same open/closed state as PC A.
- All lights should match.
- NPC outfits should match.
- Murder scene spatter visible.
- Fingerprints visible on the murder weapon.
- Vmail inbox identical.

- [ ] **Step 2: Document.**

Append to `## Phase 4 Verification`:
```
- 2026-MM-DD: 3-PC test OK. Snapshot wire size ≈ <N> bytes.
```

- [ ] **Step 3: Commit.**

```
git -C D:/sod_coop commit -m "test: Phase 4 manual playtest result"
```

---

## Phase 5 — Patch Audit & Prune

**Goal:** Remove the `[HarmonyPatch]` attribute from the two patches whose pollers shadow them (Vmail thread creation, Evidence note set), confirm none of the KEEP-listed patches are accidentally on a hot path.

### Task 5.1: Disable `Toolbox.NewVmailThread` patch

**Files:**
- Modify: `src/Patches/GamePatches.cs` (find `[HarmonyPatch(typeof(Toolbox), nameof(Toolbox.NewVmailThread)`)

- [ ] **Step 1: Locate and comment the attribute.**

Run: `grep -n "Toolbox.NewVmailThread" src/Patches/GamePatches.cs`. The match should be at line ~1517.

Replace the line `[HarmonyPatch(typeof(Toolbox), nameof(Toolbox.NewVmailThread), …)]` with:

```csharp
    // DISABLED Phase 5: now polled by VmailThreadPoller (host-side, 2 Hz).
    //[HarmonyPatch(typeof(Toolbox), nameof(Toolbox.NewVmailThread), …same args…)]
```

Keep the same exact arg list inside the commented attribute so re-enabling is one comment-removal away.

- [ ] **Step 2: Build clean.**

`dotnet build -c Release` → 0 errors.

- [ ] **Step 3: Commit.**

```
git -C D:/sod_coop commit -m "refactor: disable Toolbox.NewVmailThread patch — covered by poller"
```

### Task 5.2: Disable `Evidence.SetNote` patch

**Files:**
- Modify: `src/Patches/GamePatches.cs` (find `[HarmonyPatch(typeof(Evidence), nameof(Evidence.SetNote))]`)

- [ ] **Step 1: Locate and comment.**

Run: `grep -n "Evidence.SetNote" src/Patches/GamePatches.cs`. Line ~1257.

Replace `[HarmonyPatch(typeof(Evidence), nameof(Evidence.SetNote))]` with:

```csharp
    // DISABLED Phase 5: now polled by EvidenceNotePoller (host-side, 5 Hz).
    //[HarmonyPatch(typeof(Evidence), nameof(Evidence.SetNote))]
```

- [ ] **Step 2: Build, commit.**

```
dotnet build -c Release
git -C D:/sod_coop commit -m "refactor: disable Evidence.SetNote patch — covered by poller"
```

### Task 5.3: KEEP-list audit

**Files:** none (audit only).

- [ ] **Step 1: List every active patch.**

Run: `grep -n "^\s*\[HarmonyPatch(" src/Patches/GamePatches.cs > /tmp/patch-audit.txt`. Open the file.

- [ ] **Step 2: Cross-check against spec section 3.3 KEEP list.**

For each line in the audit file, confirm the target method matches one of the spec's KEEP entries. If a method on the audit list does NOT appear in spec section 3.3 — investigate. Either:
  - The patch is genuinely cold-path → add it to KEEP in the spec.
  - The patch is on a hot ambient path that escaped earlier review → write a 5-line note in `docs/superpowers/specs/2026-05-01-coop-patch-architecture-design.md` under a new "Post-implementation amendments" section, then either disable or migrate to a poller.

- [ ] **Step 3: Final session playtest.**

In a 2-PC coop session, run a 30-minute playthrough touching every feature category:
  - Open/close 5 doors and 5 lights → both peers in sync (Phase 2 confirmation persists).
  - Wait through 1 in-game day → outfits + sleep cycle match.
  - Make a phone call (NPC-to-NPC) → both peers see notification.
  - Walk through dirty area → footprints sync.
  - Solve a side job → reward + state cascade work.
  - Pin/unpin/string cards on case board → sync.
  - Edit an evidence note → sync.
  - Murder an NPC → spatter + fingerprints sync.
  - Send a vmail → received on both ends.

If any test fails, file the regression as a Phase 6 task before merging.

- [ ] **Step 4: Final commit.**

```
git -C D:/sod_coop commit -m "test: Phase 5 final playtest — full feature surface verified" --allow-empty
```

---

## Verification Notes

(Filled in by the implementer as phases complete.)

### Phase 1 Verification

(empty)

### Phase 2 Verification

(empty)

### Phase 3 Verification

(empty)

### Phase 4 Verification

(empty)

### Phase 5 Verification

(empty)
