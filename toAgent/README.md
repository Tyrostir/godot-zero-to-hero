---
title: "toAgent — Learner-Captured Output"
document_id: TOAGENT
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
audience: "The learner and the AI author (Tier 3)"
update_trigger: "Every time the learner drops a file here"
---

# 📥 toAgent/

Where **you** put raw output from your desktop and your phone, for **me** to read.

> ⛔ **Tier 3 — internal** ([ADR-014](../docs/meta/Decisions.md#adr-014)). Not part of the course, not in the Table of Contents.

---

## Why this exists

I write from a Termux session with no Godot, no Blender, no .NET and no `adb` ([ADR-016](../docs/meta/Decisions.md#adr-016)). I cannot see what your tools print. This directory is the only channel through which reality reaches me.

---

## What to drop here

| Kind | Example |
|---|---|
| **Verification block results** | The output of a `V-NN` block from [`../docs/internal/VerificationRuns.md`](../docs/internal/VerificationRuns.md) |
| **Error output** | A failed Godot build, a failed Android export, an `adb logcat` excerpt |
| **Tool versions** | `dotnet --list-sdks`, `java -version`, Godot's `Help → About` |
| **Performance readings** | Godot's on-device monitors — frame time, draw calls, memory, triangles |
| **Blender state** | The outliner, a UV layout, a bake result, statistics-overlay numbers |
| **Screenshots** | Anything visual. Put images in `../assets/images/` and reference them |
| **Questions** | Put `/btw` on its own line anywhere in the file |

---

## Naming

```text
NN.BlockV-NN-ShortDescription.md      e.g.  01.BlockV-01-ToolchainVersions.md
NN.Error-ShortDescription.md          e.g.  02.Error-AndroidExportKeystore.md
NN.Perf-ShortDescription.md           e.g.  03.Perf-P04Level1OnDevice.md
```

`NN` increments and is never reused.

---

## The one rule

> 🚨 **Paste everything. Do not tidy it up.**
>
> Truncated output has cost more debugging time on the sibling QNX course than any other single thing. Warnings you think are noise are frequently the answer. Include the command you ran, the full output, and the exit status if you have it.

**A good file looks like this:**

````markdown
# V-01 — Toolchain versions

Ran on: Windows 11, 2026-09-05. Everything worked except `adb`, see step 4.

## Step 1 — dotnet

```console
> dotnet --version
8.0.xxx
```

## Step 4 — adb  ❌ FAILED

```console
> adb devices
List of devices attached
<serial>   unauthorized
```

/btw does "unauthorized" mean my phone is broken, or did I miss a prompt?
````

Then tell me it's here. I'll clear the markers it settles, answer the `/btw` as a `D-NNN`, and update [`../docs/internal/VerificationRuns.md`](../docs/internal/VerificationRuns.md).

---

## Contents

*(empty — your first drop goes here)*
