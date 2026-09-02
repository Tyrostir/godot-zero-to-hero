---
title: "Conventions — Code, Naming, Folders and Git"
document_id: CONV
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When a convention is adopted or changed"
---

# 📐 Conventions.md

> Conventions are not about taste. They exist so that in month nine you can find a file without thinking, and so that a stranger reading your code — including future-you, who is a stranger — does not have to decode your habits first.

---

## 1. C# style

Godot's C# API uses **PascalCase** for everything (unlike GDScript's snake_case). Match it.

| Thing | Convention | Example |
|---|---|---|
| Class | PascalCase, **matches the filename exactly** | `PlayerController` in `PlayerController.cs` |
| Public member / property | PascalCase | `public float MaxSpeed` |
| Private field | `_camelCase` | `private float _currentSpeed` |
| Constant | PascalCase | `public const float Gravity = 9.8f` |
| Method | PascalCase | `void ApplyDamage(int amount)` |
| Local variable / parameter | camelCase | `var hitCount = 0` |
| Interface | `I` + PascalCase | `IDamageable` |
| Signal delegate | `NameEventHandler` | `[Signal] public delegate void DiedEventHandler()` |
| Enum | PascalCase, singular | `enum MoveState { Idle, Walk, Run }` |

**Godot-specific requirements** (not style — these are mandatory):

```csharp
public partial class PlayerController : CharacterBody3D   // must be public partial
```

The class name **must** match the file name, or Godot will not attach the script.

**Exported values:**

```csharp
[Export] public float MaxSpeed { get; set; } = 6f;
[Export(PropertyHint.Range, "0,1,0.01")] public float Friction { get; set; } = 0.8f;
[Export] public NodePath CameraPath { get; set; }
```

**Rules that matter more than formatting:**

1. **No magic numbers in gameplay code.** Anything a designer might tune is `[Export]`ed.
2. **No `GetNode("../../Player")`.** Reaching through the tree breaks the moment anyone moves a node. Use `[Export] NodePath`, groups, or an event bus ([ADR-003 of Module 10](../PLAN.md)).
3. **`QueueFree()`, never `Free()`** unless you can articulate why.
4. **Physics in `_PhysicsProcess`, everything else in `_Process`.**
5. **No allocations in a per-frame hot path** — from Module 10 onward this is enforced, not suggested.

---

## 2. Godot project folder layout

Every project in `projects/` uses the same structure:

```text
projects/P04_Hollow/
├── project.godot
├── scenes/
│   ├── levels/           Level01.tscn, Level02.tscn
│   ├── characters/       Player.tscn, Enemy.tscn
│   ├── ui/               HUD.tscn, PauseMenu.tscn
│   └── vfx/              ImpactBurst.tscn
├── scripts/
│   ├── player/           PlayerController.cs, states/
│   ├── systems/          SaveManager.cs, AudioDirector.cs
│   └── data/             LevelData.cs      (custom Resources)
├── assets/
│   ├── models/           .glb files exported from Blender
│   ├── textures/
│   ├── materials/
│   ├── audio/  sfx/  music/  ambience/
│   ├── fonts/
│   └── shaders/          .gdshader files
├── resources/            .tres data files
└── addons/               third-party plugins only
```

**Why `scenes/` and `scripts/` are separate:** a scene is often reused with different scripts, and a script is often shared across scenes. Nesting one inside the other creates arbitrary decisions about where a shared thing lives.

**`assets-staging/` (repo root) is different** — that's where raw downloads and `.blend` source files live. **Only exported, game-ready files go into a project's `assets/`.** The `.blend` never ships.

---

## 3. Asset naming

```text
<category>_<name>_<variant>.<ext>

mdl_crate_damaged.glb
tex_metal_rusted_albedo.png
tex_metal_rusted_orm.png          (occlusion/roughness/metallic packed)
mat_metal_rusted.tres
sfx_footstep_stone_01.wav
mus_hollow_ambient_loop.ogg
shd_dissolve.gdshader
```

**Prefixes:** `mdl_` `tex_` `mat_` `sfx_` `mus_` `amb_` `shd_` `ui_` `anim_` `fnt_`

**Texture suffixes:** `_albedo` `_normal` `_orm` `_emission` `_height` `_mask`

**Numbered variants** get two digits (`_01`), because `_1` and `_10` sort wrongly.

**In Blender**, name the *object* what you want in Godot — the object name becomes the node name on import. `-col`, `-convcol` and `-noimp` suffixes are functional, not decorative (see [B18](../BlenderTrack.md)).

---

## 4. Scene tree conventions

- **Root node name = scene name.** `Player.tscn` has a root called `Player`.
- **PascalCase node names**, matching how you'd refer to them in code.
- **Group related children under a plain `Node`** rather than letting a root have twenty children.
- **A scene should be instantiable on its own.** If it crashes unless placed inside another specific scene, it has a hidden dependency — fix it with an `[Export]`.

---

## 5. Git

**Commit message format:**

```text
<scope>: <what changed>

ch 1.13: marble rolls with forces instead of position
P02: foundry kit crate + barrel modelled and unwrapped
docs: ADR-024 answered — no learning paths
fix: safe area inset was applied twice on notched devices
```

**Scopes:** `ch N.N` · `PNN` · `docs` · `fix` · `perf` · `art` · `audio` · `refactor`

**Rules:**

1. **Commit after every chapter.** Your git history becomes your revision notes.
2. **Never commit on a broken build.** If you must stop mid-chapter, commit to a branch and say so in the message.
3. **Never commit secrets** — release keystores, signing passwords, API keys. The root `.gitignore` covers the obvious ones; check anyway.
4. **`.godot/`, `bin/`, `obj/`, `.mono/` are never committed.** They are generated.
5. **`.import` files ARE committed.** They carry your import settings; losing them re-imports everything with defaults.

**Git LFS** — worth it for: `.blend` files, textures over ~5 MB, audio, video. Not worth it for: source, scenes, `.tres`, small textures. Set up in chapter 0.7.

---

## 6. Documentation conventions

Applies to everything you or I write in `docs/`:

- **YAML front matter on every document**: `title`, `document_id`, `version`, `status`, `created`, `last_updated`, `update_trigger`.
- **Identifiers are permanent**: `ADR-NNN`, `D-NNN`, `T-NNN`, `V-NN`, `P00`–`P10`, `B1`–`B42`. Never reused, never deleted.
- **Mermaid for diagrams** ([ADR-013](../meta/Decisions.md#adr-013)) — not images, so they stay diffable.
- **No GitHub-only Markdown** ([ADR-021](../meta/Decisions.md#adr-021)) — the course must survive PDF export.
- **British-leaning spelling** — *colour*, *behaviour*, *optimise*, *modelling*. Consistency matters more than which variety.
- **`DecisionsLog.md` is append-only.** Never edit an existing entry.
