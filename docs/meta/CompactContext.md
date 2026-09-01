---
title: "Compact Context — One-Page Session Reload"
document_id: CTX
version: 1.0
status: Active (regenerated every session)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "End of every session — regenerate from CourseState + Decisions"
---

# 🗜️ CompactContext.md

> **Purpose.** A single dense page that restores *complete* working context in one read — for you after a break, or for a fresh AI session with no history.
> **Rule:** must stay under ~150 lines. If it grows, compress; don't append.

---

## WHO

- **Learner:** Tyrostir. Also the author of `qnx-zero-to-hero` (same conventions, same account).
- **Background:** embedded engineer — **C/C++ solid, Python strong** (per the QNX course record). **New to game development, to C# in a game context, to Godot, and to Blender.** Teach all four from first principles.
- **Wants:** everything from scratch, nothing assumed, every step spelled out, **practicals before theory**, many intermediate projects, every question logged with its answer.
- **Cadence:** **one chapter per turn**, committed and pushed ([ADR-017](Decisions.md#adr-017)).

## WHAT

- **Course:** *Godot Zero to Hero* — 3D **Android** game development with **Godot 4 (.NET / C#)** and **Blender**.
- **Shape:** 12 modules · **215 chapters** (173 Godot + 42 Blender) · **11 projects** · 4 mini-jams · ~400–450 h.
- **Repo:** ✅ [`https://github.com/Tyrostir/godot-zero-to-hero`](https://github.com/Tyrostir/godot-zero-to-hero) — live, pushed 2026-09-01.
- **Authoring path:** `/root/claude/godot-zero-to-hero` (Termux).
- **Deliverable:** a Markdown course + 11 Godot projects + a released Android game (*Ember Hollow*, working title).

## WHERE WE ARE

| | |
|---|---|
| Phase | **1 — planning** |
| Plan | ⏳ **Awaiting approval** |
| Chapters published | **0 / 215** |
| Setup guides | **5 / 5 drafted** — all `[UNVERIFIED]`, none run |
| Projects shipped | **0 / 11** |
| Toolchain installed | ❌ nothing yet |
| Blocker 🔴 | **Build machine undecided** ([D-001](Doubts.md)) · plan awaiting approval ([T-002](ToDos.md)) |
| Next (me) | Chapter 0.1 — or a sample chapter 1.4 on request |
| Next (you) | Approve PLAN · answer D-001 · answer D-003 · decide [ADR-024](Decisions.md#adr-024) |

## THE ENVIRONMENT — read this before assuming anything

```text
AUTHORING (this session):  Ubuntu in Termux on an Android phone
  git 2.34.1 ✅ · curl ✅ · python3 ✅ · jq ❌ · dotnet ❌ · godot ❌ · blender ❌ · adb ❌
  Learner instruction: DO NOT install or run anything here.
  ⇒ The author CANNOT verify any tool output. See ADR-016 / [UNVERIFIED].

BUILDING (learner's desktop):  ⏳ UNDECIDED — D-001 blocks Module 0
  Needs: 8 GB+ RAM, Vulkan GPU, 40 GB disk, Win/Linux/macOS

TARGET (learner's phone):  ⏳ specs unknown — D-003
  Vulkan support decides Mobile vs Compatibility renderer (ch 4.13)
```

## THE FIVE RULES THAT SHAPE EVERY CHAPTER

1. **[ADR-002] Practical-first, enforced numerically.** Build section comes first and is ≥50% of a chapter; theory follows and is ≤30%. No chapter opens with theory. Every chapter ends with something runnable.
2. **[ADR-010] Mobile-first.** The mobile-safe technique is the default taught; the desktop one is an aside. Baked before real-time. Atlas before per-object.
3. **[ADR-016] `[UNVERIFIED]` everything unrun.** Never invent an error message, a menu path, or a version number. Mark it, and let the learner clear it via `toAgent/`.
4. **[ADR-011] Every question → `D-NNN` in Doubts.md.** The `/btw` prefix guarantees it.
5. **[ADR-008] Every asset → a row in AssetLicenses.md at download time.** CC0 preferred; **NC and ND rejected outright**.

## THE SPINE — 11 projects

```text
P00 Hello Phone      M0   spinning cube ON THE PHONE — the whole toolchain, day one
P01 Marble Runner    M1   nodes, C#, transforms, physics, touch, camera, UI, save
P02 Foundry Kit      M2   14-piece modular kit YOU model/UV/texture/bake — one atlas, <12k tris
P03 Playground       M3   rig, animate, AnimationTree, C# state machine, coyote time
P04 Hollow Level 1   M4   level design, GridMap, baked GI, 60fps ON DEVICE
P05 VFX Lab          M5   6 hand-written GDShaders, particles, Blender flipbooks
P06 Feel Pass        M6   audio buses, adaptive music, screenshake, hitstop, haptics
P07 The Slice        M7   splash→intro→menu→level→dialogue→ending→credits, unbroken
P08 Warden           M8   YOUR character: sculpt→retopo→UV→bake→texture→rig→animate
P09 Refactor         M9   architecture, Resources, pooling, tiers, tests, profiling
P10 Ember Hollow     M10  4 levels + boss, released to itch.io + Play internal testing
```

## HARD TECHNICAL FACTS

- Godot's **Android editor build has no C#**. Desktop authoring is mandatory ([ADR-004](Decisions.md#adr-004)).
- Godot ships **two binaries**: standard (GDScript only) and **.NET** (C#). Only the .NET one works here.
- **Export templates must match the editor version exactly**, .NET variant included.
- **glTF 2.0 (`.glb`) only** for Blender→Godot ([ADR-009](Decisions.md#adr-009)).
- **1 Blender metre = 1 Godot unit** — Metric, Unit Scale 1.0, transforms applied.
- Godot 3D is **Y-up, right-handed, −Z forward**.
- Import suffixes: `-col` trimesh · `-convcol` convex · `-noimp` skip.
- Losing a **release keystore** = never being able to update that Play listing again.
- C# on Android in Godot works but is the less-travelled path — expect rough edges ([ADR-022](Decisions.md#adr-022)).

## DOCUMENT MAP

| Need | File |
|---|---|
| Philosophy, syllabus, constraints, pacing | [`../PLAN.md`](../PLAN.md) |
| Every chapter, numbered | [`../TableOfContents.md`](../TableOfContents.md) |
| Blender curriculum B1–B42 | [`../BlenderTrack.md`](../BlenderTrack.md) |
| Project briefs + done-criteria | [`../../projects/README.md`](../../projects/README.md) |
| Standalone drills | [`../Exercises.md`](../Exercises.md) |
| Self-check Q&A | [`../reference/QuestionBank.md`](../reference/QuestionBank.md) → [`answers/`](../reference/answers/) |
| Install everything | [`../guides/`](../guides/) |
| Free assets + licences | [`../reference/ResourcesMeta.md`](../reference/ResourcesMeta.md) |
| Attribution ledger | [`../reference/AssetLicenses.md`](../reference/AssetLicenses.md) |
| Progress | [`CourseState.md`](CourseState.md) |
| Decisions (now / history) | [`Decisions.md`](Decisions.md) / [`DecisionsLog.md`](DecisionsLog.md) |
| Questions | [`Doubts.md`](Doubts.md) |
| Open work | [`ToDos.md`](ToDos.md) |
| Agent memory | [`../internal/CLAUDE-MEMORY.md`](../internal/CLAUDE-MEMORY.md) |

## OPEN LOOPS

| ID | What | Owner |
|---|---|---|
| [T-002](ToDos.md) | 🔴 Approve `PLAN.md` — nothing is written until this lands | 👤 |
| [D-001](Doubts.md) | 🔴 Which desktop machine builds this? Blocks all of Module 0 | 👤 |
| [D-002](Doubts.md) | 🟠 Exact Godot .NET version + its Android C# issues | 👤 |
| [D-003](Doubts.md) | 🟠 Phone GPU/RAM/Android/Vulkan — decides the renderer | 👤 |
| [ADR-024](Decisions.md#adr-024) | 🟡 Three learning paths, yes or no? Recommendation: no | 👤 |
| [T-013](ToDos.md) | 🟡 Chapter 0.1 — blocked on the approval above | 🤖 |
