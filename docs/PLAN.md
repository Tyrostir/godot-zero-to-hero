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
| **P02** | **Foundry Kit** — a 14-piece modular art kit, made by you, used in-game | Module 2 | Blender modelling → UV → texture → bake → glTF → Godot |
| **P03** | **Third-Person Playground** — a character that walks, runs, jumps, lands | Module 3 | Rigging, animation, AnimationTree, state machines, root motion |
| **P04** | **Hollow — Level 1** — a real, lit, playable level built from your kit | Module 4 | Level design, GridMap, baked GI, occlusion, LOD, 60fps on device |
| **P05** | **VFX Lab** — dissolve, force field, water, wind, impacts, smoke | Module 5 | GDShader, particles, decals, Blender-baked flipbooks |
| **P06** | **Feel Pass** — the same level, but it feels good | Module 6 | Audio buses, music layers, screenshake, hitstop, tweens, haptics |
| **P07** | **The Slice** — intro cinematic → menu → level → dialogue → ending | Module 7 | Story, GDD, dialogue system, cutscenes, camera direction, credits |
| **P08** | **Warden** — your own sculpted, retopo'd, rigged, animated character | Module 8 | Full character pipeline, end to end, your hands only |
| **P09** | **Systems Refactor** — the codebase you'd be happy to hand to a team | Module 9 | Architecture, Resources, settings tiers, profiling, tests |
| **P10** | **Ember Hollow** — the capstone. 4 levels, boss, full narrative, released | Module 10 | Production, scope, polish, playtesting, Play Console, itch.io |

Full briefs and done-criteria: **[projects/README.md](../projects/README.md)**.

Between modules there are also **Mini-Jams** — 2-to-4-hour constrained builds ("make a game where the only verb is *falling*") to force synthesis without hand-holding.

---

## 4. Syllabus in brief

> Chapter-level detail is in **[TableOfContents.md](TableOfContents.md)**.

**Module 0 — Toolchain & First APK.** Machines and their roles. Godot 4 .NET, .NET SDK, Blender, JDK, Android SDK. Git, `.gitignore`, LFS. Editor tour. **Ship P00 to your phone.**

**Module 1 — Godot Foundations (P01 Marble Runner).** Nodes and scenes. The scene tree. C# scripts, lifecycle, `[Export]`. 3D transforms, basis, quaternions-when-you-need-them. Physics bodies. Input: keyboard, touch, gesture, accelerometer. Camera rigs and `SpringArm3D`. Signals and C# events. UI, anchors, Android safe area. Scene switching, autoloads. Saving to `user://`.

**Module 2 — Blender I: Props & the Asset Pipeline (P02 Foundry Kit).** `B1–B8`. Interface, navigation, units matched to Godot. Box modelling. Modifiers. Topology and poly budgets for mobile. UV unwrapping and texel density. PBR theory and the Principled BSDF. Texture painting without paid tools. Baking normal/AO/curvature/ID. glTF export settings, collision naming conventions, Godot's import dock and import presets.

**Module 3 — Characters I: Rig & Animate (P03 Playground).** `B9–B14`. Character silhouette and proportion. Armatures, bone naming, IK vs FK. Weight painting. The 12 principles applied to a run cycle. NLA. Mixamo: getting free animations and retargeting them in Blender. Root motion vs in-place. In Godot: `Skeleton3D`, `AnimationPlayer`, `AnimationTree`, state machines, `BlendSpace2D`. A C# character controller built as a real state machine.

**Module 4 — Worlds, Lighting & Mobile Performance (P04 Level 1).** Level design theory: pacing, landmarks, affordance, gating, the critical path. Greyboxing with CSG. `GridMap` and `MeshLibrary`. Terrain. Lighting: direct, shadow, `LightmapGI` vs `SDFGI` vs `VoxelGI` and why mobile means baked. `WorldEnvironment`: sky, fog, tonemapping, glow, SSAO — and the exact cost of each on a phone. Occlusion culling, LOD, `MultiMeshInstance3D`. Mobile vs Forward+ renderer. ETC2/ASTC texture compression.

**Module 5 — Shaders & VFX (P05 VFX Lab).** A mental model of the render pipeline. GDShader: spatial shaders, vertex and fragment stages, built-ins. Practical shaders you will actually ship: dissolve, force field, stylised water, wind-swayed foliage, toon ramp, triplanar. Driving shader params from C#. `GPUParticles3D`, process materials, sub-emitters, trails. Baking Blender smoke/fire simulations into flipbook sheets. Decals. Screen-space post effects. Shader compilation stutter and how to prewarm.

**Module 6 — Audio & Game Feel (P06 Feel Pass).** `AudioStreamPlayer3D`, buses, effects, attenuation. Free audio sources and their licences. Adaptive music: loops, stingers, layers. Game feel: tweening, easing curves, screenshake done tastefully, hitstop, camera kick, controller/handheld haptics.

**Module 7 — Story, Narrative & Cinematics (P07 The Slice).** Premise, theme, logline. Character arc. Environmental storytelling. Ludonarrative harmony — and dissonance. Writing the GDD and the narrative bible. A data-driven dialogue system in C# with choices, portraits and a typewriter effect. Cutscenes with `AnimationPlayer` timelines, camera cuts and `Path3D` dollies. The splash/intro animation. The main-menu animation. Loading screens that don't lie. The ending sequence. An auto-generated credits roll fed by your licence ledger. Localisation.

**Module 8 — Characters II: Your Own (P08 Warden).** `B9–B15` at depth. Concept and blockout. Sculpting. Retopology by hand. High-to-low baking. Hand-painted and procedural texturing. A production rig with IK, pole targets, and custom bone shapes. Facial basics. A hand-keyed animation set: idle, walk, run, jump, attack, hit, death. Export and retarget into the P03 controller.

**Module 9 — Architecture, Performance & Tooling (P09 Refactor).** C# in Godot: marshalling cost, allocations, the GC on mobile, `struct` vs `class`, object pooling. Composition over inheritance in a node tree. Custom `Resource` types for data-driven design. A versioned save system. A settings screen with real graphics tiers for low-end devices. Unit testing. Remote debugging and profiling on the device. `adb logcat`.

**Module 10 — Capstone & Release (P10 Ember Hollow).** Pre-production and ruthless scope control. The vertical slice. A production schedule. Enemy AI with `NavigationAgent3D` and behaviour state machines. A boss fight. Playtesting protocol and what to actually record. The polish pass. Export templates, keystores, AAB vs APK, icons and adaptive icons, app size. GitHub Actions CI that builds your APK. itch.io page, trailer capture, Play Console internal testing, privacy policy.

**Module 11 — Beyond (optional).** Multiplayer basics, procedural generation, Geometry Nodes at depth, editor plugins and custom tooling, GDExtension, porting to desktop.

---

## 5. Honest constraints — read this before you start

These are real limitations of the toolchain and of your setup. Knowing them now saves you a week later.

**5.1 — You cannot do this course on the phone alone.**
This Termux session is a good place to write, plan, and manage git. It is not where the game gets built. Godot's C#/.NET tooling needs a desktop .NET SDK, and the Android *editor* build of Godot does **not** support C# at all. Your Android phone is the **target device**, and it is essential — you will deploy to it constantly.

**Your build machine is a Linux desktop** (confirmed, [D-001](meta/Doubts.md)). That settles the setup route: the lean command-line Android SDK rather than the ~8 GB Android Studio install, OpenJDK from your distribution's packages, and a `udev` rule so `adb` sees the phone without `sudo`. The guides lead with Linux; Windows and macOS steps remain for other readers.

**5.2 — C# on Android in Godot is supported, but it is the less-travelled path.**
Godot's .NET Android export works (4.2+ introduced it, later 4.x releases hardened it), but you will occasionally hit rough edges that a GDScript user would not: longer export times, larger APKs, and fewer StackOverflow answers. This course chooses C# anyway because you asked for it and because it is the better skill to own — but expect to read the official docs and Godot's GitHub issues sometimes. `reference/Troubleshooting.md` collects the known ones.

**5.3 — Pin your versions.**
Record the exact Godot, .NET, Blender, JDK and Android SDK versions you install in `guides/Setup_01_Prerequisites.md`. When something in this course doesn't match your editor, a version difference is the first suspect.

**5.4 — Mobile is a hard performance target.**
A mid-range Android phone has roughly the GPU budget of a 2013 laptop and a thermal budget of about ten minutes. Almost every "make it pretty" technique you'll read about online assumes a desktop GPU. This course teaches the mobile-safe version *first* and mentions the desktop version second. If you ignore this you will build a beautiful game that runs at 14fps and cooks your phone.

**5.5 — Scope is the thing that kills projects, not skill.**
The capstone is deliberately small: four short levels and one boss. It will still take you longer than you expect. When you feel the urge to add a crafting system, write it in `GameDesignDocument.md` under *Post-launch* and move on.

---

## 6. Pacing

There is no calendar here — you set the pace. But for calibration:

| Module | Rough effort | Cumulative |
|---|---|---|
| 0 | 4–8 h | 8 h |
| 1 | 20–30 h | 38 h |
| 2 | 25–35 h | 73 h |
| 3 | 30–40 h | 113 h |
| 4 | 25–35 h | 148 h |
| 5 | 25–35 h | 183 h |
| 6 | 12–18 h | 201 h |
| 7 | 25–35 h | 236 h |
| 8 | 40–60 h | 296 h |
| 9 | 20–30 h | 326 h |
| 10 | 60–120 h | 446 h |

Roughly **400–450 hours** to a released game. At 10 h/week that is a year; at 20 h/week, six months. Both are normal. Track your actual hours in `meta/Journal.md` — after Module 2 you will be able to estimate your own speed, which is itself a professional skill.

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
