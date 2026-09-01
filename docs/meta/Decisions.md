---
title: "Decisions — Active Architecture Decision Records"
document_id: DEC
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "Whenever a decision is made, changed, or superseded"
---

# ⚖️ Decisions.md

> **What this document is:** the **current, active** set of decisions governing this course — the *what*.
> **What it is not:** a history. Superseded decisions are *removed* from here and preserved forever in [`DecisionsLog.md`](DecisionsLog.md) — the *why and when*.
>
> Read this file to know **how things are**. Read `DecisionsLog.md` to know **how we got here**.

**Status key:** ✅ Active · 🔄 Provisional (may change with new information) · ⏳ Pending your input

---

## Index

| ID | Decision | Category | Status |
|----|----------|----------|--------|
| [ADR-001](#adr-001) | Godot 4.x **.NET build** with **C#** is the engine and language | Product | ✅ |
| [ADR-002](#adr-002) | **The Practical-First Mandate** — every chapter opens with a build | Pedagogy | ✅ |
| [ADR-003](#adr-003) | Blender is **braided into** the course, not appended to it | Pedagogy | ✅ |
| [ADR-004](#adr-004) | Desktop = workshop · phone = target · Termux = notebook | Environment | ✅ |
| [ADR-005](#adr-005) | Ship to a real device in **Module 0**, not at the end | Pedagogy | ✅ |
| [ADR-006](#adr-006) | **Eleven** projects plus mini-jams — not one capstone | Pedagogy | ✅ |
| [ADR-007](#adr-007) | Every chapter ends with exercises **and** answered self-check questions | Pedagogy | ✅ |
| [ADR-008](#adr-008) | Free assets only; every asset logged at **download time** | Legal | ✅ |
| [ADR-009](#adr-009) | **glTF 2.0** is the only Blender→Godot transfer format | Pipeline | ✅ |
| [ADR-010](#adr-010) | **Mobile-first**: the mobile-safe technique is always taught first | Product | ✅ |
| [ADR-011](#adr-011) | Every question becomes a permanent `D-NNN` artefact; `/btw` convention | Process | ✅ |
| [ADR-012](#adr-012) | `TableOfContents.md` is canonical; `TableOfContext.md` is an alias | Docs | ✅ |
| [ADR-013](#adr-013) | Mermaid for all diagrams | Docs | ✅ |
| [ADR-014](#adr-014) | Documents are organised in **three tiers**; `docs/internal/` is Tier 3 | Docs | ✅ |
| [ADR-015](#adr-015) | `PROMPTS.md` records every learner prompt **and** every full response | Process | ✅ |
| [ADR-016](#adr-016) | The author does not execute Godot/Blender/adb; `[UNVERIFIED]` protocol | Process | ✅ |
| [ADR-017](#adr-017) | **One chapter per turn**, committed and pushed | Process | ✅ |
| [ADR-018](#adr-018) | Course content CC BY-SA 4.0; project code MIT | Legal | ✅ |
| [ADR-019](#adr-019) | Capstone scope is **locked** at 4 levels + 1 boss | Product | ✅ |
| [ADR-020](#adr-020) | Chapter files are `ChapterNN_PascalCaseTitle.md` | Docs | ✅ |
| [ADR-021](#adr-021) | No GitHub-only Markdown syntax | Docs | ✅ |
| [ADR-022](#adr-022) | C# on Android is knowingly the less-travelled path | Product | ✅ |
| [ADR-023](#adr-023) | Capstone working title is *Ember Hollow* | Product | 🔄 |
| [ADR-024](#adr-024) | Learning paths (🐣/🚶/🏃) as in the QNX course | Pedagogy | ⏳ |
| [ADR-025](#adr-025) | Repository conventions adopted from `qnx-zero-to-hero` | Docs | ✅ |

---

## ADR-001
### Godot 4.x (.NET build) with C# is the engine and language
**Status:** ✅ Active · **Category:** Product

Godot 4's `.NET` build, scripting in **C#**, targeting **Android**, in **3D**.

**Why.** Directly requested. C# is also the more transferable skill — it carries to Unity, to backend work, and to general software engineering in a way GDScript does not. Godot is free, open source, has no revenue share, exports to Android natively, and its 3D renderer has a dedicated Mobile path.

**Consequences.** See [ADR-022](#adr-022) — C# on Android is a genuinely less-travelled path and we accept that cost deliberately.

---

## ADR-002
### The Practical-First Mandate
**Status:** ✅ Active · **Category:** Pedagogy · **This is the most important decision in the course.**

**Every chapter opens with a build.** Theory appears only *after* the learner has felt the need for it, and never before. This is structural, not stylistic — it is enforced by the mandatory chapter template.

**The mandatory chapter shape** (see [`../chapters/README.md`](../chapters/README.md)):

| # | Section | Rule |
|---|---------|------|
| 1 | 🎯 **Goal** | One sentence: what will exist at the end that does not exist now |
| 2 | 🔨 **Build** | Step-by-step doing. **Must be the first substantive section. Must be ≥ 50% of the chapter.** |
| 3 | 🧠 **Why it works** | The theory this build needed — and *only* that. **Must be ≤ 30% of the chapter.** |
| 4 | 💥 **Break it** | A deliberate sabotage and the error it produces |
| 5 | 🏋️ **Practicals** | 1–3 drills that change the build |
| 6 | ✅ **Check yourself** | 3–5 questions, answers collapsed inline |
| 7 | 📎 **Cheat sheet** | Everything introduced, in one table |
| 8 | 💾 **Commit** | The exact commit message |

**Hard rules.**

1. **No chapter may begin with a theory section.** If a concept genuinely cannot be built before it is explained, the chapter is wrongly scoped — split it, or find a cruder version that *can* be built first.
2. **The three-pass spiral.** Every major topic is met three times: *naive* (simplest thing that works) → *correct* (why the naive version is wrong, rebuilt properly) → *professional* (performance, memory, tooling, data-driving, testing). Never all three at once.
3. **Every chapter ends with something runnable.** If you cannot press play at the end of a chapter, the chapter is not finished.
4. **Theory is a debrief, never a gate.**

**Why.** Explicitly and repeatedly requested by the learner. It is also simply the better method: motivation, retention and transfer are all substantially higher when a concept arrives attached to a problem the learner has personally hit.

---

## ADR-003
### Blender is braided into the course, not appended to it
**Status:** ✅ Active · **Category:** Pedagogy

The 42-chapter Blender track (`B1`–`B42`, see [`../BlenderTrack.md`](../BlenderTrack.md)) is interleaved with the Godot track at the point the game needs the asset — never taught as a standalone block.

**Why.** A separate "Blender course" at the front would delay the first playable build by months and kill momentum. A separate one at the back means every asset until then is someone else's. Braiding means you learn UV unwrapping *because Level 1's crate looks wrong*, which is when it actually sticks.

**Consequence.** Chapter numbering interleaves `A` (Godot) and `B` (Blender) chapters. The Table of Contents is the authority on order.

---

## ADR-004
### Desktop = workshop · phone = target · Termux = notebook
**Status:** ✅ Active · **Category:** Environment

All authoring happens on a desktop or laptop. The Android phone is the deployment target. The Termux session is for planning, documentation, git and conversation only.

**Why.** Godot's Android editor build has **no C#/.NET support** — C# requires a desktop .NET SDK and MSBuild. This is a hard constraint of the toolchain, not a preference.

---

## ADR-005
### Ship to a real device in Module 0
**Status:** ✅ Active · **Category:** Pedagogy

Project 00 puts a signed APK on the learner's phone before any game concept is taught.

**Why.** Six independent tools must cooperate for an APK to reach a device. Debugging that chain simultaneously with game logic is miserable. Isolate it on day one, when the only variable is the tooling.

---

## ADR-006
### Eleven projects plus mini-jams — not one capstone
**Status:** ✅ Active · **Category:** Pedagogy

P00–P10, each playable, each deployed to the phone, each feeding the next. Plus four unscaffolded mini-jams. See [`../../projects/README.md`](../../projects/README.md).

**Why.** Explicitly requested: *"multiple practicals, exercises, intermediate projects — not just one at the end."* A single end-project also fails pedagogically: the learner has no evidence of progress for months, and no practice at *finishing*, which is the rarest skill in game development.

**Consequence.** Nothing built is throwaway — the capstone is assembled from the ten projects before it.

---

## ADR-007
### Every chapter ends with exercises and answered self-check questions
**Status:** ✅ Active · **Category:** Pedagogy

Practicals are inline per chapter. Standalone drills live in [`../Exercises.md`](../Exercises.md). Self-check questions live inline (collapsed answers) and are aggregated in [`../reference/QuestionBank.md`](../reference/QuestionBank.md) with answers in [`../reference/answers/`](../reference/answers/).

**Why.** Requested: *"questions (with answers)."* Answers are kept in a separate file so that retrieval practice is possible — recognising a correct answer is not the same as producing one.

---

## ADR-008
### Free assets only; every asset logged at download time
**Status:** ✅ Active · **Category:** Legal

Every asset used in this course is free and permissively licensed — CC0 wherever possible. **Every download gets a row in [`../reference/AssetLicenses.md`](../reference/AssetLicenses.md) immediately.**

**Rejected licences:** CC-BY-NC and CC-BY-ND, in all cases, without exception. CC-BY-SA is discouraged.

**Why.** An untracked asset is an unshippable asset. Chapter 7.19 generates the game's credits roll directly from the ledger, which makes the discipline pay for itself.

---

## ADR-009
### glTF 2.0 is the only Blender→Godot transfer format
**Status:** ✅ Active · **Category:** Pipeline

`.glb` only. Not FBX, not OBJ, not `.blend` direct import.

**Why.** Open spec, unambiguous units and axes, native PBR + skinning + animation, and Godot's best-supported importer with no external converter.

---

## ADR-010
### Mobile-first: the mobile-safe technique is taught first
**Status:** ✅ Active · **Category:** Product

Wherever a technique has a desktop version and a mobile version, the **mobile version is taught as the default** and the desktop version is mentioned second, as an aside.

**Why.** Almost all Godot 3D material online assumes a desktop GPU. A mid-range phone has roughly the GPU budget of a 2013 laptop and a thermal budget of about ten minutes. Teaching the desktop technique first and "optimising later" produces a beautiful game that runs at 14fps — and the fix is usually architectural, not incremental.

**Consequence.** Baked lighting before real-time GI. Mobile renderer before Forward+. Texture atlases before per-object materials.

---

## ADR-011
### Every question becomes a permanent `D-NNN` artefact
**Status:** ✅ Active · **Category:** Process

No question is ever answered only in conversation. Every question — at any time, about anything, however small — gets a dated entry in [`Doubts.md`](Doubts.md) with a short answer and a full answer.

**The `/btw` convention.** Prefix any aside with `/btw` and it becomes a `D-NNN` entry, no matter how small or tangential.

**Why.** Adopted from the QNX course, where it worked. Questions asked in passing are exactly the ones answered in conversation and then lost.

---

## ADR-012
### `TableOfContents.md` is canonical; `TableOfContext.md` is an alias
**Status:** ✅ Active · **Category:** Docs

**Why.** "Table of Contents" is the correct term and the one every reader expects. The alias exists because the learner has typed "TableOfContext" consistently across both courses, and a redirect costs nothing.

---

## ADR-013
### Mermaid for all diagrams
**Status:** ✅ Active · **Category:** Docs

Diagrams are Mermaid code blocks in Markdown — never images — except for genuinely visual material (screenshots, UV layouts, reference boards) which lives in `assets/images/`.

**Why.** Diffable, editable, renders on GitHub, survives PDF export.

---

## ADR-014
### Three document tiers
**Status:** ✅ Active · **Category:** Docs

| Tier | Location | Audience |
|------|----------|----------|
| 📗 **Tier 1 — Course** | `README.md`, `docs/PLAN.md`, `docs/TableOfContents.md`, `docs/chapters/`, `docs/guides/`, `docs/reference/`, `projects/` | Any reader who finds this repo |
| 📘 **Tier 2 — Bookkeeping** | `docs/meta/` | The learner, and readers curious how the course was made |
| 🔒 **Tier 3 — Internal** | `docs/internal/`, `PROMPTS.md`, `toAgent/` | AI agents and the learner only |

**Why.** So an AI author can be replaced mid-project without losing context, while the course itself stays clean for a reader who has no interest in how it was authored.

---

## ADR-015
### `PROMPTS.md` records every learner prompt and every full response
**Status:** ✅ Active · **Category:** Process

Verbatim prompt, complete response, standing instructions extracted, artefacts changed.

**Why.** Reasoning that lives only in a chat window dies with the session.

---

## ADR-016
### The author does not execute Godot, Blender or adb; the `[UNVERIFIED]` protocol
**Status:** ✅ Active · **Category:** Process

The authoring environment is Termux on Android with no Godot, no Blender, no .NET and no Android SDK — and the learner has instructed that nothing be installed or run there. Therefore **every claim about what a tool actually prints or does is marked `[UNVERIFIED]` until the learner runs it and reports back**.

**Clearance path:** learner runs the step → pastes output into [`../../toAgent/`](../../toAgent/) → marker removed and the observed output written into the chapter. Protocol: [`../internal/VerificationRuns.md`](../internal/VerificationRuns.md).

**Why.** The alternative is confidently-worded fiction about error messages and menu paths, which is worse than an honest marker.

---

## ADR-017
### One chapter per turn, committed and pushed
**Status:** ✅ Active · **Category:** Process

Each working turn delivers one complete chapter, updates `docs/meta/`, and commits.

**Why.** A chapter is the natural unit of both learning and review. Smaller units fragment; larger ones can't be reviewed properly.

---

## ADR-018
### Course content CC BY-SA 4.0; project code MIT
**Status:** ✅ Active · **Category:** Legal

Prose, diagrams and course structure: **CC BY-SA 4.0**. Code in `projects/`: **MIT**. Third-party assets keep their own licences, recorded in `AssetLicenses.md`.

---

## ADR-019
### Capstone scope is locked at 4 levels + 1 boss
**Status:** ✅ Active · **Category:** Product

*Ember Hollow*: four ~6-minute levels, one enemy type with two variants, one boss with three phases, one core verb plus one traversal verb. **No crafting, no inventory, no procedural generation.**

**Why.** Scope, not skill, is what kills projects. The lock is written down precisely so that a future enthusiasm has something to argue against. New ideas go in the GDD under *Post-launch*.

---

## ADR-020
### Chapter files are `ChapterNN_PascalCaseTitle.md`
**Status:** ✅ Active · **Category:** Docs

Zero-padded, monotonically increasing. Blender chapters use the `B` prefix in their title but share the same numbering sequence, so reading order equals file order.

---

## ADR-021
### No GitHub-only Markdown syntax
**Status:** ✅ Active · **Category:** Docs

No GitHub alert blocks (`> [!NOTE]`), no GitHub-specific task-list semantics in prose. Standard Markdown, Mermaid, and tables only.

**Why.** The course must survive PDF export. Adopted from the QNX course, where this was learned the hard way.

---

## ADR-022
### C# on Android is knowingly the less-travelled path
**Status:** ✅ Active · **Category:** Product

Godot's .NET Android export works (introduced in the 4.2 line, hardened since), but it has fewer users than GDScript. Expect longer export times, larger APKs, and occasional issues with no Stack Overflow answer.

**Accepted deliberately.** Mitigations: pin versions ([Setup 01](../guides/Setup_01_Prerequisites.md)); consult the official docs and Godot's GitHub issues before assuming a bug is yours; log every one in [`../reference/Troubleshooting.md`](../reference/Troubleshooting.md).

---

## ADR-023
### Capstone working title is *Ember Hollow*
**Status:** 🔄 Provisional · **Category:** Product

A placeholder so the capstone can be referred to concretely from Module 4 onward. The learner names it properly in chapter 7.1, and this ADR is then revised.

---

## ADR-024
### Learning paths (🐣 / 🚶 / 🏃)
**Status:** ⏳ **Pending your input** · **Category:** Pedagogy

The QNX course authors three parallel paths in every chapter: 🐣 Absolute Beginner, 🚶 Self-Learner, 🏃 Fast-Track Pro.

**The question for you:** do you want the same here?

| | If yes | If no |
|---|---|---|
| Benefit | Re-readable at different depths; useful to future readers | Chapters are ~40% shorter and faster to produce |
| Cost | Roughly 1.5–2× the authoring effort per chapter | Written for exactly one reader — you |

**My recommendation: no, not as three full paths.** This course's practical-first structure already provides the same benefit more cheaply — the **Build** section *is* the fast track, and the **Why it works** section *is* the depth. Instead I propose two lightweight markers: 🔬 for optional deep dives and ⭐ for must-do practicals. That gets ~80% of the value at ~10% of the cost.

**Awaiting your decision.** Until then chapters are written single-path with 🔬 and ⭐ markers.

---

## ADR-025
### Repository conventions adopted from `qnx-zero-to-hero`
**Status:** ✅ Active · **Category:** Docs

This repository deliberately mirrors the structure of the learner's `qnx-zero-to-hero` course: YAML front matter with `document_id`/`version`/`status`/`update_trigger`; `docs/meta/` bookkeeping (`CourseState`, `CompactContext`, `Decisions`, `DecisionsLog`, `Doubts`, `ToDos`); `docs/internal/` agent memory and onboarding; `docs/reference/` glossary, links and cheat sheets; `toAgent/` for learner-captured output; root `PROMPTS.md`; and the three-tier document model.

**Why.** Explicitly requested. It also means one mental model serves both courses, and an agent onboarded to either is immediately competent in the other.

---

## 📝 Changelog

| Version | Date | Change |
|---------|------|--------|
| 1.0 | 2026-09-01 | Created at course inception (Session 001). ADR-001 to ADR-025. |
