---
title: "Practicals Index — Every Hands-On Unit in the Course"
document_id: PRAC
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When a practical, drill, challenge, jam or project is added or renumbered"
---

# 🏋️ Practicals Index

> **The point of this document.** [ADR-002](meta/Decisions.md#adr-002) says this course is practical-first. This page is the proof, and the audit trail: **every hands-on unit in the course, counted and named**, so the claim can be checked rather than believed.

---

## 1. The five kinds of hands-on work

| Kind | Marker | What it is | Where it lives | Count |
|------|--------|-----------|----------------|-------|
| **Chapter Build** | 🔨 | The mandatory first section of *every* chapter. You are building within the first screen of text. | Inside each chapter | **348** |
| **Chapter Practical** | 🏋️ | 1–3 drills at the end of each chapter that *change* what you just built | Inside each chapter | **~690** |
| **Standalone Drill / Challenge / Autopsy** | 🔁 / 🧗 / 🔍 | Repeatable skill-builders, unscaffolded challenges, and analyses of existing work | [`Exercises.md`](Exercises.md) | **44** |
| **Project** | 🚢 | A complete, playable, deployed-to-phone milestone | [`../projects/README.md`](../projects/README.md) | **11** |
| **⬜ Blank-page build** | ⬜ | **Requirements only. No steps, no reference implementation, no code.** One per major subsystem | [`meta/Decisions.md#adr-033`](meta/Decisions.md#adr-033) | **8** |
| **Mini-Jam** | ⏱️ | Timeboxed, constrained, *no help given* | [`../projects/README.md#mini-jams`](../projects/README.md#mini-jams) | **4** |
| **Presentation deliverable** | 🎬 | A title screen, ending screen, music pass, narration or walkthrough shipped with a project | [`PresentationSpine.md`](PresentationSpine.md) | **34** |
| **Library adoption** | 🧰 | Install a free library, read its source, measure it on device, and record a decision | [`Toolchain.md`](Toolchain.md) | **~45 (L1+L2)** |

**Total distinct hands-on units: ~1,150.**
**Chapters that begin with theory: 0.** That is a hard rule, not an aspiration ([ADR-002](meta/Decisions.md#adr-002)).

> 🐣🚶🏃 **Paths and practicals** ([ADR-024](meta/Decisions.md#adr-024)). ⭐ practicals are done by **every** path — they are the ones without which the chapter didn't happen. Unmarked practicals are Paths A and B. 🔬 deep-dive practicals are Paths B and C. Path A gets complete code listings for every build; Path C gets the Fast-Track Summary and the ⭐ practicals only.

---

## 2. The ratio, per module

Every chapter is ≥50% doing and ≤30% theory, by mandate. Here is what that produces:

| Module | Chapters | Builds | Chapter practicals | Standalone | 🎬 Present. | 🧰 Adopt | ⬜ Blank | Project | Jam |
|--------|---------|--------|--------------------|-----------|------------|---------|--------|---------|-----|
| 0 — Toolchain & Languages | 19 | 19 | ~30 | 2 | — | 5 | — | 🚢 **P00** | — |
| 1 — Godot + Android Eng. | 63 | 63 | ~126 | 7 | 4 | 6 | 1 | 🚢 **P01** | ⏱️ MJ1 |
| 2 — Blender I | 35 | 35 | ~70 | 6 | 2 | 7 | 1 | 🚢 **P02** | — |
| 3 — Characters I | 30 | 30 | ~60 | 6 | 3 | 3 | 1 | 🚢 **P03** | ⏱️ MJ2 |
| 4 — Worlds & Performance | 29 | 29 | ~58 | 6 | 5 | 5 | 1 | 🚢 **P04** | — |
| 5 — Shaders & VFX | 30 | 30 | ~60 | 6 | 1 | 4 | 1 | 🚢 **P05** | ⏱️ MJ3 |
| 6 — Audio, Narration & Feel | 23 | 23 | ~46 | 4 | 6 | 2 | 1 | 🚢 **P06** | — |
| 7 — Story & Cinematics | 32 | 32 | ~64 | 6 | 5 | 5 | 1 | 🚢 **P07** | ⏱️ MJ4 |
| 8 — Characters II | 20 | 20 | ~40 | 4 | 1 | 4 | — | 🚢 **P08** | — |
| 9 — Architecture & C++ | 28 | 28 | ~56 | 3 | 2 | 7 | 1 | 🚢 **P09** | — |
| 10 — Capstone | 32 | 32 | ~54 | 2 | 2 | 3 | — | 🚢 **P10** | — |
| 11 — Beyond | 7 | 7 | ~14 | — | — | 1 | — | — | — |
| **Total** | **348** | **348** | **~690** | **52** | **31** | **~45** | **8** | **11** | **4** |

---

## 3. What you have actually built, by the end of each module

This is the honest test of a practical course — not "what did you cover", but **what exists now that didn't before**.

| After | You physically possess |
|---|---|
| **Module 0** | A signed APK, made by you, installed on your own phone |
| **Module 1** | A finished 3-level 3D game with touch controls, HUD, pause, save, level select — **an animated title screen, a results screen and music** |
| **Module 2** | A 14-piece art kit **you modelled, unwrapped, textured and baked** — one atlas, under 12k triangles |
| **Module 3** | A character that walks, runs, jumps and lands, driven by a state machine you wrote — **idling on your title screen** |
| **Module 4** | A real, lit, art-passed level holding 60fps on your actual phone, an ambience bed, a menu flythrough, and **a level a stranger can finish with no tutorial prompt** |
| **Module 5** | Six shaders you wrote by hand, four particle effects, and a smoke flipbook you simulated in Blender |
| **Module 6** | A before/after recording proving what sound and timing do to a game — **and your own recorded, mixed, subtitled narration** |
| **Module 7** | An unbroken flow from splash screen to credits, with a dialogue system a designer could edit |
| **Module 8** | **Your own character** — sculpted, retopologised, UV'd, baked, textured, rigged, animated, in-game |
| **Module 9** | A codebase with zero per-frame allocations, unit tests, graphics tiers and an editor validation tool |
| **Module 10** | 🏆 **A released Android game**, on itch.io and in Play internal testing, with a trailer |

---

## 4. The named challenges

The unscaffolded ones — no instructions, no walkthrough. These are where you find out what you can do alone.

| ID | Module | Challenge |
|----|--------|-----------|
| C0.1 | 0 | Break the export pipeline three ways; document every error message |
| C1.1 | 1 | Invent a third control scheme for the marble that isn't obviously terrible |
| C1.2 | 1 | Make the save system survive four distinct failure modes |
| C2.1 | 2 | Build a scene where *every* object shares one material and one 1024 texture |
| C2.2 | 2 | Halve a model's triangles with no visible change — then halve it again |
| C3.1 | 3 | Add a dodge-roll with i-frames, cooldown and clean blending, from scratch |
| C3.2 | 3 | Make every animation state interruptible at any frame without popping |
| C4.1 | 4 | ⭐ Deliberately build a 20fps scene, then take it to 60fps documenting every change |
| C4.2 | 4 | Light one room three ways — dawn, noon, lantern — all holding framerate |
| C5.1 | 5 | An impact effect that reads at phone size and costs under 0.5 ms of GPU |
| C5.2 | 5 | A scene that looks good using only procedural shaders — no image textures |
| C6.1 | 6 | Improve game feel using **only** tweens, timing and audio |
| C7.1 | 7 | Tell a complete story in 60 seconds with no words |
| C7.2 | 7 | Make an intro cinematic a playtester chooses not to skip |
| C8.1 | 8 | Deliver the Warden under 20k triangles with no visible quality loss |
| C9.1 | 9 | Hand your codebase to someone with no explanation; every question is a bug |
| C10.1 | 10 | ⭐ **The stranger test** — hand a stranger the APK, say nothing, watch |

> 💡 **C4.1 and C10.1 are the two most professionally useful exercises in the entire course.** One teaches you to optimise with evidence instead of superstition; the other teaches you that your game is not what you think it is.

---

## 5. The three-pass spiral

Practical-first only works if you meet things more than once. Every major topic appears three times, at increasing depth ([ADR-002](meta/Decisions.md#adr-002)):

| Topic | 1️⃣ Naive | 2️⃣ Correct | 3️⃣ Professional |
|-------|----------|-----------|-----------------|
| Movement | Set position directly (1.4) | Physics + delta + state machine (1.13, 3.7) | Coyote time, buffering, pooling, no allocations (3.8, 9.2) |
| Lighting | One directional light (0.8) | Shadows, environment, GI options (4.6–4.8) | Baked lightmaps within a measured mobile budget (4.9, 4.12) |
| Materials | Default `StandardMaterial3D` (1.2) | PBR maps authored in Blender (B13–B16) | One atlas, packed channels, batched draw calls (B12, 4.15) |
| Character art | A CC0 placeholder (P03) | Retargeted Mixamo on a borrowed rig (B29) | Your own sculpt→retopo→rig→animate (P08) |
| 🧰 State machines | Hand-written FSM (3.7) | LogicBlocks / State Charts compared (3.7b) | Serialisable hierarchical states in the capstone AI (10.6b) |
| 🧰 Rigging | Hand-built armature (B21–B23) | Rigify meta-rig generation (B24b) | A rig another animator could use (B39) |
| Saving | JSON to `user://` (1.33) | Versioned with migration (9.7) | Tested, corruption-tolerant, device-verified (C1.2, 9.9) |
| 🎬 Title screen | Tween + `AnimationPlayer` (1.35) | Live 3D character, camera drift (3.12); your own shaders (5.22) | Directed, scored, narrated opening (7.16–7.18) |
| 🏁 Ending | A results card (1.36) | End card with a stinger (P06) | Narrated payoff into credits over a theme (7.21–7.22) |
| 🎵 Music | One loop, three SFX (1.37) | Adaptive layers, ambience (4.22, 6.6–6.7) | Full mix, ducking, per-bus volume, subtitles (6.11, 9.8) |
| 🔊 Narration | — | Record, clean, duck, caption (6.8–6.12) | Cue-driven system, directed, localised (7.6, 7.11, 7.13) |
| 🚶 Walkthrough | Teach by level shape (4.21) | Directed onboarding with narration (7.19) | A written player guide, and the design fixes it forces (10.20) |
| UI | Anchored labels (1.28) | Themes and containers (1.30) | Safe area, scaling, accessibility (1.29, 10.13) |

**Never all three at once.** Meeting the naive version first is what makes the correct version *make sense* rather than *be memorised*.

---

## 6. Tracking

Tick practicals in [`meta/CourseState.md §5`](meta/CourseState.md). Log what you had to look up in [`meta/Journal.md`](meta/Journal.md) — that column is your real skill map.
