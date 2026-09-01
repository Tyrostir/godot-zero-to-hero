---
title: "Doubts — Questions Asked and Answered"
document_id: DOUBTS
version: 1.0
status: Active (living document)
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "Every time the learner asks a question — no exceptions"
---

# Doubts Log

Every confusion gets written down here, immediately, before you try to resolve it. This file is the single most valuable document in the repo, because it is the only one that is genuinely about *you*.

---

## Why this exists

Three reasons, in order of importance:

1. **Writing a question well solves about a third of them.** Forcing yourself to state precisely what you expected and what happened is the debugging technique, not a preamble to it.
2. **It stops confusion compounding.** Chapter 5 assumes chapter 3 landed. If 3.7 was fuzzy and you said nothing, 5.4 will feel impossible for reasons you can no longer locate.
3. **It becomes your revision material.** In six months, the list of things that confused you is a far better study guide than the list of things that didn't.

---

## How to use it

**When you hit confusion:** stop, add a row to *Open* below with status `OPEN`. Takes 30 seconds. Do it *before* you start googling.

**Write it in this shape:**

> **Context:** where you were — chapter, file, line.
> **Expected:** what you thought would happen.
> **Actual:** what happened, with the exact error text if there is one.
> **Tried:** what you already attempted.
> **Guess:** your current best hypothesis, even if you think it's wrong. Especially if you think it's wrong.

The `Guess` field matters more than it looks. Recording a wrong hypothesis and later seeing why it was wrong is how you calibrate.

**When it's answered:** move the row to *Resolved*, write the answer in your own words — not copied from me or from Stack Overflow. If you can't write it in your own words, it isn't resolved yet.

**Ask me** by saying *"answer doubt D-014"* or just describing it. I'll write the answer into this file when you ask me to update the trackers.

---

## Status vocabulary

| Status | Meaning |
|---|---|
| `OPEN` | Written down, not yet investigated |
| `DIGGING` | You're actively working on it |
| `ASKED` | Handed to me / a forum / the docs, awaiting answer |
| `RESOLVED` | Answered *and* you can explain it unprompted |
| `PARKED` | Genuinely not needed yet; revisit at a named later chapter |
| `WONTFIX` | Turned out to be a wrong question. Note *why* — this is often the most instructive kind |

---

## Open

| ID | Date | Ch. | Question (one line) | Status | Notes |
|---|---|---|---|---|---|
| D-002 | 2026-09-01 | 0.2 | Which exact Godot 4.x .NET version, and does that version's Android C# export have known issues? | OPEN | Record answer in the [Setup 01 version log](../guides/Setup_01_Prerequisites.md#3-your-version-log) |
| D-003 | 2026-09-01 | 0.5 | What is my test phone's GPU, RAM, Android version and Vulkan support? | OPEN | Determines Mobile vs Compatibility renderer in ch 4.13 |

*(Add rows here. Never delete a row — move it down to Resolved.)*

---

## Resolved

| ID | Ch. | Question | Answer, in my own words | Resolved on |
|---|---|---|---|---|
| D-001 | 0.1 | Which desktop machine will I build on? | **A Linux desktop.** That settles the whole setup route: the lean command-line Android SDK (~1 GB) instead of Android Studio (~8 GB); OpenJDK 17 from the distribution's packages; and a `udev` rule for `adb` so the phone is visible without `sudo`. Recorded as an amendment to [ADR-004](Decisions.md#adr-004). | 2026-09-01 |
| D-004 | 0.1 | Should the course be written for one path or three? | **Three, all authored in full** — 🐣 Absolute Beginner, 🚶 Self-Learner (mine), 🏃 Fast-Track Pro. Same choice I made on the QNX course, for the same reason: a future reader should be able to enter at any depth. Costs ~1.5–2× the authoring effort per chapter, accepted knowingly. [ADR-024](Decisions.md#adr-024). | 2026-09-01 |

---

## Parked

| ID | Ch. | Question | Revisit at | Why parked |
|---|---|---|---|---|
| — | — | | | |

---

## Recurring themes

Every ~20 doubts, come back and look for patterns. If four of your questions were about coordinate spaces, that isn't four gaps — it's one gap, and it deserves a deliberate re-read of 1.7–1.9 rather than four patches.

| Theme | Doubt IDs | What I did about it |
|---|---|---|
| | | |
