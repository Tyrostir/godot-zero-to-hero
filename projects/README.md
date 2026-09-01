---
title: "Projects — Index, Briefs and Done-Criteria"
document_id: PROJ
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When a project brief or its done-criteria change"
---

# Projects

Eleven projects. Each is playable, each ships to your phone, and each one feeds the next — the capstone is assembled from code and art you built in the ten before it.

Every project has a **Done when** list. Those are not suggestions. A project is done when every box is ticked on your actual device, not in the editor.

> 🎬 **The Presentation Spine** ([ADR-026](../docs/meta/Decisions.md#adr-026)). From **P01 onward**, no project is done without an **animated first page**, an **ending/results screen**, **background music**, **ambience** where the piece has a place, a **narrative frame** (even one line), and a **walkthrough** that teaches without a wall of text. Narration joins from Module 6. These appear as 🎬 🏁 🎵 📖 🚶 🔊 items in the lists below.
>
> Full mapping and rationale: [`../docs/PresentationSpine.md`](../docs/PresentationSpine.md).

---

## P00 — *Hello Phone*
**After Module 0 · 1–3 hours · `projects/P00_HelloPhone/`**

**Brief.** A cube. It spins. It runs on your Android phone, installed from a build you made.

**Why this is first.** Because the toolchain is the hardest part of Android game development and it has nothing to do with game development. Getting a signed APK onto a device involves Godot, .NET, MSBuild, the JDK, the Android SDK, a keystore, adb and USB debugging. Every one of those can fail independently. Doing it on day one — when the game is one cube and there's nothing to blame but the tooling — means you debug the pipeline once, in isolation, and never again.

**Done when**
- [ ] The `Build` button succeeds with no errors
- [ ] It runs on the desktop with F5
- [ ] `adb devices` lists your phone
- [ ] The APK installs and the cube spins **on the phone**
- [ ] You changed `DegreesPerSecond` in the inspector and saw it take effect
- [ ] `git log` shows your first commit

---

## P01 — *Marble Runner*
**After Module 1 · 20–30 hours · `projects/P01_MarbleRunner/`**

**Brief.** A rolling-ball obstacle course. Three short levels. Tilt or on-screen-joystick control, switchable. Collectibles, a timer, a fall-out-of-world respawn, a HUD, a pause menu, a level select, and best times that survive closing the app.

**Why this shape.** A marble is the simplest possible 3D protagonist — it has no animation, no state machine, no rig — so every hour goes into learning the *engine* rather than into character work. But it still needs genuinely every foundational system: physics, input, camera, UI, scene management, persistence. It is a complete game with the character work deliberately removed.

**Done when**
- [ ] Marble rolls with physics (not by setting position directly)
- [ ] Both control schemes work on the phone, switchable in a menu
- [ ] Camera follows smoothly with no jitter and no clipping through walls
- [ ] Collectibles disappear, play a sound, and increment a counter
- [ ] Falling off respawns at the last checkpoint
- [ ] Timer runs, pauses correctly, and stops at the goal
- [ ] Best time per level persists across an app restart **on the device**
- [ ] Pause menu works, including resume/restart/quit
- [ ] UI is readable and correctly inset on your phone, including any notch
- [ ] Three levels, each beatable, each with a different idea in it
- [ ] 🎬 **Animated title screen** — text and buttons tween in; timing feels deliberate, not accidental *(1.35)*
- [ ] 🏁 **Results screen** — time, collectibles, and a payoff beat before the numbers land *(1.36)*
- [ ] 🎵 **One music loop** that loops seamlessly, plus at least three SFX *(1.37)*
- [ ] 📖 **A one-line premise on the title card** — and you can say how it changes the way Level 1 reads *(1.38)*
- [ ] 🚶 Level 1 teaches the controls **by shape alone**, with no text

**Stretch:** ghost replay of your best run; a moving-platform level; a level built from a `GridMap`.

---

## P02 — *Foundry Kit*
**After Module 2 · 25–35 hours · `assets-staging/foundry-kit/` → `projects/P01`**

**Brief.** A 14-piece modular environment kit, modelled, UV'd, textured and baked entirely by you in Blender, exported to Godot, assembled into a `MeshLibrary`, and used to replace Marble Runner's grey boxes.

**The 14 pieces.** Floor tile · wall panel · wall panel with window · corner post · doorway frame · stair module · railing section · pipe straight · pipe elbow · crate · barrel · lamp post · girder · vent grate.

**Constraints (this is the point of the exercise).**
- Everything snaps to a **2 m grid**. Modularity is a discipline, not a style.
- Whole kit shares **one 2048×2048 texture atlas**. One material. One draw call per batch.
- Total kit budget: **under 12,000 triangles**.
- Consistent texel density across every piece (chapter B11).
- Normal maps baked from high-poly, not faked with a filter.

**Why one atlas.** It forces you to learn UV packing, texel density and trim sheets — the three things that separate an art *kit* from a pile of models. It's also what makes it run on a phone.

**Done when**
- [ ] All 14 pieces modelled, with clean topology and correct scale (1 unit = 1 m)
- [ ] All UV'd into a single atlas with uniform texel density
- [ ] One PBR material set: albedo, normal, and a packed ORM texture
- [ ] Normals baked from high-poly; no shading artefacts on the low-poly
- [ ] Exported as `.glb` with correct naming, collision suffixes, and origins at sensible pivots
- [ ] Imported into Godot as a `MeshLibrary`
- [ ] A Marble Runner level rebuilt with the kit, still running at full framerate on the phone
- [ ] Under 12k triangles total, measured and written down
- [ ] 📖 **Each prop implies a place** — you can say what the crate's scratches, the barrel's stains and the lamp's design tell a player about who worked here *(2.22)*
- [ ] 🎬 Marble Runner's title screen re-skinned with **your own art**

---

## P03 — *Third-Person Playground*
**After Module 3 · 30–40 hours · `projects/P03_Playground/`**

**Brief.** A test-chamber level with slopes, stairs, gaps, ledges and drop-offs, and a humanoid character who handles all of them convincingly. Idle, walk, run, jump, fall, land, and one extra state of your choosing — blended, not snapped, and driven by a real state machine.

**Note.** You may use a Quaternius or Mixamo character here. Building your *own* is Module 8. Separating "learn the animation system" from "learn character art" keeps each one tractable.

**Done when**
- [ ] Character rigged (or a rig you understand), imported with all clips in one `.glb`
- [ ] `AnimationTree` state machine with clean transitions and no popping
- [ ] `BlendSpace` locomotion — idle→walk→run blends with speed, no snapping
- [ ] Movement is camera-relative and the character turns toward its motion smoothly
- [ ] Jump has coyote time, jump buffering and variable height
- [ ] Slopes are walkable up to a threshold and slide above it
- [ ] Stairs are climbed without stuttering
- [ ] `SpringArm3D` camera never clips into geometry
- [ ] State machine is C# classes, not a `switch` statement
- [ ] Runs at target framerate on the phone with touch controls
- [ ] 📖 **Character identity** — the idle pose and walk say something specific about who this is; you can state it in one sentence *(3.11)*
- [ ] 🎬 **Title screen, pass 2** — a live 3D character idling behind the UI, slow camera drift *(3.12)*
- [ ] 🔊 Footsteps, landings and cloth audible and matched to the animation

---

## P04 — *Hollow, Level 1*
**After Module 4 · 25–35 hours · `projects/P04_Hollow/`**

**Brief.** The first real level of the capstone game. Built from the Foundry Kit, designed to a written brief, lit with baked GI, and optimised until it holds **60fps on your actual phone**.

**Design brief.** A ~6-minute traversal from a collapsed entrance to a sealed door. It must teach jumping without a tutorial prompt, contain one memorable landmark visible from three points in the level, one optional side-route with a reward, and one moment of vertical drop that the player can see before they descend.

**Done when**
- [ ] Level greyboxed on paper first, then in CSG, then art-passed with the kit
- [ ] The design brief above is satisfied, and you can point to where each requirement is met
- [ ] Lightmaps baked, with UV2 correct and no bake artefacts
- [ ] `WorldEnvironment` set up, with every effect justified against its cost
- [ ] Occlusion culling and LOD in place where they earn their keep
- [ ] **60fps sustained on device**, measured over 5 minutes of play (not 30 seconds — watch for thermal throttle)
- [ ] Draw calls, triangles and texture memory measured and recorded in the journal
- [ ] A written optimisation log: what you changed, and the frame time before and after each change
- [ ] 📖 **Environmental storytelling** — the landmark carries a story beat; you can say what the ruins imply without writing a word of text *(4.19)*
- [ ] 🎬 **Level flythrough** — an in-engine `Path3D` camera move, used as the menu backdrop *(4.20)*
- [ ] 🚶 ⭐ **The walkthrough is designed in** — a first-time player reaches the end without a tutorial prompt. Verified by watching someone do it *(4.21)*
- [ ] 🔊 **Ambience bed** — the level sounds like a place, not like a scene *(4.22)*
- [ ] 🏁 Level-complete sequence with a beat of pause before the UI appears

---

## P05 — *VFX Lab*
**After Module 5 · 25–35 hours · `projects/P05_VFXLab/`**

**Brief.** A gallery scene with six shaders and four particle effects, all written by you, all with live-tweakable parameters — plus a combat impact effect wired into the Playground.

**Contents.** Dissolve · force field · stylised water · wind-swayed foliage · toon ramp with rim light · triplanar cliff. Particles: impact burst · continuous smoke plume (Blender-baked flipbook) · magic trail · footstep dust.

**Done when**
- [ ] All six shaders written by hand in GDShader (not copy-pasted; you can explain every line)
- [ ] All exposed as uniforms and driven live from a C# debug panel
- [ ] A smoke or fire flipbook simulated in Blender, baked to a sheet, playing in Godot
- [ ] The impact effect combines particles + decal + shader + screen effect
- [ ] Total GPU cost of the impact effect measured and under budget
- [ ] Shader compilation stutter identified and prewarmed away
- [ ] The whole lab scene runs on the phone without dropping frames
- [ ] 🎬 **Title screen, pass 3** — driven by your own shaders: dissolve-in title, animated background *(5.22)*

---

## P06 — *Feel Pass*
**After Module 6 · 12–18 hours · applied to `projects/P04_Hollow/`**

**Brief.** Take Level 1 and make it feel good. No new geometry, no new mechanics. Only sound and response.

**Done when**
- [ ] Full audio bus layout: master, music, SFX, ambience, UI — with a working settings mixer
- [ ] Footsteps change with surface material
- [ ] 3D positional audio with sensible attenuation, tested on phone speakers *and* headphones
- [ ] Ambient bed + at least one adaptive music layer
- [ ] Every UI interaction has a sound and a tween
- [ ] Screenshake uses a noise function, is subtle, and can be disabled in settings
- [ ] Landing, impact and pickup all have hitstop or a camera response
- [ ] Haptics on key events, and an off switch
- [ ] 🎵 **Music that doesn't wear out** — variation, dynamic range, and at least one deliberate silence *(6.7)*
- [ ] 🔊 ⭐ **Your first recorded narration** — written for the ear, recorded on equipment you already own, cleaned without over-processing *(6.8–6.10)*
- [ ] 🔊 **Narration bus with side-chain ducking** — voice is intelligible over music **on a phone speaker**, tested *(6.11)*
- [ ] 🔊 **Synchronised subtitles** for every narrated line, with a toggle *(6.12)*
- [ ] 🎬 Title and end screens get their audio and juice pass
- [ ] **A side-by-side recording of before and after, with a written list of what changed**

---

## P07 — *The Slice*
**After Module 7 · 25–35 hours · `projects/P07_Slice/`**

**Brief.** The complete front-to-back experience, once: splash → intro cinematic → animated main menu → Level 1 with dialogue → ending sequence → credits. No gaps, no placeholder screens, no "press F5 to skip to the level".

**Done when**
- [ ] Premise, theme, logline, character arc and three-beat outline written in `../docs/GameDesignDocument.md`
- [ ] Skippable logo splash animated in Godot
- [ ] Intro cinematic — camera moves, timing, and at least one story beat delivered without dialogue
- [ ] Main menu is an animated 3D scene, not a static image
- [ ] Dialogue system is data-driven; a designer could add a conversation without touching code
- [ ] At least one branching conversation with a consequence
- [ ] Scene transitions load in a thread; no frozen frames
- [ ] Ending sequence with proper pacing
- [ ] Credits roll generated from `../docs/reference/AssetLicenses.md` — every asset properly attributed
- [ ] 🔊 ⭐ **Narration system** — cue-driven VO, synced subtitles, automatic ducking, and a skip that doesn't break state *(7.11)*
- [ ] 🎬 **Narrated cold open** — the opening earns attention before it spends any *(7.18)*
- [ ] 🚶 ⭐ **Guided walkthrough** — the first five minutes taught with narration, camera and level, not a text wall *(7.19)*
- [ ] 🏁 **Narrated ending** with proper pacing, into credits over an end-credits theme *(7.21–7.22)*
- [ ] 🎵 The main menu has **its own theme**, distinct from gameplay music *(7.17)*
- [ ] Whole flow played end-to-end on the phone by someone who is not you, without you speaking

---

## P08 — *Warden*
**After Module 8 · 40–60 hours · `assets-staging/warden/`**

**Brief.** Your own character, made only by you, from concept to in-game: sculpted, retopologised, UV'd, baked, textured, rigged, weighted, animated, exported, and driving the Module 3 controller.

**Constraints.** Under **20,000 triangles**. One 2048 texture set. Seven animations: idle, walk, run, jump, land, attack, hit-react, death (that's eight — the eighth is the one you'll be proudest of).

**This is the hardest project in the course.** It is also the one that changes how you see every game you play afterwards. Budget the time honestly and do not rush the retopology.

**Done when**
- [ ] Concept and reference board assembled before any modelling
- [ ] Sculpt has clear primary, secondary and tertiary forms
- [ ] Retopology done by hand, with deformation-ready edge loops at joints
- [ ] UVs packed with sensible seams and symmetry
- [ ] High-to-low bake is clean — no ray misses, no visible cage errors
- [ ] Textured with an ID-mask-driven material
- [ ] Rig has IK legs, IK/FK arms, custom bone shapes, and clean naming
- [ ] Weights hand-corrected — no candy-wrapper twists at shoulders, wrists or hips
- [ ] All eight animations hand-keyed (Mixamo may be reference, not the deliverable)
- [ ] Exported and running in the P03 controller, on the phone
- [ ] Under 20k triangles, measured
- [ ] 🔊 **Vocal identity** — barks, efforts and grunts recorded and processed by you; the Warden sounds like a specific creature *(8.2)*
- [ ] 🎬 The title screen character is now **yours**

---

## P09 — *Systems Refactor*
**After Module 9 · 20–30 hours · applied across all projects**

**Brief.** Take everything you've written and refactor it into a codebase you'd be comfortable handing to a colleague. This is where hobby code becomes professional code.

**Done when**
- [ ] Zero per-frame heap allocations in the hot path, verified with a profiler
- [ ] Gameplay data lives in custom `Resource` classes, editable in the inspector
- [ ] Systems communicate via signals/events, not by reaching through the tree with `GetNode("../../..")`
- [ ] Save system is versioned and migrates an old save file successfully
- [ ] Settings screen has three real graphics tiers, auto-detected on first launch
- [ ] Unit tests cover the save system, the dialogue parser and the state machine
- [ ] At least one `[Tool]` script that validates a level and reports problems in the editor
- [ ] A repeatable on-device performance test you can run after any change
- [ ] 📖 **Narrative content is data** — dialogue, narration cues and screen definitions are `Resource`s a writer could edit without touching code *(9.5)*
- [ ] 🔊 Separate **music / SFX / narration** volume sliders, plus a **subtitle toggle** *(9.8)*

---

## P10 — *Ember Hollow* — the capstone
**After Module 10 · 60–120 hours · `projects/P10_EmberHollow/`**

**Brief.** The full game. Four levels, one boss, complete narrative arc, released publicly.

**Scope lock.** Four levels of ~6 minutes each. One enemy type with two variants. One boss with three phases. One core verb plus one traversal verb. No crafting, no inventory, no dialogue trees beyond what P07 built, no procedural generation. **Write this scope in the GDD and defend it.** The single most common cause of an unfinished game is a feature added in month four.

**Done when**
- [ ] Four levels, built, lit, populated, and playtested
- [ ] Enemy AI navigates, perceives, telegraphs and can be beaten fairly
- [ ] Boss has three distinct phases and a readable difficulty curve
- [ ] Full narrative flow from splash to credits
- [ ] Accessibility: text scaling, remappable controls, a difficulty option, colourblind-safe critical colours
- [ ] Playtested by **at least five people who are not you**, with notes recorded and acted on
- [ ] Holds target framerate on your lowest-spec test device
- [ ] APK/AAB signed with a release keystore (backed up in two places — losing it means you can never update the app)
- [ ] GitHub Actions builds a signed APK on every tagged release
- [ ] 🎬 **Trailer** — a 60-second script, narrated, with a deliberate opening shot *(10.18–10.19)*
- [ ] 🚶 **Player-facing walkthrough document** written — and every place it was hard to explain has been fixed in the design *(10.20)*
- [ ] Screenshots captured
- [ ] Published on itch.io with a real store page
- [ ] Uploaded to Play Console internal testing, with a privacy policy
- [ ] `../docs/reference/AssetLicenses.md` complete and matching the in-game credits

---

## Mini-Jams

Short, constrained, unscaffolded builds between modules. No tutorial, no help unless you're truly stuck. The point is to find out what you can actually do alone — which is the only measure that matters.

| # | After | Time | Constraint |
|---|---|---|---|
| **MJ1** | Module 1 | 3 h | A game whose only verb is *falling* |
| **MJ2** | Module 3 | 4 h | One room. The goal is a high ledge. No jumping. |
| **MJ3** | Module 5 | 3 h | A scene where nothing moves except shaders |
| **MJ4** | Module 7 | 4 h | Tell a complete story in 60 seconds with no words |

**Jam rules:** timebox it hard, ship something broken rather than nothing, and write three lines in `../docs/meta/Journal.md` afterwards about what you reached for first and what you had to look up. That list is your real skill map.
