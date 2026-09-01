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

*None yet — Session 001 produced the plan and scaffolding. Chapter 0.1 begins once [`../PLAN.md`](../PLAN.md) is approved ([T-002](../meta/ToDos.md)).*

| # | Chapter | Track | Time | Status |
|---|---------|-------|------|--------|
| — | — | — | — | — |

> 📑 Full chapter list: **[`../TableOfContents.md`](../TableOfContents.md)**
> 📍 Current progress: **[`../meta/CourseState.md`](../meta/CourseState.md)**
> 🏋️ Every hands-on unit, counted: **[`../Practicals.md`](../Practicals.md)**

---

## Naming ([ADR-020](../meta/Decisions.md#adr-020))

```text
ChapterNN_PascalCaseTitle.md
```

`NN` is zero-padded and monotonically increasing across **both** tracks, so **reading order equals file order**. Blender chapters carry their `B`-number in the title, not the filename:

```text
Chapter14_B05_BoxModellingTheCrate.md
```

---

## ⚖️ The mandatory chapter template

Enforced by [**ADR-002 — the Practical-First Mandate**](../meta/Decisions.md#adr-002). Every chapter has these sections, **in this order**, with no exceptions.

| # | Section | Rule | Share |
|---|---------|------|-------|
| — | YAML front matter | chapter number, module, track, time, prerequisites, status | — |
| 1 | `# Chapter NN — Title` | one H1 | — |
| 2 | 🎯 **Goal** | **One sentence**: what will exist at the end that does not exist now | 1 line |
| 3 | 🧭 **Before you start** | Prerequisites, and what you should already have running | short |
| 4 | 🔨 **Build** | **Step-by-step doing. Must be the first substantive section.** Every step is a click, a keystroke or a line of code. | **≥ 50%** |
| 5 | ▶️ **Run it** | What you should see. Screenshot or expected output. **The chapter must end in something runnable.** | short |
| 6 | 🧠 **Why it works** | The theory *this build needed* — and only that | **≤ 30%** |
| 7 | 🗺️ **Mental model** | A Mermaid diagram, wherever a picture beats prose | 1 diagram |
| 8 | 💥 **Break it** | A deliberate sabotage, and the error it produces | short |
| 9 | 🏋️ **Practicals** | 1–3 drills that *change* the build. ⭐ marks must-do. | short |
| 10 | ✅ **Check yourself** | 3–5 questions, answers in a collapsed block | short |
| 11 | 📎 **Cheat sheet** | Everything introduced, in one table | short |
| 12 | 🔗 **Further reading** | Into [`../reference/ReferenceLinks.md`](../reference/ReferenceLinks.md) | short |
| 13 | 💾 **Commit** | The exact commit message to use | 1 line |
| 14 | ➡️ **What's next** | | 1 line |
| 15 | 📝 **Chapter changelog** | | table |

### The four hard rules

1. **No chapter begins with theory.** If a concept genuinely cannot be built before it is explained, the chapter is wrongly scoped — split it, or find a cruder version that *can* be built first.
2. **Every chapter ends runnable.** If you can't press play, the chapter isn't finished.
3. **Theory is a debrief, never a gate.**
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

I write these chapters from an Ubuntu/Termux session on a phone with **no Godot, no Blender, no .NET and no Android SDK**, and you have instructed that nothing be installed there. So **any claim about what a tool actually prints, or exactly where a menu item sits, is marked `[UNVERIFIED]` until you run it and report back**.

```text
[UNVERIFIED] The export dialog reports "No export template found for the selected platform".
```

You run it → paste the real output into [`../../toAgent/`](../../toAgent/) → I replace the marker with the observed text. Protocol: [`../internal/VerificationRuns.md`](../internal/VerificationRuns.md).

This is deliberate. The alternative is confidently-worded fiction about error messages, which is worse than an honest marker.
