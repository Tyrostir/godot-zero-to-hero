---
title: "Setup 03 — Blender, Configured Once"
document_id: SETUP-03
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When Blender's preferences layout or recommended add-ons change"
---

# 🧊 Setup 03 — Blender, Configured Once

> **By the end of this guide** you will have a Blender you do not have to fight, configured to match Godot's world.

**Download:** <https://www.blender.org/download/> — take the current stable 4.x release.

---

## 1. Preferences to change on day one

`Edit → Preferences`. These are not cosmetic — each one removes a class of future frustration.

| Section | Setting | Value | Why |
|---|---|---|---|
| Interface | **Developer Extras** | on | Exposes Python names in tooltips — the fastest way to learn what a control actually does |
| Interface → Tooltips | **Python Tooltips** | on | Same |
| Input | **Emulate Numpad** | on *if you have no numpad* | View shortcuts move to the top-row number keys |
| Input | **Emulate 3 Button Mouse** | on *if you use a trackpad* | `Alt`+LMB substitutes for the middle mouse button |
| Navigation | Orbit Method | **Turntable** | Matches how you think about a ground plane; Trackball gets disorienting fast |
| *(see note)* | **Clip Start** | `0.01 m` | ⚠️ **Not in Preferences** — it is per-viewport: press `N` → **View** tab in the 3D viewport. Set it, then save the startup file |
| System | Undo Steps | `64` | Sculpting eats undo steps |
| Save & Load | **Auto Save** | on, every 2 min | Non-negotiable |
| Save & Load | Save Versions | 2 | Keeps `.blend1` backups |

Then **Save Preferences** (bottom-left menu).

---

## 2. Add-ons to enable

⚠️ **Blender 4.2+ ships only seven built-in add-ons** — Cycles, glTF 2.0, Hydra Storm, Manage UI translations, **Node Wrangler**, Pose Library, **Rigify**, VR Scene Inspection. Everything else moved to the **Extensions** system ([extensions.blender.org](https://extensions.blender.org), reachable from **Get Extensions** in the Preferences sidebar). ✅ Verified on Blender 4.x, 2026-09-02.

`Preferences → Add-ons`:

| Add-on | Status | Why |
|---|---|---|
| **Node Wrangler** | ⭐ **enable now** | Shader-editor shortcuts used constantly from chapter B14. `Ctrl+Shift+T` alone justifies it |
| **glTF 2.0 format** | already on — confirm | Your export path ([ADR-009](../meta/Decisions.md#adr-009)) |
| **Rigify** | leave off | Enabled in **B24b**, after you hand-build an armature ([ADR-028](../meta/Decisions.md#adr-028)) |
| ~~Extra Objects~~ · ~~Copy Attributes Menu~~ | ⚠️ no longer bundled | Available as Extensions if you want them. **Nothing in this course requires them** |

Optional but recommended once you reach Module 3:

| Add-on | Why |
|---|---|
| **Poly Haven add-on** (free, external) | One-click CC0 HDRIs, textures and models straight into Blender. See [../reference/ResourcesMeta.md](../reference/ResourcesMeta.md) |

---

## 3. The setting that matters most: units

⚠️ **In every file you make**, check `Scene Properties → Units`:

| Field | Value |
|---|---|
| Unit System | **Metric** |
| Unit Scale | **1.0** |
| Length | Metres |

This is what makes **1 Blender metre = 1 Godot unit**. Chapter **B3** explains why this matters far more than it sounds — it propagates into physics, lighting, bevel widths, normal maps and rig deformation.

### Make it the default

Set up a file the way you want it (units correct, default cube deleted, a camera and light you like), then `File → Defaults → Save Startup File`. Every new file now starts correct.

---

## 4. Smoke test

1. New file. Check units are Metric / 1.0.
2. Add a cube. In the N-panel, set its dimensions to exactly **2 m × 2 m × 2 m**.
3. `Ctrl+A → All Transforms`.
4. `File → Export → glTF 2.0 (.glb)`. Export it anywhere.
5. Drag the `.glb` into a Godot project's folder, then into a 3D scene.
6. **It should be exactly 2 units across in Godot.**

⚠️ **You cannot read this from the Inspector.** A `.glb` imports as a scene whose root is a `Node3D`; the mesh is a hidden child, so the Inspector shows the root's transform, not the mesh's size. Godot's grid also subdivides with zoom, so counting squares is not a measurement. Measure it with a script — see [chapter 0.3, Step 6, Method A](../chapters/Chapter_00.03_Blender.md).

If it isn't, stop and fix it now — every asset you make for the rest of the course depends on this being right. The diagnostic order is in [../reference/answers/module-02.md](../reference/answers/module-02.md), answer 15.

➡️ **Next:** [Setup 04 — Android SDK and your device](Setup_04_Android_And_Device.md)
