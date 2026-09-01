---
title: "The Blender Track — B1 to B42"
document_id: BLENDER
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When a Blender chapter is added or resequenced"
---

# The Blender Track

A complete Blender curriculum — **42 chapters, B1 to B42** — covering modelling, sculpting, retopology, UV, texturing, shading, baking, rigging, animation, simulation, rendering, compositing and geometry nodes.

It is not a separate course. Every chapter exists because the game needs the asset it produces, and every asset made here ends up in a build on your phone. That's the whole design: you never learn a Blender feature in the abstract, you learn it because Level 1 needs a lamp post.

**Where each chapter sits in the course:** see [TableOfContents.md](TableOfContents.md).

---

## Track overview

| Block | Chapters | Module | Produces |
|---|---|---|---|
| Fluency | B1–B4 | 2 | Muscle memory |
| Modelling | B5–B9 | 2 | The Foundry Kit's shapes |
| Surfacing | B10–B16 | 2 | The Foundry Kit's textures |
| Pipeline | B17–B19 | 2 | Assets actually inside Godot |
| Rigging | B20–B24 | 3 | A working biped rig |
| Animation | B25–B30 | 3 | A locomotion set |
| Simulation & VFX | B-VFX (5.16–5.17) | 5 | Flipbook smoke, fire, cloth |
| Cinematic | B-CIN (7.20–7.21) | 7 | Rendered cutscene + trailer |
| Character (full) | B31–B42 | 8 | The Warden |
| Procedural | B-GN (11.3) | 11 | Scatter systems |

---

## Block 1 — Fluency (B1–B4) · Module 2

You cannot learn modelling while also fighting the interface. This block exists to make navigation automatic so that later chapters can be about *shapes* rather than about *where the button is*.

**B1 — Interface, navigation, and day-one preferences.**
The editor layout, workspaces, areas and editor types. Orbit, pan, zoom, numpad views, and the local-view key (`/`) that will save you a thousand times. The header/sidebar/properties triangle. The preferences from [Setup 03 §1](guides/Setup_03_Blender.md) and *why* each one.
*Exercise:* navigate to six named views in under 20 seconds without touching a menu.

**B2 — Objects vs meshes; the data-block model.**
Blender's deepest idea and the source of most beginner confusion: an *object* is a transform that points at *data*. Two objects can share one mesh. Linked duplicates (`Alt+D`) vs real duplicates (`Shift+D`). Why this matters enormously for a modular kit.
*Exercise:* build a wall of 20 linked copies, edit one, watch all 20 change. Then make one independent.

**B3 — Units, scale, and matching Godot.**
Scene units, unit scale, and the rule that **1 Blender metre = 1 Godot unit**. `Ctrl+A` Apply Transforms, and why an unapplied scale ruins normals, bevels, physics and rigging. Object origins and where to put them for modular pieces.
*Exercise:* model a 2×2×3 m doorway to exact dimensions, origin at the floor centre, transforms applied.

**B4 — Transform systems, snapping, pivots, the 3D cursor.**
`G`/`R`/`S` with axis constraints. Transform orientations (global, local, normal, view). Pivot points. Snapping (vertex, edge, face, grid, increment) and why grid snapping is the backbone of modular kits. The 3D cursor as a movable origin.
*Exercise:* assemble 8 kit pieces into a corridor using nothing but grid snap. Zero gaps at any zoom.

---

## Block 2 — Modelling (B5–B9) · Module 2

**B5 — Box modelling.**
Vertex/edge/face modes. Extrude, inset, loop cut, bevel, knife, bridge, merge, and the difference between deleting and dissolving. Built live: a crate, from a cube to a finished prop.
*Exercise:* a barrel and a vent grate, from cubes only.

**B6 — Modifiers and the modifier stack.**
Non-destructive modelling as a way of thinking. Mirror (with clipping), Array (with offset objects), Solidify, Bevel (with weights and clamp), Subdivision Surface, Boolean, Weighted Normal. Stack order, and why it changes the result.
*Exercise:* a railing section that is one segment plus an Array; a symmetrical lamp post modelled on one side only.

**B7 — Topology: quads, poles, edge flow.**
What good topology actually is, why it matters *only sometimes*, and the honest rule: for static props, shading and UVs are all that matter; for deforming characters, edge flow is everything. N-gons, triangles, poles, and shading artefacts.
*Exercise:* diagnose and fix three broken-shading meshes provided as a puzzle.

**B8 — Hard-surface technique.**
Booleans done cleanly, support loops, bevel weights, custom normals, and the Weighted Normal modifier. Panel lines and mechanical detail without exploding your poly count.
*Exercise:* a girder with bolt detail, under 500 triangles.

**B9 — Poly budgets for mobile.**
What a phone can afford. Measuring triangles in the statistics overlay. Budget allocation across a scene. The Decimate modifier and why it is usually the wrong answer. Silhouette-first thinking: spend polygons only where they change the outline.
*Exercise:* halve the triangle count of your barrel with no visible change at gameplay distance.

---

## Block 3 — Surfacing (B10–B16) · Module 2

**B10 — UV unwrapping.**
What a UV map is. Seams, marking them, and where a seam should go (hidden edges, natural breaks, silhouette-safe). Unwrap, Smart UV Project, Follow Active Quads, Cube/Cylinder projection. Reading a checker texture: stretching, rotation, mirroring, seams.
*Exercise:* unwrap the crate, the barrel and the pipe elbow with no visible stretching.

**B11 — Texel density.**
The single number that makes a kit look coherent: texels per metre. Measuring it, setting it, and matching it across every piece. Why a kit with mixed density looks amateur even when every asset is individually good.
*Exercise:* audit all 14 kit pieces and correct every one to the same density.

**B12 — Atlasing and trim sheets.**
Packing many objects into one UV space. UDIMs (and why you won't use them for mobile). Trim sheets: one strip of textured detail reused across dozens of models. This is the technique that makes AAA-looking environments run on weak hardware.
*Exercise:* pack the whole Foundry Kit into one 2048 atlas with even density.

**B13 — PBR theory.**
What physically-based rendering means. Albedo (and why it must not contain lighting), metallic as a near-binary, roughness as the map that does most of the work, normal maps and tangent space, ambient occlusion, height. The mistakes: baked shadows in albedo, metallic used as "shiny", normal maps with wrong green channel.
*Exercise:* identify the errors in five deliberately wrong material setups.

**B14 — Shading: the Principled BSDF and the node editor.**
The shader editor as a node graph. Principled BSDF inputs, one at a time. Image Texture, Mapping, Texture Coordinate, ColorRamp, Mix, Bump vs Normal Map, Noise/Voronoi/Musgrave. Node Wrangler shortcuts. Procedural vs image-based, and where each belongs.
*Exercise:* build a procedural rusted-metal material with no image textures at all.

**B15 — Texturing without paid software.**
Blender's texture paint mode: brushes, stencils, masks, painting across UV seams. Material Maker for procedural PBR sets. Krita for hand-painted detail. ambientCG scans as a base. Channel packing roughness/metallic/AO into one RGB texture.
*Exercise:* texture the crate three ways — fully procedural, fully hand-painted, hybrid. Compare cost and look.

**B16 — Baking.**
The high-to-low workflow. Cages, ray distance, and what a "ray miss" looks like. Baking normal, AO, curvature and ID masks. Baking lighting to texture. Fixing bake artefacts. Why the game gets the low-poly and only the low-poly.
*Exercise:* sculpt damage into a high-poly crate, bake it onto the low-poly, prove the low-poly looks damaged.

---

## Block 4 — Pipeline (B17–B19) · Module 2

**B17 — Export formats.**
glTF 2.0 as the correct answer, and why: open, modern, handles PBR and skinning natively, and is Godot's best-supported path. Why not FBX (proprietary, ambiguous, scale chaos) and why not OBJ (no animation, no PBR). `.glb` vs `.gltf`+bin. Every checkbox in the glTF export panel, explained.

**B18 — Blender→Godot naming conventions.**
Godot reads suffixes on import: `-col` (trimesh collision), `-convcol` (convex), `-colonly`, `-noimp` (skip), `-rigid`, `-vehicle`, `-navmesh`. Empties as spawn markers and attachment points. Material naming so re-imports don't clobber your engine-side setup.
*Exercise:* export a crate that arrives in Godot already collidable, with an attachment point, and one helper object excluded.

**B19 — Godot's import dock.**
Import presets, per-file settings, `.import` files and what they are. Re-importing without losing engine work: the "inherited scene" pattern, and when to extract materials/meshes as separate resources. Automatic LOD generation. The advanced import dialog.
*Exercise:* set up a preset that imports every kit piece correctly with one click, then re-export a changed model and confirm nothing breaks.

---

## Block 5 — Rigging (B20–B24) · Module 3

**B20 — Character anatomy for games.**
Proportion, silhouette, and readability at phone-screen size. T-pose vs A-pose (and why A-pose deforms better at the shoulder). Where joints actually are, versus where beginners put them.

**B21 — Armatures.**
Bones: head, tail, roll. Edit/Pose/Object mode for armatures. Parenting and the bone hierarchy of a biped. Connected vs unconnected bones. Bone roll and why a wrong roll makes animation miserable.
*Exercise:* build a complete biped skeleton from scratch, correctly named and rolled.

**B22 — FK, IK and constraints.**
Forward vs inverse kinematics, and when each is right. IK constraints, chain length, pole targets and pole angle. Copy Rotation, Damped Track, Child Of. Building a leg with a proper foot roll.
*Exercise:* build an IK leg where the foot stays planted when the hips move.

**B23 — Skinning and weight painting.**
Automatic weights, and why they're a starting point rather than an answer. Weight paint mode: brushes, normalising, symmetry, the candy-wrapper twist and how to fix it. Vertex groups. Testing weights by posing to extremes.
*Exercise:* fix a deliberately broken shoulder deformation by hand.

**B24 — Rig hygiene.**
Naming conventions (`.L`/`.R` and why the exact syntax matters for symmetry). Bone collections/layers. Custom bone shapes. Deform vs control bones, and exporting only the deform hierarchy. Rigify as an option, and its export considerations.

---

## Block 6 — Animation (B25–B30) · Module 3

**B25 — Keyframes and the graph editor.**
Inserting keys, keying sets, auto-key. The dope sheet as timing, the graph editor as *feel*. Interpolation modes, handle types, and how to read an F-curve. Onion skinning.
*Exercise:* animate a bouncing ball until the curves look right, not just the motion.

**B26 — Animation principles that matter for games.**
Timing, spacing, anticipation, follow-through, overlap, arcs, weight. Which of the classic twelve apply to a loop and which don't. Why game animation has constraints film animation doesn't: it must loop, blend, and be interruptible at any frame.

**B27 — Locomotion: idle, walk, run.**
Building each in place. Contact/down/passing/up poses. Hip motion in all three axes. Arm swing and counter-rotation. Making a cycle loop seamlessly. Keeping the three clips blendable — same frame counts, same phase.
*Exercise:* a walk cycle that loops without a visible pop, then a run that blends with it.

**B28 — Actions and the NLA.**
The action data-block. Fake users and why your animation vanished. Stashing, the NLA editor, and exporting multiple named clips in one `.glb` — the exact setup Godot expects.

**B29 — Mixamo, and retargeting.**
Getting free rigs and mocap. Auto-rigger. Downloading with/without skin, in-place vs with root motion. Retargeting Mixamo's skeleton onto yours in Blender: bone mapping, rest-pose differences, scale and rotation offsets. Cleaning up mocap.
*Exercise:* retarget three Mixamo clips onto your own rig, cleanly.

**B30 — Root motion.**
In-place vs root motion, what each costs in engine, and the hybrid that most games actually use. Extracting root motion into a root bone. Godot's `AnimationTree` root-motion track.

---

## Block 7 — Simulation & VFX (Module 5, chapters 5.16–5.17)

**Smoke and fire → flipbook.** Quick Smoke setup, domain resolution, and why you keep it low. Baking the sim. Rendering the domain from a fixed camera to an image sequence. Assembling a 4×4 or 8×8 sprite sheet. Getting the alpha right so it composites in-engine.
**Cloth → mesh animation.** Cloth sim on a banner or cape, pinning, collision, baking to shape keys or an mdd, and exporting as vertex animation.
*Why do this in Blender rather than buy an effect:* because a flipbook you generated matches your art direction, costs nothing, and can be regenerated at any resolution.

---

## Block 8 — Cinematic: rendering & compositing (Module 7, chapters 7.20–7.21)

**Cameras and rendering.** Camera objects, focal length, depth of field, and the language of shots. EEVEE vs Cycles: what each is for, sampling, denoising, render time reality. Output settings, colour management, Filmic/AgX, and rendering an image sequence rather than a video file (and why).
**Compositing.** The compositor node graph. Render layers and passes. Glare, lens distortion, colour balance, vignette. Alpha-over for layering. Assembling a trailer in the Video Sequence Editor. Rendering a pre-rendered cutscene for use in-game, and the size cost of doing so on mobile.
*Exercise:* render a 10-second establishing shot of your Level 1 kit, composited and graded, for use as the game's title-screen backdrop.

---

## Block 9 — The full character pipeline (B31–B42) · Module 8

This is Module 8 in full. Every chapter is one stage of building **the Warden**.

- **B31 — Concept & blockout.** Reference boards, silhouette thumbnails, proportion blocking with primitives.
- **B32 — Sculpting fundamentals.** Dyntopo vs multires vs voxel remesh. The brush set that actually matters (Draw, Clay Strips, Grab, Crease, Smooth, Inflate, Pinch). Symmetry. Masking and face sets.
- **B33 — Sculpting the Warden.** Primary forms → secondary → tertiary. Anatomy landmarks. Hard-surface elements on an organic base. Knowing when to stop.
- **B34 — Retopology.** Why you do it. Poly Build, snapping to surface, the Shrinkwrap approach. Edge loops at every deforming joint. Budgeting the mesh: face gets more than the back of a calf.
- **B35 — Character UVs.** Seam placement on a character (hidden by armour, along the inside of limbs). Symmetry and stacked islands, and the trade-off with unique detail. Packing.
- **B36 — High-to-low baking.** Cage setup, ray distance tuning, exploded-mesh baking for tricky parts. Diagnosing every common bake error by its appearance.
- **B37 — Character texturing.** ID masks driving a layered material. Hand-painted detail over procedural base. Skin, metal, leather and cloth in one texture set.
- **B38 — Hair, cloth and accessories on a budget.** Card-based hair, alpha-tested vs alpha-blended (and the mobile cost of each), simple cloth as geometry.
- **B39 — A production rig.** IK legs with foot roll, IK/FK-switchable arms, spine and neck controls, custom bone shapes, bone collections. Usable by someone who isn't you.
- **B40 — Facial basics.** Shape keys for expressions and visemes. Drivers. A minimal, mobile-appropriate face setup.
- **B41 — The animation set.** Idle, walk, run, jump, land, attack, hit-react, death — hand-keyed. Making them blend with each other and interrupt cleanly.
- **B42 — Export and retarget.** Into the P03 controller. Verifying skinning, scale and animation on device.

---

## Block 10 — Geometry Nodes (Module 11, chapter 11.3)

Procedural modelling as a node graph. Scattering rocks, grass and debris across a surface with control. Instancing on points. Attributes. Building a procedural fence/pipe/cable generator. Realising the result to real geometry, and exporting it. Where Geometry Nodes replaces manual work and where it's a fun distraction.

---

## How to practise Blender specifically

Blender rewards **daily short sessions** more than weekend marathons — it's a motor skill as much as a knowledge one.

1. **Ten minutes of speed modelling a day.** Pick a real object on your desk. Model it in ten minutes. Don't texture it, don't perfect it. Delete it. The point is the hotkeys.
2. **Learn the hotkey when you use the menu.** Every time you reach for a menu, note the shortcut shown next to the entry and use it next time. Don't memorise lists.
3. **Always work with a reference image.** "From imagination" is a much later skill.
4. **Check the statistics overlay constantly.** Knowing your triangle count at all times is a professional habit that beginners never have.
5. **Save incrementally.** `Ctrl+Alt+S`. Blender is stable, but sculpting and simulation are where it isn't.
6. **When something looks wrong, check these five in order:** unapplied scale · flipped normals · duplicate vertices · wrong shading (flat/smooth/autosmooth) · a modifier you forgot was there. This diagnoses most problems.
