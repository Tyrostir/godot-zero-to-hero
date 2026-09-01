---
title: "Decisions Log — Append-Only History"
document_id: DECLOG
version: 1.0
status: Active (append-only living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "Every time a decision is made, revisited, superseded or reversed"
---

# 🧾 DecisionsLog.md

> **Append-only.** Nothing in this file is ever edited or deleted — only appended.
> [`Decisions.md`](Decisions.md) tells you **what is true now**.
> This file tells you **what was decided, when, why, what was rejected, and what changed**.

**Entry types**

| Type | Meaning |
|------|---------|
| 🆕 `DECIDED` | A new decision was made |
| 🔄 `REVISED` | An existing decision was modified |
| ⛔ `SUPERSEDED` | A decision was replaced by a newer one |
| ↩️ `REVERSED` | A decision was undone entirely |
| ❓ `DEFERRED` | A decision was consciously postponed |
| 🔍 `VERIFIED` | An assumption was checked against reality |

---

## 2026-09-01 — Session 001 (Course inception)

### 🔍 VERIFIED — The authoring environment

**Context.** Before designing anything, the environment this course is written in was inspected directly.

| Item | Result |
|------|--------|
| Platform | Linux 5.15.180-android13 — **Ubuntu under Termux on an Android phone** |
| Working directory | `/root/claude/godot-zero-to-hero` (empty, then `git init`) |
| `git` | 2.34.1 ✅ |
| `curl` | ✅ · `python3` ✅ |
| `jq` | ❌ absent |
| `dotnet` | ❌ absent |
| `godot` | ❌ absent |
| Network | ✅ `api.github.com` reachable (HTTP 200) |
| `$GITHUB_TOKEN` | ✅ present, 93 chars, authenticates as **Tyrostir** |

**Why it matters.** This is the decisive constraint on the whole project. The author **cannot run Godot, Blender, `dotnet` or `adb`**, and has been instructed not to install anything. Every claim about tool output is therefore unverifiable from here.

**Consequence.** [ADR-016](Decisions.md#adr-016) — the `[UNVERIFIED]` protocol — exists because of this finding. It is not a stylistic choice; it is the honest response to a real limitation.

---

### 🆕 DECIDED — ADR-001: Godot 4 (.NET) + C#, 3D, Android

**Context.** Learner's opening request: *"teach me 3D game development for android using GoDot with C#."*

**Decision.** Godot 4.x .NET build, C#, 3D, Android target.

**Rejected.**
- *GDScript* — easier and far better documented for Godot, and would allow developing on the phone itself. Rejected because C# was explicitly requested and is the more transferable skill.
- *Unity* — better Android C# documentation, but a paid tier, a revenue share, and a much heavier install. Not requested.

**Consequence.** [ADR-022](Decisions.md#adr-022) records the accepted cost.

---

### 🆕 DECIDED — ADR-002: The Practical-First Mandate

**Context.** Stated by the learner three separate times, and reinforced mid-session: *"I want you to jump into project development / coding straight-away and start explaining theories whenever needed"*, *"I want to give importance to practicals (doings) along with theories when really needed"*, and — restated during this very session — *"strictly draft this … as learning by doing approach (with relevant theories whenever needed) with lot of intermediate practicals, exercises, and many intermediate projects."*

**Decision.** Practical-first is made **structural rather than stylistic**: a mandatory chapter template in which the Build section must come first and occupy ≥50% of a chapter, and theory must follow and stay ≤30%. A chapter that cannot open with a build is declared wrongly scoped.

**Why enforce it with numbers.** Because "practical-first" is easy to agree with and easy to drift away from. A percentage is checkable; an intention is not.

**Rejected.** A conventional "theory chapter, then lab" structure — which is what most engine courses do, and which the learner has explicitly rejected twice.

---

### 🆕 DECIDED — ADR-003: Blender braided in, not appended

**Context.** Learner asked for a *"complete blender course with respect to 3d game development — whenever needed"* covering modelling, rigging, texturing, rendering, compositing, shading and animation.

**Decision.** 42 Blender chapters (`B1`–`B42`) interleaved at the point the game needs each asset.

**Rejected.**
- *Blender first, then Godot* — delays the first playable build by months.
- *Blender as an appendix* — means every asset until then belongs to someone else, and the learner never owns their own art pipeline.

---

### 🆕 DECIDED — ADR-005 & ADR-006: Device on day one; eleven projects

**Context.** Learner asked for *"multiple practicals, exercises, intermediate projects (not just 1 at the end)."*

**Decision.** P00 ships to a real phone in Module 0. Eleven projects total (P00–P10), plus four mini-jams. Every project is playable and deployed; the capstone is assembled from its predecessors.

**Why the device on day one.** Six independent tools must cooperate for an APK to install. Isolating that chain while the game is one cube converts a recurring mystery into a one-time debugging exercise.

---

### 🆕 DECIDED — ADR-010: Mobile-first technique ordering

**Context.** The target is a mid-range Android phone; the learner's own development phone is the primary test device.

**Decision.** Where a technique has desktop and mobile variants, the mobile variant is the default taught, and the desktop one is an aside.

**Why.** Nearly all Godot 3D material online assumes a desktop GPU. Teaching desktop-first and "optimising later" produces architectural problems that cannot be fixed incrementally — baked-vs-realtime lighting and atlas-vs-per-object materials are both decisions, not tunings.

---

### 🆕 DECIDED — ADR-008: Free assets, logged at download time

**Context.** Learner asked to be guided to *"publicly available free resources, 3d assets, vfx, animations, audio, materials, shaders"* and how to obtain and use them.

**Decision.** CC0 preferred; CC-BY acceptable with attribution; **CC-BY-NC and CC-BY-ND rejected outright**. Every download is logged in `AssetLicenses.md` immediately.

**Why the hard rejection of NC.** A free game with a donation link, ads, or an eventual paid release is arguably commercial. By the time that question arises, the asset is baked into forty scenes. The cost of avoiding NC up front is approximately zero, because CC0 alternatives exist for everything this course needs.

**Consequence.** Chapter 7.19 generates the in-game credits roll from the ledger, so the discipline pays for itself.

---

### 🆕 DECIDED — ADR-025: Adopt the `qnx-zero-to-hero` repository conventions

**Context.** Mid-session the learner directed: *"refer qnx-zero-to-hero repository from same github account and think which of the files and folder structures we can adopt."*

**Findings.** The QNX repo was read directly via the GitHub API. Its conventions:

| Convention | Adopted? |
|---|---|
| YAML front matter (`title`, `document_id`, `version`, `status`, `created`, `last_updated`, `update_trigger`) | ✅ |
| `docs/meta/` — CourseState, CompactContext, Decisions, DecisionsLog, Doubts, ToDos | ✅ |
| `docs/internal/` — CLAUDE-MEMORY, onboarding guides, VerificationRuns | ✅ |
| `docs/reference/` — Glossary, ReferenceLinks, ResourcesMeta, cheatsheets | ✅ |
| `docs/guides/` — numbered setup guides | ✅ |
| `docs/chapters/` — `ChapterNN_PascalCase.md` + template README | ✅ |
| Root `PROMPTS.md` — verbatim prompts + full responses | ✅ |
| `toAgent/` — learner-captured output | ✅ |
| Three document tiers | ✅ |
| `ADR-NNN` / `D-NNN` / `T-NNN` identifier schemes | ✅ |
| `/btw` question convention | ✅ |
| `[UNVERIFIED]` clearance protocol | ✅ — and *more* load-bearing here than in QNX, since nothing at all can be run |
| `TableOfContents.md` + `TableOfContext.md` alias | ✅ |
| `labs/` with `skeleton/` `solution/` `prebuilt/` | 🔄 **Adapted** → `projects/`, see below |
| Three learning paths 🐣🚶🏃 | ⏳ **Deferred** → [ADR-024](Decisions.md#adr-024) |

**Adaptation — `labs/` → `projects/`.** QNX's lab structure (`skeleton/` with TODOs, `solution/`, `prebuilt/` binaries) suits small self-contained C programs. A Godot project is a whole scene tree plus assets, and cannot be meaningfully "prebuilt" for a learner without a running engine. `projects/P00…P10/` therefore holds cumulative, evolving Godot projects rather than isolated exercises; the `skeleton`/`solution` idea survives as **⭐ practicals inside chapters** and the drills in `Exercises.md`.

---

### ❓ DEFERRED — ADR-024: Three learning paths

**Context.** The QNX course authors 🐣/🚶/🏃 paths in full in every chapter (its ADR-008).

**Deferred, not rejected.** Recommendation recorded in [ADR-024](Decisions.md#adr-024): use lightweight ⭐ (must-do) and 🔬 (optional deep dive) markers instead of three full paths, because this course's Build/Why split already provides the fast-track/deep-dive separation structurally. Awaiting the learner's decision. Chapters are written single-path until then.

---

### 🔍 VERIFIED — GitHub identity

`GET /user` with `$GITHUB_TOKEN` returns login **Tyrostir**. The `qnx-zero-to-hero` repository exists under the same account (public, default branch `main`, ~2.2 MB).

**Blocked.** `POST /user/repos` to create `godot-zero-to-hero` was **denied by the Claude Code auto-mode permission classifier**, not by GitHub. Recorded as [T-001](ToDos.md). The repository does not yet exist; everything is committed locally on branch `main` pending the learner's approval of the creation call.

---
