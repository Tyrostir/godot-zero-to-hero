---
title: "Course State — Where We Are"
document_id: STATE
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "End of every working session, and after every chapter is published"
---

# 📍 CourseState.md

> **This is the single source of truth for course progress.**
> Returning after a break? Read this file, then [`CompactContext.md`](CompactContext.md). Together they take ~3 minutes and restore full context.

---

## 1. At a glance

| Field | Value |
|-------|-------|
| **Course** | Godot Zero to Hero — 3D Android game development with Godot 4 (.NET/C#) and Blender |
| **Repository** | `https://github.com/Tyrostir/godot-zero-to-hero` — ⛔ **not yet created**, see [T-001](ToDos.md) |
| **Local path (authoring)** | `/root/claude/godot-zero-to-hero` (Termux) |
| **Local path (building)** | ⏳ **undecided** — see [D-001](Doubts.md) |
| **Learner** | Tyrostir |
| **Current phase** | **Phase 1 — planning and scaffolding** |
| **Plan status** | ⏳ **Awaiting your approval** |
| **Chapters published** | **0 / 215** |
| **Setup guides published** | **5 / 5** — all carry `[UNVERIFIED]` markers, none run yet |
| **Projects shipped** | **0 / 11** |
| **Blender chapters published** | **0 / 42** |
| **Godot installed?** | ❌ Not yet — [Setup 02](../guides/Setup_02_Godot_And_DotNet.md) |
| **Blender installed?** | ❌ Not yet — [Setup 03](../guides/Setup_03_Blender.md) |
| **Phone connected?** | ❌ Not yet — [Setup 04](../guides/Setup_04_Android_And_Device.md) |
| **P00 on device?** | ❌ Not yet — the Module 0 milestone |
| **Blocked on** | 🔴 **Two things:** the repo cannot be created (permission), and the build machine is undecided ([D-001](Doubts.md)) |
| **Last session** | 2026-09-01 (Session 001) |

### Progress bar

```text
Module  0  Toolchain & First APK   [                    ]   0 %   (0/10)
Module  1  Godot Foundations       [                    ]   0 %   (0/37)
Module  2  Blender I: Pipeline     [                    ]   0 %   (0/21)
Module  3  Characters I            [                    ]   0 %   (0/24)
Module  4  Worlds & Performance    [                    ]   0 %   (0/20)
Module  5  Shaders & VFX           [                    ]   0 %   (0/23)
Module  6  Audio & Game Feel       [                    ]   0 %   (0/12)
Module  7  Story & Cinematics      [                    ]   0 %   (0/23)
Module  8  Characters II           [                    ]   0 %   (0/15)
Module  9  Architecture & Perf     [                    ]   0 %   (0/12)
Module 10  Capstone & Release      [                    ]   0 %   (0/22)
Module 11  Beyond (optional)       [                    ]   0 %   (0/6)
────────────────────────────────────────────────────────────────────────
OVERALL                            [                    ]   0 %   (0/215)
```

---

## 2. ➡️ Next action

| Who | Action |
|-----|--------|
| 👤 **You — do next** | 1. **Approve or amend [`../PLAN.md`](../PLAN.md)** — nothing is written until you do. 2. **Decide the build machine** ([D-001](Doubts.md)) — this blocks all of Module 0. 3. **Approve the repo-creation call** ([T-001](ToDos.md)). 4. Answer [ADR-024](Decisions.md#adr-024) — do you want three learning paths? |
| 🤖 **Me — next turn** | **Chapter 0.1** once the plan is approved. If you'd rather see a sample first, ask for **chapter 1.4** — it's the most representative of the Build→Why→Break→Practical→Check shape. |

---

## 3. Phases

| Phase | What | Status |
|-------|------|--------|
| **0 — Inception** | Environment inspected, conventions adopted, repo scaffolded | ✅ Done (Session 001) |
| **1 — Planning** | PLAN, TableOfContents, projects, guides, meta docs | ✅ Drafted · ⏳ awaiting approval |
| **2 — Setup** | Learner installs the toolchain; `[UNVERIFIED]` markers cleared; P00 ships | ⬜ Not started |
| **3 — Writing chapters** | One chapter per turn, Modules 0→10 | ⬜ Not started |
| **4 — Capstone** | P10 built and released | ⬜ Not started |

---

## 4. Milestones

| # | Milestone | Target | Actual |
|---|-----------|--------|--------|
| M0 | Plan approved | | |
| M1 | ⭐ **P00 spinning cube on the phone** | | |
| M2 | P01 Marble Runner shipped | | |
| M3 | P02 Foundry Kit in-engine (first art you made) | | |
| M4 | P03 Character walking | | |
| M5 | P04 Level 1 at 60fps on device | | |
| M6 | P07 Slice playable end-to-end | | |
| M7 | P08 Warden — your own character, in-game | | |
| M8 | 🏆 **P10 released** | | |

---

## 5. Chapter-by-chapter tracker

Tick as you go. `[ ]` not started · `[~]` in progress · `[x]` done · `[!]` done but shaky (revisit) · `[-]` skipped deliberately

### Module 0 — Toolchain & Your First APK

- [ ] 0.1 Machines and their roles
- [ ] 0.2 Godot 4 .NET + .NET SDK installed
- [ ] 0.3 Blender installed and configured
- [ ] 0.4 JDK + Android SDK + debug keystore
- [ ] 0.5 Phone connected, `adb devices` sees it
- [ ] 0.6 Editor tour
- [ ] 0.7 Git, `.gitignore`, LFS, first commit
- [ ] 0.8 **P00 — Hello Phone running on device** ⭐
- [ ] 0.9 Reading errors: output, debugger, logcat
- [ ] 0.10 Module 0 self-check

### Module 1 — Godot Foundations · P01 Marble Runner

**1A Engine model** — [ ] 1.1 · [ ] 1.2 · [ ] 1.3 · [ ] 1.4 · [ ] 1.5 · [ ] 1.6
**1B Space & motion** — [ ] 1.7 · [ ] 1.8 · [ ] 1.9 · [ ] 1.10 (X)
**1C Physics** — [ ] 1.11 · [ ] 1.12 · [ ] 1.13 · [ ] 1.14 · [ ] 1.15
**1D Input** — [ ] 1.16 · [ ] 1.17 · [ ] 1.18 · [ ] 1.19 · [ ] 1.20 · [ ] 1.21 (X)
**1E Camera** — [ ] 1.22 · [ ] 1.23 · [ ] 1.24
**1F Messaging** — [ ] 1.25 · [ ] 1.26 · [ ] 1.27
**1G UI** — [ ] 1.28 · [ ] 1.29 · [ ] 1.30 · [ ] 1.31
**1H Persistence** — [ ] 1.32 · [ ] 1.33 · [ ] 1.34
- [ ] 1.35 **P01 ship** ⭐ · [ ] 1.36 Mini-Jam 1 · [ ] 1.37 Self-check

### Module 2 — Blender I · P02 Foundry Kit

**Fluency** — [ ] B1 · [ ] B2 · [ ] B3 · [ ] B4 · [ ] X2.1
**Modelling** — [ ] B5 · [ ] B6 · [ ] B7 · [ ] B8 · [ ] B9 · [ ] X2.2
**Surfacing** — [ ] B10 · [ ] B11 · [ ] B12 · [ ] B13 · [ ] B14 · [ ] B15 · [ ] B16
**Pipeline** — [ ] B17 · [ ] B18 · [ ] B19 · [ ] 2.20 · [ ] 2.21
- [ ] 2.22 **P02 ship** ⭐ · [ ] 2.23 Self-check

### Module 3 — Characters I · P03 Playground

**Rigging** — [ ] B20 · [ ] B21 · [ ] B22 · [ ] B23 · [ ] B24
**Animation** — [ ] B25 · [ ] B26 · [ ] B27 · [ ] B28 · [ ] B29 · [ ] B30
**Playback** — [ ] 3.1 · [ ] 3.2 · [ ] 3.3 · [ ] 3.4 · [ ] 3.5
**Control** — [ ] 3.6 · [ ] 3.7 · [ ] 3.8 · [ ] 3.9 · [ ] 3.10 (X)
- [ ] 3.11 **P03 ship** ⭐ · [ ] 3.12 Mini-Jam 2 · [ ] 3.13 Self-check

### Module 4 — Worlds, Lighting & Performance · P04 Level 1

**Design** — [ ] 4.1 · [ ] 4.2 · [ ] 4.3 · [ ] 4.4 · [ ] 4.5 (X)
**Light** — [ ] 4.6 · [ ] 4.7 · [ ] 4.8 · [ ] 4.9 · [ ] 4.10 · [ ] 4.11
**Speed** — [ ] 4.12 · [ ] 4.13 · [ ] 4.14 · [ ] 4.15 · [ ] 4.16 · [ ] 4.17 · [ ] 4.18 (X)
- [ ] 4.19 **P04 ship** ⭐ · [ ] 4.20 Self-check

### Module 5 — Shaders & VFX · P05 VFX Lab

**Shaders** — [ ] 5.1 · [ ] 5.2 · [ ] 5.3 · [ ] 5.4 · [ ] 5.5 · [ ] 5.6 · [ ] 5.7 · [ ] 5.8 · [ ] 5.9 · [ ] 5.10 · [ ] 5.11 · [ ] 5.12
**Particles & FX** — [ ] 5.13 · [ ] 5.14 · [ ] 5.15 · [ ] 5.16 (B) · [ ] 5.17 (B) · [ ] 5.18 · [ ] 5.19 · [ ] 5.20 · [ ] 5.21 (X)
- [ ] 5.22 **P05 ship** ⭐ · [ ] 5.23 Self-check

### Module 6 — Audio & Game Feel · P06 Feel Pass

[ ] 6.1 · [ ] 6.2 · [ ] 6.3 · [ ] 6.4 · [ ] 6.5 · [ ] 6.6 · [ ] 6.7 · [ ] 6.8 · [ ] 6.9 · [ ] 6.10 (X) · [ ] 6.11 **ship** ⭐ · [ ] 6.12 Self-check

### Module 7 — Story & Cinematics · P07 The Slice

**Writing** — [ ] 7.1 · [ ] 7.2 · [ ] 7.3 · [ ] 7.4 · [ ] 7.5 · [ ] 7.6 · [ ] 7.7 (X)
**Systems** — [ ] 7.8 · [ ] 7.9 · [ ] 7.10 · [ ] 7.11
**Cinematics** — [ ] 7.12 · [ ] 7.13 · [ ] 7.14 · [ ] 7.15 · [ ] 7.16 · [ ] 7.17 · [ ] 7.18 · [ ] 7.19 · [ ] 7.20 (B) · [ ] 7.21 (B)
- [ ] 7.22 **P07 ship** ⭐ · [ ] 7.23 Self-check

### Module 8 — Characters II · P08 Warden

[ ] B31 · [ ] B32 · [ ] B33 · [ ] B34 · [ ] B35 · [ ] B36 · [ ] B37 · [ ] B38 · [ ] B39 · [ ] B40 · [ ] B41 · [ ] B42 · [ ] 8.1 · [ ] 8.2 **ship** ⭐ · [ ] 8.3 Self-check

### Module 9 — Architecture & Performance · P09 Refactor

[ ] 9.1 · [ ] 9.2 · [ ] 9.3 · [ ] 9.4 · [ ] 9.5 · [ ] 9.6 · [ ] 9.7 · [ ] 9.8 · [ ] 9.9 · [ ] 9.10 · [ ] 9.11 **ship** ⭐ · [ ] 9.12 Self-check

### Module 10 — Capstone · P10 Ember Hollow

**Production** — [ ] 10.1 · [ ] 10.2 · [ ] 10.3 · [ ] 10.4
**Content** — [ ] 10.5 · [ ] 10.6 · [ ] 10.7 · [ ] 10.8 · [ ] 10.9 · [ ] 10.10
**Polish & release** — [ ] 10.11 · [ ] 10.12 · [ ] 10.13 · [ ] 10.14 · [ ] 10.15 · [ ] 10.16 · [ ] 10.17 · [ ] 10.18 · [ ] 10.19 · [ ] 10.20
- [ ] 10.21 **RELEASED** 🏆 · [ ] 10.22 Self-check

### Module 11 — Beyond (optional)

[ ] 11.1 · [ ] 11.2 · [ ] 11.3 · [ ] 11.4 · [ ] 11.5 · [ ] 11.6

---

## 6. Skills self-assessment

Re-rate every two modules. 1 = never done it · 2 = can follow a tutorial · 3 = can do it unaided · 4 = can do it well and explain why · 5 = can teach it.

| Skill | Start | M2 | M4 | M6 | M8 | M10 |
|---|---|---|---|---|---|---|
| C# language | | | | | | |
| Godot scene/node model | | | | | | |
| 3D maths (transforms, rotations) | | | | | | |
| Physics & collision | | | | | | |
| Character controllers | | | | | | |
| Animation state machines | | | | | | |
| Shaders (GDShader) | | | | | | |
| VFX & particles | | | | | | |
| Lighting & baking | | | | | | |
| Mobile performance | | | | | | |
| Blender — modelling | | | | | | |
| Blender — UV & texturing | | | | | | |
| Blender — sculpt & retopo | | | | | | |
| Blender — rigging | | | | | | |
| Blender — animation | | | | | | |
| Blender — rendering & compositing | | | | | | |
| Level design | | | | | | |
| Narrative & story | | | | | | |
| Audio & game feel | | | | | | |
| Shipping & release | | | | | | |

---

## 7. Session log

| Date | Hours | Chapters covered | Shipped/committed | Energy 1–5 | Note to future me |
|---|---|---|---|---|---|
| 2026-09-01 | — | Session 001 — course inception: plan, ToC, 25 ADRs, 5 setup guides, 11 project briefs, meta + internal scaffolding | local `git init`, no remote yet | — | Approve PLAN.md, decide the build machine (D-001), approve repo creation (T-001) |

---

---

## 📝 Changelog

| Version | Date | Change |
|---------|------|--------|
| 1.0 | 2026-09-01 | Created at course inception (Session 001). |
