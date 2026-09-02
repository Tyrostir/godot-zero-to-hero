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
| **Repository** | ✅ [`https://github.com/Tyrostir/godot-zero-to-hero`](https://github.com/Tyrostir/godot-zero-to-hero) — created and pushed 2026-09-01 |
| **Local path (authoring)** | `/root/claude/godot-zero-to-hero` (Termux) |
| **Local path (building)** | ✅ **A Linux desktop** ([D-001](Doubts.md) resolved 2026-09-01) |
| **Learner** | Tyrostir — path 🚶 **B, Self-Learner** (A and C authored in full, [ADR-024](Decisions.md#adr-024)) |
| **Current phase** | **Phase 1 — planning and scaffolding** |
| **Plan status** | ⏳ **Awaiting your approval** |
| **Chapters published** | **0 / 359** |
| **Setup guides published** | **5 / 5** — all carry `[UNVERIFIED]` markers, none run yet |
| **Projects shipped** | **0 / 11** · public releases **0 / 4** |
| **Blender chapters published** | **0 / 64** |
| **Godot installed?** | ❌ Not yet — [Setup 02](../guides/Setup_02_Godot_And_DotNet.md) |
| **Blender installed?** | ❌ Not yet — [Setup 03](../guides/Setup_03_Blender.md) |
| **Phone connected?** | ❌ Not yet — [Setup 04](../guides/Setup_04_Android_And_Device.md) |
| **P00 on device?** | ❌ Not yet — the Module 0 milestone |
| **Blocked on** | 🔴 **`PLAN.md` approval** ([T-002](ToDos.md)) — you asked to review it before any chapter is written |
| **Last session** | 2026-09-01 (Session 001) |

### Progress bar

```text
Module  0  Toolchain, APK & Languages    [                    ]   0 %   (0/19)
Module  1  Godot Foundations             [                    ]   0 %   (0/44)
Module  2  Android Runtime & Practice    [                    ]   0 %   (0/19)
Module  3  Blender I: Pipeline           [                    ]   0 %   (0/35)
Module  4  Characters I                  [                    ]   0 %   (0/30)
Module  5  Worlds & Performance          [                    ]   0 %   (0/29)
Module  6  Shaders & VFX                 [                    ]   0 %   (0/30)
Module  7  Audio, Narration & Feel       [                    ]   0 %   (0/23)
Module  8  Story & Cinematics            [                    ]   0 %   (0/32)
Module  9  Characters II                 [                    ]   0 %   (0/20)
Module 10  Architecture, C++ & Perf      [                    ]   0 %   (0/28)
Module 11  Capstone: Ship, Keep Shipping [                    ]   0 %   (0/43)
Module 12  Beyond (optional)             [                    ]   0 %   (0/7)
───────────────────────────────────────────────────────────────────────────────
OVERALL                                  [                    ]   0 %   (0/359)
```

---

## 2. ➡️ Next action

| Who | Action |
|-----|--------|
| 👤 **You — do next** | ⭐ **1. Review [`../PLAN.md`](../PLAN.md)** and come back with amendments — you asked for this before any chapter is written. Read §1 (philosophy), §1b (the three paths), §3 (the 11 projects) and §5 (honest constraints). 2. Skim [`../TableOfContents.md`](../TableOfContents.md) for anything missing or mis-sequenced. 3. Record your phone's specs ([D-003](Doubts.md)). |
| 🤖 **Me — next turn** | ⏸️ **Holding for your plan review.** On your word: **Chapter 0.1**, written for all three paths, one chapter per turn. |

---

## 3. Phases

| Phase | What | Status |
|-------|------|--------|
| **0 — Inception** | Environment inspected, conventions adopted, repo scaffolded, **GitHub repo created and pushed** | ✅ Done (Session 001) |
| **1 — Planning** | PLAN, TableOfContents, projects, guides, meta docs | ✅ Drafted · ⏳ **awaiting your review** |
| **2 — Setup** | Learner installs the toolchain; `[UNVERIFIED]` markers cleared; P00 ships | ⬜ Not started |
| **3 — Writing chapters** | One chapter per turn, Modules 0→10 | ⬜ Not started |
| **4 — Capstone** | P10 built and released | ⬜ Not started |

---

## 4. Milestones

| # | Milestone | Target | Actual |
|---|-----------|--------|--------|
| M0 | Plan approved | | |
| M0.5 | Repo live on GitHub | 2026-09-01 | ✅ 2026-09-01 |
| M1 | ⭐ **P00 spinning cube on the phone** | | |
| M3 | P01 Marble Runner shipped | | |
| M4 | P02 Foundry Kit in-engine (first art you made) | | |
| M5 | P03 Character walking | | |
| M6 | P04 Level 1 at 60fps on device | | |
| M7 | P07 Slice playable end-to-end | | |
| M8 | P08 Warden — your own character, in-game | | |
| M9 | 🚢 **v1.0 released** — Level 1 public, on itch.io + Play | | |
| M10 | 🚢 v1.1 — Level 2 live, saves migrated | | |
| M11 | 🚢 v1.2 — Level 3 live | | |
| M12 | 🏆 **v1.3 — *Ember Hollow* complete**, four levels + boss | | |

---

## 5. Chapter-by-chapter tracker

Tick as you go. `[ ]` not started · `[~]` in progress · `[x]` done · `[!]` done but shaky (revisit) · `[-]` skipped deliberately

### Module 0 — Toolchain, First APK & The Four Languages

[ ] 0.1 · [ ] 0.2 · [ ] 0.3 · [ ] 0.4 · [ ] 0.5 · [ ] 0.6
[ ] 0.7 · [ ] 0.8 **ship** ⭐ · [ ] 0.9 · [ ] 0.10 · [ ] 0.11 · [ ] 0.12
[ ] 0.13 · [ ] 0.14 · [ ] 0.15 · [ ] 0.16 · [ ] 0.17 · [ ] 0.18
[ ] 0.19 self-check

### Module 1 — Godot Foundations · P01

[ ] 1.1 · [ ] 1.2 · [ ] 1.3 · [ ] 1.4 · [ ] 1.4b 🧰 · [ ] 1.5
[ ] 1.6 · [ ] 1.7 · [ ] 1.8 · [ ] 1.9 · [ ] 1.10 (X) · [ ] 1.11
[ ] 1.11b 🧰 · [ ] 1.12 · [ ] 1.13 · [ ] 1.13b 🧰 · [ ] 1.14 · [ ] 1.15
[ ] 1.16 · [ ] 1.16b 🧰 · [ ] 1.17 · [ ] 1.18 · [ ] 1.19 · [ ] 1.20
[ ] 1.21 (X) · [ ] 1.22 · [ ] 1.23 · [ ] 1.24 · [ ] 1.24b 🧰 · [ ] 1.25
[ ] 1.25b 🧰 · [ ] 1.26 · [ ] 1.27 · [ ] 1.28 · [ ] 1.29 · [ ] 1.30
[ ] 1.31 · [ ] 1.32 · [ ] 1.33 · [ ] 1.33b 🧰 · [ ] 1.34 · [ ] 1.35
[ ] 1.36 · [ ] 1.37

### Module 2 — Android Runtime & Engineering Practice · P01

[ ] 2.1 · [ ] 2.2 · [ ] 2.3 · [ ] 2.4 · [ ] 2.5 · [ ] 2.6
[ ] 2.7 · [ ] 2.8 · [ ] 2.9 · [ ] 2.10 · [ ] 2.11 · [ ] 2.12
[ ] 2.13 · [ ] 2.14 · [ ] 2.15 · [ ] 2.16 (X) · [ ] 2.17 **ship** ⭐ · [ ] 2.18 jam
[ ] 2.19 self-check

### Module 3 — Blender I: Props & the Asset Pipeline · P02

[ ] B1 · [ ] B2 · [ ] B3 · [ ] B4 · [ ] X2.1 (X) · [ ] B5
[ ] B5b · [ ] B6 · [ ] B7 · [ ] B8 · [ ] B8b · [ ] B9
[ ] X2.2 (X) · [ ] B10 · [ ] B11 · [ ] B11b · [ ] B12 · [ ] B12b
[ ] B13 · [ ] B14 · [ ] B15 · [ ] B15b · [ ] B15c · [ ] B15d
[ ] B16 · [ ] B17 · [ ] B18 · [ ] B19 · [ ] B19b · [ ] 3.20
[ ] 3.21 · [ ] 3.22 · [ ] 3.22b 🧰 (X) · [ ] 3.23 **ship** ⭐ · [ ] 3.24 self-check

### Module 4 — Characters I: Rig & Animate · P03

[ ] B20 · [ ] B21 · [ ] B22 · [ ] B23 · [ ] B24 · [ ] B24b
[ ] B25 · [ ] B26 · [ ] B27 · [ ] B28 · [ ] B29 · [ ] B29b
[ ] B30 · [ ] 4.1 · [ ] 4.2 · [ ] 4.2b 🧰 · [ ] 4.3 · [ ] 4.4
[ ] 4.5 · [ ] 4.6 · [ ] 4.7 · [ ] 4.7b 🧰 · [ ] 4.8 · [ ] 4.9
[ ] 4.10 (X) · [ ] 4.11 · [ ] 4.12b 🧰 (X) · [ ] 4.13 **ship** ⭐ · [ ] 4.14 jam · [ ] 4.15 self-check

### Module 5 — Worlds, Lighting & Mobile Performance · P04

[ ] 5.1 · [ ] 5.2 · [ ] 5.2b 🧰 · [ ] 5.3 · [ ] 5.4 · [ ] 5.4b 🧰
[ ] 5.5 (X) · [ ] 5.6 · [ ] 5.7 · [ ] 5.8 · [ ] 5.9 · [ ] 5.9b 🧰
[ ] 5.10 · [ ] 5.11 · [ ] 5.12 · [ ] 5.13 · [ ] 5.14 · [ ] 5.15
[ ] 5.15b 🧰 · [ ] 5.16 · [ ] 5.17 · [ ] 5.18 (X) · [ ] 5.19 · [ ] 5.20
[ ] 5.21 · [ ] 5.22 · [ ] 5.22b 🧰 (X) · [ ] 5.23 **ship** ⭐ · [ ] 5.24 self-check

### Module 6 — Shaders & VFX · P05

[ ] 6.1 · [ ] 6.2 · [ ] 6.3 · [ ] 6.3b 🧰 · [ ] 6.4 · [ ] 6.5
[ ] 6.6 · [ ] 6.7 · [ ] 6.8 · [ ] 6.9 · [ ] 6.10 · [ ] 6.11
[ ] 6.12 · [ ] 6.13 · [ ] 6.14 · [ ] 6.15 · [ ] 6.16 · [ ] 6.16b 🧰
[ ] 6.17 · [ ] 6.18 · [ ] 6.18b 🧰 · [ ] 6.19 · [ ] 6.20 · [ ] 6.20b 🧰
[ ] 6.21 (X) · [ ] 6.22 · [ ] 6.22b 🧰 (X) · [ ] 6.23 **ship** ⭐ · [ ] 6.24 jam · [ ] 6.25 self-check

### Module 7 — Audio & Game Feel · P06

[ ] 7.1 · [ ] 7.2 · [ ] 7.2b 🧰 · [ ] 7.3 · [ ] 7.4 · [ ] 7.5
[ ] 7.6 · [ ] 7.7 · [ ] 7.8 · [ ] 7.9 · [ ] 7.10 · [ ] 7.11
[ ] 7.12 · [ ] 7.13 · [ ] 7.13b 🧰 · [ ] 7.14 (X) · [ ] 7.15 · [ ] 7.16
[ ] 7.17 · [ ] 7.18 (X) · [ ] 7.18b 🧰 (X) · [ ] 7.19 **ship** ⭐ · [ ] 7.20 self-check

### Module 8 — Story, Narrative & Cinematics · P07

[ ] 8.1 · [ ] 8.2 · [ ] 8.2b 🧰 · [ ] 8.3 · [ ] 8.4 · [ ] 8.5
[ ] 8.6 · [ ] 8.7 · [ ] 8.8 (X) · [ ] 8.9 · [ ] 8.10 · [ ] 8.10b 🧰
[ ] 8.11 · [ ] 8.12 · [ ] 8.13 · [ ] 8.14 · [ ] 8.15 · [ ] 8.15b 🧰
[ ] 8.16 · [ ] 8.17 · [ ] 8.18 · [ ] 8.19 · [ ] 8.20 · [ ] 8.21
[ ] 8.22 · [ ] 8.23 · [ ] 8.24 · [ ] 8.24b 🧰 · [ ] 8.24d 🧰 (X) · [ ] 8.25 **ship** ⭐
[ ] 8.26 jam · [ ] 8.27 self-check

### Module 9 — Characters II: Build Your Own · P08

[ ] B31 · [ ] B31b · [ ] B32 · [ ] B33 · [ ] B34 · [ ] B34b
[ ] B34c · [ ] B35 · [ ] B36 · [ ] B37 · [ ] B38 · [ ] B39
[ ] B40 · [ ] B41 · [ ] B41b · [ ] B42 · [ ] 9.1 · [ ] 9.2
[ ] 9.3 **ship** ⭐ · [ ] 9.4 self-check

### Module 10 — Architecture, Performance & Tooling · P09

[ ] 10.1 · [ ] 10.1b 🧰 · [ ] 10.1c 🧰 · [ ] 10.1c2 🧰 · [ ] 10.1c3 🧰 · [ ] 10.1d0 🧰
[ ] 10.1d 🧰 · [ ] 10.1e 🧰 · [ ] 10.1f 🧰 · [ ] 10.2 · [ ] 10.2b 🧰 · [ ] 10.3
[ ] 10.4 · [ ] 10.4b 🧰 · [ ] 10.5 · [ ] 10.6 · [ ] 10.7 · [ ] 10.6b 🧰
[ ] 10.7b 🧰 · [ ] 10.8 · [ ] 10.9 · [ ] 10.10 · [ ] 10.9b 🧰 · [ ] 10.10b 🧰
[ ] 10.11 · [ ] 10.11c 🧰 (X) · [ ] 10.12 **ship** ⭐ · [ ] 10.13 self-check

### Module 11 — Capstone: Ship, Then Keep Shipping · P10

[ ] 11.1 · [ ] 11.1b 🧰 · [ ] 11.2 · [ ] 11.3 · [ ] 11.4 · [ ] 11.5
[ ] 11.6 · [ ] 11.6b 🧰 · [ ] 11.7 · [ ] 11.8 · [ ] 11.8b 🧰 · [ ] 11.9
[ ] 11.10 · [ ] 11.11 · [ ] 11.12 · [ ] 11.13 · [ ] 11.13b 🧰 · [ ] 11.14
[ ] 11.15 · [ ] 11.16 · [ ] 11.17 · [ ] 11.18 · [ ] 11.19 · [ ] 11.20 🚢
[ ] 11.21 · [ ] 11.22 · [ ] 11.23 · [ ] 11.24 · [ ] 11.25 · [ ] 11.26
[ ] 11.27 · [ ] 11.28 🚢 · [ ] 11.29 · [ ] 11.30 🚢 · [ ] 11.31 · [ ] 11.32
[ ] 11.33 🏆 · [ ] 11.34 · [ ] 11.35 · [ ] 11.36 · [ ] 11.37 · [ ] 11.38 (X)
[ ] 11.39 self-check

### Module 12 — Beyond (optional)

[ ] 12.1 · [ ] 12.2 · [ ] 12.3 · [ ] 12.4 · [ ] 12.5 · [ ] 12.6
[ ] 12.7

---

## 6. Skills self-assessment

Re-rate every two modules. 1 = never done it · 2 = can follow a tutorial · 3 = can do it unaided · 4 = can do it well and explain why · 5 = can teach it.

| Skill | Start | M3 | M5 | M7 | M9 | M11 |
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
| 2026-09-01 | — | Session 001 — course inception: plan, ToC, 25 ADRs, 5 setup guides, 11 project briefs, meta + internal scaffolding | ✅ pushed to GitHub, commit `6219e4b` | — | Approve PLAN.md, decide the build machine (D-001), approve repo creation (T-001) |

---

---

## 📝 Changelog

| Version | Date | Change |
|---------|------|--------|
| 1.0 | 2026-09-01 | Created at course inception (Session 001). |
