# Godot Zero to Hero

**3D game development for Android — Godot 4 and Blender — taught entirely by building things.**

**Four languages: C# (primary), GDScript, C++/GDExtension and GDShader.** Every free library and addon in the ecosystem, adopted only after you have hand-built what it replaces.

This is not a book you read and then start. From Module 0 you have a `.apk` running on your own phone, and every chapter after that adds a real feature to a real game.

> 🏋️ **359 chapter builds · ~690 chapter practicals · 44 standalone drills · 8 ⬜ blank-page builds · 11 projects · 4 mini-jams.**
> **Four languages** — C# (primary), GDScript, C++/GDExtension and GDShader — each taught where it earns its place.
> **Chapters that begin with theory: 0.** That is enforced, not aspirational — see [ADR-002](docs/meta/Decisions.md#adr-002) and the audit in [docs/Practicals.md](docs/Practicals.md).

---

## The promise

By the end you will own:

| # | Thing |
|---|---|
| 1 | A **shipped 3D Android game** with intro cinematic, menu, 4 levels, a boss, an ending, credits and settings |
| 2 | **Ten smaller games and tools** built along the way, each playable on your phone |
| 3 | Your own hand-modelled, hand-rigged, hand-animated **3D character** |
| 4 | A **modular environment art kit** you made in Blender |
| 5 | A reusable **C# codebase** — state machines, dialogue, saves, audio director, UI framework |
| 6 | Working **Blender** ability across modelling, sculpting, retopology, UV, texturing, shading, baking, rigging, animation, simulation, rendering, compositing and geometry nodes — every one taught through an asset you actually ship |
| 7 | A **published build** on itch.io and a Play Console internal-testing track |

---

## Start here

1. **[docs/PLAN.md](docs/PLAN.md)** — the philosophy, the shape of the course, and the honest constraints. **Read §5 before anything else.**
2. **[docs/TableOfContents.md](docs/TableOfContents.md)** — every chapter, practical and project, numbered.
3. **[docs/guides/](docs/guides)** — install everything, in five ordered guides, ending with ⭐ **your first APK on your phone**.
4. **[docs/meta/CourseState.md](docs/meta/CourseState.md)** — your progress tracker. Keep it open.
5. **[docs/meta/Doubts.md](docs/meta/Doubts.md)** — your question log. Every confusion goes here *before* you try to solve it.

Then say **"start 0.1"** and we begin.

---

## Repository map

```text
godot-zero-to-hero/
├── README.md                       you are here
├── PROMPTS.md                      🔒 prompt + response log (Tier 3)
├── LICENSE                         CC BY-SA 4.0 (course) + MIT (code)
│
├── docs/
│   ├── PLAN.md                     philosophy, syllabus, constraints, pacing
│   ├── TableOfContents.md          every chapter, numbered   (alias: TableOfContext.md)
│   ├── BlenderTrack.md             the Blender curriculum, B1–B42
│   ├── Practicals.md               every hands-on unit, counted
│   ├── PresentationSpine.md        story, screens, music, narration — per project
│   ├── Toolchain.md                every free library/addon, and where we adopt it
│   ├── Languages.md                C#, GDScript, C++, GDShader — which job goes to which
│   ├── meta/ReviewTriage.md        external review, triaged point by point
│   ├── Exercises.md                standalone drills, challenges, autopsies
│   ├── GameDesignDocument.md       the capstone GDD (filled in during Module 8)
│   │
│   ├── chapters/                   the course itself + the mandatory chapter template
│   ├── guides/                     Setup 01–05, in order
│   │
│   ├── meta/                       📘 bookkeeping
│   │   ├── CourseState.md            progress — the source of truth
│   │   ├── CompactContext.md         one-page context reload
│   │   ├── Decisions.md              active ADRs
│   │   ├── DecisionsLog.md           append-only decision history
│   │   ├── Doubts.md                 your questions, with answers
│   │   ├── ToDos.md                  open work items
│   │   └── Journal.md                daily learning log
│   │
│   ├── reference/                  📚 look things up
│   │   ├── Glossary.md · ReferenceLinks.md · ResourcesMeta.md
│   │   ├── AssetLicenses.md          ⚠️ your attribution ledger
│   │   ├── Conventions.md · Troubleshooting.md
│   │   ├── QuestionBank.md → answers/
│   │   └── cheatsheets/
│   │
│   └── internal/                   🔒 agent memory, onboarding, verification protocol
│
├── projects/                       P00 … P10, one Godot project per folder
├── assets-staging/                 raw downloads + .blend sources (pre-export)
└── toAgent/                        🔒 output you capture and drop in for me
```

---

## How this course works

Every chapter has the same shape, and it is enforced by [the mandatory template](docs/chapters/README.md):

```text
🎯 Goal          one sentence — what will exist that doesn't now
🔨 Build         step-by-step doing            ← comes FIRST, ≥50% of the chapter
▶️  Run it        what you should see
🧠 Why it works  the theory this build needed  ← comes AFTER, ≤30%
💥 Break it      deliberate sabotage + the error it produces
🏋️ Practicals    drills that change what you built
✅ Check         questions, answers collapsed
📎 Cheat sheet · 💾 Commit · ➡️ Next
```

**Theory is a debrief, never a gate.** And every major topic is met three times — naive, then correct, then professional — never all three at once.

### Help is removed on a schedule

Every chapter declares how much of it is guided ([ADR-033](docs/meta/Decisions.md#adr-033)):

| Modules | Guided / Independent |
|---|---|
| 0–1 | 90 / 10 |
| 2–4 | 70 / 30 |
| 5–7 | 50 / 50 |
| 8–9 | 30 / 70 |
| 10 | **10 / 90** |

Every major subsystem ends with a **⬜ blank-page build**: *requirements only — no steps, no reference implementation, no code.* The measure of success is not "I completed 348 chapters"; it is **"given a real requirement, I can design → implement → debug → test → profile → validate on Android → ship it."**

### Build it once, then adopt the library

The course is free-tools-only, but it doesn't teach you to reinvent everything. Twenty-eight 🧰 **adoption chapters** follow this pattern ([ADR-028](docs/meta/Decisions.md#adr-028)):

> **hand-build it** → **read the library's source** → **decide, and write down why**

Rigify after you hand-rig a biped. Phantom Camera after you write a follow camera. LogicBlocks after your own state machine. RetopoFlow after hand retopology. Terrain3D, Proton Scatter, Beehave, Dialogue Manager, GdUnit4, TexTools, FFmpeg — all after you've felt the problem they solve. Full catalogue: **[Toolchain.md](docs/Toolchain.md)**.

---

## The project spine

Nothing you build is throwaway. The capstone is assembled from the ten projects before it.

| | Project | After | You end up with |
|---|---|---|---|
| **P00** | Hello Phone | M0 | A signed APK you made, on your phone — day one |
| **P01** | Marble Runner | M1 | A finished 3-level game: physics, touch, camera, UI, saves, **title screen, ending screen, music** |
| **P02** | Foundry Kit | M3 | 14 modular assets **you** modelled, unwrapped, textured, baked |
| **P03** | Playground | M4 | A character that walks, runs, jumps and lands properly |
| **P04** | Hollow, Level 1 | M5 | A real lit level at 60fps on your actual phone |
| **P05** | VFX Lab | M6 | Six shaders you wrote by hand, plus Blender-baked effects |
| **P06** | Feel Pass | M7 | Proof of what sound and timing do to a game — **plus your own recorded, mixed, subtitled narration** |
| **P07** | The Slice | M8 | Splash → narrated cold open → menu → level → dialogue → guided walkthrough → narrated ending → credits |
| **P08** | Warden | M9 | **Your own character** — sculpt to animation, all yours |
| **P09** | Systems Refactor | M10 | Code you'd be happy to hand to a team |
| **P10** | 🏆 Ember Hollow | M11 | **A released Android game — released four times.** v1.0 after Level 1, then v1.1–v1.3 as staged updates to a live app |

Plus four **mini-jams** — timeboxed, constrained, no help given. Those are where you find out what you can do alone.

---

## Ground rules

1. **Type the code. Don't paste it.** You are building muscle memory for an API surface.
2. **Ship to the phone constantly.** A thing that runs in the editor but not on the device is not done.
3. **Every downloaded asset gets a row in [AssetLicenses.md](docs/reference/AssetLicenses.md) the moment you download it.** Not later. Untracked assets are how hobby projects become unshippable.
4. **Commit after every chapter.** Your git history becomes your revision notes.
5. **Never stop mid-chapter on a broken build.** Future-you will not remember what you were mid-thought about.
6. **If a chapter takes more than 2× its estimate, log it in [Doubts.md](docs/meta/Doubts.md) and move on.** Being stuck is data, not failure.

---

## On "AAA"

You'll see the goal stated as *professional, industry grade* rather than AAA. That's deliberate and it's worth one paragraph ([ADR-030](docs/meta/Decisions.md#adr-030)).

**AAA describes budget and headcount, not quality** — 100–300 people, $50–200 M, three to five years. No course produces that; it's a statement about organisational scale, not skill.

**Professional and industry-grade craft is entirely achievable, and is what this course targets in full**: measured asset pipelines, production rigging, previz, colour management, behaviour-tree AI, code standards with warnings-as-errors, unit-testable scene code, on-device profiling, CI, the milestones studios actually use, production tracking with Kitsu, structured playtesting, a published post-mortem, accessibility as a requirement, and a portfolio reel to show a studio.

At the end you won't have made a AAA game. You'll have the craft, the pipeline discipline and the shipped evidence to work on one — or to make something small and excellent alone, which is the harder and rarer thing.

---

## Two things you should know up front

**You need a desktop or laptop.** Godot's Android editor build has no C# support, so authoring happens on a desktop; your phone is the target device, and it is essential. Details in [PLAN.md §6.1](docs/PLAN.md).

**`[UNVERIFIED]` markers are deliberate.** This course is authored from a Termux session with no Godot, no Blender and no Android SDK. Any claim about what a tool actually prints carries an `[UNVERIFIED]` marker until you run it and report back — the alternative would be confidently-worded fiction. See [the verification protocol](docs/internal/VerificationRuns.md).

---

## Definition of done, for the whole course

> Someone who is not you installs your APK from a link, understands what to do without you explaining, plays from the intro to the credits, and sees your name on the screen at the end.

Everything here is in service of that sentence.

---

*Course conventions adopted from the sibling [`qnx-zero-to-hero`](https://github.com/Tyrostir/qnx-zero-to-hero) repository — see [ADR-025](docs/meta/Decisions.md#adr-025).*
*This is your notebook, not a read-only textbook. Edit it.*
