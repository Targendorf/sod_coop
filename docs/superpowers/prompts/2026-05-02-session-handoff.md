# Session Handoff — SoD Coop Mod, ZDO Refactor

> Paste this entire prompt into a fresh Claude session to continue the SoD
> Coop mod work. This document is self-contained — the new session does
> NOT need any prior conversation context.

---

## Your role

You are continuing work on the **SoD Coop mod** — a BepInEx 6 IL2CPP plugin that adds peer-to-peer cooperative multiplayer to *Shadow of Doubt* (a single-player detective game by ColePowered Games on Unity 2021.3).

The previous session ended with a major architectural decision: **migrate from per-feature `Sync` classes to a unified ZDO (Z-Data Object) replication layer**, modeled on Valheim's networking, plus optimisations from BetterNetworking-Valheim (zstd compression, batching, queue management).

Your job in this session: **produce the ZDO architecture design spec**, then optionally produce the implementation plan.

## Project location

- **Repo root:** `D:\sod_coop`
- **GitHub:** https://github.com/Targendorf/sod_coop
- **Branch:** `main` (local + origin)
- **Build:** `dotnet build -c Release` from repo root.
- **DLL output:** `D:\sod_coop\bin\Release\net6.0\SoDCoop.dll`
- **Auto-deploy target:** `C:\Users\blued\AppData\Roaming\com.kesomannen.gale\shadows-of-doubt\profiles\Default\BepInEx\plugins\SoDCoop\` (configured in csproj post-build).

## Tech stack

- C# 11, .NET 6
- BepInEx 6.0.0-be.755 (IL2CPP variant, bleeding-edge)
- HarmonyX (the IL2CPP-aware Harmony fork)
- LiteNetLib (UDP P2P transport, host-authoritative star topology)
- Il2CppInterop (managed↔IL2CPP bridge)
- SOD.Common 2.1.4 (Venomaus's SoD modding API — save-load events, time, etc.)

## What's already done (do not redo)

A long iteration to make Harmony patches not freeze save-load. Final state of that effort is preserved on:

- **Branch:** `archive/phase1-gradual-resume`
- **Tag:** `archive/pre-zdo-2026-05-02`

That work (commits `d030363` through `48146cc`) is **not deleted** — it just wasn't the right architectural direction long-term. The current `main` HEAD includes it but everything from this commit onward is ZDO refactor work.

Specifically, those commits:
- Removed and then restored Pause/Resume cycle around save-load.
- Discovered via diagnostic that `UnpatchSelf` + re-`PatchAll` corrupts trampolines (commit `b118093`).
- Implemented gradual Resume (1 patch class per 100ms over ~5s) in `48146cc` as a workaround.
- The gradual Resume **may or may not be working** — playtest was inconclusive when the session ended.

**Important: the ZDO architecture eliminates the need for Pause/Resume entirely** by not patching init-burst-hot methods at all (those become pollers). So the gradual Resume work is still useful as Phase 1 documentation but the final architecture won't need it.

## Critical constraints learned the hard way

These are sharp edges. Don't try to relitigate any of them:

1. **`Harmony.UnpatchSelf` does NOT undo native detours.** It clears HarmonyX records but Dobby's JMP-based detour stays in place. Verified via DobbyDetour debug logs: zero "Removing detour" lines exist anywhere. **Implication:** every re-`PatchAll` adds a NEW detour layer on top of the existing one → wrapper-trampoline-stacking → eventual crash.

2. **Re-`PatchAll` after `UnpatchSelf` causes hard crashes.** Specifically when called while SoD's post-load init burst (which runs 5+ minutes after `OnAfterLoad`) has methods on the active call stack. Verified by user crash on ESC after Resume in commit before `b118093`.

3. **Body-bail is not enough.** A `[HarmonyPostfix] static void Postfix() { if (!SyncGate.IsOpen) return; ... }` does NOT eliminate the IL2CPP wrapper trampoline cost. The wrapper marshals arguments BEFORE the body runs. With patches active during save-load init burst, save-load goes from ~50s (vanilla) to 200+s (uncompletable in 15min).

4. **New-game world creation is just as heavy as save-load init burst.** SOD.Common's `OnBeforeLoad` fires only on save-load, NOT on new-game. So Pause hooks scoped to `OnBeforeLoad` miss new-game entirely. Verified: with patches active during new-game creation, world ready at 7+ minutes. With patches paused, ~60s.

5. **`string.GetHashCode()` is randomised in .NET 6+.** Two peers running the same code will get DIFFERENT hash values for the same string. Any shared-key hashing scheme (e.g., ZDO property keys) must use a deterministic algorithm like FNV-1a. **Do NOT use `string.GetHashCode()`.**

6. **`Il2CppSystem.Collections.Generic.List<T>` ≠ `System.Collections.Generic.List<T>`.** SoD's lists are the IL2CPP variant. Standard LINQ does not work. Iterate manually.

7. **No SoD source code.** All field/method discovery is via dnSpy decompile of `Shadows of Doubt_Data\il2cpp_data\Metadata\global-metadata.dat` plus runtime reflection via Il2CppInterop. Verify field names against existing patches in `src/Patches/GamePatches.cs` (those were authored against runtime-verified names).

8. **No automated test harness.** Verification is `dotnet build -c Release` (0 errors) plus manual playtest in 2-PC and 3-PC sessions.

9. **`SyncGate.IsOpen` is the single body-bail flag.** Default `false` (closed at plugin load). Opened only when patches are fully attached and ready to broadcast. Every patch body's first line is `if (!SyncGate.IsOpen) return;`.

## Where to find documentation

All in `D:\sod_coop\docs\superpowers\`:

- **`specs/2026-05-01-coop-patch-architecture-design.md`** — the Phase 1 design spec (the OLD architecture we're superseding). Read for context only; do not implement from this.
- **`plans/2026-05-01-coop-patch-architecture-plan.md`** — the Phase 1 implementation plan (also superseded).
- **`prompts/2026-05-02-zdo-spec-prompt.md`** — **THIS IS THE PROMPT YOU NEED.** Detailed instructions for writing the ZDO spec. Read it carefully — it contains every requirement, nuance, and section structure for the new doc.

User memory (auto-loaded by Claude harness):
- `project_sod_coop.md` — top-level project index.
- `project_sod_coop_ui.md` — UI architecture.
- `project_sod_coop_history.md` — feature timeline (Phases 1-4 + Side Jobs SJ.1-SJ.3 + Phase A/B character names).
- `project_sod_coop_character.md` — per-client character names + twin citizen system.
- `project_sod_coop_sidejobs.md` — Side Jobs sync details.

## Reference architecture sources

When the spec cites Valheim or BetterNetworking, use these URLs:
- **Valheim ZDO/RPC reference:** https://github.com/Valheim-Modding/Wiki/wiki/RPC-System-Reference-Sheet
- **Jotunn RPC tutorial:** https://valheim-modding.github.io/Jotunn/tutorials/rpcs.html
- **BetterNetworking-Valheim source:** https://github.com/CW-Jesse/valheim-betternetworking
- **MegaBonk.Multiplayer (same stack as us, different game):** https://github.com/DeliriumPulse/MegaBonk.Multiplayer

## What to do (step by step)

### Step 1 — verify project state (≤2 min)

Run:
```bash
git -C D:/sod_coop log -3 --oneline
git -C D:/sod_coop branch -a
git -C D:/sod_coop tag --list "archive/*"
git -C D:/sod_coop status --short
```

Expected: clean working tree on `main`. Latest commit is `faf9e26` (or newer). Branch `archive/phase1-gradual-resume` exists. Tag `archive/pre-zdo-2026-05-02` exists.

If any of those expectations fail, STOP and tell the user — something has shifted since handoff was written.

### Step 2 — read the ZDO spec prompt (≤5 min)

Open and read fully: `D:\sod_coop\docs\superpowers\prompts\2026-05-02-zdo-spec-prompt.md`.

That file is **the actual prompt for the spec writing**. Treat it as your spec-writing brief.

### Step 3 — read the prerequisite source files (≤15 min)

The ZDO spec prompt lists 10 files to pre-read. Honour that list. Don't skip.

Specifically:
- `docs/superpowers/specs/2026-05-01-coop-patch-architecture-design.md` (current Phase 1 spec, ~240 lines)
- `docs/superpowers/plans/2026-05-01-coop-patch-architecture-plan.md` (current Phase 1 plan, ~2000 lines — skim section headers, deep-read only sections relevant to your spec section)
- `src/Plugin.cs` (entry point + patch lifecycle, ~440 lines)
- `src/Network/NetworkManager.cs` (transport, ~1400 lines — skim)
- `src/Network/Packets.cs` (packet enum + structs, ~660 lines — note the magnitude of packet types)
- `src/Sync/SyncManager.cs` (dispatcher, ~310 lines — read OnPacketReceived carefully)
- `src/Sync/WorldStateSync.cs` (~430 lines — example pattern)
- `src/Patches/GamePatches.cs` (49 active + 17 disabled patches; ~2150 lines — first 200 lines for shape, then grep)
- `src/Sync/WorldReadyGate.cs` (~165 lines)
- `src/Integration/SodCommonBridge.cs` (~130 lines)

Plus skim the file list under `src/Sync/` to know what feature-sync classes exist.

### Step 4 — write the spec (target 60-90 min)

Follow the prompt at `docs/superpowers/prompts/2026-05-02-zdo-spec-prompt.md` **verbatim**. Output to `docs/superpowers/specs/2026-05-02-zdo-architecture-design.md`.

Mandatory structure: 13 sections + 15 named nuances. Every section must have content; every nuance must be addressed by name. Length: 800-1500 lines.

When you reference current code, cite by `src/<file>:<line>`. When you cite Valheim/BetterNetworking, link to the URLs above.

### Step 5 — self-review (≤10 min)

After writing, before saving, scan your spec for:
1. **Placeholders**: search for "TBD", "TODO", "fill in", "etc.", "...". Replace each with concrete content or move it to section 12 as a numbered open question.
2. **Internal contradictions**: e.g., section 4 says compression always-on; section 5 says skip below 100 bytes. Pick one.
3. **Coverage gaps**: cross-reference your section 6 feature mapping against `grep -l "public static void Broadcast" src/Sync/`. Every Broadcast method must map to a row.
4. **Type consistency**: `ZdoMan` vs `ZDOMan` — pick one and grep-replace.
5. **Unattributed numeric estimates**: every "~Xkb" or "~Yms" claim has either a citation or a reasoned derivation.

Fix issues inline, then save.

### Step 6 — commit and report

```bash
git -C D:/sod_coop add docs/superpowers/specs/2026-05-02-zdo-architecture-design.md
git -C D:/sod_coop commit -m "docs: ZDO + BetterNetworking architecture design spec

Replaces the per-feature Sync class architecture (10+ classes,
115+ packet types) with a unified ZDO replication layer modelled
on Valheim's ZDO/ZNet, plus zstd compression and batching from
BetterNetworking-Valheim.

Spec covers full feature parity with current sync surface."
```

Then report to the user with:
- Spec path + line count.
- `git log -1 --oneline` of your commit.
- Top 3 design decisions you made and why.
- Open questions you couldn't resolve, by their section 12 number.

Wait for user review before doing anything else.

### Step 7 (optional, only if user approves) — write the implementation plan

Once user signs off on the spec, write the implementation plan to:
`docs/superpowers/plans/2026-05-02-zdo-architecture-plan.md`.

The plan decomposes Phases A-H from the spec's section 9 into per-task code-level instructions. Use the existing pattern at `docs/superpowers/plans/2026-05-01-coop-patch-architecture-plan.md` as a structural template — same task-with-checkbox format, same verification-via-build pattern, same per-phase user-gate playtests.

Length: 1500-3000 lines (the migration is bigger than Phase 1).

Commit + report similarly.

## Reporting format

Throughout the session, report status in clear blocks:

- **DONE** — task complete; here's what I did and where.
- **NEEDS_INPUT** — I need a decision or more context from you.
- **BLOCKED** — I can't proceed; here's why.

For each significant edit/commit: include `git log -1 --oneline` and a 1-sentence what-changed summary.

## Out of scope for this session

To prevent scope creep:
- **Do not implement code yet.** This session produces docs only.
- **Do not run the gradual Resume test.** That belongs to a different session.
- **Do not modify any source file in `src/`.** Only `docs/`.
- **Do not change the active branch or tags.** They were established intentionally.
- **Do not push to origin until user explicitly approves.** Local commits only by default; user pushes when ready.

## Tone / language

User's primary language is Russian. Reply to the user in Russian (concise, technical, no fluff). Internal docs/specs/code stay in English (this is a code project — comments and identifiers in English).

If user types a brief instruction like "запускай" / "приступай" / "ОК" — that's approval to proceed with the next step in this handoff document.

If user pushes back on a design decision, take it seriously. The previous session ate ~7 iterations of architectural rework because the user kept insisting features should not be disabled. Listen to constraints first, propose only after.

---

## Quick-reference for common tasks

**Build the mod:**
```bash
cd D:/sod_coop
dotnet build -c Release
```
Expected: 0 errors, 5 acceptable pre-existing warnings (NU1603 ×2, NETPKT001/RS2008, CS0414 ×2).

**Find all Broadcast methods (for feature mapping coverage):**
```bash
grep -rn "public static void Broadcast" src/Sync/
```

**Find all currently-active Harmony patches:**
```bash
grep -nE "^\s*\[HarmonyPatch\(" src/Patches/GamePatches.cs
```

**Find disabled hot-path patches:**
```bash
grep -n "DISABLED hot-path\|DISABLED Phase" src/Patches/GamePatches.cs
```

**Read a specific patched method's prerequisites** (for feature mapping):
```bash
grep -n "BroadcastDoorState" src/
```

---

## Final checklist before you start writing the spec

- [ ] Verified git state (Step 1).
- [ ] Read `docs/superpowers/prompts/2026-05-02-zdo-spec-prompt.md` fully (Step 2).
- [ ] Read all 10 prerequisite files (Step 3).
- [ ] Internalised the 9 critical constraints (above).
- [ ] Understand reporting format.
- [ ] Have at least 60 minutes of focused time available.

If yes to all: proceed to Step 4 (write the spec).

If no: ask the user for the missing piece before starting.
