---
title: "Glossary — Every Term the Course Uses"
document_id: GLOSS
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "First use of any new term in a chapter"
---

# 📖 Glossary.md

> First use of a term in a chapter is marked 📖 and links here. If you meet a word in this course that isn't below, that's a defect — tell me and it gets added.

---

## Godot & engine

**Node** — the atom of Godot. An object in the scene tree with a lifecycle and a place in a hierarchy.
**Scene** — a saved tree of nodes, instantiable many times. Godot's equivalent of a prefab.
**Scene tree** — the live hierarchy of all active nodes; also the object that runs the main loop.
**Resource** — reference-counted *data* that lives outside the tree and can be shared: meshes, materials, textures, and your own custom types.
**Autoload / singleton** — a node loaded once at startup and present in every scene. For services, not gameplay.
**Signal** — Godot's observer pattern. A node emits; listeners react. In C#, declared with `[Signal]`.
**Group** — a named tag on nodes, for finding or messaging many at once.
**`_Ready`** — called after the node and all its children have entered the tree.
**`_Process(delta)`** — once per rendered frame; `delta` varies with framerate.
**`_PhysicsProcess(delta)`** — at a fixed tick rate with constant `delta`. All physics goes here.
**`delta`** — seconds since the previous call. Multiply movement by it or your game runs at different speeds on different hardware.
**`PackedScene`** — a scene loaded as data, ready to `Instantiate()`.
**`res://`** — the project directory. **Read-only in an exported build.**
**`user://`** — writable per-user storage. On Android, the app's private internal data directory.
**`[Export]`** — exposes a C# property in the inspector and serialises it into the scene.
**`[Tool]`** — makes a script run in the editor as well as at runtime.
**Marshalling** — converting data across the C#↔engine boundary. Not free; matters in hot paths.

## 3D maths & space

**Transform3D** — position, rotation and scale combined; a basis plus an origin.
**Basis** — a 3×3 matrix holding rotation and scale. Its columns are the object's local X, Y, Z axes.
**Local vs global space** — relative to the parent, versus relative to the world.
**Y-up, right-handed, −Z forward** — Godot's 3D convention. A node's forward direction is `-Basis.Z`.
**Euler angles** — rotation as three angles. Intuitive; suffers gimbal lock.
**Gimbal lock** — when two rotation axes align and a degree of freedom is lost.
**Quaternion** — a four-component rotation representation. No gimbal lock; interpolates cleanly.
**Slerp** — spherical linear interpolation: smooth rotation between two orientations.
**Normal** — the direction a surface faces.
**Raycast** — a query asking what a line from A to B hits.

## Physics

**StaticBody3D** — doesn't move. Level geometry.
**RigidBody3D** — fully simulated. Never set its position directly; apply forces or impulses.
**CharacterBody3D** — script-driven mover with `MoveAndSlide`. For characters.
**AnimatableBody3D** — a static-natured body meant to be *moved* by script or animation. Moving platforms.
**Area3D** — a non-solid detection volume. Triggers, pickups, kill planes.
**Collision layer** — which layers a body *exists on*: "what I am".
**Collision mask** — which layers a body *scans*: "what I look for".
**Impulse** — an instantaneous change in momentum, applied once.
**Force** — applied continuously; must be re-applied each physics frame.
**Trimesh vs convex collision** — exact-but-static-only, versus approximate-but-usable-on-dynamic-bodies.

## Rendering

**Draw call** — one instruction to the GPU to draw something. Fewer is better.
**Batching** — merging objects that share a material into one draw call.
**Overdraw** — shading the same pixel more than once. Transparency's main cost.
**Tile-based rendering** — how mobile GPUs work: the screen is split into tiles processed in fast on-chip memory. Makes bandwidth, not raw compute, the usual bottleneck.
**Forward+ / Mobile / Compatibility** — Godot 4's three renderers. Mobile is the phone default; Compatibility targets pre-Vulkan hardware.
**PBR** — physically based rendering: materials described by albedo, metallic, roughness and normal.
**Albedo** — a surface's intrinsic colour with no lighting baked in.
**Roughness** — how scattered reflections are. Does most of the visual work.
**Metallic** — near-binary: is this raw metal or not.
**Normal map** — per-texel surface directions, faking detail the geometry doesn't have.
**Tangent space** — the local surface frame a normal map's directions are relative to; what lets it survive deformation.
**ORM** — occlusion/roughness/metallic packed into one texture's RGB channels.
**Lightmap** — precomputed lighting baked into a texture. The mobile answer to global illumination.
**UV2** — a second, non-overlapping UV set used for lightmaps.
**Global illumination (GI)** — indirect bounced light. `LightmapGI` (baked), `VoxelGI`, `SDFGI` (real-time, expensive).
**LOD** — level of detail: simpler meshes at distance.
**Occlusion culling** — not drawing what's hidden behind something else.
**MultiMesh** — many instances of one mesh in a single draw call. Grass, rubble, crowds.
**ETC2 / ASTC** — GPU texture compression formats for mobile.
**Mipmaps** — precomputed smaller versions of a texture, reducing shimmer and bandwidth.
**Fresnel** — surfaces reflect more at glancing angles. The basis of rim light, force fields and water edges.
**Shader compilation stutter** — the frame hitch when a shader is compiled on first use.

## Shaders & VFX

**GDShader** — Godot's shading language.
**Vertex shader** — runs per vertex; can move geometry.
**Fragment shader** — runs per pixel; decides colour.
**Uniform** — a shader parameter you can set from code.
**Varying** — a value passed from the vertex stage to the fragment stage.
**Triplanar mapping** — projecting a texture from three axes, so no UVs are needed.
**Flipbook** — an animation stored as a grid of frames on one texture sheet.
**Decal** — a texture projected onto existing geometry. Bullet holes, scorch marks.
**Sub-emitter** — a particle system spawned by another system's particles.
**Billboard** — a quad that always faces the camera.

## Blender & art pipeline

**Data-block** — Blender's shareable data unit. An *object* is a transform pointing at one.
**Linked duplicate (`Alt+D`)** — a new object sharing the original's mesh data. The basis of modular kits.
**Modifier stack** — non-destructive operations applied in order.
**Topology** — how a mesh's faces are arranged. Critical where it deforms; largely irrelevant where it doesn't.
**Edge loop** — a continuous ring of edges. Placed at joints so a character bends properly.
**Pole** — a vertex where a number of edges other than four meet. Causes shading artefacts on smooth surfaces.
**N-gon** — a face with more than four sides.
**Retopology** — rebuilding a clean, low-poly mesh over a sculpt.
**UV unwrapping** — flattening a 3D surface into 2D texture space.
**Seam** — where the flattening is allowed to cut.
**Texel density** — texture pixels per metre of surface. Consistency across a kit is what makes it look professional.
**Atlas** — many objects' UVs packed into one texture.
**Trim sheet** — a texture of reusable detail strips, applied across many different models.
**Baking** — computing detail from a high-poly mesh into textures for a low-poly one.
**Cage** — an inflated copy of the low-poly defining where bake rays start.
**Ray distance** — how far bake rays search. The most common source of bake errors.
**ID mask** — a flat-colour map used to select material regions.
**Armature** — Blender's skeleton object.
**Bone roll** — a bone's rotation about its own axis. Getting it wrong makes animation miserable.
**FK / IK** — forward kinematics (rotate each joint) versus inverse (place the end, solve the chain).
**Pole target** — the object that decides which way an IK joint bends.
**Weight painting** — assigning how strongly each vertex follows each bone.
**Candy-wrapper twist** — the pinch at a wrist or shoulder from bad weights.
**Shape key** — a stored alternate vertex position. Facial expressions.
**NLA** — Blender's non-linear animation editor; how multiple clips are organised for export.
**Root motion** — movement authored into the animation rather than into code.
**Retargeting** — mapping one skeleton's animation onto another's.
**glTF / `.glb`** — the open transfer format this course uses exclusively.

## Game design & production

**Vertical slice** — a small piece of the game at full final quality. Used to re-estimate everything.
**Greybox / blockout** — a level built from untextured primitives to test layout before art.
**Critical path** — the route through a level nearly every player takes.
**Affordance** — a visual cue that shows what a thing can do without telling you.
**Gating** — preventing progress until a condition is met.
**Game feel / juice** — the tactile response layer: shake, hitstop, tweens, audio.
**Hitstop** — a few frames of frozen time on impact. Reads as power.
**Coyote time** — a brief grace period after leaving a ledge in which a jump still works.
**Jump buffering** — accepting a jump pressed slightly before landing.
**i-frames** — invincibility frames during a dodge or after a hit.
**Telegraph** — the wind-up that makes an attack readable and therefore fair.
**Ludonarrative dissonance** — when what the game *says* and what it *makes you do* contradict each other.
**Logline** — the whole story in one sentence.
**Beat** — one unit of story or pacing change.
**Stinger** — a short musical phrase marking an event.
**Adaptive music** — music that responds to game state, usually by layering.
**Scope** — how much game you have committed to making. The thing that kills projects.
**GDD** — game design document.
**First-page animation** — the animated title/opening screen. Built four times in this course, at increasing sophistication.
**End-page animation** — the results, completion or ending screen. A game that stops dead feels broken.
**Cold open** — starting in the middle of something, before any title card. Earns attention before spending it.
**Attract mode** — what a game shows when nobody is playing it.
**Narration** — spoken voice-over addressed to the player, distinct from character dialogue.
**Bark** — a short, situational character vocalisation: a grunt, a warning shout, an effort sound.
**Ducking** — automatically lowering one audio bus (music) while another (voice) is playing, usually via side-chain compression.
**Side-chain** — driving one audio effect from a different signal, e.g. compressing music using the narration track as the trigger.
**Proximity effect** — the bass boost you get from speaking close to a directional microphone. The main reason home recordings sound muddy.
**Plosive** — the burst of air on a "p" or "b" that overloads a microphone. Fixed with distance, angle, or a pop filter.
**Noise floor** — the constant background hiss of a recording. Low is good; noise reduction cannot rescue a bad one.
**Stinger** — a short musical phrase marking an event.
**Loop point** — the sample position where a music track wraps. A badly chosen one produces an audible click or a lurch.
**Walkthrough** — in this course, two things: the *designed* walkthrough (a level that teaches without prompts) and the *written* walkthrough (a player-facing guide, chapter 10.20).
**Onboarding** — the first five minutes, in which the player learns what the game is and whether they want to continue.
**Caption vs subtitle** — subtitles transcribe speech; captions also convey non-speech audio ("[distant machinery]"). Ship captions.

## Android & shipping

**APK / AAB** — the installable package, versus the Play-Store upload format.
**Keystore** — the certificate that signs your app. **Lose the release one and the listing can never be updated.**
**`adb`** — Android Debug Bridge: the tool that installs, logs and inspects.
**`logcat`** — Android's system log. Where your device-side crashes and prints appear.
**Safe area** — the part of the screen not covered by a notch, status bar or gesture area.
**dp** — density-independent pixel. Touch targets should be at least 48×48 dp.
**Target SDK** — the Android API level your app declares. Play has minimum requirements that rise annually.
**Internal testing track** — a Play Console channel for distributing to a small list of testers.
