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
- **Path:** 🚶 **B — Self-Learner**. But 🐣 A and 🏃 C content must be written **in full in every chapter** — explicit learner requirement ([ADR-024](Decisions.md#adr-024)), so future readers can enter by any path.
- **Build machine:** ✅ **Linux desktop** ([D-001](Doubts.md)).
- **Cadence:** **one chapter per turn**, committed and pushed ([ADR-017](Decisions.md#adr-017)).

## WHAT

- **Course:** *Godot Zero to Hero* — 3D **Android** game development with **Godot 4 (.NET / C#)** and **Blender**.
- **Shape:** **13 modules** · **359 chapters** (64 Blender · ~45 🧰 adoption · 8 ⬜ blank-page) · **11 projects** · 4 mini-jams · ~560–650 h.
- **Languages:** **C# primary** (~180 ch) · GDScript (8) · C++/GDExtension (7) · GDShader (12). All four taught; see [`../Languages.md`](../Languages.md).
- **Repo:** ✅ [`https://github.com/Tyrostir/godot-zero-to-hero`](https://github.com/Tyrostir/godot-zero-to-hero) — live, pushed 2026-09-01.
- **Authoring path:** `/root/claude/godot-zero-to-hero` (Termux).
- **Deliverable:** a Markdown course + 11 Godot projects + a released Android game (*Ember Hollow*, working title).

## WHERE WE ARE

| | |
|---|---|
| Phase | **1 — planning** |
| Plan | ⏳ **Awaiting approval** |
| Chapters published | **0 / 359** |
| Setup guides | **5 / 5 drafted** — all `[UNVERIFIED]`, none run |
| Projects shipped | **0 / 11** |
| Toolchain installed | ❌ nothing yet |
| Blocker 🔴 | **`PLAN.md` review** ([T-002](ToDos.md)) — learner asked to review before chapters begin |
| Next (me) | Chapter 0.1 — or a sample chapter 1.4 on request |
| Next (you) | ⭐ Review PLAN.md and TableOfContents.md · answer D-003 (phone specs) |

## THE ENVIRONMENT — read this before assuming anything

```text
AUTHORING (this session):  Ubuntu in Termux on an Android phone
  git 2.34.1 ✅ · curl ✅ · python3 ✅ · jq ❌ · dotnet ❌ · godot ❌ · blender ❌ · adb ❌
  Learner instruction: DO NOT install or run anything here.
  ⇒ The author CANNOT verify any tool output. See ADR-016 / [UNVERIFIED].

BUILDING (learner's desktop):  ✅ LINUX (D-001 resolved)
  ⇒ command-line Android SDK route (~1 GB), distro OpenJDK 17, udev rule for adb
  Needs: 8 GB+ RAM, Vulkan GPU, 40 GB disk

TARGET (learner's phone):  ⏳ specs unknown — D-003
  Vulkan support decides Mobile vs Compatibility renderer (ch 5.13)
```

## THE FIVE RULES THAT SHAPE EVERY CHAPTER

0. **[ADR-024] Three paths, all authored in full.** 🐣 A (extra scaffolding, complete listings) · 🚶 B (the learner's, full chapter) · 🏃 C (Fast-Track Summary + build + cheat sheet). One document, path markers. Ratios below are measured on the Path B reading.
0. **[ADR-033] Help is removed on a schedule.** 90/10 guided → 10/90 by the capstone. Every chapter declares its split; every subsystem ends with a **⬜ blank-page build** (requirements only). **Success = independent capability, not chapter count.**
0a2. **[ADR-034] Android is a runtime, not a build target.** Module 2 (2.7–2.16): lifecycle, interruptions, process death, **the chaos test**, input beyond touch, device tier matrix, explicit performance budgets. P01 does not ship until it survives the chaos test.
0a. **[ADR-028] Build it once by hand, then adopt the library.** 28 🧰 `N.Mb` adoption chapters: hand-build → read the library's source → **decide and record why**. Never library-first. **[ADR-029]** Free toolchain catalogued in [`../Toolchain.md`](../Toolchain.md); six evaluation questions taught in 0.10. ⚠️ Most Godot addons are GDScript — C# loses **ergonomics, not access**. Prefer **Chickensoft** (C#-first), wrap the rest behind a C# interface (10.6b), use **NuGet** (0.11). **[ADR-031] Polyglot by design:** C# primary · GDScript for `@tool` scripts and addon glue · C++/GDExtension only after profiling. Boundaries live in one file (0.10b, 10.1b). **[ADR-030]** "AAA" = budget/headcount, not achievable solo, and saying so is more useful than agreeing; **professional/industry-grade craft** is the real target and is taught in full.
0b. **[ADR-026] The Presentation Spine.** Story, first-page animation, end-page animation, music, ambience and the walkthrough ship with **every project from P01**, not just Module 8. Title screen is built four times: 1.35 → 3.12 → 6.22 → 8.16–7.18. **[ADR-027]** Narration is recorded by the learner with gear they own (7.8–7.14), and **subtitles are mandatory**.
1. **[ADR-002] Practical-first, enforced numerically.** Build section comes first and is ≥50% of a chapter; theory follows and is ≤30%. No chapter opens with theory. Every chapter ends with something runnable.
2. **[ADR-010] Mobile-first.** The mobile-safe technique is the default taught; the desktop one is an aside. Baked before real-time. Atlas before per-object.
3. **[ADR-016] `[UNVERIFIED]` everything unrun.** Never invent an error message, a menu path, or a version number. Mark it, and let the learner clear it via `toAgent/`.
4. **[ADR-011] Every question → `D-NNN` in Doubts.md — question verbatim *and* your full answer**, unprompted, every turn. `/btw` must carry the question on the same line.
5. **[ADR-008] Every asset → a row in AssetLicenses.md at download time.** CC0 preferred; **NC and ND rejected outright**.

## THE SPINE — 11 projects

```text
P00 Hello Phone      M0   spinning cube ON THE PHONE — the whole toolchain, day one
P01 Marble Runner    M1   nodes, C#, transforms, physics, touch, camera, UI, save
                          + title screen, results screen, music, one-line premise
P02 Foundry Kit      M3   14-piece modular kit YOU model/UV/texture/bake — one atlas, <12k tris
P03 Playground       M4   rig, animate, AnimationTree, C# state machine, coyote time
P04 Hollow Level 1   M5   level design, GridMap, baked GI, 60fps ON DEVICE
P05 VFX Lab          M6   6 hand-written GDShaders, particles, Blender flipbooks
P06 Feel Pass        M7   audio buses, adaptive music, screenshake, hitstop, haptics
                          + NARRATION: write, record, clean, duck, subtitle
P07 The Slice        M8   splash→narrated cold open→menu→level→dialogue→
                          guided walkthrough→narrated ending→credits, unbroken
P08 Warden           M9   YOUR character: sculpt→retopo→UV→bake→texture→rig→animate
P09 Refactor         M10   architecture, Resources, pooling, tiers, tests, profiling
P10 Ember Hollow     M11  4 levels + boss, released FOUR TIMES: v1.0 after Level 1,
                          then v1.1-v1.3 as staged updates. Live-ops: save migration,
                          staged rollout, crash triage, hotfixes (ADR-019)
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
| Story / screens / music / narration per project | [`../PresentationSpine.md`](../PresentationSpine.md) |
| Free libraries, licences, adoption chapters | [`../Toolchain.md`](../Toolchain.md) |
| The four languages and which job goes to which | [`../Languages.md`](../Languages.md) |
| Project briefs + done-criteria | [`../../projects/README.md`](../../projects/README.md) |
| Standalone drills | [`../Exercises.md`](../Exercises.md) |
| Self-check Q&A | [`../reference/QuestionBank.md`](../reference/QuestionBank.md) → [`answers/`](../reference/answers) |
| Install everything | [`../guides/`](../guides) |
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
| [T-002](ToDos.md) | 🔴 `PLAN.md` review — chapters are held until this lands | 👤 |
| [D-002](Doubts.md) | 🟠 Exact Godot .NET version + its Android C# issues | 👤 |
| [D-003](Doubts.md) | 🟠 Phone GPU/RAM/Android/Vulkan — decides the renderer | 👤 |
| [T-013](ToDos.md) | 🟡 Chapter 0.1 — blocked on the approval above | 🤖 |
