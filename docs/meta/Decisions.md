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
| [ADR-011](#adr-011) | Every question → a permanent `D-NNN` artefact — **question and answer**; `/btw` convention | Process | ✅ |
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
| [ADR-024](#adr-024) | **Three learning paths 🐣/🚶/🏃, all authored in full** | Pedagogy | ✅ |
| [ADR-025](#adr-025) | Repository conventions adopted from `qnx-zero-to-hero` | Docs | ✅ |
| [ADR-026](#adr-026) | **The Presentation Spine** — story, screens, music and walkthrough in *every* project | Pedagogy | ✅ |
| [ADR-027](#adr-027) | Narration is taught and recorded by the learner; **subtitles are mandatory** | Product | ✅ |
| [ADR-028](#adr-028) | **Build it once by hand, then adopt the library** — the `b`-chapter pattern | Pedagogy | ✅ |
| [ADR-029](#adr-029) | The approved free toolchain, and dependency-evaluation as a taught skill | Tooling | ✅ |
| [ADR-030](#adr-030) | What "industry grade" means here — and the honest limit of "AAA" | Product | ✅ |

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

All authoring happens on a desktop or laptop — **confirmed 2026-09-01 as a Linux machine** ([D-001](Doubts.md)). The Android phone is the deployment target. The Termux session is for planning, documentation, git and conversation only.

**Consequence of the Linux choice.** Setup guides lead with the Linux route: the command-line Android SDK (~1 GB, no Android Studio), a `udev` rule for `adb`, and the distribution's OpenJDK. Windows and macOS steps stay in the guides for other readers but are secondary.

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
### Every question becomes a permanent `D-NNN` artefact — question **and** answer
**Status:** ✅ Active *(amended 2026-09-02)* · **Category:** Process

No question is ever answered only in conversation. Every question — at any time, about anything, however small — gets a dated entry in [`Doubts.md`](Doubts.md).

**Both halves are logged, every time, unprompted:**

| | What | Field |
|---|------|-------|
| 📥 | **The learner's question, verbatim** — wording, typos and all | `### Question (verbatim)` |
| 📤 | **The author's short answer** — 2–3 sentences, enough to unblock | `### Short answer` |
| 📤 | **The author's full answer** — as deep as the question deserves | `### Full answer` |
| ⚙️ | Any chapter edit, ADR or ToDo that resulted | `### Action taken` |

**This is the author's job, not the learner's**, and it happens at the end of every turn whether or not the learner asks for it.

**The `/btw` convention.** Prefix any aside with `/btw` — **on the same line as the question** — and it becomes a `D-NNN` entry, no matter how small or tangential. A bare `/btw` is swallowed by the command handler and never reaches the author.

**Which log gets what.** One prompt may produce zero, one, or several `D-NNN` entries.

| File | Records |
|------|---------|
| [`Doubts.md`](Doubts.md) | Reusable **technical answers**, indexed and searchable |
| [`../../PROMPTS.md`](../../PROMPTS.md) | The **narrative** — what was asked and said, verbatim, in order |
| [`DecisionsLog.md`](DecisionsLog.md) | **Decisions**, with rationale and rejected alternatives |

**Why.** Adopted from the QNX course, where it worked. Questions asked in passing are exactly the ones answered in conversation and then lost.

**Why amended.** The original wording said only "every question gets an entry", which the author satisfied narrowly — logging questions *put to* the learner (D-001 to D-004) while a question the learner asked *of* the author ([D-005](Doubts.md#d-005)) went into `PROMPTS.md` and never into `Doubts.md`. The root cause was structural: `Doubts.md` v1.0 had a column for the learner's own-words answer and **no field for the author's**. Format rebuilt in v2.0; wording tightened here. See [D-006](Doubts.md#d-006).

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
### Three learning paths, all authored in full
**Status:** ✅ Active *(decided 2026-09-01)* · **Category:** Pedagogy

Every chapter is written for **three paths simultaneously**, all three authored in full — the same decision the learner made on `qnx-zero-to-hero` (its ADR-008), and for the same reason: future readers should be able to enter the course at any depth.

| Path | Who | What they read | What they build |
|------|-----|----------------|-----------------|
| 🐣 **A — Absolute Beginner** | New to programming *and* new to 3D | Everything, plus 🐣 expansion boxes that explain the programming and 3D concepts a first-timer won't have | Complete code listings, never "add the obvious". Uses CC0 placeholder art where Path B models its own |
| 🚶 **B — Self-Learner** | **The learner's path.** Comfortable coding, new to games and to Blender | The full chapter: every build step, every theory debrief, every practical | Everything. Models, rigs and animates their own art. Writes every shader by hand |
| 🏃 **C — Fast-Track Pro** | Experienced developer or artist, time-poor | The 🏃 Fast-Track Summary, the Build steps, and the cheat sheet. Skips theory debriefs they already know | ⭐ core practicals only |

**How it appears in a chapter.** Not three separate documents — one document with markers:

- A **🏃 Fast-Track Summary** near the top: the whole chapter in ~10 bullets plus the finished code. Path C reads only this and the cheat sheet.
- **🐣 boxes** — collapsible *"New to this?"* expansions, inline at the point of confusion. Path B and C skip them.
- **🔬 deep dives** — optional depth. Path A skips them.
- **⭐ core practicals** — every path does these. Unmarked practicals are Path A and B.
- Chapter headers carry path tags: `🐣🚶🏃` when it is for everyone, `🚶🏃` when Path A should skip it.

**Interaction with [ADR-002](#adr-002).** The ≥50% Build / ≤30% theory ratio is measured on the **Path B reading** — the full chapter minus 🐣 boxes and 🏃 summaries. Path markers add material; they never displace the build.

**Cost, accepted knowingly.** Roughly 1.5–2× the authoring effort per chapter, and longer chapters. The learner chose this deliberately over the cheaper ⭐/🔬-markers-only alternative that was originally recommended, on the grounds that the course should serve readers other than themselves.

---

## ADR-025
### Repository conventions adopted from `qnx-zero-to-hero`
**Status:** ✅ Active · **Category:** Docs

This repository deliberately mirrors the structure of the learner's `qnx-zero-to-hero` course: YAML front matter with `document_id`/`version`/`status`/`update_trigger`; `docs/meta/` bookkeeping (`CourseState`, `CompactContext`, `Decisions`, `DecisionsLog`, `Doubts`, `ToDos`); `docs/internal/` agent memory and onboarding; `docs/reference/` glossary, links and cheat sheets; `toAgent/` for learner-captured output; root `PROMPTS.md`; and the three-tier document model.

**Why.** Explicitly requested. It also means one mental model serves both courses, and an agent onboarded to either is immediately competent in the other.

---

## ADR-026
### The Presentation Spine — story, screens, music and walkthrough in every project
**Status:** ✅ Active *(decided 2026-09-02)* · **Category:** Pedagogy

Presentation — the **first-page animation, the end-page animation, background music, ambience, a narrative frame and a walkthrough** — is not a module. It is a **spine running through every project from P01 onward**, escalating in three passes.

Full mapping, project by project: [`../PresentationSpine.md`](../PresentationSpine.md).

**From P01 onward, a project is not shipped without:** an animated opening screen · an ending/results screen · at least one music loop · ambience where the piece has a place · a narrative frame, even one line · and a walkthrough that teaches without a wall of text. These are **done-criteria in [`../../projects/README.md`](../../projects/README.md)**, not suggestions.

**Why this changed.** The plan as first drafted quarantined all of it in Modules 6–7. That was wrong on two counts. First, it contradicted the learner's actual request — *"on all the projects wherever applicable"*. Second, and worse, it contradicted [ADR-002](#adr-002): a learner would spend roughly 180 hours before making their first title screen, then have to learn timing, camera language, sound design and pacing **all at once, at full difficulty, with no practice**. That is precisely the theory-then-practice failure this course exists to avoid.

**The escalation.** You build a title screen four times: crude tween (1.35) → live 3D character (3.12) → your own shaders (5.22) → directed, scored, narrated opening (7.16–7.18). Same for the ending (1.36 → 7.21), music (1.37 → 6.7 → 7.17) and the walkthrough (level shape 4.21 → directed onboarding 7.19 → a written guide 10.20).

**Cost.** 42 additional chapters (215 → 258). Accepted: they are almost all short, they are distributed rather than lumped, and they make every intermediate project feel like a *game* rather than a tech demo — which is itself the strongest defence against the thing that actually kills courses, which is losing interest.

---

## ADR-027
### Narration is recorded by the learner; subtitles are mandatory
**Status:** ✅ Active *(decided 2026-09-02)* · **Category:** Product

Narration and voice get eleven chapters (6.8–6.14, 7.6, 7.11, 8.2, 10.18), taught practical-first: **record before theorising**.

**No purchase is required.** Chapter 6.9 is built around a phone's voice recorder and a wardrobe of soft furnishings as an improvised booth. The fastest way to learn what makes a voice track bad is to make a bad one and fix it. Microphone guidance is offered for later, never assumed.

**Text-to-speech is treated as legitimate** (6.13), not as a fallback for people who "can't" record — with an honest account of when it's the right choice and the licensing trap in commercial use.

**Subtitles are mandatory.** Any narration shipped must carry synchronised captions and a toggle ([`9.8`](../TableOfContents.md)). A phone gets played on mute, on a bus, by someone who is deaf, and by someone at 4% battery — all four are the same requirement, and treating it as an accessibility afterthought produces a worse system than designing the cue track for captions from the start.

---

## ADR-028
### Build it once by hand, then adopt the library
**Status:** ✅ Active *(decided 2026-09-02)* · **Category:** Pedagogy

Every major system is met three times: **hand-build → compare → decide**.

| Step | What | Result |
|------|------|--------|
| 1️⃣ **Hand-build** | Write the minimal version yourself | You understand the *problem*, not an API. You can debug anything built on it |
| 2️⃣ **Compare** | Install the library, **read its source**, find what it does better *and worse* | You learn what production-ready means: edge cases, tooling, performance |
| 3️⃣ **Decide** | Adopt or keep yours, and **record why** in [`DecisionsLog.md`](DecisionsLog.md) | You practise the most valuable senior skill: justifying a dependency |

**Notation.** A chapter numbered `N.Mb` is the **adoption chapter** paired with hand-build chapter `N.M`, and is marked 🧰. Twenty-eight such chapters exist. This keeps existing numbering stable and makes the pairing visible at a glance.

**Why this rather than teaching libraries directly.** A learner who only knows the addon cannot debug it, cannot extend it, and is helpless the day it breaks or is abandoned — which in the Godot addon ecosystem is a *when*, not an *if*; the Godot 3→4 transition orphaned a great many. The opposite failure is equally real: a learner who reinvents everything badly and ships nothing. Three steps resolve both.

**Rejected.** *Libraries first* (faster to a result, produces a helpless developer) and *never use libraries* (produces a slow developer with a worse game). Also rejected: making adoption optional. **Step 3 is mandatory and "a tutorial used it" is not a rationale.**

**Interaction with [ADR-002](#adr-002).** Adoption chapters are still practical-first: the Build section is installing, wiring and measuring the library. The theory that follows is the comparison.

---

## ADR-029
### The approved free toolchain, and dependency evaluation as a taught skill
**Status:** ✅ Active *(decided 2026-09-02)* · **Category:** Tooling

Full catalogue with licences, caveats and adoption chapters: **[`../Toolchain.md`](../Toolchain.md)**.

**Everything in the course is free.** Where a paid tool is the industry default, the free equivalent is taught and the paid one named so the learner knows the landscape: Rigify not Auto-Rig Pro; Geometry Nodes / Proton Scatter not Scatter5; QuadriFlow / RetopoFlow not Quad Remesher; ambientCG and Poly Haven not Quixel; Material Maker not Substance Designer.

**The six evaluation questions** (taught in chapter 0.10, applied every time thereafter): licence · maintenance · **does it work from C#** · mobile cost measured on device · abandonment risk · could you write it in a day.

**⚠️ The C# consequence, stated plainly.** Most Godot addons are GDScript. They work from C# — they are nodes, you call them — but with lost type safety and real friction. Three responses, all taught: prefer C#-native or GDExtension libraries; **wrap any GDScript addon behind a C# interface** (chapter 9.6b); and use **NuGet**, which is a large compensation GDScript users do not have (chapter 0.11).

**The single most consequential find** is the **Chickensoft** ecosystem — maintained, MIT, **C#-first** Godot libraries (LogicBlocks, AutoInject, GodotNodeInterfaces, SaveFileBuilder, GodotTest, GodotEnv). Every "best Godot addons" list online is written for GDScript users; a C# developer following those lists spends their life writing `Call("do_thing")`.

**Explicit rejections** are recorded in [`../Toolchain.md` §8](../Toolchain.md) — including FMOD/Wwise (community integration + C# + Android is three compounding risks; awareness taught in 6.2b, no install) and GPL-licensed addons in shipped code.

**`[UNVERIFIED]` applies.** The author cannot install or run any of these ([ADR-016](#adr-016)). Versions, current maintenance and mobile cost are checked by the learner **at the point of adoption** — which is the exercise anyway, so the constraint and the pedagogy point the same way.

---

## ADR-030
### What "industry grade" means here — and the honest limit of "AAA"
**Status:** ✅ Active *(decided 2026-09-02)* · **Category:** Product

The learner's stated goal is to be able to develop *"AAA standard — professional — industry grade games."* Two of those three are achievable through this course. One is not, and saying so plainly is more useful than agreeing.

**"AAA" is a description of budget and headcount, not of quality.** It means 100–300 people, $50–200 M, three to five years, and a marketing spend that often exceeds production. No course produces that, and no solo developer achieves it — not because of skill, but because it is a statement about organisational scale.

**"Professional" and "industry grade" are entirely achievable, and are what this course now targets in full**: the same pipelines, tools, standards, review practices and quality bars that studios use, executed at a scope one person can finish. Concretely, the course teaches:

| Practice | Where |
|---|---|
| A real asset pipeline: budgets, atlases, texel density, LODs, bakes, validation | Modules 2, 4, 8 |
| Production rigging with the industry-standard free system (Rigify) | B24b |
| Storyboards and previz before cameras (Grease Pencil) | 7.2b |
| Colour management (OpenColorIO / AgX), as studios do it | 7.24b |
| Behaviour trees, navmesh AI, telegraphed readable combat | 10.6–10.8 |
| Code standards: analyzers, `.editorconfig`, warnings-as-errors, doc comments | 9.2b |
| Unit-testable scene code, and a test suite | 9.9, 9.9b |
| Structured logging and on-device profiling as routine | 9.11, 9.11b |
| CI that builds a signed artefact on every tag | 10.17 |
| **Industry milestones** — first playable, vertical slice, alpha, beta, content lock, gold | 10.1b |
| **Production tracking** with an open-source studio tool (Kitsu) | 10.3b |
| Structured playtesting with recorded protocol | 10.11 |
| **The post-mortem**, written honestly and published | 10.11b |
| Accessibility as a requirement, not a stretch goal | 10.13, ADR-027 |
| **A portfolio and breakdown reel** for studio applications | 10.20b |

**What is deliberately *not* attempted**, and why it is the right call: a large content volume (scope kills solo projects — [ADR-019](#adr-019)); photoreal fidelity (wrong target for a phone — [ADR-010](#adr-010)); multiplayer infrastructure (an entire discipline; awareness only in 11.1); and marketing at scale.

**The honest summary.** At the end you will not have made a AAA game. You will have the craft, the pipeline discipline and the shipped evidence to work on one — or to make something small and excellent on your own, which is the harder and rarer achievement.

---

## 📝 Changelog

| Version | Date | Change |
|---------|------|--------|
| 1.0 | 2026-09-01 | Created at course inception (Session 001). ADR-001 to ADR-025. |
| 1.1 | 2026-09-01 | ADR-024 decided: three paths, all authored in full. ADR-004 amended: build machine is **Linux**. |
| 1.2 | 2026-09-02 | ADR-026 (Presentation Spine) and ADR-027 (narration, mandatory subtitles) added after a plan-review audit. Course grows 215 → 258 chapters. |
| 1.3 | 2026-09-02 | ADR-011 amended: **both** the question and the author's full answer are logged in `Doubts.md`, unprompted, every turn. Prompted by [D-006](Doubts.md#d-006). |
| 1.4 | 2026-09-02 | ADR-028 (build-then-adopt), ADR-029 (the free toolchain), ADR-030 (what "industry grade" honestly means). Course grows 258 → 290 chapters; new `Toolchain.md`. Prompted by [D-007](Doubts.md#d-007). |
