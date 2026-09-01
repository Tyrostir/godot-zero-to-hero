# Answers — Module 2: Blender & the Pipeline

**1. "1 unit" in Blender.**
Blender's default unit system is Metric with a Unit Scale of 1.0, where one grid square is **1 metre**. Godot's 3D space is also nominally 1 unit = 1 metre. For them to agree, keep Metric/1.0 in every scene, model at real-world size, and don't fix scale problems by scaling the *object* — fix them at the source.

**2. Unapplied scale.**
An object scaled at, say, `(0.1, 0.1, 3.0)` in object mode has mesh data that doesn't match what you see. That breaks: **bevels and other modifiers** (widths are computed in local space, so they come out uneven), **normals** (non-uniform scale skews them, causing wrong shading and wrong normal-map baking), and **physics and rigging** in-engine (collision shapes and bone deformation inherit the distortion). `Ctrl+A → Scale` bakes the scale into the mesh data. Do it before UVs, before baking, before export.

**3. `Shift+D` vs `Alt+D`.**
`Shift+D` duplicates the object *and* copies its mesh data — two independent meshes. `Alt+D` creates a **linked duplicate**: a new object pointing at the *same* mesh data. Edit one, all of them change. For a modular kit, `Alt+D` is what you want — change the wall panel once and every instance in the level updates, and the `.blend` stays small.

**4. Object vs mesh data.**
An **object** is a transform (position/rotation/scale) plus modifiers that points at a **data-block**; the mesh data-block holds the actual vertices. Many objects can share one data-block. This is the model behind linked duplicates, and behind "why did editing this one change that one".

**5. Why glTF.**
(a) It's an **open standard** with an unambiguous spec — no scale or axis guesswork. (b) It natively carries **PBR materials, skinning and animation**, which OBJ can't do at all. (c) It's **Godot's best-supported import path** — a first-class importer, no external converter. (FBX is proprietary and historically needed an external `FBX2glTF` step in Godot; OBJ has no animation, no skinning and no PBR.) `.glb` packs everything into one binary file, which is what you want for a game asset.

**6. Import suffixes.**
`-col` — Godot generates a **trimesh** (concave, static) collision sibling for that mesh. `-convcol` — generates a **convex** collision shape (cheaper, usable on dynamic bodies). `-noimp` — the object is **skipped entirely** on import, so you can keep helpers, cages and reference geometry in the same `.blend`. (Also useful: `-colonly`, `-rigid`, `-vehicle`, `-navmesh`.)

**7. Texel density.**
Texels per unit of surface area — literally, how many texture pixels cover one metre of model. If your crate has 512 px/m and the wall next to it has 128 px/m, the crate looks sharp and the wall looks blurry *in the same shot*. The eye reads that inconsistency as "cheap" long before it identifies why. Pick one density for the kit and enforce it.

**8. Trim sheets.**
A trim sheet is a single texture containing horizontal strips of reusable detail — panel edges, pipes, trims, bolts, grating. You UV many different models onto those same strips. One texture, one material, unlimited variations of geometry. On mobile this is enormous: it collapses texture memory and lets everything batch into very few draw calls, while still looking hand-detailed.

**9. Albedo must not contain lighting.**
Albedo (base colour) is the surface's *intrinsic* colour under neutral light. Baked shadows, highlights or ambient occlusion painted into it will fight the engine's real lighting — your shadowed crevice stays dark when you shine a torch into it, and the object looks flat and "stickered". Lighting information belongs in the AO map (used subtly) and in the engine's actual lights.

**10. Normal maps and tangent space.**
A normal map stores, per texel, a perturbed surface normal direction encoded as RGB. **Tangent space** means those directions are stored relative to the surface's own local frame (tangent, bitangent, normal) rather than to world space — which is what allows the map to remain correct when the model rotates, deforms or is skinned to a skeleton. Watch the green-channel convention: OpenGL-style (+Y up) is what Godot expects; a DirectX-style map imported unchanged gives you lighting that looks inverted.

**11. High-to-low baking and the cage.**
You model a detailed **high-poly**, model a cheap **low-poly** that matches its silhouette, then bake the high-poly's surface detail into textures applied to the low-poly. Rays are cast from the low-poly surface outward to find the high-poly. A **cage** is an inflated copy of the low-poly that defines where those rays *start* — it gives you consistent, controllable ray origins and prevents rays from starting inside geometry, which is the cause of most bake noise.

**12. Bake artefacts — dark streaks and stray marks.**
Most likely: (a) **ray distance / cage too small** so rays miss the high-poly, or too large so they hit the wrong nearby surface; (b) **overlapping or flipped UVs** on the low-poly — two surfaces writing into the same texels; (c) **unapplied scale or flipped normals** on either mesh. Also common: insufficient bake margin (bleeding at island edges), and a smooth/flat shading mismatch between high and low.

**13. Atlas → fewer draw calls.**
The GPU changes state between draw calls, and switching material/texture is a state change. Objects sharing one material and one texture can be submitted together; objects with fourteen different materials cannot. On a tile-based mobile GPU that overhead is a real fraction of your frame. One atlas → one material → your whole kit batches.

**14. When topology matters.**
It matters **critically** wherever the mesh deforms — around every joint on an animated character, edge loops must follow the bend or the surface pinches and collapses. It matters **somewhat** for shading, since bad poles and n-gons produce visible artefacts on smooth surfaces. It matters **very little** for a static, flat-shaded prop that never deforms: an n-gon in the middle of a flat crate face is genuinely fine, and agonising over it is wasted time. Judge by "does this deform?" and "does this shade smoothly?"

**15. Model imports at 1/100th size — checks in order.**
(1) Object scale in the N-panel — is it 0.01, and was `Ctrl+A → Apply Scale` done? (2) Scene unit scale in Scene Properties — Metric, 1.0? (3) Was the asset authored in centimetres (common for FBX-origin assets)? (4) glTF export panel — any scale/transform option set unexpectedly. (5) Godot's import dock — the mesh import scale setting. Fix it at the earliest point in that list that's wrong; fixing it downstream (scaling the node in Godot) leaves you with broken physics and lighting later.
