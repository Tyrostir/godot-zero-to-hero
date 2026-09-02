---
title: "Resources Meta — Free Assets, Tools and Their Licences"
document_id: RESMETA
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When a resource is evaluated, or a licence changes"
---

# Free Resources Directory

Everything in this course can be built with free software and free assets. This is the directory of where to get them, what licence you're accepting, and how to actually get each kind of file into Godot.

> **Rule, repeated because it matters:** the moment you download something, add a row to [AssetLicenses.md](AssetLicenses.md). Six months from now you will not remember where that texture came from, and "I can't prove I'm allowed to use this" is how finished games fail to ship.

---

## Part 1 — Licences, before anything else

Read this section once, properly. It takes five minutes and saves you from a category of problem that has no fix later.

| Licence | Can I use it in a game I sell? | Must I credit? | Catch |
|---|---|---|---|
| **CC0** / Public Domain | Yes | No (but do anyway) | None. **This is the licence you want.** |
| **CC-BY** | Yes | **Yes** — visibly, in credits | Attribution must be reasonable and visible. A credits screen counts. |
| **CC-BY-SA** | Yes, with care | Yes | "ShareAlike": derivatives of *the asset* must carry the same licence. Fine for a texture you don't modify; risky for one you build a new material from. Prefer to avoid. |
| **CC-BY-NC** | **No** | — | Non-commercial only. Even a free game with ads or a Patreon can be argued commercial. **Just don't.** |
| **CC-BY-ND** | **No** (in practice) | — | No derivatives — and importing, re-compressing and re-rigging are derivatives. |
| **OGA-BY** | Yes | Yes | OpenGameArt's own attribution licence. Behaves like CC-BY. |
| **MIT / BSD / Apache-2.0** | Yes | Yes (licence text) | Normal for code and shaders. Keep the licence text in your repo. |
| **GPL / AGPL** | **Careful** | Yes | Viral for *code*. A GPL shader or plugin can obligate you to release your source. Fine if you intend to; a trap if you don't. |
| **SIL OFL** | Yes | Usually no | Standard font licence. Don't sell the font itself. |
| **"Royalty-free", custom EULAs** | Read it | Depends | Sonniss, Mixamo etc. Usually generous, but read the actual terms — they often forbid *redistributing the raw asset*, which is fine for a game but not for an asset pack. |

**Three rules that keep you safe:**

1. **Prefer CC0.** Nearly everything this course needs exists as CC0.
2. **Never take CC-BY-NC or CC-BY-ND.** The moment you consider monetising — or even just accepting a donation — they become a problem, and by then they're baked into 40 scenes.
3. **Record attribution at download time.** Chapter 8.19 builds a credits roll that reads `AssetLicenses.md` automatically. If the ledger is complete, your credits screen is free.

---

## Part 2 — 3D models & environment art

| Source | Licence | Best for | Notes |
|---|---|---|---|
| **[Kenney.nl](https://kenney.nl/assets)** | CC0 | Prototyping kits, UI, props, characters | The single best starting point in game dev. Thousands of assets, zero strings. Low-poly and consistent. |
| **[Poly Haven](https://polyhaven.com/)** | CC0 | HDRIs, PBR textures, scanned models | Best-in-class HDRIs for lighting. Also has a free Blender add-on for one-click import. |
| **[Quaternius](https://quaternius.com/)** | CC0 | Stylised low-poly characters, nature, buildings | Includes *rigged and animated* characters — excellent for Module 4 before your own character exists. |
| **[KayKit / Kay Lousberg](https://kaylousberg.itch.io/)** | CC0 | Cohesive dungeon/character/adventure kits | Modular, mobile-friendly, and stylistically consistent — a rare combination. |
| **[Poly Pizza](https://poly.pizza/)** | CC0 & CC-BY (filter!) | Low-poly props, quick prototyping | Successor to the Google Poly archive. **Filter by licence** — it mixes both. |
| **[Sketchfab](https://sketchfab.com/features/free-3d-models)** | Mixed | Almost anything | Filter to *Downloadable* + a licence you accept. Quality and topology vary wildly; expect to clean up. |
| **[OpenGameArt](https://opengameart.org/)** | Mixed | Long tail, odd specifics | Old, unglamorous, huge. **Check the licence on every single asset** — the mix includes GPL and CC-BY-SA. |
| **[Fab](https://www.fab.com/)** | Mixed | Epic's marketplace, has a free section | Read each item's licence carefully; terms differ per listing. |
| **[BlenderKit](https://www.blenderkit.com/)** | Free tier, mixed | In-Blender asset browsing | Convenient because it lives inside Blender. Verify per-asset licensing. |
| **[ambientCG](https://ambientcg.com/)** | CC0 | PBR material scans | See *Materials* below. Also has some models. |

**How to use a downloaded model (the general workflow):**

1. Download to `assets-staging/models/<source>-<name>/`. Keep the original archive.
2. **Log it in [AssetLicenses.md](AssetLicenses.md) now.**
3. Open the source file (`.blend`, `.fbx`, `.obj`) in Blender — never import an unknown `.fbx` straight into Godot.
4. In Blender: check scale (1 unit = 1 m), apply transforms (`Ctrl+A`), check the origin is sensible (usually at the object's base), check normals (`Alt+N → Recalculate Outside`), check poly count.
5. Rename meshes and materials to your project's convention (see [Conventions.md](Conventions.md)).
6. Export **glTF 2.0 (`.glb`)** into your Godot project's `assets/` folder.
7. In Godot, set the import preset, then re-import.

Chapters B17–B19 cover every step of this in detail. Do not skip step 4 — 90% of "why is my model tiny / sideways / inside-out" comes from skipping it.

---

## Part 3 — Textures & materials

| Source | Licence | Notes |
|---|---|---|
| **[ambientCG](https://ambientcg.com/)** | CC0 | ~2000 PBR materials, every map, multiple resolutions. **Start here.** |
| **[Poly Haven Textures](https://polyhaven.com/textures)** | CC0 | Fewer but very high quality, with proper displacement maps. |
| **[ShareTextures](https://www.sharetextures.com/)** | CC0 | Good architectural / surface variety. |
| **[Material Maker](https://www.materialmaker.org/)** | MIT (tool) | **Procedural material authoring, free and open source.** Node-based, exports PBR map sets, and is made by the Godot community — it even exports Godot shaders directly. This is your free replacement for Substance Designer. |
| **[Krita](https://krita.org/)** / **[GIMP](https://www.gimp.org/)** | Free | Hand-painting textures, editing maps, packing channels. |

**Mobile texture discipline** (learned properly in 5.14, but adopt it from day one):

- Download the **2K** version, not 4K or 8K. On a phone screen you cannot tell, and you will pay for it in memory and load time.
- Prefer **1K** for anything not directly under the camera.
- Pack roughness/metallic/AO into a single texture's channels rather than shipping three greyscale images.
- Always check "is this texture tiling?" before you use it on a large surface.

---

## Part 4 — Characters & animations

| Source | Licence | Notes |
|---|---|---|
| **[Mixamo](https://www.mixamo.com/)** | Free with an Adobe account | **The** free source of humanoid animation. Auto-rigs your own model, and offers thousands of mocap clips. Chapters B29–B30 cover retargeting these onto your own skeleton in Blender. Read Adobe's terms: use in your game is fine, redistributing the raw clips is not. |
| **[Quaternius characters](https://quaternius.com/)** | CC0 | Already rigged and animated. Perfect placeholder while you build your own in Module 9. |
| **[MakeHuman](http://www.makehumancommunity.org/)** | CC0 output | Generates base human meshes with rigs. Useful as a sculpting base or proportion reference. |
| **[Cascadeur](https://cascadeur.com/)** | Free tier | Physics-assisted keyframe animation. The free tier is generous. An alternative to hand-keying in Blender for action animation. |
| **[Kenney character kits](https://kenney.nl/assets)** | CC0 | Blocky, cheerful, extremely mobile-friendly. |

---

## Part 5 — VFX & shaders

| Source | Licence | Notes |
|---|---|---|
| **[Godot Shaders](https://godotshaders.com/)** | Mostly MIT / CC0 (**check each**) | A community library of GDShader code. Read them to learn, don't just paste them. |
| **[Kenney particle packs](https://kenney.nl/assets/particle-pack)** | CC0 | Ready-made particle sprites: smoke, sparks, magic, flares. |
| **[OpenGameArt VFX](https://opengameart.org/)** | Mixed | Explosion sheets, magic effects, flipbooks. |
| **[Real Time VFX](https://realtimevfx.com/)** | — | Not an asset source: a *community*. The best place to learn how effects are constructed. Read the "beginner" pinned threads. |
| **Blender (yourself)** | Yours | Chapters 6.16–6.17: bake smoke, fire and cloth sims into flipbook sheets. Making your own VFX textures is easier than it sounds and gives you a look nobody else has. |
| **[Shadertoy](https://www.shadertoy.com/)** | **Varies — often not reusable** | Superb for learning techniques; treat licensing as restrictive unless the author says otherwise. Learn the maths, write your own. |

---

## Part 6 — Audio

| Source | Licence | Notes |
|---|---|---|
| **[Sonniss GDC Bundles](https://sonniss.com/gameaudiogdc)** | Royalty-free, commercial OK | Tens of gigabytes of professional SFX, released free every year. **The best free SFX resource that exists.** Download a couple of years' worth once. |
| **[Freesound](https://freesound.org/)** | Mixed — filter to CC0 | Enormous library. Use the licence filter; a lot is CC-BY, some is NC. |
| **[Kenney audio](https://kenney.nl/assets?q=audio)** | CC0 | UI clicks, impacts, footsteps. Small, clean, game-ready. |
| **[Pixabay](https://pixabay.com/sound-effects/)** | Pixabay licence | Music and SFX, commercial use allowed, no attribution required. Read the licence for the exclusions. |
| **[Incompetech (Kevin MacLeod)](https://incompetech.com/music/)** | CC-BY | Huge, well-organised music library. **Attribution is mandatory** — the exact wording is on the site. |
| **[Free Music Archive](https://freemusicarchive.org/)** | Mixed | Filter carefully. |
| **[OpenGameArt music](https://opengameart.org/art-search-advanced?field_art_type_tid%5B%5D=12)** | Mixed | Loops written for games specifically. |
| ~~BBC Sound Effects~~ | **Personal/education only** | Listed here so you know to *avoid* it for a released game. |

**Tools:** [Audacity](https://www.audacityteam.org/) for editing (free), [LMMS](https://lmms.io/) or [MuseScore](https://musescore.org/) for composing, [sfxr/jfxr](https://jfxr.frozenfractal.com/) for retro-style generated SFX, [Chiptone](https://sfbgames.itch.io/chiptone) for the same in-browser.

**Workflow for every SFX** (chapter 7.4): trim silence → normalise to a consistent level → fade in/out to avoid clicks → export as **`.ogg`** for music and ambience, **`.wav`** for short frequently-triggered SFX → import into Godot with loop settings checked.

---

## Part 7 — UI, fonts & icons

| Source | Licence | Notes |
|---|---|---|
| **[Kenney UI packs](https://kenney.nl/assets?q=ui)** | CC0 | Buttons, panels, cursors, prompts. Includes gamepad and touch button glyphs. |
| **[Google Fonts](https://fonts.google.com/)** | Mostly OFL | Download the `.ttf`. For a game, pick a font with a wide weight range and check it has the glyphs your localisation needs. |
| **[game-icons.net](https://game-icons.net/)** | CC-BY 3.0 | ~4000 game-appropriate SVG icons. Attribution required. Recolour freely. |
| **[Lucide](https://lucide.dev/)** | ISC | Clean UI iconography for settings/menus. |

**Android UI reality check:** design your UI at a phone's aspect ratio from the start, respect the safe area (chapter 1.29), and make every touch target at least **48×48 dp**. A UI designed on a 27" monitor is always too small on a phone.

---

## Part 8 — Tools (all free)

| Tool | Purpose |
|---|---|
| **Godot 4 .NET** | The engine |
| **Blender 4.x** | All 3D content |
| **VS Code** + C# Dev Kit, or **Rider** (free non-commercial) | Code |
| **Material Maker** | Procedural PBR materials |
| **Krita** / **GIMP** | Texture painting, image editing |
| **Inkscape** | Vector art, icons, logos |
| **Audacity** | Audio editing |
| **LMMS** / **MuseScore** | Music |
| **Cascadeur** (free tier) | Physics-assisted animation |
| **MakeHuman** | Base human meshes |
| **OBS Studio** | Trailer capture, playtest recording |
| **scrcpy** | Mirror and record your phone's screen from the desktop — invaluable for capturing gameplay footage |
| **Git + Git LFS** | Version control |

---

## Part 9 — Learning references (bookmark these)

| Reference | Use it for |
|---|---|
| **[Godot docs](https://docs.godotengine.org/)** | The primary source. The C# sections are good. Read the class reference, not just tutorials. |
| **[Godot C# API reference](https://docs.godotengine.org/en/stable/classes/)** | Switch the language toggle to C# — the signatures differ from GDScript. |
| **[Godot GitHub issues](https://github.com/godotengine/godot/issues)** | When something is weird on Android + C#, search here before assuming it's you. It often isn't. |
| **[Blender Manual](https://docs.blender.org/manual/en/latest/)** | Genuinely excellent. Underused. |
| **[Godot Shaders](https://godotshaders.com/)** | Shader examples |
| **[Real Time VFX](https://realtimevfx.com/)** | VFX craft |
| **[Book of Shaders](https://thebookofshaders.com/)** | Shader fundamentals from first principles |
| **[Game Programming Patterns](https://gameprogrammingpatterns.com/)** (free online) | Architecture, and the source of half of Module 10 |

---

## Part 10 — What to download right now

Don't hoard. But before Module 1, get these four, and log all four in the ledger:

1. **Kenney's "Prototype Textures"** — grid textures for greyboxing. You'll use them in every project.
2. **Kenney's "UI Pack"** — so your first HUD isn't grey rectangles.
3. **One Poly Haven HDRI** (an outdoor one, 2K) — instant decent lighting for tests.
4. **Quaternius's animated character pack** — a rigged, animated humanoid to develop Module 4 against while your own character doesn't exist yet.

That is enough. Asset hoarding is a very effective way to feel productive without shipping anything.
