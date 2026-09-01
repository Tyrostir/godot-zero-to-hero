---
title: "Table of Contents — the full course index"
document_id: TOC
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "Whenever a chapter, project or exercise is added, renamed or renumbered"
---

# Table of Contents

Legend: **[A]** Godot/C# chapter · **[B]** Blender chapter · **[P]** Project milestone · **[X]** Exercise set · **[J]** Mini-jam · **[Q]** Check-yourself questions

Every chapter ends with `[X]` and `[Q]`; they are only listed separately below where they are substantial enough to stand alone.

---

## Module 0 — Toolchain & Your First APK
*Goal: a build of your own running on your phone before you understand any of it.*

- **0.1 [A]** Machines and their roles — desktop as workshop, phone as target, Termux as notebook
- **0.2 [A]** Installing Godot 4 (.NET build) and the .NET SDK
- **0.3 [A]** Installing Blender, and configuring it once so you never fight it again
- **0.4 [A]** JDK, Android SDK, platform tools, and the debug keystore
- **0.5 [A]** Connecting your phone: USB debugging, `adb devices`, wireless debugging
- **0.6 [A]** The Godot editor: docks, viewport, inspector, the node tree, the output panel
- **0.7 [A]** Git for game projects: the Godot `.gitignore`, what Git LFS is for, first commit
- **0.8 [P] Project 00 — "Hello Phone"** — a spinning cube, one C# script, exported and installed on your device
- **0.9 [A]** Reading errors: the Godot output panel, the debugger, and `adb logcat`
- **0.10 [Q]** Module 0 self-check

---

## Module 1 — Godot Foundations
### Project 01 — *Marble Runner*
*Goal: a complete, small, finished 3D game. Everything in Module 1 is a feature of it.*

**1A — The engine's model of the world**
- **1.1 [A]** Nodes: the one idea Godot is built on
- **1.2 [A]** Scenes, instancing, and scene inheritance — Godot's answer to prefabs
- **1.3 [A]** The scene tree, the main loop, and the order things happen in
- **1.4 [A]** Your first real C# script: `_Ready`, `_Process`, `_PhysicsProcess`, and what `delta` actually is
- **1.5 [A]** `[Export]`, the inspector, and why designers should never edit code
- **1.6 [A]** Nodes vs Resources — the distinction that confuses everyone once

**1B — Space and motion**
- **1.7 [A]** 3D space in Godot: right-handed, Y-up, −Z forward, and the mistakes that follow
- **1.8 [A]** `Transform3D`, `Basis`, position/rotation/scale, local vs global
- **1.9 [A]** Rotations: Euler angles, gimbal lock, quaternions, `LookAt`, `Basis.Slerp`
- **1.10 [X]** Drill: move, orbit, and align objects three different ways

**1C — Physics**
- **1.11 [A]** The four body types: `StaticBody3D`, `RigidBody3D`, `CharacterBody3D`, `Area3D`
- **1.12 [A]** Collision shapes, layers, masks — and how to think about layer design
- **1.13 [A]** Making the marble roll: forces, impulses, torque, damping, physics materials
- **1.14 [A]** `Area3D` triggers: collectibles, kill volumes, checkpoints
- **1.15 [A]** Raycasts: `RayCast3D` node vs `PhysicsDirectSpaceState3D` queries

**1D — Input, on a phone**
- **1.16 [A]** The InputMap: never hard-code a key
- **1.17 [A]** Polling vs events: `Input.IsActionPressed` vs `_UnhandledInput`
- **1.18 [A]** Touch: `InputEventScreenTouch`, `InputEventScreenDrag`, multi-touch
- **1.19 [A]** Building an on-screen virtual joystick as a reusable scene
- **1.20 [A]** Accelerometer and gyroscope tilt controls, and their dead-zone problem
- **1.21 [X]** Drill: three control schemes for the same marble, switchable at runtime

**1E — Camera**
- **1.22 [A]** `Camera3D`: FOV, near/far, projection, and what FOV does on a small screen
- **1.23 [A]** Follow cameras: lerp, damping, look-ahead
- **1.24 [A]** `SpringArm3D` — collision-aware third-person cameras for free

**1F — Talking between objects**
- **1.25 [A]** Signals in C#: connecting, emitting, custom signals, `[Signal]` delegates
- **1.26 [A]** Groups, `CallDeferred`, and node lookup patterns that survive refactors
- **1.27 [A]** Autoloads (singletons): the right and wrong things to put in them

**1G — Interface**
- **1.28 [A]** `Control` nodes, containers, anchors, and the layout system
- **1.29 [A]** Resolution independence, aspect ratios, and the Android **safe area** (notches!)
- **1.30 [A]** Themes: styling once, applying everywhere
- **1.31 [A]** A HUD: timer, collectible counter, pause menu

**1H — Beyond one scene**
- **1.32 [A]** Changing scenes, preloading, and a loading screen that isn't a lie
- **1.33 [A]** Saving to `user://`: JSON, `FileAccess`, and where that file lives on Android
- **1.34 [A]** Level select, best times, and persistent state

- **1.35 [P] Project 01 ship** — Marble Runner v1.0 on your phone, 3 levels, times saved
- **1.36 [J] Mini-Jam 1** — 3 hours: a game whose only verb is *falling*
- **1.37 [Q]** Module 1 self-check (28 questions)

---

## Module 2 — Blender I: Props & the Asset Pipeline
### Project 02 — *Foundry Kit*
*Goal: a 14-piece modular art kit, made by you, running in your Godot game.*

**2A — Getting fluent**
- **B1 [B]** Interface, navigation, and the preferences you should change on day one
- **B2 [B]** Objects vs meshes, object mode vs edit mode, the data-block model
- **B3 [B]** Units, scale, and matching Blender's world to Godot's 1 unit = 1 metre
- **B4 [B]** Transform, snapping, pivots, the 3D cursor, and orientation systems
- **X2.1 [X]** Speed drill: build 5 primitives to exact dimensions, blindfolded to the menus

**2B — Modelling**
- **B5 [B]** Box modelling: extrude, inset, loop cut, bevel, knife — building a crate
- **B6 [B]** Modifiers: Mirror, Array, Solidify, Bevel, Subdivision, Boolean — and the modifier stack as a concept
- **B7 [B]** Topology: quads, poles, edge flow, and *when it genuinely doesn't matter*
- **B8 [B]** Hard-surface techniques: booleans done cleanly, support loops, shading artefacts
- **B9 [B]** Poly budgets: what a mobile scene can actually afford, and how to measure yours
- **X2.2 [X]** Model a barrel, a lamp post, a girder and a stair module to spec

**2C — Surfacing**
- **B10 [B]** UV unwrapping: seams, projection, islands, and how to read a UV checker
- **B11 [B]** Texel density: the number that makes a kit look consistent
- **B12 [B]** Atlasing and trim sheets — the technique that makes mobile kits cheap
- **B13 [B]** PBR theory: albedo, metallic, roughness, normal, AO, and what each map physically means
- **B14 [B]** The Principled BSDF, and the shader editor as a node graph
- **B15 [B]** Texturing without paid software: Blender texture paint, Material Maker, Krita, ambientCG
- **B16 [B]** Baking: high-poly → low-poly normal maps, AO, curvature, ID masks

**2D — Getting it into the game**
- **B17 [B]** Export formats: why glTF 2.0 and not FBX/OBJ
- **B18 [B]** Blender→Godot naming conventions: `-col`, `-convcol`, `-noimp`, empties as markers
- **B19 [B]** Godot's import dock, import presets, and re-import without losing your work
- **2.20 [A]** Materials in Godot: `StandardMaterial3D`, overrides, and shared material discipline
- **2.21 [A]** `MeshLibrary` and `GridMap`: turning your kit into a level-building tool

- **2.22 [P] Project 02 ship** — the Foundry Kit, in-engine, replacing Marble Runner's grey boxes
- **2.23 [Q]** Module 2 self-check

---

## Module 3 — Characters I: Rig & Animate
### Project 03 — *Third-Person Playground*
*Goal: a character that walks, runs, jumps and lands convincingly, driven by a real state machine.*

**3A — Blender: rigging**
- **B20 [B]** Character anatomy for games: silhouette, proportion, and the T-pose vs A-pose argument
- **B21 [B]** Armatures: bones, roll, parenting, the bone hierarchy of a biped
- **B22 [B]** FK vs IK, pole targets, constraints, and building a usable leg
- **B23 [B]** Skinning: automatic weights, then fixing them by hand in weight paint
- **B24 [B]** Rig hygiene: naming, symmetry, layers, custom bone shapes, and why it matters at export

**3B — Blender: animation**
- **B25 [B]** Keyframes, the dope sheet, the graph editor, interpolation and easing
- **B26 [B]** The animation principles that actually apply to a run cycle
- **B27 [B]** Building an idle, a walk and a run, in place
- **B28 [B]** Actions, the NLA editor, and exporting multiple clips in one glTF
- **B29 [B]** Mixamo: free rigs and animations, and how to retarget them onto your skeleton
- **B30 [B]** Root motion vs in-place: what each costs you in engine

**3C — Godot: playback**
- **3.1 [A]** `Skeleton3D`, `BoneAttachment3D`, and reading an imported character
- **3.2 [A]** `AnimationPlayer`: tracks, method-call tracks, and animation-driven gameplay
- **3.3 [A]** `AnimationTree` and `AnimationNodeStateMachine`
- **3.4 [A]** `BlendSpace1D`/`BlendSpace2D` for locomotion blending
- **3.5 [A]** Root motion in Godot, and `AnimationTree.GetRootMotionPosition`

**3D — Godot: control**
- **3.6 [A]** `CharacterBody3D`: `MoveAndSlide`, floor detection, slopes, snapping
- **3.7 [A]** A finite state machine in C#, done properly (interfaces, not `switch` soup)
- **3.8 [A]** Coyote time, jump buffering, variable jump height — the invisible feel work
- **3.9 [A]** Camera-relative movement, and turning the character toward motion
- **3.10 [X]** Add a dodge-roll state with i-frames, from scratch

- **3.11 [P] Project 03 ship** — playground with slopes, stairs, gaps, ledges; character handles all
- **3.12 [J] Mini-Jam 2** — 4 hours: a one-room game about reaching a high ledge
- **3.13 [Q]** Module 3 self-check

---

## Module 4 — Worlds, Lighting & Mobile Performance
### Project 04 — *Hollow, Level 1*
*Goal: a real level, lit, that holds 60fps on your actual phone.*

**4A — Design**
- **4.1 [A]** Level design theory: the critical path, landmarks, affordance, gating, pacing
- **4.2 [A]** Sketching a level on paper, then greyboxing it with CSG nodes
- **4.3 [A]** Metrics: deriving jump distance, step height and door width from your character
- **4.4 [A]** Replacing greybox with the Foundry Kit via `GridMap`
- **4.5 [X]** Design and greybox a second level to a written brief

**4B — Light**
- **4.6 [A]** How real-time lighting works, in one page
- **4.7 [A]** `DirectionalLight3D`, `OmniLight3D`, `SpotLight3D`; shadow maps, bias, and peter-panning
- **4.8 [A]** Global illumination options: `LightmapGI`, `VoxelGI`, `SDFGI` — cost, quality, and why mobile means **baked**
- **4.9 [A]** Baking lightmaps: UV2, lightmap size, bake settings, common bake artefacts
- **4.10 [A]** `ReflectionProbe`, and fake reflections that cost nothing
- **4.11 [A]** `WorldEnvironment`: sky, ambient, fog, tonemapping, glow, SSAO — priced individually for mobile

**4C — Speed**
- **4.12 [A]** The mobile GPU in your pocket: tile-based rendering, bandwidth, overdraw, thermal throttling
- **4.13 [A]** Forward+ vs Mobile vs Compatibility renderers — choosing, and the consequences
- **4.14 [A]** Texture compression: ETC2, ASTC, mipmaps, and import settings that matter
- **4.15 [A]** Draw calls, batching, `MultiMeshInstance3D` for grass and rubble
- **4.16 [A]** LOD, visibility ranges, and `OccluderInstance3D`
- **4.17 [A]** Profiling on the device: the remote debugger, monitors, frame time budgets
- **4.18 [X]** Optimisation drill: take a 22fps scene to 60fps and document every change

- **4.19 [P] Project 04 ship** — Level 1, art-passed and lit, 60fps measured on device
- **4.20 [Q]** Module 4 self-check

---

## Module 5 — Shaders & VFX
### Project 05 — *VFX Lab*
*Goal: a scene of effects you wrote, all of which are cheap enough to ship.*

**5A — Shaders**
- **5.1 [A]** What a shader is, where it runs, and the pipeline in one diagram
- **5.2 [A]** GDShader syntax: `shader_type spatial`, `vertex()`, `fragment()`, built-ins, varyings
- **5.3 [A]** Uniforms, and driving them from C# with `SetShaderParameter`
- **5.4 [A]** Shader 1 — **dissolve** (noise, step, emission edge)
- **5.5 [A]** Shader 2 — **force field** (fresnel, scrolling UV, depth intersection)
- **5.6 [A]** Shader 3 — **stylised water** (vertex displacement, normal scroll, foam by depth)
- **5.7 [A]** Shader 4 — **wind-swayed foliage** (vertex animation, per-instance variation)
- **5.8 [A]** Shader 5 — **toon ramp + rim light**, and a `screen_texture` outline
- **5.9 [A]** Shader 6 — **triplanar** projection for cliffs with no UVs
- **5.10 [A]** Visual shaders, and when the node editor beats text
- **5.11 [A]** Shader cost on mobile: texture reads, branching, transparency, overdraw
- **5.12 [A]** Shader compilation stutter, and prewarming your materials

**5B — Particles & effects**
- **5.13 [A]** `GPUParticles3D` vs `CPUParticles3D` on Android
- **5.14 [A]** `ParticleProcessMaterial` in depth: emission shapes, curves, attractors, collision
- **5.15 [A]** Sub-emitters, trails, and ribbon effects
- **5.16 [B]** Blender: smoke and fire simulation, baked to a **flipbook sprite sheet**
- **5.17 [B]** Blender: a cloth simulation baked to a mesh animation
- **5.18 [A]** Flipbook materials in Godot, and `billboard` modes
- **5.19 [A]** Decals: bullet holes, scorch marks, projected detail
- **5.20 [A]** Full-screen post effects on a `CanvasLayer` — vignette, damage flash, colour grade
- **5.21 [X]** Author an impact effect: particles + decal + shader + screen effect, under 0.5ms

- **5.22 [P] Project 05 ship** — VFX Lab, plus impact FX wired into the Playground
- **5.23 [Q]** Module 5 self-check

---

## Module 6 — Audio & Game Feel
### Project 06 — *Feel Pass*
*Goal: the same level from Module 4, transformed by sound and response.*

- **6.1 [A]** Godot audio: `AudioStreamPlayer`, `2D`, `3D`; attenuation, doppler, reverb areas
- **6.2 [A]** Audio buses, effects, ducking, and a master mix that respects phone speakers
- **6.3 [A]** Sourcing free audio legally: Freesound, Sonniss GDC bundles, Kenney, Pixabay, OpenGameArt
- **6.4 [A]** Editing SFX in Audacity: trim, normalise, fade, pitch variation, loop points
- **6.5 [A]** Footsteps that respond to surface material
- **6.6 [A]** Adaptive music: loops, stingers, and layered intensity
- **6.7 [A]** Game feel I — tweens, easing curves, anticipation and follow-through in UI
- **6.8 [A]** Game feel II — screenshake with a noise function (not random jitter), camera kick, hitstop
- **6.9 [A]** Haptics on Android: `Input.VibrateHandheld`, and restraint
- **6.10 [X]** A/B drill: record the level before and after the feel pass; write down what changed and why
- **6.11 [P] Project 06 ship** · **6.12 [Q]** Module 6 self-check

---

## Module 7 — Story, Narrative & Cinematics
### Project 07 — *The Slice*
*Goal: intro cinematic → main menu → level → dialogue → ending → credits, as one unbroken flow.*

**7A — Writing it**
- **7.1 [A]** Premise, theme, and logline — three sentences that constrain every later decision
- **7.2 [A]** Character: want vs need, the arc, and why your player character can be quiet
- **7.3 [A]** Structure for games: beats, gates, and why three-act structure needs adapting
- **7.4 [A]** Environmental storytelling: telling the story with the level, not with text
- **7.5 [A]** Ludonarrative harmony — making the verbs mean the theme
- **7.6 [A]** Writing the Game Design Document and the narrative bible
- **7.7 [X]** Write *Ember Hollow*'s premise, theme, logline, arc and three-beat outline

**7B — Systems for narrative**
- **7.8 [A]** A dialogue system in C#: data-driven with custom `Resource`s, branching, conditions
- **7.9 [A]** Typewriter text, portraits, speaker names, skip and auto-advance
- **7.10 [A]** Flags, quest state, and a tiny event bus
- **7.11 [A]** Localisation: CSV translations, `tr()`, font fallbacks, and text expansion

**7C — Cinematics**
- **7.12 [A]** Cutscene architecture: an `AnimationPlayer` timeline as the director
- **7.13 [A]** Camera language: shot types, cuts, the 180° rule, `Path3D` dollies, depth of field
- **7.14 [A]** The **splash/intro animation** — logo sting, built in Godot, skippable
- **7.15 [A]** The **main menu animation** — an animated 3D menu scene, parallax, idle motion
- **7.16 [A]** The **first-play opening** — cold open, title card, hand-off to gameplay
- **7.17 [A]** Loading screens, scene transitions, and threaded loading
- **7.18 [A]** The **ending sequence** — payoff, fade, and pacing an outro
- **7.19 [A]** A **credits roll** generated automatically from `reference/AssetLicenses.md`
- **7.20 [B]** Blender for cinematics: camera rigs, Cycles vs EEVEE, rendering a pre-rendered cutscene
- **7.21 [B]** Blender compositing: the node editor, glare, colour grade, and rendering a trailer

- **7.22 [P] Project 07 ship** — the full slice, played end-to-end on device
- **7.23 [Q]** Module 7 self-check

---

## Module 8 — Characters II: Build Your Own
### Project 08 — *Warden*
*Goal: a game-ready character that exists only because you made it.*

- **B31 [B]** Concept, reference boards, and blocking out proportions
- **B32 [B]** Sculpting: dynamic topology, multires, the brush set that matters
- **B33 [B]** Sculpting the Warden: forms, secondary shapes, surface detail
- **B34 [B]** Retopology by hand: the poly-build workflow and a mobile-safe budget
- **B35 [B]** UVs for characters: seam placement, symmetry, and packing
- **B36 [B]** High-to-low baking: cages, ray distance, and fixing bake errors
- **B37 [B]** Texturing: hand-painted + procedural, an ID-mask-driven material
- **B38 [B]** Hair, cloth and accessories on a mobile budget
- **B39 [B]** A production rig: IK legs, IK/FK arms, spine controls, custom shapes
- **B40 [B]** Facial rigging basics: shape keys and drivers
- **B41 [B]** Animating the full set: idle, walk, run, jump, attack, hit, death
- **B42 [B]** Export, and retargeting onto the Module 3 controller
- **8.1 [A]** In-engine setup: materials, LODs, attachment points, ragdoll basics
- **8.2 [P] Project 08 ship** · **8.3 [Q]** Module 8 self-check

---

## Module 9 — Architecture, Performance & Tooling
### Project 09 — *Systems Refactor*

- **9.1 [A]** C# in Godot: the marshalling boundary, and what crossing it costs
- **9.2 [A]** Garbage collection on mobile: allocations per frame, `struct` vs `class`, spans, pooling
- **9.3 [A]** Composition over inheritance in a node tree: component nodes done right
- **9.4 [A]** Data-driven design with custom `Resource` classes, and an inspector that designers can use
- **9.5 [A]** An event bus, and when a signal is better than a reference
- **9.6 [A]** A versioned save system with migration, and where saves live on Android
- **9.7 [A]** A settings screen with real graphics tiers, auto-detected from device capability
- **9.8 [A]** Unit testing game logic: pure C# tests, and GdUnit4 for scene-level tests
- **9.9 [A]** Editor tooling: `[Tool]` scripts, custom docks, and a level-validation button
- **9.10 [A]** Profiling on device, `adb logcat`, and building a repeatable performance test
- **9.11 [P] Project 09 ship** · **9.12 [Q]** Module 9 self-check

---

## Module 10 — Capstone & Release
### Project 10 — *Ember Hollow*

**10A — Production**
- **10.1 [A]** Pre-production: scope, the one-page pitch, and the feature guillotine
- **10.2 [A]** The vertical slice, and using it to re-estimate everything
- **10.3 [A]** A production schedule and a task board you'll actually maintain
- **10.4 [A]** Asset lists, naming, and a content pipeline that survives four levels

**10B — Content**
- **10.5 [A]** Enemy AI: `NavigationAgent3D`, navmesh baking, avoidance
- **10.6 [A]** Behaviour: state machines, perception, and readable telegraphed attacks
- **10.7 [A]** Combat: hitboxes, damage, i-frames, knockback, death
- **10.8 [A]** The boss: phases, arena design, and difficulty tuning
- **10.9 [A]** Levels 2, 3 and 4 — build, light, populate
- **10.10 [A]** Progression, pickups, and the economy of a short game

**10C — Polish & release**
- **10.11 [A]** Playtesting: recruiting, protocol, what to record, what to ignore
- **10.12 [A]** The polish pass checklist, applied top to bottom
- **10.13 [A]** Accessibility: text size, colourblind safety, remappable controls, difficulty options
- **10.14 [A]** Android export in depth: keystores, AAB vs APK, target SDK, permissions
- **10.15 [A]** Icons, adaptive icons, splash screen, app name, versioning
- **10.16 [A]** App size: what's in your PCK, and how to shrink it
- **10.17 [A]** CI: a GitHub Actions workflow that builds a signed APK on every tag
- **10.18 [A]** Capturing a trailer and screenshots (Godot + Blender compositing)
- **10.19 [A]** itch.io release; Play Console internal testing; store listing; privacy policy
- **10.20 [A]** Post-launch: crash reports, patching, and reading feedback without being destroyed by it
- **10.21 [P] Project 10 ship** — *Ember Hollow* released
- **10.22 [Q]** Module 10 self-check

---

## Module 11 — Beyond (optional)

- **11.1 [A]** Multiplayer: the high-level multiplayer API, authority, and why mobile makes it hard
- **11.2 [A]** Procedural generation: rooms, mazes, and seeded randomness
- **11.3 [B]** Geometry Nodes at depth: scatter systems, procedural props, exporting the result
- **11.4 [A]** GDExtension and native code, when C# isn't enough
- **11.5 [A]** Porting: desktop, web, and what changes
- **11.6 [A]** Turning the codebase into a reusable template for your next game

---

## Appendices

- **A1** [docs/guides/](guides/) — installation, in five ordered guides, plus the version log
- **A2** [reference/ResourcesMeta.md](reference/ResourcesMeta.md) — free asset, audio, VFX and tool directory
- **A3** [reference/AssetLicenses.md](reference/AssetLicenses.md) — your attribution ledger
- **A4** [reference/Conventions.md](reference/Conventions.md) — code, naming, folders, git
- **A5** [reference/Glossary.md](reference/Glossary.md) — terminology
- **A6** [reference/Troubleshooting.md](reference/Troubleshooting.md) — known errors and fixes
- **A7** [reference/cheatsheets/](reference/cheatsheets/) — Blender keys, GDShader, Godot C# API, adb
- **A8** [reference/QuestionBank.md](reference/QuestionBank.md) — all self-check questions · answers in [reference/answers/](reference/answers/)
