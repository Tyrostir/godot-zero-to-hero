---
title: "assets-staging — Raw Downloads and Blender Sources"
document_id: STAGING
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When the staging conventions change"
---

# 🗂️ assets-staging/

**Source files live here. Game-ready exports live in a project's `assets/`.**

This separation matters: a `.blend` file is 40 MB and useless to the engine; the `.glb` it exports is 400 KB and is what ships. Mixing them makes your game project bloated and your Blender work unfindable.

```text
assets-staging/
├── downloads/          raw third-party archives, as downloaded
│   └── <source>-<name>/
├── foundry-kit/        P02 — your modular environment kit
│   ├── kit.blend
│   ├── textures/       source PSD/KRA/high-res maps
│   └── bakes/
├── warden/             P08 — your character
│   ├── sculpt.blend
│   ├── lowpoly.blend
│   ├── rig.blend
│   └── animations.blend
└── vfx/                P05 — simulation sources, flipbook renders
```

## Rules

1. **Keep the original archive** of anything you download. You will want to re-extract at some point.
2. **Log every download in [`../docs/reference/AssetLicenses.md`](../docs/reference/AssetLicenses.md) immediately** ([ADR-008](../docs/meta/Decisions.md#adr-008)).
3. **Never point a Godot project at a file in here.** Export into the project.
4. **`.blend` files are worth Git LFS; raw `.zip` archives are not tracked at all** — see the root `.gitignore`.
5. **Name the source file after what it produces**, so you can find it a year later.

## Before you import anything you downloaded

Open it in Blender first — never import an unknown `.fbx` straight into Godot. Then check, in this order:

- [ ] Scale — 1 unit = 1 m, and `Ctrl+A → Apply Transforms` done
- [ ] Origin — usually at the object's base, not its centre
- [ ] Normals — `Alt+N → Recalculate Outside`; check with the Face Orientation overlay
- [ ] Triangle count — against your budget, in the statistics overlay
- [ ] Names — meshes and materials renamed to [your conventions](../docs/reference/Conventions.md)

Ninety per cent of "why is my model tiny / sideways / inside-out" comes from skipping this list. Chapters B17–B19 cover each step.
