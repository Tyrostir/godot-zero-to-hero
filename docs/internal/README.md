---
title: "docs/internal — Internal Working Documents (NOT part of the course)"
document_id: INTERNAL
version: 1.0
status: Active
created: 2026-09-01
last_updated: 2026-09-01
audience: "AI author agents and the learner only — never the end reader"
update_trigger: "When an internal document is added or the tier rules change"
---

# 🔒 docs/internal — Internal Working Documents

> ⛔ **Nothing in this directory is part of the Godot course.**
> These documents exist so that an AI author agent can be replaced mid-project without losing context. They are **operational**, not **educational**.

---

## The three document tiers ([ADR-014](../meta/Decisions.md#adr-014))

| Tier | Location | Audience | Rule |
|------|----------|----------|------|
| 📗 **Tier 1 — Course** | `README.md`, `docs/PLAN.md`, `docs/TableOfContents.md`, `docs/BlenderTrack.md`, `docs/Practicals.md`, `docs/Exercises.md`, `docs/chapters/`, `docs/guides/`, `docs/reference/`, `projects/` | **The end reader.** Anyone who finds this repo. | Describes exactly one setup: a desktop running Godot and Blender, deploying to one Android phone. |
| 📘 **Tier 2 — Bookkeeping** | `docs/meta/` | The learner, and readers curious how the course is made. | Progress, decisions, doubts, todos. **Reader-safe** — no authoring-infrastructure detail. |
| 🔒 **Tier 3 — Internal** | **this directory**, plus `PROMPTS.md` and `toAgent/` at the repo root | **AI agents and the learner only.** | Agent memory, handover, session mechanics, raw prompt logs, learner-captured output. |

---

## Contents

| File | Purpose | Read when |
|------|---------|-----------|
| [`CLAUDE-MEMORY.md`](CLAUDE-MEMORY.md) | **The agent's brain dump.** Everything known about the learner, the environment, the technical facts, the decisions and the operating rules — in one file. | **First. Always.** |
| [`NewAgentOnboardingGuide.md`](NewAgentOnboardingGuide.md) | How a brand-new agent takes over: what to read, in what order, what it may and may not do. | You are a new agent |
| [`NewAgentOnboardingPrompts.md`](NewAgentOnboardingPrompts.md) | Copy-paste prompts **the learner** sends to bootstrap a new agent in one message. | You are the learner, starting a fresh session |
| [`VerificationRuns.md`](VerificationRuns.md) | The `[UNVERIFIED]` clearance protocol: what the learner runs on the desktop, and where results get pasted. | Clearing `[UNVERIFIED]` markers |
| [`../../toAgent/`](../../toAgent) | Raw output the learner captures on the desktop or phone and drops in for the author. | Reading reported results |

---

## The one rule that matters most

> 🚨 **Never let Tier 3 leak into Tier 1.**
>
> The end reader should see a course written for a desktop + phone workflow. The fact that it was *authored* from a Termux session on a phone, with no engine available, adds nothing pedagogically. The one place it legitimately surfaces is the `[UNVERIFIED]` marker — which is presented to the reader as a verification protocol, not as an apology.

---

## 📝 Changelog

| Version | Date | Change |
|---------|------|--------|
| 1.0 | 2026-09-01 | Created at course inception (Session 001), adopting the QNX course's tier model per [ADR-025](../meta/Decisions.md#adr-025). |
