---
title: "Course Plan — Godot Zero to Hero"
document_id: PLAN
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When the course structure, scope or philosophy changes"
---

# Course Plan — Godot Zero to Hero

> *3D Android game development with Godot 4 (.NET/C#) and Blender, taught by building.*

---

## 1. The teaching philosophy

This course inverts the normal order. The normal order is: theory, theory, theory, then a project at the end that you never finish. Here the order is:

> **Build the thing → hit the wall → learn exactly the theory that gets you over the wall → build more.**

Concretely, every chapter has this shape:

| Section | What it is | Typical size |
|---|---|---|
| **Goal** | One sentence: what will exist at the end that did not exist at the start. | 1 line |
| 🏃 **Fast-Track Summary** | The whole chapter in ~10 bullets plus the finished code. Path C reads only this and the cheat sheet. | short |
| **Build** | Step-by-step doing. Code, clicks, keystrokes. This is 60–70% of the chapter. | the bulk |
| **Why it works** | The theory — but *only* the theory this build needed. Delivered after you've felt the need for it. | 20% |
| **Break it** | A deliberate sabotage + the error message it produces, so you learn the failure mode. | short |
| **Exercise** | 1–3 drills that change the build. No solutions handed over immediately. | short |
| **Check yourself** | 3–5 questions. Answers live in `reference/answers`. | short |
| **Commit** | The exact git commit message to use. | 1 line |

Theory is never a prerequisite gate. It is always a debrief.

### Why this works for you specifically

You asked to learn *everything from scratch* and to *go professional grade*. Those two goals fight each other if taught linearly — "everything from scratch" wants a huge theory foundation, "professional grade" wants shipping practice. The resolution is **spiral learning**: you meet every major topic three times.

1. **Pass 1 — Naive.** You do the simplest version that works. (e.g. a character that teleports on input.)
2. **Pass 2 — Correct.** You learn why the naive version is wrong and rebuild it properly. (physics-based movement with delta time and a state machine.)
3. **Pass 3 — Professional.** You learn the production concerns: performance on a mid-range Android chip, memory, tooling, data-driving it, testing it.

You'll see this pattern on the character controller, on lighting, on the save system, on Blender modelling, and on shaders.

---

## 1b. Three paths, one document

Every chapter is written for three readers at once, all three authored in full ([ADR-024](meta/Decisions.md#adr-024)) — the same choice you made on `qnx-zero-to-hero`, for the same reason: a future reader should be able to enter at any depth.

| Path | Who it's for | What they read | What they build |
|------|--------------|----------------|-----------------|
| 🐣 **A — Absolute Beginner** | New to programming *and* new to 3D | Everything, plus 🐣 *"New to this?"* boxes explaining the concepts a first-timer won't have | Complete code listings, never "add the obvious". CC0 placeholder art where Path B models its own |
| 🚶 **B — Self-Learner** | Comfortable coding, new to games and to Blender | The full chapter — every build step, every theory debrief, every practical | Everything. Models, rigs and animates their own art. Writes every shader by hand |
| 🏃 **C — Fast-Track Pro** | Experienced developer or artist, time-poor | The 🏃 Fast-Track Summary, the Build steps, the cheat sheet. Skips theory they already know | ⭐ core practicals only |

**Your path is 🚶 B.** Paths A and C are authored alongside it so the course stands on its own for anyone who finds it.

**How it looks on the page.** Not three documents — one document with markers. A 🏃 summary near the top; collapsed 🐣 boxes inline at the point of confusion; 🔬 optional deep dives; ⭐ on the practicals everyone does. Chapter headings carry `🐣🚶🏃` tags, or `🚶🏃` where Path A should skip.

> ⚠️ **This does not dilute the practical-first mandate.** The ≥50% build / ≤30% theory ratio is measured on the **Path B reading** — the chapter minus 🐣 boxes and the 🏃 summary. Path material *adds*; it never displaces the build.

**The cost, stated plainly:** roughly 1.5–2× the authoring effort per chapter, and longer chapters. You chose this knowingly over the cheaper markers-only alternative.

---

## 2. Two tracks, braided

| Track | What | Where |
|---|---|---|
| **Track A — Godot / C#** | Engine, code, systems, gameplay, shipping | Modules 0–10 |
| **Track B — Blender** | Modelling, sculpting, retopo, UV, texturing, shading, baking, rigging, animation, simulation, rendering, compositing, geometry nodes | Chapters `B0`–`B19`, interleaved |

Track B is **not** an appendix you do afterwards. It is braided in at the exact point the game needs the asset:

- You need a crate → you learn box modelling, modifiers, UV, texturing (B1–B8).
- You need a character → you learn sculpting, retopology, rigging, weight painting, animation (B9–B14).
- You need an explosion → you learn simulation and flipbook baking (B16).
- You need a trailer → you learn cameras, Cycles rendering and compositing (B17–B18).

Full Blender syllabus: **[BlenderTrack.md](BlenderTrack.md)**.

---

## 3. The project spine

Eleven projects. Each one is playable and each one is shipped to your phone. The capstone reuses code and art from every project before it — nothing you build is throwaway.

| ID | Project | Ships after | Teaches |
|---|---|---|---|
| **P00** | **Hello Phone** — a cube you can rotate, running on your Android device | Module 0 | Toolchain, export, signing, the whole loop, day one |
| **P01** | **Marble Runner** — tilt/touch controlled ball, ramps, collectibles, timer | Module 1 | Nodes, C#, 3D transforms, physics, input, camera, UI, save |
| **P02** | **Foundry Kit** — a 14-piece modular art kit, made by you, used in-game | Module 3 | Blender modelling → UV → texture → bake → glTF → Godot |
| **P03** | **Third-Person Playground** — a character that walks, runs, jumps, lands | Module 4 | Rigging, animation, AnimationTree, state machines, root motion |
| **P04** | **Hollow — Level 1** — a real, lit, playable level built from your kit | Module 5 | Level design, GridMap, baked GI, occlusion, LOD, 60fps on device |
| **P05** | **VFX Lab** — dissolve, force field, water, wind, impacts, smoke | Module 6 | GDShader, particles, decals, Blender-baked flipbooks |
| **P06** | **Feel Pass** — the same level, but it feels good | Module 7 | Audio buses, music layers, screenshake, hitstop, tweens, haptics |
| **P07** | **The Slice** — intro cinematic → menu → level → dialogue → ending | Module 8 | Story, GDD, dialogue system, cutscenes, camera direction, credits |
| **P08** | **Warden** — your own sculpted, retopo'd, rigged, animated character | Module 9 | Full character pipeline, end to end, your hands only |
| **P09** | **Systems Refactor** — the codebase you'd be happy to hand to a team | Module 10 | Architecture, Resources, settings tiers, profiling, tests |
| **P10** | **Ember Hollow** — the capstone. 4 levels, boss, full narrative, **released four times** | Module 11 | Production, polish, playtesting, Play Console, itch.io — and **live operations**: save migration, staged rollout, crash triage, hotfixes |

Full briefs and done-criteria: **[projects/README.md](../projects/README.md)**.

### 3a-2. The capstone ships four times

*Ember Hollow* has **four mandatory levels** — nothing is cut and no quality bar moves ([ADR-019](meta/Decisions.md#adr-019)). What changes is when the public first sees it:

| Release | Contains | Teaches |
|---------|----------|---------|
| **v1.0** | Level 1 at final quality, boss systems, narrative frame, settings, accessibility | Shipping |
| **v1.1** | Level 2 | Save migration across shipped versions · staged rollout |
| **v1.2** | Level 3 | Acting on real crash data and real feedback |
| **v1.3** | Level 4 + boss, content lock | Finishing |

**Why:** the commonest way a solo project fails is 500 hours of work and nothing released. After v1.0 that failure mode is gone and the remaining work is purely additive. It also teaches an entire discipline a ship-once model structurally cannot — **patching a live game**: save migration, staged rollout and rollback, crash triage from strangers' devices, hotfix branches, and acting on feedback from people who are not you (Module 11D). And Levels 3–4 get built with evidence instead of guesswork.

⚠️ **The chapter this depends on is 11.8b** — *designing for content you have not built yet*. Get the level format, spawn data and save schema right before v1.0, or v1.1 is a rewrite rather than an update.

### 3b. The Presentation Spine — every project is a *game*, not a tech demo

Story, the opening screen, the ending screen, music, ambience and the walkthrough are **not a module you reach eventually**. They run through every project from P01 onward, escalating in three passes ([ADR-026](meta/Decisions.md#adr-026)).

**From P01, a project is not shipped without:** an animated first page · an ending/results screen · at least one music loop · ambience where the piece has a place · a narrative frame, even one line · and a walkthrough that teaches without a wall of text.

You build your first title screen in **Module 1** (chapter 1.35), not Module 8. It is crude — that is the point. You rebuild it with a live 3D character in Module 4, with your own shaders in Module 6, and finally as a directed, scored, narrated opening in Module 8.

**Narration** gets eleven chapters of its own from Module 7, recorded by you with equipment you already own, with **mandatory synchronised subtitles** ([ADR-027](meta/Decisions.md#adr-027)).

> 📎 Full project-by-project mapping: **[PresentationSpine.md](PresentationSpine.md)**.

### 3c. Build it once, then adopt the library

The course is built entirely on **free** tools — but it does not pretend the free ecosystem doesn't exist, and it does not teach you to reinvent everything. Every major system is met three times ([ADR-028](meta/Decisions.md#adr-028)):

> **1️⃣ Hand-build it** → you understand the problem, not an API.
> **2️⃣ Compare** with the free library that does it properly — install it, *read its source*, find what it does better and worse.
> **3️⃣ Decide**, and write down why.

Sixty-three **adoption and variant chapters** (numbered `N.Mb`, `N.Mc`…, marked 🧰) do this, and **[ADR-032](meta/Decisions.md#adr-032) guarantees every library in the catalogue is actually used on real project content** — clustered into doing-sessions where several small tools share a purpose, never listed and left uninstalled: **Rigify** after you hand-rig a biped · **Phantom Camera** after you write a follow camera · **LogicBlocks** after your own state machine · **RetopoFlow** after hand retopology · **Terrain3D**, **Proton Scatter**, **Beehave/LimboAI**, **Dialogue Manager**, **GdUnit4**, **TexTools**, **FFmpeg**, **ImageMagick** and more.

**Step 3 is mandatory.** "A tutorial used it" is not a rationale. Chapter **0.10** teaches the six evaluation questions — licence, maintenance, **does it work from C#**, mobile cost measured on device, abandonment risk, and could you write it in a day — and you apply them every time thereafter. Choosing and rejecting dependencies is a larger part of professional work than writing code is.

⚠️ **One honest consequence of choosing C#**: most Godot addons are GDScript, and using them from C# costs you type safety and ergonomics — **but not access**. They are nodes; you instantiate and call them. Three answers, all taught: prefer C#-native or GDExtension libraries (the **Chickensoft** ecosystem is the key find), wrap GDScript addons behind a C# interface (10.6b), and use **NuGet**, which GDScript users don't have (0.11).

**And you are not restricted to one language** ([ADR-031](meta/Decisions.md#adr-031)). Godot's .NET build runs **GDScript and C# side by side**, and a **C++ GDExtension class registers as an engine type both can use**. The course teaches this deliberately: **C# primary** for systems and architecture, **GDScript secondary** for `@tool` editor scripts and addon glue, **C++ last resort** for a hot path you have measured. Every boundary lives in one wrapper file. Chapters **0.10b** and **10.1b**.

> 📎 Full catalogue, licences and caveats: **[Toolchain.md](Toolchain.md)**.

### 3c-2. Four languages, taught by measurement

Godot genuinely uses four languages, and this course teaches all four — each scoped to the jobs it is best at ([ADR-001](meta/Decisions.md#adr-001), [ADR-031](meta/Decisions.md#adr-031)).

| Language | Role | Chapters | You write it for |
|----------|------|----------|------------------|
| **C#** | 🥇 Primary | ~180 | Gameplay systems, architecture, data, saves, tests |
| **GDScript** | 🥈 Secondary | 8 | `@tool` editor scripts, editor plugins, addon glue, prototyping |
| **C++** (GDExtension) | 🥉 Last resort | 7 | A hot path you have **measured**; wrapping native libraries |
| **GDShader** | 🎨 GPU | 12 | Anything running per-vertex or per-pixel |

**You are not told the differences — you measure them.** Module 0's block **0B** builds the *same spinning cube* in GDScript (0.10), C# (0.11) and C++ (0.13–0.14), on your own hardware, recording build time, APK size, lines of code and iteration speed. In **0.17 you write the language decision table yourself, from your own numbers**, and use it for the next 300 chapters.

> ⚠️ **0.13–0.14 will take an afternoon and will feel disproportionate.** That's deliberate. You won't need C++ again until Module 10 — doing the toolchain once now, when nothing depends on it, means Module 10 is about *performance* rather than about SCons.

**The rule that keeps four languages from becoming four sets of problems:** every boundary lives in **one wrapper file**. Chapters 10.1c and 9.6b.

> 📎 Full curriculum: **[Languages.md](Languages.md)**.

### 3c-3. Help is removed on a schedule

A course built on learning by doing needs a **gradient toward doing it alone**, or it produces someone who can follow instructions. Every chapter declares its guided/independent split ([ADR-033](meta/Decisions.md#adr-033)):

| Stage | Modules | Guided / Independent |
|-------|---------|---------------------|
| Early | 0–2 | **90 / 10** |
| Intermediate | 3–5 | **70 / 30** |
| Advanced | 6–8 | **50 / 50** |
| Professional | 9–10 | **30 / 70** |
| Capstone | 11–12 | **10 / 90** |

Every major subsystem ends with a **⬜ blank-page build** — *requirements only, no steps, no reference implementation, no code*. There are eight, plus four mini-jams and the autopsies in [Exercises.md](Exercises.md). The progression per subsystem is **guided build → variation → ⬜ blank-page → jam → autopsy**.

**This changes what "done" means for the whole course.** Not *"I completed 348 chapters"* but *"given a real requirement, I can design → implement → debug → test → profile → validate on Android → ship it."*

### 3c-4. Android is a runtime, not just a build target

**Module 2** (2.7–2.16) covers what the plan previously missed entirely ([ADR-034](meta/Decisions.md#adr-034)): the activity lifecycle · interruptions · process death and resume · **the chaos test** · input beyond touch · screens you did not design for · **the device tier matrix** · **explicit performance budgets** · profile-first optimisation.

**P01 does not ship until it survives the chaos test** — home · reopen · lock · unlock · rotate · simulate a call · task-switch · **kill the process** · reopen · load save. From there it is a done-criterion on every project.

That is the difference between a game that renders correctly and a game that survives a phone call, and it sits *before* your first release rather than after it.

### 3d. What "industry grade" means here

You said you want to reach **AAA / professional / industry grade**. Two of those three are what this course targets in full. One deserves an honest word ([ADR-030](meta/Decisions.md#adr-030)).

**"AAA" describes budget and headcount, not quality** — 100–300 people, $50–200 M, three to five years. No course produces that and no solo developer achieves it, because it is a statement about organisational scale rather than skill.

**"Professional" and "industry grade" are entirely achievable**, and the course now teaches them explicitly: a real asset pipeline with measured budgets · production rigging · storyboards and previz · colour management · behaviour-tree AI · code standards with analyzers and warnings-as-errors · unit-testable scene code · structured logging and on-device profiling · CI that builds a signed artefact on every tag · **the milestones studios actually use** (first playable, vertical slice, alpha, beta, content lock, gold) · **production tracking with Kitsu** · structured playtesting · **a published post-mortem** · accessibility as a requirement · and **a portfolio and breakdown reel** to show a studio.

At the end you will not have made a AAA game. You will have the craft, the pipeline discipline and the shipped evidence to work on one — or to make something small and excellent alone, which is the harder and rarer thing.

Between modules there are also **Mini-Jams** — 2-to-4-hour constrained builds ("make a game where the only verb is *falling*") to force synthesis without hand-holding.

---

## 4. Syllabus in brief

> Chapter-level detail is in **[TableOfContents.md](TableOfContents.md)**.

**Module 0 — Toolchain & First APK.** Machines and their roles. Godot 4 .NET, .NET SDK, Blender, JDK, Android SDK. Git, `.gitignore`, LFS. Editor tour. **Ship P00 to your phone.** Then: the Asset Library and **how to evaluate a dependency** (six questions), **NuGet**, and version management.

**Module 1 — Godot Foundations (P01 Marble Runner).** Nodes and scenes. The scene tree. C# scripts, lifecycle, `[Export]`. 3D transforms, basis, quaternions-when-you-need-them. Physics bodies. Input: keyboard, touch, gesture, accelerometer. Camera rigs and `SpringArm3D`. Signals and C# events. UI, anchors, Android safe area. Scene switching, autoloads. Saving to `user://`.

**Module 3 — Blender I: Props & the Asset Pipeline (P02 Foundry Kit).** `B1–B8`. Interface, navigation, units matched to Godot. Box modelling. Modifiers. Topology and poly budgets for mobile. UV unwrapping and texel density. PBR theory and the Principled BSDF. Texture painting without paid tools. Baking normal/AO/curvature/ID. glTF export settings, collision naming conventions, Godot's import dock and import presets.

**Module 4 — Characters I: Rig & Animate (P03 Playground).** `B9–B14`. Character silhouette and proportion. Armatures, bone naming, IK vs FK. Weight painting. The 12 principles applied to a run cycle. NLA. Mixamo: getting free animations and retargeting them in Blender. Root motion vs in-place. In Godot: `Skeleton3D`, `AnimationPlayer`, `AnimationTree`, state machines, `BlendSpace2D`. A C# character controller built as a real state machine.

**Module 5 — Worlds, Lighting & Mobile Performance (P04 Level 1).** Level design theory: pacing, landmarks, affordance, gating, the critical path. Greyboxing with CSG. `GridMap` and `MeshLibrary`. Terrain. Lighting: direct, shadow, `LightmapGI` vs `SDFGI` vs `VoxelGI` and why mobile means baked. `WorldEnvironment`: sky, fog, tonemapping, glow, SSAO — and the exact cost of each on a phone. Occlusion culling, LOD, `MultiMeshInstance3D`. Mobile vs Forward+ renderer. ETC2/ASTC texture compression.

**Module 6 — Shaders & VFX (P05 VFX Lab).** A mental model of the render pipeline. GDShader: spatial shaders, vertex and fragment stages, built-ins. Practical shaders you will actually ship: dissolve, force field, stylised water, wind-swayed foliage, toon ramp, triplanar. Driving shader params from C#. `GPUParticles3D`, process materials, sub-emitters, trails. Baking Blender smoke/fire simulations into flipbook sheets. Decals. Screen-space post effects. Shader compilation stutter and how to prewarm.

**Module 7 — Audio, Narration & Game Feel (P06 Feel Pass).** `AudioStreamPlayer3D`, buses, effects, attenuation. Free audio sources and their licences. Editing in Audacity. Footsteps by surface. Adaptive music: loops, stingers, layers — and music that doesn't wear out. **Then narration, in full: writing for the ear; recording with a phone and a wardrobe; cleaning a take without over-processing it; the narration bus and side-chain ducking; synchronised subtitles; text-to-speech and its licensing.** Then game feel: tweening, easing curves, screenshake done tastefully, hitstop, camera kick, haptics.

**Module 8 — Story, Narrative & Cinematics (P07 The Slice).** Premise, theme, logline. Character arc. Environmental storytelling. Ludonarrative harmony — and dissonance. **Directing narration: who speaks, to whom, in what tense, and when silence is stronger.** Writing the GDD and the narrative bible. A data-driven dialogue system in C# with choices, portraits and a typewriter effect. **A narration system: cue-driven VO with synchronised subtitles, automatic music ducking, and a skip that doesn't break state.** Cutscenes with `AnimationPlayer` timelines, camera cuts and `Path3D` dollies. The splash/intro animation. The main-menu animation with its own theme. The narrated cold open. **The guided walkthrough — teaching the first five minutes with narration, camera and level rather than a wall of text.** Loading screens that don't lie. The narrated ending sequence. An auto-generated credits roll over an end-credits theme. Localisation, including what localising *audio* actually costs.

**Module 9 — Characters II: Your Own (P08 Warden).** `B9–B15` at depth. Concept and blockout. Sculpting. Retopology by hand. High-to-low baking. Hand-painted and procedural texturing. A production rig with IK, pole targets, and custom bone shapes. Facial basics. A hand-keyed animation set: idle, walk, run, jump, attack, hit, death. Export and retarget into the P03 controller.

**Module 10 — Architecture, Performance & Tooling (P09 Refactor).** C# in Godot: marshalling cost, allocations, the GC on mobile, `struct` vs `class`, object pooling. Composition over inheritance in a node tree. Custom `Resource` types for data-driven design. A versioned save system. A settings screen with real graphics tiers for low-end devices. Unit testing. Remote debugging and profiling on the device. `adb logcat`.

**Module 11 — Capstone: Ship, Then Keep Shipping (P10 Ember Hollow).** Pre-production and the release plan. Enemy AI with `NavigationAgent3D`, behaviour trees, combat, progression. **Designing for content you have not built yet** — the level format, spawn data and save schema that make v1.1 an update rather than a rewrite. Then **Level 1 to final quality and out the door as v1.0**: polish pass, playtesting, accessibility, keystores, AAB, icons, app size, CI, trailer, store listing, privacy policy. Then **live operations** — crash and ANR monitoring, **save migration across shipped versions**, staged rollout and rollback, release notes, triaging feedback from strangers, hotfix discipline. Then **Levels 2, 3 and 4 shipped as v1.1, v1.2 and v1.3**, each informed by real player data. Finally: upgrade discipline, the player-facing walkthrough, the post-mortem, and your portfolio reel.

**Module 12 — Beyond (optional).** Multiplayer basics, procedural generation, Geometry Nodes at depth, editor plugins and custom tooling, GDExtension, porting to desktop.

---

## 5. Honest constraints — read this before you start

These are real limitations of the toolchain and of your setup. Knowing them now saves you a week later.

**6.1 — You cannot do this course on the phone alone.**
This Termux session is a good place to write, plan, and manage git. It is not where the game gets built. Godot's C#/.NET tooling needs a desktop .NET SDK, and the Android *editor* build of Godot does **not** support C# at all. Your Android phone is the **target device**, and it is essential — you will deploy to it constantly.

**Your build machine is a Linux desktop** (confirmed, [D-001](meta/Doubts.md)). That settles the setup route: the lean command-line Android SDK rather than the ~8 GB Android Studio install, OpenJDK from your distribution's packages, and a `udev` rule so `adb` sees the phone without `sudo`. The guides lead with Linux; Windows and macOS steps remain for other readers.

**6.2 — C# on Android in Godot is supported, but it is the less-travelled path.**
Godot's .NET Android export works (4.2+ introduced it, later 4.x releases hardened it), but you will occasionally hit rough edges that a GDScript user would not: longer export times, larger APKs, and fewer StackOverflow answers. This course chooses C# anyway because you asked for it and because it is the better skill to own — but expect to read the official docs and Godot's GitHub issues sometimes. `reference/Troubleshooting.md` collects the known ones.

**6.3 — Pin your versions.**
Record the exact Godot, .NET, Blender, JDK and Android SDK versions you install in `guides/Setup_01_Prerequisites.md`. When something in this course doesn't match your editor, a version difference is the first suspect.

**6.4 — Mobile is a hard performance target.**
A mid-range Android phone has roughly the GPU budget of a 2013 laptop and a thermal budget of about ten minutes. Almost every "make it pretty" technique you'll read about online assumes a desktop GPU. This course teaches the mobile-safe version *first* and mentions the desktop version second. If you ignore this you will build a beautiful game that runs at 14fps and cooks your phone.

**6.5 — Scope is the thing that kills projects, not skill.**
The capstone is deliberately small: four short levels and one boss. It will still take you longer than you expect. When you feel the urge to add a crafting system, write it in `GameDesignDocument.md` under *Post-launch* and move on.

---

## 6. Pacing

There is no calendar here — you set the pace. But for calibration:

| Module | Rough effort | Cumulative |
|---|---|---|
| 0 | 12–18 h | 18 h |
| 1 | 30–42 h | 60 h |
| 2 | 34–46 h | 106 h |
| 3 | 36–48 h | 154 h |
| 4 | 36–48 h | 202 h |
| 5 | 30–42 h | 244 h |
| 6 | 23–32 h | 276 h |
| 7 | 36–48 h | 324 h |
| 8 | 50–72 h | 396 h |
| 9 | 42–60 h | 456 h |
| 10 | 72–140 h | 596 h |

Roughly **580–670 hours** to a game released four times. At 10 h/week that is a year; at 20 h/week, six months. Both are normal. Track your actual hours in `meta/Journal.md` — after Module 3 you will be able to estimate your own speed, which is itself a professional skill.

**Rhythm that works:** one chapter per session, ending on a green build and a commit. Never stop mid-chapter on a broken build — future-you will not remember what you were mid-thought about.

---

## 7. How you and I work together

- Ask me to **start a chapter** by number: *"start 1.4"*. I'll teach it in the Build → Why → Break → Exercise → Check shape.
- Ask me to **review** your code or your `.blend` decisions; paste the code or describe the outliner.
- When you're stuck, log it in `meta/Doubts.md` first, then ask — writing the question well usually solves a third of them.
- Ask for a **mini-jam** when you want to test yourself without scaffolding.
- Ask me to **update the trackers** at the end of a session; I'll tick `meta/CourseState.md` and file answered questions into `meta/Doubts.md`.

---

## 8. Definition of done, for the course

You are done when someone who is not you can install your APK from a link, understand what to do without you explaining, play from the intro to the credits, and see your name on the screen at the end. Everything in this plan is in service of that sentence.
