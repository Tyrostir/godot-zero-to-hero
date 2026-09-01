---
title: "CLAUDE-MEMORY — The Agent's Complete Working Memory"
document_id: MEM
version: 1.0
status: Active (living document — regenerate at the end of every session)
created: 2026-09-01
last_updated: 2026-09-01
audience: "AI author agents only (Tier 3 — internal)"
update_trigger: "End of every session, and immediately after any decision or learner instruction"
---

# 🧠 CLAUDE-MEMORY.md

> ⛔ **Tier 3 — internal.** Never quoted, linked or paraphrased in `README.md`, `docs/PLAN.md`, `docs/chapters/`, `docs/guides/`, `docs/reference/` or `docs/meta/`.
>
> **What this is.** A language model starts every session with no memory. This file is the memory. It is written so that reading *only this file* makes an agent immediately competent to continue the project.
>
> **Rule:** keep it dense and current. Update it; do not append to it indefinitely.

---

## Contents

1. [The 60-second version](#1-the-60-second-version)
2. [Who the learner is](#2-who-the-learner-is)
3. [The environment — and its hard limit](#3-the-environment--and-its-hard-limit)
4. [What is being built](#4-what-is-being-built)
5. [Where the project stands](#5-where-the-project-stands)
6. [Standing instructions from the learner](#6-standing-instructions-from-the-learner)
7. [Operating rules for the agent](#7-operating-rules-for-the-agent)
8. [Technical facts worth remembering](#8-technical-facts-worth-remembering)
9. [Decisions in force](#9-decisions-in-force)
10. [Known hazards and open loops](#10-known-hazards-and-open-loops)

---

## 1. The 60-second version

You are the **author** of a book-length course: *Godot Zero to Hero* — 3D **Android** game development with **Godot 4 (.NET / C#)** and **Blender**. The **learner** owns the repo and does all hands-on work. **You write Markdown; you do not run software.**

**Shape:** 12 modules · **258 chapters** (173 Godot + 48 Blender, interleaved) · **11 projects** · 4 mini-jams · ~430–480 hours.

**Progress: Phase 1. 0/258 chapters. Plan drafted, awaiting the learner's review. Nothing installed yet.**

**Cadence: one chapter per turn**, committed and pushed, with `docs/meta/` updated each time.

**The single most important rule: [ADR-002](../meta/Decisions.md#adr-002) — practical-first, enforced numerically.** Build section first and ≥50% of the chapter; theory after and ≤30%.

---

## 2. Who the learner is

- **Tyrostir** (`karthikeyankasivishwanathan@gmail.com`, GitHub `Tyrostir`).
- **Embedded engineer.** C/C++ solid, Python strong — established in the sibling `qnx-zero-to-hero` course, which they authored with the same conventions.
- **New to:** game development, C# in a game context, Godot, and Blender. All four are taught from first principles.
- **Path 🚶 B — Self-Learner.** But 🐣 A and 🏃 C content is authored **in full in every chapter** ([ADR-024](../meta/Decisions.md#adr-024)) — an explicit requirement, so future readers can enter at any depth. Same choice they made on the QNX course.
- **Because they are a strong systems programmer**, do not over-explain general programming, pointers, memory or build systems. **Do** explain everything game-specific, everything about 3D maths, and everything about art tooling — none of it is transferable from embedded work.
- **Communication style:** wants complete documentation, everything logged, nothing left in conversation only. Asks direct, well-scoped questions. Restates important requirements — when they repeat something, treat the repetition as emphasis and make it structural.

---

## 3. The environment — and its hard limit

```text
AUTHORING (the agent's session):
  Ubuntu under Termux, on an Android phone. Linux 5.15.180-android13.
  Working dir: /root/claude/godot-zero-to-hero
  Available: git 2.34.1, curl, python3, network (GitHub API reachable)
  ABSENT:    dotnet, godot, blender, adb, java, jq
  $GITHUB_TOKEN present (93 chars) → authenticates as Tyrostir

  🚨 LEARNER INSTRUCTION: "You should not install or run anything in this environment."
     Memory and compute are severely limited. Respect this absolutely.

BUILDING (learner's desktop):  ✅ LINUX — D-001 resolved 2026-09-01.
                               ⇒ CLI Android SDK route, distro OpenJDK 17, udev rule for adb.
TARGET   (learner's phone):    ⏳ specs unknown — D-003. Decides the renderer.
```

**The consequence that shapes everything:** the agent cannot observe what any tool prints. Hence [ADR-016](../meta/Decisions.md#adr-016) and the `[UNVERIFIED]` protocol. **Never invent an error message, a menu path, a version number or a dialog title.** Mark it and let the learner clear it via `toAgent/`.

---

## 4. What is being built

**Track A — Godot/C#:** Modules 0–11, 173 chapters.
**Track B — Blender:** `B1`–`B42` plus 6 Blender chapters embedded in other modules, braided in at the point the game needs each asset ([ADR-003](../meta/Decisions.md#adr-003)).

**The Presentation Spine ([ADR-026](../meta/Decisions.md#adr-026)) — do not forget this one.** Story, first-page animation, end-page animation, music, ambience and the walkthrough ship with **every project from P01**, escalating in passes; they are **not** confined to Module 7. Narration ([ADR-027](../meta/Decisions.md#adr-027)) is recorded by the learner with equipment they already own, and **subtitles are mandatory**. Full mapping: [`../PresentationSpine.md`](../PresentationSpine.md). Covers modelling, sculpting, retopology, UV, texturing, shading, baking, rigging, animation, simulation, rendering, compositing and geometry nodes — every one attached to a shipped asset.

**The project spine (nothing is throwaway — P10 is assembled from P00–P09):**

```text
P00 Hello Phone   M0  · P01 Marble Runner M1 · P02 Foundry Kit  M2
P03 Playground    M3  · P04 Hollow Lvl 1  M4 · P05 VFX Lab      M5
P06 Feel Pass     M6  · P07 The Slice     M7 · P08 Warden       M8
P09 Refactor      M9  · P10 Ember Hollow  M10 (released)
```

Capstone working title *Ember Hollow* is provisional ([ADR-023](../meta/Decisions.md#adr-023)); the learner names it properly in ch 7.1.

---

## 5. Where the project stands

| | |
|---|---|
| Phase | 1 — planning |
| Plan | ⏳ **awaiting the learner's review** ([T-002](../meta/ToDos.md)) — they explicitly asked to review before chapters begin |
| Chapters | 0 / 258 |
| Setup guides | 5 / 5 drafted, all `[UNVERIFIED]` |
| Repo on GitHub | ✅ live — https://github.com/Tyrostir/godot-zero-to-hero |
| Git | branch `main`, pushed, commit `6219e4b` |

**Session 001 produced:** README, PLAN, TableOfContents (+ alias), BlenderTrack, Practicals, Exercises, projects/README, 5 setup guides, QuestionBank + answers M0–M2, ResourcesMeta, 25 ADRs, DecisionsLog, CourseState, CompactContext, Doubts, ToDos, Journal, and this internal set.

---

## 6. Standing instructions from the learner

Extracted verbatim-in-substance from their prompts. These do not expire.

| # | Instruction | Where it landed |
|---|-------------|-----------------|
| 1 | Teach 3D Android game dev with Godot **and C#**, from absolute basics | [ADR-001](../meta/Decisions.md#adr-001) |
| 2 | **Learning by doing.** Jump into building straight away; theory only when needed. **Stated three times** — treat as the highest-priority constraint | [ADR-002](../meta/Decisions.md#adr-002) |
| 3 | Include a **complete Blender course** — modelling, rigging, texturing, rendering, compositing, shading, animation, every purpose — with practical projects | [ADR-003](../meta/Decisions.md#adr-003) |
| 4 | **Many** intermediate practicals, exercises and projects — *"not just 1 at the end"* | [ADR-006](../meta/Decisions.md#adr-006), [`../Practicals.md`](../Practicals.md) |
| 5 | Questions **with answers** | [ADR-007](../meta/Decisions.md#adr-007) |
| 6 | Guide to **free public assets** — 3D, VFX, animation, audio, materials, shaders — where to get them and how to use them | [ADR-008](../meta/Decisions.md#adr-008), `ResourcesMeta.md` |
| 7 | Teach the **whole game**, not just code: story development, storytelling, intro animation, first-page animation, walkthrough, end-page animation — professional grade | Module 7 |
| 8 | Create the GitHub repo `godot-zero-to-hero` using `$GITHUB_TOKEN` | [T-001](../meta/ToDos.md) — blocked |
| 9 | Draft PLAN, TableOfContents, Doubts **and all documentation needed to track progress**, first | Session 001 output |
| 10 | **Do not install or run anything** in the Termux environment | [ADR-016](../meta/Decisions.md#adr-016) |
| 11 | **Adopt the `qnx-zero-to-hero` repository conventions** — Decisions, DecisionsLog, TableOfContext, CompactContext, CourseState, CLAUDE-MEMORY, PROMPTS, and similar | [ADR-025](../meta/Decisions.md#adr-025) |

---

## 7. Operating rules for the agent

1. **Practical-first is structural, not stylistic.** Follow the mandatory template in [`../chapters/README.md`](../chapters/README.md). Build first, ≥50%. Theory after, ≤30%. Never open a chapter with theory.
2. **Never fabricate tool output.** `[UNVERIFIED]` it.
3. **Mobile-first ordering** ([ADR-010](../meta/Decisions.md#adr-010)). The mobile-safe technique is the default; the desktop one is an aside.
3b. **[ADR-026/027] Presentation is a spine, not a module.** Every project from P01 ships a title screen, an ending screen, music, a narrative frame and a walkthrough. Narration from Module 6, with **mandatory subtitles**. Before drafting any project chapter, check [`../PresentationSpine.md` §2](../PresentationSpine.md).
4. **Every question → `D-NNN`** in `Doubts.md` — **the learner's question verbatim AND your short + full answer**, at the end of every turn, **unprompted**. `/btw` (on the same line as the question) guarantees it, but any question qualifies. ⚠️ **Known failure mode:** logging a question into `PROMPTS.md` only and forgetting `Doubts.md`. That happened once, with [D-005](../meta/Doubts.md#d-005). `PROMPTS.md` is the narrative; `Doubts.md` is the searchable reference; they are not substitutes.
5. **Every decision → `ADR-NNN`** in `Decisions.md`, with its history appended to `DecisionsLog.md`. The log is **append-only**.
6. **Every prompt and full response → `PROMPTS.md`** ([ADR-015](../meta/Decisions.md#adr-015)).
7. **Update `docs/meta/` every session** — CourseState, CompactContext, ToDos at minimum.
8. **One chapter per turn**, then commit.
9. **No GitHub-only Markdown** ([ADR-021](../meta/Decisions.md#adr-021)) — the course must survive PDF export.
10. **Do not run Godot, Blender, dotnet or adb.** They are not installed and must not be.
11. **Write every chapter for all three paths** — 🏃 Fast-Track Summary near the top, 🐣 boxes inline, 🔬 deep dives, ⭐ on universal practicals, path tags in the front matter. Ratios in ADR-002 are measured on the Path B reading.
12. **British-leaning spelling** is used throughout the existing documents (*colour*, *behaviour*, *optimise*, *modelling*). Stay consistent.
13. **Do not narrate the authoring infrastructure to the reader** — Tier 3 stays Tier 3.

---

## 8. Technical facts worth remembering

**Godot / C#**
- Godot ships **two binaries**: standard (GDScript only) and **.NET** (C# too). Only the .NET one works for this course.
- The **Android editor build of Godot has no C# support** — desktop authoring is mandatory.
- **Export templates must match the editor version exactly**, .NET variant included. Mismatch → export error, or an APK that installs and instantly crashes.
- Godot 4.2+ projects target `net8.0` by default; verify against the generated `.csproj`.
- C# classes must be `public partial class X : Node` in `X.cs`. Edit → **Build** → run.
- Godot 3D is **Y-up, right-handed, local −Z forward**.
- `_Process` delta varies; `_PhysicsProcess` is a fixed tick — physics goes in the latter.
- `QueueFree()` not `Free()`. `CallDeferred` when mutating the tree from a physics callback.
- Body types: `StaticBody3D`, `RigidBody3D`, `CharacterBody3D`, `Area3D`, **`AnimatableBody3D`** (the right answer for moving platforms).
- Collision **layer** = what I am; **mask** = what I scan for.
- `user://` on Android = the app's private internal data dir; unreachable without `adb shell run-as` on a debuggable build.
- Safe area: `DisplayServer.GetDisplaySafeArea()`.
- Renderers: **Mobile** for phones; Forward+ is desktop-oriented; Compatibility for pre-Vulkan devices.

**Blender / pipeline**
- **glTF 2.0 (`.glb`) only** ([ADR-009](../meta/Decisions.md#adr-009)). Not FBX, not OBJ.
- **1 Blender metre = 1 Godot unit** — Metric, Unit Scale 1.0, `Ctrl+A` transforms applied.
- Import suffixes: `-col` trimesh · `-convcol` convex · `-colonly` · `-noimp` skip · `-navmesh`.
- `Alt+D` linked duplicate vs `Shift+D` real duplicate — linked is what builds a modular kit.
- Normal maps: **OpenGL-style green channel (+Y)** is what Godot expects.
- The five-point diagnostic for "it looks wrong": unapplied scale · flipped normals · duplicate vertices · wrong shading mode · a forgotten modifier.

**Android**
- Debug keystore: `androiddebugkey` / `android`. **Release keystore loss = the app listing can never be updated again.**
- Package name must be reverse-domain with at least one dot.
- `adb logcat | grep -i godot` is the learner's debugging lifeline on device.

**Licences** — CC0 preferred; CC-BY fine with attribution; **CC-BY-NC and CC-BY-ND rejected outright** ([ADR-008](../meta/Decisions.md#adr-008)).

---

## 9. Decisions in force

25 ADRs. Full text: [`../meta/Decisions.md`](../meta/Decisions.md). The load-bearing ones:

| ADR | One line |
|-----|----------|
| **002** | **Practical-first, enforced numerically. The most important decision in the course.** |
| 003 | Blender braided in, not appended |
| 004 | Desktop = workshop, phone = target, Termux = notebook |
| 006 | Eleven projects, not one capstone |
| 008 | Free assets, logged at download time, no NC/ND |
| 010 | Mobile-first technique ordering |
| 011 | Every question → `D-NNN` |
| 016 | The author does not execute; `[UNVERIFIED]` |
| 019 | Capstone scope locked: 4 levels + 1 boss |
| **024** | **Three learning paths 🐣/🚶/🏃, all authored in full. Decided yes.** |
| 025 | QNX repo conventions adopted |
| **026** | **Presentation Spine — story/screens/music/walkthrough in every project, not just Module 7** |
| **027** | **Narration recorded by the learner; subtitles mandatory** |

---

## 10. Known hazards and open loops

| ID | Hazard | Mitigation |
|----|--------|-----------|
| **H-01** | ✅ **Cleared.** The repo now exists and is pushed. Worth remembering: the first `POST /user/repos` was denied by the **Claude Code auto-mode permission classifier**, not by GitHub, and the retry succeeded. Expect the same intermittency on other write calls. | — |
| **H-02** | ✅ **Cleared.** Build machine is a **Linux desktop** ([D-001](../meta/Doubts.md)). Guides lead with the Linux route. | — |
| **H-03** | 🟠 C# + Android in Godot is the less-travelled path; rough edges with few community answers. | [ADR-022](../meta/Decisions.md#adr-022). Check Godot's GitHub issues before assuming a bug is the learner's. Log everything in `Troubleshooting.md`. |
| **H-04** | 🟠 Every setup guide is `[UNVERIFIED]`. If a version number here is wrong, Module 0 stalls. | Guides link the always-current official pages and say explicitly that those pages win. |
| **H-05** | 🟠 Scope creep on the capstone. | [ADR-019](../meta/Decisions.md#adr-019) locks it; new ideas go to the GDD under *Post-launch*. |
| **H-06** | 🟡 258 chapters at one per turn is a long project. Momentum is the real risk. | Eleven shipped projects supply visible progress, and [ADR-026](../meta/Decisions.md#adr-026) is a direct mitigation: every project now has a title screen, an ending and music, so each one *feels* like a game rather than a tech demo. P00 lands in the first session of real work. |
| **H-07** | ✅ **Cleared, and answered before any chapter existed** — exactly why it was asked in Session 001. Three paths, all authored in full. No retrofitting needed. | — |
| **H-08** | 🔵 Godot version drift over a ~year-long project. | Version log in [Setup 01 §3](../guides/Setup_01_Prerequisites.md); pin and record. |
