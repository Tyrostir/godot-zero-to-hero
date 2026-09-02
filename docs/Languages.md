---
title: "The Languages — GDScript, C#, C++ and GDShader, and which job goes to which"
document_id: LANGS
version: 1.0
status: Active
created: 2026-09-02
last_updated: 2026-09-02
update_trigger: "When the language split or a language's role in the course changes"
---

# 🗣️ The Languages

> **You will write four languages in this course.** Not because more is better, but because Godot genuinely uses four, each one is best at a different job, and a professional picks the right one rather than forcing one everywhere.
>
> **The rule ([ADR-031](meta/Decisions.md#adr-031)):** you never learn a language from a lecture. You learn it by **building the same thing in it and measuring the difference on your own hardware.**

---

## 1. The four, and what each is actually for

| Language | Role | Best at | Worst at | First met |
|----------|------|---------|----------|-----------|
| **C#** | 🥇 **Primary** | Gameplay systems, architecture, data, saves, tests. Static typing, real refactoring, NuGet | Quick editor scripts; iteration speed (needs a build) | **0.11** |
| **GDScript** | 🥈 **Secondary** | `@tool` editor scripts, UI glue, prototyping, **consuming and patching the addon ecosystem** | Large architectures; anything you want type-checked | **0.10** |
| **C++** (GDExtension) | 🥉 **Last resort** | Measured hot paths; wrapping native libraries; engine extension | Everything before you have profiled. Iteration is slow, and Android means per-ABI builds | **0.13** |
| **GDShader** | 🎨 **Its own thing** | Anything that runs on the GPU, per-vertex or per-pixel | Game logic — it cannot do it. Different execution model entirely | **0.16** |

---

## 2. How you learn them — the same cube, three ways

Module 0's block **0B** is the heart of this. You do not read a comparison table; **you produce one.**

| Chapter | You build | You measure |
|---------|-----------|-------------|
| **0.10** | The spinning cube in **GDScript** — six lines, no build step | Time from edit to seeing the change |
| **0.11** | The same cube in **C#** — `partial`, the class-name rule, `[Export]` | The same, now including a build |
| **0.12** ⭐ | Nothing new — you **compare** | Build time · APK size · lines of code · iteration speed |
| **0.13** | The same cube as a **C++ GDExtension node** — `godot-cpp`, SCons, property and signal registration | How long the toolchain took to set up. Be honest; it is not five minutes |
| **0.14** | That native node **on your phone** — per-ABI builds, the `.gdextension` file | APK size delta, and whether it actually runs |
| **0.15** ⭐ | Nothing new — the **three-way comparison** | Everything above, on *your* hardware |
| **0.16** | A one-line fragment shader on the cube | That GDShader is a different kind of thing altogether |
| **0.17** | **The decision table** — written by you, from your numbers | Which job goes to which language, for the next 300 chapters |

> 💡 **Why measure rather than be told.** Any course can assert "C++ is faster, GDScript iterates quicker". A number you produced on your own phone is something you believe, remember, and can defend in an argument. It also means that when your hardware or Godot's version makes the received wisdom wrong, you will notice.

> ⚠️ **0.13–0.14 will take an afternoon and will feel disproportionate.** That is expected and it is deliberate. You will not need C++ again until Module 10. Doing the toolchain once now, when nothing depends on it, means Module 10 is about *performance* rather than about SCons.

---

## 3. Where each language is actually used, chapter by chapter

### GDScript — 8 chapters where it is the *right* choice

| Chapter | What you write in GDScript | Why not C# |
|---------|---------------------------|------------|
| **0.10** | First contact — the cube | — |
| **4.2b** | An `@tool` animation-clip validator | Editor scripts want no build step and instant reload |
| **5.9b** | A `@tool` level validator: lightmap UVs, missing collisions, over-budget meshes | Same, and it runs on every save |
| **10.10b** | A full editor plugin with a custom dock | GDScript's editor integration is simply better |
| **1.31b** | Consuming **Panku Console** from C# — your first cross-language boundary | The addon is GDScript; you meet it on its terms |
| **8.10b** | Evaluating **Dialogue Manager** / **Dialogic** | Both are GDScript addons |
| **11.6b** | Evaluating **Beehave** | GDScript addon |
| **10.6b** | **Wrapping** a GDScript addon behind a C# interface | The pattern that makes all the above safe |

### C++ / GDExtension — 7 chapters, all earned

| Chapter | What you write in C++ | Why |
|---------|----------------------|-----|
| **0.13** | A native node with a property and a signal | First contact; both languages can see it |
| **0.14** | Android per-ABI build, `.gdextension` wiring | Because "it compiles on desktop" is not shipping |
| **10.1c** | A real GDExtension node used by the game | Now it does something |
| **10.1d** | Debug vs release builds, APK size measurement | The cost side of the trade |
| **10.1e** ⭐ | **The measured rewrite** — one hot path, GDScript → C# → C++, benchmarked on the phone at each step | This is the chapter that makes "profile first" a fact rather than a slogan |
| **10.1f** 🔬 | Wrapping a native C++ library, and its licence question | |
| **12.4** | GDExtension at depth | Optional |

You also *consume* C++ constantly without writing it: **Terrain3D**, **LimboAI**, **Debug Draw 3D** and **Zylann Voxel Tools** are all GDExtension, which is precisely why they have the best C# story.

### GDShader — Module 6 in its entirety
Twelve chapters (6.1–6.12), six shaders written by hand. Introduced in **0.16** so it is not a surprise.

### C# — everything else
Roughly 180 chapters. Systems, architecture, gameplay, data, saves, tests, tooling.

---

## 4. The boundaries, and their cost

| Direction | Mechanism | Cost | Rule |
|-----------|-----------|------|------|
| C# ↔ GDScript | Signals, `Call()`, `Get()`/`Set()`, `GetNode<T>()` | Variant marshalling per call; **no compile-time checking** | Cross **once per frame**, never once per entity per frame |
| C# ↔ C++ | The C++ class *is* an engine type | Cheap, **fully typed** | Free to use normally |
| GDScript ↔ C++ | Same | Cheap | Same |

⚠️ **Cross-language *inheritance* is not supported** — GDScript cannot extend a C# class or vice versa. `[UNVERIFIED]` for your exact version; the guidance holds either way: **compose at the boundary, never inherit across it.**

**The rule that makes polyglot safe:** every boundary lives in **one place**. One wrapper file per GDScript addon exposing a clean C# interface (10.6b). One GDExtension module with a narrow, documented API (10.1c). If boundary code is scattered through your codebase, you have three languages' problems and none of their benefits.

---

## 5. The decision table

You write your own version in **0.17**, from your own measurements. This is the starting point.

| The job | Language | Because |
|---------|----------|---------|
| Gameplay systems, state machines, combat | **C#** | Typed, testable, refactorable |
| Data and save files | **C#** | NuGet serialisers, and `Resource` classes |
| Unit tests | **C#** | GdUnit4 + FluentAssertions |
| An `@tool` editor script | **GDScript** | No build step; instant reload |
| An editor plugin or dock | **GDScript** | Best editor integration |
| Quick prototype of an idea | **GDScript** | Fastest edit→see loop |
| Patching or reading a community addon | **GDScript** | It is already GDScript |
| A hot path you **measured** | **C++** | Only after the profiler says so |
| Wrapping a native library | **C++** | No alternative |
| Anything on the GPU | **GDShader** | No alternative |
| A boundary between any two of the above | **One wrapper file** | See §4 |

---

## 6. What this costs you, honestly

1. **Four syntaxes, three debuggers, two build systems.** For a solo developer this is a real tax, and it is why C# stays primary and the other three are scoped tightly to jobs they are clearly best at.
2. **The C++ toolchain is genuinely fiddly**, especially the Android per-ABI story. Budget an afternoon in 0.13–0.14 and do not be discouraged.
3. **Boundary bugs are the worst kind** — they fail at runtime, not compile time. Hence the one-wrapper-file rule.
4. **More to keep current.** Godot updates can break a GDExtension ABI and require a rebuild.

**What you get for it:** you can use *every* library in [`Toolchain.md`](Toolchain.md) rather than the subset that happens to match your language, you can reach for the right tool per job, and you have the skill set an actual studio uses. That trade is why the course makes it — and why [ADR-031](meta/Decisions.md#adr-031) scopes each language rather than letting them sprawl.
