---
title: "docs/meta — Course Bookkeeping"
document_id: META-INDEX
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
update_trigger: "When a meta document is added"
---

# 📘 docs/meta/

**Tier 2 — course bookkeeping** ([ADR-014](Decisions.md#adr-014)). How the course is going, what has been decided, and what you asked. Reader-safe: anyone curious about how this course was made can read all of it.

| File | Purpose | Read when |
|------|---------|-----------|
| [`CourseState.md`](CourseState.md) | **Single source of truth for progress.** Chapter tracker, milestones, skills self-assessment, session log | **First**, after any break |
| [`CompactContext.md`](CompactContext.md) | One dense page that restores full context in ~2 minutes | Starting a new session, or a new AI session |
| [`Decisions.md`](Decisions.md) | The **active** ADRs — how things are | Wondering why the course is shaped this way |
| [`DecisionsLog.md`](DecisionsLog.md) | **Append-only** history — how we got here, what was rejected | Wondering why a decision was made *that* way |
| [`Doubts.md`](Doubts.md) | Every question you've asked, with short and full answers (`D-NNN`) | You have a question, or want to revise |
| [`ToDos.md`](ToDos.md) | Open work items for both of us (`T-NNN`) | Deciding what to do next |
| [`Journal.md`](Journal.md) | Daily learning log — hours, what you looked up, notes to future you | End of every session |

## Identifier schemes

| Prefix | Means | Lives in |
|--------|-------|----------|
| `ADR-NNN` | Architecture Decision Record | `Decisions.md` / `DecisionsLog.md` |
| `D-NNN` | A doubt / question | `Doubts.md` |
| `T-NNN` | A task | `ToDos.md` |
| `P00`–`P10` | A project | [`../../projects/README.md`](../../projects/README.md) |
| `B1`–`B42` | A Blender chapter | [`../BlenderTrack.md`](../BlenderTrack.md) |
| `MJ1`–`MJ4` | A mini-jam | [`../../projects/README.md#mini-jams`](../../projects/README.md#mini-jams) |

None are ever reused, and none are ever deleted.
