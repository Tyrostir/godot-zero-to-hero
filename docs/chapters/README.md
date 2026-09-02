---
title: "Chapters — Index and the Mandatory Chapter Template"
document_id: CHAPTERS-INDEX
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When a chapter is published, or the template changes"
---

# 📖 docs/chapters/

The course itself. Chapters are published in order and appear here as they are written.

## Published

| # | Chapter | Track | Paths | Time | Status |
|---|---------|-------|-------|------|--------|
| **0.1** | [Machines and Their Roles](Chapter_00.01_MachinesAndTheirRoles.md) | A | 🐣🚶🏃 | 45–60 m | ✅ Published |
| **0.2** | [Installing Godot 4 (.NET) and the .NET SDK](Chapter_00.02_GodotAndDotNet.md) | A | 🐣🚶🏃 | 60–90 m | ✅ Published |
| **0.3** | [Installing Blender, and Configuring It Once](Chapter_00.03_Blender.md) | A | 🐣🚶🏃 | 45–60 m | ✅ Published |
| **0.4** | [JDK, Android SDK, and the Debug Keystore](Chapter_00.04_AndroidToolchain.md) | A | 🐣🚶🏃 | 60–90 m | ✅ Published |
| **0.5** | [Connecting Your Phone](Chapter_00.05_ConnectingYourPhone.md) | A | 🐣🚶🏃 | 45–60 m | ✅ Published |
| **0.6** | [The Godot Editor](Chapter_00.06_TheGodotEditor.md) | A | 🐣🚶🏃 | 60–75 m | ✅ Published |
| **0.7** | [Git for Game Projects](Chapter_00.07_GitForGameProjects.md) | A | 🐣🚶🏃 | 60–75 m | ✅ Published |
| **0.8** ⭐ | [**Project 00: Hello Phone**](Chapter_00.08_P00HelloPhone.md) | **P** | 🐣🚶🏃 | 60–90 m | ✅ Published |
| **0.9** | [Reading Errors](Chapter_00.09_ReadingErrors.md) | A | 🐣🚶🏃 | 60–75 m | ✅ Published |
| **0.10** | [GDScript First Contact](Chapter_00.10_GDScriptFirstContact.md) | A | 🐣🚶🏃 | 45–60 m | ✅ Published |
| **0.11** | [C# First Contact](Chapter_00.11_CSharpFirstContact.md) | A | 🐣🚶🏃 | 60–75 m | ✅ Published |
| **0.12** ⭐ | [Measured: Two Languages, One Cube](Chapter_00.12_MeasuredTwoLanguages.md) | A | 🐣🚶🏃 | 60–75 m | ✅ Published |
| **0.13** | [GDShader: The Fourth Language](Chapter_00.13_GDShaderFirstContact.md) | A | 🐣🚶🏃 | 45–60 m | ✅ Published |
| **0.14** | [The Language Decision Table](Chapter_00.14_LanguageDecisionTable.md) | A | 🐣🚶🏃 | 45–60 m | ✅ Published |
| **0.15** | [Evaluating a Dependency](Chapter_00.15_EvaluatingADependency.md) | A | 🐣🚶🏃 | 60–75 m | ✅ Published |
| **0.16** | [NuGet](Chapter_00.16_NuGet.md) | A | 🐣🚶🏃 | 45–60 m | ✅ Published |
| **0.17** 🧰 | [Dev-Loop Tools](Chapter_00.17_DevLoopTools.md) | A | 🐣🚶🏃 | 45–60 m | ✅ Published |
| **0.18** ⭐ | [The Version Matrix](Chapter_00.18_TheVersionMatrix.md) | A | 🐣🚶🏃 | 45–60 m | ✅ Published |
| **0.19** | [Module 0 Self-Check](Chapter_00.19_Module0SelfCheck.md) | **Q** | 🐣🚶🏃 | 60–90 m | ✅ Published |

**19 / 359.** 🎉 **MODULE 0 COMPLETE** — toolchain, first APK, four languages, dependencies and a pinned build.
 🎉 **Block 0B complete** — all four languages written, and a decision table built from your own measurements.
 🎉 **Block 0A complete** — toolchain installed, an app on the phone, and the ability to read it when it breaks.

Next: **Module 1 — Godot Foundations**, and Project 01 *Marble Runner*.

> 📏 **ADR-002 compliance** — measured against the instructional body ([ADR-002](../meta/Decisions.md#adr-002)):
>
> | Chapter | Doing (≥50%) | Theory (≤30%) |
> |---|---|---|
> | 0.1 | 70.9% | 16.3% |
> | 0.2 | 68.9% | 17.0% |
> | 0.3 | 65.1% | 19.3% |
> | 0.4 | 71.3% | 15.4% |
> | 0.5 | 67.0% | 19.6% |
> | 0.6 | 66.2% | 20.0% |
> | 0.7 | 64.2% | 20.8% |
> | 0.8 | 66.4% | 18.7% |
> | 0.9 | 62.7% | 21.4% |
> | 0.10 | 58.8% | 22.7% |
> | 0.11 | 61.2% | 21.7% |
> | 0.12 | 61.7% | 20.1% |
> | 0.13 | 61.0% | 19.5% |
> | 0.14 | 64.2% | 18.5% |
> | 0.15 | 59.7% | 22.5% |
> | 0.16 | 59.3% | 20.6% |
> | 0.17 | 53.8% | 23.1% |
> | 0.18 | 65.0% | 18.2% |
> | 0.19 | *(assessment chapter — exempt)* | |

> 📑 Full chapter list: **[`../TableOfContents.md`](../TableOfContents.md)**
> 📍 Current progress: **[`../meta/CourseState.md`](../meta/CourseState.md)**
> 🏋️ Every hands-on unit, counted: **[`../Practicals.md`](../Practicals.md)**

---

## Naming ([ADR-020](../meta/Decisions.md#adr-020))

```text
Chapter_MM.NN_PascalCaseTitle.md
```

`MM` is the module, `NN` the chapter, so **filenames sort in reading order** and carry the ID everyone cites. Variant chapters keep their suffix (`Chapter_01.34b_...`). Blender chapters carry their `B`-number in the title:

```text
Chapter_00.01_MachinesAndTheirRoles.md
Chapter_03.B05_BoxModellingTheCrate.md
```

---

## ⚖️ The mandatory chapter template

Enforced by [**ADR-002 — the Practical-First Mandate**](../meta/Decisions.md#adr-002). Every chapter has these sections, **in this order**, with no exceptions.

| # | Section | Rule | Share |
|---|---------|------|-------|
| — | YAML front matter | chapter number, module, track, **paths**, time, prerequisites, status | — |
| 1 | `# Chapter NN — Title` | one H1 | — |
| 1b | 🪜 **Scaffolding** | Front matter declares this chapter's guided/independent split, per [ADR-033](../meta/Decisions.md#adr-033) | 1 line |
| 2 | 🎯 **Goal** | **One sentence**: what will exist at the end that does not exist now | 1 line |
| 2b | 🏃 **Fast-Track Summary** | The whole chapter in ~10 bullets plus the finished code. **Path C reads only this and the cheat sheet — so it must stand alone.** Every download, prerequisite and gotcha the build depends on appears here too, or the chapter is broken for that reader. See [D-015](../meta/Doubts.md#d-015). | short |
| 3 | 🧭 **Before you start** | Prerequisites, and what you should already have running | short |
| 4 | 🔨 **Build** | **Step-by-step doing. Must be the first substantive section.** Every step is a click, a keystroke or a line of code. | **≥ 50%** |
| 5 | ▶️ **Run it** | What you should see. Screenshot or expected output. **The chapter must end in something runnable.** | short |
| 5b | 👀 **Observe** | What actually happened? Name it before explaining it | short |
| 6 | 🧠 **Why it works** | The theory *this build needed* — and only that | **≤ 30%** |
| 7 | 🗺️ **Mental model** | A Mermaid diagram, wherever a picture beats prose | 1 diagram |
| 8 | 💥 **Break it** | A deliberate sabotage | short |
| 8b | 🔎 **Diagnose** | **The learner attempts the diagnosis first.** The answer is collapsed below, not printed above it | short |
| 9 | 🏋️ **Practicals** | 1–3 drills that *change* the build. ⭐ marks must-do. | short |
| 10 | ✅ **Check yourself** | 3–5 questions, answers in a collapsed block | short |
| 11 | 📎 **Cheat sheet** | Everything introduced, in one table | short |
| 12 | 🔗 **Further reading** | Into [`../reference/ReferenceLinks.md`](../reference/ReferenceLinks.md) | short |
| 13 | 💾 **Commit** | The exact commit message to use | 1 line |
| 14 | ➡️ **What's next** | | 1 line |
| 14b | 🪞 **Reflection** | Explain the concept back in your own words. If you cannot, the chapter is not finished | 2 lines |
| 15 | 📝 **Chapter changelog** | | table |

### Path markers ([ADR-024](../meta/Decisions.md#adr-024))

Every chapter serves three paths from one document:

| Path | Who | Reads |
|------|-----|-------|
| 🐣 **A — Absolute Beginner** | New to programming *and* new to 3D | Everything, plus 🐣 *"New to this?"* expansion boxes. Complete code listings, never "add the obvious" |
| 🚶 **B — Self-Learner** | Comfortable coding, new to games and Blender | The full chapter. **This is the learner's path** |
| 🏃 **C — Fast-Track Pro** | Experienced, time-poor | 🏃 Fast-Track Summary + Build steps + cheat sheet. Skips theory debriefs. ⭐ practicals only |

- Chapter front matter and the index below carry tags: `🐣🚶🏃` for everyone, `🚶🏃` where Path A should skip.
- **🐣 boxes** sit inline, at the point of confusion — collapsed, so B and C read past them.
- **🔬 deep dives** are optional depth; Path A skips them.
- **⭐ practicals** are done by every path.

> ⚠️ **The ratios in ADR-002 are measured on the Path B reading** — the full chapter minus 🐣 boxes and the 🏃 summary. Path material *adds*; it never displaces the build.

### The scaffolding gradient ([ADR-033](../meta/Decisions.md#adr-033))

Every chapter declares its guided/independent split, and the ratio shifts across the course:

| Stage | Modules | Guided / Independent |
|-------|---------|---------------------|
| Early | 0–2 | **90 / 10** |
| Intermediate | 3–5 | **70 / 30** |
| Advanced | 6–8 | **50 / 50** |
| Professional | 9–10 | **30 / 70** |
| Capstone | 11–12 | **10 / 90** |

**⬜ Blank-page builds** end every major subsystem: *requirements only — no steps, no reference implementation, no code*. The progression is **guided build → variation → ⬜ blank-page → jam → autopsy**.

> ⚠️ **Under pressure the instinct is always to give more help.** The declared percentage exists so that drift is visible, exactly as [ADR-002](../meta/Decisions.md#adr-002)'s thresholds do for theory creep.

> 🚨 **Before publishing, read the Fast-Track Summary as if it were the only thing on the page.** For 🏃 Path C it *is*. A summary written by condensing a finished chapter reliably drops prerequisites that lived in prose — which is exactly how chapter 0.4 shipped telling the reader to unzip a file it never told them to download ([D-015](../meta/Doubts.md#d-015)).

### The four hard rules

1. **No chapter begins with theory.** If a concept genuinely cannot be built before it is explained, the chapter is wrongly scoped — split it, or find a cruder version that *can* be built first.
2. **Every chapter ends runnable.** If you can't press play, the chapter isn't finished.
3. **Theory is a debrief, never a gate** — and in a Break-it section it arrives only *after* the learner has attempted the diagnosis.
4. **The three-pass spiral** — naive, then correct, then professional. Never all three at once. See [`../Practicals.md §5`](../Practicals.md).

### Why the percentages exist

"Practical-first" is easy to agree with and easy to drift away from. A percentage is checkable; an intention is not. If a chapter's Build section is under half its length, it gets rewritten.

---

## Reading symbols

| Symbol | Meaning |
|--------|---------|
| ⭐ | Must-do — do this one regardless of how rushed you are |
| 🔬 | Optional deep dive — safe to skip on a first pass, come back later |
| 💡 | Insight worth remembering |
| ⚠️ | Something that will bite you |
| 💥 | Break-it exercise |
| 🏋️ | Practical |
| 📱 | Mobile-specific concern ([ADR-010](../meta/Decisions.md#adr-010)) |
| 🧊 | Blender-track content |
| 📖 | First use of a glossary term — see [`../reference/Glossary.md`](../reference/Glossary.md) |
| `[UNVERIFIED]` | I could not run this; you clear it ([ADR-016](../meta/Decisions.md#adr-016)) |

---

## The `[UNVERIFIED]` marker

> 🚨 **Includes every GUI instruction.** Any menu path, panel name, Inspector section, property row or button label is `[UNVERIFIED]` unless a learner screenshot or `toAgent/` paste has confirmed it. This has been got wrong twice ([D-014](../meta/Doubts.md#d-014), [D-017](../meta/Doubts.md#d-017)) for the same reason both times: a UI path *feels* like something the author knows rather than something they are guessing. **Confidence is not evidence.**


I write these chapters from an Ubuntu/Termux session on a phone with **no Godot, no Blender, no .NET and no Android SDK**, and you have instructed that nothing be installed there. So **any claim about what a tool actually prints, or exactly where a menu item sits, is marked `[UNVERIFIED]` until you run it and report back**.

```text
[UNVERIFIED] The export dialog reports "No export template found for the selected platform".
```

You run it → paste the real output into [`../../toAgent/`](../../toAgent/) → I replace the marker with the observed text. Protocol: [`../internal/VerificationRuns.md`](../internal/VerificationRuns.md).

This is deliberate. The alternative is confidently-worded fiction about error messages, which is worse than an honest marker.
