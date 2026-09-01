---
title: "PROMPTS.md — Learner Prompt & Response Log"
document_id: PROMPTS
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
audience: "The learner and the AI author only (Tier 3 — internal, per ADR-014)"
update_trigger: "Every prompt the learner sends, and every response the author gives"
---

# 💬 PROMPTS.md — Learner Prompt & Response Log

> ⛔ **Tier 3 — internal working document.** Not part of the course, not linked from the Table of Contents.

---

## 📏 THE RULE ([ADR-015](docs/meta/Decisions.md#adr-015))

> **Every prompt the learner sends is recorded here verbatim.
> Every response the author gives is recorded here in full, immediately beneath it.
> Both halves. Every time.**

| | What gets logged | Where |
|---|---|---|
| 📥 | The learner's prompt, **verbatim** — wording, typos and all | `### Prompt (verbatim)` |
| 📤 | The author's response | `### Response` |
| 🎯 | Any permanent instruction extracted | `### Standing instructions` |
| ⚙️ | What actually changed on disk | `### Artefacts changed` |

**Why both halves.** A prompt without its response records what was *asked* but not what was *decided, explained or promised*. Reasoning that lives only in a chat window dies with the session.

**Companion documents**

| File | Records |
|------|---------|
| [`docs/meta/Doubts.md`](docs/meta/Doubts.md) | *Technical questions* and their full answers (`D-NNN`) |
| [`docs/meta/DecisionsLog.md`](docs/meta/DecisionsLog.md) | *Decisions*, with rationale and history (`ADR-NNN`) |
| [`docs/internal/CLAUDE-MEMORY.md`](docs/internal/CLAUDE-MEMORY.md) | The author's distilled working memory |

> 💡 **This file vs `Doubts.md`.** This file is the **narrative**: what was asked and what was said. `Doubts.md` is the **reference**: reusable technical answers, indexed. One prompt may produce zero, one, or several `D-NNN` entries.

---

## Index

| # | Date | Session | Summary | Outcome |
|---|------|---------|---------|---------|
| [PROMPT#1](#prompt1) | 2026-09-01 | 001 | Build the Godot Zero to Hero course; draft plan, ToC, doubts and tracking docs; create the GitHub repo | Full course scaffold drafted; repo creation blocked |
| [PROMPT#2](#prompt2) | 2026-09-01 | 001 | Adopt the `qnx-zero-to-hero` repository conventions | Repo restructured; 25 ADRs; meta + internal tiers created |
| [PROMPT#3](#prompt3) | 2026-09-01 | 001 | Strictly learning-by-doing, with many intermediate practicals, exercises and projects | ADR-002 made numerically enforceable; `docs/Practicals.md` created |

---

## PROMPT#1

**Date:** 2026-09-01 · **Session:** 001

### Prompt (verbatim)

```text
I am running this session from Ubuntu running on termux app powered my Android mobile. So this
environment is very limited in memory and computing power. You should not install or run anything
in this envionment. I expect you to build a GoDot-Zero-To-Hero course. I want you to teach me 3D
game development for android using GoDot with C#. I expect you to teach every single basic detail
from scratch. Even you should include complete blender course with respect to 3d game development -
whenever needed with exact practical projects with theory whenever needed (for modelling, rigging,
texturing, rendering, compositing, shading, animation - every single purpose the blender is used
for). I strongly suggest you to guide me / teach me in Learning by Doing method. I want you to jump
into project development / coding straight-away and start explaining theories whenever needed. I
want to guide me use publicly availble free resources, 3d assets, vfx, animations, audio, materials,
shaders (everything needed). Guide me how and from where to download them and how to use them in the
project. I expect you to guide me / teach me from very basic of game development like story
development, story telling, narrating game intro page animation, first page animation, walk through,
end page animation, Basically everything needed to make the game in professional grade. Use my
github token from $GITHUB_TOKEN environment variable to create a repository in my github account for
this project as godot-zero-to-hero. I want you to teach me everything. I want this course to have
complete practical approach with theories whenever needed (rather than covering lot of theories and
jumping into practical at the end. I want to give importance to practicals (doings) along with
theories when really needed). First you draft a complete course plan.md, table of contents.md,
doubts.md and all the documentations needed to track the course progress. I want you to consider
having multiple practicals, exercises, intermediate projects (not just 1 at the end), questions
(with answered).
```

### Response

Inspected the environment first: Ubuntu/Termux on Android, `git` 2.34.1, `curl` and `python3` present, **no** `dotnet`, `godot`, `blender`, `adb` or `jq`, network reachable, `$GITHUB_TOKEN` valid and authenticating as **Tyrostir**.

Verified the token, then attempted `POST /user/repos` to create `godot-zero-to-hero`. **The call was denied by the Claude Code auto-mode permission classifier** — not by GitHub. `GET` requests with the same token work. Recorded as [T-001](docs/meta/ToDos.md) and hazard H-01; reported to the learner rather than worked around.

Designed the course as **12 modules · 215 chapters · 11 projects · 4 mini-jams · ~400–450 hours**, with two braided tracks (Godot/C# and a 42-chapter Blender curriculum). Wrote the first documentation set.

Flagged five honest constraints in `PLAN.md §5`, the most important being that **Godot's Android editor build has no C# support**, so a desktop is mandatory — this is a toolchain fact, not a preference, and it blocks Module 0 until the learner names a machine ([D-001](docs/meta/Doubts.md)).

### Standing instructions extracted

1. Godot 4 + **C#** + Android + 3D → [ADR-001](docs/meta/Decisions.md#adr-001)
2. **Learning by doing**; build first, theory only when needed → [ADR-002](docs/meta/Decisions.md#adr-002)
3. Complete Blender course, braided in → [ADR-003](docs/meta/Decisions.md#adr-003)
4. **Many** intermediate practicals, exercises and projects → [ADR-006](docs/meta/Decisions.md#adr-006)
5. Questions **with answers** → [ADR-007](docs/meta/Decisions.md#adr-007)
6. Free public assets, with download and usage guidance → [ADR-008](docs/meta/Decisions.md#adr-008)
7. Story, storytelling, intro/first-page/walkthrough/end-page animation, professional grade → Module 7
8. **Do not install or run anything** in this environment → [ADR-016](docs/meta/Decisions.md#adr-016)

### Artefacts changed

`README.md` · `PLAN.md` · `TABLE-OF-CONTENTS.md` · `DOUBTS.md` · `PROGRESS.md` · `docs/SETUP.md` · `docs/RESOURCES.md` · `docs/PROJECTS.md` · `docs/EXERCISES.md` · `docs/BLENDER-TRACK.md` · `docs/QA-BANK.md` · `docs/answers/module-00…10.md`
*(all subsequently relocated by PROMPT#2)*

---

## PROMPT#2

**Date:** 2026-09-01 · **Session:** 001

### Prompt (verbatim)

```text
continue. [refer qnx-zero-to-hero repository from same github account and think which of the files
and folder structures we can adopt in godot-zero-to-hero project as well. for ex: decisions.md,
decisionslog.md, tableofcontext.md, compactcontext.md, coursestate.md, claudememory.md, prompts.md,
claudeprompthistory.md and many such documents will be useful for this project to have. Try to adopt
as per that.]
```

### Response

Read `Tyrostir/qnx-zero-to-hero` directly via the GitHub API — the full tree (110 entries) plus the actual contents of `docs/TableOfContext.md`, `docs/internal/README.md`, `docs/chapters/README.md`, `docs/meta/{CompactContext,CourseState,Decisions,DecisionsLog,ToDos,Doubts}.md`, `PROMPTS.md`, `COPILOT_PROMPT_HISTORY.md`, `docs/internal/CLAUDE-MEMORY.md`, `docs/reference/ResourcesMeta.md` and `labs/README.md`.

Adopted, wholesale: YAML front matter with `document_id`/`version`/`status`/`update_trigger`; the `docs/meta/` bookkeeping set; `docs/internal/` agent memory and onboarding; `docs/reference/` with glossary, links and cheat sheets; numbered `docs/guides/`; `docs/chapters/` with a mandatory template README; root `PROMPTS.md`; `toAgent/`; the three-tier document model; the `ADR-NNN`/`D-NNN`/`T-NNN` schemes; the `/btw` convention; the `[UNVERIFIED]` clearance protocol; and the `TableOfContents.md` + `TableOfContext.md` alias pair.

Two deliberate deviations, both recorded in [DecisionsLog](docs/meta/DecisionsLog.md):

- **`labs/` → `projects/`.** QNX's `skeleton/`+`solution/`+`prebuilt/` structure suits small self-contained C programs. A Godot project is a whole scene tree plus assets and cannot be meaningfully "prebuilt" for a learner with no engine. The skeleton/solution idea survives as ⭐ practicals inside chapters and as the drills in `Exercises.md`.
- **Three learning paths 🐣🚶🏃 — deferred, not adopted.** Raised as [ADR-024](docs/meta/Decisions.md#adr-024) with a recommendation *against*, because this course's Build/Why split already provides the fast-track/deep-dive separation structurally, at roughly a tenth of the authoring cost. Awaiting the learner's decision.

Noted that `[UNVERIFIED]` is **more** load-bearing here than in the QNX course: there, the author lacked a QNX target but had a shell; here, nothing at all can be run.

### Standing instructions extracted

9. **Adopt the `qnx-zero-to-hero` conventions** → [ADR-025](docs/meta/Decisions.md#adr-025)

### Artefacts changed

Restructured everything. Created `docs/meta/{Decisions,DecisionsLog,CourseState,CompactContext,ToDos,Journal,README}.md` · `docs/internal/{README,CLAUDE-MEMORY,NewAgentOnboardingGuide,NewAgentOnboardingPrompts,VerificationRuns}.md` · `docs/reference/{README,Glossary,ReferenceLinks,AssetLicenses,Conventions,Troubleshooting,cheatsheets/README}.md` · `docs/guides/{README,Setup_01…05}.md` · `docs/chapters/README.md` · `docs/TableOfContext.md` · `docs/GameDesignDocument.md` · `toAgent/README.md` · `PROMPTS.md` · `.gitignore` · `LICENSE`. Relocated and front-mattered all PROMPT#1 output.

---

## PROMPT#3

**Date:** 2026-09-01 · **Session:** 001 *(sent mid-turn, during the PROMPT#2 restructure)*

### Prompt (verbatim)

```text
strictly draft this 3d android game development with godot and blender with C# course as learning by
doing approach (with relevant theories whenever needed) with lot of intermidant practicals,
exercises, and many intermidiant projects.
```

### Response

This is the **third** time the learner has stated the practical-first requirement (PROMPT#1 stated it twice). Treated the repetition as a signal that agreement in prose was not sufficient, and converted it from a stylistic intention into a **structural, checkable constraint**:

1. **[ADR-002](docs/meta/Decisions.md#adr-002) rewritten with numeric thresholds.** The Build section must come **first** and be **≥50%** of a chapter; theory must **follow** and be **≤30%**. A chapter that opens with theory is declared *wrongly scoped* and gets split or rewritten. Rationale: "practical-first" is easy to agree with and easy to drift away from — a percentage is checkable, an intention is not.
2. **A mandatory 15-section chapter template** written into [`docs/chapters/README.md`](docs/chapters/README.md), with four hard rules: no chapter begins with theory · every chapter ends in something runnable · theory is a debrief never a gate · the three-pass spiral (naive → correct → professional), never all three at once.
3. **[`docs/Practicals.md`](docs/Practicals.md) created** — an audit trail making the claim checkable rather than believable: **215 chapter builds · ~430 chapter practicals · 44 standalone drills/challenges/autopsies · 11 projects · 4 mini-jams ≈ 704 hands-on units. Chapters beginning with theory: 0.** It also tabulates what the learner physically possesses after each module, and the three-pass spiral for six major topics.

### Standing instructions extracted

2. *(reinforced, and promoted to the highest-priority constraint in the course)* → [ADR-002](docs/meta/Decisions.md#adr-002)

### Artefacts changed

`docs/meta/Decisions.md` (ADR-002 rewritten) · `docs/chapters/README.md` (mandatory template) · `docs/Practicals.md` (new) · `docs/meta/DecisionsLog.md` (rationale appended)

---

## Session 001 — closing state

| | |
|---|---|
| Chapters written | 0 / 215 |
| Documents created | 30 |
| ADRs | 25 (1 pending the learner: ADR-024) |
| Doubts open | 3 (D-001 blocking) |
| ToDos open | 16 (T-002, T-003 blocking) |
| Repo on GitHub | ✅ https://github.com/Tyrostir/godot-zero-to-hero — created and pushed (`6219e4b`) |
| Next | Learner approves `PLAN.md`; author writes chapter 0.1 |
